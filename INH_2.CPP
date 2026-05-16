//single i nheritance
#include<iostream.h>
#include<conio.h>
class Acc
{

	public:

	float sal=60000;


};
class Prog:public Acc
{
	public:

	float bon=5000;


};
void main()
{
	clrscr();
	Prog p1;
	cout<<"salary:"<<p1.sal<<endl;
	cout<<"bon:"<<p1.bon<<endl;
	getch();

}