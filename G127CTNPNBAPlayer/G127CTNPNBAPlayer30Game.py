import pygame, sys, random  # Nhập các thư viện pygame, sys và random
from pygame.locals import *  # Nhập các hằng số và các sự kiện từ pygame

WINDOWWIDTH_ngocphung_27 = 400  # Đặt chiều rộng cửa sổ game
WINDOWHEIGHT_ngocphung_27 = 600  # Đặt chiều cao cửa sổ game
pygame.init()  # Khởi tạo pygame
FPS_ngocphung_27 = 60  # Số khung hình trên giây (Frames per second)
fpsClock_ngocphung_27 = pygame.time.Clock()  # Đặt đồng hồ lặp theo nhịp FPS

BGSPEED_ngocphung_27 = 1.5  # Tốc độ cuộn nền
BGIMG_ngocphung_27 = pygame.image.load(r'D:\PYPR (Python Programming)\G127CTNPNBAPlayer\G127CTNPNBAPLayer30Game\back_ground.png')  # Tải ảnh nền

DISPLAYSURF_ngocphung_27 = pygame.display.set_mode((WINDOWWIDTH_ngocphung_27, WINDOWHEIGHT_ngocphung_27))  # Tạo cửa sổ game với kích thước đã định
pygame.display.set_caption('27 Cao Thị Ngọc Phụng = Ex3.0: Game = Game ĐUA XE')  # Đặt tiêu đề cho cửa sổ game

class Background_ngocphung_27():  # Lớp nền của game
    def __init__(self):
        self.x_ngocphung_27 = 0  # Vị trí x của nền
        self.y_ngocphung_27 = 0  # Vị trí y của nền
        self.speed_ngocphung_27 = BGSPEED_ngocphung_27  # Tốc độ cuộn nền
        self.img_ngocphung_27 = BGIMG_ngocphung_27  # Hình nền
        self.width_ngocphung_27 = self.img_ngocphung_27.get_width()  # Chiều rộng của nền
        self.height_ngocphung_27 = self.img_ngocphung_27.get_height()  # Chiều cao của nền

    def draw_ngocphung_27(self):  # Vẽ nền
        DISPLAYSURF_ngocphung_27.blit(self.img_ngocphung_27, (int(self.x_ngocphung_27), int(self.y_ngocphung_27)))  # Vẽ nền tại vị trí x, y
        DISPLAYSURF_ngocphung_27.blit(self.img_ngocphung_27, (int(self.x_ngocphung_27), int(self.y_ngocphung_27-self.height_ngocphung_27)))  # Vẽ nền tiếp theo

    def update_ngocphung_27(self):  # Cập nhật vị trí nền
        self.y_ngocphung_27 += self.speed_ngocphung_27  # Di chuyển nền xuống dưới
        if self.y_ngocphung_27 > self.height_ngocphung_27:  # Nếu nền đã cuộn hết thì reset lại vị trí
            self.y_ngocphung_27 -= self.height_ngocphung_27


X_MARGIN_ngocphung_27 = 80  # Khoảng cách bên trái và phải của xe
CARWIDTH_ngocphung_27 = 40  # Chiều rộng của xe
CARHEIGHT_ngocphung_27 = 60  # Chiều cao của xe
CARSPEED_ngocphung_27 = 3  # Tốc độ di chuyển của xe
CARIMG_ngocphung_27 = pygame.image.load(r'D:\PYPR (Python Programming)\G127CTNPNBAPlayer\G127CTNPNBAPLayer30Game\car_icon_1.png')  # Hình ảnh xe

class Car_ngocphung_27():  # Lớp xe
    def __init__(self):
        self.width_ngocphung_27 = CARWIDTH_ngocphung_27  # Đặt chiều rộng cho xe
        self.height_ngocphung_27 = CARHEIGHT_ngocphung_27  # Đặt chiều cao cho xe
        self.x_ngocphung_27 = (WINDOWWIDTH_ngocphung_27-self.width_ngocphung_27)/2  # Vị trí x của xe (giữa màn hình)
        self.y_ngocphung_27 = (WINDOWHEIGHT_ngocphung_27-self.height_ngocphung_27)/2  # Vị trí y của xe (giữa màn hình)
        self.speed_ngocphung_27 = CARSPEED_ngocphung_27  # Tốc độ di chuyển của xe
        self.surface_ngocphung_27 = pygame.Surface((self.width_ngocphung_27, self.height_ngocphung_27))  # Tạo một bề mặt cho xe
        self.surface_ngocphung_27.fill((255, 255, 255))  # Đặt màu trắng cho xe

    def draw_ngocphung_27(self):  # Vẽ xe
        DISPLAYSURF_ngocphung_27.blit(CARIMG_ngocphung_27, (int(self.x_ngocphung_27), int(self.y_ngocphung_27)))  # Vẽ hình ảnh xe lên màn hình

    def update_ngocphung_27(self, moveLeft, moveRight, moveUp, moveDown):  # Cập nhật vị trí của xe
        if moveLeft:  # Nếu người chơi nhấn phím trái
            self.x_ngocphung_27 -= self.speed_ngocphung_27  # Di chuyển xe sang trái
        if moveRight:  # Nếu người chơi nhấn phím phải
            self.x_ngocphung_27 += self.speed_ngocphung_27  # Di chuyển xe sang phải
        if moveUp:  # Nếu người chơi nhấn phím lên
            self.y_ngocphung_27 -= self.speed_ngocphung_27  # Di chuyển xe lên
        if moveDown:  # Nếu người chơi nhấn phím xuống
            self.y_ngocphung_27 += self.speed_ngocphung_27  # Di chuyển xe xuống
        
        # Giới hạn di chuyển xe
        if self.x_ngocphung_27 < X_MARGIN_ngocphung_27:
            self.x_ngocphung_27 = X_MARGIN_ngocphung_27  # Xe không được ra ngoài màn hình bên trái
        if self.x_ngocphung_27 + self.width_ngocphung_27 > WINDOWWIDTH_ngocphung_27 - X_MARGIN_ngocphung_27:
            self.x_ngocphung_27 = WINDOWWIDTH_ngocphung_27 - X_MARGIN_ngocphung_27 - self.width_ngocphung_27  # Xe không được ra ngoài màn hình bên phải
        if self.y_ngocphung_27 < 0:
            self.y_ngocphung_27 = 0  # Xe không được ra ngoài màn hình trên
        if self.y_ngocphung_27 + self.height_ngocphung_27 > WINDOWHEIGHT_ngocphung_27:
            self.y_ngocphung_27 = WINDOWHEIGHT_ngocphung_27 - self.height_ngocphung_27  # Xe không được ra ngoài màn hình dưới


LANEWIDTH_ngocphung_27 = 60  # Chiều rộng mỗi làn đường
DISTANCE_ngocphung_27 = 200  # Khoảng cách giữa các xe cản trở
OBSTACLESSPEED_ngocphung_27 = 2  # Tốc độ của các vật cản
CHANGESPEED_ngocphung_27 = 0.001  # Tốc độ tăng dần của vật cản
OBSTACLESIMG_ngocphung_27 = pygame.image.load(r'D:\PYPR (Python Programming)\G127CTNPNBAPlayer\G127CTNPNBAPLayer30Game\car_icon_2.png')  # Hình ảnh vật cản

class Obstacles_ngocphung_27():  # Lớp vật cản
    def __init__(self):
        self.width_ngocphung_27 = CARWIDTH_ngocphung_27  # Đặt chiều rộng cho vật cản
        self.height_ngocphung_27 = CARHEIGHT_ngocphung_27  # Đặt chiều cao cho vật cản
        self.distance_ngocphung_27 = DISTANCE_ngocphung_27  # Khoảng cách giữa các vật cản
        self.speed_ngocphung_27 = OBSTACLESSPEED_ngocphung_27  # Tốc độ của vật cản
        self.changeSpeed_ngocphung_27 = CHANGESPEED_ngocphung_27  # Tốc độ thay đổi của vật cản
        self.ls_ngocphung_27 = []  # Danh sách các vật cản

    def create_ngocphung_27(self):  # Tạo các vật cản mới
        self.ls_ngocphung_27.append([random.randint(X_MARGIN_ngocphung_27, WINDOWWIDTH_ngocphung_27 - self.width_ngocphung_27), -self.height_ngocphung_27])

    def draw_ngocphung_27(self):  # Vẽ các vật cản
        for obs_ngocphung_27 in self.ls_ngocphung_27:
            DISPLAYSURF_ngocphung_27.blit(OBSTACLESIMG_ngocphung_27, (int(obs_ngocphung_27[0]), int(obs_ngocphung_27[1])))  # Vẽ hình ảnh vật cản lên màn hình

    def update_ngocphung_27(self):  # Cập nhật vị trí các vật cản
        for obs_ngocphung_27 in self.ls_ngocphung_27:
            obs_ngocphung_27[1] += self.speed_ngocphung_27  # Di chuyển vật cản xuống dưới
        self.ls_ngocphung_27 = [obs_ngocphung_27 for obs_ngocphung_27 in self.ls_ngocphung_27 if obs_ngocphung_27[1] < WINDOWHEIGHT_ngocphung_27]  # Loại bỏ các vật cản đã đi ra ngoài màn hình


def checkHit_ngocphung_27(car_ngocphung_27, obstacles_ngocphung_27):  # Kiểm tra va chạm giữa xe và vật cản
    for obs_ngocphung_27 in obstacles_ngocphung_27.ls_ngocphung_27:
        if (car_ngocphung_27.x_ngocphung_27 < obs_ngocphung_27[0] + CARWIDTH_ngocphung_27 and 
            car_ngocphung_27.x_ngocphung_27 + CARWIDTH_ngocphung_27 > obs_ngocphung_27[0] and 
            car_ngocphung_27.y_ngocphung_27 < obs_ngocphung_27[1] + CARHEIGHT_ngocphung_27 and 
            car_ngocphung_27.y_ngocphung_27 + CARHEIGHT_ngocphung_27 > obs_ngocphung_27[1]):  # Kiểm tra va chạm
            return True  # Nếu có va chạm thì trả về True
    return False  # Không có va chạm


def main_ngocphung_27():
    background_ngocphung_27 = Background_ngocphung_27()  # Khởi tạo nền
    car_ngocphung_27 = Car_ngocphung_27()  # Khởi tạo xe
    obstacles_ngocphung_27 = Obstacles_ngocphung_27()  # Khởi tạo vật cản

    moveLeft_ngocphung_27 = moveRight_ngocphung_27 = moveUp_ngocphung_27 = moveDown_ngocphung_27 = False  # Khởi tạo trạng thái di chuyển
    score_ngocphung_27 = 0  # Điểm số ban đầu

    while True:
        for event_ngocphung_27 in pygame.event.get():
            if event_ngocphung_27.type == QUIT:
                pygame.quit()  # Thoát khỏi game
                sys.exit()

            if event_ngocphung_27.type == KEYDOWN:
                if event_ngocphung_27.key == K_LEFT:  # Nhấn phím trái
                    moveLeft_ngocphung_27 = True
                if event_ngocphung_27.key == K_RIGHT:  # Nhấn phím phải
                    moveRight_ngocphung_27 = True
                if event_ngocphung_27.key == K_UP:  # Nhấn phím lên
                    moveUp_ngocphung_27 = True
                if event_ngocphung_27.key == K_DOWN:  # Nhấn phím xuống
                    moveDown_ngocphung_27 = True

            if event_ngocphung_27.type == KEYUP:
                if event_ngocphung_27.key == K_LEFT:  # Thả phím trái
                    moveLeft_ngocphung_27 = False
                if event_ngocphung_27.key == K_RIGHT:  # Thả phím phải
                    moveRight_ngocphung_27 = False
                if event_ngocphung_27.key == K_UP:  # Thả phím lên
                    moveUp_ngocphung_27 = False
                if event_ngocphung_27.key == K_DOWN:  # Thả phím xuống
                    moveDown_ngocphung_27 = False

        background_ngocphung_27.update_ngocphung_27()  # Cập nhật nền
        obstacles_ngocphung_27.update_ngocphung_27()  # Cập nhật vật cản
        car_ngocphung_27.update_ngocphung_27(moveLeft_ngocphung_27, moveRight_ngocphung_27, moveUp_ngocphung_27, moveDown_ngocphung_27)  # Cập nhật xe

        if random.randint(1, 60) == 1:  # Tạo vật cản mới
            obstacles_ngocphung_27.create_ngocphung_27()

        if checkHit_ngocphung_27(car_ngocphung_27, obstacles_ngocphung_27):  # Kiểm tra va chạm
            pygame.quit()
            sys.exit()

        DISPLAYSURF_ngocphung_27.fill((0, 0, 0))  # Lấp đầy màn hình với màu đen
        background_ngocphung_27.draw_ngocphung_27()  # Vẽ nền
        obstacles_ngocphung_27.draw_ngocphung_27()  # Vẽ vật cản
        car_ngocphung_27.draw_ngocphung_27()  # Vẽ xe

        pygame.display.update()  # Cập nhật màn hình
        fpsClock_ngocphung_27.tick(FPS_ngocphung_27)  # Điều khiển FPS


if __name__ == "__main__":
    main_ngocphung_27()  # Chạy game
