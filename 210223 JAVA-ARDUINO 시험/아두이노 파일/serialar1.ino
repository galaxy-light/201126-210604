//LED
#define LED 13

//BUZZER
const int BUZZER =10;
#define DO1 262 // 4옥타브
#define RE  294
#define MI  330
#define FA  349
#define SOL 392
#define LA  440
#define SI  494
#define DO2 523
#define DELAY 300
const int hakGYo[] ={
  SOL, SOL, LA, LA, SOL, SOL, MI, SOL, SOL, MI, MI, RE, SOL, LA, LA, SOL, SOL, MI, MI, RE,
SOL,SOL, LA, LA, SOL, SOL, MI, SOL, MI, RE, MI, DO1};

//SERVO
#include <Servo.h>
Servo myservo;

int pos = 0;

void setup() {
  // 시리얼 통신 속도 (baudrate)
  Serial.begin(9600);
  // LED 출력 설정
  pinMode(LED, OUTPUT);

 //servo
  myservo.attach(8);
}



void loop() {
//  // 데이터 송신: 아두이노 -> PC
//  Serial.print("온도: 26.5℃");
//  Serial.println();
//  delay(2000);

    controlSystem();
    
}


void controlSystem() {
  // 데이터 수신: PC -> 아두이노
  if (Serial.available()) {
    char ch = Serial.read();
    if (ch == '1') {
      digitalWrite(LED, HIGH);
      // 데이터 송신: 아두이노 -> PC
      Serial.println("LED ON/TV ON");
    }
    else if (ch == '2') {
      digitalWrite(LED, LOW);
      Serial.println("LED OFF/TV OFF");
    }
    else if (ch == '3') {
      Serial.println("MELODY ON/HEATER ON"); 
      for(int i=0; i<sizeof(hakGYo)/sizeof(int);i++){
          tone(BUZZER, hakGYo[i],300);
      delay(DELAY);
      }
    }
    else if (ch == '4') {
      Serial.println("SERVO ON/CLEANER ON");
      for (pos = 0; pos <= 180; pos += 1) {
           myservo.write(pos);              
      delay(15);                       
      }
      for (pos = 180; pos >= 0; pos -= 1) {
           myservo.write(pos);              
      delay(15);                       
      }
    }
    delay(50);
  }
}
