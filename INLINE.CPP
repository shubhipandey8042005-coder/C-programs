//Program to show the concept of Inline Functions

#include<iostream.h>
#include<conio.h>
inline int cube(int n)
{
	return (n*n*n);
}
void main()
{
	clrscr();
	int x;
	cout<<"Enter A Value : ";
	cin>>x;
	cout<<"The Cube of "<<x<<" is "<<cube(x);
	getch();
}


