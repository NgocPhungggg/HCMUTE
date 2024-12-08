import pygame, sys  # Nhập thư viện pygame để phát triển game và sys để xử lý các lệnh hệ thống
from pygame.locals import *  # Nhập tất cả các hằng số và đối tượng từ pygame.locals, giúp sử dụng các hằng như QUIT mà không cần gọi pygame.QUIT
pygame.init()  # Khởi tạo tất cả các module của Pygame để sẵn sàng sử dụng
DISPLAYSURF = pygame.display.set_mode((400, 300))  # Tạo cửa sổ game với kích thước 400x300 pixels và gán vào biến DISPLAYSURF
pygame.display.set_caption('27 Cao Thị Ngọc Phụng = Ex3.1: Màn hình (cửa sổ) Game')  # Thiết lập tiêu đề cửa sổ game
while True:  # Bắt đầu vòng lặp chính của game, vòng lặp này sẽ chạy mãi cho đến khi có sự kiện thoát
    for event in pygame.event.get():  # Lấy tất cả sự kiện đã xảy ra trong game (như nhấn phím, di chuyển chuột...)
        if event.type == QUIT:  # Nếu sự kiện là QUIT (đóng cửa sổ game)
            pygame.quit()  # Dừng tất cả các module của Pygame
            sys.exit()  # Thoát khỏi hệ thống và đóng ứng dụng
    DISPLAYSURF.fill((255, 255, 255))  # Tô nền cửa sổ với màu trắng (RGB: 255, 255, 255)
    pygame.draw.rect(DISPLAYSURF, (255, 0, 0), (100, 80, 150, 50))  # Vẽ một hình chữ nhật màu đỏ (khung đỏ) tại vị trí (100, 80) với kích thước 150x50 (dòng này đã bị chú thích, có thể dùng để thử nghiệm)
