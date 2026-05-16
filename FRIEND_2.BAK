//Program to illustrate Friend Function with Private Declaration.

#include<iostream.h>
#include<conio.h>
class FriendDemo
{
	int a;
	void show();
	friend void change();
};
void FriendDemo :: show()
{
	cout<<"not a friend Function"<<endl;
}
void change()
{
	FriendDemo ob;
	ob.a = 10;
	ob.show();
	cout<<"Friend Function"<<endl;
	cout<<"Value of A = "<<ob.a<<endl;
}
int main()
{
	clrscr();
	change();
	getch();
	return 0;
}