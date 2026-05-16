//fstream file concept 5
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	clrscr();
	fstream file;
	file.open("abc.txt",ios::out|ios::binary);
	file<<"deepanjali sharma";
	file.close();
	getch();
}


