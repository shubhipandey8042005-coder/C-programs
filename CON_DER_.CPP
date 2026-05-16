#include<iostream.h>
#include<conio.h>
class A
{
	public:
	A(int a)
	{
		cout<<"method a"<<endl;
	}
};
class B:public A
{
	public:
       B()
	{
		cout<<"class b"<<endl;
	}

};
class C:public B
{
	public:
	C()
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