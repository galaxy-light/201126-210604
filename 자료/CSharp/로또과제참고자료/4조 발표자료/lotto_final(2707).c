#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void lotto1(int credit); // �Լ� lotto1�� ����� ���̶�� ������ ���Դϴ�.
void lotto2(int credit);
void lotto3(int credit);
int percent();

int main(void) {
	// ������ȹ�� , ��ɼ��� 

	// �ζ� Ȯ������ ������ ���� �� �����ϱ�

	// ������ �����Ǹ� ������ ���ڸ� ��� ����ϰ� �Ǵ� ���� ó�� 
	// �ζǴ� �ڵ����� ��½� �ڵ�, ������ ���� ���� ���� ����ؼ� ����ϰԵȴ�. 

	// �츮�� �� ��� : 733ȸ�� ��谡 ��ü�Ǿ 733 ~ 920 ȸ���� ���� �� ������ ���ڵ��� ����Ѵ�.


	srand(time(NULL)); // seed�� time�� ���缭 �� ���ึ�� ��°��� �޸���. 

	int credit;	//������ ���� ����

	printf("\n�ڡڡڡڡڡڡڡڡڡڡڷζǹ�ȣ �ڵ� ��±�ڡڡڡڡڡڡڡڡڡڡ�\n");
	do {

		printf("\n1�� �̻��� ������ ������ �ּ���.");
		printf("\n�� ���� �ζǿ����� �����Ͻðڽ��ϱ�? ");

		scanf_s("%d", &credit);

		if (credit < 1)
			printf("�ùٸ� ������ �Է��ϼ���.");

	} while (credit < 1); // ���� 1�� �̻� �Է¹ް��ϱ�

	printf("\n1. ���� �ζǿ��� ���� �� ���Դ� ����(12��) ������� �ڵ�����ϱ�.\n");
	printf("\n2. ��������n�� + �߳����� ��������m��.\n"); // 45���� ���� ���� ���� + ���� �߳����� 12���� ��������
	printf("\n3. (��� ���) 1~45�� �� �󵵼��� ���� ���� ����. \n"); // https://www.dhlottery.co.kr/gameResult.do?method=statByNumber

	printf("\n\n���Ͻô� ��¹��� ������ �ּ���: ");

	int x; // ��¹� �Է¹��� ����


	do {
		scanf_s("%d", &x);

		if (x == 1)
			lotto1(credit); // x == 1�� ���  �Լ� lotto1() ����
		else if (x == 2)
			lotto2(credit); // x == 2�� ���  �Լ� lotto2() ����
		else if (x == 3)
			lotto3(credit); // x == 3�� ���  �Լ� lotto3() ����
		else
			printf("���� ���� ���ڸ� �Է��� �ּ���: ");

	} while (x < 1 || x > 3);

	printf("\n�ڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡ�\n\n");
}



void lotto1(int credit) {

	int ball[12] = { 10, 12, 16 , 17, 18, 21, 24, 34, 38, 39, 42, 43 }; // 733ȸ���� ��谡 ��ü��. 733 ~ 920ȸ���� ���� �߳��� ���� 12��
	int num[6]; // ��ȣ �� 6���� ���� �迭
	int limit; // �ߺ� üũ�� ���� ���� 
	int cnt = 0; // cnt�� credit ������ �����ϱ� ���ؼ� ����� (92��° ���� ������ �ּ���)

	printf("\n�ڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡ�\n\n");

	do {
		do {
			limit = 1;

			//////////////////////////////////////////���� 6�� �ޱ�(�ߺ�üũ �ϸ鼭)////////////////////////////////////////////

			for (int i = 0; i < 6; i++) {
				num[i] = ball[rand() % 12];  // �ζ� ��ȣ �ޱ�		

				if (i > 0) {// i�� 1 �̻��� ��� ���� �ߺ� üũ
					for (int j = 0; j < i; j++)
						if (num[i] == num[j]) { // �ߺ��Ǹ� ����
							limit = 0; // �ߺ� ���� �����Ƿ� �ٽ� �����Ŵ	
							break;
						}

					if (limit == 0)
						break; //break�� for���� Ż���ϴ� ������ �մϴ�. 2�� for���̱� ������ break�� 2�� ����ؾ� �մϴ�.
				}
			}

			///////////////////////////////////////////////////���/////////////////////////////////////////////////////////////

			if (limit == 1) {
				for (int i = 0; i < 6; i++) {

					if (num[i] > 9) // ���� 6���� ����ϰ� ����ϱ� ���ؼ� ����߽��ϴ�.
						printf("%d ", num[i]);
					else
						printf(" %d ", num[i]);
				}
			}
		} while (limit == 0);




		cnt++;// credit(����)�� ��ŭ�� �ݺ����� ���� ���ؼ� ���˴ϴ�.
		printf("\n");

	} while (cnt < credit);
}
void lotto2(int credit) {

	int ball[12] = { 10, 12, 16 , 17, 18, 21, 24, 34, 38, 39, 42, 43 }; // 733ȸ���� ��谡 ��ü��. 733 ~ 920ȸ���� ���� �߳��� ���� 12��
	int num[6]; // �ζ� ��ȣ�� 6���� ���� �迭
	int limit; // �ߺ� üũ�� ���� ����
	int cnt = 0;
	int jnum = 0; // just random number

	printf("\n�ڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡ�\n\n");

	do {
		printf("��� �׳� ���� ���ڸ� ����Ͻðڽ��ϱ�?: ");
		scanf_s("%d", &jnum);

		if (jnum > 6 || jnum <= 0)
			printf("�ùٸ� ������ ���� �Է��ϼ���\n");

	} while (jnum > 6 || jnum <= 0);

	do {
		do {
			limit = 1;
			for (int i = 0; i < 6; i++) {
				if (jnum > i) {
					num[i] = rand() % 45 + 1;  // �ζ� ��ȣ �ޱ�
				}
				else {
					num[i] = ball[rand() % 12];
				}

				if (i > 0) {// i�� 1 �̻��� ��� ���� �ߺ� üũ
					for (int j = 0; j < i; j++)
						if (num[i] == num[j]) { // �ߺ��Ǹ� ����
							limit = 0; // �ߺ� ���� �����Ƿ� �ٽ� �����Ŵ		
							break;
						}

					if (limit == 0)
						break;
				}
			}
			/////////////////////////////////////////////���////////////////////////////////////////////

			if (limit == 1) {
				for (int i = 0; i < 6; i++) {

					if (num[i] > 9)			// ���� 6���� ����ϰ� ����ϱ� ���ؼ� ����߽��ϴ�.
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

	int num[6]; // �ζ� ��ȣ�� 6���� ���� �迭
	int limit; // �ߺ� üũ�� ���� ����
	int cnt = 0;

	printf("\n�ڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡڡ�\n\n");

	do {
		do {

			do {
				limit = 1;
				for (int i = 0; i < 6; i++) {

					num[i] = percent();  // �ζ� ��ȣ �ޱ�		

					if (i > 0) {// i�� 1 �̻��� ��� ���� �ߺ� üũ
						for (int j = 0; j < i; j++) {
							if (num[i] == num[j]) { // �ߺ��Ǹ� ����
								limit = 0; // �ߺ� ���� �����Ƿ� �ٽ� �����Ŵ	
								break;
							}
						}

						if (limit == 0)
							break; //break�� for���� Ż���ϴ� ������ �մϴ�. 2�� for���̱� ������ break�� 2�� ����ؾ� �մϴ�.
					}
				}

				if (limit == 1) {
					for (int i = 0; i < 6; i++) {
						if (num[i] > 9)			// ���� 6���� ����ϰ� ����ϱ� ���ؼ� ����߽��ϴ�.
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

	if (rnumber < 336) // 1���� �� 0~335
		return 12;

	else if (rnumber < 626) // 2���� �� 336~ 625
		return 38;

	else if (rnumber < 908) // 3���� �� 
		return 18;

	else if (rnumber < 1180) // 4���� ��
		return 43;

	else if (rnumber < 1455) // 5���� ��
		return 16;

	else if (rnumber < 1835) // 6���� ��
		return 21;

	else if (rnumber < 2102) // 7���� ��
		return 17;

	else if (rnumber < 2369) // 8���� ��
		return 42;

	else if (rnumber < 2636) // 9���� ��
		return 34;

	else if (rnumber < 2891) // 10���� ��
		return 10;

	else if (rnumber < 3146) // 11���� ��
		return 39;

	else if (rnumber < 3401) // 12���� ��
		return 24;

	else if (rnumber < 3656) // 13���� ��
		return 19;

	else if (rnumber < 3911) // 14���� ��
		return 45;

	else if (rnumber < 4155) // 15���� ��
		return 33;

	else if (rnumber < 4390) // 16���� ��
		return 31;

	else if (rnumber < 4625) // 17���� ��
		return 30;

	else if (rnumber < 4860) // 18���� ��
		return 6;

	else if (rnumber < 5095) // 19���� ��
		return 3;

	else if (rnumber < 5324) // 20���� ��
		return 36;

	else if (rnumber < 5553) // 21 ���� ��
		return 13;

	else if (rnumber < 5766) // 22���� ��
		return 28;

	else if (rnumber < 5987) // 23���� ��
		return 14;

	else if (rnumber < 6208) // 24���� ��
		return 27;

	else if (rnumber < 6429) // 25���� ��
		return 32;

	else if (rnumber < 6642) // 26���� ��
		return 2;

	else if (rnumber < 6855) // 27���� ��
		return 11;

	else if (rnumber < 7068) // 28���� ��
		return 26;

	else if (rnumber < 7281) // 29���� ��
		return 9;

	else if (rnumber < 7487) // 30���� ��
		return 41;

	else if (rnumber < 7693) // 31���� ��
		return 5;

	else if (rnumber < 7891) // 32���� ��
		return 15;

	else if (rnumber < 8089) // 33���� ��
		return 4;

	else if (rnumber < 8287) // 34���� ��
		return 29;

	else if (rnumber < 8478) // 35���� ��
		return 35;

	else if (rnumber < 8669) // 36���� ��
		return 22;

	else if (rnumber < 8852) // 37���� ��
		return 7;

	else if (rnumber < 9028) // 38���� ��
		return 23;

	else if (rnumber < 9196) // 39���� ��
		return 44;

	else if (rnumber < 9364) // 40���� ��
		return 37;

	else if (rnumber < 9528) // 41���� ��
		return 40;

	else if (rnumber < 9692)  //  42���� ��
		return 1;

	else if (rnumber < 9798) // 43���� ��
		return 25;

	else if (rnumber < 9904) // 44���� ��
		return 8;

	else 					 //45���� ��
		return 20;
}