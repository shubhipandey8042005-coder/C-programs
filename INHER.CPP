//program to show the concept of inheritance
#include<iostream.h>
#include<conio.h>
class A
{
	void show()
	{
		cout<<"private"<<endl;
	}
	public:
	void msg()
	{
		cout<<"public"<<endl;
	}
};
class B:public A
{
		void disp()
	{
		cout<<"private"<<endl;
	}
	public:
	void fun()
	{
		cout<<"public"<<endl;
	}


};
class C: private A
{
		void input()
	{
		cout<<"private"<<endl;
	}
	public:
	void funs()
	{
		cout<<"public"<<endl;
	}
};
void main()
{
	clrscr();
	A ob;
	B oc;
	C om;
	ob.msg();
	oc.fun();
	om.funs();
	getch();
}