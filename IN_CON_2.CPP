//Program To Show A Concept Of Parameterized Constructor In Child Classe.

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
	B(int a)
	{
		cout<<"Welcome in B";
		cout<<"\nValue Of A = "<<a;
	}
};
void main()
{
	clrscr();
	B ob(20);
	getch();
}