// Program To Show Concept Of Operator Overloading Of Binary Operator +.

#include<iostream.h>
#include<conio.h>
class BinaryOp
{
	public:
		int a;
		BinaryOp operator +(BinaryOp ob)
		{
			BinaryOp om;
			om.a = a + ob.a;
			return om;
		}
		void show()
		{
			cout<<"Value Of A = "<<a<<endl;
		}
};
void main()
{
	clrscr();
	BinaryOp ob1,ob2,ob3;
	ob1.a = 20;
	ob2.a = 30;
	ob1.show();
	ob2.show();
	ob3 = ob1 + ob2;
	ob3.show();
	getch();
}

