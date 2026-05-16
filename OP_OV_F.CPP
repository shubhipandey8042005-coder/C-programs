// Program To Show Concept Of Op Overloading Of Unary Operator ++(friend fun).

#include<iostream.h>
#include<conio.h>
class UnaryOp
{
	public:
		int a;
		friend void operator ++(UnaryOp &obj);
		void show()
		{
			cout<<"Value Of A = "<<a<<endl;
		}
};
void operator ++(UnaryOp &obj)
{
       obj.a++;
}
void main()
{
	clrscr();
	UnaryOp ob;
	ob.a = 10;
	ob.show();
	++ob;
	ob.show();
	getch();
}