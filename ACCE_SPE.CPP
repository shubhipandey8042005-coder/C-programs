//program of access specifier
#include<iostream.h>
#include<conio.h>
class A
{
	private:
	int a;
	void msg()
	{
		a=10;
	}
       public:
       void display()
       {
		msg();
		cout<<"a is:"<<a<<endl;
		input();

       }
       protected:
       void input()
       {
		cout<<"c++"<<endl;
       }
};
class B:public A
{
	private:
	void add()

	{
		input();
	}
	public:
	void sub()
	{
		display();
		input();
	}
       protected:
       void mul()
       {
		add();
       }
};
void main()
{
	clrscr();
	B ob;
	ob.sub();
	getch();
}



