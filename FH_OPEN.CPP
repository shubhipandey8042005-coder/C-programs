// Program To Show ConceptOf File Handling.

/*	Question : Creating A Msc.txt  File Using Open Method.

*/

#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	ofstream obf;

	clrscr();

	obf.open("MSc");
	obf<<"Master In Computer Science ";
	obf.close();

	getch();
}