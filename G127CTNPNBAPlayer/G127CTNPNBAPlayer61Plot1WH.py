import matplotlib.pyplot as plt  # Thư viện dùng để vẽ đồ thị 2D
import numpy as np  # Thư viện tính toán khoa học, cung cấp các hàm về mảng và toán học
from mpl_toolkits import mplot3d  # Thư viện bổ sung để vẽ đồ thị 3D

# EX1: Vẽ một đồ thị đơn giản
x_list_ngocphung_27 = [0, 2, 7]  # Tạo danh sách các giá trị của trục x
y_list_ngocphung_27 = [1, 8, 9]  # Tạo danh sách các giá trị tương ứng của trục y
plt.plot(x_list_ngocphung_27, y_list_ngocphung_27)  # Vẽ đồ thị với các điểm (x, y)
plt.show()  # Hiển thị đồ thị

# EX2: Vẽ đồ thị hàm số f(x) = x^2 + x + 1
def f_ngocphung_27(x):
    return x**2 + x + 1  # Định nghĩa hàm f(x)

# Tạo các giá trị x từ -3 đến 3 với 100 điểm
x_1_ngocphung_27 = np.linspace(start=-3, stop=3, num=100)
y_1_ngocphung_27 = f_ngocphung_27(x_1_ngocphung_27)  # Tính giá trị y tương ứng với mỗi giá trị x từ hàm f(x)
plt.plot(x_1_ngocphung_27, y_1_ngocphung_27)  # Vẽ đồ thị hàm số
plt.figure(figsize=(3, 10))  # Tạo figure với kích thước 3x10 inch
plt.show()  # Hiển thị đồ thị

# Cài đặt giới hạn cho trục x và y, thêm nhãn cho trục
plt.xlim(-3, 3)  # Giới hạn trục x từ -3 đến 3
plt.ylim(0, 8)  # Giới hạn trục y từ 0 đến 8
plt.xlabel('X', fontsize=16)  # Nhãn cho trục x
plt.ylabel('f(x)', fontsize=16)  # Nhãn cho trục y
plt.plot(x_1_ngocphung_27, y_1_ngocphung_27)  # Vẽ lại đồ thị với nhãn và giới hạn mới
plt.show()  # Hiển thị đồ thị

plt.plot([0, 1, 2, 3, 4], [1, 2, 3, 4, 10], 'go-', label='Python')  # Đồ thị Python với dấu 'go-' (green, circle, solid line)
plt.plot([0, 1, 2, 3, 4], [10, 4, 3, 2, 1], 'ro-', label='C#')  # Đồ thị C# với dấu 'ro-' (red, circle, solid line)
plt.plot([2.5, 2.5, 2.5, 1.5, 0.5], [1, 3, 5, 7, 10], 'bo-', label='Java')  # Đồ thị Java với dấu 'bo-' (blue, circle, solid line)
plt.title('Vẽ đồ thị trong Python với Matplotlib')  # Tiêu đề của đồ thị
plt.xlabel('X')  # Nhãn cho trục x
plt.ylabel('Y')  # Nhãn cho trục y
plt.legend(loc='best')  # Hiển thị chú thích cho đồ thị
plt.show()  # Hiển thị đồ thị

height_ngocphung_27 = np.array([167, 170, 149, 165, 155, 180, 166, 146, 159, 185, 145, 168, 172, 181, 169])  # Dữ liệu chiều cao
weight_ngocphung_27 = np.array([86, 74, 66, 78, 68, 79, 90, 73, 70, 88, 66, 84, 67, 84, 77])  # Dữ liệu cân nặng

colors_ngocphung_27 = np.random.rand(15)  # Tạo mảng ngẫu nhiên các giá trị màu sắc
area_ngocphung_27 = (30 * np.random.rand(15))**2  # Tạo mảng kích thước ngẫu nhiên cho các điểm

plt.xlim(140, 200)  # Giới hạn trục x từ 140 đến 200
plt.ylim(60, 100)  # Giới hạn trục y từ 60 đến 100
plt.scatter(height_ngocphung_27, weight_ngocphung_27, s=area_ngocphung_27, c=colors_ngocphung_27)  # Vẽ đồ thị phân tán với các điểm có kích thước và màu sắc ngẫu nhiên
plt.title("Chiều cao và cân nặng")  # Tiêu đề cho đồ thị
plt.xlabel("Chiều cao - cm")  # Nhãn cho trục x
plt.ylabel("Cân nặng - kg")  # Nhãn cho trục y
plt.show()  # Hiển thị đồ thị

h_ngocphung_27 = np.array([167, 170, 149, 165, 155, 180, 166, 146, 159, 185, 145, 168, 172, 181, 189])  # Dữ liệu chiều cao 3D
w_ngocphung_27 = np.array([86, 74, 66, 78, 68, 79, 90, 73, 70, 88, 66, 84, 67, 84, 77])  # Dữ liệu cân nặng 3D

# Tạo đồ thị 3D
ax_ngocphung_27 = plt.axes(projection='3d')  # Tạo đối tượng axes cho đồ thị 3D
ax_ngocphung_27.scatter3D(h_ngocphung_27, w_ngocphung_27)  # Vẽ các điểm phân tán trong không gian 3D
ax_ngocphung_27.set_xlabel("Chiều cao")  # Nhãn trục x
ax_ngocphung_27.set_ylabel("Cân nặng")  # Nhãn trục y
plt.title("BIỂU ĐỒ CAO _ NẶNG")  # Tiêu đề đồ thị 3D
plt.show()  # Hiển thị đồ thị 3D
