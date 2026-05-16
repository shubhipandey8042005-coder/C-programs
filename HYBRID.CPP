#include<iostream.h>
#include<conio.h>
class A
{
	public:
	void msg()
	{
		cout<<"method a"<<endl;
	}
};
class B:virtual public A
{
	public:
	void display()
	{
		cout<<"class b"<<endl;
	}

};
class C:public virtual A
{
	public:
	void output()
	{
		cout<<"class c"<<endl;
	}
};
class D:public B,public C
{
	public:
	void show()
	{
		cout<<"class d"<<endl;
	}
};
void main()
{
	clrscr();
	D ob;
	ob.show();
	ob.output();
	ob.display();
	ob.msg();     //ambiguity errors can solve by virtual class use
	getch();
}