import pyautogui

# 사용중인 모니터의 사이즈 출력
a = pyautogui.size()
print(a)

# 마우스 움직임 제어(2초동안 100, 200의 좌표로 이동)
# moveTo : 절대좌표
# pyautogui.moveTo(100,200, duration=2)
# pyautogui.moveTo(200,400, duration=2)
# pyautogui.moveTo(400,600, duration=2)
# pyautogui.moveTo(600,600, duration=2)

# 현재 마우스 위치 출력
pos = pyautogui.position()
print(pos)