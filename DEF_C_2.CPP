//Program to Constructor with Default Arguments and Default Constructor

#include<iostream.h>
#include<conio.h>
class Demo
{
	public:
		Demo()
		{
			cout<<"Welcome in Default Constructor"<<endl;
		}
		Demo(int a=5)
		{
			cout<<"Welcome in Parameterized Constructor"<<endl;
			cout<<"Value of A = "<<a<<endl;
		}
};
void main()
{
	clrscr();
//	Demo ob;    // Ambiguity between Demo :: Demo and Demo :: Demo(int)
	Demo ob(10);
	getch();
}
