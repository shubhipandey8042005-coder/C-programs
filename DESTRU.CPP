//program of DESTRUCTOR
#include<iostream.h>
#include<conio.h>
class bca
{
	public:
	bca()
	{
		cout<<"constructor";
	}
	~ bca()
	{
		cout<<"destructor";
	}
};
void main()
{
	clrscr();
	bca ob;
	getch();
}