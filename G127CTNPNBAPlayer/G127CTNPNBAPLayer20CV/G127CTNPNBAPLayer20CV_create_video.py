import cv2
import numpy as np
import os

# Đặc tả các thông số cho video
frame_width = 640
frame_height = 480
fps = 1  # Mỗi frame sẽ hiển thị trong 1 giây
frame_count = 3  # Tổng số hình bạn muốn hiển thị (1 hình = 1 frame)

# Đường dẫn lưu video vào thư mục cụ thể
save_dir = r"D:\PYPR (Python Programming)\G127CTNPNBAPlayer\G127CTNPNBAPLayer20CV\ngocphung_27"

# Kiểm tra và tạo thư mục nếu chưa tồn tại
if not os.path.exists(save_dir):
    os.makedirs(save_dir)

# Khởi tạo video writer để lưu video
fourcc = cv2.VideoWriter_fourcc(*'mp4v')  # Định dạng video
video_out = cv2.VideoWriter(os.path.join(save_dir, 'ngocphung_27_create_video.mp4'), fourcc, fps, (frame_width, frame_height))

# Tạo video với hình học cơ bản
frame_list = []  # Danh sách chứa các frame hình học

# Tạo các frame với hình học
for i in range(frame_count):
    # Tạo một frame trắng
    frame = np.ones((frame_height, frame_width, 3), dtype=np.uint8) * 255
    
    # Vẽ hình học tùy theo số frame
    if i == 0:  # Vẽ hình tròn
        center = (int(frame_width / 2), int(frame_height / 2))
        radius = 50  # Kích thước hình tròn
        color = (0, 255, 0)  # Màu xanh lá cây
        thickness = 3
        frame = cv2.circle(frame, center, radius, color, thickness)

    elif i == 1:  # Vẽ hình vuông
        top_left = (50, 200)
        bottom_right = (frame_width - 50, 300)
        frame = cv2.rectangle(frame, top_left, bottom_right, (255, 0, 0), 2)  # Màu xanh dương

    elif i == 2:  # Vẽ đường thẳng
        line_start = (50 + i * 5, 50)
        line_end = (50 + i * 5, frame_height - 50)
        frame = cv2.line(frame, line_start, line_end, (0, 0, 255), 2)  # Màu đỏ
    
    # Thêm frame vào danh sách
    frame_list.append(frame)

# Số lượng vòng lặp trong video (lặp lại các hình học)
repeat_count = 10  # Video sẽ lặp lại 10 lần

# Tạo video với các frame đã tạo trước đó
for _ in range(repeat_count):
    for frame in frame_list:
        # Lưu từng frame vào video
        video_out.write(frame)

        # Hiển thị frame
        cv2.imshow("Frame", frame)
        cv2.waitKey(1000)  # Đợi 1 giây (1000 ms) giữa các frame

# Giải phóng đối tượng VideoWriter và đóng tất cả các cửa sổ
video_out.release()
cv2.destroyAllWindows()
print("Video đã được tạo và lưu thành công!")
