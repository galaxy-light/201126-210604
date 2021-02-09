#define LED 13 // 전구 13번 핀
// const int LED = 13; 위와 동일함

// 부저
const int BUZZER = 10;
#define DO1 262 // 4옥타브 도
#define RE  294 // 4옥타브 레
#define MI  330 // 4옥타브 미
#define FA  349 // 4옥타브 파
#define SOL 392 // 4옥타브 솔
#define LA  440 // 4옥타브 라
#define SI  494 // 4옥타브 시
#define DO2 523 // 5옥타브 도
#define DELAY 300
const int hakGyo[] = {SOL, SOL, LA, LA, SOL, SOL, MI, SOL, SOL, MI, MI, RE, SOL, SOL, LA, LA, SOL, SOL, MI, SOL, MI, RE, MI, DO1};

// 서보모터
#define SERVO 9
/* Sweep
 by BARRAGAN <http://barraganstudio.com>
 This example code is in the public domain.

 modified 8 Nov 2013
 by Scott Fitzgerald
 http://www.arduino.cc/en/Tutorial/Sweep
*/

#include <Servo.h>

Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards

int pos = 0;    // variable to store the servo position

// 숨겨진 main에서 setup과 loop 호출을 해서 이 프로그램이 작동하는 것
void setup() {
  // put your setup code here, to run once:
  // 시리얼 통신 속도 (baudrate : 통신 속도)
  Serial.begin(9600); // 9600 : 문자 정보 전송 속도
  pinMode(LED, OUTPUT); // 전구
  pinMode(BUZZER, OUTPUT); // 부저
  myservo.attach(SERVO); // 서보모터
}

void loop() {
  // put your main code here, to run repeatedly:
  // 데이터 송신 : 아두이노 -> PC
//  Serial.print("온도 : 26.5℃");
//  Serial.println();
//  delay(2000);

    controlSystem();      
}

void controlSystem(){
    // 데이터 송신 : PC -> 아두이노
  if (Serial.available()){ // Serial.available : 데이터가 수신되어졌으면
      char ch = Serial.read();
      if (ch == '0') {
          digitalWrite(LED, LOW);                   
          digitalWrite(BUZZER, LOW);                    
          digitalWrite(SERVO, LOW);
          Serial.println("OFF");                         
        }
        else if (ch == '1') {
          digitalWrite(LED, HIGH);
          Serial.println("LED ON");  
        }        
        else if (ch == '2'){
          digitalWrite(BUZZER, HIGH);
          Serial.println("멜로디 ON");
          musicStart();          
        }
        else if (ch == '3') {
          digitalWrite(SERVO, HIGH);
          Serial.println("서보모터 ON");
          lotStart();
        }
    }
}

void musicStart (){
  for (int i = 0; i < sizeof(hakGyo)/sizeof(int); i++) { // sizeof : 배열의 개수를 구하는 매크로 / sizeof(int) -> int : 데이터 타입
      tone(BUZZER, hakGyo[i], 300);
      delay(DELAY);
    }  
}

void lotStart () {
  for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
      myservo.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15ms for the servo to reach the position
    }
  for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
      myservo.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15ms for the servo to reach the position
    }
}
