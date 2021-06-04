#define _CRT_SECURE_NO_WARNINGS // scanf()
#include <stdio.h>
#include <windows.h> // system("PAUSE") system("cls")

int lotto[920][7] = { 0, }; // 920회까지의 당첨로또번호를 넣을 배열 lotto[v][h]={회차,당첨번호1,...}
int main()
{
	//<조건값을 도출하기> text파일의 내용 입력하기
	FILE* text = fopen("E:\\7_c\\example\\example\\lotto.txt", "rt"); //FILE* fopen(const char* filename, const char* mode); //파일 참조하기 rt:읽기모드
	if (text == NULL)
	{
		puts("파일오픈 실패!"); //puts:문자열만 출력(속도향상)
		return-1; //에러메세지를 반환		
	}
	int num;
	while ((num = fgetc(text)) != EOF) //text파일의 숫자들을 배열에 집어넣기 //fgetc:스트림의 FILE객체에 대한 포인터 //EOF:EndOfFile 파일의끝까지 읽어들임
	{
		for (int v = 0; v < 920; v++) //920행까지 반복
		{
			for (int h = 0; h < 7; h++) //7열까지 반복
			{
				fscanf(text, "%d", &num); //text파일에서 변수 단위로 입력받음, 변수 간의 구분은 공백,탭,개행 문자로 함
				lotto[v][h] = num; //text파일에서 받은 회차, 당첨번호를 입력				
			}			
		}
	}
	fclose(text); // int fflush(FILE* restrict stream); 버퍼비우기

	//<조건1. 랜덤함수로 뽑힌 [번호들의 총합]의 범위를 지정, 평균값에 가까울수록 유사성이 높다고 판단>
	int n; //920회 이전의 최근 당첨회차
	int max = 0; //최근n회분의 각 회차의[번호들의 총합]으로 최대값
	int min = 256; //최근n회분의 각 회차의[번호들의 총합]으로 최소값 (당첨번호가45~40일 경우를 위해 설정)
	float avg; //최근n회분의 각 회차의[번호들의 총합]으로 평균값
	int tmp_sum = 0; //max,min,avg값 도출을 위한 각 회차의[번호들의 총합]
	float avg_sum = 0; //avg값 도출을 위한 임시값
	int result_index = 0;
	int result_n[24] = { 0, };
	int result_max[24] = { 0, };
	int result_min[24] = { 0, };
	int result_avg[24] = { 0, };
	for (n = 5; n < 121; n += 5) //최근 몇회분까지 사용할지 설정
	{
		for (int v = 0; v < n; v++) //lotto[][]배열에서 최근n회차분까지 순차적으로 행바꿈
		{
			for (int h = 0; h < 6; h++) //lotto[][]배열에서 최근n회차분까지 순차적으로 열바꿈
			{
				tmp_sum += lotto[919 - 1 - v][h + 1]; //h+1:lotto[][0]==회차정보(열)이기 때문
			}
			if (tmp_sum > max) //최대값갱신
			{
				max = tmp_sum;
			}
			if (tmp_sum < min) //최소값갱신
			{
				min = tmp_sum;
			}
			avg_sum += tmp_sum; //최근n회차분의 [번호들의 총합]으로 평균값을 위해 누적
			tmp_sum = 0; //다음 최대값, 최소값을 갱신하기 위해 초기화
		}
		avg = avg_sum / n; //최근n회차분의 [번호들의 총합]으로 평균값
		result_n[result_index] = n;
		result_max[result_index] = max;
		result_min[result_index] = min;
		result_avg[result_index] = avg;
		result_index++; //최근n회차,max,min,avg값을 저장하고 다음값을 입력하기 위해 index상승
		avg_sum = 0; //다음 최근n회차분의 [번호들의 총합]으로 평균값을 구하기 위해 초기화
		max = 0; //다음 최근n회차분의 [번호들의 총합]으로 최대값을 구하기 위해 초기화
		min = 256; //다음 최근n회차분의 [번호들의 총합]으로 최소값을 구하기 위해 초기화
	}

	//<조건2. 랜덤함수로 뽑힌 번호들과 최근 당첨회차의 번호가 [일치하는 갯수]의 연관성>
	int same_n[4] = {0,1,2,3}; //일치하는 갯수
	int same[8][46] = { 0, }; //사용된 최근회차범위와 뽑힌 번호 (same[same_v][same_h]={최근회차범위,일치하는갯수 누적량,...})
	int same_v = 0;
	for (n = 5; n < 41; n += 5) //최근 n회분까지 사용할지 설정
	{
		same[same_v][0] = n; //same[1~8][0] 회차범위 지정
		for (int v = 0; v < n; v++)
		{
			for (int h = 0; h < 6; h++)
			{
				num = lotto[919 - 1 - v][h + 1];
				for (int same_h = 0; same_h < 45; same_h++)
				{
					if (same[same_v][same_h + 1] == num) //최근919회차부터의 당첨번호를 한개씩 same[][]와 중첩확인
					{
						break; //중첩일시 다음 당첨번호 lotto[][]행바꿈
					}
				}
				same[same_v][num] = num; //중첩이 아닐 시 same[][] = {최근n회범위,1~45중 일치한 숫자위치에 표시}
			}
		}
		same_v++; //최근n회범위의 변경
	}

	//<조건3. 특정범위구간의 당첨번호중 n개의 홀수가 나온 갯수의 비율을 적용>
	const int hol_n[7] = { 0, 1, 2, 3, 4, 5, 6 }; //홀수가 나올 수 있는 경우의 수
	int hol_rec[30][8] = { 0, }; //최근n회범위, n개의 홀수가 나온갯수 (hol_rec[range_index][]={range,홀수가 나온 수의 누적량,...})
	int range; //최근n회범위
	int range_index = 0;
	for (range = 10; range < 301; range += 10) //최근 몇회분까지 사용할지 설정
	{
		hol_rec[range_index][0] = range; //hol_rec[][]에 범위정보 입력
		for (int v = 0; v < range; v++)
		{
			int cnt = 0; //lotto[][]에서 확인할 회차가 바뀔 시 초기화
			for (int h = 0; h < 6; h++)
			{
				num = lotto[919 - 1 - v][h + 1]; //불러들임
				if (num % 2 == 1) 
				{
					cnt++; //홀수일 경우 표식
				}
			}
			hol_rec[range_index][cnt + 1]++; //lotto[][]의 회차에 n개의 홀수가 나온 갯수를 누적
		}
		range_index++; //최근n회범위 변경
	}	
	int prob_rec[30][8] = { 0, }; //porb 최근n회범위, n개의 홀수가 나온확률 hol_rec[30][8]
	range_index = 0;
	for (range = 10; range < 301; range += 10) //prob_rec[0~29][0]회차범위 입력
	{
		prob_rec[range_index][0] = range;
		range_index++;
	}	
	for (int v = 0; v < 30; v++) //prob_rec[0~29][1~7]n개의 홀수가 뽑힌 횟수를 확률로 대입
	{
		for (int h = 0; h < 7; h++)
		{
			prob_rec[v][h + 1] = hol_rec[v][h + 1] * 100 * 10 / prob_rec[v][0];
		}
	}

	//<조건값을 출력하기> text파일에 내용 입력하기
	FILE* output_text = fopen("E:\\7_c\\example\\example\\req.txt", "wt"); //FILE* fopen(const char* filename, const char* mode); //파일 참조하기 rt:읽기모드
	if (output_text == NULL)
	{
		puts("파일오픈 실패!"); //puts:문자열만 출력(속도향상)
		return-1; //에러메세지를 반환		
	}

	//조건1의 결과값들 출력[근접회차범위, 평균, 최대값, 최소값]
	fprintf(output_text, "조건1의 결과값들 출력[근접회차범위, 평균, 최대값, 최소값]\n");
	fprintf(output_text, "근접회차범위 avg max min\n");
	for (result_index = 0; result_index < 24; result_index++)
	{
		fprintf(output_text,"%d %d %d %d\n", result_n[result_index], result_avg[result_index], result_max[result_index], result_min[result_index]);
	}

	//조건2의 결과값들 출력[근접회차범위, 뽑힌 번호, 일치하는 수의 갯수]
	fprintf(output_text, "\n조건2의 결과값들 출력[근접회차범위, 뽑힌 번호, 일치하는 수의 갯수]\n");
	fprintf(output_text, "일치하는 수의 갯수 ");
	for (int i = 0; i < 4; i++)
	{
		fprintf(output_text,"%d ", same_n[i]);
	}
	fprintf(output_text, "\n근접회차범위 나온 번호\n");
	for (int v = 0; v < 8; v++)
	{
		for (int h = 0; h < 46; h++)
		{
			fprintf(output_text, "%d ", same[v][h]);
		}
		fprintf(output_text, "\n");
	}

	//조건3의 결과값들 출력[홀수가 나올 수 있는 경우의 수, 근접회차범위, n개의 홀수가 나온 확률*10:소수점버림]
	fprintf(output_text, "\n조건3의 결과값들 출력[홀수가 나올 수 있는 경우의 수, 근접회차범위, n개의 홀수가 나온 확률*10:소수점버림]\n");
	fprintf(output_text, "홀수가 나올 수 있는 경우의 수 ");
	for (int h = 0; h < 7; h++)
	{
		fprintf(output_text, "%d ", hol_n[h]);
	}
	fprintf(output_text, "\n근접회차범위 (n개의 홀수가 나온 확률*10:소수점버림)\n");
	for (int v = 0; v < 30; v++)
	{
		for (int h = 0; h < 8; h++)
		{
			fprintf(output_text, "%d ", prob_rec[v][h]);
		}
		fprintf(output_text, "\n");
	}

	fclose(output_text); // int fflush(FILE* restrict stream); 버퍼비우기
}