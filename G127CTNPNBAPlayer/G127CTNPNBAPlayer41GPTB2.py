import math
# Hàm giải phương trình bậc nhất ax + b = 0
def solve_linear_equation_27NgocPhung(a, b):
    if a == 0:
        return "Vô nghiệm" if b != 0 else "Vô số nghiệm"
    return -b / a
# Hàm giải phương trình bậc hai ax^2 + bx + c = 0
def solve_quadratic_equation_27NgocPhung(a, b, c):
    if a == 0:  
    # Nếu a = 0, phương trình trở thành bậc nhất
        return solve_linear_equation_27NgocPhung(b, c)
    delta = b**2 - 4 * a * c  # Tính biệt thức delta = b^2 - 4ac
    if delta < 0:  
    # Nếu delta < 0, phương trình vô nghiệm (không có nghiệm thực)
        return "Vô nghiệm"
    elif delta == 0:  
    # Nếu delta = 0, phương trình có nghiệm kép
        return -b / (2 * a)
    else:  
    # Nếu delta > 0, phương trình có 2 nghiệm phân biệt
        sqrt_delta = math.sqrt(delta)
        x1 = (-b + sqrt_delta) / (2 * a)
        x2 = (-b - sqrt_delta) / (2 * a)
        return x1, x2
# Ví dụ sử dụng
print(solve_linear_equation_27NgocPhung(2, -4)) 
 # Giải phương trình 2x - 4 = 0, kết quả: 2
print(solve_quadratic_equation_27NgocPhung(1, -3, 2))  
# Giải phương trình x^2 - 3x + 2 = 0, kết quả: (2.0, 1.0)
