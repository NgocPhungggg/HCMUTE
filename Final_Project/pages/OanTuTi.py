import random
import cv2
import os
import streamlit as st
import base64
import mediapipe as mp
import numpy as np

st.set_page_config(
    page_title="Rock Paper Scissors Game",
    page_icon="✋",
)

def add_bg_from_local(image_file):
    with open(image_file, "rb") as image_file:
        encoded_string = base64.b64encode(image_file.read())
    st.markdown(
        f"""
        <style>
        .stApp {{
            background-image: url(data:image/{"jpg"};base64,{encoded_string.decode()});
            background-size: cover;
        }}
        </style>
        """,
        unsafe_allow_html=True
    )

add_bg_from_local('E:/TAI_LIEU_DAI_HOC/SEMESTER_6/XuLyAnh/FinalProject/Background/OneTwoThree.png')  

st.markdown("""
<style>
    [data-testid=stSidebar] {
        background-color: #7F736A;
    }
    .red-text {
        color: red;
    }
    button {
        background-color: green;
        color: white;
        border-radius: 20px;
    }
</style>
""", unsafe_allow_html=True)

Hands = mp.solutions.hands
Draw = mp.solutions.drawing_utils

class HandDetector:
    def __init__(self, max_num_hands=2, min_detection_confidence=0.5, min_tracking_confidence=0.5):
        self.hands = Hands.Hands(max_num_hands=max_num_hands, min_detection_confidence=min_detection_confidence,
                                 min_tracking_confidence=min_tracking_confidence)

    def findHandLandMarks(self, image, handNumber=0, draw=False):
        originalImage = image
        image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)  # mediapipe needs RGB
        results = self.hands.process(image)
        landMarkList = []

        if results.multi_handedness:
            label = results.multi_handedness[handNumber].classification[0].label  # label gives if hand is left or right
            # account for inversion in cam
            if label == "Left":
                label = "Right"
            elif label == "Right":
                label = "Left"

        if results.multi_hand_landmarks:  # returns None if hand is not found
            hand = results.multi_hand_landmarks[handNumber]  # results.multi_hand_landmarks returns landMarks for all the hands

            for id, landMark in enumerate(hand.landmark):
                # landMark holds x,y,z ratios of single landmark
                imgH, imgW, imgC = originalImage.shape  # height, width, channel for image
                xPos, yPos = int(landMark.x * imgW), int(landMark.y * imgH)
                landMarkList.append([id, xPos, yPos, label])

            if draw:
                Draw.draw_landmarks(originalImage, hand, Hands.HAND_CONNECTIONS)
        return landMarkList

handDetector = HandDetector(min_detection_confidence=0.7)

def draw_results(frame, user_draw):
    # Cho máy sinh ra lựa chọn ngẫu nhiên
    com_draw = random.randint(0, 2)

    # Vẽ hình, viết chữ theo user_draw
    frame = cv2.putText(frame, 'You', (50, 50), cv2.FONT_HERSHEY_SIMPLEX,
                        1, (0, 255, 0), 2, cv2.LINE_AA)

    s_img = cv2.imread(os.path.join("E:/TAI_LIEU_DAI_HOC/SEMESTER_6/XuLyAnh/FinalProject/ModelOanTuTi/pix", str(user_draw) + ".png"))
    if s_img is not None:
        s_img = cv2.resize(s_img, (100, 100))  # Thay đổi kích thước hình ảnh
        x_offset = 50
        y_offset = 100
        if y_offset + s_img.shape[0] <= frame.shape[0] and x_offset + s_img.shape[1] <= frame.shape[1]:
            y1, y2 = y_offset, y_offset + s_img.shape[0]
            x1, x2 = x_offset, x_offset + s_img.shape[1]
            frame[y1:y2, x1:x2] = s_img
        else:
            print("Kích thước của hình ảnh quá lớn để chèn vào frame")

    # Vẽ hình, viết chữ theo com_draw
    frame = cv2.putText(frame, 'Computer', (370, 50), cv2.FONT_HERSHEY_SIMPLEX,
                        1, (0, 0, 255), 2, cv2.LINE_AA)
    s_img = cv2.imread(os.path.join("E:/TAI_LIEU_DAI_HOC/SEMESTER_6/XuLyAnh/FinalProject/ModelOanTuTi/pix", str(com_draw) + ".png"))
    if s_img is not None:
        s_img = cv2.resize(s_img, (100, 100))  # Thay đổi kích thước hình ảnh
        x_offset = 400
        y_offset = 100
        if y_offset + s_img.shape[0] <= frame.shape[0] and x_offset + s_img.shape[1] <= frame.shape[1]:
            y1, y2 = y_offset, y_offset + s_img.shape[0]
            x1, x2 = x_offset, x_offset + s_img.shape[1]
            frame[y1:y2, x1:x2] = s_img
        else:
            print("Kích thước của hình ảnh quá lớn để chèn vào frame")

    # Kiểm tra và hiển thị kết quả
    if user_draw == com_draw:
        result = "DRAW!"
    elif (user_draw == 0) and (com_draw == 1):
        result = "YOU WIN!"
    elif (user_draw == 1) and (com_draw == 2):
        result = "YOU WIN!"
    elif (user_draw == 2) and (com_draw == 0):
        result = "YOU WIN!"
    else:
        result = "YOU LOSE!"

    frame = cv2.putText(frame, result, (50, 300), cv2.FONT_HERSHEY_SIMPLEX,
                        1, (255, 0, 255), 2, cv2.LINE_AA)
    return frame

def main():
    cam = cv2.VideoCapture(0)
    result_image = st.empty()
    play_button = st.button("Play")
    resume_button = st.button("Resume")
    frame = None
    stop_camera = False

    if play_button:
        status, frame = cam.read()
        frame = cv2.flip(frame, 1)
        handLandmarks = handDetector.findHandLandMarks(image=frame, draw=True)
        n_fingers = -1

        if len(handLandmarks) != 0:
            n_fingers = 0
            if handLandmarks[4][1] + 50 < handLandmarks[5][1]:  # Thumb finger
                n_fingers += 1
            if handLandmarks[8][2] < handLandmarks[6][2]:  # Index finger
                n_fingers += 1
            if handLandmarks[12][2] < handLandmarks[10][2]:  # Middle finger
                n_fingers += 1
            if handLandmarks[16][2] < handLandmarks[14][2]:  # Ring finger
                n_fingers += 1
            if handLandmarks[20][2] < handLandmarks[18][2]:  # Little finger
                n_fingers += 1

        user_draw = -1  # 0: Lá, 1: Đấm, 2: Kéo
        if n_fingers == 0:
            user_draw = 1
        elif n_fingers == 2:
            user_draw = 2
        elif n_fingers == 5:
            user_draw = 0
        elif n_fingers != -1:
            print("Chỉ chấp nhận Đấm Lá Kéo")
        else:
            print("Không có bàn tay trong hình")

        frame = draw_results(frame, user_draw)
        result_image.image(frame, channels="BGR")
        stop_camera = True

    if not stop_camera:
        while True:
            status, frame = cam.read()
            frame = cv2.flip(frame, 1)
            result_image.image(frame, channels="BGR")
            key = cv2.waitKey(1)
            if key == ord("q") or play_button or resume_button:
                break

    if resume_button:
        stop_camera = False
        while not stop_camera:
            status, frame = cam.read()
            frame = cv2.flip(frame, 1)
            result_image.image(frame, channels="BGR")
            key = cv2.waitKey(1)
            if key == ord("q") or play_button:
                break

    cam.release()
    cv2.destroyAllWindows()

if __name__ == "__main__":
    main()

