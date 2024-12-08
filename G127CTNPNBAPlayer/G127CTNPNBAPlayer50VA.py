import tkinter as tk
from tkinter import messagebox, simpledialog
import speech_recognition as sr
from gtts import gTTS
import playsound
import os

# Thư mục lưu tạm file âm thanh
OUT_DIR_ngocphung_27 = "D:/PYPR (Python Programming)/G127CTNPNBAPlayer/B6Ex3_GUI/ngocphung_27"  # Thay đổi thư mục lưu file âm thanh
os.makedirs(OUT_DIR_ngocphung_27, exist_ok=True)

def thapHaNoi_ngocphung_27(n_ngocphung_27, toaMot_ngocphung_27, toaHai_ngocphung_27, toaBa_ngocphung_27):
    if n_ngocphung_27 == 1:
        print(f"Chuyển từ {toaMot_ngocphung_27} sang {toaBa_ngocphung_27}")
    else:
        thapHaNoi_ngocphung_27(n_ngocphung_27 - 1, toaMot_ngocphung_27, toaBa_ngocphung_27, toaHai_ngocphung_27)
        print(f"Chuyển từ {toaMot_ngocphung_27} sang {toaBa_ngocphung_27}")
        thapHaNoi_ngocphung_27(n_ngocphung_27 - 1, toaHai_ngocphung_27, toaMot_ngocphung_27, toaBa_ngocphung_27)

def run_thapHaNoi_ngocphung_27():
    n_ngocphung_27 = int(simpledialog.askstring("Nhập số đĩa", "Nhập số đĩa:"))
    print(f"Bắt đầu chuyển {n_ngocphung_27} đĩa:")
    thapHaNoi_ngocphung_27(n_ngocphung_27, "1", "2", "3")

def voice_assistant_ngocphung_27():
    recognizer_ngocphung_27 = sr.Recognizer()
    with sr.Microphone() as source_ngocphung_27:
        duration_ngocphung_27 = int(simpledialog.askstring("Chọn thời gian", "Chọn thời gian hiệu chỉnh (giây):"))

        messagebox.showinfo("Nhắc nhở", f"Hiệu chỉnh mic trong {duration_ngocphung_27} giây.")
        recognizer_ngocphung_27.adjust_for_ambient_noise(source_ngocphung_27, duration=duration_ngocphung_27)

        messagebox.showinfo("Thông báo", "Bắt đầu nói trong 5 giây.")
        audio_data_ngocphung_27 = recognizer_ngocphung_27.record(source_ngocphung_27, duration=5)

        try:
            text_ngocphung_27 = recognizer_ngocphung_27.recognize_google(audio_data_ngocphung_27, language="vi")
        except sr.UnknownValueError:
            text_ngocphung_27 = "Bạn nói gì nghe không rõ!"  # Thay "Quý vị" thành "Bạn"
        except sr.RequestError:
            text_ngocphung_27 = "Không thể kết nối với dịch vụ nhận diện."

        messagebox.showinfo("Kết quả nhận diện", f"Bạn đã nói: {text_ngocphung_27}")  # Thay "Quý vị" thành "Bạn"
        text_to_speech_ngocphung_27(text_ngocphung_27)

def text_to_speech_ngocphung_27(text_ngocphung_27):
    audio_file_ngocphung_27 = os.path.join(OUT_DIR_ngocphung_27, "ngocphung_27_GUI_2.mp3")
    tts_ngocphung_27 = gTTS(text=text_ngocphung_27, lang='vi')
    tts_ngocphung_27.save(audio_file_ngocphung_27)
    playsound.playsound(audio_file_ngocphung_27)

def eda_preprocessing_ngocphung_27():
    col_count_ngocphung_27 = int(simpledialog.askstring("Số cột", "Nhập số cột NULL cần loại bỏ:"))
    messagebox.showinfo("Thông báo", f"Sẽ
