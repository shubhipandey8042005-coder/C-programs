//Program To Show Concept Of Pointers To Object.

#include<iostream.h>
#include<conio.h>
class BCA
{
	public:
		int a;
		void show()
		{
			cout<<"Value Of A : "<<a;
		}
};
void main()
{
	clrscr();
	BCA ob;
	BCA *ptr; // Pointer To Object.
	ptr = &ob;
	ptr -> a = 10;
	ptr -> show();
	getch();
}