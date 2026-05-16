// Program To Show Concept Of this Pointer To Object.

#include<iostream.h>
#include<conio.h>
class this_demo
{
	public:
		int a;
		void show(int a)
		{
//			a = a;      //  Prints 30
			a = a;
			cout<<"Value Of A = "<<this->a;//  Prints 20
		}
};
void main()
{
	clrscr();
	this_demo ob;
	ob.a = 20;
	ob.show(30);
	getch();
}