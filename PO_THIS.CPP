//
#include<iostream.h>
#include<conio.h>
class BCA
{
	public:
	int a;
	void show(int a)
	{
		int c;
		c=this->a;
		cout<<"value of c is:"<<c;
	}
};
void main()
{
	clrscr();
	BCA ob;
	ob.a=10;
       //	ob1.a=20;
	getch();
}