#include<stdio.h>
#include<stdlib.h>
#include<math.h>
float func(float x,int n, float F[n]){
	float y=0;
	int i,power;
	
	for (i=0;i<n;i++){
		power = (n-1)-i;
		y=y+F[i]*(pow(x,power));  
	}
	
	//printf("\n");
	return y;
}
int IsPositive(float b){
	if(b>0){
		return 1;
	}
	else{
		return 0;
	}
}
float MullersMethod(float g0,float g1, float g2, int n, float F[n] ){
	
	float h0,h1;
	float d0,d1;
	float a,b,c;
	float g3;
	float Dis;
	float Error;
	h0 = g1 - g0;
	h1 = g2-g1;
	d0 = (func(g1,n,F) - func(g0,n,F))/(g1-g0);
	d1 = (func(g2,n,F) - func(g1,n,F))/(g2-g1);
	a = (d1-d0)/(h1+h0);
	b = a*h1 + d1;
	c = func(g2,n,F);
	printf("a = %f  b = %f  c = %f  \n",a,b,c);
	Dis = sqrt(b*b - 4*a*c);
	if(IsPositive(Dis)==0){
		printf("No real roots!\n");
	}
	else{
	
	printf("Dis = %f\n",Dis);
	if(fabs(b+Dis)<fabs(b+Dis)){
	g3 = g2 + ((-2)*c)/(b-Dis);	
	}
	else {
			g3 = g2 + ((-2)*c)/(b+Dis);
	}
	
	Error = fabs((g3-g2)/g3);
	if(Error > 0.001){
		printf("temp guess 3 = %f\n\n",g3);
		return MullersMethod(g1,g2,g3,n,F);
	}
	else{
		//printf("\nx0 = %f  x1 = %f  x2 = %f  \n",g1,g2,g3);
		return g3;
	}}
		
}

printar(int n,float F[n]){
	int i;
	for ( i=0;i<n;i++){
		
		printf("%f",F[i]);
	}
	printf("\n");
}
void test(){
	printf("Welcome to the Muller's method program!\n\ntested inputs:\n\nx^3 - 13x - 12\nx0 = 4.5; x1 = 5.5; x2 = 5\nroot is 4\n\n");
	
}
int main (){
	float ans;
	int n,i,degree;
	float g0,g1,g2;
	test();
	
	printf("enter the degree of polynomial:\n");
	scanf("%d",&degree);
	n=degree+1;
	
	float F[n];
	
	printf("enter the coefficients:\n");
	for ( i=0;i<n;i++){
		
		scanf("%f",&F[i]);
	}
	printf("\nyour function is: \n");
	for(i = 0; i< n;i++){
		if(i!=(n-1)){
		printf("%f * x^%d",F[i],(n-1-i));
		printf(" + ");
		}
		else{
			printf("%f",F[n-1]);
		}
	}
	
	
	printf("\nenter guesses x0,x1,x2: \n");
	scanf("%f%f%f",&g0,&g1,&g2);
	
	ans = MullersMethod(g0,g1,g2,n,F);
	
	printf("\nfinal guess:\n%f",ans);
	
	getch();
	return 0;
}
