#include<iostream.h>
#include<conio.h>
void main()
{
	clrscr();
	int i,count=0;
	for(i=1900;i<=2000;i++)
	{
		if((i%100!=0) && (i%4==0))
//		if(i%4==0)
		{
			cout<<i<<"\t";
			count++;
		}
	}
	cout<<endl;
	cout<<"Total Leap Year : "<<count;
	getch();
}