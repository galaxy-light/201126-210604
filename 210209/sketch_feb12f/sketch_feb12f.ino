#define LED 13 // 전구 13번 핀
// const int LED = 13; 위와 동일함

// 부저
const int BUZZER = 10;
const int numTones = 140;
const int tones[] = {415,415,391,391,
349,349,391,391,391,233,233,246,
246,246,0,246,415,415,391,391,
349,349,391,391,391,391,391,391,
0,0,0,0,391,415,466,466,
466,466,523,523,523,311,311,311,
311,466,466,466,466,311,349,391,
391,391,349,349,349,311,349,349,
349,349,349,349,415,415,391,391,
349,349,391,391,391,233,233,246,
246,246,0,246,415,415,391,391,
349,349,391,391,391,466,466,466,
466,466,466,466,391,415,466,466,
466,466,523,523,523,311,311,311,
311,466,466,466,0,622,622,622,
622,466,523,523,0,0,0,0,
698,698,783,698,698,698,622,698,
698,587,622,622,622,622,622,622};

// #define DELAY 300

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
    for (int i = 0; i < sizeof(numTones)/sizeof(int); i++) {
      // tone함수를 통해 피에조부저에서 소리가 나며 tones[]배열에 있는 주파수에 해당하는 음계가 출력됩니다.
      tone(BUZZER, tones[i]);
      // delay(DELAY);
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
