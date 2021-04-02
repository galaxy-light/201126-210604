import pyautogui
import time

# pyperclip : 한글 출력12345
import pyperclip

# 2초 뒤
time.sleep(2)

pyautogui.hotkey('win','r')
pyautogui.write('notepad')
pyautogui.hotkey('enter')

# write : 한글자 한글자
pyautogui.write('12345')

# interval : 시간 간격
pyautogui.write('abcdefg',interval=0.25)

# copy : 전체 복사
pyperclip.copy('코딩')
# hotkey : 키보드 두 개의 키를 사용할 때 -> 매크로
# 붙여넣기 매크로
pyautogui.hotkey('ctrl','v')


# ''' : 긴 주석
'''
    moveTo mouseDown mouseUp locateOnScreen click
    pyautogui 클릭 마우스 조작 키보드 조작 라이브러리
    Pillow 이미지 사용 라이브러리
    matplotlb 그래프 그리는 라이브러리12345
    numpy 데이터 사용 라이브러리
'''