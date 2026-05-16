// Program To Show A Concept Of Constructor In Drived Class.
#include<iostream.h>
#include<conio.h>
class A
{
	public:
	A(int a)
	{
		cout<<"Welcome in class A"<<endl;
		cout<<"Value of A="<<a<<endl;
	}
};
class B: public A
{
       public:
       B(int x): A(20)
	{
		cout<<"Welcome in class B"<<endl;
		cout<<"Value of X="<<x<<endl;

	}
};
class C :public B
{
	public:
	C(): B(40)
	{
		cout<<"Welcome in class C"<<endl;

	}
};
void main()
{
	clrscr();
       //	A ob;
       //	B oc(10);
	C om;
	getch();
}