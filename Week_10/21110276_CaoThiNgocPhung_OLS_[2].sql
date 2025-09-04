ALTER PLUGGABLE DATABASE ALL OPEN;
-------------------------------------------------------------------------------------------
--------------------------------I. Cac loai nhan nguoi dung--------------------------------
-------------------------------------------------------------------------------------------
--------1.1. Gan quyen nguoi dung theo cac thanh phan cua nhan--------
--------------------------------HR_SEC--------------------------------
BEGIN 
    sa_user_admin.set_levels (
        policy_name => 'ACCESS_LOCATIONS', 
        user_name    => 'LDORAN', 
        max_level    => 'CONF', 
        min_level    => 'PUB', 
        def_level    => 'CONF', 
        row_level    => 'CONF'); 
END; 
--------------------------------HR_SEC--------------------------------
BEGIN 
    sa_user_admin.set_compartments (
        policy_name => 'ACCESS_LOCATIONS', 
        user_name    => 'LDORAN', 
        read_comps   => 'SM,HR', 
        write_comps  => 'SM', 
        def_comps    => 'SM', 
        row_comps    => 'SM'); 
END;
--------------------------------HR_SEC--------------------------------
BEGIN 
    sa_user_admin.set_groups (
        policy_name => 'ACCESS_LOCATIONS', 
        user_name    => 'LDORAN', 
        read_groups  => 'UK,CA',
        write_groups => 'UK', 
        def_groups   => 'UK',
        row_groups   => 'UK'); 
END; 
--------------------------------------------------------------------
--------------1.2. Gan quyen nguoi dung theo cac nhan---------------
--------------------------------HR_SEC--------------------------------
BEGIN 
    sa_user_admin.set_user_labels (
        policy_name 	=> 'ACCESS_LOCATIONS', 
        user_name       => 'KPARTNER', 
        max_read_label  => 'SENS:SM,HR:UK,CA', 
        max_write_label => 'SENS:SM:UK', 
        min_write_label => 'CONF', 
        def_label       => 'SENS:SM,HR:UK', 
        row_label       => 'SENS:SM:UK'); 
END; 
--------------------------------------------------------------------
-----------------1.3. Gan cac quyen dat biet------------------------
--------------------------------HR_SEC--------------------------------
BEGIN 
    sa_user_admin.set_user_privs (
        policy_name  => 'ACCESS_LOCATIONS', 
        user_name     => 'SKING',
        PRIVILEGES    => 'FULL'); 
END; 
--------------------------------HR_SEC--------------------------------
BEGIN 
    sa_user_admin.set_user_privs (
        policy_name  => 'ACCESS_LOCATIONS',
        user_name     => 'NKOCHHAR', 
        PRIVILEGES    => 'READ'); 
END; 
--------------------------------------------------------------------

-------------------------------------------------------------------------------------------
---------------------------------II. Ap dung chinh sach OLS--------------------------------
-------------------------------------------------------------------------------------------
------------------2.1. A dung chinh sach cho bang-------------------
------------------------------SEC_ADMIN-----------------------------
BEGIN 
    sa_policy_admin.apply_table_policy (
        policy_name     => 'ACCESS_LOCATIONS', 
        schema_name     => 'HR', 
        table_name      => 'LOCATIONS', 
        table_options   => 'NO_CONTROL'); 
END;
---------------------------------HR---------------------------------
DESCRIBE locations; 
--------------------------------------------------------------------
---------------------2.2. Gán nhãn cho d? li?u ---------------------
---------------------------------HR---------------------------------
GRANT select, insert, update ON locations TO sec_admin; 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'CONF'); 
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
SET ols_column = char_to_label 
('ACCESS_LOCATIONS', 'CONF:SM:UK,CA') 
WHERE (country_id = 'CA' 
        AND city = 'Toronto') 
        OR (country_id = 'UK' 
        AND city = 'Oxford'); 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'CONF:HR:UK') 
WHERE country_id = 'UK' 
        AND city = 'London'; 
------------------------------SEC_ADMIN-----------------------------
UPDATE hr.locations 
SET ols_column = char_to_label ('ACCESS_LOCATIONS', 'SENS:HR,SM,FIN:CORP') 
WHERE country_id = 'CH' 
        AND city = 'Geneva'; 
------------------------------SEC_ADMIN-----------------------------        
BEGIN 
    sa_policy_admin.remove_table_policy (
        policy_name   => 'ACCESS_LOCATIONS', 
        schema_name    => 'HR', 
        table_name     => 'LOCATIONS'); 
    sa_policy_admin.apply_table_policy (
        policy_name    => 'ACCESS_LOCATIONS', 
        schema_name     => 'HR', 
        table_name      => 'LOCATIONS', 
        table_options   =>  'READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL'); 
END; 
--------------------------------------------------------------------















