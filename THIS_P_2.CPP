// Program To Show Concept Of this Pointer To Object(Complex Program).

#include<iostream.h>
#include<conio.h>
class ThisDemo
{
	public:
		int age;
		ThisDemo & max (ThisDemo &ob)
		{
			if(age > ob.age)
			{
				return *this;
			}
			else
			{
				return ob;
			}
		}
		void show()
		{
			cout<<"\nMaximum Age : "<<age;
		}
};
void main()
{
	clrscr();
	ThisDemo A,B,C;
	A.age = 20;
	B.age = 25;

//	C =A.max(B);

	A.show();
	B.show();
	C.show();
	getch();
}