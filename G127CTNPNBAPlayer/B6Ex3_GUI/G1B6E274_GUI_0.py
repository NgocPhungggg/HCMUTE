from tkinter import *
from tkinter import messagebox
# Tạo một cửa sổ mới
frw27ctnp = Tk()
# Thêm tiêu đề cho cửa sổ
frw27ctnp.title('27 Cao Thị Ngọc Phụng _ Lớp _ HUCMUTE: ĐỒ ÁN HP: LẬP TRÌNH PYTHON')
# Đặt kích thước của cửa sổ
frw27ctnp.geometry('500x400')
lbl = Label(frw27ctnp, text="27_CaoThiNgocPhung \n Đồ Án Học Phần: Lập trình Python \n SV Thực hiện: Cao Thị Ngọc Phụng, STT: 27 \n Trường: HCMUTE", font=("Arial Bold", 10))
lbl.grid(column=0, row=0)
# Hàm thoát chương trình
def Thoat():
    traloi = messagebox.askquestion("Xác nhận", "Bạn có muốn thoát không (Y/N)?")
    if traloi == "yes": frw27ctnp.destroy() # wn.quit()
# Nút thoát chương trình
btnThoat = Button(frw27ctnp, text="Thoát", width=10, command=Thoat)
btnThoat.place(x=100, y=120)  # Căn cứ vào kích thước form [wn.geometry("800x600")] để đặt vị trí Button "Thoát"
# Thiết lập nhãn Label thông tin sinh viên
lblText_27ctnp = Label(frw27ctnp, text="Cao Thị Ngọc Phụng STT:27", background="lightgreen", fg="darkblue", relief=SUNKEN, font="Times 16", borderwidth=3, width=30, height=2)
lblText_27ctnp.place(x=0, y=150) # Đặt Label vừa thiết lập thông tin vào Form
txtSource_ctnp_21110276 = Entry(frw27ctnp, width=30) # Thiết lập Entry để người dùng nhập vào
txtSource_ctnp_21110276.place(x=100, y=90)
a = txtSource_ctnp_21110276.get() # Lấy giá trị người dùng đã nhập vào textbox
a = txtSource_ctnp_21110276.get().strip() # Lấy giá trị người dùng đã nhập và cắt bỏ các khoảng trắng dư thừa
# Khởi chạy vòng lặp sự kiện của Tkinter
frw27ctnp.mainloop()  # Phải có dòng này để cửa sổ Tkinter hoạt động
