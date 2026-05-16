//end of file detection
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	fstream file;
	clrscr();
	char c[30];


	file.open("cpp.txt.",ios::in);
	//file<<"object oriented ";
       //	file>>c;
	//file.read((char *) &c,sizeof(c));
	file.seekg(15);           //if position given 1 then data from starting
	while(!file.eof())
	{
	file>>c;
	cout<<c<<endl;
	}
	file.close();
	getch();
}