// Program To Show Concept Of Write Method In File Fandling.

#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	int marks[5];

	fstream file;
	file.open("Result",ios::in);

	clrscr();
	file.read((char *) & marks , sizeof(marks));
	for(int i=0;i<=4;i++)
	{
		cout<<marks[i]<<"\n";
	}

	file.close();

	getch();
}