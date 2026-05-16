//fstream file concept 1
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	clrscr();
	fstream file;
	file.open("xyz.txt",ios::app);
	file<<"Use of append mode";
	file.close();
	getch();
}


