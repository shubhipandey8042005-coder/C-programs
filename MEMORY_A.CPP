/* Program to show concept of Memory Allocation of Object,Data Member and
   Member Function
*/

#include<iostream.h>
#include<conio.h>
class Memory
{
	public:
		int a,b;
		void show()
		{
			cout<<"Value of A = "<<a<<endl;
			cout<<"Value of B = "<<b<<endl;
		}

};
void main()
{
	clrscr();
	Memory ob,oc;
	cout<<"Result for Object ob "<<endl;
	ob.a=10;
	ob.b=20;
	ob.show();
	cout<<endl;
	cout<<"Result for Object oc "<<endl;
	oc.a=30;
	oc.b=60;
	oc.show();
	getch();
}

