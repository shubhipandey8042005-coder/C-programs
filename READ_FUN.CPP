//read function
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	int marks[3];
	fstream f;
	clrscr();
	f.open("result.txt",ios::in);
	f.read((char *)&marks, sizeof(marks));
	f.close();
	for(int i=0;i<3;i++)
	{
		cout<<"marks is:"<<marks[i]<<endl;
	}
	getch();
}