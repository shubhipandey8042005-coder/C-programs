//program to Find Factorial of a Number Using Recursion

#include<iostream.h>
#include<conio.h>
int fact(int n);
void main()
{
	clrscr();
	int num;
	cout<<"Enter a Number : ";
	cin>>num;
	cout<<"\nFactorial of "<<num<<" is "<<fact(num);
	getch();
}
int fact(int n)
{
	int f;
	if(n==1)
	{
		return 1;
	}
	else
	{
		f = n*fact(n-1);
	}
	return f;
}
