#include<stdio.h>
#include<stdlib.h>
#include<time.h>

main()
{
	srand(time(NULL));

	char* room[15] = { "곽상우","허선용","노진우", "박상우", "서주형", "송진영", "이승원", "이은수", "강충만",
		"이상헌","김현우","임형욱","윤철희" , "최재혁" };
	char* win[3] = { "0", };

	printf("Enter를 눌러주세요.");
	for (int i = 2; i >= 0; i--)
	{
		getchar();
		win[i] = room[rand() % 15];

		if (i == 2)
			printf("%d등. %s", i + 1, win[i]);
		else
		{
			for (int j = 2; j > i; j--)
			{
				if (win[i] == win[j])
				{
					while (win[i] == win[j])
					{
						win[i] = room[rand() % 13];
					}
				}
			}
			printf("%d등. %s", i + 1, win[i]);
		}
	}

}

