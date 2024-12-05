import tkinter as tk
from tkinter import messagebox, simpledialog
import speech_recognition as sr
from gtts import gTTS
import playsound
import os

# Thư mục lưu tạm file âm thanh
OUT_DIR = "D:/PYPR (Python Programming)/G127CTNPNBAPlayer/B6Ex3_GUI/ngocphung_27"  # Thay đổi thư mục lưu file âm thanh
os.makedirs(OUT_DIR, exist_ok=True)

def thapHaNoi_27ctnp(n, toaMot, toaHai, toaBa):
    if n == 1:
        print(f"Chuyển từ {toaMot} sang {toaBa}")
    else:
        thapHaNoi_27ctnp(n - 1, toaMot, toaBa, toaHai)
        print(f"Chuyển từ {toaMot} sang {toaBa}")
        thapHaNoi_27ctnp(n - 1, toaHai, toaMot, toaBa)

def run_thapHaNoi_ctnp():
    n = int(simpledialog.askstring("Nhập số đĩa", "Nhập số đĩa:"))
    print(f"Bắt đầu chuyển {n} đĩa:")
    thapHaNoi_27ctnp(n, "1", "2", "3")

def voice_assistant_21110276_ctnp():
    recognizer = sr.Recognizer()
    with sr.Microphone() as source:
        duration = int(simpledialog.askstring("Chọn thời gian", "Chọn thời gian hiệu chỉnh (giây):"))

        messagebox.showinfo("Nhắc nhở", f"Hiệu chỉnh mic trong {duration} giây.")
        recognizer.adjust_for_ambient_noise(source, duration=duration)

        messagebox.showinfo("Thông báo", "Bắt đầu nói trong 5 giây.")
        audio_data = recognizer.record(source, duration=5)

        try:
            text = recognizer.recognize_google(audio_data, language="vi")
        except sr.UnknownValueError:
            text = "Bạn nói gì nghe không rõ!"  # Thay "Quý vị" thành "Bạn"
        except sr.RequestError:
            text = "Không thể kết nối với dịch vụ nhận diện."

        messagebox.showinfo("Kết quả nhận diện", f"Bạn đã nói: {text}")  # Thay "Quý vị" thành "Bạn"
        text_to_speech_ctnp(text)

def text_to_speech_ctnp(text):
    audio_file = os.path.join(OUT_DIR, "ngocphung_27_GUI_2.mp3")
    tts = gTTS(text=text, lang='vi')
    tts.save(audio_file)
    playsound.playsound(audio_file)

def eda_preprocessing_ctnp():
    col_count = int(simpledialog.askstring("Số cột", "Nhập số cột NULL cần loại bỏ:"))
    messagebox.showinfo("Thông báo", f"Sẽ loại bỏ {col_count} cột NULL nhiều nhất (mô phỏng).")
    print(f"Mô phỏng: Loại bỏ {col_count} cột NULL nhiều nhất.")

def main():
    wn = tk.Tk()
    wn.title("Cao Thị Ngọc Phụng 21110276 MainForm - Đồ Án Python")
    wn.geometry("500x400")
    # Nhãn tiêu đề
    lbl_title = tk.Label(
        wn, text="Lập Trình Python - Đồ Án Học Phần", 
        font=("Arial", 16), bg="lightgreen", fg="darkblue", height=2
    )
    lbl_title.pack(fill=tk.X)
    # Nút Tháp Hà Nội
    btn_thapHaNoi = tk.Button(wn, text="Tháp Hà Nội", width=20, command=run_thapHaNoi_ctnp)
    btn_thapHaNoi.pack(pady=10)
    # Nút Voice Assistant
    btn_voice = tk.Button(wn, text="Voice Assistant", width=20, command=voice_assistant_21110276_ctnp)
    btn_voice.pack(pady=10)
    # Nút EDA Pre-processing
    btn_eda = tk.Button(wn, text="EDA Pre-processing", width=20, command=eda_preprocessing_ctnp)
    btn_eda.pack(pady=10)
    # Nút Thoát
    btn_exit = tk.Button(wn, text="Thoát", width=20, command=wn.quit)
    btn_exit.pack(pady=10)
    wn.mainloop()

if __name__ == "__main__":
    main()
