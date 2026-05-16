//program to Show the Concept of Class and Object with Array

#include<iostream.h>
#include<conio.h>
class Array
{
	private:
		int ar[5],min,max,i,j;
	public:  	//Access Specifier
		void input()
		{
			for(i=0;i<=4;i++)
			{
				cout<<"Enter "<<(i+1)<<" Value : ";
				cin>>ar[i];
			}
		}
		void minimum()
		{
			min = ar[0];
			for(i=0;i<=4;i++)
			{
				if(min>=ar[i])
				{
					min = ar[i];
				}
			}
			cout<<"\nMinimum Value in Array is "<<min;
		}
		void maximum()
		{
			max = ar[0];
			for(i=0;i<=4;i++)
			{
				if(max<=ar[i])
				{
					max = ar[i];
				}
			}
			cout<<"\n\nMaximum Value in Array is "<<max;
		}
};
void main()
{
	clrscr();
	Array ar;
	ar.input();
	ar.minimum();
	ar.maximum();
	getch();
}
