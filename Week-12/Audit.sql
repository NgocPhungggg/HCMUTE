ALTER PLUGGABLE DATABASE ALL OPEN;
----------------------A. L� thuy?t----------------------
---------- II. Qu?n l� Standard Audit Trail ----------
----------- 1. K�ch ho?t Standard Auditing -----------
SHOW PARAMETER AUDIT; 
------- k�ch ho?t ch?c n?ng gi�m s�t
ALTER SESSION SET CONTAINER = CDB$ROOT;
ALTER SYSTEM SET audit_trail = db SCOPE = SPFILE; 
SHUTDOWN IMMEDIATE; 
STARTUP MOUNT; 
 
----------------------B. Th?c h�nh----------------------
------1. Gi�m s�t c�u l?nh SQL li�n quan ??n ROLE 
AUDIT ROLE; 

CREATE ROLE test;  

AUDIT ROLE WHENEVER SUCCESSFUL; 

SELECT username, 
TIMESTAMP, obj_name, action_name  
FROM dba_audit_trail 
WHERE username = 'SEC_MGR';  

AUDIT ROLE WHENEVER SUCCESSFUL; 

------2. Gi�m s�t c�u l?nh SQL select v� update 
AUDIT SELECT TABLE, UPDATE TABLE;

AUDIT SELECT TABLE, UPDATE TABLE BY hr; 

------3. Gi�m s�t quy?n x�a b?ng  
AUDIT DELETE ANY TABLE; 

------4. Gi�m s�t quy?n li�n quan t?i Directories 
AUDIT CREATE ANY DIRECTORY;

AUDIT DIRECTORY; 

CREATE OR REPLACE DIRECTORY ngocphung_week12 AS 'W:\Oracle\DBSE_Database_Security';
AUDIT READ ON DIRECTORY ngocphung_week12; 

------5. Gi�m s�t truy v?n tr�n b?ng 
AUDIT SELECT ON hr.employees; 

AUDIT SELECT ON hr.employees 
WHENEVER NOT SUCCESSFUL; 

------6. Gi�m s�t insert v� update tr�n b?ng 
AUDIT INSERT, UPDATE ON hr.customers; 

------7. Thi?t l?p m?c ??nh cho l?a ch?n gi�m s�t ??i t??ng 
AUDIT ALTER, GRANT, INSERT, UPDATE, DELETE 
ON DEFAULT; 

------8. T?t gi�m s�t 
NOAUDIT ALL;  

NOAUDIT ALL PRIVILEGES; 

NOAUDIT SELECT ON hr.employees; 
NOAUDIT INSERT, UPDATE ON hr.customers; 


--------------------IV. B�i t?p--------------------
------1. T?o user m?i v?i username l� audit_test. 
CREATE USER audit_test IDENTIFIED BY audittest; 
GRANT CREATE TABLE TO audit_test;
GRANT CREATE PROCEDURE TO audit_test;
GRANT CREATE SESSION TO audit_test;
ALTER USER audit_test QUOTA 100M ON USERS;

------2. Th?c hi?n gi�m s�t 
AUDIT SELECT ON DEFAULT;
AUDIT INSERT ON DEFAULT;
AUDIT UPDATE ON DEFAULT;
AUDIT DELETE ON DEFAULT;

------3. ??ng nh?p v�o t�i kho?n user audit_test. 
------3.a T?o b?ng t�n TAB (b?ng TAB ch? c� m?t c?t ID c� ki?u l� NUMBER) 
CREATE TABLE TAB (ID NUMBER);
------3.b Insert gi� tr? v�o b?ng TAB. 
INSERT INTO TAB VALUES (1);
------3.c Update gi� tr? v?a insert v�o. 
UPDATE TAB SET ID = 2 WHERE ID = 1;
------3.d Xem t?t c? d? li?u c?a b?ng TAB. 
SELECT * FROM TAB;
------3.e X�a t?t c? d? li?u trong b?ng TAB. 
DELETE FROM TAB;
------4.f X�a b?ng TAB. 
DROP TABLE TAB;


------4. ??ng nh?p v�o user system, ki?m tra nh?ng h�nh vi n�o ???c gi�m s�t l?i.
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
