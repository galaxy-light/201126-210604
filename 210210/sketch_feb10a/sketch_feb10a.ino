#define LED 13

#define C 262 // 도 
#define D 294 // 레 
#define E 330 // 미 
#define F 349 // 파 
#define G 392 // 솔 
#define A 440 // 라 
#define B 494 // 시 

int BUZZER = 10;
int tempo = 200; // duration 옵션 값 설정 
int notes[25] = { G, G, A, A, G, G, E, G, G, E, E, D, G, G, A, A, G, G, E, G, E, D, E, C }; 

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

void setup() {
 // put your setup code here, to run once:
  // 시리얼 통신 속도 (baudrate : 통신 속도)
  Serial.begin(9600); // 9600 : 문자 정보 전송 속도
  pinMode(LED, OUTPUT); // 전구
  pinMode(BUZZER, OUTPUT); // 부저
  myservo.attach(SERVO); // 서보모터
}
 
// setup() 함수가 호출된 이후, loop() 함수가 호출되며,
// 블록 안의 코드를 무한히 반복 실행됩니다.
void loop() {
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
          Serial.println("MELODY ON");
          musicStart();          
        }
        else if (ch == '3') {
          digitalWrite(SERVO, HIGH);
          Serial.println("SERVO ON");
          lotStart();
        }
    }
}

void musicStart (){
  for (int i = 0; i < 12; i++) { 
    tone (BUZZER, notes[ i ], tempo); 
    delay (300); 
  } 
  delay(100); // 멜로디 중간에 짧게 멈추는 용도 

  for (int i = 12; i < 25; i++) { 
    tone (BUZZER, notes[ i ], tempo); 
    delay(300); 
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
