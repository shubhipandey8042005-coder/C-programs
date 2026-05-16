/* Program to show concept of Memory Allocation of Object,Data Member and
   Member Function and Static Data Members
*/

#include<iostream.h>
#include<conio.h>
class Memory
{
	public:
		static int x;	// Also Called Class Variable
		int a,b;
		void show()
		{
			cout<<"Value of A = "<<a<<endl;
			cout<<"Value of B = "<<b<<endl;
			cout<<"Value of Static Variable X : "<<x<<endl;
		}

};
int Memory :: x;	//Compulsory to define scope of Static Variable.
void main()
{
	clrscr();
	Memory ob,oc;
	cout<<"Result for Object ob "<<endl;
	ob.a=10;
	ob.b=20;
	ob.x=50;
	ob.show();
	cout<<endl;
	cout<<"Result for Object oc "<<endl;
	oc.a=30;
	oc.b=60;
	oc.show();
	getch();
}

