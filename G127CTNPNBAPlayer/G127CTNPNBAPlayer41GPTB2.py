import math
# Hàm giải phương trình bậc nhất ax + b = 0
def solve_linear_equation_ngocphung_27(a_ngocphung_27, b_ngocphung_27):
    if a_ngocphung_27 == 0:
        return "Vô nghiệm" if b_ngocphung_27 != 0 else "Vô số nghiệm"
    return -b_ngocphung_27 / a_ngocphung_27
# Hàm giải phương trình bậc hai ax^2 + bx + c = 0
def solve_quadratic_equation_ngocphung_27(a_ngocphung_27, b_ngocphung_27, c_ngocphung_27):
    if a_ngocphung_27 == 0:  
    # Nếu a = 0, phương trình trở thành bậc nhất
        return solve_linear_equation_ngocphung_27(b_ngocphung_27, c_ngocphung_27)
    delta_ngocphung_27 = b_ngocphung_27**2 - 4 * a_ngocphung_27 * c_ngocphung_27  # Tính biệt thức delta = b^2 - 4ac
    if delta_ngocphung_27 < 0:  
    # Nếu delta < 0, phương trình vô nghiệm (không có nghiệm thực)
        return "Vô nghiệm"
    elif delta_ngocphung_27 == 0:  
    # Nếu delta = 0, phương trình có nghiệm kép
        return -b_ngocphung_27 / (2 * a_ngocphung_27)
    else:  
    # Nếu delta > 0, phương trình có 2 nghiệm phân biệt
        sqrt_delta_ngocphung_27 = math.sqrt(delta_ngocphung_27)
        x1_ngocphung_27 = (-b_ngocphung_27 + sqrt_delta_ngocphung_27) / (2 * a_ngocphung_27)
        x2_ngocphung_27 = (-b_ngocphung_27 - sqrt_delta_ngocphung_27) / (2 * a_ngocphung_27)
        return x1_ngocphung_27, x2_ngocphung_27
# Ví dụ sử dụng
print(solve_linear_equation_ngocphung_27(2, -4)) 
# Giải phương trình 2x - 4 = 0, kết quả: 2
print(solve_quadratic_equation_ngocphung_27(1, -3, 2))  
# Giải phương trình x^2 - 3x + 2 = 0, kết quả: (2.0, 1.0)
