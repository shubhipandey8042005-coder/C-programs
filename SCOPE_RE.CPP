//Program to show concept of creating Member Function Body OUTSIDE the Class

#include<iostream.h>
#include<conio.h>
class BCA
{
	void display()
	{
		cout<<"Private Method Within the Class"<<endl;
	}
	public:
		void msg();
}ob;
void BCA :: msg()    //Use of Scope Resolution Operator(::) to Access Method
{
	display();
	cout<<"Public Member Function Outside of the Class";
}
void main()
{
	clrscr();
//	BCA ob;
//	ob.display(); 	CANNOT access Private Method outside of Class
	ob.msg();
	getch();
}
