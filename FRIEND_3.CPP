
//Program to illustrate Friend Function with Object as a Function Argument.

#include<iostream.h>
#include<conio.h>
class FriendDemo
{
	int a;
	void show();
	friend void change(FriendDemo ob);
};
void FriendDemo :: show()
{
	cout<<"Private Function"<<endl;
}
void change(FriendDemo ob)
{
	ob.a = 10;
	ob.show();
	cout<<"Friend Function"<<endl;
	cout<<"Value of A = "<<ob.a<<endl;
}
int main()
{
	clrscr();
	FriendDemo ob;
	change(ob);
	getch();
	return 0;
}