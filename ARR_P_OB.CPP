//program to show the concept of ARRAY OF POINTER TO OBJECT
#include<iostream.h>
#include<conio.h>
class ArrPObj
{
	public:
	void result(int m)
	{
		cout<<"Total Marks "<<m<<endl;
	}


}ob1,ob2,ob3;
void main()
{
	clrscr();

	ArrPObj *bca[3];

	bca[0]=&ob1;
	bca[0]->result(400);

	bca[1]=&ob2;
	bca[1]->result(400);

	bca[2]=&ob3;
	bca[2]->result(400);

	getch();
}
