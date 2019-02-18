#include <stdio.h>
#include <stdlib.h>

void main()
{
	/*
	char name[20];
	int i;
	
	printf("Enter Name: ");
	scanf("%s", name);
	printf("\nEnter Age :");
	scanf("%d", &i);
	printf("\nYour Name: %s and Age : %d ", name,i);
	printf("\n");
	*/
	
	char name[20];
	// auto garbage collection
	fgets(name,20,stdin); //var,var_length,standard input
	
	//gets(name);
	printf("Hello world, %s \n", name);
	
	printf("Age : ");
	int i;
	scanf("%d", &i);
	printf("\nYou entered Age :%d",i);
	
}