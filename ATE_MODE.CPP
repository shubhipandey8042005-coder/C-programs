//end of file detection pointer offset calls
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	fstream file;
	clrscr();
	file.open("cpp.txt",ios::ate);
	file.seekp(23);
	file<<" c# ";
	file.close();
	getch();
}