// 파일 - 예제 - 0.1 basics - blink

// 상수 변수 선언 // 상수 변수 : 한번 선언한 변수는 수정하지 않겠다라는 뜻
const int LED = 13; // const : 자바의 final와 똑같음
const int HIGH_VAL = 1; // const : 자바의 final와 똑같음
const int LOW_VAL = 0; // const : 자바의 final와 똑같음

// 부저 (#define BUZZER 10; : 하나의 상수 변수값)
#define BUZZER 10 // 10번 핀

// setup : 장치에 대한 환경 설정
void setup() {
  // put your setup code here, to run once:
  // 아두이노 핀맵 참조
  // 13번핀 출력(제어) 방향 설정
  pinMode(LED, OUTPUT); // LED_BUILTIN : 상수 : 13
  // pinMode(13, OUTPUT);을 해도 위와 똑같이 동작함
  
  // 부저 제어
  pinMode(BUZZER, OUTPUT);
}

// main()이 존재하지만 숨겨져 있음
// 동작하는 루틴 적용
// 매개변수가 2개 있음 : LED_BUILTIN, HIGH/LOW
void loop() {
  // put your main code here, to run repeatedly:
  // 13번핀 디지털 신호 high : 디지털 신호 -> 1 / 1 : 5V / high : true와 비슷한 개념
  digitalWrite(LED, HIGH_VAL);   // turn the LED on (HIGH is the voltage level)
  // 시간 딜레이
  delay(1000); // 기본 단위 : ms ex)1000 : 1초     // wait for a second  
  // 부저 디지털 신호
  // digitalWrite(BUZZER, HIGH);
  // 부저 딜레이
  // delay(2000);
  buzStart(); // 부저 함수 호출
  // 13번핀 디지털 신호 low : 디지털 신호 -> 0 / 0 : GND / low : false와 비슷한 개념
  digitalWrite(LED, LOW_VAL);    // turn the LED off by making the voltage LOW
  // 시간 딜레이
  buzStart(); // 부저 함수 호출
  delay(1000); // 기본 단위 : ms ex)1000 : 1초     // wait for a second
  // 부저 디지털 신호
  // digitalWrite(BUZZER, LOW);
  // 부저 딜레이
  // delay(2000);  
}

// 부저 디지털 신호를 위에 같이 적을 수 있지만 코드가 너무 길어져서 함수로 빼냄
void buzStart(){
  digitalWrite(BUZZER, HIGH);
  delay(100);
  digitalWrite(BUZZER, LOW);  
}
