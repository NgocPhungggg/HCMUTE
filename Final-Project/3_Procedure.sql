------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
------------------------------PART IV. CREATE PROCEDURE-----------------------------
------------------------------------------------------------------------------------
--------------------------4.1 Create procedure ManageProfile---------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE ManageProfile (
    p_action IN VARCHAR2,
    p_profile_name IN VARCHAR2,
    p_sessions_per_user IN VARCHAR2 DEFAULT NULL,
    p_connect_time IN VARCHAR2 DEFAULT NULL,
    p_idle_time IN VARCHAR2 DEFAULT NULL
) AUTHID CURRENT_USER AS
BEGIN
    -- Start the transaction
    SAVEPOINT start_transaction;

    BEGIN
        IF p_action = 'CREATE' THEN
            EXECUTE IMMEDIATE 'CREATE PROFILE ' || p_profile_name || ' LIMIT ' ||
                'SESSIONS_PER_USER ' || 
                CASE WHEN p_sessions_per_user IS NOT NULL THEN p_sessions_per_user ELSE 'DEFAULT' END || ' ' ||
                'CONNECT_TIME ' || 
                CASE WHEN p_connect_time IS NOT NULL THEN p_connect_time ELSE 'DEFAULT' END || ' ' ||
                'IDLE_TIME ' || 
                CASE WHEN p_idle_time IS NOT NULL THEN p_idle_time ELSE 'DEFAULT' END;
        ELSIF p_action = 'ALTER' THEN
            EXECUTE IMMEDIATE 'ALTER PROFILE ' || p_profile_name || ' LIMIT ' ||
                'SESSIONS_PER_USER ' || 
                CASE WHEN p_sessions_per_user IS NOT NULL THEN p_sessions_per_user ELSE 'DEFAULT' END || ' ' ||
                'CONNECT_TIME ' || 
                CASE WHEN p_connect_time IS NOT NULL THEN p_connect_time ELSE 'DEFAULT' END || ' ' ||
                'IDLE_TIME ' || 
                CASE WHEN p_idle_time IS NOT NULL THEN p_idle_time ELSE 'DEFAULT' END;
        ELSIF p_action = 'DROP' THEN
            EXECUTE IMMEDIATE 'DROP PROFILE ' || p_profile_name || ' CASCADE';
        ELSE
            RAISE_APPLICATION_ERROR(-20001, 'Invalid action.');
        END IF;

        -- Commit the transaction
        COMMIT;
    EXCEPTION
        WHEN OTHERS THEN
            -- Rollback to the savepoint in case of an error
            ROLLBACK TO start_transaction;
            RAISE;
    END;
END;

------------------------------------------------------------------------------------
--------------------------4.2 Create procedure ManageUser---------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE ManageUser (
    p_action IN VARCHAR2,
    p_username IN VARCHAR2,
    p_password IN VARCHAR2 DEFAULT NULL,
    p_default_tablespace IN VARCHAR2 DEFAULT NULL,
    p_temporary_tablespace IN VARCHAR2 DEFAULT NULL,
    p_quota IN VARCHAR2 DEFAULT NULL,
    p_account_status IN VARCHAR2 DEFAULT 'UNLOCK',
    p_profile IN VARCHAR2 DEFAULT NULL,
    p_role IN VARCHAR2 DEFAULT NULL
) AUTHID CURRENT_USER AS
BEGIN
    IF p_action = 'CREATE' THEN
        IF p_username IS NULL THEN
            RAISE_APPLICATION_ERROR(-20001, 'Username is required for creating a user.');
        END IF;
        
        EXECUTE IMMEDIATE 'CREATE USER ' || p_username || CASE WHEN p_password IS NOT NULL THEN ' IDENTIFIED BY ' || p_password ELSE '' END || ' ACCOUNT ' || p_account_status;
        
        IF p_default_tablespace IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' DEFAULT TABLESPACE ' || p_default_tablespace;
        END IF;
        
        IF p_temporary_tablespace IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' TEMPORARY TABLESPACE ' || p_temporary_tablespace;
        END IF;
        
        IF p_quota IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' QUOTA ' || p_quota || ' ON ' || p_default_tablespace;
        END IF;
        
        IF p_profile IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' PROFILE ' || p_profile;
        END IF;
        
        IF p_role IS NOT NULL THEN
            EXECUTE IMMEDIATE 'GRANT ' || p_role || ' TO ' || p_username;
        END IF;
        
    ELSIF p_action = 'ALTER' THEN
        IF p_username IS NULL THEN
            RAISE_APPLICATION_ERROR(-20002, 'Username is required for altering a user.');
        END IF;
        
        IF p_password IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' IDENTIFIED BY ' || p_password;
        END IF;
        
        IF p_default_tablespace IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' DEFAULT TABLESPACE ' || p_default_tablespace;
        END IF;
        
        IF p_temporary_tablespace IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' TEMPORARY TABLESPACE ' || p_temporary_tablespace;
        END IF;

        IF p_quota IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' QUOTA ' || p_quota || ' ON ' || p_default_tablespace;
        END IF;
        
        IF p_account_status IS NOT NULL THEN
            IF p_account_status = 'LOCK' THEN
                EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' ACCOUNT LOCK';
            ELSIF p_account_status = 'UNLOCK' THEN
                EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' ACCOUNT UNLOCK';
            END IF;
        END IF;
        
        IF p_profile IS NOT NULL THEN
            EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' PROFILE ' || p_profile;
        END IF;
        
        IF p_role IS NOT NULL THEN
            EXECUTE IMMEDIATE 'GRANT ' || p_role || ' TO ' || p_username;
        END IF;
        
    ELSIF p_action = 'DROP' THEN
        IF p_username IS NULL THEN
            RAISE_APPLICATION_ERROR(-20003, 'Username is required for dropping a user.');
        END IF;
        
        EXECUTE IMMEDIATE 'DROP USER ' || p_username || ' CASCADE';
    ELSE
        RAISE_APPLICATION_ERROR(-20004, 'Invalid action. Use CREATE, ALTER, or DROP.');
    END IF;

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;

------------------------------------------------------------------------------------
--------------------------4.3 Create procedure Manage_Role---------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE Manage_Role (
    p_action      IN VARCHAR2,        -- 'CREATE', 'DROP', hoặc 'ALTER'
    p_role_name   IN VARCHAR2,        -- Tên role
    p_password    IN VARCHAR2 DEFAULT NULL -- Password (chỉ áp dụng cho 'CREATE' và 'ALTER')
)
AUTHID CURRENT_USER -- Sử dụng quyền của user thực thi
IS
    v_count NUMBER;
BEGIN
    -- Kiểm tra trạng thái role
    SELECT COUNT(*)
    INTO v_count
    FROM DBA_ROLES
    WHERE ROLE = UPPER(p_role_name);


    -- Xử lý hành động
    IF UPPER(p_action) = 'CREATE' THEN
        IF v_count > 0 THEN
            -- Role đã tồn tại
            RAISE_APPLICATION_ERROR(-20001, 'Role "' || p_role_name || '" already exists.');
        ELSE
            -- Tạo role
            IF p_password IS NOT NULL THEN
                EXECUTE IMMEDIATE 'CREATE ROLE ' || p_role_name || ' IDENTIFIED BY ' || p_password;
            ELSE
                EXECUTE IMMEDIATE 'CREATE ROLE ' || p_role_name;
            END IF;
        END IF;


    ELSIF UPPER(p_action) = 'DROP' THEN
        IF v_count = 0 THEN
            -- Role không tồn tại
            RAISE_APPLICATION_ERROR(-20002, 'Role "' || p_role_name || '" does not exist.');
        ELSE
            -- Xóa role
            EXECUTE IMMEDIATE 'DROP ROLE ' || p_role_name;
        END IF;


    ELSIF UPPER(p_action) = 'ALTER' THEN
        IF v_count = 0 THEN
            -- Role không tồn tại
            RAISE_APPLICATION_ERROR(-20003, 'Role "' || p_role_name || '" does not exist.');
        ELSE
            -- Thay đổi password role
            IF p_password IS NOT NULL THEN
                EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role_name || ' IDENTIFIED BY ' || p_password;
            ELSE
                RAISE_APPLICATION_ERROR(-20004, 'Password is required to alter the role.');
            END IF;
        END IF;


    ELSE
        -- Hành động không hợp lệ
        RAISE_APPLICATION_ERROR(-20005, 'Invalid action. Use CREATE, DROP, or ALTER.');
    END IF;
END;



------------------------------------------------------------------------------------
-----------------------4.4 Create procedure GRANT_REVOKE_Roles----------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE GRANT_REVOKE_Roles (
    p_action       IN VARCHAR2,        -- 'GRANT' hoặc 'REVOKE'
    p_role_name    IN VARCHAR2,        -- Tên role
    p_user_name    IN VARCHAR2,        -- Tên user nhận role
    p_with_option  IN BOOLEAN DEFAULT FALSE -- TRUE: WITH ADMIN OPTION (chỉ GRANT)
)
AUTHID CURRENT_USER -- Thực thi với quyền user hiện tại
IS
    v_sql     VARCHAR2(4000); -- Câu lệnh SQL
    v_exists  NUMBER;         -- Biến kiểm tra tồn tại
BEGIN
    -- Kiểm tra quyền của người gọi
    SELECT COUNT(*)
    INTO v_exists
    FROM SESSION_PRIVS
    WHERE PRIVILEGE = 'GRANT ANY ROLE';


    IF v_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20002, 'You do not have the privilege "GRANT ANY ROLE" to perform this action.');
    END IF;


    -- Kiểm tra role có tồn tại không
    SELECT COUNT(*)
    INTO v_exists
    FROM DBA_ROLES
    WHERE ROLE = UPPER(p_role_name);


    IF v_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20003, 'Role "' || p_role_name || '" does not exist.');
    END IF;


    -- Kiểm tra user có tồn tại không
    SELECT COUNT(*)
    INTO v_exists
    FROM DBA_USERS
    WHERE USERNAME = UPPER(p_user_name);


    IF v_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20004, 'User "' || p_user_name || '" does not exist.');
    END IF;


    -- Xây dựng câu lệnh SQL
    IF UPPER(p_action) = 'GRANT' THEN
        -- Chỉ thêm WITH ADMIN OPTION khi GRANT và p_with_option = TRUE
        IF p_with_option THEN
            v_sql := p_action || ' ' || p_role_name || ' TO ' || p_user_name || ' WITH ADMIN OPTION';
        ELSE
            v_sql := p_action || ' ' || p_role_name || ' TO ' || p_user_name;
        END IF;
    ELSE
        -- REVOKE không dùng WITH ADMIN OPTION
        v_sql := p_action || ' ' || p_role_name || ' FROM ' || p_user_name;
    END IF;


    -- Thực thi câu lệnh SQL
    EXECUTE IMMEDIATE v_sql;


EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20006, 'An unexpected error occurred: ' || SQLERRM);
END;


------------------------------------------------------------------------------------
--------------------4.5 Create procedure Manage_System_Privileges-------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE Manage_System_Privileges (
    p_action       IN VARCHAR2,        -- 'GRANT' hoặc 'REVOKE'
    p_privilege    IN VARCHAR2,        -- Tên quyền (CREATE SESSION, SELECT ANY TABLE, ...)
    p_grantee      IN VARCHAR2,        -- Tên user hoặc role được cấp quyền
    p_with_option  IN BOOLEAN DEFAULT FALSE -- TRUE: WITH ADMIN OPTION (chỉ GRANT)
)
AUTHID CURRENT_USER -- Thực thi với quyền user hiện tại
IS
    v_sql     VARCHAR2(4000); -- Câu lệnh SQL
    v_exists  NUMBER;         -- Biến kiểm tra tồn tại
BEGIN
    -- Kiểm tra giá trị của p_action
    IF UPPER(p_action) NOT IN ('GRANT', 'REVOKE') THEN
        RAISE_APPLICATION_ERROR(-20001, 'Invalid action. Use GRANT or REVOKE.');
    END IF;


    -- Kiểm tra quyền của người gọi
    SELECT COUNT(*)
    INTO v_exists
    FROM SESSION_PRIVS
    WHERE PRIVILEGE = 'GRANT ANY PRIVILEGE';


    IF v_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20002, 'You do not have the privilege "GRANT ANY PRIVILEGE" to perform this action.');
    END IF;


    -- Kiểm tra grantee là role
    SELECT COUNT(*)
    INTO v_exists
    FROM DBA_ROLES
    WHERE ROLE = UPPER(p_grantee);


    IF v_exists = 0 THEN
        -- Nếu không phải role, kiểm tra xem grantee có phải là user không
        SELECT COUNT(*)
        INTO v_exists
        FROM DBA_USERS
        WHERE USERNAME = UPPER(p_grantee);


        IF v_exists = 0 THEN
            RAISE_APPLICATION_ERROR(-20003, 'Grantee "' || p_grantee || '" does not exist as a user or role.');
        END IF;
    END IF;


    -- Xây dựng câu lệnh SQL
    IF UPPER(p_action) = 'GRANT' THEN
        v_sql := p_action || ' ' || p_privilege || ' TO ' || p_grantee;
        IF p_with_option THEN
            v_sql := v_sql || ' WITH ADMIN OPTION';
        END IF;
    ELSE
        v_sql := p_action || ' ' || p_privilege || ' FROM ' || p_grantee;
    END IF;


    -- Thực thi câu lệnh SQL
    EXECUTE IMMEDIATE v_sql;


EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20004, 'An unexpected error occurred: ' || SQLERRM);
END;

------------------------------------------------------------------------------------
--------------------4.6 Create procedure Manage_Object_Privileges-------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE Manage_Object_Privileges (
    p_action       IN VARCHAR2,        -- 'GRANT' hoặc 'REVOKE'
    p_privilege    IN VARCHAR2,        -- Tên quyền (SELECT, INSERT, DELETE...)
    p_grantee      IN VARCHAR2,        -- User hoặc role được cấp quyền
    p_object_name  IN VARCHAR2,        -- Tên đối tượng (bảng hoặc view)
    p_column_name  IN VARCHAR2 DEFAULT NULL, -- Tên cột (chỉ sử dụng nếu áp dụng cho cột)
    p_with_option  IN BOOLEAN DEFAULT FALSE -- TRUE: WITH GRANT OPTION (chỉ GRANT)
)
AUTHID CURRENT_USER -- Thực thi với quyền user hiện tại
IS
    v_sql          VARCHAR2(4000); -- Lệnh SQL
    v_exists       NUMBER;         -- Biến kiểm tra tồn tại
    v_is_role      NUMBER;         -- Biến kiểm tra nếu p_grantee là role
    v_is_nullable  NUMBER;         -- Kiểm tra cột có thể NULL hay không
BEGIN
    -- Kiểm tra giá trị của p_action
    IF UPPER(p_action) NOT IN ('GRANT', 'REVOKE') THEN
        RAISE_APPLICATION_ERROR(-20001, 'Invalid action. Use GRANT or REVOKE.');
    END IF;


    -- Kiểm tra đối tượng có tồn tại không
    SELECT COUNT(*)
    INTO v_exists
    FROM ALL_OBJECTS
    WHERE OBJECT_NAME = UPPER(p_object_name) AND OBJECT_TYPE IN ('TABLE', 'VIEW');


    IF v_exists = 0 THEN
        RAISE_APPLICATION_ERROR(-20002, 'Object "' || p_object_name || '" does not exist.');
    END IF;


    -- Kiểm tra nếu p_grantee là role
    SELECT COUNT(*)
    INTO v_is_role
    FROM DBA_ROLES
    WHERE ROLE = UPPER(p_grantee);


    IF v_is_role = 0 THEN
        -- Nếu không phải role, kiểm tra xem p_grantee có phải là user không
        SELECT COUNT(*)
        INTO v_exists
        FROM DBA_USERS
        WHERE USERNAME = UPPER(p_grantee);


        IF v_exists = 0 THEN
            RAISE_APPLICATION_ERROR(-20003, 'Grantee "' || p_grantee || '" does not exist as a user or role.');
        END IF;
    END IF;


    -- Kiểm tra trường hợp không được cấp quyền SELECT hoặc DELETE trên cột
    IF UPPER(p_privilege) IN ('SELECT', 'DELETE') AND p_column_name IS NOT NULL THEN
        RAISE_APPLICATION_ERROR(-20004, 'Cannot GRANT or REVOKE ' || p_privilege || ' privilege on a specific column.');
    END IF;


    -- Kiểm tra nếu quyền INSERT chỉ áp dụng trên cột
    IF UPPER(p_privilege) = 'INSERT' AND p_column_name IS NOT NULL THEN
        -- Kiểm tra cột này có thể NULL không
        SELECT COUNT(*)
        INTO v_is_nullable
        FROM ALL_TAB_COLUMNS
        WHERE TABLE_NAME = UPPER(p_object_name)
          AND COLUMN_NAME = UPPER(p_column_name)
          AND NULLABLE = 'N';


        IF v_is_nullable > 0 THEN
            RAISE_APPLICATION_ERROR(-20005, 'Cannot GRANT INSERT on column "' || p_column_name || '" because other columns cannot be NULL.');
        END IF;
    END IF;


    -- Xây dựng câu lệnh SQL
    IF UPPER(p_action) = 'GRANT' THEN
        v_sql := p_action || ' ' || p_privilege;


        -- Nếu là cột, thêm tên cột vào câu lệnh
        IF p_column_name IS NOT NULL THEN
            v_sql := v_sql || ' (' || p_column_name || ')';
        END IF;


        v_sql := v_sql || ' ON ' || p_object_name || ' TO ' || p_grantee;


        -- Nếu có WITH GRANT OPTION
        IF p_with_option THEN
            v_sql := v_sql || ' WITH GRANT OPTION';
        END IF;
    ELSE
        -- REVOKE quyền
        v_sql := p_action || ' ' || p_privilege;


        -- Nếu là cột, thêm tên cột vào câu lệnh
        IF p_column_name IS NOT NULL THEN
            v_sql := v_sql || ' (' || p_column_name || ')';
        END IF;


        v_sql := v_sql || ' ON ' || p_object_name || ' FROM ' || p_grantee;
    END IF;


    -- Thực thi câu lệnh SQL
    EXECUTE IMMEDIATE v_sql;


EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20006, 'An unexpected error occurred: ' || SQLERRM);
END;
