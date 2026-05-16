/*  Program to Show Concept of Friend Function.

NOTE : A FRIEND FUNCTION CAN ACCESS PRIVATE DATA OF CLASS WITH HELP OF OBJECT
       BUT A NON MEMBER FUNCTION CAN ONLY ACCESS PUBLIC DATA
*/

#include<iostream.h>
#include<conio.h>
void msg(); 	// NONMEMBER FUNCTION
class FriendDemo
{
	private:
		int a;	// DATA MEMBER
		void show()  // MEMBER FUNCTION
		{
		      a=10;
		      cout<<"Value Of A In Private Function : "<<a;
		}
	public:
		void display();		// MEMBER FUNCTION
		friend void BCA(); //ONLY Declaration in Class and Not Body
};
void FriendDemo :: display()
{
	show();
}
void BCA() //Non Member Function
{
//	display();	ERROR : Function should have a Prototype
	FriendDemo ob;
	ob.show();
}
void main()
{
	clrscr();
//	FriendDemo ob;
//	ob.display();
//	msg();
	BCA();
	getch();
}
void msg()
{
//      show();        ERROR : Function should have a Prototype
//	display();     ERROR : Function should have a Prototype
//	FriendDemo ob;	// Creating Object of Class in Non Member Function
//	ob.show();     ERROR : FriendDemo :: show() not Accesible
//	ob.display();
	cout<<endl<<"Non Member Function ";
}