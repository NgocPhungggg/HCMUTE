import matplotlib.pyplot as plt    # Thư viện vẽ đồ thị 2D
import numpy as np                 # Thư viện xử lý mảng và các phép toán số học
from mpl_toolkits import mplot3d   # Thư viện con của matplotlib hỗ trợ vẽ đồ thị 3D

# Vẽ đồ thị đơn giản với 3 điểm rời rạc
x_list = [0,2,7]                  # Danh sách giá trị trục x
y_list = [1,8,9]                  # Danh sách giá trị trục y
plt.plot(x_list, y_list)          # Vẽ đồ thị nối các điểm (x_list, y_list)
plt.show()                        # Hiển thị đồ thị

def f(x):                         # Định nghĩa một hàm f(x) = x^2 + x + 1
    return x**2 + x + 1

x_1 = np.linspace(start=-3, stop=3, num=100)  # Tạo mảng x_1 gồm 100 giá trị từ -3 đến 3
y_1 = f(x_1)                                  # Tính giá trị y_1 = f(x_1)

# Vẽ đồ thị hàm f(x)
plt.plot(x_1, y_1)                         # Vẽ đồ thị với trục x là x_1 và trục y là y_1
plt.figure(figsize=(3,10))                  # Đặt kích thước đồ thị (chiều rộng 3, chiều cao 10)
plt.show()                                  # Hiển thị đồ thị

# Đặt phạm vi của trục x và trục y, và thêm nhãn
plt.xlim(-3, 3)                            # Xác định phạm vi trục x từ -3 đến 3
plt.ylim(0, 8)                             # Xác định phạm vi trục y từ 0 đến 8
plt.xlabel('X', fontsize=16)               # Đặt nhãn cho trục x với kích thước font 16
plt.ylabel('f(x)', fontsize=16)            # Đặt nhãn cho trục y với kích thước font 16
plt.plot(x_1, y_1)                         # Vẽ lại đồ thị hàm f(x)
plt.show()                                  # Hiển thị đồ thị

plt.plot([0,1,2,3,4], [1,2,3,4,10], 'go-', label='Python')  # Vẽ đồ thị với các điểm rời rạc và nối bằng đường (Python)
plt.plot([0,1,2,3,4], [10,4,3,2,1], 'ro-', label='C#')       # Vẽ đồ thị với các điểm rời rạc và nối bằng đường (C#)
plt.plot([2.5,2.5,2.5,1.5,0.5], [1,3,5,7,10], 'bo-', label='Java')  # Vẽ đồ thị với các điểm rời rạc và nối bằng đường (Java)

plt.title('Vẽ đồ thị trong Python với Matplotlib')  # Đặt tiêu đề cho đồ thị
plt.xlabel('X')                                    # Đặt nhãn cho trục x
plt.ylabel('Y')                                    # Đặt nhãn cho trục y
plt.legend(loc='best')                             # Hiển thị chú giải cho các tập điểm với vị trí tốt nhất
plt.show()                                         # Hiển thị đồ thị

height = np.array([167,170,149,165,155,180,166,146,159,185,145,168,172,181,169])  # Chiều cao của các đối tượng
weight = np.array([86,74,66,78,68,79,90,73,70,88,66,84,67,84,77])  # Cân nặng của các đối tượng

colors = np.random.rand(15)  # Tạo một mảng các giá trị ngẫu nhiên cho màu sắc của các điểm
area = (30 * np.random.rand(15))**2  # Tạo diện tích các điểm phân tán (càng lớn thì điểm càng to)

# Vẽ đồ thị phân tán với chiều cao là trục x và cân nặng là trục y
plt.xlim(140, 200)  # Xác định phạm vi trục x từ 140 đến 200
plt.ylim(60, 100)   # Xác định phạm vi trục y từ 60 đến 100
plt.scatter(height, weight, s=area, c=colors)  # Vẽ đồ thị phân tán, với diện tích và màu sắc ngẫu nhiên
plt.title("Chiều cao và cân nặng")  # Đặt tiêu đề cho đồ thị
plt.xlabel("Chiều cao - cm")       # Đặt nhãn cho trục x
plt.ylabel("Cân nặng - kg")        # Đặt nhãn cho trục y
plt.show()  # Hiển thị đồ thị

h = np.array([167,170,149,165,155,180,166,146,159,185,145,168,172,181,189])  # Chiều cao
w = np.array([86,74,66,78,68,79,90,73,70,88,66,84,67,84,77])  # Cân nặng

# Tạo đồ thị 3D
ax = plt.axes(projection='3d')  # Tạo một trục 3D
ax.scatter3D(h, w)              # Vẽ đồ thị phân tán 3D với dữ liệu chiều cao (h) và cân nặng (w)
ax.set_xlabel("Chiều cao")      # Đặt nhãn cho trục x trong không gian 3D
ax.set_ylabel("Cân nặng")       # Đặt nhãn cho trục y trong không gian 3D
plt.title("BIỂU ĐỒ CAO _NẶNG")  # Đặt tiêu đề cho đồ thị
plt.show()  # Hiển thị đồ thị
