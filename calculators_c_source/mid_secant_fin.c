#include<stdio.h>
#include<conio.h>
#include<math.h>
#include<stdlib.h>

void test(){
	printf("Welcome to the Secant Method program to evaluate the roots of the given equation!\n\n");
}

void printfunc(){
	
	
	printf("\nyour function is:\n\nf= 0.95*x^3 - 5.9*x^2 + 10.9*x - 6\n");
	printf("\nactual roots are: 1.0268, 1.839 and 3.345\n\n");
	
}

float func(float x){

float R;
	R = 0.95*pow(x,3) - 5.9*pow(x,2) + 10.9*x - 6;
	return R;
}


float approx(float x0,float x1, float Error){
	
	float x;
	x = x1 - ((func(x1)*(x0 - x1))/(func(x0)-func(x1)));
	
	if (fabs((x - x1)/x)>=Error) {
		return approx(x1,x,Error);
	}
	else
	{
	return x;
	}
}
int main () {
	
	int i;		
	float x0,x1,root;
	test();
	
	float Error;
	

	printfunc();	
	
	printf("\nenter the Error : \n");
	scanf("%f",&Error);
	
	printf("\nenter the first two approximations : \n");
	scanf("%f",&x0);
	scanf("%f",&x1);
	
	root = approx(x0,x1,Error);

	printf("\nthe approximated root is  %f  ",root);
	
getch();	
return 0;	
}
