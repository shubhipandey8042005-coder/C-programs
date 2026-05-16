//Program To Show Conept Of Inheritance

#include<iostream.h>
#include<conio.h>
class A
{
	public:
		void show()
		{
			cout<<"Welcome In Class A"<<endl;
		}
};
class B : public A
{
	public:
		void display()
		{
			show();
			cout<<"Welcome In Class B"<<endl;
		}
};
class C
{
	public:
		void Msg()
		{
			cout<<"Welcome In Class C"<<endl;
		}
};
void main()
{
	clrscr();
	B oc;
	oc.show();
	oc.display();
	C od;
	od.Msg();
	getch();
}