import pyautogui

# myfunc 파일 안에서 find_target,doA,han_write를 가져옴
# from myfunc import find_target,doA,han_write
# * : find_target,doA,han_write
from myfunc import *

doA()
pyautogui.click(find_target("A.PNG"))
time.sleep(1)
han_write('hello world')