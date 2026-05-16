// Program to Show Concept Of Write Function.

#include<iostream.h>
#include<conio.h>
#include<string.h>
//#include<iomanip.h>
void main()
{
	char name[20];
	clrscr();
	cout<<"Enter Your Name : ";
//	cin>>name;
//	cout<<"\n"<<name;
	cin.getline(name,10);
//	cout.write(name,20);
	cout<<"\n"<<name;
	cout<<"\n\nLength = "<<strlen(name);
	getch();
}