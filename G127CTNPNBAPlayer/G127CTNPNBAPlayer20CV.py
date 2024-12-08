import os  # Thêm dòng này để import thư viện os
import cv2
import tkinter as tk
from tkinter import filedialog
import numpy as np

# B2: HÀM MỞ file Clips= cắt frames
def OpenFile_ngocphung_27():
    # biến toàn cục
    global filepath_ngocphung_27
    # Hộp thoại mở thư mục
    filepath_ngocphung_27 = filedialog.askopenfilename(title="Chọn Clip File", filetypes=(("Clips File (.mp4)", "*.mp4"), ("Movie File (.mov)", "*.mov")))
    lblfile_ngocphung_27.configure(text="File Video: %s" % filepath_ngocphung_27)

# B3: HÀM cắt frames và nhận diện hình học
def FramesCap_ngocphung_27():
    cap_ngocphung_27 = cv2.VideoCapture(filepath_ngocphung_27)
    count_ngocphung_27 = 0  # biến đếm số khung hình -> bắt đầu từ số 0
    output_dir_ngocphung_27 = r"D:/PYPR (Python Programming)/G127CTNPNBAPlayer/G127CTNPNBAPLayer20CV/ngocphung_27"  # Đường dẫn thư mục lưu ảnh
    
    # Kiểm tra nếu thư mục chưa tồn tại, tạo thư mục mới
    if not os.path.exists(output_dir_ngocphung_27):
        os.makedirs(output_dir_ngocphung_27)

    while cap_ngocphung_27.isOpened():  # trong khi Video clip đang còn phát
        ret_ngocphung_27, frame_ngocphung_27 = cap_ngocphung_27.read()  # chụp ra một khung hình: khung chụp được lưu vào biến frame
        if not ret_ngocphung_27:
            break
        
        # Tiền xử lý hình ảnh (chuyển sang ảnh xám)
        gray_ngocphung_27 = cv2.cvtColor(frame_ngocphung_27, cv2.COLOR_BGR2GRAY)
        blurred_ngocphung_27 = cv2.GaussianBlur(gray_ngocphung_27, (5, 5), 0)
        edges_ngocphung_27 = cv2.Canny(blurred_ngocphung_27, 50, 150)

        # Tìm các hình vuông (hình chữ nhật) bằng cách tìm các contour
        contours_ngocphung_27, _ = cv2.findContours(edges_ngocphung_27, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

        for contour_ngocphung_27 in contours_ngocphung_27:
            # Lọc các contour quá nhỏ (không phải là hình học)
            if cv2.contourArea(contour_ngocphung_27) < 500:
                continue

            # Xấp xỉ contour thành một đa giác
            epsilon_ngocphung_27 = 0.04 * cv2.arcLength(contour_ngocphung_27, True)
            approx_ngocphung_27 = cv2.approxPolyDP(contour_ngocphung_27, epsilon_ngocphung_27, True)

            # Kiểm tra nếu là hình vuông (hoặc hình chữ nhật)
            if len(approx_ngocphung_27) == 4:
                cv2.drawContours(frame_ngocphung_27, [approx_ngocphung_27], -1, (0, 255, 0), 3)  # Vẽ hình vuông/chữ nhật

        # Phát hiện hình tròn
        circles_ngocphung_27 = cv2.HoughCircles(gray_ngocphung_27, cv2.HOUGH_GRADIENT, 1, minDist=50, param1=50, param2=30, minRadius=10, maxRadius=100)
        
        if circles_ngocphung_27 is not None:
            circles_ngocphung_27 = np.round(circles_ngocphung_27[0, :]).astype("int")
            for (x_ngocphung_27, y_ngocphung_27, r_ngocphung_27) in circles_ngocphung_27:
                cv2.circle(frame_ngocphung_27, (x_ngocphung_27, y_ngocphung_27), r_ngocphung_27, (0, 0, 255), 4)  # Vẽ hình tròn
                cv2.rectangle(frame_ngocphung_27, (x_ngocphung_27 - 5, y_ngocphung_27 - 5), (x_ngocphung_27 + 5, y_ngocphung_27 + 5), (0, 128, 255), -1)

        # Lưu khung hình vào thư mục đã chỉ định
        output_path_ngocphung_27 = os.path.join(output_dir_ngocphung_27, f"ngocphung_27_khung{count_ngocphung_27}.jpg")  # Đường dẫn đầy đủ để lưu ảnh
        cv2.imwrite(output_path_ngocphung_27, frame_ngocphung_27)  # Lưu ảnh vào thư mục

        # Hiển thị khung hình với các hình học được nhận diện
        cv2.imshow('Khung Hinh', frame_ngocphung_27)
        
        count_ngocphung_27 += 1  # Tăng chỉ count lên 1 để chuẩn bị lưu khung hình kế tiếp

        # Chờ gõ phím kết thúc là phím 'q'
        if cv2.waitKey(10) & 0xFF == ord('q'):
            break

    cap_ngocphung_27.release()  # Giải phóng đối tượng VideoCapture
    cv2.destroyAllWindows()  # Đóng tất cả các cửa sổ
    lblfile_ngocphung_27.configure(text="Tổng số frames: %d" % count_ngocphung_27)

# B2: THIẾT LẬP & KHỞI TẠO ĐỐI TƯỢNG FORM
wf_ngocphung_27 = tk.Tk()
wf_ngocphung_27.title("CẮT KHUNG ẢNH TỪ VIDEO CLIPs VÀ NHẬN DIỆN HÌNH HỌC")
wf_ngocphung_27.geometry("900x500")
wf_ngocphung_27.resizable(tk.FALSE, tk.FALSE)

# Thiết lập label
tk.Label(wf_ngocphung_27, text="Chọn file Video:").place(x=10, y=15)

# Thiết lập 1 button
btnOpenFile_ngocphung_27 = tk.Button(wf_ngocphung_27, text="Open File", command=OpenFile_ngocphung_27)
btnOpenFile_ngocphung_27.place(x=120, y=15)

# Thiết lập label hiện tên file
lblfile_ngocphung_27 = tk.Label(wf_ngocphung_27, text="", relief=tk.SUNKEN)
lblfile_ngocphung_27.place(x=120, y=50)

# Thiết lập 1 button
btnFrCut_ngocphung_27 = tk.Button(wf_ngocphung_27, text="Cắt frames và nhận diện hình học", command=FramesCap_ngocphung_27)
btnFrCut_ngocphung_27.place(x=200, y=15)

wf_ngocphung_27.mainloop()
