ALTER PLUGGABLE DATABASE ALL OPEN;
-------------------------------------------------------------------------------------------
--------------------------------------Cau 1: Tao user--------------------------------------
-------------------------------------------------------------------------------------------
--------------------------------Cau 1a:--------------------------------
------------------------------SYS_ORCLPDB------------------------------
CREATE USER Phung IDENTIFIED BY phung;
GRANT CREATE SESSION TO Phung;
--------------------------------Cau 1b:--------------------------------
------------------------------SYS_ORCLPDB------------------------------
ALTER USER Phung DEFAULT TABLESPACE users;
ALTER USER Phung QUOTA 10M ON users;
GRANT CREATE TABLE TO Phung;
--------------------------------Cau 2a-h:--------------------------------
------------------------------SYS_ORCLPDB------------------------------
CREATE PROFILE PhungProfile LIMIT
  SESSIONS_PER_USER 5
  CONNECT_TIME 3 
  IDLE_TIME 3
  PASSWORD_LIFE_TIME 5/1440
  PASSWORD_GRACE_TIME 5/1440
  PASSWORD_REUSE_TIME 2
  PASSWORD_REUSE_MAX 3
  FAILED_LOGIN_ATTEMPTS 3; 
--------------------------------Cau 2j:--------------------------------
------------------------------SYS_ORCLPDB------------------------------
ALTER USER Phung PROFILE PhungProfile;

SELECT username, profile 
FROM dba_users 
WHERE username = 'PHUNG';

--------------------------------Cau 3:--------------------------------
------------------------------SYS_ORCLPDB------------------------------
CREATE USER PhungAdmin IDENTIFIED BY phungadmin;
GRANT CREATE SESSION TO PhungAdmin;

GRANT ALTER PROFILE, CREATE PROFILE, ALTER USER, CREATE USER, DROP USER TO PhungAdmin;
GRANT CREATE ANY PROCEDURE TO PhungAdmin;
GRANT EXECUTE ON DBMS_RLS TO PhungAdmin;

SELECT * 
FROM dba_sys_privs 
WHERE grantee = 'PHUNGADMIN';

--------------------------------Cau 4:--------------------------------
---------------------------------PHUNG--------------------------------
CREATE TABLE Emp (
    EmpNo NUMBER(5),
    Name VARCHAR2(60),
    HireDate DATE
);
---------------------------------PHUNG--------------------------------
INSERT INTO Phung.Emp (EmpNo, Name, HireDate)
VALUES (1, 'PHUNG', TO_DATE('02/01/2010', 'DD/MM/YYYY'));
INSERT INTO Phung.Emp (EmpNo, Name, HireDate)
VALUES (2, 'CHAU', TO_DATE('12/05/2010', 'DD/MM/YYYY'));
INSERT INTO Phung.Emp (EmpNo, Name, HireDate)
VALUES (3, 'KHANH', TO_DATE('26/08/2009', 'DD/MM/YYYY'));
SELECT *
FROM Emp 

--------------------------------Cau 4a-c:--------------------------------
------------------------------SYS_ORCLPDB------------------------------
CREATE USER CHAU IDENTIFIED BY chau;
GRANT CREATE SESSION TO CHAU;
CREATE USER KHANH IDENTIFIED BY khanh;
GRANT CREATE SESSION TO KHANH;

GRANT SELECT ON Phung.Emp TO KHANH; 
GRANT SELECT, UPDATE ON Phung.Emp TO CHAU;
GRANT SELECT, UPDATE ON Phung.Emp TO KHANH;

-----Cao Th? Ng?c Ph?ng 21110276
SELECT *
FROM user_policies
WHERE object_name = 'EMP';

CREATE OR REPLACE FUNCTION Phung.QuanLyUser_select (
    schema_name IN VARCHAR2, 
    table_name IN VARCHAR2
) RETURN VARCHAR2 IS
    v_predicate VARCHAR2(4000);
BEGIN
    IF USER = 'PHUNG' THEN
        v_predicate := '1=1';
    ELSIF USER = 'CHAU' THEN
        v_predicate := 'Name = ''CHAU''';
    ELSIF USER = 'KHANH' THEN
        v_predicate := 'Name = ''KHANH''';
    ELSE
        v_predicate := '1=0';
    END IF;
    RETURN v_predicate;
END;

BEGIN
    DBMS_RLS.DROP_POLICY(
        object_schema   => 'Phung',                
        object_name     => 'Emp',                  
        policy_name     => 'QuanLyUserPolicySelect'
    );
END;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'Phung',
        object_name     => 'Emp',
        policy_name     => 'QuanLyUserPolicySelect',
        function_schema => 'Phung',
        policy_function => 'QuanLyUser_select',
        statement_types => 'SELECT'
    );
END;
-----Cao Th? Ng?c Ph?ng 21110276
CREATE OR REPLACE FUNCTION Phung.QuanLyUser_update (
    schema_name IN VARCHAR2, 
    table_name IN VARCHAR2
) RETURN VARCHAR2 IS
    v_predicate VARCHAR2(4000);
BEGIN
    IF USER = 'PHUNG' THEN
        v_predicate := '1=1';
    ELSIF USER = 'CHAU' THEN
        v_predicate := 'Name = ''CHAU''';
    ELSIF USER = 'KHANH' THEN
        v_predicate := '1=0';
    ELSE
        v_predicate := '1=0';
    END IF;

    RETURN v_predicate;
END;
-----Cao Th? Ng?c Ph?ng 21110276

BEGIN
    DBMS_RLS.DROP_POLICY(
        object_schema   => 'Phung',                
        object_name     => 'Emp',                  
        policy_name     => 'QuanLyUserPolicyUpdate'
    );
END;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'Phung',
        object_name     => 'Emp',
        policy_name     => 'QuanLyUserPolicyUpdate',
        function_schema => 'Phung',
        policy_function => 'QuanLyUser_update',
        statement_types => 'UPDATE'
    );
END;

SELECT *
FROM Phung.Emp 
-----Cao Th? Ng?c Ph?ng 21110276

UPDATE Phung.Emp
SET HireDate = TO_DATE('02/01/2020', 'DD/MM/YYYY')
WHERE Name = 'PHUNG';
UPDATE Phung.Emp
SET HireDate = TO_DATE('02/01/2020', 'DD/MM/YYYY')
WHERE Name = 'CHAU';
UPDATE Phung.Emp
SET HireDate = TO_DATE('02/01/2020', 'DD/MM/YYYY')
WHERE Name = 'KHANH';
-----Cao Th? Ng?c Ph?ng 21110276


