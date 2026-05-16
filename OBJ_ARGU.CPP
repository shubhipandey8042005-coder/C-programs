//program to show the concept of object as a function arguement
#include<iostream.h>
#include<conio.h>
class Demo
{
	int c;
	public:
	int a;
	void show()
	{
		cout<<"addition is:"<<c;
	}
	void add(Demo ob,Demo oc)
	{
	       //	ob.a=10;
	       //	oc.a=20;
		c=ob.a+oc.a;
	}
};
void main()
{
	clrscr();
       Demo d1,d2,d3;
      // d3.add(d1,d2);
	d1.a=10;
	d2.a=20;
	 d3.add(d1,d2);
	d3.show();
	getch();
}
