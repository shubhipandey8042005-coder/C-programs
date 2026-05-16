#include<iostream.h>
#include<conio.h>
class A
{
	public:
	void show()
	{
		cout<<"welcome in class a";
	}
};
class B:public A
{
	public:
	void show(int a)
	{
		cout<<"welcome in class b";
	}
};
void main()
{
	clrscr();
	B ob;
	//ob.show();
	ob.show(20);
	getch();
}