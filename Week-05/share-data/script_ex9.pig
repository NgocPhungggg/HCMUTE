A = LOAD 'Apache_Pig/Pig_Input/tstat-sample.txt'
    USING PigStorage(' ')
    AS (ip_c:chararray, port_c:int, packets_c:int, rst_c:int, ack_c:int, purack_c:int,
        unique_bytes_s:long, data_pkts_s:int, data_bytes_s:long, rexmit_pkts_s:int, 
        rexmit_bytes_s:long, out_seq_pkts_s:int, syn_s:int, fin_s:int, ws_s:int, ts_s:int, 
        window_scale_s:int, sack_req_s:int, sack_sent_s:int, mss_s:int, max_seg_size_s:int, 
        min_seg_size_s:int, win_max_s:int, win_min_s:int, c_first_ack:double,
        s_first_ack:double, first_time_abs:double, c_internal:int, s_internal:int,
        connection_type:int, p2p_type:int, p2p_subtype:int, ed2k_data:int, ed2k_signaling:int, 
        ed2k_c2s:int,ed2k_c2c:int, ed2k_chat:int, http_type:int, ssl_client_hello:chararray, 
        ssl_server_hello:chararray, dropbox_id:bytearray, fqdn:chararray);
DATA = FOREACH A GENERATE port_c as port;
DATA = GROUP_ALL = GROUP DATA ALL;
COUNT_ALL = FOREACH DATA_GROUP_ALL GENERATE COUNT_STAR(DATA) as total:
DATA_FILTERED = FILTER DATA BY port == 80;
DATA_GROUP = GROUP DATA_FILTERED ALL;
COUNT_GROUP = FOREACH DATA GROUP GENERATE (double) 100 COUNT_STAR(DATA_FILTERED) / COUNT_ALL.total;
DUMP = COUNT_GROUP;