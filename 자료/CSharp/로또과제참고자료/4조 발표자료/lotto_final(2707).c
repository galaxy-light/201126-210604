#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void lotto1(int credit); // 함수 lotto1을 사용할 것이라고 선언한 것입니다.
void lotto2(int credit);
void lotto3(int credit);
int percent();

int main(void) {
	// 사전계획서 , 기능설명서 

	// 로또 확률에서 나오는 난수 빈도 정의하기

	// 난수가 누적되면 일정한 숫자만 계속 출력하게 되는 문제 처리 
	// 로또는 자동으로 출력시 자동, 수동의 많이 나온 수를 기반해서 출력하게된다. 

	// 우리가 할 기법 : 733회에 기계가 교체되어서 733 ~ 920 회에서 가장 잘 나오는 숫자들을 사용한다.


	srand(time(NULL)); // seed를 time에 맞춰서 매 실행마다 출력값이 달린다. 

	int credit;	//구매할 용지 수량

	printf("\n★★★★★★★★★★★로또번호 자동 출력기★★★★★★★★★★★\n");
	do {

		printf("\n1개 이상의 용지를 구입해 주세요.");
		printf("\n몇 개의 로또용지를 구매하시겠습니까? ");

		scanf_s("%d", &credit);

		if (credit < 1)
			printf("올바른 수량을 입력하세요.");

	} while (credit < 1); // 용지 1개 이상만 입력받게하기

	printf("\n1. 실제 로또에서 가장 잘 나왔던 숫자(12개) 기반으로 자동출력하기.\n");
	printf("\n2. 랜덤숫자n개 + 잘나오는 랜덤숫자m개.\n"); // 45개중 뽑을 랜덤 숫자 + 가장 잘나오는 12개의 랜덤숫자
	printf("\n3. (통계 기반) 1~45의 볼 빈도수에 따른 랜덤 숫자. \n"); // https://www.dhlottery.co.kr/gameResult.do?method=statByNumber

	printf("\n\n원하시는 출력법을 선택해 주세요: ");

	int x; // 출력법 입력받을 변수


	do {
		scanf_s("%d", &x);

		if (x == 1)
			lotto1(credit); // x == 1일 경우  함수 lotto1() 실행
		else if (x == 2)
			lotto2(credit); // x == 2일 경우  함수 lotto2() 실행
		else if (x == 3)
			lotto3(credit); // x == 3일 경우  함수 lotto3() 실행
		else
			printf("범위 안의 숫자를 입력해 주세요: ");

	} while (x < 1 || x > 3);

	printf("\n★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★\n\n");
}



void lotto1(int credit) {

	int ball[12] = { 10, 12, 16 , 17, 18, 21, 24, 34, 38, 39, 42, 43 }; // 733회차때 기계가 교체됨. 733 ~ 920회에서 가장 잘나온 숫자 12개
	int num[6]; // 번호 총 6개를 받을 배열
	int limit; // 중복 체크를 위한 변수 
	int cnt = 0; // cnt는 credit 변수를 제어하기 위해서 사용함 (92번째 열을 참조해 주세요)

	printf("\n★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★\n\n");

	do {
		do {
			limit = 1;

			//////////////////////////////////////////숫자 6개 받기(중복체크 하면서)////////////////////////////////////////////

			for (int i = 0; i < 6; i++) {
				num[i] = ball[rand() % 12];  // 로또 번호 받기		

				if (i > 0) {// i가 1 이상일 경우 부터 중복 체크
					for (int j = 0; j < i; j++)
						if (num[i] == num[j]) { // 중복되면 실행
							limit = 0; // 중복 값이 있으므로 다시 실행시킴	
							break;
						}

					if (limit == 0)
						break; //break는 for문을 탈출하는 역할을 합니다. 2중 for문이기 때문에 break를 2번 사용해야 합니다.
				}
			}

			///////////////////////////////////////////////////출력/////////////////////////////////////////////////////////////

			if (limit == 1) {
				for (int i = 0; i < 6; i++) {

					if (num[i] > 9) // 숫자 6개를 깔끔하게 출력하기 위해서 사용했습니다.
						printf("%d ", num[i]);
					else
						printf(" %d ", num[i]);
				}
			}
		} while (limit == 0);




		cnt++;// credit(용지)수 만큼만 반복문을 쓰기 위해서 사용됩니다.
		printf("\n");

	} while (cnt < credit);
}
void lotto2(int credit) {

	int ball[12] = { 10, 12, 16 , 17, 18, 21, 24, 34, 38, 39, 42, 43 }; // 733회차때 기계가 교체됨. 733 ~ 920회에서 가장 잘나온 숫자 12개
	int num[6]; // 로또 번호를 6개를 받을 배열
	int limit; // 중복 체크를 위한 변수
	int cnt = 0;
	int jnum = 0; // just random number

	printf("\n★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★\n\n");

	do {
		printf("몇개의 그냥 랜덤 숫자를 출력하시겠습니까?: ");
		scanf_s("%d", &jnum);

		if (jnum > 6 || jnum <= 0)
			printf("올바른 범위의 값을 입력하세요\n");

	} while (jnum > 6 || jnum <= 0);

	do {
		do {
			limit = 1;
			for (int i = 0; i < 6; i++) {
				if (jnum > i) {
					num[i] = rand() % 45 + 1;  // 로또 번호 받기
				}
				else {
					num[i] = ball[rand() % 12];
				}

				if (i > 0) {// i가 1 이상일 경우 부터 중복 체크
					for (int j = 0; j < i; j++)
						if (num[i] == num[j]) { // 중복되면 실행
							limit = 0; // 중복 값이 있으므로 다시 실행시킴		
							break;
						}

					if (limit == 0)
						break;
				}
			}
			/////////////////////////////////////////////출력////////////////////////////////////////////

			if (limit == 1) {
				for (int i = 0; i < 6; i++) {

					if (num[i] > 9)			// 숫자 6개를 깔끔하게 출력하기 위해서 사용했습니다.
						printf("%d ", num[i]);
					else
						printf(" %d ", num[i]);
				}
			}
		} while (limit == 0);
		cnt++;
		printf("\n");

	} while (cnt < credit);
}
void lotto3(int credit) {

	int num[6]; // 로또 번호를 6개를 받을 배열
	int limit; // 중복 체크를 위한 변수
	int cnt = 0;

	printf("\n★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★\n\n");

	do {
		do {

			do {
				limit = 1;
				for (int i = 0; i < 6; i++) {

					num[i] = percent();  // 로또 번호 받기		

					if (i > 0) {// i가 1 이상일 경우 부터 중복 체크
						for (int j = 0; j < i; j++) {
							if (num[i] == num[j]) { // 중복되면 실행
								limit = 0; // 중복 값이 있으므로 다시 실행시킴	
								break;
							}
						}

						if (limit == 0)
							break; //break는 for문을 탈출하는 역할을 합니다. 2중 for문이기 때문에 break를 2번 사용해야 합니다.
					}
				}

				if (limit == 1) {
					for (int i = 0; i < 6; i++) {
						if (num[i] > 9)			// 숫자 6개를 깔끔하게 출력하기 위해서 사용했습니다.
							printf("%d ", num[i]);
						else
							printf(" %d ", num[i]);
					}
				}
			} while (limit == 0);
		} while (limit == 0);
		cnt++;
		printf("\n");

	} while (cnt < credit);
}

int percent() {
	int rnumber = rand() % 10000;//10000

	if (rnumber < 336) // 1순위 공 0~335
		return 12;

	else if (rnumber < 626) // 2순위 공 336~ 625
		return 38;

	else if (rnumber < 908) // 3순위 공 
		return 18;

	else if (rnumber < 1180) // 4순위 공
		return 43;

	else if (rnumber < 1455) // 5순위 공
		return 16;

	else if (rnumber < 1835) // 6순위 공
		return 21;

	else if (rnumber < 2102) // 7순위 공
		return 17;

	else if (rnumber < 2369) // 8순위 공
		return 42;

	else if (rnumber < 2636) // 9순위 공
		return 34;

	else if (rnumber < 2891) // 10순위 공
		return 10;

	else if (rnumber < 3146) // 11순위 공
		return 39;

	else if (rnumber < 3401) // 12순위 공
		return 24;

	else if (rnumber < 3656) // 13순위 공
		return 19;

	else if (rnumber < 3911) // 14순위 공
		return 45;

	else if (rnumber < 4155) // 15순위 공
		return 33;

	else if (rnumber < 4390) // 16순위 공
		return 31;

	else if (rnumber < 4625) // 17순위 공
		return 30;

	else if (rnumber < 4860) // 18순위 공
		return 6;

	else if (rnumber < 5095) // 19순위 공
		return 3;

	else if (rnumber < 5324) // 20순위 공
		return 36;

	else if (rnumber < 5553) // 21 순위 공
		return 13;

	else if (rnumber < 5766) // 22순위 공
		return 28;

	else if (rnumber < 5987) // 23순위 공
		return 14;

	else if (rnumber < 6208) // 24순위 공
		return 27;

	else if (rnumber < 6429) // 25순위 공
		return 32;

	else if (rnumber < 6642) // 26순위 공
		return 2;

	else if (rnumber < 6855) // 27순위 공
		return 11;

	else if (rnumber < 7068) // 28순위 공
		return 26;

	else if (rnumber < 7281) // 29순위 공
		return 9;

	else if (rnumber < 7487) // 30순위 공
		return 41;

	else if (rnumber < 7693) // 31순위 공
		return 5;

	else if (rnumber < 7891) // 32순위 공
		return 15;

	else if (rnumber < 8089) // 33순위 공
		return 4;

	else if (rnumber < 8287) // 34순위 공
		return 29;

	else if (rnumber < 8478) // 35순위 공
		return 35;

	else if (rnumber < 8669) // 36순위 공
		return 22;

	else if (rnumber < 8852) // 37순위 공
		return 7;

	else if (rnumber < 9028) // 38순위 공
		return 23;

	else if (rnumber < 9196) // 39순위 공
		return 44;

	else if (rnumber < 9364) // 40순위 공
		return 37;

	else if (rnumber < 9528) // 41순위 공
		return 40;

	else if (rnumber < 9692)  //  42순위 공
		return 1;

	else if (rnumber < 9798) // 43순위 공
		return 25;

	else if (rnumber < 9904) // 44순위 공
		return 8;

	else 					 //45순위 공
		return 20;
}