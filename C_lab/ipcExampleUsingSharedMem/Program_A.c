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
	
	*s = '6';
	s[1] = '\0';
	
	printf("\nWrote value %s \n", s);
	
	while(strcmp(s, "ready") != 0);
	
	while(*s != '*'){
			printf("\n%s\n", s);
			*s = '*';
			sleep(1);
	}
	shmdt(shm);
}
