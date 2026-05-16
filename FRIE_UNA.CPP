// To Show Concept Of Operator Overloading Of Unary Operator ++ using friend function

#include<iostream.h>
#include<conio.h>
class Op_Over
{
	public:
		int a;
		friend void operator ++(Op_Over &ob);
};
void operator ++(Op_Over &ob)
{
	++ ob.a;
}
void main()
{
	clrscr();
	Op_Over ob;
	ob.a= 10;
	cout<<"Value Of A = "<<ob.a;
	++ob;
	cout<<"\nValue Of A = "<<ob.a;
	getch();
}
