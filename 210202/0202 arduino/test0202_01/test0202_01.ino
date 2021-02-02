// 파일 - 예제 - 0.1 basics - blink

// 상수 변수 선언 // 상수 변수 : 한번 선언한 변수는 수정하지 않겠다라는 뜻
const int LED = 13; // const : 자바의 final와 똑같음
const int HIGH_VAL = 1; // const : 자바의 final와 똑같음
const int LOW_VAL = 0; // const : 자바의 final와 똑같음

// setup : 장치에 대한 환경 설정
void setup() {
  // put your setup code here, to run once:
  // 아두이노 핀맵 참조
  // 13번핀 출력(제어) 방향 설정
  pinMode(LED, OUTPUT); // LED_BUILTIN : 상수 : 13
  // pinMode(13, OUTPUT);을 해도 위와 똑같이 동작함
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
  // 13번핀 디지털 신호 low : 디지털 신호 -> 0 / 0 : GND / low : false와 비슷한 개념
  digitalWrite(LED, LOW_VAL);    // turn the LED off by making the voltage LOW
  // 시간 딜레이
  delay(1000); // 기본 단위 : ms ex)1000 : 1초     // wait for a second
}
