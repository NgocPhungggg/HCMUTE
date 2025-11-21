import os  # Thêm dòng này để import thư viện os
import cv2
import tkinter as tk
from tkinter import filedialog
import numpy as np

# B2: HÀM MỞ file Clips= cắt frames
def OpenFile():
    # biến toàn cục
    global filepath
    # Hộp thoại mở thư mục
    filepath = filedialog.askopenfilename(title="Chọn Clip File", filetypes=(("Clips File (.mp4)", "*.mp4"), ("Movie File (.mov)", "*.mov")))
    lblfile.configure(text="File Video: %s" % filepath)

# B3: HÀM cắt frames và nhận diện hình học
def FramesCap():
    cap = cv2.VideoCapture(filepath)
    count = 0  # biến đếm số khung hình -> bắt đầu từ số 0
    output_dir = r"D:/PYPR (Python Programming)/G127CTNPNBAPlayer/G127CTNPNBAPLayer20CV/ngocphung_27"  # Đường dẫn thư mục lưu ảnh
    
    # Kiểm tra nếu thư mục chưa tồn tại, tạo thư mục mới
    if not os.path.exists(output_dir):
        os.makedirs(output_dir)

    while cap.isOpened():  # trong khi Video clip đang còn phát
        ret, frame = cap.read()  # chụp ra một khung hình: khung chụp được lưu vào biến frame
        if not ret:
            break
        
        # Tiền xử lý hình ảnh (chuyển sang ảnh xám)
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        blurred = cv2.GaussianBlur(gray, (5, 5), 0)
        edges = cv2.Canny(blurred, 50, 150)

        # Tìm các hình vuông (hình chữ nhật) bằng cách tìm các contour
        contours, _ = cv2.findContours(edges, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

        for contour in contours:
            # Lọc các contour quá nhỏ (không phải là hình học)
            if cv2.contourArea(contour) < 500:
                continue

            # Xấp xỉ contour thành một đa giác
            epsilon = 0.04 * cv2.arcLength(contour, True)
            approx = cv2.approxPolyDP(contour, epsilon, True)

            # Kiểm tra nếu là hình vuông (hoặc hình chữ nhật)
            if len(approx) == 4:
                cv2.drawContours(frame, [approx], -1, (0, 255, 0), 3)  # Vẽ hình vuông/chữ nhật

        # Phát hiện hình tròn
        circles = cv2.HoughCircles(gray, cv2.HOUGH_GRADIENT, 1, minDist=50, param1=50, param2=30, minRadius=10, maxRadius=100)
        
        if circles is not None:
            circles = np.round(circles[0, :]).astype("int")
            for (x, y, r) in circles:
                cv2.circle(frame, (x, y), r, (0, 0, 255), 4)  # Vẽ hình tròn
                cv2.rectangle(frame, (x - 5, y - 5), (x + 5, y + 5), (0, 128, 255), -1)

        # Lưu khung hình vào thư mục đã chỉ định
        output_path = os.path.join(output_dir, f"ngocphung_27_khung{count}.jpg")  # Đường dẫn đầy đủ để lưu ảnh
        cv2.imwrite(output_path, frame)  # Lưu ảnh vào thư mục

        # Hiển thị khung hình với các hình học được nhận diện
        cv2.imshow('Khung Hinh', frame)
        
        count += 1  # Tăng chỉ count lên 1 để chuẩn bị lưu khung hình kế tiếp

        # Chờ gõ phím kết thúc là phím 'q'
        if cv2.waitKey(10) & 0xFF == ord('q'):
            break

    cap.release()  # Giải phóng đối tượng VideoCapture
    cv2.destroyAllWindows()  # Đóng tất cả các cửa sổ
    lblfile.configure(text="Tổng số frames: %d" % count)

# B2: THIẾT LẬP & KHỞI TẠO ĐỐI TƯỢNG FORM
wf = tk.Tk()
wf.title("CẮT KHUNG ẢNH TỪ VIDEO CLIPs VÀ NHẬN DIỆN HÌNH HỌC")
wf.geometry("900x500")
wf.resizable(tk.FALSE, tk.FALSE)

# Thiết lập label
tk.Label(wf, text="Chọn file Video:").place(x=10, y=15)

# Thiết lập 1 button
btnOpenFile = tk.Button(wf, text="Open File", command=OpenFile)
btnOpenFile.place(x=120, y=15)

# Thiết lập label hiện tên file
lblfile = tk.Label(wf, text="", relief=tk.SUNKEN)
lblfile.place(x=120, y=50)

# Thiết lập 1 button
btnFrCut = tk.Button(wf, text="Cắt frames và nhận diện hình học", command=FramesCap)
btnFrCut.place(x=200, y=15)

wf.mainloop()
