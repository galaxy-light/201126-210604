# python 인터프린터언어 : 한 줄씩 실행됨 / 나갈 때 : quit()
# 컴퍼일언어 : python - 01_ex.py 

# python은 들여쓰기가 중요함

# ctrl + ~ 터미널창 열기 shell 열기
# # : 주석

import time

# 1이 찍히고 3초 뒤에 안녕하세요
print(1)
time.sleep(3)
print("안녕하세요")

# i의 값이 0~4까지 1씩 증가
for i in range(0,5,1):
    print("i = ", i)

# cls : 화면지우기
# cd : 폴더명 경로이동
# dir, ls : 폴더 안 내용 보기    

# pip install pyautogui