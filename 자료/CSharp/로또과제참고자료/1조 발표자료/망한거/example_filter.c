#define _CRT_SECURE_NO_WARNINGS // scanf()
#include <stdio.h>
#include <windows.h> // system("PAUSE") system("cls")

int lotto[920][7] = { 0, }; // 920ȸ������ ��÷�ζǹ�ȣ�� ���� �迭 lotto[v][h]={ȸ��,��÷��ȣ1,...}
int main()
{
	//<���ǰ��� �����ϱ�> text������ ���� �Է��ϱ�
	FILE* text = fopen("E:\\7_c\\example\\example\\lotto.txt", "rt"); //FILE* fopen(const char* filename, const char* mode); //���� �����ϱ� rt:�б���
	if (text == NULL)
	{
		puts("���Ͽ��� ����!"); //puts:���ڿ��� ���(�ӵ����)
		return-1; //�����޼����� ��ȯ		
	}
	int num;
	while ((num = fgetc(text)) != EOF) //text������ ���ڵ��� �迭�� ����ֱ� //fgetc:��Ʈ���� FILE��ü�� ���� ������ //EOF:EndOfFile �����ǳ����� �о����
	{
		for (int v = 0; v < 920; v++) //920����� �ݺ�
		{
			for (int h = 0; h < 7; h++) //7������ �ݺ�
			{
				fscanf(text, "%d", &num); //text���Ͽ��� ���� ������ �Է¹���, ���� ���� ������ ����,��,���� ���ڷ� ��
				lotto[v][h] = num; //text���Ͽ��� ���� ȸ��, ��÷��ȣ�� �Է�				
			}			
		}
	}
	fclose(text); // int fflush(FILE* restrict stream); ���ۺ���

	//<����1. �����Լ��� ���� [��ȣ���� ����]�� ������ ����, ��հ��� �������� ���缺�� ���ٰ� �Ǵ�>
	int n; //920ȸ ������ �ֱ� ��÷ȸ��
	int max = 0; //�ֱ�nȸ���� �� ȸ����[��ȣ���� ����]���� �ִ밪
	int min = 256; //�ֱ�nȸ���� �� ȸ����[��ȣ���� ����]���� �ּҰ� (��÷��ȣ��45~40�� ��츦 ���� ����)
	float avg; //�ֱ�nȸ���� �� ȸ����[��ȣ���� ����]���� ��հ�
	int tmp_sum = 0; //max,min,avg�� ������ ���� �� ȸ����[��ȣ���� ����]
	float avg_sum = 0; //avg�� ������ ���� �ӽð�
	int result_index = 0;
	int result_n[24] = { 0, };
	int result_max[24] = { 0, };
	int result_min[24] = { 0, };
	int result_avg[24] = { 0, };
	for (n = 5; n < 121; n += 5) //�ֱ� ��ȸ�б��� ������� ����
	{
		for (int v = 0; v < n; v++) //lotto[][]�迭���� �ֱ�nȸ���б��� ���������� ��ٲ�
		{
			for (int h = 0; h < 6; h++) //lotto[][]�迭���� �ֱ�nȸ���б��� ���������� ���ٲ�
			{
				tmp_sum += lotto[919 - 1 - v][h + 1]; //h+1:lotto[][0]==ȸ������(��)�̱� ����
			}
			if (tmp_sum > max) //�ִ밪����
			{
				max = tmp_sum;
			}
			if (tmp_sum < min) //�ּҰ�����
			{
				min = tmp_sum;
			}
			avg_sum += tmp_sum; //�ֱ�nȸ������ [��ȣ���� ����]���� ��հ��� ���� ����
			tmp_sum = 0; //���� �ִ밪, �ּҰ��� �����ϱ� ���� �ʱ�ȭ
		}
		avg = avg_sum / n; //�ֱ�nȸ������ [��ȣ���� ����]���� ��հ�
		result_n[result_index] = n;
		result_max[result_index] = max;
		result_min[result_index] = min;
		result_avg[result_index] = avg;
		result_index++; //�ֱ�nȸ��,max,min,avg���� �����ϰ� �������� �Է��ϱ� ���� index���
		avg_sum = 0; //���� �ֱ�nȸ������ [��ȣ���� ����]���� ��հ��� ���ϱ� ���� �ʱ�ȭ
		max = 0; //���� �ֱ�nȸ������ [��ȣ���� ����]���� �ִ밪�� ���ϱ� ���� �ʱ�ȭ
		min = 256; //���� �ֱ�nȸ������ [��ȣ���� ����]���� �ּҰ��� ���ϱ� ���� �ʱ�ȭ
	}

	//<����2. �����Լ��� ���� ��ȣ��� �ֱ� ��÷ȸ���� ��ȣ�� [��ġ�ϴ� ����]�� ������>
	int same_n[4] = {0,1,2,3}; //��ġ�ϴ� ����
	int same[8][46] = { 0, }; //���� �ֱ�ȸ�������� ���� ��ȣ (same[same_v][same_h]={�ֱ�ȸ������,��ġ�ϴ°��� ������,...})
	int same_v = 0;
	for (n = 5; n < 41; n += 5) //�ֱ� nȸ�б��� ������� ����
	{
		same[same_v][0] = n; //same[1~8][0] ȸ������ ����
		for (int v = 0; v < n; v++)
		{
			for (int h = 0; h < 6; h++)
			{
				num = lotto[919 - 1 - v][h + 1];
				for (int same_h = 0; same_h < 45; same_h++)
				{
					if (same[same_v][same_h + 1] == num) //�ֱ�919ȸ�������� ��÷��ȣ�� �Ѱ��� same[][]�� ��øȮ��
					{
						break; //��ø�Ͻ� ���� ��÷��ȣ lotto[][]��ٲ�
					}
				}
				same[same_v][num] = num; //��ø�� �ƴ� �� same[][] = {�ֱ�nȸ����,1~45�� ��ġ�� ������ġ�� ǥ��}
			}
		}
		same_v++; //�ֱ�nȸ������ ����
	}

	//<����3. Ư������������ ��÷��ȣ�� n���� Ȧ���� ���� ������ ������ ����>
	const int hol_n[7] = { 0, 1, 2, 3, 4, 5, 6 }; //Ȧ���� ���� �� �ִ� ����� ��
	int hol_rec[30][8] = { 0, }; //�ֱ�nȸ����, n���� Ȧ���� ���°��� (hol_rec[range_index][]={range,Ȧ���� ���� ���� ������,...})
	int range; //�ֱ�nȸ����
	int range_index = 0;
	for (range = 10; range < 301; range += 10) //�ֱ� ��ȸ�б��� ������� ����
	{
		hol_rec[range_index][0] = range; //hol_rec[][]�� �������� �Է�
		for (int v = 0; v < range; v++)
		{
			int cnt = 0; //lotto[][]���� Ȯ���� ȸ���� �ٲ� �� �ʱ�ȭ
			for (int h = 0; h < 6; h++)
			{
				num = lotto[919 - 1 - v][h + 1]; //�ҷ�����
				if (num % 2 == 1) 
				{
					cnt++; //Ȧ���� ��� ǥ��
				}
			}
			hol_rec[range_index][cnt + 1]++; //lotto[][]�� ȸ���� n���� Ȧ���� ���� ������ ����
		}
		range_index++; //�ֱ�nȸ���� ����
	}	
	int prob_rec[30][8] = { 0, }; //porb �ֱ�nȸ����, n���� Ȧ���� ����Ȯ�� hol_rec[30][8]
	range_index = 0;
	for (range = 10; range < 301; range += 10) //prob_rec[0~29][0]ȸ������ �Է�
	{
		prob_rec[range_index][0] = range;
		range_index++;
	}	
	for (int v = 0; v < 30; v++) //prob_rec[0~29][1~7]n���� Ȧ���� ���� Ƚ���� Ȯ���� ����
	{
		for (int h = 0; h < 7; h++)
		{
			prob_rec[v][h + 1] = hol_rec[v][h + 1] * 100 * 10 / prob_rec[v][0];
		}
	}

	//<���ǰ��� ����ϱ�> text���Ͽ� ���� �Է��ϱ�
	FILE* output_text = fopen("E:\\7_c\\example\\example\\req.txt", "wt"); //FILE* fopen(const char* filename, const char* mode); //���� �����ϱ� rt:�б���
	if (output_text == NULL)
	{
		puts("���Ͽ��� ����!"); //puts:���ڿ��� ���(�ӵ����)
		return-1; //�����޼����� ��ȯ		
	}

	//����1�� ������� ���[����ȸ������, ���, �ִ밪, �ּҰ�]
	fprintf(output_text, "����1�� ������� ���[����ȸ������, ���, �ִ밪, �ּҰ�]\n");
	fprintf(output_text, "����ȸ������ avg max min\n");
	for (result_index = 0; result_index < 24; result_index++)
	{
		fprintf(output_text,"%d %d %d %d\n", result_n[result_index], result_avg[result_index], result_max[result_index], result_min[result_index]);
	}

	//����2�� ������� ���[����ȸ������, ���� ��ȣ, ��ġ�ϴ� ���� ����]
	fprintf(output_text, "\n����2�� ������� ���[����ȸ������, ���� ��ȣ, ��ġ�ϴ� ���� ����]\n");
	fprintf(output_text, "��ġ�ϴ� ���� ���� ");
	for (int i = 0; i < 4; i++)
	{
		fprintf(output_text,"%d ", same_n[i]);
	}
	fprintf(output_text, "\n����ȸ������ ���� ��ȣ\n");
	for (int v = 0; v < 8; v++)
	{
		for (int h = 0; h < 46; h++)
		{
			fprintf(output_text, "%d ", same[v][h]);
		}
		fprintf(output_text, "\n");
	}

	//����3�� ������� ���[Ȧ���� ���� �� �ִ� ����� ��, ����ȸ������, n���� Ȧ���� ���� Ȯ��*10:�Ҽ�������]
	fprintf(output_text, "\n����3�� ������� ���[Ȧ���� ���� �� �ִ� ����� ��, ����ȸ������, n���� Ȧ���� ���� Ȯ��*10:�Ҽ�������]\n");
	fprintf(output_text, "Ȧ���� ���� �� �ִ� ����� �� ");
	for (int h = 0; h < 7; h++)
	{
		fprintf(output_text, "%d ", hol_n[h]);
	}
	fprintf(output_text, "\n����ȸ������ (n���� Ȧ���� ���� Ȯ��*10:�Ҽ�������)\n");
	for (int v = 0; v < 30; v++)
	{
		for (int h = 0; h < 8; h++)
		{
			fprintf(output_text, "%d ", prob_rec[v][h]);
		}
		fprintf(output_text, "\n");
	}

	fclose(output_text); // int fflush(FILE* restrict stream); ���ۺ���
}