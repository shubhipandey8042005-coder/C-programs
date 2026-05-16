// Program To Show Concept Of Pointer To Function.

#include<iostream.h>
#include<conio.h>
void (*FunPtr)();
void show();
void main()
{
	clrscr();
	FunPtr = &show;
	FunPtr();
	getch();
}
void show()
{
	cout<<"\nWelcome In Demonstration Of Funtion Pointer";
}
