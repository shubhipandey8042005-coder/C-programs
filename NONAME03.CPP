//Program To Show A Concept Of Parameterized Constructor In Classes.

#include<iostream.h>
#include<conio.h>
class A
{
	public:
	A(int x)
	{
		cout<<"Welcome in A"<<endl;
		cout<<"Value Of X = "<<x<<endl;
	}
};
class B : public A
{
	public:
	B(int y) : A(10)
	{
		cout<<"Welcome in B"<<endl;
		cout<<"Value Of Y = "<<y<<endl;
	}
};
void main()
{
	clrscr();
	B ob(20);
	getch();
}