//program to show the concept of copy constructor
#include<iostream.h>
#include<conio.h>
class BCA
{
	public:
	int a;
	BCA()
	{
		cout<<"copy constructor"<<endl;
	}
	BCA(BCA &oc)
	{
		oc.a=10;

	}
	void show()
	{
		cout<<"value of a is:"<<a<<endl;
	}




};
void main()
{
	clrscr();
	BCA om;
	om.a=10;
	BCA oc(om);
	om.show();
	oc.show();

	oc.a=20;
	om.show();
	oc.show();

	getch();
}