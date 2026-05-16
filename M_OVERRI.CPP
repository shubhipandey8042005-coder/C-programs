/* Program To Show Concept Of Method Overriding(And Pointer Of Base Class)
*/

#include<iostream.h>
#include<conio.h>
class A
{
	public:
		virtual void show()
		{
			cout<<"Parent Class"<<endl;
		}
};
class B : public A
{
	public:
		void show()
		{
			cout<<"Child Class"<<endl;
		}
		void display()
		{
			cout<<"Welocome In Display() Function"<<endl;
		}
};
void main()
{
	clrscr();
	A oa,*p;
	B ob,*k;
	p = &ob;
	cout<<endl;
	p->show();
//	p->display();
//	ob.show();
	getch();
}


