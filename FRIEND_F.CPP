//program to show the concept of friend function
#include<iostream.h>
#include<conio.h>
class frienddemo
{

	public:
	void msg();
	friend void display();

};
void frienddemo::msg()
{
	cout<<"not a friend function"<<endl;
}
void display()
{

	cout<<"friend function";


}
void main()
{
	clrscr();
	frienddemo d;
	d.msg();
	display();
	getch();
}