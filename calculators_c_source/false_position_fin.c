#include<stdio.h>
#include<conio.h>
#include<math.h>
#include<stdlib.h>

void test(){
	printf("Welcome to the False Position Method program!\n\ntested inputs:\n\nx^3 - 13x - 12\nxl = -4; xr = -2\nroot is -3\n\n");
	
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
			printf("%f",A[n]);
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

float falsepos(float xl, float xr, int iter,int n, float A[]){
	while (iter<100)
	{
	
		float xm = xr - (func(xr,n,A)*(xl-xr))/(func(xl,n,A)-func(xr,n,A));
		iter++;
		if (func(xl,n,A)*func(xm,n,A)<0){
		  return falsepos (xl,xm,iter,n,A);
		}
		else if (func(xm,n,A)*func(xr,n,A)<0){
		  return falsepos (xm,xr,iter,n,A);
		}
		else {return xm;break;}
	}
	
}
int main () {
	
	float xl,xr;
	int n,i;
	
	test();
	
	int iter;
	float root;
	iter=0;
	
	printf("enter the degree : \n");
	scanf("%d",&n);
	
	
	int m = n+1;
	float A[m];
	
	
	
	printf("enter the coefficients a0, a1, ... , an: \n");
	for(i=0;i<m;i++)
		{
		 scanf("%f",&A[i]);
		}
	printf("\n",root);	
	
		
	printfunc(n,A);	
	
	printf("\nenter the xl : \n");
	scanf("%f",&xl);
	
	printf("\nenter the xr : \n");
	scanf("%f",&xr);
	
	root = falsepos(xl,xr,iter,n,A);

	printf("\nthe root is  %f  ",root);
	
getch();	
return 0;	
}
