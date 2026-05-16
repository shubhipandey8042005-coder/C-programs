//Program To Show Concept Of File Handling.

/* Question : WAP To create A file Info.txt And Send Data Of One Student

*/

#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	ofstream obf("Info");
	int roll_no,i;
	char name[20];
	float pr_marks[3],t = 0;

	clrscr();

	cout<<"Enter Roll No. : ";
	cin>>roll_no;
	obf<<"Roll No = "<<roll_no<<"\n";

	cout<<"Enter Your Name : ";
	cin>>name;
	obf<<"Name = "<<name<<"\n";

	for(i=0;i<=2;i++)
	{
		cout<<"Enter Subject "<<(i+1)<<" Practical Marks : ";
		cin>>pr_marks[i];
		obf<<"Practical Marks Of Subject "<<(i+1)<<" = "<<pr_marks[i]<<"\n";

		t = t + pr_marks[i];
	}

	cout<<"\nTotal Is "<<t;
	obf<<"Total Is "<<t;

	obf.close();
	getch();
}