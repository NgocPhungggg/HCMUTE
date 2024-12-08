# Import các thư viện cần thiết để tạo giao diện người dùng
import tkinter as tk  # Thư viện chính để tạo GUI
from tkinter import *  # Lấy tất cả các thành phần từ tkinter
from tkinter import filedialog  # Thư viện con hỗ trợ mở file
from tkinter import messagebox as msg  # Thư viện con để hiển thị thông báo (messagebox)

wf_ngocphung_27 = tk.Tk()  # Tạo một cửa sổ chính (window)
wf_ngocphung_27.title("BAI MAU 1 = tkinter")  # Thiết lập tiêu đề cửa sổ
wf_ngocphung_27.geometry("900x500")  # Thiết lập kích thước cửa sổ (width x height)
wf_ngocphung_27.resizable(tk.FALSE, tk.FALSE)  # Không cho phép thay đổi kích thước cửa sổ

def ClearText_ngocphung_27(): 
    # Xóa tất cả nội dung của widget lblFileText_ngocphung_27 (Text box)
    lblFileText_ngocphung_27.delete("1.0", tk.END)
    scroll_y_ngocphung_27.set(0.0,1.0)  # Đặt thanh cuộn quay lại vị trí đầu tiên

def OpenTextFile_ngocphung_27(): 
    global filepath_ngocphung_27  # Biến toàn cục để lưu đường dẫn file
    # Hiển thị hộp thoại mở file và chọn file
    filepath_ngocphung_27 = filedialog.askopenfilename(title = "Bai mau 1_ Open Text File", filetypes = (("Text File (.txt)", "*.txt"),("CSV File (.csv)", "*.csv")))
    # Mở file được chọn với encoding UTF-8
    f1_ngocphung_27 = open(filepath_ngocphung_27, "r", encoding="utf-8")
    data_ngocphung_27 = f1_ngocphung_27.read()  # Đọc toàn bộ nội dung của file
    # Xóa nội dung cũ trong Text widget
    ClearText_ngocphung_27()
    # Hiển thị nội dung file vào Text widget lblFileText_ngocphung_27
    lblFileText_ngocphung_27.configure(state=tk.NORMAL)  # Cho phép chỉnh sửa nội dung text
    lblFileText_ngocphung_27.insert(tk.END, data_ngocphung_27)  # Chèn nội dung file vào cuối widget
    lblFileText_ngocphung_27.configure(state=tk.DISABLED)  # Đặt widget ở chế độ chỉ đọc (không cho chỉnh sửa)
    f1_ngocphung_27.close()  # Đóng file sau khi đọc xong

def XuLy_ngocphung_27():
    # Mở file văn bản với encoding utf-8
    f1_ngocphung_27 = open(filepath_ngocphung_27, "r", encoding="utf-8")
    s_ngocphung_27 = ""
    students_set_ngocphung_27 = set()  # Sử dụng set để lưu sinh viên duy nhất

    # Đọc từng dòng trong file
    for line_ngocphung_27 in f1_ngocphung_27:
        line_ngocphung_27 = line_ngocphung_27.strip()  # Cắt bỏ khoảng trắng ở đầu và cuối dòng
        if line_ngocphung_27 != "":  # Nếu dòng không rỗng
            if ":" in line_ngocphung_27:
                students_set_ngocphung_27.add(line_ngocphung_27)  # Thêm vào set, tự động loại bỏ trùng lặp
                s_ngocphung_27 += line_ngocphung_27 + "\n"  # Thêm dòng vào chuỗi kết quả
    
    # Kiểm tra nếu không có dữ liệu hợp lệ trong file
    if not students_set_ngocphung_27:
        msg.showwarning("Không có dữ liệu hợp lệ", "Không có dữ liệu hợp lệ trong file!")
        f1_ngocphung_27.close()
        return
    
    # Sắp xếp danh sách sinh viên duy nhất theo thứ tự
    sorted_students_ngocphung_27 = sorted(students_set_ngocphung_27)

    # Tạo lại chuỗi s_ngocphung_27 với sinh viên duy nhất đã sắp xếp
    s_ngocphung_27 = ""
    for student_ngocphung_27 in sorted_students_ngocphung_27:
        s_ngocphung_27 += student_ngocphung_27 + "\n"
    
    # Đếm số lượng sinh viên duy nhất
    dem_ngocphung_27 = len(sorted_students_ngocphung_27)
    
    # Đóng file
    f1_ngocphung_27.close()
    
    # Clear text area
    ClearText_ngocphung_27()
    
    # Cập nhật nội dung vào TextBox
    lblXuLy_ngocphung_27.configure(state=tk.NORMAL)
    lblXuLy_ngocphung_27.insert(tk.END, s_ngocphung_27)
    lblXuLy_ngocphung_27.configure(state=tk.DISABLED)
    
    # Cập nhật số lượng phần tử
    lblCount_ngocphung_27.configure(text="Số lượng SV: %d" % dem_ngocphung_27)
    
    # Lưu kết quả vào file mới
    f_new_ngocphung_27 = open("KetQua_ngocphung_27.txt", "w+", encoding="utf-8")
    f_new_ngocphung_27.write(s_ngocphung_27 + "\n" + "Số lượng SV: %d" % dem_ngocphung_27)
    f_new_ngocphung_27.close()

# Thiết lập một button để mở file
btnOpenTextFile_ngocphung_27 = tk.Button(wf_ngocphung_27, text = "Open text File", command = OpenTextFile_ngocphung_27)
btnOpenTextFile_ngocphung_27.place(x=5, y=5)

# Thiết lập một frame để chứa Text widget và Scrollbar
frame_ngocphung_27 = tk.Frame(wf_ngocphung_27, width = 380, height = 300, relief = tk.SUNKEN, borderwidth = 3)
frame_ngocphung_27.place(x=5, y=40)

# Thiết lập Text widget để hiển thị nội dung file
lblFileText_ngocphung_27 = tk.Text(frame_ngocphung_27, width = 50, state=tk.DISABLED)
scroll_y_ngocphung_27 = tk.Scrollbar(frame_ngocphung_27, command = lblFileText_ngocphung_27.yview, orient = tk.VERTICAL)
lblFileText_ngocphung_27.configure(yscrollcommand = scroll_y_ngocphung_27.set)
# Thiết lập vị trí cho Scrollbar
scroll_y_ngocphung_27.pack(side=tk.RIGHT, fill=tk.Y)
lblFileText_ngocphung_27.pack(side=tk.LEFT, fill=tk.BOTH)

# Thiết lập một button để thực hiện xử lý file
btnXuLy_ngocphung_27 = tk.Button(wf_ngocphung_27, text = "Xử lý", command = XuLy_ngocphung_27)
btnXuLy_ngocphung_27.place(x=450, y=5)

# Thiết lập một frame2 để chứa Text widget và Scrollbar cho kết quả xử lý
frame2_ngocphung_27 = tk.Frame(wf_ngocphung_27, width = 380, height = 300, relief = tk.SUNKEN, borderwidth = 3)
frame2_ngocphung_27.place(x=450, y=40)

# Thiết lập Text widget để hiển thị kết quả xử lý
lblXuLy_ngocphung_27 = tk.Text(frame2_ngocphung_27, width = 50, state=tk.DISABLED)
scroll_y_ngocphung_27 = tk.Scrollbar(frame2_ngocphung_27, command = lblXuLy_ngocphung_27.yview, orient = tk.VERTICAL)
lblXuLy_ngocphung_27.configure(yscrollcommand = scroll_y_ngocphung_27.set)
# Thiết lập vị trí cho Scrollbar
scroll_y_ngocphung_27.pack(side=tk.RIGHT, fill=tk.Y)
lblXuLy_ngocphung_27.pack(side=tk.LEFT, fill=tk.BOTH)

# Thiết lập label để hiển thị số lượng phần tử đã xử lý
lblCount_ngocphung_27 = tk.Label(wf_ngocphung_27, text="Số lượng SV: 0", relief = tk.SUNKEN, width = 25)
lblCount_ngocphung_27.place(x=700, y=470)

# Bắt đầu vòng lặp chính của GUI
wf_ngocphung_27.mainloop()
