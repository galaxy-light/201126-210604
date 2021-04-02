import pyautogui

# 시간 객체를 사용하기 위해 import time
import time

# UTC시간표시(현재시간과 n초 뒤의 시간 표시)
start = time.time()
print('start',start)
# time.sleep(3)
# end = time.time()
# print('end',end)

#따로 괄호 없이 들여쓰기로 while 구문 안에 포함 됨을 알 수 있다
#True일 동안 반복됨/ end에서 종료됨
#파이썬의 함수 선언은 def를 사용한다/ 들여쓰기 매우 중요/드래그 후 Tab 눌러서 포함시킴

# 10초 동안 파일 이미지 찾기 / 매개변수 적을 때 따로 지정없음(바로 file_name만 적어도 됨)
#timeout : 디폴트값 10초 지정
def find_target(file_name,timeout=10):    
    while True :
        time.sleep(1)
        end = time.time()   
        # print('end',end)    
        # if (end - start) > 3 :
        #     print("10초 경과")
        #     break
        
        file_a = pyautogui.locateOnScreen(file_name)
        # print(file_a)
        if file_a is not None :
            # print("찾음")

            # 찾으면 클릭
            # pyautogui.click(file_a)
            # break
            
             #파일을 찾았을 때 리턴함
            return file_a

        if (end - start) > timeout :
            # print("10초 경과")
            break
# 따로 void나 int 등을 사용하지 않기 때문에 바로 호출 가능
# box = find_target('A.PNG')
box = find_target('A.PNG',20)
pyautogui.click(box)

# pip install Pillow

# 캡쳐한 사진(돋보기) 클릭하기
# file_a = pyautogui.locateOnScreen('A.PNG')
# print(file_a)

# 2초동안 이동 후 클릭
# pyautogui.click(file_a,duration=2)