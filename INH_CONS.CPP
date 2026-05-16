//Program To Show A Concept Of Default Constructor In Classes.
#include<iostream.h>
#include<conio.h>
class A
{
	public:
	A()
	{
		cout<<"Welcome in A"<<endl;
	}
};
class B : public A
{
	public:
	B()
	{
		cout<<"Welcome in B";
	}
};
void main()
{
	clrscr();
	B ob;
	getch();
}