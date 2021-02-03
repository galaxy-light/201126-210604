// 학교종이 땡땡땡
const int BUZZER = 10; // #define BUZZER 10

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

void setup() {
  // put your setup code here, to run once:
  musicStart(); // 함수 호출
}

void loop() {
  // put your main code here, to run repeatedly:

}

void musicStart (){
  for (int i = 0; i < sizeof(hakGyo)/sizeof(int); i++) { // sizeof : 배열의 개수를 구하는 매크로 / sizeof(int) -> int : 데이터 타입
      tone(BUZZER, hakGyo[i], 300);
      delay(DELAY);
    }  
}
