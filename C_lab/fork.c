#include <stdio.h>
#include <sys/types.h>
#include <unistd.h>

int main()
{

	pid_t pid = fork();
	printf("Process ID: %d \n", pid);

	if(pid < 0)
	{
		printf("Unsuccessful child process creation.\n");
		exit(0);
	}
	else if(pid > 0)
	{
		wait();
		for(int i=0; i <= 10 ; i+=2)
			printf("%d\n", i);
		printf("Parent Ends.");
	}
	else
	{
		getpid();
		for(int i=1; i <= 10 ; i+=2)
			printf("%d\n", i);
		printf("Child Ends.");
	}

	return 0;
}
