//read function  and write function
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
void main()
{
	int salary[4]={5000,6000,7000,8000};
	int i;
	fstream f;
	clrscr();
	f.open("emp_sal.txt",ios::out);
	f.write((char *)&salary, sizeof(salary));
	f.close();


	f.open("emp_sal.txt",ios::in);
	f.read((char *)&salary, sizeof(salary));

	for(i=0;i<=3;i++)
	{
		cout<<"employee salary is:"<<salary[i]<<endl;
	}
	f.close();
	getch();
}