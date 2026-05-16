//program to show ,the concept of static MEMBER FUNCTION
#include<iostream.h>
#include<conio.h>
class Demo
{
	public:
       int a;
	static int b;
	static void show()
	{
	 //      	cout<<a<<endl;
		cout<<b<<endl;
	}
};
int Demo::b;
void main()
{
	clrscr();
	Demo ob,oc,od;
	ob.a=10;
	oc.a=20;
	od.a=30;
	ob.b=50;
	Demo::show();
	getch();

}
