//
#include<iostream.h>
#include<conio.h>
class BCA
{
	public:
	int a;
	BCA()
	{
		a=20;
		cout<<"A ="<<a<<endl;
	}
	public:
	void show()
	{
		cout<<"Weclome in show "<<endl;
	}
};
class MCA:public BCA
{
	public:
	msg()
	{
		show();
	}
};
void main()
{
	clrscr();
	MCA ob;
	ob.show();
	getch();
}