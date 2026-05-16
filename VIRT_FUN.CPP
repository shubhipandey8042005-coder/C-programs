//program to show the concept of POINTERS TO DERIVED CLASS(VIRTUAL)
#include<iostream.h>
#include<conio.h>
class Base
{
	public:
	virtual void show()
	{
		cout<<"Base class:";

	}
};
class Derived:public Base
{
	public:
	void msg()
	{
		cout<<"derived class"<<endl;
	}
	void show()
	{
		cout<<"show method in derived class:";

	}
};
void main()
{
	clrscr();
	Base *b;
	Base ob;
	ob.show();


	b=&ob;
	b->show();


	Derived od;
	b=&od;
	b->show();
       // b->msg();
	getch();
}