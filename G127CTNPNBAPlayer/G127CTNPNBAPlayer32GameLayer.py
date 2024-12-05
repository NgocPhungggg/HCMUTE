import pygame, sys  # Nhập thư viện pygame (để phát triển game) và sys (để thoát ứng dụng)
from pygame.locals import *  # Nhập tất cả các hằng số và đối tượng từ pygame.locals, giúp sử dụng các hằng như QUIT mà không cần gọi pygame.QUIT
pygame.init()  # Khởi tạo tất cả các module của Pygame để sẵn sàng sử dụng các tính năng của Pygame
DISPLAYSURF = pygame.display.set_mode((400, 300))  # Tạo cửa sổ game với kích thước 400x300 pixels và lưu đối tượng cửa sổ vào biến DISPLAYSURF
pygame.display.set_caption('27 Cao Thị Ngọc Phụng = Ex3.2: Surface = Layer')  # Thiết lập tiêu đề cửa sổ game
while True:  # Vòng lặp chính của game, chạy liên tục cho đến khi có sự kiện thoát
    for event in pygame.event.get():  # Lấy tất cả các sự kiện xảy ra (như nhấn phím, di chuyển chuột...)
        if event.type == QUIT:  # Nếu sự kiện là QUIT (đóng cửa sổ game)
            pygame.quit()  # Dừng tất cả các module của Pygame
            sys.exit()  # Thoát khỏi hệ thống và đóng ứng dụng
    DISPLAYSURF.fill((255, 255, 255))  # Tô nền cửa sổ game với màu trắng (RGB: 255, 255, 255)
    surface2rect = pygame.Surface((150, 50))  # Tạo một Surface (một lớp vẽ) có kích thước 150x50 pixels
    surface2rect.fill((0, 255, 0))  # Tô màu cho surface2rect với màu xanh lá cây (RGB: 0, 255, 0)
    pygame.draw.rect(surface2rect, (255, 0, 0), (20, 20, 50, 20))  # Vẽ một hình chữ nhật đỏ (RGB: 255, 0, 0) trên surface2rect, tại vị trí (20, 20) và kích thước 50x20 pixels
    DISPLAYSURF.blit(surface2rect, (100, 80))  # Dùng phương thức blit để vẽ (đặt) surface2rect lên màn hình tại vị trí (100, 80)
    pygame.display.update()  # Cập nhật màn hình hiển thị để tất cả các thay đổi trên surface được hiển thị
