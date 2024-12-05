import speech_recognition as sr  # Thư viện nhận diện giọng nói
import os  # Thư viện làm việc với hệ thống file
import time  # Thư viện làm việc với thời gian
from googletrans import Translator  # Thư viện dịch văn bản sử dụng Google Translate
from gtts import gTTS  # Thư viện chuyển văn bản thành giọng nói (text-to-speech)
from pydub import AudioSegment  # Nhập khẩu thư viện pydub

# Hàm chọn nguồn âm thanh (microphone hoặc file)
def choose_audio_source_ngocphung_27(source="microphone", filename=None):
    if source == "file" and filename:  # Nếu chọn nguồn là file và có filename
        return sr.AudioFile(filename)  # Trả về đối tượng AudioFile từ file âm thanh
    elif source == "microphone":  # Nếu chọn nguồn là microphone
        return sr.Microphone()  # Trả về đối tượng Microphone để thu âm từ microphone
    else:  # Nếu nguồn không hợp lệ
        raise ValueError("chỉ được nhập 'file' hoặc 'microphone'")  # Raise lỗi nếu nguồn không hợp lệ

# Hàm nhận diện âm thanh từ nguồn (microphone hoặc file)
def recognize_audio_ngocphung_27(source="microphone", filename=None):
    recognizer = sr.Recognizer()  # Tạo một đối tượng Recognizer để nhận diện giọng nói
    with choose_audio_source_ngocphung_27(source, filename) as source_audio:  # Chọn nguồn âm thanh
        print("Đang nghe... Vui lòng nói")  # Thông báo đang nghe
        audio_data = recognizer.listen(source_audio)  # Lắng nghe và thu âm
    try:
        print("Nhận diện giọng nói...")  # Thông báo đang nhận diện giọng nói
        text_ngocphung_27 = recognizer.recognize_google(audio_data, language="vi")  # Nhận diện giọng nói thành văn bản bằng Google Speech Recognition
        return text_ngocphung_27  # Trả về văn bản nhận diện
    except sr.UnknownValueError:  # Nếu không nhận diện được giọng nói
        return "Không thể nhận diện giọng nói"  # Trả về thông báo lỗi
    except sr.RequestError:  # Nếu có lỗi kết nối đến dịch vụ nhận diện
        return "Lỗi kết nối với dịch vụ nhận diện"  # Trả về thông báo lỗi kết nối

# Hàm dịch văn bản từ ngôn ngữ nguồn (source_lang) sang ngôn ngữ đích (target_lang)
def translate_text_ngocphung_27(text_ngocphung_27, source_lang='vi', target_lang='en'):
    translator = Translator()  # Tạo đối tượng Translator để dịch văn bản
    translated_ngocphung_27 = translator.translate(text_ngocphung_27, src=source_lang, dest=target_lang)  # Dịch văn bản
    return translated_ngocphung_27.text  # Trả về văn bản đã dịch

# Hàm chuyển văn bản thành âm thanh (text-to-speech)
def text_to_speech_ngocphung_27(text_ngocphung_27, filename="ngocphung_27", lang="vi"):
    tts = gTTS(text=text_ngocphung_27, lang=lang)  # Tạo đối tượng gTTS để chuyển văn bản thành giọng nói
    timestamp = time.strftime("%Y%m%d%H%M%S")  # Lấy thời gian hiện tại để tạo tên file duy nhất
    mp3_file_path = f"D:\\PYPR (Python Programming)\\G127CTNPNBAPlayer\\B2Ex2_VoiceAssistant\\{filename}_{timestamp}.mp3"  # Đường dẫn file MP3
    wav_file_path = f"D:\\PYPR (Python Programming)\\G127CTNPNBAPlayer\\B2Ex2_VoiceAssistant\\{filename}_{timestamp}.wav"  # Đường dẫn file WAV

    tts.save(mp3_file_path)  # Lưu âm thanh thành file MP3
    print(f"Đã lưu âm thanh vào {mp3_file_path}")  # Thông báo đã lưu MP3

    # Sử dụng pydub để chuyển đổi MP3 thành WAV
    sound = AudioSegment.from_mp3(mp3_file_path)  # Đọc file MP3
    sound = sound.set_frame_rate(16000)  # Đảm bảo tần số mẫu phù hợp với yêu cầu của nhận diện giọng nói
    sound = sound.set_channels(1)  # Đảm bảo chỉ có một kênh âm thanh
    sound.export(wav_file_path, format="wav")  # Chuyển đổi và lưu dưới định dạng WAV
    print(f"Đã lưu âm thanh vào {wav_file_path}")  # Thông báo đã lưu WAV

# Hàm chính của trợ lý ảo (Voice Assistant)
def voice_assistant_ngocphung_27():
    print("Chọn nguồn âm thanh (file/microphone):")  # Yêu cầu người dùng chọn nguồn âm thanh
    source_ngocphung_27 = input("Nhập 'file' hoặc 'microphone': ").lower()  # Lấy lựa chọn nguồn âm thanh từ người dùng
    filename_ngocphung_27 = None  # Biến để lưu tên file (nếu nguồn là file)
    if source_ngocphung_27 == "file":  # Nếu nguồn là file
        filename_ngocphung_27 = input("Nhập tên file âm thanh (ví dụ: audio.wav): ")  # Yêu cầu người dùng nhập tên file âm thanh
    text_ngocphung_27 = recognize_audio_ngocphung_27(source_ngocphung_27, filename_ngocphung_27)  # Nhận diện âm thanh thành văn bản
    print(f"Văn bản nhận diện: {text_ngocphung_27}")  # In ra văn bản nhận diện
    print("Chuyển ngữ (Vi -> En)?")  # Hỏi người dùng có muốn dịch không
    if input("Nhấn 'y' để tiếp tục, 'n' để dừng: ").lower() == 'y':  # Nếu người dùng chọn dịch
        translated_text_ngocphung_27 = translate_text_ngocphung_27(text_ngocphung_27, source_lang="vi", target_lang="en")  # Dịch văn bản
        print(f"Văn bản dịch: {translated_text_ngocphung_27}")  # In ra văn bản đã dịch
        # Chuyển văn bản tiếng Việt thành giọng nói
        text_to_speech_ngocphung_27(text_ngocphung_27, filename="ngocphung_27_vi", lang="vi")
        # Chuyển văn bản tiếng Anh thành giọng nói
        text_to_speech_ngocphung_27(translated_text_ngocphung_27, filename="ngocphung_27_en", lang="en")
    else:
        # Chỉ chuyển văn bản tiếng Việt thành giọng nói
        text_to_speech_ngocphung_27(text_ngocphung_27, filename="ngocphung_27_vi", lang="vi")

# Chạy ứng dụng Voice Assistant
voice_assistant_ngocphung_27()
