import cv2
import numpy as np

cap = cv2.VideoCapture(r"C:\Users\MERT\PycharmProjects\pythonProject2\fotolar\car.mp4")

ret, firstFrame = cap.read()
firstFrame = cv2.resize(firstFrame, (640, 480))
firstGray = cv2.cvtColor(firstFrame, cv2.COLOR_BGR2GRAY)
firstGray = cv2.GaussianBlur(firstGray, (5, 5), 0)

while True:
    ret, frame = cap.read()
    frame = cv2.resize(frame, (640, 480))
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    gray = cv2.GaussianBlur(gray, (5, 5), 0)

    diff = cv2.absdiff(firstGray, gray)

    cv2.imshow("diff", diff)
    cv2.imshow("frame", frame)







    if cv2.waitKey(30) & 0xFF == ord("q"):
        break

cap.release()
cv2.destroyAllWindows()