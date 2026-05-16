// Program to show concept of Constructor with Scope Resolution Operator.

#include<iostream.h>
#include<conio.h>
class BCA
{
	int a;
	public:
		BCA();
};
BCA :: BCA()
{
	a = 20;
	cout<<"Value of A = "<<a;
}
void main()
{
	clrscr();
	BCA ob;
	getch();
}
