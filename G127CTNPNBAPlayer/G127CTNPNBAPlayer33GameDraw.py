import pygame, sys  # Nhập thư viện pygame để phát triển game và thư viện sys để xử lý hệ thống (thoát game)
from pygame.locals import *  # Nhập tất cả các hằng số và đối tượng từ pygame.locals, bao gồm QUIT và các sự kiện khác

# Khai báo kích thước cửa sổ
WINDOWWIDTH = 400  # Chiều rộng cửa sổ game (400 pixels)
WINDOWHEIGHT = 300  # Chiều cao cửa sổ game (300 pixels)

# Định nghĩa các màu sắc cơ bản bằng cách sử dụng giá trị RGB (Red, Green, Blue)
BLACK = (  0,   0,   0)  # Màu đen (RGB: 0, 0, 0)
WHITE = (255, 255, 255)  # Màu trắng (RGB: 255, 255, 255)
RED   = (255,   0,   0)  # Màu đỏ (RGB: 255, 0, 0)
GREEN = (  0, 255,   0)  # Màu xanh lá cây (RGB: 0, 255, 0)
BLUE  = (  0,   0, 255)  # Màu xanh dương (RGB: 0, 0, 255)

pygame.init()  # Khởi tạo tất cả các module của pygame để chuẩn bị sử dụng các tính năng của nó

# Tạo cửa sổ game với kích thước đã định nghĩa (400x300)
DISPLAYSURF = pygame.display.set_mode((WINDOWWIDTH, WINDOWHEIGHT))  
# Thiết lập tiêu đề cửa sổ game là '27 Cao Thi Ngoc Phung = Ex3.3: Vẽ hình đơn giản'
pygame.display.set_caption('27 Cao Thi Ngoc Phung = Ex3.3: Vẽ hình đơn giản')  

# Vòng lặp chính của game, game sẽ tiếp tục chạy cho đến khi người dùng đóng cửa sổ
while True:  
    for event in pygame.event.get():  # Lấy tất cả các sự kiện từ người dùng
        if event.type == QUIT:  # Nếu sự kiện là QUIT (đóng cửa sổ)
            pygame.quit()  # Dừng tất cả các module của pygame
            sys.exit()    # Thoát khỏi hệ thống và đóng ứng dụng

    DISPLAYSURF.fill(WHITE)  # Tô nền cửa sổ với màu trắng (RGB: 255, 255, 255)

    # Vẽ hình chữ nhật đỏ tại vị trí (10, 10), kích thước 100x50 pixels
    pygame.draw.rect(DISPLAYSURF, RED, (10, 10, 100, 50))  

    # Vẽ hình chữ nhật rỗng màu xanh lá, vị trí (150, 10), kích thước 100x50 pixels, độ dày đường viền 2 pixels
    pygame.draw.rect(DISPLAYSURF, GREEN, (150, 10, 100, 50), 2)  

    # Vẽ hình tròn đỏ tại vị trí (50, 100), bán kính 20 pixels
    pygame.draw.circle(DISPLAYSURF, RED, (50, 100), 20)  

    # Vẽ hình tròn rỗng màu xanh dương tại vị trí (200, 100), bán kính 20 pixels, độ dày đường viền 1 pixel
    pygame.draw.circle(DISPLAYSURF, BLUE, (200, 100), 20, 1)  

    # Vẽ hình elip đỏ tại vị trí (10, 150), kích thước 100x50 pixels
    pygame.draw.ellipse(DISPLAYSURF, RED, (10, 150, 100, 50))  

    # Vẽ hình elip rỗng màu xanh lá tại vị trí (150, 150), kích thước 100x50 pixels, độ dày đường viền 3 pixels
    pygame.draw.ellipse(DISPLAYSURF, GREEN, (150, 150, 100, 50), 3)  

    # Vẽ một đa giác đỏ với các đỉnh tại (10,220), (150,230), (100,290), (30,270)
    pygame.draw.polygon(DISPLAYSURF, RED, ((10, 220), (150, 230), (100, 290), (30, 270)))  

    # Vẽ một đa giác rỗng màu xanh dương, độ dày đường viền 2 pixels, với các đỉnh tại (160,220), (300,230), (250,290), (180,270)
    pygame.draw.polygon(DISPLAYSURF, BLUE, ((160, 220), (300, 230), (250, 290), (180, 270)), 2)  

    # Vẽ một đoạn thẳng màu đen từ (300, 50) đến (350, 150) với độ dày đường viền 4 pixels
    pygame.draw.line(DISPLAYSURF, BLACK, (300, 50), (350, 150), 4)  

    # Cập nhật cửa sổ game để các thay đổi (vẽ các hình, màu sắc) được hiển thị trên màn hình
    pygame.display.update()  
