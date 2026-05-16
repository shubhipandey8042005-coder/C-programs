//
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	fstream file;
	clrscr();
	file.open("cpp.txt",ios::out);
	file<<"object oritented language";
	file.close();
	getch();
}