#include<sys/types.h>
#include<sys/ipc.h>
#include<sys/shm.h>
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#define MAXSIZE 27

void die(char *str) 
{
	perror(str);
	exit(1);
}

void itos(int, char[]);

int main(void) 
{
	int sharememid;
	key_t key;
	char *shm, *s;

	char dest;
	char sourc;
	char msg;
	char inputcha;
	
	key = 2211;
	fflush(stdin);
	if((sharememid = shmget(key, MAXSIZE, IPC_CREAT | 0666)) < 0)
		die("shmget");
	if((shm = shmat(sharememid, NULL, 0)) == (char*) -1)
		die("shmat");
	
	for(s = shm; *s != '\0'; s++)
		putchar(*s); //print char

	char snum[10];
	itos(sharememid, snum); // convert int to string
	char *str = strcat( snum, "Connect"); // concat sharememid with 'Connect'
	printf(" %s ",snum);
	strcpy(shm, str); //dest, source

	scanf("%d",&dest);
	scanf("%d",&sourc);
	scanf("%d",&msg);
	
//	strcpy(s, dest);
//	strcpy(s, sourc);
//	strcpy(s, msg);

	strcpy(s, "Dest Source Message");
	printf("%d\n", s);
	
	scanf("%c",&inputcha);

//to quit client
	scanf("%c",&inputcha);
	while(inputcha != 'Q')
		*shm = 'Q';
		sleep(1);

	printf("\n");
	exit(0);
}

void itos(int n, char str[10])
{
	int temp = n;
	int digits = 0;
	//char str[10];
		
	while(temp!=0)
	{
		temp/=10;
		digits++;
	}
	
	int j = digits-1;
	
	while(n!=0)
	{
		str[j] = (char)n%10;
		n/=10;
		j--;
	}
	str[digits] = 0;
	
}
