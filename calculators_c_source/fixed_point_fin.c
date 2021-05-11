#include<stdio.h>
#include<conio.h>
#include<math.h>
#include<stdlib.h>

void test(){
	printf("Welcome to the Fixed-point Iteration Method program!\n\ntested inputs:\n\nx^3 - 13x - 12\nx0 = 0 \nroot is -1\n\n");
	
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


float approx(float x, int n, float A[], float Error){
	
	int i;
	float S=0,S1,ans;
	for (i=0;i<n-1;i++){
		S+=A[i]*pow(x,n-i);
		
	}
	S1 = A[n]*(-1) - S;
	ans = S1/(A[n-1]);
	
	if (fabs((ans - x)/ans)>=Error) {
		return approx(ans,n,A,Error);
	}
	else
	{
	return ans;
	}
}
int main () {
	
	int n,i;		
	float x0,root;
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
	
	printf("\nenter the first approximation : \n");
	scanf("%f",&x0);
	
	root = approx(x0,n,A,Error);

	printf("\nthe approximated root is  %f  ",root);
	
getch();	
return 0;	
}
