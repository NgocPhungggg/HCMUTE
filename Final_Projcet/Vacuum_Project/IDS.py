import matplotlib.pyplot as plt
import matplotlib.image as mpimg
import numpy as np
from PIL import Image
import random
from tkinter import messagebox
from copy import copy, deepcopy

# Node Object, biểu diễn một vị trí trong mảng ma trận
class Node:
    def __init__(self, x, y, parent=None):
        self.x = x
        self.y = y
        self.parent = parent

    def set_x(self, x):
        self.x = x

    def set_y(self, y):
        self.y = y

    def get_x(self):
        return self.x

    def get_y(self):
        return self.y

    def set_parent(self, parent):
        self.parent = parent

    def get_parent(self):
        return self.parent

wall = 1 # 1 là tường
cleanstate = 0 # 0 là nơi không có bụi
dustystate = 2 # 2 là nơi có bụi (sẽ được random bụi ở hàm createWorld)

width = 15
matrix = []
presentationMatrix = []

# Sử dụng vòng lặp for để tạo ma trận
for i in range(width):
    row = []
    for j in range(width):
        if i == 0 or i == width - 1 or j == 0 or j == width - 1:
            row.append(wall)
        else:
            row.append(cleanstate)
    matrix.append(row)
    presentationMatrix.append(row)

# nơi xuất phát của máy hút bụi --> vị trí ngẫu nhiên trên ma trận
currLine =  random.randint(1, width - 2)
currCol =  random.randint(1, width - 2)
agentstate = 4 #state hiện tại của agent, giá trị phải khác 0,2,1
stack = [Node(currLine, currCol)]
solution = [Node(currLine, currCol)]
process_map = []

#Tạo thực địa cho agent
def createWorld(m):
    for mI in range(1, width - 2):
        for aI in range(1, width - 2):
            if (mI == 1 and aI == 1):
                continue
            number = random.randint(0,5) #random trạng thấy ô sạch/bẩn ở 1 vị vị trí của ma trận
            if number == dustystate: #nếu number được randon có gía trị = dustystate(2) thì vị trí đó bẩn
                m[mI][aI] = dustystate
            else:
                m[mI][aI] = cleanstate
    renderMatrix(matrix)
    global process_map
    process_map = deepcopy(matrix)
    global presentationMatrix
    presentationMatrix = deepcopy(matrix)

def renderMatrix(matrix): 
    # Đọc hình nền bạn muốn sử dụng
    background_image = plt.imread('D:/AI (Artificial Intelligence)/Vacuum_Project/images/floor.jpg')
    
    rows, cols = width, width
    bg_rows, bg_cols, _= background_image.shape # Xác định kích thước của hình ảnh nền
    
    row_ratio = bg_rows / rows # Tính tỷ lệ chia hàng
    col_ratio = bg_cols / cols # Tính tỷ lệ chia cột
    
    # Hiển thị hình ảnh nền với tỷ lệ chia
    plt.imshow(background_image, extent=(0, bg_cols, 0, bg_rows), alpha=0.5, aspect='auto')

    # Hiển thị ma trận với tỷ lệ chia và màu nền
    plt.imshow(matrix, alpha=0.5, cmap='Greys', extent=(0, bg_cols, 0, bg_rows), aspect='auto')
    
    # Tọa độ của icon trên trục x và trục y
    x_position = currCol * col_ratio + 30
    y_position = bg_rows - 30 - (currLine * row_ratio)

    #o là icon hình tròn, c là màu cyan
    plt.plot(x_position, y_position, 'oc', markersize=15)

    plt.show(block=False)
    plt.pause(0.1) #tốc độ
    plt.clf()    

def mapNotClean(): #kiểm tra vị tí có sạch không
    for i in range(1, width - 2):
        for j in range(1, width - 2):
            if (matrix[i][j] == dustystate): 
                return True #vị trí i,j bằng giá trị dustystate(2) trả về true
    return False


def hasPosition(x, y): #kiểm tra vị tí có thể đi không
    if (matrix[x][y] == wall): 
        return False #vị trí i,j bằng giá trị wall(1) trả về false
    return True


def lookLeft(x, y, node): 
    if (hasPosition(x - 1, y)):
        new_node = Node(x - 1, y, node)
        if (process_map[x - 1][y] == dustystate):
            return new_node
        if (process_map[x - 1][y] != agentstate):
            stack.append(new_node)
            process_map[x - 1][y] = agentstate


def lookRight(x, y, node):
    if (hasPosition(x + 1, y)):
        new_node = Node(x + 1, y, node)
        if (process_map[x + 1][y] == dustystate):
            return new_node
        if (process_map[x + 1][y] != agentstate):
            stack.append(new_node)
            process_map[x + 1][y] = agentstate


def lookAbove(x, y, node):
    if (hasPosition(x, y - 1)):
        new_node = Node(x, y - 1, node)
        if (process_map[x][y - 1] == dustystate):
            return new_node
        if (process_map[x][y - 1] != agentstate):
            stack.append(new_node)
            process_map[x][y - 1] = agentstate


def lookDown(x, y, node):
    if (hasPosition(x, y + 1)):
        new_node = Node(x, y + 1, node)
        if (process_map[x][y + 1] == dustystate):
            return new_node
        if (process_map[x][y + 1] != agentstate):
            stack.append(new_node)
            process_map[x][y + 1] = agentstate


def discoverPath(): #đường agent khám phá
    while (len(stack) != 0):
        node = stack.pop(0)
        x = node.get_x()
        y = node.get_y()

        auxNode = lookLeft(x, y, node)
        if (auxNode):
            return auxNode

        auxNode = lookAbove(x, y, node)
        if (auxNode):
            return auxNode

        auxNode = lookRight(x, y, node)
        if (auxNode):
            return auxNode

        auxNode = lookDown(x, y, node)
        if (auxNode):
            return auxNode


def IDS():
    global matrix
    global process_map
    global stack
    global currCol
    global currLine
    
    createWorld(matrix) #tạo thực địa

    while (mapNotClean()): #vòng lặp tìm bụi, nếu hàm mapNotClean trả về true --> không sạch
        path = discoverPath()
        x = path.get_x()
        y = path.get_y()
        aux_list = [] 

        while (path.get_parent() is not None): # vòng lặp sẽ tiếp tục cho đến khi phương thức get_parent() 
                                                # trên path trả về giá trị khác None.
            aux_list.append(path) # path được thêm vào danh sách aux_list
            path = path.get_parent() 
            
        aux_list.reverse() # đảo ngược reverse
        solution.extend(aux_list) # các phần tử trong aux_list được thêm vào solution

        matrix[x][y] = 0 # gán giá trị cho vị trí x,y bằng 0
        stack = [Node(x, y)] # ds stack chứa Node tại vị trí x, y
        process_map = deepcopy(matrix) #tạo ra một bản sao sâu (deep copy) của ma trận

    for path in solution:
        currCol = path.get_y() #lấy vị trí cột
        currLine = path.get_x() #lấy vị trí hàng 
        renderMatrix(presentationMatrix) # cập nhật matrix vào giao diện
        if (presentationMatrix[currLine][currCol] == dustystate): #tìm thấy được bụi
            presentationMatrix[currLine][currCol] = cleanstate # hút bụi
    renderMatrix(presentationMatrix) #cập nhật lại matrix
    messagebox.showinfo("Hoàn thành", "máy đã hút hết tất cả các bụi")

