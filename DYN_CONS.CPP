//program of dynamic constructor
#include<iostream.h>
#include<conio.h>
class dynamic
{

	char *p;
	public:

	dynamic()
	{
	p=new char[20];
	p="deepanjali";
	}
	void show()
	{
		cout<<"value of p is:"<<p;
	}
};
void main()
{
	clrscr();
	dynamic ob;
	ob.show();
	getch();
}
