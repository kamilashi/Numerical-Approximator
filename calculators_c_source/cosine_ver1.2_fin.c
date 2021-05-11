#include<stdio.h>
#include <conio.h>
#include<stdlib.h>
#include<math.h>
void test(){
	printf("Welcome to the Cosine Calculator via the Maclaurin Series Expansion !\n\n");
}

double cosSeries(float x){
	int i,j;
	double denom=1;
	double numer=1;
	int Max=100000;
	float Error=0.001;
	double cos=0,cos0=1,term;
	float o=-1;
	i=0;
	for (j=0;j<Max;j++)
	{
		
		//printf("cos0 = %f \n",(cos0));
		
		denom = denom*(i+1)*(i+2);
		i+=2;
		numer= numer*x*x;
		term = o*(numer)/(denom);
		cos=cos0 + (term);
		
		if(o==1){o=-1;
		}
		else if(o==-1){o=1;
		}
		
		//printf("term     = %f * %f / %f \n",o,numer,denom);
		//printf("cos = %f \n",(cos));
		
		
		
		
		if((fabs(fabs(cos)- fabs(cos0))/fabs(cos))<=Error)
		{    
		
		   
			return cos;
      	}		
		cos0 = cos;
    }
		
	return cos;	
}
int main(){
	float x;
	double c;
	//float x = 3.1415/3;
	//float x = 0;
	test();
	printf("enter x: \n");
	scanf("%f",&x);
	c = cosSeries(x);
	printf("cos (%f) = %lf\n",x,c);
	
	getch();
	return 0;
}
