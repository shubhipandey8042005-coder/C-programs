#include<iostream.h>
#include<conio.h>
void main()
{
	int n,i,j,k;
	clrscr();
	cout<<"Enter a Number ";
	cin>>n;
	for(i=1;i<=n;i++)
	{
		for(k=1;k<=(n-i);k++)
		{
			cout<<" ";
		}
		for(j=1;j<=i;j++)
		{
			cout<<"* ";
		}
		cout<<endl;
	}
	getch();
}
