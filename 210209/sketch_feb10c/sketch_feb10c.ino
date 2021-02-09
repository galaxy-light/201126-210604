#define LED 13 // 전구 13번 핀
// const int LED = 13; 위와 동일함

// 부저
const int BUZZER = 10;
float A[] = {27.5, 55, 110, 220, 440, 880, 1760, 3520};
float As[] = {29.1, 58.3, 116.5, 233.1, 446.2, 932.3, 1864.7, 3729.3};
float B[] = {30.9, 61.7, 123.5, 246.9, 493.9, 987.8, 1975.5, 3951.1};
float C[] = {32.7, 65.4, 130.8, 261.6, 523.3, 1046.5, 2093, 4186};
float Cs[] = {34.6, 69.3, 139.6, 277.2, 544.4, 1108.7, 2217.5};
float D[] = {36.7, 73.4, 146.8, 293.7, 587.3, 1174.7, 2349.3};
float Ds[] = {38.9, 77.8, 155.6, 311.1, 622.3, 1244.5, 2489};
float E[] = {41.2, 82.4, 164.8, 329.6, 659.3, 1318.5, 2637};
float F[] = {43.7, 87.3, 174.6, 349.2, 698.5, 1396.9, 2793.8};
float Fs[] = {46.2, 92.5, 185, 370, 740, 1480, 2960};
float G[] = {49, 98, 196, 392, 780, 1568, 3136};
float Gs[] = {51.9, 103.8, 207.7, 415.3, 830, 1661.2, 3322.4};

#define DELAY 300

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
   tone(BUZZER, D[4]);
   delay(500);
   tone(BUZZER, G[4]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(700);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, A[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(900);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, G[4]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, G[5]);
   delay(700);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, G[5]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(400);
   tone(BUZZER, F[5]);
   delay(300);
   tone(BUZZER, Ds[5]);
   delay(300);
   tone(BUZZER, F[5]);
   delay(1000);
   noTone(BUZZER);
   delay(400);

   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(1000);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, E[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, G[5]);
   delay(1000);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, E[5]);
   delay(1000);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, G[4]);
   delay(500);
   tone(BUZZER, A[5]);
   delay(1000);
   noTone(BUZZER);
   delay(400);

   tone(BUZZER, As[5]);
   delay(1000);
   tone(BUZZER, A[5]);
   delay(1000);
   tone(BUZZER, C[5]);
   delay(150);
   tone(BUZZER, As[5]);
   delay(1000);
   tone(BUZZER, A[5]);
   delay(1000);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, A[4]);
   delay(550);
   tone(BUZZER, D[4]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, D[4]);
   delay(500);
   noTone(BUZZER);
   delay(10);

   tone(BUZZER, A[4]);
   delay(550);
   tone(BUZZER, D[4]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, D[4]);
   delay(500);
   noTone(BUZZER);
   delay(10);
 
   tone(BUZZER, A[4]);
   delay(550);
   tone(BUZZER, D[4]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, D[4]);
   delay(500);
   noTone(BUZZER);
   delay(10);

   tone(BUZZER, D[4]);
   delay(500);
   tone(BUZZER, G[4]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(700);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, A[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(900);
   noTone(BUZZER);
   delay(400);

   tone(BUZZER, G[4]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, G[5]);
   delay(700);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, G[5]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(400);
   tone(BUZZER, F[5]);
   delay(300);
   tone(BUZZER, Ds[5]);
   delay(300);
   tone(BUZZER, F[5]);
   delay(1000);
   noTone(BUZZER);
   delay(400);

   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(1000);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(300);
   tone(BUZZER, E[5]);
   delay(300);
   tone(BUZZER, D[5]);
   delay(300);
   tone(BUZZER, E[5]);
   delay(300);
   tone(BUZZER, G[5]);
   delay(1000);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, E[5]);
   delay(300);
   tone(BUZZER, D[5]);
   delay(300);
   tone(BUZZER, C[5]);
   delay(300);
   tone(BUZZER, D[5]);
   delay(300);
   noTone(BUZZER);
   delay(10);
 
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(300);
   tone(BUZZER, D[5]);
   delay(300);
   tone(BUZZER, C[5]);
   delay(300);
   tone(BUZZER, As[5]);
   delay(300);
   tone(BUZZER, A[5]);
   delay(700);
   tone(BUZZER, B[5]);
   delay(300);
   tone(BUZZER, Cs[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(1000);
   noTone(BUZZER);
   delay(10);
 
 
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, Ds[5]);
   delay(1000);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, A[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
 
   tone(BUZZER, F[4]);
   delay(1000);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, F[4]);
   delay(500);
   tone(BUZZER, Ds[5]);
   delay(1000);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(1000);
   tone(BUZZER, As[5]);
   delay(300);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(1000);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, D[5]);
   delay(300);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, D[5]);
   delay(300);
 
   tone(BUZZER, Cs[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, E[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, Cs[5]);
   delay(1000);
   tone(BUZZER, E[5]);
   delay(500);
   tone(BUZZER, A[5]);
   delay(1000);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, A[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(1000);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, F[5]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, E[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, E[5]);
   delay(2000);
 
   tone(BUZZER, Fs[5]);
   delay(1000);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, Fs[5]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, Fs[5]);
   delay(500);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(500);
   tone(BUZZER, As[6]);
   delay(2000);

   tone(BUZZER, E[5]);
   delay(1000);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, E[5]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, E[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(2000);
 
   tone(BUZZER, D[5]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, D[5]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, Cs[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);

   tone(BUZZER, Cs[5]);
   delay(1000);
   tone(BUZZER, E[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(1000);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, Fs[5]);
   delay(2000);

   tone(BUZZER, D[4]);
   delay(500);
   tone(BUZZER, G[4]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(700);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, A[5]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(700);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, G[4]);
   delay(500);
   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, G[5]);
   delay(700);
   noTone(BUZZER);
   delay(400);
 
   tone(BUZZER, G[5]);
   delay(500);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(400);
   tone(BUZZER, F[5]);
   delay(300);
   tone(BUZZER, Ds[5]);
   delay(300);
   tone(BUZZER, F[5]);
   delay(1000);
   noTone(BUZZER);
   delay(400);

   tone(BUZZER, As[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, A[6]);
   delay(1000);
   tone(BUZZER, G[5]);
   delay(500);
   tone(BUZZER, F[5]);
   delay(300);
   tone(BUZZER, E[5]);
   delay(300);
   tone(BUZZER, D[5]);
   delay(300);
   tone(BUZZER, E[5]);
   delay(300);
   tone(BUZZER, G[5]);
   delay(1000);
   tone(BUZZER, F[5]);
   delay(500);
   tone(BUZZER, E[5]);
   delay(300);
   tone(BUZZER, D[5]);
   delay(300);
   tone(BUZZER, C[5]);
   delay(300);
   tone(BUZZER, D[5]);
   delay(300);
   noTone(BUZZER);
   delay(10);
 
   tone(BUZZER, D[5]);
   delay(500);
   tone(BUZZER, C[5]);
   delay(300);
   tone(BUZZER, D[5]);
   delay(300);
   tone(BUZZER, C[5]);
   delay(300);
   tone(BUZZER, As[5]);
   delay(300);
   tone(BUZZER, A[5]);
   delay(1000);
   tone(BUZZER, B[5]);
   delay(300);
   tone(BUZZER, Cs[5]);
   delay(500);
   tone(BUZZER, D[5]);
   delay(1000);
   noTone(BUZZER);
   delay(10);
   
   tone(BUZZER, D[4]);
   delay(300);
   noTone(BUZZER);
   delay(10);
   tone(BUZZER, D[4]);
   delay(500);
   tone(BUZZER, C[4]);
   delay(300);
   tone(BUZZER, D[4]);
   delay(300);
   tone(BUZZER, C[4]);
   delay(300);
   tone(BUZZER, As[4]);
   delay(300);
   tone(BUZZER, A[4]);
   delay(1000);
   tone(BUZZER, B[4]);
   delay(300);
   tone(BUZZER, Cs[4]);
   delay(500);
   tone(BUZZER, D[4]);
   delay(1500);
   noTone(BUZZER);
   delay(10000); 
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
