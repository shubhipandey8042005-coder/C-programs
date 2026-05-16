//Program to Constructor with Default Arguments

#include<iostream.h>
#include<conio.h>
class Demo
{
	public:
		Demo(int a=5,int b=20,int c=50)
		{
			cout<<"Value of A = "<<a<<endl;
			cout<<"Value of B = "<<b<<endl;
			cout<<"Value of C = "<<c<<endl;
		}
};
void main()
{
	clrscr();
	Demo ob;
	getch();
}

