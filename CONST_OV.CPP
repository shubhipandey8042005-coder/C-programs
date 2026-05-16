//Program to show the Concept of Constructor Overloading OR Multiple Constructors.

#include<iostream.h>
#include<conio.h>
class MCA
{
	public:
		MCA()	// Default Constructor
		{
			cout<<"Default Constructor"<<endl;
		}
		MCA(int a)	// Parameterized Constructor
		{
			cout<<"Value of A = "<<a;
		}
		MCA(int x,int y)	// Parameterized Constructor
		{
			cout<<"\nValue of X = "<<x;
			cout<<"\nValue of Y = "<<y;

		}
};
void main()
{
	clrscr();
	MCA ob;
	MCA oc(10);
	MCA od = MCA(20,50);
	getch();
}