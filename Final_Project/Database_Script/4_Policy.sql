------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
-------------------------------PART III. CREATE POLICY------------------------------
------------------------------------------------------------------------------------
---------------------------3.1 Create policy admin_filter---------------------------
------------------------------------------------------------------------------------
CREATE OR REPLACE FUNCTION admin_filter (
    p_schema IN VARCHAR2, 
    p_object IN VARCHAR2)
RETURN VARCHAR2
AS
BEGIN
  IF USER = 'ADMIN' THEN
    RETURN '1=1';
  END IF;
  IF USER IS NOT NULL THEN
    RETURN 'USERNAME = USER';
  END IF;
  RETURN '1=0';
END;


BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'ADMIN',
    object_name     => 'USER_ACCOUNT_INFO',
    policy_name     => 'USER_ACCESS_POLICY',
    function_schema => 'ADMIN',
    policy_function => 'admin_filter',
    statement_types => 'SELECT',
    update_check    => FALSE
  );
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'ADMIN',
    object_name     => 'USER_PRIVILEGES_INFO',
    policy_name     => 'USER_ACCESS_POLICY',
    function_schema => 'ADMIN',
    policy_function => 'admin_filter',
    statement_types => 'SELECT',
    update_check    => FALSE
  );
    DBMS_RLS.ADD_POLICY(
    object_schema   => 'ADMIN',
    object_name     => 'USER_OBJECT_PRIVILEGES_INFO',
    policy_name     => 'USER_ACCESS_POLICY',
    function_schema => 'ADMIN',
    policy_function => 'admin_filter',
    statement_types => 'SELECT',
    update_check    => FALSE
  );
END;

BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'ADMIN',
    object_name     => 'LIST_PROFILE',
    policy_name     => 'PROFILE_ACCESS_POLICY',
    function_schema => 'ADMIN',
    policy_function => 'admin_filter',
    statement_types => 'SELECT',
    update_check    => FALSE
  );
END;

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'ADMIN',                   -- Schema chứa bảng
        object_name     => 'INFO',                   -- Tên bảng
        policy_name     => 'INFO_ACCESS_POLICY',     -- Tên chính sách
        function_schema => 'ADMIN',                 -- Schema chứa hàm
        policy_function => 'admin_filter',    -- Hàm thực thi logic
        statement_types => 'SELECT, UPDATE, INSERT',        -- Loại lệnh bị kiểm soát
        update_check    => TRUE                     -- Kiểm tra điều kiện trong lệnh UPDATE
    );
END;
