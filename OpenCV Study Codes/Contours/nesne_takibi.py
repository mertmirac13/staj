import cv2
import numpy as np
sens = 15
cap = cv2.VideoCapture(r"C:\Users\MERT\PycharmProjects\pythonProject2\fotolar\dog.mp4")

while True:
    ret, frame = cap.read()

    hsv = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)
    lower_white = np.array([0, 0, 255-sens])
    upper_white = np.array([255, sens, 255])
    mask = cv2.inRange(hsv, lower_white, upper_white)
    res = cv2.bitwise_and(frame, frame, mask= mask)

    cv2.imshow("frame", frame)
    cv2.imshow("mask", mask)
    cv2.imshow("result", res)

    if cv2.waitKey(30) & 0xFF == ord("q"):
        break

cap.release()
cap.destroyAllWindows()