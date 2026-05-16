//Program To Show A Concept Of Parameterized Constructor In Parent Class.

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
	B() : A(10)
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