//
#include<iostream.h>
#include<conio.h>
#include<fstream.h>
#include<iomanip.h>
void main()
{
	float height[4]={10.5,22.5,5.5,33.5};

	ofstream outfile;
	outfile.open("binary.txt");

	outfile.write((char *) & height,sizeof(height));
	outfile.close();

	for(int i=0;i<4;i++)
	height[i]=0;
	ifstream infile;
	infile.open("binary.txt");
	infile.read((char *) & height, sizeof(height));

	for(i=0;i<4;i++)
	{
		cout.setf(ios::showpoint);
		cout << setw(10) << setprecision(2)
		     << height[i];

	}
	infile.close();
	getch();
}