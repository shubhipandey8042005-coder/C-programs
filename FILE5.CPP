//file handling
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	char name[30];
	float per;
	clrscr();

	ifstream inf;
	inf.open("Student_record.txt");

	inf>>name;
	inf>>per;

	cout<<"student name:"<<name<<endl;
	cout<<"student percentage"<<per<<endl;

	inf.close();
	getch();
}