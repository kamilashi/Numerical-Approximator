#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

void test(){
	printf("Welcome to the equation solver via Gauss Elimination with Pivoting!\n\n");
}

void print(int n, int m, float A[n][m]){
	int i,j;
	
	for(i=0;i<n;i++)
	{ 
		for(j=0;j<m;j++)
		{
			
			printf("   %f   ",A[i][j]);
       
		}	printf("\n");
	}
	printf("\n");
	printf("\n");
}
void pivot(int startrow, int n,int m, float A[n][m]){
	int k = startrow,h;
	int maxInd;
	float max,swap;
	max = A[k][k];
		maxInd=k;
		for(h=k;h<n;h++){
			if (A[h][k]>=max){
				max = A[h][k];
				maxInd = h;
			}
		}
		
 	    if (maxInd!=k){
 	    	for(h=0;h<m;h++)
 	    	{   swap = A[k][h];
 	    		A[k][h] = A[maxInd][h];
 	    		A[maxInd][h] = swap;
			 }
		 } 
		 printf("pivoting %d \n",k);
		 //printf("\nmax = %f , ind = %d\n\n",max,maxInd);
 	    print(n,m,A);
	
	
	
}
float gauss(int n, int m, float A[n][m], float L[])
{ float B[n][m];
	int i=0,j=0,k=0,d=0,p,r,s;
	
 for (d=0;d<n;d++) {
 	
	 pivot(d,n,m,A);
 	
	for(k=d;k<n;k++){
		
	 
 	
	    for (p=0; p<m; p++)
	{ 
		L[p]=A[k][p]/A[k][d];
		
		
		if(k==0) {
	             	B[0][p]=A[0][p];
				 }
    }
	    
	  for(j=0;j<m;j++)
	   	{ 
             B[k+1][j] = A[k+1][j] - L[j]*A[k+1][d];
		}
       	
}
for(r=0;r<n;r++)
	{ 
		for(s=0;s<m;s++)
		{
			
			A[r][s]=B[r][s];
       
		}	
	}
	print(n,m,A);
}

}

void printline(int n, float X[]){
	int i;
	for(i=0;i<n;i++)
	{ 
        	printf("   %f   ",X[i]);
	}
}
float subst (int n, int m, float A[n][m], float X[m-1] )
{ float S=0;
   int i,j;
   
   for(i=n-1;i>=0;i--){
   	
   	for(j=m-2;j>i;j--){
   	 	
   	 	S+=A[i][j]*X[j];
   	 	
		}
	   X[i] = (A[i][m-1] - S)/A[i][i];
	   
   	 S=0;
		
   }
	return 0;
}


int main() {
int n,i,j,m;
    test();
	printf("enter the number of unknowns : \n");
	scanf("%d",&n);
	m = n+1;
	
	float A[n][m];
	float L[m];
	float X[m-1];
	printf("enter the coefficients a00, a01, ... , b0n, ... : \n");
	for(i=0;i<n;i++)
	{ 
		for(j=0;j<m;j++)
		{
			//A[i][j] = (0 + rand()%11);
			scanf("%f",&A[i][j]);
			
       
		}
	}
	printf("\n");
	printf("\n");
    print(n,m,A);
    
	gauss(n,m,A,L);
	printf("\n");
	//print(n,m,A);
	
	subst(n,m,A,X);
	printf("the roots are:\n\n");
	printline(m-1,X);
	
	getch();
	return 0;}
