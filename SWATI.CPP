#include<iostream.h>
#include<conio.h>
class A
{
	private:
		void One()
		{
			cout<<"Welcome in One";
		}

	public:
		void Two()
		{

			cout<<"Welcome in  Two";
		}
	protected:
		void Three()
		{
			cout<<"Welcome in Three";
		}
};

class B:public A
{
	private:
		void Four()
		{
			cout<<"Welcome in Four";
		}

	public:
		void Five()
		{

			cout<<"value of Five";
		}
	protected:
		void Six()
		{
			cout<<"Welcome in Six";
		}
};
class C
{
	private:
		void Seven()
		{
			cout<<"Welcome in Seven";
		}
	public:
		void Eight()
		{

			cout<<"Welcome in Eight";
		}
	protected:
		void Nine()
		{
			cout<<"Welcome in Nine";
		}
};
void main()
{
	clrscr();
	A a;
	a.Two();
	B b;
	C c;
	getch();
}



