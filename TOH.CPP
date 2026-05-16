//Tower of Hanoi

#include<iostream.h>
#include<conio.h>
void towers(int,char,char,char);
void main()
{
	int n;
	clrscr();
	cout<<"Enter no. of disks : ";
	cin>>n;
	cout<<"The sequence of moves included in the tower of hanoi are\n";
	towers(n,'A','C','B');
	getch();
}
void towers(int n,char A,char C,char B)
{
	if(n==1)
	{
		cout<<"Move disk 1 from peg "<<A<<" to peg "<<C;
		return;
	}
	towers(n-1,A,B,C);
	cout<<endl;
	cout<<"move disk "<<n<<" from peg "<<A<<" to peg "<<C;
	cout<<endl;
	towers(n-1,B,C,A);
}