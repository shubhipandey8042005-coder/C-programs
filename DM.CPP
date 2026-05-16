// Program To Show Concept Of eof() method.

#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	fstream file;

	char data[100];

	file.open("DEMO",ios::out); //ios Is A Class That Provides Modes.
	file<<"Bachelor Of Computer Application";
	file.close();

	clrscr();

	file.open("DEMO",ios::in);

	while(!file.eof())
	{
		file>>data;
		cout<<data<<" ";

/*		if(file.eof())		Also Valid
		{
			break;
		}
*/
	}

	file.close();

/*	file.open("MEMO",ios::app);
	file<<"\nMaster Of Computer Application";
	file.close();
*/

	getch();

}