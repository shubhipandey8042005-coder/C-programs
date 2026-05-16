//
#include<iostream.h>
#include<conio.h>
class A
{
	int a,b,c;
	public:
	void show()
	{
		a=10;
		b=20;
		c=a+b;
		cout<<"addition is :"<<c<<endl;
	}
};
class B:public A
{
	int a,b,c;
	public:
	void display()
	{
		a=10;
		b=20;
		c=a-b;
		cout<<"subtraction is :"<<c;
	}
};
void main()
{
	clrscr();
	A ob;
	B oc;
	ob.show();
	oc.display();
	getch();
}