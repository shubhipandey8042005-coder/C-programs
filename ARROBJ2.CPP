//program of array of object(book)
#include<iostream.h>
#include<conio.h>
class employee
{
	char name[30];
	float age;
	public:
	getdata();
	putdata();
};
employee::getdata()
{
	cout<<"enter name:";
	cin>>name;
	cout<<"enter age:";
	cin>>age;
}
 employee::putdata()
{
	cout<<"name:"<<name<<"\n";
	cout<<"age:"<<age<<"\n";
}
const int size=3;
int main()
{
	clrscr();
	employee manager[size];
	for(int i=0;i<size;i++)
	{
		cout<<"\ndetails of manager"<<i+1<<"\n";
		manager[i].getdata();
	}
	cout<<"\n";
	for(i=0;i<size;i++)
	{
		cout<<"\nmanager"<< i+1<<"\n";
		manager[i].putdata();
	}
	getch();

}