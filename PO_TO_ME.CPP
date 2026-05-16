//Program To Show Concept Of Pointers To Members.

#include<iostream.h>
#include<conio.h>
class BCA
{
	public:
		int a;
		void show()
		{
			BCA ob;
			int BCA ::* k = &BCA :: a;
			cout<<"\nValue Of A : "<<a;
			cout<<"\nValue Of K : "<<(ob.*k);
		}
};
void main()
{
	clrscr();
	BCA ob;
	BCA *ptr;
	ptr = &ob;
	ptr -> a = 10;
	ptr -> show();
//	int BCA ::* k = &BCA :: a;
//	cout<<"\nValue Of K : "<<(ob.*k);
//	cout<<"\nValue Of K : "<<(ptr->*k);
	getch();
}