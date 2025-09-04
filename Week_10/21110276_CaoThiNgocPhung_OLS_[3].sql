ALTER PLUGGABLE DATABASE ALL OPEN;
-------------------------------------------------------------------------------------------
---------------------------I. Mot so ky thuat nang cao trong OLS---------------------------
-------------------------------------------------------------------------------------------
--------------1.1. Che giau cot thong tin chinh sach----------------
------------------------------SEC_ADMIN-----------------------------
BEGIN 
    sa_policy_admin.remove_table_policy (
        policy_name   => 'ACCESS_LOCATIONS', 
        schema_name    => 'HR', 
        table_name     => 'LOCATIONS', 
        drop_column    => true); 
END; 

SELECT * 
FROM hr.locations; 
------------------------------SEC_ADMIN-----------------------------
BEGIN 
    sa_policy_admin.apply_table_policy (
        policy_name     => 'ACCESS_LOCATIONS',
        schema_name      => 'HR',
        table_name       => 'LOCATIONS',
        table_options    => 'HIDE,NO_CONTROL'); 
END; 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'CONF'); 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'CONF::US') 
WHERE country_id = 'US'; 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'CONF::UK') 
WHERE country_id = 'UK'; 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'CONF::CA') 
WHERE country_id = 'CA'; 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'CONF:SM:UK,CA') 
WHERE (country_id = 'CA' 
        AND city = 'Toronto') 
        OR 
        (country_id = 'UK' 
        AND city = 'Oxford'); 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'CONF:HR:UK') 
WHERE country_id = 'UK' 
        AND city = 'London'; 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'SENS:HR,SM,FIN:CORP') 
WHERE country_id = 'CH' AND city = 'Geneva'; 
------------------------------SEC_ADMIN-----------------------------
BEGIN 
    sa_policy_admin.remove_table_policy (
        policy_name => 'ACCESS_LOCATIONS', 
        schema_name    => 'HR', 
        table_name     => 'LOCATIONS'
    ); 
    sa_policy_admin.apply_table_policy (
        policy_name     => 'ACCESS_LOCATIONS',
        schema_name     => 'HR', 
        table_name      => 'LOCATIONS', 
        table_options   => 'HIDE,READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL'
    ); 
END;
------------------------------SEC_ADMIN-----------------------------
SELECT * 
FROM hr.locations; 
------------------------------SEC_ADMIN-----------------------------
DESCRIBE hr.locations; 
--------------------------------SKING-------------------------------
SELECT * 
FROM hr.locations 
WHERE city = 'Bern';
--------------------------------SKING-------------------------------
SELECT  label_to_char (ols_column) as label, locations.* 
FROM hr.locations 
WHERE city = 'Bern'; 
----------------------------SYS_ORCLDBP-----------------------------
GRANT select, insert, update ON hr.employees TO sking; 
GRANT select, insert, update ON hr.employees TO sec_admin; 
GRANT create procedure TO sec_admin;
--------------------------------LBASYS-------------------------------
GRANT execute ON to_lbac_data_label TO sec_admin WITH GRANT OPTION; 
------------------------------SEC_ADMIN-----------------------------
CREATE OR REPLACE FUNCTION sec_admin.gen_emp_label
(
    Job VARCHAR2,
    Sal NUMBER
) 
RETURN LBACSYS.LBAC_LABEL AS i_label VARCHAR2(80); 
BEGIN
    /************* Xác ??nh level *************/
    IF Sal > 17000 THEN i_label := 'SENS:';
    ELSIF Sal > 10000 THEN i_label := 'CONF:';
    ELSE i_label := 'PUB:';
    END IF;
    /************* Xác ??nh compartment *************/
    IF Job LIKE '%HR%' THEN i_label := i_label || 'HR:';
    ELSIF Job LIKE '%MK%' OR Job LIKE '%SA%' THEN i_label := i_label || 'SM:';
    ELSIF Job LIKE '%FI%' THEN i_label := i_label || 'FIN:';
    ELSE i_label := i_label || ':';
    END IF;
    /************* Xác ??nh groups *************/
    i_label := i_label || 'CORP';
    RETURN TO_LBAC_DATA_LABEL('ACCESS_LOCATIONS', i_label);
END;
------------------------------SEC_ADMIN-----------------------------
GRANT execute ON sec_admin.gen_emp_label TO lbacsys; 
------------------------------SEC_ADMIN-----------------------------
BEGIN
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
        policy_name   	=> 'ACCESS_LOCATIONS',
        schema_name   	=> 'HR', 
        table_name    	=> 'EMPLOYEES', 
        table_options 	=> 'READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL', 
        label_function => 'sec_admin.gen_emp_label (:new.job_id, :new.salary)',
        PREDICATE => NULL); 
END; 
--------------------------------LBASYS-------------------------------
select * 
from DBA_SA_USERS; 
--------------------------------LBASYS-------------------------------
select * 
from DBA_SA_USER_LEVELS;  
--------------------------------LBASYS-------------------------------
SELECT * 
FROM DBA_SA_USER_COMPARTMENTS;
--------------------------------LBASYS-------------------------------
SELECT * 
FROM DBA_SA_USER_GROUPS;  





 


--------------------------------------------------------------------        
