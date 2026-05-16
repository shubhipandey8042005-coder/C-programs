 // Program To Show A Concept Of Dynamic Constructors.

#include<iostream.h>
#include<conio.h>
class BCA
{
	public:
		float r;
		float *area;
		BCA()
		{
			cout<<"Enter a Radius = ";
			cin>>r;
			area= new float;
			*area=3.14*r*r;
			cout<<"Area is = "<<*area;
		}
};
void main()
{
	clrscr();
	BCA ob;
	getch();
}