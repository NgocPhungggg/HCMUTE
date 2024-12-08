import numpy as np  # Numeric Python: Thư viện về Đại số tuyến tính tính
import pandas as pd  # Python Analytic on Data System: For data processing (Thư viện xử lý dữ liệu)
from scipy import stats  # Thư viện cung cấp các công cụ thống kê [statistics] sub-lib của science python [các công cụ khoa học] 
from sklearn import preprocessing  # Thư viện tiền xử lý DL (XL ngoại lệ: Isolated) = thư viện chính of ML (trong môn PyPro chỉ làm Pre-Processing)
from sklearn.feature_selection import SelectKBest, chi2  # Nạp hàm Thư viện hỗ trợ Mô hình phân tích dữ liệu thăm dò

df_ngocphung_27 = pd.read_csv('D:/PYPR (Python Programming)/G127CTNPNBAPlayer/G127CTNPNBAPLayer10EDA/NBA_2024_per_game(03-01-2024).csv')
print('Độ lớn của bảng [frame] dữ liệu cầu thủ:', df_ngocphung_27.shape)  # Display the shape of the data set (Vẽ biểu đồ tập dữ liệu)
print(df_ngocphung_27[0:5])  # Display data (Hiển thị dữ liệu dạng mảng 5 dòng đầu)


# Checking for null values (Kiểm tra giá trị null = đếm số dòng có dữ liệu ứng từng thuộc# tính)
print(df_ngocphung_27.count().sort_values())  # df.count(): đếm số lượng dòng có dữ liệu của df, .sort_values() sx tăng dân
df_ngocphung_27 = df_ngocphung_27.drop(columns=['FT%', '3P%', '2P%', 'FG%', 'eFG%'], axis=1)
print(df_ngocphung_27.shape)  # kiểm tra lại số lượng cột & dòng của df sau khi XL NULL cột


# Removing null values (Xóa tất cả các dòng có giá trị null trong tập FRAME dữ liệu.)
df_ngocphung_27 = df_ngocphung_27.dropna(how='any')
print(df_ngocphung_27.shape)  # kiểm tra lại số lượng cột & dòng của df sau khi XL NULL các dòng DL


# #kiểm tra tập dữ liệu có bất kỳ ngoại lệ nào không
z_ngocphung_27 = np.abs(stats.zscore(df_ngocphung_27._get_numeric_data()))  # Dò tìm và lấy các giá trị cá biệt trong tập dữ liệu gốc thông qua điểm z (z_score)
print('MA TRAN Z-SCORE\n')
print(z_ngocphung_27)  # in ra tập (ma trận) các giá trị z-score từ tập dữ liệu gốc
df_ngocphung_27 = df_ngocphung_27[(z_ngocphung_27 < 3).all(axis=1)]  # kiểm tra và chỉ giữ lại trong df các giá trị số liệu tưng ứng với z-score < 3  
# {loại các giá trị >= 3} vì các giá trị z-score >=3 tướng ứng với số liệu quá khác biệt so với các số liệu còn lại (“cá biệt” = “ngoại lệ” = isolated}
print(df_ngocphung_27.shape)  # xác định số dòng & cột dữ liệu sau khu xử lý các giá trị cá biệt


# Mã hóa các giá trị trong cột 'Pos' bằng cách sử dụng 'replace'
df_ngocphung_27['Pos'].replace({'PG': 1, 'SG': 1, 'SF': 0, 'PF': 0, 'C': 0}, inplace=True)
# Xóa các dòng có giá trị 'Pos' không nằm trong danh sách đã định
df_ngocphung_27 = df_ngocphung_27[df_ngocphung_27['Pos'].isin([1, 2, 3, 4, 5])]  # Kiểm tra kết quả
# Kiểm tra lại phân phối các giá trị trong cột 'Pos'
print(df_ngocphung_27['Pos'])


df_num_ngocphung_27 = df_ngocphung_27.drop(columns=['Player', 'Tm'], axis=1) 
rr_ngocphung_27 = preprocessing.MinMaxScaler()  # xác định thang đo sẽ dùng để RR hóa theo khoảng đều 
rr_ngocphung_27.fit(df_num_ngocphung_27)  # Áp dụng thang đo vào data frame [df] của đề tài (đã tiền xử lý đến Bước 5)
df_num_ngocphung_27 = pd.DataFrame(rr_ngocphung_27.transform(df_num_ngocphung_27), index=df_ngocphung_27.index, columns=df_num_ngocphung_27.columns)  # Chuyển đổi dữ liệu
df_num_ngocphung_27.iloc[4:10]  # Lấy 5 dòng dữ liệu từ chỉ số 4 đến 10
print(df_num_ngocphung_27)  # In ra DataFrame đã được chuẩn hóa


X_ngocphung_27 = df_num_ngocphung_27.loc[:, df_num_ngocphung_27.columns != 'Pos']  # Tất cả các cột trừ cột 'Pos'
y_ngocphung_27 = df_num_ngocphung_27[['Pos']]  # Dữ liệu đầu ra là cột 'Pos'
# Loại bỏ các dòng có giá trị thiếu
selector_ngocphung_27 = SelectKBest(chi2, k=2)  # sd các hàm ... trong thư viện sklearn = Mô hình xác định các Thuộc tính quan trọng quyết định việc dự đoàn DL output = trích lọc Đặc trưng = Feature Extraction: k = 1...12 (đ/v bài này)
selector_ngocphung_27.fit(X_ngocphung_27, y_ngocphung_27)  # Áp dụng mô hình trên vào .... 
X_new_ngocphung_27 = selector_ngocphung_27.transform(X_ngocphung_27)  # Chuyên DL Input teho mô hình
print(X_new_ngocphung_27)
print(y_ngocphung_27)
print('k cot quan trong nhat quyet dinh cho Vector Output')
print(X_ngocphung_27.columns[selector_ngocphung_27.get_support(indices=True)])  # in ds các tt đặc trưng


# # XĐ data frame = Chiếu lấy các thuộc tính đặc trưng đã xđ trong B8
df_new_ngocphung_27 = df_num_ngocphung_27[['PF', 'PTS']]
# TOV (Turnovers per game): Số lần cầu thủ mất bóng hoặc bị đối phương cướp bóng mỗi trận.
# PF (Personal fouls per game): Số lần cầu thủ phạm lỗi cá nhân mỗi trận.
# PTS (Points per game): Số điểm cầu thủ ghi được trung bình mỗi trận.

X_ngocphung_27 = df_new_ngocphung_27[['PF']]
y_ngocphung_27 = df_new_ngocphung_27[['PTS']]
print(X_ngocphung_27)
print(y_ngocphung_27)
