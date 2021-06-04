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

	//����ȸ������,���,�ִ�,�ּ�
	int c1[24][4] = { 0, };
	FILE* case1 = fopen("C:\\C_Bold\\example\\case1.txt", "rt");
	if (case1 == NULL)
	{
		puts("���Ͽ��� ����!"); //puts:���ڿ��� ���(�ӵ����)
		return-1; //�����޼����� ��ȯ
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
	//����ȸ������,���� ��ȣ,��ġ�ϴ� ����
	int c2[8][46] = { 0, };
	int c2_n[4] = { 0,1,2,3 };
	FILE* case2 = fopen("C:\\C_Bold\\example\\case2.txt", "rt");
	if (case2 == NULL)
	{
		puts("���Ͽ��� ����!"); //puts:���ڿ��� ���(�ӵ����)
		return-1; //�����޼����� ��ȯ
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
	//Ȧ���� ���� �� �ִ� ����� ��,����ȸ������,n���� Ȧ���� ���� Ȯ��*10:�Ҽ�������
	int c3_n[5] = { 1,2,3,4,5 };
	int c3[30][8] = { 0, };
	FILE* case3 = fopen("C:\\C_Bold\\example\\case3.txt", "rt");
	if (case3 == NULL)
	{
		puts("���Ͽ��� ����!"); //puts:���ڿ��� ���(�ӵ����)
		return-1; //�����޼����� ��ȯ
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

	int l_920[6] = { 2,3,26,33,34,43 }; //920ȸ ��÷��ȣ

	while (1)
	{
		int lotto[6] = { 0, };
		int r;
		int ref_opt = 0; // ���ÿɼǰ� ���� 1.�ڵ� 2.���� 3.����
		int result[720][9] = {0,}; // ����1+3������� 920ȸ�� ��ġ�ϴ� ��ȣ�� �� {����1,����3,0,1,2,3,4,5,6}
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
			printf("�ڵ��� �����ϼ̽��ϴ�\n");
			printf("----------------------\n");
			//���Ǻ� �ζ� ��÷�� Ȯ��
			srand((unsigned int)time(NULL));
			for (int c3_r = 0; c3_r < 30; c3_r++) //����3 ��������
			{				
				for (int c1_r = 0; c1_r < 24; c1_r++) //����1 ��������
				{					
					result[r_v][0] = c1_r + 1;
					result[r_v][1] = c3_r + 1;	
					for (int cnt = 0; cnt < 1000; cnt++) //�������� �ּҰ��������
					{
						int chk_full = 0;
						int tmp_sum = 0;
						for (int i = 0; i < 6; i++) //�����ζ�6�ڸ�
						{
							r = (rand() % 45) + 1;
							lotto[i] = r;
							for (int j = 0; j < i; j++) //�������� ��øȮ��
							{
								if (lotto[j] == lotto[i])
								{									
									i--;
									err1 = 1;
									break;
								}
							} //�������� ��øȮ��
							if (err1==0) //�������� ��ø�� �ƴҶ�
							{
								tmp_sum += lotto[i];
								if (i == 5) //������ȣ6���� ���� ��
								{
									if (c1[c1_r][2] < tmp_sum || c1[c1_r][3] > tmp_sum) //����1 �ִ밪 �ּҰ�
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
						} //����6�ڸ� �Ϸ�
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
					//printf("����1:%d ����3:%d ��ġ�ϴ� ��÷��ȣ�� ����:%d(0��) %d(1��) %d(2��) %d(3��) %d(4��) %d(5��) %d(6��)\n", result[r_v][0], result[r_v][1], result[r_v][2], result[r_v][3], result[r_v][4], result[r_v][5], result[r_v][6], result[r_v][7], result[r_v][8]);
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
			for (int i = 0; i < 720; i++) //��������
			{
				printf("����1:%d ����3:%d ��ġ�ϴ� ��÷��ȣ�� ����:%d(0��) %d(1��) %d(2��) %d(3��) %d(4��) %d(5��) %d(6��) �հ�:%d\n", result[i][0], result[i][1], result[i][2], result[i][3], result[i][4], result[i][5], result[i][6], result[i][7], result[i][8], result[i][2]+result[i][3]+result[i][4]+result[i][5]+result[i][6]+result[i][7]+result[i][8]);
				//system("PAUSE");
			}
			//���Ǻ� �ζ� ��÷�� Ȯ��
			break;
		case 2:
			printf("������ �����ϼ̽��ϴ�\n");
			printf("----------------------\n");
			break;
		case 3:
			exit(0);
		default:
			printf("�߸��� ��ȣ�Դϴ�");
			printf("----------------------\n");
		}
		system("pause");
		system("cls");
	}//�ݺ�����
}//main����

void dis_default()
{
	printf("----------------------\n");
	printf("�ζ� ���α׷��̿�\n");
	printf("----------------------\n");
	printf("�ɼ��� ������ �ּ���\n");
	printf("1.�ڵ����� �̱�\n");
	printf("2.�������� �̱�\n");
	printf("3.���α׷� �����ϱ�\n");
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