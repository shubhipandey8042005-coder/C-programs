//Program To Show Concept Of File Handling.

/* Question : WAP To create A file Info.txt And Send Data Of One Student

*/

#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	ofstream obf("Info_2");

	int roll_no,i;
	char name[20];
	float pr_marks[3],t = 0;

	obf<<"Roll No. \t";
	obf<<"Name \t";
	obf<<"C++ \t";
	obf<<"Java \t";
	obf<<"Python \t";
	obf<<"Total \n";

	clrscr();

	cout<<"Enter Roll No. : ";
	cin>>roll_no;
	obf<<roll_no<<"\t";

	cout<<"Enter Your Name : ";
	cin>>name;
	obf<<name<<"\t";

	for(i=0;i<=2;i++)
	{
		cout<<"Enter Subject "<<(i+1)<<" Practical Marks : ";
		cin>>pr_marks[i];
		obf<<pr_marks[i]<<"\t";

		t = t + pr_marks[i];
	}

	cout<<"\nTotal Is "<<t;
	obf<<t;

	obf.close();
	getch();
}