// Program To Show Concept Of Operator Overloading Of Binary Operator +.

#include<iostream.h>
#include<conio.h>
class BinaryOp
{
	public:
		int a;
		friend BinaryOp operator +(BinaryOp ob,BinaryOp oc);
		void show()
		{
			cout<<"Value Of A = "<<a<<endl;
		}
};
BinaryOp operator +(BinaryOp ob,BinaryOp oc)
{
	BinaryOp om;
	om.a = ob.a + oc.a;
	return om;
}
void main()
{
	clrscr();
	BinaryOp ob1,ob2,ob3;
	ob1.a = 40;
	ob2.a = 60;
	ob1.show();
	ob2.show();
	ob3 = ob1 + ob2;
	ob3.show();
	getch();
}
