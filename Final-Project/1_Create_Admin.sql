------------------------------------------------------------------------------------
----------------------------------USING SYSORCLBDP----------------------------------
------------------------------------------------------------------------------------
CREATE USER ADMIN IDENTIFIED BY admin;
grant dba to ADMIN with admin option;
GRANT CREATE ANY VIEW TO ADMIN;
GRANT GRANT ANY PRIVILEGE TO ADMIN with admin option;
GRANT SELECT ANY DICTIONARY TO ADMIN with admin option;
------------------------------------------------------------------------------------
-------------------------------------USING SYS -------------------------------------
------------------------------------------------------------------------------------
CREATE TABLESPACE MGRS
    DATAFILE 'S:\Works\OracleBase\oradata\ORCL\orclpdb\MGRS01.DBF' 
    SIZE 20M 
    AUTOEXTEND ON NEXT 10M MAXSIZE UNLIMITED;

AUDIT SELECT TABLE, UPDATE TABLE, INSERT TABLE, DELETE TABLE BY ADMIN;


select username, timestamp, obj_name, action_name from dba_audit_trail where obj_name in ('INFO', 'USERS')