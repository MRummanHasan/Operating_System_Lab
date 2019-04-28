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
	char c;
	int shmid;
	key_t key; // security key for shared mem
	char *shm, *s;

	key = 2211;
	
	if((shmid = shmget(key, MAXSIZE, IPC_CREAT | 0666)) < 0)
		die("shmget");
	if((shm = shmat(shmid, NULL, 0)) == (char*) -1)
		die("shmat");
	s = shm;
	
	// flushing memory
	for(int i = 0; i < MAXSIZE; i++) 
	{
		s[i] = 0;
		printf("%c", s[i]);
	}
	
	
	// writing on shared memory(msg board)
	char hw[11] = "Hello Board";
	for(int i = 0; i < 11; i++) 
	{
		s[i]=hw[i];
		printf("%c\n", s[i]);
	}

// writing on shared memory(msg board)	
//	for(c = 'a'; c <= 'd'; c++) 
//	{
//		*s++ = c;
//		printf("%c\n", c);
//	}
		
	while(*shm != '*')
		sleep(1);
	*shm='*';
		

	printf("\n%s",shm);
	exit(0);
}

