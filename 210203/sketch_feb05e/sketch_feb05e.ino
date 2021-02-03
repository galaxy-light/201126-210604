// 배열 선언
const int melody[] = {
    262, // 도
    264, // 레
    330, // 미
    349, // 파
    392, // 솔
    440, // 라
    494, // 시
    523  // 높은 도
  };

// 상수 변수(두가지로 사용 가능함)
const int BUZZER = 10;
// C/C++에서 사용하는 문법
// #define BUZZER 10  

void setup() {
   // put your setup code here, to run once:
   // tone(BUZZER, melody[0], 500); // 0 : 도 / 500 : 딜레이
   // tone(BUZZER, melody[1], 500; // 1 : 레 / 500 : 딜레이
   for (int i = 0; i < 8; i++) {
      tone(BUZZER, melody[i], 500);
      delay(300);
    }
   for (int i = 8; i >= 0; i--) {
      tone(BUZZER, melody[i], 500);
      delay(300);
    }
}

void loop() {
  // put your main code here, to run repeatedly:

}
