ALTER PLUGGABLE DATABASE ALL OPEN;
GRANT CREATE TABLE TO LBACSYS;
-------------------------------------------------------------------------------------------
------------------------------------------Bai tap------------------------------------------
-------------------------------------------------------------------------------------------
-----------------------------Tao bang CUSTOMER-----------------------------
------------------------------LBACSYS_ORCLPDB------------------------------
CREATE TABLE CUSTOMERS (
    id            NUMBER(10) NOT NULL,
    cust_type     VARCHAR2(10),
    first_name    VARCHAR2(30),
    last_name     VARCHAR2(30),
    region        VARCHAR2(5),
    credit        NUMBER(10,2),
    CONSTRAINT customer_pk PRIMARY KEY (id),
    CONSTRAINT customer_cust_type_ck CHECK (cust_type IN ('silver', 'gold', 'platinum')),
    CONSTRAINT customer_region_ck CHECK (region IN ('north', 'west', 'east', 'south'))
);
--------------------5.1 Chen du lieu vao bang CUSTOMERS--------------------
------------------------------LBACSYS_ORCLPDB------------------------------
INSERT INTO CUSTOMERS (id, cust_type, first_name, last_name, region, credit)
VALUES (1, 'silver', 'John', 'Doe', 'north', 3000);
INSERT INTO CUSTOMERS (id, cust_type, first_name, last_name, region, credit)
VALUES (2, 'gold', 'Jane', 'Smith', 'west', 1500);
INSERT INTO CUSTOMERS (id, cust_type, first_name, last_name, region, credit)
VALUES (3, 'platinum', 'Emily', 'Johnson', 'east', 400);
-----Cao Th? Ng?c Ph?ng 21110276

-------------------------5.2 Tao chinh sach bao mat------------------------
------------------Bo qua neu da thuc hien o lab truoc----------------------
------------------------------LBACSYS_ORCLPDB------------------------------
BEGIN
    SA_SYSDBA.CREATE_POLICY(
        policy_name => 'region_policy',  
        column_name => 'region_label' 
    );
END;
----------------5.3 Gán nhãn b?o m?t cho các hàng trong b?ng---------------
------------------------------LBACSYS_ORCLPDB------------------------------
ALTER TABLE CUSTOMERS ADD region_label VARCHAR2(100);
UPDATE CUSTOMERS
SET region_label = 'SENS:SM:NORTH'
WHERE region = 'north';
UPDATE CUSTOMERS
SET region_label = 'SENS:SM:WEST'
WHERE region = 'west';
UPDATE CUSTOMERS
SET region_label = 'SENS:SM:EAST'
WHERE region = 'east';
------------------------------5.4 Tao cac user-----------------------------
--------------------------------SYS_ORCLPDB--------------------------------
CREATE USER sales_north IDENTIFIED BY salesnorth;
CREATE USER sales_west IDENTIFIED BY saleswest;
CREATE USER sales_east IDENTIFIED BY saleseast;
CREATE USER sales_south IDENTIFIED BY salessouth;
GRANT CONNECT TO sales_north;
GRANT CONNECT TO sales_west;
GRANT CONNECT TO sales_east;
GRANT CONNECT TO sales_south;
GRANT CREATE SESSION TO sales_north;
GRANT CREATE SESSION TO sales_west;
GRANT CREATE SESSION TO sales_east;
GRANT CREATE SESSION TO sales_south;
----------------------------5.5 gan nhan cho user--------------------------
------------------------------LBACSYS_ORCLPDB------------------------------
BEGIN 
    SA_USER_ADMIN.SET_USER_LABELS (
        policy_name     => 'region_policy',
        user_name       => 'sales_north',
        max_read_label  => 'L1:MN:RN',
        max_write_label => 'L1:MN:RN',
        min_write_label => 'L1',
        def_label       => 'L1:MN:RN',
        row_label       => 'L1:MN:RN'
    ); 
END;
BEGIN 
    SA_USER_ADMIN.SET_USER_LABELS (
        policy_name     => 'region_policy',
        user_name       => 'sales_south',
        max_read_label  => 'L1:MN:RS',
        max_write_label => 'L1:MN:RS',
        min_write_label => 'L1',           
        def_label       => 'L1:MN:RS',     
        row_label       => 'L1:MN:RS'      
    ); 
END;
BEGIN 
    SA_USER_ADMIN.SET_USER_LABELS (
        policy_name     => 'region_policy',
        user_name       => 'sales_east',
        max_read_label  => 'L1:MN:RE', 
        max_write_label => 'L1:MN:RE',
        min_write_label => 'L1',           
        def_label       => 'L1:MN:RE',     
        row_label       => 'L1:MN:RE'      
    ); 
END;
BEGIN 
    SA_USER_ADMIN.SET_USER_LABELS (
        policy_name     => 'region_policy',
        user_name       => 'sales_west',
        max_read_label  => 'L1:MN:RW',
        max_write_label => 'L1:MN:RW',
        min_write_label => 'L1',           
        def_label       => 'L1:MN:RW',     
        row_label       => 'L1:MN:RW'      
    ); 
END;
-----Cao Th? Ng?c Ph?ng 21110276




