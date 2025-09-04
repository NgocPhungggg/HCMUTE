
------------------------------------------------------------------------------------
--------------------------------PART I. CREATE TABLE--------------------------------
------------------------------------------------------------------------------------
--------------------------------2.1 Create view Info--------------------------------
------------------------------------------------------------------------------------
CREATE TABLE Info (
    user_id NUMBER PRIMARY KEY,
    username VARCHAR2(50) UNIQUE,
    full_name VARCHAR2(100),
    address VARCHAR2(255),
    phone_number VARCHAR2(15),
    email VARCHAR2(100));
INSERT INTO Info (user_id, username, full_name, address, phone_number, email)
VALUES (1, 'PHUNG_CAO', 'Cao Thi Ngoc Phung', '123 Main St', '0123456789', 'phung@gmail.com');
INSERT INTO Info (user_id, username, full_name, address, phone_number, email)
VALUES (2, 'TIEN_TRAN', 'Tran Van Tien', '456 Oak St', '0987654321', 'tien@gmail.com');
INSERT INTO Info (user_id, username, full_name, address, phone_number, email)
VALUES (3, 'THANH_NGUYEN', 'Nguyen Phu Thanh', '456 Oak St', '0987654321', 'tien@gmail.com');
INSERT INTO Info (user_id, username, full_name, address, phone_number, email)
VALUES (4, 'HAO_NGUYEN', 'Nguyen Van Hao', '456 Oak St', '0987654321', 'tien@gmail.com');
------------------------------------------------------------------------------------
--------------------------------2.1 Create view USERS--------------------------------
------------------------------------------------------------------------------------
CREATE TABLE ADMIN.USERS (
    username VARCHAR2(50) NOT NULL,
    password VARCHAR2(100) NULL,
    PRIMARY KEY (username)
);

------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
--------------------------------PART II. CREATE VIEW--------------------------------
------------------------------------------------------------------------------------
--------------------------2.1 Create view USER_ACCOUNT_INFO-------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW USER_ACCOUNT_INFO AS
SELECT 
    u.USERNAME,
    u.ACCOUNT_STATUS,
    u.LOCK_DATE,
    u.CREATED AS CREATED_DATE,
    u.DEFAULT_TABLESPACE,
    u.TEMPORARY_TABLESPACE,
    q.MAX_BYTES / 1024 / 1024 AS QUOTA_MB,
    u.PROFILE,
    r.GRANTED_ROLE,
    r.ADMIN_OPTION AS ROLE_CAN_BE_GRANTED
FROM 
    DBA_USERS u
LEFT JOIN DBA_TS_QUOTAS q ON u.USERNAME = q.USERNAME
LEFT JOIN DBA_ROLE_PRIVS r ON u.USERNAME = r.GRANTEE
ORDER BY u.USERNAME;

GRANT SELECT ON USER_ACCOUNT_INFO TO PUBLIC;

------------------------------------------------------------------------------------
-------------------------2.2 Create view USER_PRIVILEGES_INFO-----------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW USER_PRIVILEGES_INFO AS
SELECT 
    p.GRANTEE AS USERNAME,
    p.PRIVILEGE,
    p.ADMIN_OPTION AS CANT_GRANT,
    'DIRECT' AS GRANT_TYPE
FROM 
    DBA_SYS_PRIVS p
WHERE 
    p.GRANTEE IN (SELECT USERNAME FROM DBA_USERS)
UNION
SELECT 
    r.GRANTEE AS USERNAME,
    rp.PRIVILEGE,
    rp.ADMIN_OPTION AS CANT_GRANT,
    'THROUGH ROLE' AS GRANT_TYPE
FROM 
    DBA_ROLE_PRIVS r
JOIN DBA_SYS_PRIVS rp ON r.GRANTED_ROLE = rp.GRANTEE
WHERE 
    r.GRANTEE IN (SELECT USERNAME FROM DBA_USERS)
ORDER BY USERNAME;

GRANT SELECT ON USER_PRIVILEGES_INFO TO PUBLIC;

------------------------------------------------------------------------------------
---------------------2.3 Create view USER_OBJECT_PRIVILEGES_INFO--------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW USER_OBJECT_PRIVILEGES_INFO AS
SELECT 
    o.GRANTEE AS USERNAME,
    o.OWNER,
    o.TABLE_NAME,
    o.PRIVILEGE,
    o.GRANTABLE AS CAN_GRANT,
    'DIRECT' AS GRANT_TYPE
FROM 
    DBA_TAB_PRIVS o
WHERE 
    o.GRANTEE IN (SELECT USERNAME FROM DBA_USERS)
UNION
SELECT 
    u.USERNAME,
    o.OWNER,
    o.TABLE_NAME,
    o.PRIVILEGE,
    o.GRANTABLE AS CAN_GRANT,
    'THROUGH ROLE' AS GRANT_TYPE
FROM 
    DBA_USERS u
JOIN DBA_ROLE_PRIVS r ON u.USERNAME = r.GRANTEE
JOIN DBA_TAB_PRIVS o ON r.GRANTED_ROLE = o.GRANTEE
ORDER BY USERNAME;

GRANT SELECT ON USER_OBJECT_PRIVILEGES_INFO TO PUBLIC;

------------------------------------------------------------------------------------
--------------------------2.4 Create view DEFAULT_TABLESPACES-------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW DEFAULT_TABLESPACES AS
SELECT DISTINCT TABLESPACE_NAME
FROM DBA_TABLESPACES
WHERE CONTENTS = 'PERMANENT'
ORDER BY TABLESPACE_NAME;
GRANT SELECT ON DEFAULT_TABLESPACES TO PUBLIC;
------------------------------------------------------------------------------------
--------------------------2.5 Create view TEMPORARY_TABLESPACES-------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW TEMPORARY_TABLESPACES AS
SELECT DISTINCT TABLESPACE_NAME
FROM DBA_TABLESPACES
WHERE CONTENTS = 'TEMPORARY'
ORDER BY TABLESPACE_NAME;
GRANT SELECT ON TEMPORARY_TABLESPACES TO PUBLIC;

------------------------------------------------------------------------------------
--------------------------2.6 Create view ALL_ROLES-------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW ALL_ROLES AS
SELECT DISTINCT ROLE
FROM DBA_ROLES
WHERE ORACLE_MAINTAINED = 'N'
ORDER BY ROLE;
GRANT SELECT ON ALL_ROLES TO PUBLIC;

------------------------------------------------------------------------------------
-----------------------------2.7 Create view PROFILE_INFO---------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW PROFILE_INFO AS   
SELECT p.PROFILE, P.RESOURCE_NAME, p.LIMIT
FROM DBA_PROFILES p
ORDER BY p.PROFILE;

------------------------------------------------------------------------------------
-----------------------------2.8 Create view LIST_PROFILE---------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW LIST_PROFILE AS  
SELECT DISTINCT 
    u.USERNAME,
    p.PROFILE
FROM 
    DBA_PROFILES p
LEFT JOIN DBA_USERS u 
    ON u.PROFILE = p.PROFILE
ORDER BY 
    u.USERNAME;


------------------------------------------------------------------------------------
------------------------2.9 Create view SYSTEM_PRIVILEGES_VIEW----------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW SYSTEM_PRIVILEGES_VIEW AS
SELECT 
    grantee AS user_or_role,
    privilege AS privilege_name,
    admin_option,
    created
FROM 
    dba_sys_privs sp
JOIN 
    dba_users u ON sp.grantee = u.username
WHERE 
    u.created >= TO_DATE('06-12-2024', 'DD-MM-YYYY');

------------------------------------------------------------------------------------
------------------------2.10 Create view OBJECT_PRIVILEGES_VIEW----------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW OBJECT_PRIVILEGES_VIEW AS
SELECT 
    grantee AS user_or_role,
    table_name || ' (' || privilege || ')' AS privilege_name,
    owner AS table_owner,
    grantable AS admin_option,
    created
FROM 
    dba_tab_privs tp
JOIN 
    dba_users u ON tp.grantee = u.username
WHERE 
    u.created >= TO_DATE('06-12-2024', 'DD-MM-YYYY');


------------------------------------------------------------------------------------
-------------------------2.11 Create view ROLE_PRIVILEGES_VIEW-----------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW ROLE_PRIVILEGES_VIEW AS
SELECT 
    r.role AS role_name,
    rp.privilege AS privilege_name,
    'SYSTEM PRIVILEGE' AS privilege_type
FROM 
    role_sys_privs rp
JOIN 
    dba_roles r ON rp.role = r.role
UNION ALL
SELECT 
    r.role AS role_name,
    tp.table_name || ' (' || tp.privilege || ')' AS privilege_name,
    'OBJECT PRIVILEGE' AS privilege_type
FROM 
    role_tab_privs tp
JOIN 
    dba_roles r ON tp.role = r.role;

------------------------------------------------------------------------------------
----------------------2.12 Create view USER_ROLE_ASSIGNMENTS_VIEW---------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW USER_ROLE_ASSIGNMENTS_VIEW AS
SELECT 
    drp.grantee AS user_or_role,
    drp.granted_role AS role_name,
    drp.admin_option,
    u.created
FROM 
    dba_role_privs drp
JOIN 
    dba_users u ON drp.grantee = u.username
WHERE 
    u.created >= TO_DATE('06-12-2024', 'DD-MM-YYYY');

------------------------------------------------------------------------------------
----------------------2.13 Create view USER_ROLE_ASSIGNMENTS_VIEW--------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW All_User AS
SELECT DISTINCT
    USERNAME
FROM
    DBA_USERS
WHERE
    CREATED >= TO_DATE('06-12-2024', 'DD-MM-YYYY');
