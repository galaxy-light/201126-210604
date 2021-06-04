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
	//���ǰ� ���� �ʿ� c1,c2 == 0 �̸� �����䱸ȭ�� ���
	int c1 = 0; //6���� �������� 0: < 138 1 : = 138 2 : >138
	int c2 = 0; //Ȧ�� ����
	int option = require_setting();
	while (option)
	{		
		printf("c1:%d c2:%d\n",c1,c2); //�ʱⰪ Ȯ�ο�
		if (option==2)
		{
			display_default();
			option = select_option();
		}
		int ref_opt = 0; // ���ÿɼǰ� ���� 1.���� 2.�ڵ� 3.����
		switch (option)
		{
		case 1:
		{
			printf("���� �����ϱ⸦ �����ϼ̽��ϴ�\n");
			printf("--------------------------------------------------------\n");
			int size = file_count();
			int** lotto = malloc(sizeof(int*) * size); //���� �����ͷ� 2���� �迭(���� �޸� �Ҵ�)
			for (int i = 0; i < size; i++)
			{
				lotto[i] = malloc(sizeof(int) * 7);
			}
			for (int v = 0; v < size; v++) //�Էµ� �� �ʱ�ȭ
			{
				for (int h = 0; h < 7; h++)
				{
					lotto[v][h] = 0;
				}
			}

			//<���ǰ��� �����ϱ�> text������ ���� �Է��ϱ�
			FILE* text = fopen("lotto.txt", "rt"); //FILE* fopen(const char* filename, const char* mode); //���� �����ϱ� rt:�б���
			if (text == NULL)
			{
				puts("���Ͽ��� ����!"); //puts:���ڿ��� ���(�ӵ����)
				return-1; //�����޼����� ��ȯ		
			}
			int temp;
			while ((temp = fgetc(text)) != EOF) //text������ ���ڵ��� �迭�� ����ֱ� //fgetc:��Ʈ���� FILE��ü�� ���� ������ //EOF:EndOfFile �����ǳ����� �о����
			{
				for (int v = 0; v < size; v++)
				{
					for (int h = 0; h < 7; h++)
					{
						fscanf(text, "%d", &temp); //text���Ͽ��� ���� ������ �Է¹���, ���� ���� ������ ����,��,���� ���ڷ� ��
						lotto[v][h] = temp; //text���Ͽ��� ���� ȸ��, ��÷��ȣ�� �Է�				
					}
				}
			}
			fclose(text); // int fflush(FILE* restrict stream); ���ۺ���
			//for (int v = 0; v < size; v++) //2 �Էµ� �� ȭ�� ����ϱ�
			//{
			//	for (int h = 0; h < 7; h++)
			//	{
			//		printf("%d ", lotto[v][h]);
			//	}
			//	printf("\n");
			//}

			srand((unsigned int)time(NULL)); //��ġ���� �ʿ��Ѱ�? �����ִ밪?
			
			//<����1. [�ζ� ��ȣ 6���� ��][�ּ�ġ�� �ִ�ġ�� ��� 138]�� �������� ������ �ľ�, ������ ����>
			int n = 0; //�ֱ� ��÷ȸ������
			int spread[3] = { 0, }; //6���� �������� 0:<138 1:=138 2:>138
			int temp_sum = 0;
			printf("����1�� ���� �ֱ� ��÷ȸ�� ������ �Է��ϼ���\n");
			scanf("%d", &n);
			for (int v = 0; v < n; v++)
			{
				for (int h = 0; h < 6; h++)
				{
					temp_sum += lotto[size - 1 - v][h + 1]; //h+1:lotto[][0]==ȸ������(��)�̱� ����
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
				temp_sum = 0; //���� �ִ밪, �ּҰ��� �����ϱ� ���� �ʱ�ȭ
			}
			printf("count_down:%d count_same:%d count_up:%d\n", spread[0], spread[1], spread[2]); //��°� Ȯ��
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
			c1 = c1_cnt; //6���� �������� 0:<138 1:=138 2:>138
			printf("rand_c1:%d\n", rand_c1);
			printf("n:%d\n", n);
			printf("6���� �������� 0:<138 1:=138 2:>138 %d\n", c1);
			//system("PAUSE");

			////<����2. ��÷��ȣ�� n���� Ȧ���� ���� ������ ������ ����>
			int hol_rec[7] = { 0, }; //Ȧ���� ���� �� �ִ� ����� ���� ī��Ʈ
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
						cnt++; //Ȧ���� ��� ǥ��
					}
				}
				hol_rec[cnt]++;
			}
			for (int i = 0; i < 7; i++) //��°� Ȯ��
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
			c2 = c2_cnt; //Ȧ�� ����
			printf("rand_c2:%d\n", rand_c2);
			printf("size:%d\n", size);
			printf("�ζǹ迭�� Ȧ������:%d\n", c2);

			for (int i = 0; i < size; i++) //���� ũ�⸸ŭ �ݺ�
			{
				free(lotto[i]); //2���� �迭�� ���� ���� �޸� ����
			}
			free(lotto); //2���� �迭�� ���� ���� �޸� ����

			option = 2;
			break;
		}
		case 2:
			printf("�ڵ��� �����ϼ̽��ϴ�\n");
			printf("--------------------------------------------------------\n");
			printf("������ ��ǰǰ���? ");			
			srand((unsigned int)time(NULL)); //��ġ���� �ʿ��Ѱ�? �����ִ밪?
			int size = select_num(); //�ζ� ������� ���ϱ�
			int** lotto = malloc(sizeof(int*) * size); //���� �����ͷ� 2���� �迭(���� �޸� �Ҵ�)
			for (int i = 0; i < size; i++)
			{
				lotto[i] = malloc(sizeof(int) * 6);
			}
			for (int v = 0; v < size; v++) //�Էµ� �� �ʱ�ȭ
			{
				for (int h = 0; h < 6; h++)
				{
					lotto[v][h] = 0;
				}
			}

			for (int num = 0; num < size; num++)
			{
				printf("num:%d\n", num);
				for (int i = 0; i < 6; i++) //�����ζ�6�ڸ�
				{
					int r = (rand() % 45) + 1;
					lotto[num][i] = r;
					for (int j = 0; j < i; j++) //�������� ��øȮ��
					{
						if (lotto[num][j] == lotto[num][i])
						{
							i--;
							break;
						}
					}
				}

				//�ζǹ迭 ��ø���� 
				int chk_count;
				int err = 1;
				for (int chk = 0; chk < size; chk++)
				{
					if (chk != num)
					{
						chk_count = 0;
						for (int i = 0; i < 6; i++)
						{
							for (int j = 0; j < 6; j++) //�������� ��øȮ��
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

				//����1[c1] 6���� �������� 0: < 138 1 : = 138 2 : >138
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

				//����2[c2] Ȧ�� ���� ����
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
			for (int num=0; num<size; num++) //�������� ����
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

			//����1[c1]Ȯ�� 6���� �������� 0: < 138 1 : = 138 2 : >138
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
			
			for (int v=0; v<size; v++) //�ζ� ����ϱ�
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
			printf("�߸��� ��ȣ�Դϴ�");
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
		printf("�ʱ⼳���� �ϼž� �մϴ�\n");
		printf("--------------------------------------------------------\n");
		printf("1. �ʱ⼳���ϱ�\n");
		printf("2. ���α׷� �����ϱ�\n");
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
	printf("�ζ� ���α׷��̿�\n");
	printf("--------------------------------------------------------\n");
	printf("�ɼ��� ������ �ּ���\n");
	printf("1. ���� �����ϱ�\n");
	printf("2. �ڵ����� �̱�\n");
	printf("3. ���α׷� �����ϱ�\n");
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
	int count_line = 0; //�༼���
	char temp[1024] = { 0, }; //�ӽ� �� �б��

	if (text == NULL)
	{
		puts("���Ͽ��� ����!");
		return-1;
	}

	while (!feof(text)) //�హ�� �б�
	{
		fgets(temp, 1024, text);
		//printf("temp = %s", temp); //�హ�� �б� Ȯ�ο�
		count_line++;
	}
	//printf("\n"); //�హ�� �б� Ȯ�ο�

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