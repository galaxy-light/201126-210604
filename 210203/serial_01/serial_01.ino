#define LED 13

// 숨겨진 main에서 setup과 loop 호출을 해서 이 프로그램이 작동하는 것
void setup() {
  // put your setup code here, to run once:
  // 시리얼 통신 속도 (baudrate : 통신 속도)
  Serial.begin(9600); // 9600 : 문자 정보 전송 속도
  // LED 출력 설정
  pinMode(LED, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  // 데이터 송신 : 아두이노 -> PC
//  Serial.print("sersor_value");
//  Serial.println();
//  delay(2000);

  // 데이터 송신 : PC -> 아두이노
  if (Serial.available()){ // Serial.available : 데이터가 수신되어졌으면
      char ch = Serial.read();
      if (ch == '1') {
          digitalWrite(LED, HIGH);
          Serial.println("LED ON");
        }
        else if (ch == '0') {
          digitalWrite(LED, LOW);
          Serial.println("LED OFF");  
        }
        delay(50);
    }
}
