#include<stdio.h>
#include<conio.h>
#include<math.h>
#include<stdlib.h>

void test(){
	printf("Welcome to the Secant Method program!\n\n");
}

void printfunc(int n, float A[]){
	int i;
	
	printf("\nyour function is:\n\nf= ");
	for (i=n; i>=0; i-- ){
		if(i!=0){
		printf("%f * x^%d",A[n-i],i);
		printf(" + ");
		}
		else{
			printf("%f = 0",A[n]);
		}
	}
	printf("\n");
}

float func(float x, int n, float A[]){
int i;	
float R=0;
	for(i = n; i>=0; i-- )
	{
	   R+=pow(x,i)*A[n-i];
	}
	return R;
}


float approx(float x0,float x1, int n, float A[], float Error){
	
	float x;
	x = x1 - ((func(x1,n,A)*(x0 - x1))/(func(x0,n,A)-func(x1,n,A)));
	
	if (fabs((x - x1)/x)>=Error) {
		return approx(x1,x,n,A,Error);
	}
	else
	{
	return x;
	}
}
int main () {
	
	int n,i;		
	float x0,x1,root;
	test();
	
	printf("enter the degree : \n");
	scanf("%d",&n);
	
	
	int m = n+1;
	float A[m],Error;
	
	
	
	printf("enter the coefficients a0, a1, ... , an: \n");
	for(i=0;i<m;i++)
		{
		 scanf("%f",&A[i]);
		}
					
	printfunc(n,A);	
	
	printf("\nenter the Error : \n");
	scanf("%f",&Error);
	
	printf("\nenter the first two approximations : \n");
	scanf("%f",&x0);
	scanf("%f",&x1);
	
	root = approx(x0,x1,n,A,Error);

	printf("\nthe approximated root is  %f  ",root);
	
getch();	
return 0;	
}
