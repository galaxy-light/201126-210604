// #define LED 13
const int LED = 13;

const int BUZZER = 10;
// #define BUZZER 10

#define SERVO 8

#define DO1   262 // 4옥타브 도
#define RE    294 // 레
#define MI    330 // 미
#define FA    349
#define SOL   392
#define LA    440
#define SI    494
#define DO2   523

#define DELAY 300

#include <Servo.h>

Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards

int pos = 0;    // variable to store the servo position

void setup() {
  // 시리얼 통신 속도 (baudrate)
  Serial.begin(9600);
  // LED 출력 설정
  pinMode(LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
  myservo.attach(SERVO);
}

void loop() {
  // 데이터 송신: 아두이노 -> PC
  /*
  Serial.print("온도 : 36.5℃");
  Serial.println();
  delay(2000);
  */

  controlSystem();
}

  void controlSystem() {
    // 데이터 수신: PC -> 아두이노
  
  if (Serial.available()) {
    char ch = Serial.read();
    if (ch == '1') {
      // 데이터 송신: 아두이노 -> PC
      Serial.println("LED ON");
      digitalWrite(LED, HIGH);    
    }
    else if (ch == '0') {
      Serial.println("OFF");
      digitalWrite(LED, LOW);
      digitalWrite(BUZZER, LOW);
      digitalWrite(SERVO, LOW);
    }
    else if( ch == '2' ) {
      Serial.println("BUZZER ON");
      const int hakGyo[] = {DO1, DO1, DO1, RE, MI, MI, RE, MI, FA, SOL};
      for (int i=0; i<sizeof(hakGyo)/sizeof(int); i++) {
      tone(BUZZER, hakGyo[i], 100);
      delay(DELAY);
      }
    }
    else if( ch == '3') {
      Serial.println("SERVO ON");
      for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
      // in steps of 1 degree
      myservo.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15ms for the servo to reach the position
        }
      }
      for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
      myservo.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15ms for the servo to reach the position
        }
    }
}

    
  
  
  








  
