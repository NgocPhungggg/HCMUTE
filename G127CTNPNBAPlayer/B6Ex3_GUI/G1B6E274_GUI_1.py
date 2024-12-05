import speech_recognition as sr
from gtts import gTTS
import playsound
import tkinter as tk
from tkinter import messagebox
import os  # Thư viện OS để tạo thư mục và lưu file
import time

OUT_FILE = "D:/PYPR (Python Programming)/G127CTNPNBAPlayer/B6Ex3_GUI/ngocphung_27/ngocphung_27_GUI_1.mp3"  # Thay đổi đường dẫn file âm thanh đầu ra
odir = 'D:/PYPR (Python Programming)/G127CTNPNBAPlayer/B6Ex3_GUI/ngocphung_27'  # Thay đổi thư mục lưu file âm thanh
count = 0
os.makedirs(odir, exist_ok=True)  # Tạo thư mục nếu chưa tồn tại

# Hàm thoát chương trình
def Thoat():
    traloi_ctnp = messagebox.askquestion("Xác nhận", "Bạn có muốn thoát không (Y/N)?")
    if traloi_ctnp == "yes":  # Nếu người dùng chọn "yes", đóng cửa sổ
        wn.destroy()

# Hàm nhận lệnh giọng nói và chuyển thành văn bản
def Lenh():
    r_21110276ctnp = sr.Recognizer()  # Khởi tạo đối tượng nhận diện giọng nói
    with sr.Microphone() as source:  # Sử dụng microphone làm nguồn âm thanh
        messagebox.showinfo("Nhắc nhở", "Hiệu chỉnh MIC trước khi ra lệnh bằng lời nói!")  # Nhắc người dùng hiệu chỉnh mic
        r_21110276ctnp.adjust_for_ambient_noise(source, duration=1)  # Hiệu chỉnh theo tiếng ồn môi trường

        messagebox.showinfo("Cảnh báo", "Ra lệnh bằng tiếng Việt trong 3 giây, bấm OK để bắt đầu.")  # Nhắc người dùng ra lệnh
        audio_data = r_21110276ctnp.record(source, duration=3)  # Ghi lại âm thanh trong 3 giây

        try:
            tt_phung = r_21110276ctnp.recognize_google(audio_data, language="vi")  # Nhận dạng giọng nói thành văn bản
        except sr.UnknownValueError:  # Nếu không nhận diện được giọng nói
            tt_phung = "Bạn nói gì nghe không rõ!"  # Thông báo lỗi
        except sr.RequestError:  # Nếu không thể kết nối với dịch vụ nhận dạng
            tt_phung = "Không thể kết nối với dịch vụ nhận diện."

        messagebox.showinfo("Bạn đã nói:", tt_phung)  # Hiển thị văn bản nhận diện được

        ctnp = gTTS(text=tt_phung, lang='vi')  # Chuyển văn bản thành âm thanh
        ctnp.save(OUT_FILE)  # Lưu âm thanh vào file tại thư mục mới

# Hàm phát âm thanh đã lưu
def Xuat():
    try:
        playsound.playsound(OUT_FILE)  # Phát âm thanh từ file
    except Exception as e:  # Nếu có lỗi xảy ra trong quá trình phát âm thanh
        messagebox.showerror("Lỗi", f"Không thể phát âm thanh: {e}")  # Hiển thị thông báo lỗi

# Tạo cửa sổ chính của ứng dụng
wn = tk.Tk()
wn.title("Cao Thị Ngọc Phụng STT: 27, LỚP_HCMUTE, ĐỒ ÁN HỌC PHẦN: LẬP TRÌNH PYTHON, T9.2024")
wn.geometry("800x600")  # Đặt kích thước cửa sổ
wn.resizable(False, False)  # Không cho phép thay đổi kích thước cửa sổ

# Tạo nhãn (Label) hiển thị thông tin về đồ án
lblText = tk.Label(
    wn, 
    text="Phân tích thống kê về cầu thủ bóng rổ trong mùa giải NBA thường niên 2023-2024", 
    background="lightgreen", fg="darkblue", relief=tk.SUNKEN,
    font="Times 16", borderwidth=3, width=60, height=3
)
lblText.place(x=10, y=10)

# Tạo nút "Thoát"
btnThoat = tk.Button(wn, text="Thoát", width=10, command=Thoat)
btnThoat.place(x=100, y=200)

# Tạo nút "Lệnh = nói"
btnLenh = tk.Button(wn, text="Lệnh = nói", width=10, command=Lenh)
btnLenh.place(x=400, y=200)

# Tạo nút "ĐỌC"
btnDoc = tk.Button(wn, text="ĐỌC", width=10, command=Xuat)
btnDoc.place(x=500, y=200)

# Chạy vòng lặp sự kiện của tkinter
wn.mainloop()
