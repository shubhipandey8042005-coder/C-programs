//program to Show the Concept of Class and Object

#include<iostream.h>
#include<conio.h>
class Student
{
	char name[10];
	int rollno,marks[6],total,i;
	float per;
	public:
		void input()
		{
			total = 0;
			cout<<"Enter Name of Student : ";
			cin>>name;
			cout<<"Enter Roll No. of Student : ";
			cin>>rollno;
			cout<<"Enter Marks of Student out of 100 : "<<endl;
			for(i=0;i<=5;i++)
			{
				cout<<"Marks ";
				cin>>marks[i];
				total = total+marks[i];
			}
		}
		void output()
		{
			cout<<endl;
			cout<<"\nName = "<<name<<endl;
			cout<<"Roll No. = "<<rollno<<endl;
			for(i=0;i<=5;i++)
			{
				cout<<"Marks = "<<marks[i]<<endl;
			}
			cout<<"Total Marks = "<<total<<endl;
			per = total/6;
			cout<<"Percentage = "<<per<<" %";
		}
};
void main()
{
	clrscr();
	Student s;
	s.input();
	s.output();
	getch();
}