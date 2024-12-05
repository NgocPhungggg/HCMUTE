import pygame, sys  # Nhập thư viện pygame để phát triển game và thư viện sys để xử lý hệ thống (thoát game)
from pygame.locals import *  # Nhập tất cả các hằng số và đối tượng từ pygame.locals, bao gồm các phím và sự kiện như QUIT, KEYDOWN, KEYUP

# Khai báo kích thước cửa sổ game
WINDOWWIDTH = 400  # Chiều rộng cửa sổ game (400 pixels)
WINDOWHEIGHT = 300  # Chiều cao cửa sổ game (300 pixels)

# Định nghĩa các màu sắc cơ bản bằng cách sử dụng giá trị RGB (Red, Green, Blue)
BLACK = (  0,   0,   0)  # Màu đen (RGB: 0, 0, 0)
WHITE = (255, 255, 255)  # Màu trắng (RGB: 255, 255, 255)
RED   = (255,   0,   0)  # Màu đỏ (RGB: 255, 0, 0)
GREEN = (  0, 255,   0)  # Màu xanh lá cây (RGB: 0, 255, 0)
BLUE  = (  0,   0, 255)  # Màu xanh dương (RGB: 0, 0, 255)
pygame.init() 

DISPLAYSURF = pygame.display.set_mode((WINDOWWIDTH, WINDOWHEIGHT))  
pygame.display.set_caption('27 Cao Thị Ngọc Phung = Ex3.4: Game đơn giản = Game CHẠY XE')  # Thiết lập tiêu đề cho cửa sổ game

# Xác định FPS (frames per second) - số khung hình mỗi giây, 60 FPS là một tốc độ mượt mà cho game
FPS = 60  # 60 khung hình mỗi giây [>= 24] ==> cho người chơi chọn hoặc nhập
fpsClock = pygame.time.Clock()  # Tạo một đồng hồ để điều khiển tốc độ khung hình của game

# Định nghĩa lớp Car (xe) cho game, để tạo đối tượng xe và điều khiển nó
class Car():
    def __init__(self):
        self.x = 100  # Vị trí ban đầu của xe trên trục x, cho người chơi chọn

        # Tạo surface và thêm hình ảnh chiếc xe vào game từ một file ảnh
        self.surface = pygame.image.load('D:/PYPR (Python Programming)/G127CTNPNBAPlayer/G127CTNPNBAPlayer30Game/car_icon_3.png')  # Tải ảnh chiếc xe từ đường dẫn mới

    def draw(self):  # Hàm vẽ xe lên màn hình
        DISPLAYSURF.blit(self.surface, (self.x, 100))  # Vẽ ảnh xe vào vị trí (self.x, 100) trên màn hình

    def update(self, moveLeft, moveRight):  # Hàm cập nhật vị trí của xe khi di chuyển
        if moveLeft == True:  # Nếu phím trái được nhấn, di chuyển xe sang trái
            self.x -= 2  # Di chuyển xe sang trái 2 pixels
        if moveRight == True:  # Nếu phím phải được nhấn, di chuyển xe sang phải
            self.x += 2  # Di chuyển xe sang phải 2 pixels

        # Kiểm tra xem xe có vượt ra ngoài biên giới cửa sổ không, nếu có thì điều chỉnh lại vị trí
        if self.x + 100 > WINDOWWIDTH:  # Nếu xe ra ngoài biên phải của cửa sổ
            self.x = WINDOWWIDTH - 100  # Đặt xe vào sát biên phải
        if self.x < 0:  # Nếu xe ra ngoài biên trái của cửa sổ
            self.x = 0  # Đặt xe vào sát biên trái

# Tạo đối tượng xe
car = Car()

# Khai báo biến để kiểm tra xem người chơi có nhấn phím trái hoặc phải không
moveLeft = False
moveRight = False

# B4: Vòng lặp chính của game, chạy liên tục cho đến khi người dùng đóng cửa sổ
while True:  
    for event in pygame.event.get():  # Lấy tất cả các sự kiện (nhấn phím, đóng cửa sổ, v.v.)
        if event.type == QUIT:  # Nếu sự kiện là đóng cửa sổ (nút x trên cùng bên phải)
            pygame.quit()  # Dừng tất cả các module của pygame
            sys.exit()  # Thoát chương trình và hệ thống
        if event.type == KEYDOWN:  # Nếu phím được nhấn xuống
            if event.key == K_LEFT:  # Nếu phím trái được nhấn
                moveLeft = True  # Đặt biến moveLeft thành True, xe sẽ di chuyển sang trái
            if event.key == K_RIGHT:  # Nếu phím phải được nhấn
                moveRight = True  # Đặt biến moveRight thành True, xe sẽ di chuyển sang phải

        if event.type == KEYUP:  # Nếu phím được nhả lên
            if event.key == K_LEFT:  # Nếu phím trái được nhả
                moveLeft = False  # Đặt biến moveLeft thành False, dừng xe
            if event.key == K_RIGHT:  # Nếu phím phải được nhả
                moveRight = False  # Đặt biến moveRight thành False, dừng xe

    DISPLAYSURF.fill(WHITE)  # Tô nền cửa sổ với màu trắng trước khi vẽ lại mọi thứ

    car.draw()  # Vẽ chiếc xe lên cửa sổ game

    # Cập nhật và vẽ lại cửa sổ
    pygame.display.update()  # Cập nhật màn hình

    car.update(moveLeft, moveRight)  # Cập nhật vị trí của xe, di chuyển xe nếu phím trái/phải được nhấn
    pygame.display.update()  # Cập nhật lại màn hình sau khi di chuyển xe
    # Điều chỉnh tốc độ khung hình theo tốc độ FPS
    fpsClock.tick(FPS)  # Giới hạn game ở 60 khung hình mỗi giây
