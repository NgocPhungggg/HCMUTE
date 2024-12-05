def thapHaNoi_CTNP_27(n, toaMot, toaHai, toaBa):
    if n == 1:
        print("Chuyển từ", toaMot, "sang", toaBa)
    else:
        thapHaNoi_CTNP_27(n - 1, toaMot, toaBa, toaHai)
        print("Chuyển từ", toaMot, "sang", toaBa)
        thapHaNoi_CTNP_27(n - 1, toaHai, toaMot, toaBa)

# Nhập số đĩa từ người dùng
n = int(input("Nhập số đĩa: "))
# Gọi hàm tháp Hà Nội với các trụ
thapHaNoi_CTNP_27(n, "1", "2", "3")
