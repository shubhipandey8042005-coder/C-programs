//end of file detection pointer offset calls
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	fstream file;
	clrscr();
	file.open("cpp.txt",ios::app);
	file<<"example java c++ python";
	file.close();
	getch();
}