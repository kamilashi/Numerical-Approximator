#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

void test(){
	printf("Welcome to the Inverse Matrix calculator!\n\ntested inputs:\n\n3 -0.1 -0.2\n0.1 7 -0.3\n0.3 -0.2 10\n\n");
	printf("the inverse is:\n\n0.33249 0.004944 0.006798\n-0.00518 0.142903 0.004183\n-0.01008 0.00271 0.09988\n\n");
}

void printline(int n, float X[]){
	int i;
	 printf("\n");
	for(i=0;i<n;i++)
	{ 
        	printf("   %f   ",X[i]);
	}
	 printf("\n");
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
void decompose(int n, int m, float A[n][m], float B[n][m], float Diag[n]){
	int i,j,d,z=0;
	for(i = 0; i < n; i++){
		for(j=0;j< m; j ++){
			B[i][j] = A[i][j];
			if(j==i){
				Diag[z] = A[i][j];
				z+=1;
			}
		}
	}
	z = 0;
	for (d=0;d<n;d++){
		for (j = 0; j<n; j++){
			for(i = d; i< n; i++){
				if(i>=j){
				
				B[i][j] = A[i][j]/Diag[j];
			    }
			    else{
			    	B[i][j] = 0;
				}
			}
		}
	}
	
}

float gauss(int n, int m, float A[n][m], float L[])
{ float B[n][m];
	int i=0,j=0,k=0,d=0,p,r,s;
	
	
	
	
 for (d=0;d<n;d++) {
 	
	 //pivot(d,n,m,A);
 	
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
	//print(n,m,A);
}
printf(" U = \n");
print(n,m,A);
}

void substL (int columnnumb, int n, float A[n][n], float Y[n] )
{ float S=0;
int m=n+1;
float Aext[n][m];
  
   int i,j,z;
   float B[n];
   
   for (i =0; i<n; i++){
   	for(j=0;j<m;j++){
   		if(j!=n)
		   {
   		Aext[i][j] = A[i][j]; 
   	        }
   	    else{
   	        	if(i==columnnumb){Aext[i][j] = 1;
				   }
   	        	else {
				   Aext[i][j] = 0; }
			   }
	   }
   }
   printf("Substitution into L = \n");
   print(n,m,Aext);
   
   for(i=0;i<n;i++){
   	
   	  Y[i] = (Aext[i][n] - S)/Aext[i][i];
   	  //printf("\nAext - S = %f\n",Y[i]);
   	  S=0;	
   	for(j=0;j<=i;j++)
	        {
   	 	
   	 	S+=Aext[i+1][j]*Y[j];
   	 	//printf("S = %f\n",S);
	    	}
	   
   }
  
   
}


void subst (int n, float A[n][n], float Y[n], float X[n] )
{ 
float S=0;
int m = n+1;
float Aext[n][m];
int i,j;
   
   for (i =0; i< n; i++){
   	for(j=0;j<m;j++){
   		if(j!=n)
		    {
   		Aext[i][j] = A[i][j]; 
   	        }
   	        else{
				   Aext[i][n] = Y[i]; 
				   }
	   }
   }
printf("Substitution into U = \n");
print(n,m,Aext);
   
   for(i=n-1;i>=0;i--){
   	
   	for(j=m-2;j>i;j--){
   	 	
   	 	S+=Aext[i][j]*X[j];
   	 	
		}
	   X[i] = (Aext[i][m-1] - S)/Aext[i][i];
	   
   	 S=0;
		
   }
   //printf("\nX = ");
   //printline(n,X);
   //printf("\n");
}

int main() {
int n,i,j,m;
    test();

	printf("enter the matrix dimension : \n");
	scanf("%d",&n);
	m = n;
	
	float A[n][m];
	float L0[n][m];
	float Inv[n][n];
	float L[m];
	float Y[n];
	float X[n];
	float Diag[n];

	
   printf("enter the elements a00, a01, ... : \n");
	for(i=0;i<n;i++)
	{ 
		for(j=0;j<m;j++)
		{
			
			scanf("%f",&A[i][j]);
       
		}
	}
	
	decompose(n,m,A,L0,Diag);
	printf("\n");
    print(n,m,A);
    printf("\n L = \n");
    print(n,m,L0);
	gauss(n,m,A,L);
	printf("\n");
	
	int columnnumb;
	
	for (i = 0; i< n; i++){
		columnnumb = i;
		
		substL(columnnumb, n,L0,Y);
		
		//printf("\n y = ");
		//printline(n,Y);
		//printf("\n");
		
		subst (n,A,Y,X);
		
		//printf("\n X = ");
		//printline(n,X);
		//printf("\n");
		
		for (j=0;j<n;j++){
			Inv[j][i] = X[j];
		}
		
	}
	printf("\nInverse Matrix =\n");
	print(n,m,Inv);
	
	
	
	getch();
	return 0;}
