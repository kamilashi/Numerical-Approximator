#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

void test(){
	printf("Welcome to the Naive Gauss Elimination program!\n\n");
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

float gauss(int n, int m, float A[n][m], float L[])
{ float B[n][m];
	int i=0,j=0,k=0,d=0,p,r,s;
	
 for (d=0;d<n;d++) {
 	
	 
 	
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


int main() {
int n,i,j,m;
    test();
	printf("enter the matrix dimension : \n");
	scanf("%d",&n);
	m = n;
	
	float A[n][m];
	float L[m];
	float X[m-1];
	
   printf("enter the elements a00, a01, ... : \n");
	for(i=0;i<n;i++)
	{ 
		for(j=0;j<m;j++)
		{
			
			scanf("%f",&A[i][j]);
       
		}
	}
	printf("\n");
	printf("\n");
    print(n,m,A);
    
	gauss(n,m,A,L);
	printf("\n");
	
	getch();
	return 0;}
