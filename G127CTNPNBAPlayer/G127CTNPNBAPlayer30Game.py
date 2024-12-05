import pygame, sys, random  # Nhập các thư viện pygame, sys và random
from pygame.locals import *  # Nhập các hằng số và các sự kiện từ pygame

WINDOWWIDTH = 400  # Đặt chiều rộng cửa sổ game
WINDOWHEIGHT = 600  # Đặt chiều cao cửa sổ game
pygame.init()  # Khởi tạo pygame
FPS = 60  # Số khung hình trên giây (Frames per second)
fpsClock = pygame.time.Clock()  # Đặt đồng hồ lặp theo nhịp FPS

BGSPEED = 1.5  # Tốc độ cuộn nền
BGIMG = pygame.image.load(r'D:\PYPR (Python Programming)\G127CTNPNBAPlayer\G127CTNPNBAPLayer30Game\back_ground.png')  # Tải ảnh nền

DISPLAYSURF = pygame.display.set_mode((WINDOWWIDTH, WINDOWHEIGHT))  # Tạo cửa sổ game với kích thước đã định
pygame.display.set_caption('27 Cao Thị Ngọc Phụng = Ex3.0: Game = Game ĐUA XE')  # Đặt tiêu đề cho cửa sổ game

class Background():  # Lớp nền của game
    def __init__(self):
        self.x = 0  # Vị trí x của nền
        self.y = 0  # Vị trí y của nền
        self.speed = BGSPEED  # Tốc độ cuộn nền
        self.img = BGIMG  # Hình nền
        self.width = self.img.get_width()  # Chiều rộng của nền
        self.height = self.img.get_height()  # Chiều cao của nền

    def draw(self):  # Vẽ nền
        DISPLAYSURF.blit(self.img, (int(self.x), int(self.y)))  # Vẽ nền tại vị trí x, y
        DISPLAYSURF.blit(self.img, (int(self.x), int(self.y-self.height)))  # Vẽ nền tiếp theo

    def update(self):  # Cập nhật vị trí nền
        self.y += self.speed  # Di chuyển nền xuống dưới
        if self.y > self.height:  # Nếu nền đã cuộn hết thì reset lại vị trí
            self.y -= self.height


X_MARGIN = 80  # Khoảng cách bên trái và phải của xe
CARWIDTH = 40  # Chiều rộng của xe
CARHEIGHT = 60  # Chiều cao của xe
CARSPEED = 3  # Tốc độ di chuyển của xe
CARIMG = pygame.image.load(r'D:\PYPR (Python Programming)\G127CTNPNBAPlayer\G127CTNPNBAPLayer30Game\car_icon_1.png')  # Hình ảnh xe

class Car():  # Lớp xe
    def __init__(self):
        self.width = CARWIDTH  # Đặt chiều rộng cho xe
        self.height = CARHEIGHT  # Đặt chiều cao cho xe
        self.x = (WINDOWWIDTH-self.width)/2  # Vị trí x của xe (giữa màn hình)
        self.y = (WINDOWHEIGHT-self.height)/2  # Vị trí y của xe (giữa màn hình)
        self.speed = CARSPEED  # Tốc độ di chuyển của xe
        self.surface = pygame.Surface((self.width, self.height))  # Tạo một bề mặt cho xe
        self.surface.fill((255, 255, 255))  # Đặt màu trắng cho xe

    def draw(self):  # Vẽ xe
        DISPLAYSURF.blit(CARIMG, (int(self.x), int(self.y)))  # Vẽ hình ảnh xe lên màn hình

    def update(self, moveLeft, moveRight, moveUp, moveDown):  # Cập nhật vị trí của xe
        if moveLeft:  # Nếu người chơi nhấn phím trái
            self.x -= self.speed  # Di chuyển xe sang trái
        if moveRight:  # Nếu người chơi nhấn phím phải
            self.x += self.speed  # Di chuyển xe sang phải
        if moveUp:  # Nếu người chơi nhấn phím lên
            self.y -= self.speed  # Di chuyển xe lên
        if moveDown:  # Nếu người chơi nhấn phím xuống
            self.y += self.speed  # Di chuyển xe xuống
        
        # Giới hạn di chuyển xe
        if self.x < X_MARGIN:
            self.x = X_MARGIN  # Xe không được ra ngoài màn hình bên trái
        if self.x + self.width > WINDOWWIDTH - X_MARGIN:
            self.x = WINDOWWIDTH - X_MARGIN - self.width  # Xe không được ra ngoài màn hình bên phải
        if self.y < 0:
            self.y = 0  # Xe không được ra ngoài màn hình trên
        if self.y + self.height > WINDOWHEIGHT:
            self.y = WINDOWHEIGHT - self.height  # Xe không được ra ngoài màn hình dưới


LANEWIDTH = 60  # Chiều rộng mỗi làn đường
DISTANCE = 200  # Khoảng cách giữa các xe cản trở
OBSTACLESSPEED = 2  # Tốc độ của các vật cản
CHANGESPEED = 0.001  # Tốc độ tăng dần của vật cản
OBSTACLESIMG = pygame.image.load(r'D:\PYPR (Python Programming)\G127CTNPNBAPlayer\G127CTNPNBAPLayer30Game\car_icon_2.png')  # Hình ảnh vật cản

class Obstacles():  # Lớp vật cản
    def __init__(self):
        self.width = CARWIDTH  # Đặt chiều rộng cho vật cản
        self.height = CARHEIGHT  # Đặt chiều cao cho vật cản
        self.distance = DISTANCE  # Khoảng cách giữa các vật cản
        self.speed = OBSTACLESSPEED  # Tốc độ của vật cản
        self.changeSpeed = CHANGESPEED  # Tốc độ thay đổi của vật cản
        self.ls = []  # Danh sách các vật cản
        for i in range(5):  # Khởi tạo 5 vật cản
            y = -CARHEIGHT - i * self.distance  # Đặt vị trí ban đầu của vật cản
            lane = random.randint(0, 3)  # Chọn ngẫu nhiên làn đường
            self.ls.append([lane, y])  # Thêm vật cản vào danh sách

    def draw(self):  # Vẽ các vật cản
        for i in range(5):  # Lặp qua tất cả các vật cản
            x = int(X_MARGIN + self.ls[i][0] * LANEWIDTH + (LANEWIDTH - self.width) / 2)  # Tính toán vị trí x của vật cản
            y = int(self.ls[i][1])  # Lấy vị trí y của vật cản
            DISPLAYSURF.blit(OBSTACLESIMG, (x, y))  # Vẽ vật cản lên màn hình

    def update(self):  # Cập nhật vị trí của các vật cản
        for i in range(5):  # Lặp qua tất cả các vật cản
            self.ls[i][1] += self.speed  # Di chuyển vật cản xuống dưới
        self.speed += self.changeSpeed  # Tăng dần tốc độ vật cản
        if self.ls[0][1] > WINDOWHEIGHT:  # Nếu vật cản ra ngoài màn hình
            self.ls.pop(0)  # Xóa vật cản đầu tiên
            y = self.ls[3][1] - self.distance  # Đặt vị trí mới cho vật cản
            lane = random.randint(0, 3)  # Chọn ngẫu nhiên làn đường
            self.ls.append([lane, y])  # Thêm vật cản vào cuối danh sách


class Score():  # Lớp điểm số
    def __init__(self):
        self.score = 0  # Khởi tạo điểm số

    def draw(self):  # Vẽ điểm số
        font = pygame.font.SysFont('consolas', 30)  # Chọn font chữ
        scoreSuface = font.render('Score: '+str(int(self.score)), True, (0, 0, 0))  # Tạo bề mặt điểm số
        DISPLAYSURF.blit(scoreSuface, (10, 10))  # Vẽ điểm số lên màn hình

    def update(self):  # Cập nhật điểm số
        self.score += 0.02  # Tăng điểm theo thời gian

def rectCollision(rect1, rect2):  # Kiểm tra va chạm giữa 2 hình chữ nhật
    if rect1[0] <= rect2[0] + rect2[2] and rect2[0] <= rect1[0] + rect1[2] and rect1[1] <= rect2[1] + rect2[3] and rect2[1] <= rect1[1] + rect1[3]:
        return True
    return False

def isGameover(car, obstacles):  # Kiểm tra nếu game over
    carRect = [car.x, car.y, car.width, car.height]  # Vị trí và kích thước của xe
    for i in range(5):  # Lặp qua các vật cản
        x = int(X_MARGIN + obstacles.ls[i][0] * LANEWIDTH + (LANEWIDTH - obstacles.width) / 2)  # Tính toán vị trí x của vật cản
        y = int(obstacles.ls[i][1])  # Lấy vị trí y của vật cản
        obstaclesRect = [x, y, obstacles.width, obstacles.height]  # Vị trí và kích thước của vật cản
        if rectCollision(carRect, obstaclesRect):  # Kiểm tra va chạm
            return True
    return False


def gameOver(bg, car, obstacles, score):  # Hàm game over
    font = pygame.font.SysFont('consolas', 60)  # Chọn font chữ
    headingSuface = font.render('GAMEOVER', True, (255, 0, 0))  # Tạo chữ 'GAMEOVER'
    headingSize = headingSuface.get_size()  # Lấy kích thước chữ

    font = pygame.font.SysFont('consolas', 20)  # Chọn font chữ nhỏ cho hướng dẫn
    commentSuface = font.render('Press "space" to replay', True, (0, 0, 0))  # Tạo chữ hướng dẫn
    commentSize = commentSuface.get_size()  # Lấy kích thước chữ hướng dẫn
    while True:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:  # Nếu đóng cửa sổ game
                pygame.quit()
                sys.exit()
            if event.type == pygame.KEYUP:  # Nếu nhấn phím
                if event.key == K_SPACE:  # Nhấn phím space để chơi lại
                    return
        bg.draw()  # Vẽ nền
        car.draw()  # Vẽ xe
        obstacles.draw()  # Vẽ vật cản
        score.draw()  # Vẽ điểm số
        DISPLAYSURF.blit(headingSuface, (int((WINDOWWIDTH - headingSize[0]) / 2), 100))  # Vẽ chữ 'GAMEOVER'
        DISPLAYSURF.blit(commentSuface, (int((WINDOWWIDTH - commentSize[0]) / 2), 400))  # Vẽ hướng dẫn
        pygame.display.update()  # Cập nhật màn hình
        fpsClock.tick(FPS)  # Điều chỉnh tốc độ khung hình


def gameStart(bg):  # Hàm bắt đầu game
    bg.__init__()  # Khởi tạo lại nền
    font = pygame.font.SysFont('consolas', 60)  # Chọn font chữ
    headingSuface = font.render('RACING', True, (255, 0, 0))  # Tạo chữ 'RACING'
    headingSize = headingSuface.get_size()  # Lấy kích thước chữ

    font = pygame.font.SysFont('consolas', 20)  # Chọn font chữ nhỏ cho hướng dẫn
    commentSuface = font.render('Press "space" to play', True, (0, 0, 0))  # Tạo chữ hướng dẫn
    commentSize = commentSuface.get_size()  # Lấy kích thước chữ hướng dẫn
    while True:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:  # Nếu đóng cửa sổ game
                pygame.quit()
                sys.exit()
            if event.type == pygame.KEYUP:  # Nếu nhấn phím
                if event.key == K_SPACE:  # Nhấn phím space để bắt đầu chơi
                    return
        bg.draw()  # Vẽ nền
        DISPLAYSURF.blit(headingSuface, (int((WINDOWWIDTH - headingSize[0]) / 2), 100))  # Vẽ chữ 'RACING'
        DISPLAYSURF.blit(commentSuface, (int((WINDOWWIDTH - commentSize[0]) / 2), 400))  # Vẽ hướng dẫn
        pygame.display.update()  # Cập nhật màn hình
        fpsClock.tick(FPS)  # Điều chỉnh tốc độ khung hình


def gamePlay(bg, car, obstacles, score):  # Hàm chơi game
    car.__init__()  # Khởi tạo lại xe
    obstacles.__init__()  # Khởi tạo lại vật cản
    bg.__init__()  # Khởi tạo lại nền
    score.__init__()  # Khởi tạo lại điểm số
    moveLeft = moveRight = moveUp = moveDown = False  # Khởi tạo trạng thái di chuyển
    while True:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:  # Nếu đóng cửa sổ game
                pygame.quit()
                sys.exit()
            if event.type == KEYDOWN:  # Nếu nhấn phím
                if event.key == K_LEFT:  # Nhấn phím trái để di chuyển trái
                    moveLeft = True
                if event.key == K_RIGHT:  # Nhấn phím phải để di chuyển phải
                    moveRight = True
                if event.key == K_UP:  # Nhấn phím lên để di chuyển lên
                    moveUp = True
                if event.key == K_DOWN:  # Nhấn phím xuống để di chuyển xuống
                    moveDown = True
            if event.type == KEYUP:  # Nếu nhả phím
                if event.key == K_LEFT:  # Nhả phím trái
                    moveLeft = False
                if event.key == K_RIGHT:  # Nhả phím phải
                    moveRight = False
                if event.key == K_UP:  # Nhả phím lên
                    moveUp = False
                if event.key == K_DOWN:  # Nhả phím xuống
                    moveDown = False

        if isGameover(car, obstacles):  # Kiểm tra nếu game over
            return
        bg.draw()  # Vẽ nền
        bg.update()  # Cập nhật nền
        car.draw()  # Vẽ xe
        car.update(moveLeft, moveRight, moveUp, moveDown)  # Cập nhật vị trí xe
        obstacles.draw()  # Vẽ vật cản
        obstacles.update()  # Cập nhật vật cản
        score.draw()  # Vẽ điểm số
        score.update()  # Cập nhật điểm số
        pygame.display.update()  # Cập nhật màn hình
        fpsClock.tick(FPS)  # Điều chỉnh tốc độ khung hình

def main():  # Hàm chính
    bg = Background()  # Tạo đối tượng nền
    car = Car()  # Tạo đối tượng xe
    obstacles = Obstacles()  # Tạo đối tượng vật cản
    score = Score()  # Tạo đối tượng điểm số
    gameStart(bg)  # Bắt đầu game
    while True:
        gamePlay(bg, car, obstacles, score)  # Chơi game
        gameOver(bg, car, obstacles, score)  # Khi game kết thúc thì hiển thị game over

if __name__ == '__main__':  # Nếu chương trình được chạy trực tiếp
    main()  # Gọi hàm chính
