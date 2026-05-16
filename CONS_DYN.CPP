//program to shiow the concept of Dynamic initialization of objects
#include<iostream.h>
#include<conio.h>
class BCA
{
	int a,b;
	public:
	BCA()
	{
		cout<<"default constructor"<<endl;
	}
	BCA(int a,int b=0)
	{
		cout<<a+b<<endl;

	}
};
void main()
{
	clrscr();
	int a,b;
	cout<<"value of a&b"<<endl;
	cin>>a>>b;
	BCA ob(a,b);
	cout<<"value of a is:"<<a<<endl;
	cin>>a;
	cout<<"value of b is:"<<b<<endl;
	cin>>b ;
	BCA oc(a);
	getch();
}