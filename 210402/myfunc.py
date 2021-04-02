import pyautogui
import time
import pyperclip

def doA():
    for i in range(0,5):
        print("i = ",i)

def han_write(text):
    pyperclip.copy(text)
    pyautogui.hotkey('ctrl','v')

# 10초동안 찾아지면 05_ex.py로 보내짐
def find_target(file_name,timeout=10):    
    start = time.time()
    while True :
        time.sleep(1)
        end = time.time()           
        
        file_a = pyautogui.locateOnScreen(file_name)       
        if file_a is not None :           
            return file_a

        if (end - start) > timeout :            
            break
box = find_target('A.PNG',20)
pyautogui.click(box)
