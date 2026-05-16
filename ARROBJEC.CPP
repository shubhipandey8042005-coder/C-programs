//program to show the concept of array of object
#include<iostream.h>
#include<conio.h>
class Demo
{
	public:
	void show()
	{
		cout<<"welcome in c++"<<endl;
	}
};
void main()
{
	int i;
	Demo ob[4];
	clrscr();
	for(i=0;i<3;i++)
	{
		ob[i].show();
	}
	getch();
}