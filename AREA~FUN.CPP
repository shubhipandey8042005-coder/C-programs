#include<iostream.h>
#include<conio.h>
float area;
void circle();
int square(void);
void triangle(float height,float breadth);
int rectangle(int length,int breadth);
void main()
{
	clrscr();
	int choice,ar;
	cout<<"Press No. Keys to Perform following Calculations"<<endl;
	cout<<"1 for Area of Circle"<<endl;
	cout<<"2 for Area of Square"<<endl;
	cout<<"3 for Area of Triangle"<<endl;
	cout<<"4 for Area of Rectangle"<<endl;
	cout<<"\nEnter Your Choice : ";
	cin>>choice;
	cout<<endl;

	switch(choice)
	{
		case 1:
		{
			circle();
			break;
		}
		case 2:
		{
			ar = square();
			cout<<"Area of Square is "<<ar;
			break;
		}
		case 3:
		{
			float height,breadth;
			triangle(height,breadth);
			break;
		}
		case 4:
		{
			int length,breadth;
			ar = rectangle(length,breadth);
			cout<<"Area of Rectangle is "<<ar;
			break;
		}
		default:
		{
			cout<<"\nWrong Choice\nTry Again";
		}
	}
		getch();
}
void circle()
{
	int radius;
	cout<<"Enter Radius : ";
	cin>>radius;
	area=3.14*radius*radius;
	cout<<"Area of Circle is "<<area;
}
int square(void)
{
	int side;
	cout<<"Enter Side : ";
	cin>>side;
	area=side*side;
	return area;
}
void triangle(float height,float breadth)
{
	cout<<"Enter Height : ";
	cin>>height;
	cout<<"Enter Breadth : ";
	cin>>breadth;
	area=0.5*height*breadth;
	cout<<"Area of Triangle is "<<area;
}
int rectangle(int length,int breadth)
{
	cout<<"Enter Length : ";
	cin>>length;
	cout<<"Enter Breadth : ";
	cin>>breadth;
	area=length*breadth;
	return(area);
}



