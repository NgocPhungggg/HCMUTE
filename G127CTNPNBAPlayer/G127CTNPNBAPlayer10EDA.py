########################################################
# GIAI ĐOẠN 1: NẠP DỮ LIỆU GỐC (PRIMARY INPUT DATA LOAD)
########################################################
#######################################
# Bước 1: Nạp các thư viện cần thiết
#######################################
import numpy as np #Numeric Python: Thư viện về Đại số tuyến tính tính
import pandas as pd #Python Analytic on Data System: For data processing (Thư viện xử lý dữ liệu)
from scipy import stats # thư viện cung cấp các công cụ thống kê [statistics] sub-lib của science python [các công cụ khoa học] 
from sklearn import preprocessing # Thư viện tiền xử lý DL (XL ngoại lệ: Isolated) = thư viện chính of ML (trong môn PyPro chỉ làm Pre-Processing)
from sklearn.feature_selection import SelectKBest, chi2 # Nạp hàm Thư viện hỗ trợ Mô hình phân tích dữ liệu thăm dò
###############################################################
# Bước 2: Tải tập dữ liệu: Load the data set (Nạp tập dữ liệu)
# ./NBA_2024_per_game(03-01-2024).csv
##############################################################
df = pd.read_csv('D:/PYPR (Python Programming)/G127CTNPNBAPlayer/G127CTNPNBAPLayer10EDA/NBA_2024_per_game(03-01-2024).csv')
print('Độ lớn của bảng [frame] dữ liệu cầu thủ:',df.shape) # Display the shape of the data set (Vẽ biểu đồ tập dữ liệu)
print(df[0:5]) # Display data (Hiển thị dữ liệu dạng mảng 5 dòng đầu)

###############################################
# # GIAI ĐOẠN 2: TIỀN XỬ LÝ (PRE-PROCESSING)
###############################################

############################################################################
# # Bước 3: Xử lý CỘT dữ liệu NULL quá nhiều OR không có giá trị phân tích
############################################################################
# Checking for null values (Kiểm tra giá trị null = đếm số dòng có dữ liệu ứng từng thuộc# tính)
print(df.count().sort_values()) #df.count(): đếm số lượng dòng có dữ liệu của df, .sort_values() sx tăng dân
df = df.drop(columns=['FT%', '3P%', '2P%', 'FG%', 'eFG%'], axis=1)
print(df.shape) # kiểm tra lại số lượng cột & dòng của df sau khi XL NULL cột

#####################################
# # Bước 4: Xử lý DÒNG dữ liệu NULL 
###################################
# Removing null values (Xóa tất cả các dòng có giá trị null trong tập FRAME dữ liệu.)
df = df.dropna(how='any')
print(df.shape) # kiểm tra lại số lượng cột & dòng của df sau khi XL NULL các dòng DL

##################################################################
# # Bước 5: Xử lý loại bỏ các giá trị ngoại lệ (cá biệt): isolated
##################################################################
# #kiểm tra tập dữ liệu có bất kỳ ngoại lệ nào không
z = np.abs(stats.zscore(df._get_numeric_data())) # Dò tìm và lấy các giá trị cá biệt trong tập dữ liệu gốc thông qua điểm z (z_score)
print('MA TRAN Z-SCORE\n')
print(z) # in ra tập (ma trận) các giá trị z-score từ tập dữ liệu gốc
df= df[(z < 3).all(axis=1)] # kiểm tra và chỉ giữ lại trong df các giá trị số liệu tưng ứng với z-score < 3  
# {loại các giá trị >= 3} vì các giá trị z-score >=3 tướng ứng với số liệu quá khác biệt so với các số liệu còn lại (“cá biệt” = “ngoại lệ” = isolated}
print(df.shape) # xác định số dòng & cột dữ liệu sau khu xử lý các giá trị cá biệt

##############################################################################
# # Bước 6: RR THEO Mã hóa trực tiếp
##############################################################################
# Mã hóa các giá trị trong cột 'Pos' bằng cách sử dụng 'replace'
df['Pos'].replace({'PG': 1, 'SG': 1, 'SF': 0, 'PF': 0, 'C': 0}, inplace=True)
# Xóa các dòng có giá trị 'Pos' không nằm trong danh sách đã định
df = df[df['Pos'].isin([1, 2, 3, 4, 5])]# Kiểm tra kết quả
# Kiểm tra lại phân phối các giá trị trong cột 'Pos'
print(df['Pos'])

####################################################################
# #Bước 7: RR hóa theo khoảng / đoạn = Chuẩn hóa (Rời rạc hóa) tập dữ liệu Input dùng ..MaxMin
####################################################################
df_num = df.drop(columns=['Player', 'Tm'], axis=1) 
rr = preprocessing.MinMaxScaler()  # xác định thang đo sẽ dùng để RR hóa theo khoảng đều 
rr.fit(df_num)  # Áp dụng thang đo vào data frame [df] của đề tài (đã tiền xử lý đến Bước 5)
df_num = pd.DataFrame(rr.transform(df_num), index=df.index, columns=df_num.columns)  # Chuyển đổi dữ liệu
df_num.iloc[4:10]  # Lấy 5 dòng dữ liệu từ chỉ số 4 đến 10
print(df_num)  # In ra DataFrame đã được chuẩn hóa



################################################################################################################
# # GIAI ĐOẠN 3: PHÂN TÍCH DỮ LIỆU THĂM DÒ : EDA [CƠ SỞ = HỌC CÁC MÔN data Science, AI, ML và DeepML,... ]
################################################################################################################
####################################################################
# #Bước 8: Xác định mô hình trích lọc các thuộc tính đặc trưng: EDA 
####################################################################
X = df_num.loc[:, df_num.columns != 'Pos']  # Tất cả các cột trừ cột 'Pos'
y = df_num[['Pos']]  # Dữ liệu đầu ra là cột 'Pos'
# Loại bỏ các dòng có giá trị thiếu
selector = SelectKBest(chi2, k=3) # sd các hàm ... trong thư viện sklearn = Mô hình xác định các Thuộc tính quan trọng quyết định việc dự đoàn DL output = trích lọc Đặc trưng = Feature Extraction: k = 1...12 (đ/v bài này)
selector.fit(X, y) # Áp dụng mô hình trên vào ....
X_new = selector.transform(X) # Chuyên DL Input teho mô hình
print(X_new)
print(y)
print('k cot quan trong nhat quyet dinh cho Vector Output')
print(X.columns[selector.get_support(indices=True)]) # in ds các tt đặc trưng

####################################################################
# #Bước 9: Xác định mô hình trích lọc các thuộc tính đặc trưng 
####################################################################
# # XĐ data frame = Chiếu lấy các thuộc tính đặc trưng đã xđ trong B8
df_new = df_num[['TOV','PF','PTS']]
# TOV (Turnovers per game): Số lần cầu thủ mất bóng hoặc bị đối phương cướp bóng mỗi trận.
# PF (Personal fouls per game): Số lần cầu thủ phạm lỗi cá nhân mỗi trận.
# PTS (Points per game): Số điểm cầu thủ ghi được trung bình mỗi trận.

####################################################################
# #Bước 10: EDA theo nhu cầu thực tế => input vào các mô hình AI, ML,...
####################################################################
X = df_new[['PF']]
y = df_new[['PTS']]
print(X)
print(y)
