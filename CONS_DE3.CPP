#include<iostream.h>
#include<conio.h>
class A
{
	public:
	A(int a)
	{
		cout<<a<<endl;
	}
};
class B
{
	public:
	B()
	{
		cout<<"class b"<<endl;
	}

};
class C:public B,public A
{
	public:
	C():A(10)
	{
		cout<<"class c"<<endl;
	}
};
void main()
{
	clrscr();
	C ob;
	getch();
}