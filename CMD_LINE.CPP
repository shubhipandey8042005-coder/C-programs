//Program To Show Concept Of Command Line Arguments.

#include<iostream.h>
#include<conio.h>
int main(int c, char *ch[])
{
	clrscr();
	cout<<"No. Of Arguments = "<<c;
//	cout<<"\n\nValue Is "<<ch[0];
//	cout<<"\n\nValue Is "<<ch[1];

	for(int i=1;i<c;i++)
	{
		cout<<"\n\nValue Is "<<ch[i];
	}
	getch();
	return 0;
}

