#include<stdio.h>
#include<conio.h>
#include<math.h>
#include<stdlib.h>

void test(){
	printf("Welcome to the Modified Secant Method program!\n");
	printf("\nTested inputs:\n\nf= 0.95*x^3 - 5.9*x^2 + 10.9*x - 6\n");
	printf("Actual roots are: 1.0268, 1.839 and 3.345\n\n\n");
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


float approx(float x0,float del, int n, float A[], float Error){
	
	float x;
	x = x0 - ((func(x0,n,A)*del*x0)/(func((x0+del*x0),n,A)-func(x0,n,A)));
	
	if (fabs((x - x0)/x)>=Error) {
		return approx(x,del,n,A,Error);
	}
	else
	{
	return x;
	}
}
int main () {
	
	int n,i;		
	float x0,del,root;
	test();
	
	printf("Enter the degree : \n");
	scanf("%d",&n);
	
	
	int m = n+1;
	float A[m],Error;
	
	
	
	printf("Enter the coefficients a0, a1, ... , an: \n");
	for(i=0;i<m;i++)
		{
		 scanf("%f",&A[i]);
		}
					
	printfunc(n,A);	
	
	printf("\nenter the Error : \n");
	scanf("%f",&Error);
	
	printf("\nenter the delta : \n");
	scanf("%f",&del);
	
	printf("\nenter the first approximation : \n");
	scanf("%f",&x0);
	
	root = approx(x0,del,n,A,Error);

	printf("\nthe approximated root is  %f  ",root);
	
getch();	
return 0;	
}
