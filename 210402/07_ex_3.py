# Quiz) 아래 동작을 자동으로 수행하는 프로그램을 작성하시오.
# 1. 그림판 실행 (단축기 : win + r, 입력값 : mspaint)
# 2. 상단의 텍스트 기능을 이용하여 흰 영역 아무 곳에다가 글자 입력
# - 입력 글자 : "참 잘했어요"

import pyautogui
import time 
import myfunc

pyautogui.hotkey('win','r')
pyautogui.write('mspaint')
pyautogui.hotkey('enter')

time.sleep(2)

# getWindowsWithTitle : 특정 이름의 창을 띄움
# window에 열려있는 [0]번째 ("제목 없음 - 그림판")을 가져옴 
# [0] : 0번째
window = pyautogui.getWindowsWithTitle("제목 없음 - 그림판")[0]
# maximize : 창 최대화
window.maximize()

box = pyautogui.locateOnScreen('B.PNG')
pyautogui.click(box)

pyautogui.move(0,200,duration=2)
pyautogui.click()

time.sleep(1)
myfunc.han_write('참 잘했어요')

# 1초 뒤 닫기
time.sleep(3)
window.close()
time.sleep(2)
pyautogui.hotkey('n')
