//working with file2
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	clrscr();
	ofstream outf("Item.txt");
	cout<<"enter item name:";
	char name[30];
	cin>>name;

	outf<<name<<endl;

	cout<<"enter item cost:";
	float cost;
	cin>>cost;

	outf<<cost<<endl;

	outf.close();

	getch();
}
