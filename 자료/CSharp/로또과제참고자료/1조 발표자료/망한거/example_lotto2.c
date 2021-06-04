#define _CRT_SECURE_NO_WARNINGS // scanf()
#include <stdio.h>
#include <windows.h> // system("PAUSE") system("cls")
#include <stdlib.h> // rand()
#include <time.h> // time()

void dis_default();
int select_option();
int select_num();

int main()
{
	int v;
	int h;
	int temp;

	//근점회차범위,평균,최대,최소
	int c1[24][4] = { 0, };
	FILE* case1 = fopen("C:\\C_Bold\\example\\case1.txt", "rt");
	if (case1 == NULL)
	{
		puts("파일오픈 실패!"); //puts:문자열만 출력(속도향상)
		return-1; //에러메세지를 반환
	}
	while ((temp = fgetc(case1)) != EOF)
	{
		for (v = 0; v < 24; v++)
		{
			for (h = 0; h < 4; h++)
			{
				fscanf(case1, "%d", &temp);
				c1[v][h] = temp;
				printf("%d ", c1[v][h]);
			}
			printf("\n");
		}
	}
	fclose(case1);
	printf("\n");
	//근접회차범위,뽑힌 번호,일치하는 갯수
	int c2[8][46] = { 0, };
	int c2_n[4] = { 0,1,2,3 };
	FILE* case2 = fopen("C:\\C_Bold\\example\\case2.txt", "rt");
	if (case2 == NULL)
	{
		puts("파일오픈 실패!"); //puts:문자열만 출력(속도향상)
		return-1; //에러메세지를 반환
	}
	while ((temp = fgetc(case2)) != EOF)
	{
		for (v = 0; v < 4; v++)
		{
			for (h = 0; h < 46; h++)
			{
				fscanf(case2, "%d", &temp);
				c2[v][h] = temp;
				printf("%d ", c2[v][h]);
			}
			printf("\n");
		}
	}
	fclose(case2);
	printf("\n");
	//홀수가 나올 수 있는 경우의 수,근접회차범위,n개의 홀수가 나온 확률*10:소수점버림
	int c3_n[5] = { 1,2,3,4,5 };
	int c3[30][8] = { 0, };
	FILE* case3 = fopen("C:\\C_Bold\\example\\case3.txt", "rt");
	if (case3 == NULL)
	{
		puts("파일오픈 실패!"); //puts:문자열만 출력(속도향상)
		return-1; //에러메세지를 반환
	}
	while ((temp = fgetc(case3)) != EOF)
	{
		for (v = 0; v < 30; v++)
		{
			for (h = 0; h < 8; h++)
			{
				fscanf(case3, "%d", &temp);
				c3[v][h] = temp;
				printf("%d ", c3[v][h]);
			}
			printf("\n");
		}
	}
	fclose(case3);
	printf("\n");

	int l_920[6] = { 2,3,26,33,34,43 }; //920회 당첨번호

	while (1)
	{
		int lotto[6] = { 0, };
		int r;
		int ref_opt = 0; // 선택옵션값 저장 1.자동 2.수동 3.종료
		int result[720][9] = {0,}; // 조건1+3결과값에 920회와 일치하는 번호의 양 {조건1,조건3,0,1,2,3,4,5,6}
		int r_v = 0;
		int err1 = 0;
		int err2 = 0;
		int err3 = 0;
		int hol[7] = { 0, };
		int hol_cnt = 0;
		dis_default();
		switch (select_option())
		{
		case 1:
			printf("자동을 선택하셨습니다\n");
			printf("----------------------\n");
			//조건별 로또 당첨률 확인
			srand((unsigned int)time(NULL));
			for (int c3_r = 0; c3_r < 30; c3_r++) //조건3 범위변경
			{				
				for (int c1_r = 0; c1_r < 24; c1_r++) //조건1 범위변경
				{					
					result[r_v][0] = c1_r + 1;
					result[r_v][1] = c3_r + 1;	
					for (int cnt = 0; cnt < 1000; cnt++) //한조건의 최소결과누적값
					{
						int chk_full = 0;
						int tmp_sum = 0;
						for (int i = 0; i < 6; i++) //랜덤로또6자리
						{
							r = (rand() % 45) + 1;
							lotto[i] = r;
							for (int j = 0; j < i; j++) //랜덤숫자 중첩확인
							{
								if (lotto[j] == lotto[i])
								{									
									i--;
									err1 = 1;
									break;
								}
							} //랜덤숫자 중첩확인
							if (err1==0) //랜덤숫자 중첩이 아닐때
							{
								tmp_sum += lotto[i];
								if (i == 5) //랜덤번호6개가 됬을 때
								{
									if (c1[c1_r][2] < tmp_sum || c1[c1_r][3] > tmp_sum) //조건1 최대값 최소값
									{
										cnt--;
										err2 = 1;
										break;
									}
									for (int i = 0; i < 6; i++)
									{
										if (lotto[i] % 2 == 1)
										{
											hol_cnt++;
										}
									}
									if (hol[hol_cnt] < c3[c3_r][hol_cnt + 1])
									{
										hol[hol_cnt]++;
									}
									else
									{
										cnt--;
										err3 = 1;
										break;
									}
									printf("%d %d\n", hol[hol_cnt], c3[c3_r][hol_cnt + 1]);								
									printf("%d %d %d %d %d %d %d %d\n", hol[0], hol[1], hol[2], hol[3], hol[4], hol[5], hol[6], hol_cnt);
									printf("%d %d %d %d %d %d %d\n", c3[c3_r][1], c3[c3_r][2], c3[c3_r][3], c3[c3_r][4], c3[c3_r][5], c3[c3_r][6], c3[c3_r][7]);
									//system("PAUSE");
								}
							}
							err1=0;							
						} //랜덤6자리 완료
						if (err1==0 && err2==0 && err3==0)
						{
							int tmp_same = 0;
							for (int a = 0; a < 6; a++)
							{
								for (int b = 0; b < 6; b++)
								{
									if (lotto[b] == l_920[a])
									{
										tmp_same++;
									}
								}
							}
							result[r_v][tmp_same + 2]++;
						}
						err2 = 0;
						err3 = 0;
						hol_cnt = 0;
						if (hol[0] == c3[c3_r][0 + 1])
						{
							if (hol[1] == c3[c3_r][1 + 1])
							{
								if (hol[2] == c3[c3_r][2 + 1])
								{
									if (hol[3] == c3[c3_r][3 + 1])
									{
										if (hol[4] == c3[c3_r][4 + 1])
										{
											if (hol[5] == c3[c3_r][5 + 1])
											{
												if (hol[6] == c3[c3_r][6 + 1])
												{
													chk_full = 1;
												}
											}
										}
									}
								}
							}
						}
						if (chk_full == 1)
						{
							break;
						}
					}
					//printf("조건1:%d 조건3:%d 일치하는 당첨번호의 개수:%d(0개) %d(1개) %d(2개) %d(3개) %d(4개) %d(5개) %d(6개)\n", result[r_v][0], result[r_v][1], result[r_v][2], result[r_v][3], result[r_v][4], result[r_v][5], result[r_v][6], result[r_v][7], result[r_v][8]);
					//system("PAUSE");
					//if (result[r_v][])
					//{
						r_v++;
						for (int i = 0; i < 7; i++)
						{
							hol[i] = 0;
						}
					//}
				}
			}
			for (int i = 0; i < 720; i++) //결과값출력
			{
				printf("조건1:%d 조건3:%d 일치하는 당첨번호의 개수:%d(0개) %d(1개) %d(2개) %d(3개) %d(4개) %d(5개) %d(6개) 합계:%d\n", result[i][0], result[i][1], result[i][2], result[i][3], result[i][4], result[i][5], result[i][6], result[i][7], result[i][8], result[i][2]+result[i][3]+result[i][4]+result[i][5]+result[i][6]+result[i][7]+result[i][8]);
				//system("PAUSE");
			}
			//조건별 로또 당첨률 확인
			break;
		case 2:
			printf("수동을 선택하셨습니다\n");
			printf("----------------------\n");
			break;
		case 3:
			exit(0);
		default:
			printf("잘못된 번호입니다");
			printf("----------------------\n");
		}
		system("pause");
		system("cls");
	}//반복루프
}//main종료

void dis_default()
{
	printf("----------------------\n");
	printf("로또 프로그램이요\n");
	printf("----------------------\n");
	printf("옵션을 선택해 주세요\n");
	printf("1.자동으로 뽑기\n");
	printf("2.수동으로 뽑기\n");
	printf("3.프로그램 종료하기\n");
	printf("----------------------\n");
}

int select_option()
{
	int option = 0;
	scanf("%d", &option);
	printf("----------------------\n");
	return(option);
}

int select_num()
{
	while (1)
	{
		int num = 0;
		scanf("%d", &num);
		if (num != 0)
		{
			printf("----------------------\n");
			return(num);
		}
	}
}