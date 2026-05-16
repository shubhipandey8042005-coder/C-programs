// Program To Show Concept Of Child Class Object Pointer.

#include<iostream.h>
#include<conio.h>
class A
{
	public:
		void show()
		{
			cout<<"Welocome In Show() Function"<<endl;
		}
};
class B : public A
{
	public:
		void display()
		{
			cout<<"Welocome In Display() Function"<<endl;
		}
};
void main()
{
	clrscr();
	A ob;
	B oc;
//	A *p;
//	p = &oc;
//	cout<<endl;
//	p->show();
	B *k;
	k = &oc;
	cout<<endl;
	k->show();
	k->display();
	getch();
}
