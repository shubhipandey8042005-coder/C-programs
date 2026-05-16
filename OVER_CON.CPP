//program of constructor overloading
#include<iostream.h>
#include<conio.h>
class Construct
{
	public:
	int x;
	Construct()
	{
		x=10;
	}
	Construct(int a,int b)
	{
		x=a+b;
	}
	void display()
	{
		cout<<x<<endl;
	}
};
void main()
{
	clrscr();
	Construct ob;
	Construct ob2(5,10);
	ob.display();
	ob2.display();
	getch();
}