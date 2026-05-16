/*Program to show a concept of single inheritance with Public and
 Private Access Specifiers.*/
#include<iostream.h>
#include<conio.h>
class BCA
{
		int a;
		void show()
		{
			cout<<"Welcome in Show"<<endl;

		}
		public:
		int x;
		void msg()
		{
			a=10;
			cout<<"Value of A="<<a<<endl;
			show();
		}
};
class MCA:public BCA
{       private:
		void display()
		{
		       //	msg();
			cout<<"Welcome in Display"<<endl;
		}
		public:
			void output()
			{
				display();
				msg();
			}
};
void main()
{
	clrscr();
	MCA ob;
	ob.output();
	getch();
}

