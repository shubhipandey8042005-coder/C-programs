//Program To Show A Concept Of Destructors In Classes.

#include<iostream.h>
#include<conio.h>
class A
{
	public:
	A()
	{
		cout<<"Welcome in A"<<endl;
	}
	~A()
	{
		cout<<"Destructor"<<endl;
	}
};
class B : public A
{
	public:
	B()
	{
		cout<<"Welcome in B"<<endl;
	}
	~B()
	{
		cout<<"Destructor"<<endl;
	}
};
void main()
{
	clrscr();
	B ob;
	getch();
}