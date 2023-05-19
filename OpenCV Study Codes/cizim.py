import numpy as np
import cv2

canvas = np.zeros((512,512,3), dtype=np.uint8) + 255
cv2.namedWindow("Canvas",cv2.WINDOW_NORMAL)
cv2.line(canvas ,(2,2) , (510,510) , (0,0,0) , thickness = 3) #çizgi çizme
cv2.rectangle(canvas , (100,100) , (250,300) ,(0,0,255) , -1) #dikdörtgen çizme
cv2.circle(canvas,(350,350),100 , (55,0,125) , -1)#daire çizdirme

#üçgen çizme
p1 = (5, 100)
p2 = (25, 350)
p3 = (342, 500)
cv2.line(canvas, p1, p2, (0, 0, 0), 4)
cv2.line(canvas, p2, p3, (0, 0, 0), 4)
cv2.line(canvas, p1, p3, (0, 0, 0), 4)
#üçgen çizme
#yamuk çiziktirme
points = np.array([[[30,170], [75, 202], [124, 287], [400,472]]])
cv2.polylines(canvas, [points], True, (0, 0, 28), 3)
cv2
#yamuk çiziktirme
cv2.imshow("Canvas", canvas)
cv2.waitKey(0)
cv2.destroyAllWindows()