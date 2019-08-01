#include <stdio.h>
#include <stdlib.h>

void main(){
int count = 0;
char s[6];
s[0]='a';
s[1]='b';
s[2]='a';
s[3]='a';
s[4]='a';
s[5]='c';
char inp;
//*s = "ABC";

// Print input array
/*for (int j=0; j<6; j++ )
{
 printf("%c\n",s[j]);
}*/
printf("INPUT ARRAY : %s\n",s);
//scanf("%d", &s[0]);
//printf("%c\n",s[0]);

printf("initial count: %i\n",count);
//printf("%c %c\n",s[0],s[1]);
//printf("%c\n",inp);


for(int i=0; i<6; i++)
{ 
 count=0;
 inp=s[i];
 for(int w=0;w<6;w++)
 {
   if(inp==s[w] && inp!=' ')
   {
    count++;
    s[w]=NULL;
//printf("IF VAL %d\n",i);
   }
 }
printf("count: %i of %c \n",count,inp);
}

printf("%c\n",inp);
printf("FINAL ARRAY: %s\n",s);
}
