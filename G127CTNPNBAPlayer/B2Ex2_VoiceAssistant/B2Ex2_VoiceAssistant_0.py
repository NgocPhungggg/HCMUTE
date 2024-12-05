import speech_recognition as sr
from gtts import gTTS
import playsound

r_ngocphung_27 = sr.Recognizer()  # Khởi tạo đối tượng Recognizer để nhận dạng giọng nói

with sr.Microphone() as Source_ngocphung_27:  # Mở microphone để nhận âm thanh
    # Hiệu chỉnh mic để chuẩn bị nói
    print("1. Chọn thoi gian cho là 1 s")
    print("2. Chọn thoi gian cho là 2 s")
    print("Bạn chọn 1 hay 2") 
    w_ngocphung_27 = int(input("Bạn chọn 1 hay 2: "))  # Chọn thời gian cho việc hiệu chỉnh nhiễu
    print("Hiệu chỉnh nhiễu trước khi nói!")
    r_ngocphung_27.adjust_for_ambient_noise(Source_ngocphung_27, duration=w_ngocphung_27)  # Hiệu chỉnh nhiễu môi trường
    print("Hiệu chỉnh nhiễu trước khi nói!")
    r_ngocphung_27.adjust_for_ambient_noise(Source_ngocphung_27, duration=1)  # Thực hiện lần nữa để ổn định môi trường
    print("Nói tiếng Việt đi, sau 5s sẽ in ra văn bản!")
    audio_data_ngocphung_27 = r_ngocphung_27.record(Source_ngocphung_27, duration=5)  # Ghi âm lời nói trong 5 giây
    print("KẾT QUẢ NHẬN DIỆN ..................")
    try:
        text_ngocphung_27 = r_ngocphung_27.recognize_google(audio_data_ngocphung_27, language="vi")  # Chuyển âm thanh thành văn bản
    except: 
        text_ngocphung_27 = "Bạn nói gì nghe không rõ...!"  # Nếu không nhận diện được thì trả về lỗi

    print("Bạn đã nói là: ", format(text_ngocphung_27))  # In ra văn bản nhận được

def main_ngocphung_27(t_ngocphung_27):  # Hàm chính để chuyển văn bản thành lời nói
    ngocphung_27 = gTTS(text=t_ngocphung_27, lang='vi')  # Sử dụng gTTS để chuyển văn bản thành tiếng nói
    file_name_ngocphung_27 = 'D:\PYPR (Python Programming)\G127CTNPNBAPlayer\B2Ex2_VoiceAssistant\B2Ex2_VoiceAssistant_0.mp3'  # Đặt tên file lưu
    ngocphung_27.save(file_name_ngocphung_27)  # Lưu file âm thanh
    playsound.playsound(file_name_ngocphung_27)  # Phát âm thanh vừa tạo

main_ngocphung_27(text_ngocphung_27)  # Gọi hàm để đọc văn bản đã nhận diện
