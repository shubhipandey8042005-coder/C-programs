//program to show the concept of object returning
#include<iostream.h>
#include<conio.h>
class Demo
{
	public:
	int a;
	Demo display(Demo ob,Demo oc)
	{
		Demo om;
		om.a=ob.a+oc.a;
		return om;
	}
};
void main()
{
	clrscr();
	Demo d1,d2,d3,d4;
	d1.a=10;
	d2.a=20;
	d4=d3.display(d1,d2);
	cout<<d4.a;
	getch();
}
