//program to show a concept of Multilevel inheritance.
#include<iostream.h>
#include<conio.h>
class BCA
{
	public:
	int a,b;
	BCA()
	{
		a=20;
		b=30;
		cout<<"Value of A="<<a<<endl;
		cout<<"Value of B="<<b<<endl;
	}
	void add()
	{       int c=a+b;
		cout<<"Addition is="<<c<<endl;
	}
	void sub()
	{       int c=a-b;
		cout<<"Subtraction is="<<c<<endl;
	}
};
class MCA:public BCA
{
	public:
	void msg()
	{       add();
		sub();
	}
};
class MSC:public MCA
{
	public:
	void sqr()
	{
		cout<<"Square is="<<a*a<<endl;
	}
	void display()
	{
		msg();
		sqr();
	}

};
void main()
{
	clrscr();
	MSC ob;
	ob.display();
	getch();
}