//
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	int marks[3]={45,48,49};
	fstream f;
	clrscr();
	f.open("result.txt",ios::out);
	f.write((char *)&marks, sizeof(marks));
	f.close();
	getch();
}