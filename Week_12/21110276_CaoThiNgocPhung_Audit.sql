ALTER PLUGGABLE DATABASE ALL OPEN;
----------------------A. Lý thuy?t----------------------
---------- II. Qu?n lí Standard Audit Trail ----------
----------- 1. Kích ho?t Standard Auditing -----------
SHOW PARAMETER AUDIT; 
------- kích ho?t ch?c n?ng giám sát
ALTER SESSION SET CONTAINER = CDB$ROOT;
ALTER SYSTEM SET audit_trail = db SCOPE = SPFILE; 
SHUTDOWN IMMEDIATE; 
STARTUP MOUNT; 
 
----------------------B. Th?c hành----------------------
------1. Giám sát câu l?nh SQL liên quan ??n ROLE 
AUDIT ROLE; 

CREATE ROLE test;  

AUDIT ROLE WHENEVER SUCCESSFUL; 

SELECT username, 
TIMESTAMP, obj_name, action_name  
FROM dba_audit_trail 
WHERE username = 'SEC_MGR';  

AUDIT ROLE WHENEVER SUCCESSFUL; 

------2. Giám sát câu l?nh SQL select và update 
AUDIT SELECT TABLE, UPDATE TABLE;

AUDIT SELECT TABLE, UPDATE TABLE BY hr; 

------3. Giám sát quy?n xóa b?ng  
AUDIT DELETE ANY TABLE; 

------4. Giám sát quy?n liên quan t?i Directories 
AUDIT CREATE ANY DIRECTORY;

AUDIT DIRECTORY; 

CREATE OR REPLACE DIRECTORY ngocphung_week12 AS 'W:\Oracle\DBSE_Database_Security';
AUDIT READ ON DIRECTORY ngocphung_week12; 

------5. Giám sát truy v?n trên b?ng 
AUDIT SELECT ON hr.employees; 

AUDIT SELECT ON hr.employees 
WHENEVER NOT SUCCESSFUL; 

------6. Giám sát insert và update trên b?ng 
AUDIT INSERT, UPDATE ON hr.customers; 

------7. Thi?t l?p m?c ??nh cho l?a ch?n giám sát ??i t??ng 
AUDIT ALTER, GRANT, INSERT, UPDATE, DELETE 
ON DEFAULT; 

------8. T?t giám sát 
NOAUDIT ALL;  

NOAUDIT ALL PRIVILEGES; 

NOAUDIT SELECT ON hr.employees; 
NOAUDIT INSERT, UPDATE ON hr.customers; 


--------------------IV. Bài t?p--------------------
------1. T?o user m?i v?i username là audit_test. 
CREATE USER audit_test IDENTIFIED BY audittest; 
GRANT CREATE TABLE TO audit_test;
GRANT CREATE PROCEDURE TO audit_test;
GRANT CREATE SESSION TO audit_test;
ALTER USER audit_test QUOTA 100M ON USERS;

------2. Th?c hi?n giám sát 
AUDIT SELECT ON DEFAULT;
AUDIT INSERT ON DEFAULT;
AUDIT UPDATE ON DEFAULT;
AUDIT DELETE ON DEFAULT;

------3. ??ng nh?p vào tài kho?n user audit_test. 
------3.a T?o b?ng tên TAB (b?ng TAB ch? có m?t c?t ID có ki?u là NUMBER) 
CREATE TABLE TAB (ID NUMBER);
------3.b Insert giá tr? vào b?ng TAB. 
INSERT INTO TAB VALUES (1);
------3.c Update giá tr? v?a insert vào. 
UPDATE TAB SET ID = 2 WHERE ID = 1;
------3.d Xem t?t c? d? li?u c?a b?ng TAB. 
SELECT * FROM TAB;
------3.e Xóa t?t c? d? li?u trong b?ng TAB. 
DELETE FROM TAB;
------4.f Xóa b?ng TAB. 
DROP TABLE TAB;


------4. ??ng nh?p vào user system, ki?m tra nh?ng hành vi nào ???c giám sát l?i.
SELECT USERNAME,TIMESTAMP,OWNER,OBJ_NAME,ACTION_NAME
from dba_audit_trail 
WHERE OWNER ='AUDIT_TEST'


CREATE TABLE TAB (ID NUMBER);
DROP TABLE TAB;

SELECT USERNAME,TIMESTAMP,OWNER,OBJ_NAME,ACTION_NAME
from dba_audit_trail 
WHERE OWNER ='AUDIT_TEST'

---- Cao Thi Ngoc Phung 21110276

AUDIT DROP ANY TABLE;

SELECT USERNAME, TIMESTAMP, ACTION_NAME, OBJ_NAME
FROM DBA_AUDIT_TRAIL
WHERE USERNAME = 'AUDIT_TEST';

SELECT USERNAME,TIMESTAMP,OWNER,OBJ_NAME,ACTION_NAME
from dba_audit_trail 
WHERE OWNER ='AUDIT_TEST'

---- Cao Thi Ngoc Phung 21110276
