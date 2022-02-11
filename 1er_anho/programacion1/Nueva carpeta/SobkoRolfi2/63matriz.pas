program matriz63;

uses
	crt;

type
	ventas = array [1..6, 1..10] of integer;

	nombres = array [1..10] of string[7];


procedure planilla;

	var
		tot,x,y,f,c:integer;
		namev:nombres;
		plata:ventas;

	begin

		for f:=1 to 10 do
			begin
				writeln('ingrese los nombres de los vendedores');
				readln(namev[f]);
			end;

		clrscr;

		for f:=1 to 5 do
		
			for c:=1 to 10 do 
				begin 
					writeln('ingrese el moto que ', namev[c], ' vendio  el dia ', f);
					readln(plata[f,c]);
				end;
		
		for c:=1 to 10 do
			plata[6,c]:=plata[1,c]+plata[2,c]+plata[3,c]+plata[4,c]+plata[5,c];

		tot:=plata[6,1]+plata[6,2]+plata[6,3]+plata[6,4]+plata[6,5]+plata[6,6]+
		plata[6,7]+plata[6,8]+plata[6,9]+plata[6,10];

		clrscr;
		x:=10;
		y:=5;

		gotoxy(x,y);
		textcolor(blue);

		writeln('lunes');
		y:=y+2;
		gotoxy(x,y);
		writeln('martes');
		y:=y+2;
		gotoxy(x,y);
		writeln('miercoles');
		y:=y+2;
		gotoxy(x,y);
		writeln('jueves');
		y:=y+2;
		gotoxy(x,y);
		writeln('viernes');
		y:=y+2;
		gotoxy(x,y);
		writeln('total');
		

		y:=3;
		x:=33;

		for c:=1 to 10 do
			begin
				textcolor(blue);
				gotoxy(x,y);
				write(namev[c]);
				x:=x+8;
			end;



		y:=5;
		x:=25;

		for f:=1 to 6 do
			begin
			gotoxy(x,y);
				for c:=1 to 10 do
					begin
						x:=x+8;
						textcolor(15);
						gotoxy(x,y);
						write(plata[f,c]);

					end;
			x:=x-80;
			y:=y+2;
			end;

	gotoxy(25,25);
	writeln('el total de ventas en la semana fue de $', tot);



	end;


begin
	planilla;
	readln();
end.
