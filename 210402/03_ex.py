import pyautogui
import time

# rpa 매크로

# 2초동안 좌표로 이동 후 클릭됨
# pyautogui.click(199,12,duration=2)

# 3초 기다림
time.sleep(3)

# 100,200 좌표로 이동
# mouseDown : 드래그
# move : 상대좌표
# mouseUp() : 마우스 뗌
pyautogui.mouseDown(100,200)
pyautogui.move(100,100,duration=1)
pyautogui.mouseUp()