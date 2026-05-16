//Program To Show Concept Of Circle Generation

#include<iostream.h>
#include<conio.h>
#include<graphics.h>
void main()
{
	clrscr();

	int gd = DETECT,gm;
	initgraph(&gd,&gm,"..\\bgi");

	circle(200,200,80);
	circle(165,165,3);
	circle(230,165,3);
	circle(230,165,20);
	circle(165,165,20);
	circle(200,230,20);

	getch();

	closegraph();
}
