//   containership
#include<iostream.h>
#include<conio.h>
class BCA
{
	public:
	void msg()
	{
		cout<<"welcome in BCA class"<<endl;
	}
};
class MCA
{
	BCA ob;
	public:
	MCA()

	{
		ob.msg();
		cout<<"welcome in MCA class"<<endl;
	}
};
void main()
{
	clrscr();
	MCA oc;
       //	oc.show();
	getch();

}