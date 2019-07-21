#include <stdio.h>
#include <sys/types.h>
#include <unistd.h>

int main()
{

 int pid = fork();
 printf("Process ID: %d \n", pid);
 
return 0;
}
