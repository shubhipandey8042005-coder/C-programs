// Program To Show Concept Of Write Method In File Fandling.

#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	int marks[5] = { 47,45,40,50,43};

	fstream file;
	file.open("Result",ios::out);

	file.write((char *) & marks , sizeof(marks));

	clrscr();

	file.close();

	getch();
}