# Import các thư viện cần thiết để tạo giao diện người dùng
import tkinter as tk  # Thư viện chính để tạo GUI
from tkinter import *  # Lấy tất cả các thành phần từ tkinter
from tkinter import filedialog  # Thư viện con hỗ trợ mở file
from tkinter import messagebox as msg  # Thư viện con để hiển thị thông báo (messagebox)

wf = tk.Tk()  # Tạo một cửa sổ chính (window)
wf.title("BAI MAU 1 = tkinter")  # Thiết lập tiêu đề cửa sổ
wf.geometry("900x500")  # Thiết lập kích thước cửa sổ (width x height)
wf.resizable(tk.FALSE, tk.FALSE)  # Không cho phép thay đổi kích thước cửa sổ

def ClearText(): 
    # Xóa tất cả nội dung của widget lblFileText (Text box)
    lblFileText.delete("1.0", tk.END)
    scroll_y.set(0.0,1.0)  # Đặt thanh cuộn quay lại vị trí đầu tiên

def OpenTextFile(): 
    global filepath  # Biến toàn cục để lưu đường dẫn file
    # Hiển thị hộp thoại mở file và chọn file
    filepath = filedialog.askopenfilename(title = "Bai mau 1_ Open Text File", filetypes = (("Text File (.txt)", "*.txt"),("CSV File (.csv)", "*.csv")))
    # Mở file được chọn với encoding UTF-8
    f1 = open(filepath, "r", encoding="utf-8")
    data = f1.read()  # Đọc toàn bộ nội dung của file
    # Xóa nội dung cũ trong Text widget
    ClearText()
    # Hiển thị nội dung file vào Text widget lblFileText
    lblFileText.configure(state=tk.NORMAL)  # Cho phép chỉnh sửa nội dung text
    lblFileText.insert(tk.END, data)  # Chèn nội dung file vào cuối widget
    lblFileText.configure(state=tk.DISABLED)  # Đặt widget ở chế độ chỉ đọc (không cho chỉnh sửa)
    f1.close()  # Đóng file sau khi đọc xong

def XuLy():
    # Mở file văn bản với encoding utf-8
    f1 = open(filepath, "r", encoding="utf-8")
    s = ""
    students_set = set()  # Sử dụng set để lưu sinh viên duy nhất

    # Đọc từng dòng trong file
    for line in f1:
        line = line.strip()  # Cắt bỏ khoảng trắng ở đầu và cuối dòng
        if line != "":  # Nếu dòng không rỗng
            if ":" in line:
                students_set.add(line)  # Thêm vào set, tự động loại bỏ trùng lặp
                s += line + "\n"  # Thêm dòng vào chuỗi kết quả
    
    # Kiểm tra nếu không có dữ liệu hợp lệ trong file
    if not students_set:
        msg.showwarning("Không có dữ liệu hợp lệ", "Không có dữ liệu hợp lệ trong file!")
        f1.close()
        return
    
    # Sắp xếp danh sách sinh viên duy nhất theo thứ tự
    sorted_students = sorted(students_set)

    # Tạo lại chuỗi s với sinh viên duy nhất đã sắp xếp
    s = ""
    for student in sorted_students:
        s += student + "\n"
    
    # Đếm số lượng sinh viên duy nhất
    dem = len(sorted_students)
    
    # Đóng file
    f1.close()
    
    # Clear text area
    ClearText()
    
    # Cập nhật nội dung vào TextBox
    lblXuLy.configure(state=tk.NORMAL)
    lblXuLy.insert(tk.END, s)
    lblXuLy.configure(state=tk.DISABLED)
    
    # Cập nhật số lượng phần tử
    lblCount.configure(text="Số lượng SV: %d" % dem)
    
    # Lưu kết quả vào file mới
    f_new = open("KetQua.txt", "w+", encoding="utf-8")
    f_new.write(s + "\n" + "Số lượng SV: %d" % dem)
    f_new.close()




# Thiết lập một button để mở file
btnOpenTextFile = tk.Button(wf, text = "Open text File", command = OpenTextFile)
btnOpenTextFile.place(x=5, y=5)

# Thiết lập một frame để chứa Text widget và Scrollbar
frame = tk.Frame(wf, width = 380, height = 300, relief = tk.SUNKEN, borderwidth = 3)
frame.place(x=5, y=40)

# Thiết lập Text widget để hiển thị nội dung file
lblFileText = tk.Text(frame, width = 50, state=tk.DISABLED)
scroll_y = tk.Scrollbar(frame, command = lblFileText.yview, orient = tk.VERTICAL)
lblFileText.configure(yscrollcommand = scroll_y.set)
# Thiết lập vị trí cho Scrollbar
scroll_y.pack(side=tk.RIGHT, fill=tk.Y)
lblFileText.pack(side=tk.LEFT, fill=tk.BOTH)

# Thiết lập một button để thực hiện xử lý file
btnXuLy = tk.Button(wf, text = "Xử lý", command = XuLy)
btnXuLy.place(x=450, y=5)

# Thiết lập một frame2 để chứa Text widget và Scrollbar cho kết quả xử lý
frame2 = tk.Frame(wf, width = 380, height = 300, relief = tk.SUNKEN, borderwidth = 3)
frame2.place(x=450, y=40)

# Thiết lập Text widget để hiển thị kết quả xử lý
lblXuLy = tk.Text(frame2, width = 50, state=tk.DISABLED)
scroll_y = tk.Scrollbar(frame2, command = lblXuLy.yview, orient = tk.VERTICAL)
lblXuLy.configure(yscrollcommand = scroll_y.set)
# Thiết lập vị trí cho Scrollbar
scroll_y.pack(side=tk.RIGHT, fill=tk.Y)
lblXuLy.pack(side=tk.LEFT, fill=tk.BOTH)

# Thiết lập label để hiển thị số lượng phần tử đã xử lý
lblCount = tk.Label(wf, text="Số lượng SV: 0", relief = tk.SUNKEN, width = 25)
lblCount.place(x=700, y=470)

# Bắt đầu vòng lặp chính của GUI
wf.mainloop()
