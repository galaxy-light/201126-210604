# Quiz) 아래 동작을 자동으로 수행하는 프로그램을 작성하시오.
# 1. 그림판 실행 (단축기 : win + r, 입력값 : mspaint)
# 2. 상단의 텍스트 기능을 이용하여 흰 영역 아무 곳에다가 글자 입력
# - 입력 글자 : "참 잘했어요"

import pyautogui
import pyperclip
import time

pyautogui.hotkey('win','r')
pyautogui.write('mspaint')
pyautogui.hotkey('enter')

start = time.time()
print('start',start)
def find_target(file_name,timeout=10):
    while True :
        time.sleep(1)
        end = time.time()
        
        file_a = pyautogui.locateOnScreen(file_name)        
        if file_a is not None :
            return file_a

        if (end - start) > timeout :
            break
box = find_target('B.PNG',20)
pyautogui.click(box)

pyautogui.move(100,200,duration=1)
pyautogui.mouseUp()

pyautogui.write('참 잘했어요')
pyperclip.copy('참 잘했어요')
pyautogui.hotkey('ctrl','v')