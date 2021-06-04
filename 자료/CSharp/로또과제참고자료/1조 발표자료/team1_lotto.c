#define _CRT_SECURE_NO_WARNINGS // scanf()
#include <stdio.h>
#include <stdlib.h> //malloc, free
#include <windows.h> // system("PAUSE") system("cls")

int file_count();
//int file_read(int size, int lotto[][7]);
int require_setting();
void display_default();
int select_option();
int select_num();

int main()
{
	//조건값 생성 필요 c1,c2 == 0 이면 설정요구화면 출력
	int c1 = 0; //6개의 숫자합이 0: < 138 1 : = 138 2 : >138
	int c2 = 0; //홀수 갯수
	int option = require_setting();
	while (option)
	{		
		printf("c1:%d c2:%d\n",c1,c2); //초기값 확인용
		if (option==2)
		{
			display_default();
			option = select_option();
		}
		int ref_opt = 0; // 선택옵션값 저장 1.설정 2.자동 3.종료
		switch (option)
		{
		case 1:
		{
			printf("조건 생성하기를 선택하셨습니다\n");
			printf("--------------------------------------------------------\n");
			int size = file_count();
			int** lotto = malloc(sizeof(int*) * size); //이중 포인터로 2차원 배열(동적 메모리 할당)
			for (int i = 0; i < size; i++)
			{
				lotto[i] = malloc(sizeof(int) * 7);
			}
			for (int v = 0; v < size; v++) //입력된 값 초기화
			{
				for (int h = 0; h < 7; h++)
				{
					lotto[v][h] = 0;
				}
			}

			//<조건값을 도출하기> text파일의 내용 입력하기
			FILE* text = fopen("lotto.txt", "rt"); //FILE* fopen(const char* filename, const char* mode); //파일 참조하기 rt:읽기모드
			if (text == NULL)
			{
				puts("파일오픈 실패!"); //puts:문자열만 출력(속도향상)
				return-1; //에러메세지를 반환		
			}
			int temp;
			while ((temp = fgetc(text)) != EOF) //text파일의 숫자들을 배열에 집어넣기 //fgetc:스트림의 FILE객체에 대한 포인터 //EOF:EndOfFile 파일의끝까지 읽어들임
			{
				for (int v = 0; v < size; v++)
				{
					for (int h = 0; h < 7; h++)
					{
						fscanf(text, "%d", &temp); //text파일에서 변수 단위로 입력받음, 변수 간의 구분은 공백,탭,개행 문자로 함
						lotto[v][h] = temp; //text파일에서 받은 회차, 당첨번호를 입력				
					}
				}
			}
			fclose(text); // int fflush(FILE* restrict stream); 버퍼비우기
			//for (int v = 0; v < size; v++) //2 입력된 값 화면 출력하기
			//{
			//	for (int h = 0; h < 7; h++)
			//	{
			//		printf("%d ", lotto[v][h]);
			//	}
			//	printf("\n");
			//}

			srand((unsigned int)time(NULL)); //위치조정 필요한가? 랜덤최대값?
			
			//<조건1. [로또 번호 6개의 합][최소치와 최대치의 평균 138]을 기준으로 분포를 파악, 비중을 적용>
			int n = 0; //최근 당첨회차지정
			int spread[3] = { 0, }; //6개의 숫자합이 0:<138 1:=138 2:>138
			int temp_sum = 0;
			printf("조건1에 사용될 최근 당첨회차 범위를 입력하세요\n");
			scanf("%d", &n);
			for (int v = 0; v < n; v++)
			{
				for (int h = 0; h < 6; h++)
				{
					temp_sum += lotto[size - 1 - v][h + 1]; //h+1:lotto[][0]==회차정보(열)이기 때문
				}
				if (temp_sum < 138)
				{
					spread[0]++;
				}
				else if (temp_sum == 138)
				{
					spread[1]++;
				}
				else
				{
					spread[2]++;
				}
				temp_sum = 0; //다음 최대값, 최소값을 갱신하기 위해 초기화
			}
			printf("count_down:%d count_same:%d count_up:%d\n", spread[0], spread[1], spread[2]); //출력값 확인
			//system("PAUSE");
			int rand_c1 = (rand() % n) + 1;			
			int cal_1 = 0;
			int c1_cnt = 0;
			for (int i = 0; i < 3; i++)
			{
				cal_1 += spread[i];
				if (cal_1 < rand_c1)
				{
					c1_cnt++;
				}
			}
			c1 = c1_cnt; //6개의 숫자합이 0:<138 1:=138 2:>138
			printf("rand_c1:%d\n", rand_c1);
			printf("n:%d\n", n);
			printf("6개의 숫자합이 0:<138 1:=138 2:>138 %d\n", c1);
			//system("PAUSE");

			////<조건2. 당첨번호중 n개의 홀수가 나온 갯수의 비율을 적용>
			int hol_rec[7] = { 0, }; //홀수가 나올 수 있는 경우의 수를 카운트
			int temp_hol = 0;
			int cnt = 0;
			for (int v = 0; v < size; v++)
			{
				cnt = 0;
				for (int h = 0; h < 6; h++)
				{
					temp_hol = lotto[size - 1 - v][h + 1];
					if (temp_hol % 2 == 1)
					{
						cnt++; //홀수일 경우 표식
					}
				}
				hol_rec[cnt]++;
			}
			for (int i = 0; i < 7; i++) //출력값 확인
			{
				printf("%d ",hol_rec[i]);
			}
			printf("\n");
			int rand_c2 = (rand() % size) + 1;
			int cal_2 = 0;
			int c2_cnt = 0;
			for (int i = 0; i < 7; i++)
			{
				cal_2 += hol_rec[i];
				if (cal_2 < rand_c2)
				{
					c2_cnt++;
				}
			}
			c2 = c2_cnt; //홀수 갯수
			printf("rand_c2:%d\n", rand_c2);
			printf("size:%d\n", size);
			printf("로또배열의 홀수갯수:%d\n", c2);

			for (int i = 0; i < size; i++) //세로 크기만큼 반복
			{
				free(lotto[i]); //2차원 배열의 가로 공간 메모리 해제
			}
			free(lotto); //2차원 배열의 세로 공간 메모리 해제

			option = 2;
			break;
		}
		case 2:
			printf("자동을 선택하셨습니다\n");
			printf("--------------------------------------------------------\n");
			printf("몇장을 사실건가요? ");			
			srand((unsigned int)time(NULL)); //위치조정 필요한가? 랜덤최대값?
			int size = select_num(); //로또 몇개뽑을지 정하기
			int** lotto = malloc(sizeof(int*) * size); //이중 포인터로 2차원 배열(동적 메모리 할당)
			for (int i = 0; i < size; i++)
			{
				lotto[i] = malloc(sizeof(int) * 6);
			}
			for (int v = 0; v < size; v++) //입력된 값 초기화
			{
				for (int h = 0; h < 6; h++)
				{
					lotto[v][h] = 0;
				}
			}

			for (int num = 0; num < size; num++)
			{
				printf("num:%d\n", num);
				for (int i = 0; i < 6; i++) //랜덤로또6자리
				{
					int r = (rand() % 45) + 1;
					lotto[num][i] = r;
					for (int j = 0; j < i; j++) //랜덤숫자 중첩확인
					{
						if (lotto[num][j] == lotto[num][i])
						{
							i--;
							break;
						}
					}
				}

				//로또배열 중첩제거 
				int chk_count;
				int err = 1;
				for (int chk = 0; chk < size; chk++)
				{
					if (chk != num)
					{
						chk_count = 0;
						for (int i = 0; i < 6; i++)
						{
							for (int j = 0; j < 6; j++) //랜덤숫자 중첩확인
							{
								if (lotto[chk][j] == lotto[num][i])
								{
									chk_count++;
									break;
								}
							}
						}
						if (chk_count == 6)
						{
							err--;
							num--;
							break;
						}
					}
				}

				//조건1[c1] 6개의 숫자합이 0: < 138 1 : = 138 2 : >138
				if (err == 1)
				{
					int temp_sum = 0;
					for (int h = 0; h < 6; h++)
					{
						temp_sum += lotto[num][h];
					}
					printf("temp_sum:%d\n", temp_sum);				
					if (c1 == 0)
					{
						if (temp_sum >= 138)
						{
							err--;
							num--;
						}
					}
					if (c1 == 1)
					{
						if (temp_sum != 138)
						{
							err--;
							num--;
						}
					}
					if (c1 == 2)
					{
						if (temp_sum <= 138)
						{
							err--;
							num--;
						}
					}
					//system("PAUSE");
				}

				//조건2[c2] 홀수 갯수 적용
				if (err == 1)
				{
					int count_hol = 0;
					for (int h = 0; h < 6; h++)
					{
						if (lotto[num][h] % 2 == 1)
						{
							count_hol++;
						}
					}
					if (count_hol != c2)
					{
						num--;
					}
				}
			}
			system("PAUSE");
			for (int num=0; num<size; num++) //오름차순 정렬
			{
				int tmp = 0;
				for (int i=0; i<6-1; i++)
				{
					for (int j=0; j<6-1; j++)
					{
						if (lotto[num][j]>lotto[num][j+1])
						{
							tmp = lotto[num][j];
							lotto[num][j] = lotto[num][j + 1];
							lotto[num][j + 1] = tmp;
						}
					}
				}
			}

			//조건1[c1]확인 6개의 숫자합이 0: < 138 1 : = 138 2 : >138
			int temp_sum;
			for (int num = 0; num < size; num++)
			{
				temp_sum = 0;
				for (int h = 0; h < 6; h++)
				{
					temp_sum += lotto[num][h];
				}
				printf("temp_sum:%d\n", temp_sum);
			}
			system("PAUSE");
			
			for (int v=0; v<size; v++) //로또 출력하기
			{
				for (int h=0; h<6; h++)
				{
					printf("%d ", lotto[v][h]);
				}
				printf("\n");
			}

			break;
		case 3:
			exit(0);
		default:
			printf("잘못된 번호입니다");
			printf("--------------------------------------------------------\n");
		}
		system("pause");
		system("cls");
	}
}

int require_setting()
{
	int option = 1;
	while (option)
	{
		printf("--------------------------------------------------------\n");
		printf("초기설정을 하셔야 합니다\n");
		printf("--------------------------------------------------------\n");
		printf("1. 초기설정하기\n");
		printf("2. 프로그램 종료하기\n");
		printf("--------------------------------------------------------\n");
		switch (select_option())
		{
		case 1:
		{
			system("cls");
			printf("--------------------------------------------------------\n");
			return option;		
		}
		case 2:
		{
			exit(0);
			break;
		}
		default:
		{
			system("cls");
			break;
		}
		}
	}
}

void display_default()
{
	printf("--------------------------------------------------------\n");
	printf("로또 프로그램이요\n");
	printf("--------------------------------------------------------\n");
	printf("옵션을 선택해 주세요\n");
	printf("1. 조건 변경하기\n");
	printf("2. 자동으로 뽑기\n");
	printf("3. 프로그램 종료하기\n");
	printf("--------------------------------------------------------\n");
}

int select_option()
{
	int option = 0;
	scanf("%d", &option);
	printf("--------------------------------------------------------\n");
	return(option);
}

int file_count()
{
	FILE* text = fopen("lotto.txt", "rt");
	int count_line = 0; //행세기용
	char temp[1024] = { 0, }; //임시 열 읽기용

	if (text == NULL)
	{
		puts("파일오픈 실패!");
		return-1;
	}

	while (!feof(text)) //행갯수 읽기
	{
		fgets(temp, 1024, text);
		//printf("temp = %s", temp); //행갯수 읽기 확인용
		count_line++;
	}
	//printf("\n"); //행갯수 읽기 확인용

	fclose(text);
	return count_line;
}

int select_num()
{
	while (1)
	{
		int num = 0;
		scanf("%d", &num);
		if (num != 0)
		{
			printf("--------------------------------------------------------\n");
			return(num);
		}
	}
}