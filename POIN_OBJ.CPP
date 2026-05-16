//program to show the concept of POINTER TO OBJECT
#include<iostream.h>
#include<conio.h>
class PointerObject
{
	int c;
	public:
	void add(int a,int b)
	{
		c=a+b;
		cout<<"Addition is:"<<c;
	}
};
main()
{
	clrscr();

	PointerObject *p;

	PointerObject ob;


	p=&ob;

       //	p->add(5,10);
	(*p).add(10,20);
	getch();
}
