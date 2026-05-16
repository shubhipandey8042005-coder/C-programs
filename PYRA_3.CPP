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
		for(j=1;j<=i;j++)
		{
			cout<<" ";
		}
		for(k=1;k<=(n-i);k++)
		{
			cout<<"* ";
		}
		cout<<endl;
	}
	getch();
}
