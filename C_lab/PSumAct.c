/* Includes */
#include <unistd.h>     /* Symbolic Constants */
#include <sys/types.h>  /* Primitive System Data Types */ 
#include <errno.h>      /* Errors */
#include <stdio.h>      /* Input/Output */
#include <stdlib.h>     /* General Utilities */
#include <pthread.h>    /* POSIX Threads */
#include <string.h>     /* String handling */
#include <semaphore.h>  /* Semaphore */

/* prototype for thread routine */
void handler (int *);

/* global vars */
/* 
 s *emaphores are declared global so they can be accessed 
 in main() and in thread routine, here, the semaphore is 
 used as a mutex 
 */

sem_t mutex;

int total_sum=0;//shared variable
int threadnum = 0;

int main() 
{
	unsigned int rnum[1000000];
	pthread_t thread[10];
	sem_init(&mutex, 0, 1);
	srand((unsigned)time(NULL));
	/*Initialize mutex to 1 and 2nd param zero means mutex is local*/
	/*Note: you can check for successful initialization by evaluating the return value of semaphore and pthreads*/
	
	//Initializing and creating threads
	for(int i=0; i<1000000; i++)
		rnum[i] = rand()%100;
	for(int t=0; t<10; t++){
		pthread_create(&thread[t], 0, (void *) &handler, &(rnum[(t*100000)]));
		pthread_join(thread[t],NULL);
	}
	sem_destroy(&mutex);
	printf("\n\nFinal Sum is %d\n\n", total_sum);
	return 0;
}

void handler (int *ptr) 
{
	int psum = 0;
	int t=++threadnum;
	
	for(int i=0; i<100000; i++)
		psum += ptr[i];
	printf("sem [INFO] Thread %d partial sum = %d \n", t, psum);
	
	printf("sem [INFO] Thread %d Waiting to enter in critical region. \n", t);
	sem_wait(&mutex); 
	//Critical Region Starts
	printf("sem [INFO] Thread %d Enters in Critical Region. \n", t);
	printf("sem [INFO] Thread %d Value of total_sum is %d.\n",t,total_sum);
	printf("sem [INFO] Thread %d Increamenting The Value of total_sum\n",t);
	total_sum+=psum;
	printf("sem [INFO] Thread %d New value of total_sum is: %d\n",t, total_sum);
	printf("sem [INFO] Thread %d Exiting Critical Region.\n", t);
	//Critical Region Ends
	sem_post(&mutex);
	pthread_exit(0);
}
