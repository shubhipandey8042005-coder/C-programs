// Show Concept Of Operator Overloading Of binary Operator using friend func
#include<iostream.h>
#include<conio.h>
class OpDemoBinary
{
	public:
		int a;
		friend OpDemoBinary operator +(OpDemoBinary ob,OpDemoBinary od);
		void show()
		{
			cout<<"value of a:"<<endl;
		}

};
OpDemoBinary operator + (OpDemoBinary ob,OpDemoBinary od)
{
	OpDemoBinary oc;
	oc.a=ob.a+od.a;

}
void main()
{
	clrscr();
	OpDemoBinary o1,o2,o3;
	o1.a= 10;
	o2.a=20;
	//cout<<"Value Of A = "<<o1.a;
	o3=o1+o2;
	o1.show();
	o2.show();
	o3.show();
       //	++ob;

       //	cout<<"\nValue Of A = "<<ob.a;
	getch();
}
