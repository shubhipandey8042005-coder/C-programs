//program to show the concept of constructor and perimeterised constructor
#include<iostream.h>
#include<conio.h>
class Demo
{
	public:
	Demo()
	{
		cout<<"Constructor"<<endl;
	}
	Demo(int a,int b)
	{
		cout<<"Addition is:"<<(a+b);
	}

};
void main()
{
	clrscr();
	Demo ob;
	Demo od(10,20);
	getch();
}