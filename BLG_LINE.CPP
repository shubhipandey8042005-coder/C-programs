//Program To Show Concept Of Line Generation Using Breshenman Algorithm.

#include<iostream.h>
#include<conio.h>
#include<graphics.h>
void BLG()
{
	float x,y,xn,yn,dty,dtx,x1,y1,p,p1,a,b;

	x = 100;
	y = 150;

	xn= 200;
	yn= 300;

	dty = yn - y;
	dtx = xn - x;

	a = 2 * dtx;
	b = 2 * dty;

	p = b - dtx;

	x1 = x;
	y1 = y;

	p1 = p;

	for(x1,y1; x1<xn && y1<yn;)
	{

		if(p1<0)
		{
			x1 = x1 + 1;
			y1 = y1;
			p1 = p + b;
		}
		else
		{
			x1 = x1 + 1;
			y1 = y1 + 1;
			p1 = p + b - a;
		}

		line(x,y,x1,y1);

	}
}
void main()
{

	int gd = DETECT,gm;
	initgraph(&gd,&gm,"..\\bgi");

	clrscr();

	BLG();

	getch();

	closegraph();
}
