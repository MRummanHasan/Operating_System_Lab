#include<sys/types.h>
#include<sys/ipc.h>
#include<sys/shm.h>
#include<stdio.h>
#include<stdlib.h>

#define MAXSIZE 27

void die(char *str) 
{
	perror(str);
	exit(1);
}

int main(void)
{
	int shmid;
	key_t key;
	char *shm, *s;
	int n, i;
	i = 1;

	key = 9999;
	
	if((shmid = shmget(key, MAXSIZE, IPC_CREAT | 0666)) < 0){
		printf("\n Failed on first if\n");
		die("shmget");
	}
		
	if((shm = shmat(shmid, NULL, 0)) == (char*) -1){
		printf("\n Failed on second if\n");
		die("shmat");
	}
	
	s = shm;
	
	n = atoi(s);
	
	printf("\nRead value %d \n", n);
	
	strncpy(s, "ready\0", 6);
	
	while(i <= 10)
	{
		if(*s == '*'){
			sprintf(s,"%d", ((i)*n));
			i++;
		}
	}
	shmdt(shm);
}
