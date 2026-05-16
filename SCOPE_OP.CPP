#include<iostream.h>
#include<conio.h>
void display();
class BCA
{
	private:
	void show();
	public:
	void msg()

      {
	cout<<"public method in class";
	show();
      }

};
void BCA::show()
{
	cout<<"\nprivate method outside the class";
}
void main()
{
	clrscr();
	BCA obj;
	obj.msg();
	display();
	getch();

}
void display()
{
	cout<<"\nnormal function";
}