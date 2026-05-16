//program to show the concept of constructor
#include<iostream.h>
#include<conio.h>
class Demo
{
	public:
	Demo()
	{
		cout<<"Constructor";
	}

};
void main()
{
	clrscr();
	Demo ob;
	getch();
}