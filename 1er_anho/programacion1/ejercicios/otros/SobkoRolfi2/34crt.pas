program crt34;

uses
	crt;

const
	fila = 19;
	columna = 30;
	a = 201;  // ╔(201) o ┌(218)
	b = 205;  // ═(205) o ─(196)
	c = 203;  // ╦(203) o ┬(194)
	d = 187;  // ╗(187) o ┐(191)
	e = 186;  // ║(186) o │(179)
	f = 204;  // ╠(204) o ├(195)
	g = 206;  // ╬(206) o ┼(197)
	h = 200;  // ╚(200) o └(192)
	i = 202;  // ╩(202) o ┴(193)
	j = 188;  // ╝(188) o ┘(217)
	k = 185;  // ╣(185) o ┤(180)

var
	con,x,y:integer;

begin
	clrscr;									
	y:= 10;								
	x:= 8;
	gotoxy(x,y);						
	write(chr(a));									//esto dibuja el borde superior
	for con:=2 to columna do
		write(chr(b), chr(c));
		write(chr(b), chr(d));					//esto dibuja el borde superior/>

		y:=y + 1;	// cambio la posicion de y
		while y <> fila do								//esto dibuja el borde derecho
			begin
				gotoxy(x,y);
				write(chr(e));
				y:=y + 2;
			end;
		y:=y - 7;  // cambio la posicion de y
		while y <> 18 do
			begin
				gotoxy(x,y);
				write(chr(f));
				y:=y + 2;
			end;										//esto dibuja el borde derecho/>

	x:= x + 1;		// cambio la posicion de x	
	y:=11;			// cambio la posicion de y

	repeat											//esto dibuja las casillas internas
		begin
			gotoxy(x, y);
				for con:= 0 to (columna - 2) do
					write(' ', chr(e));
					write(' ');						

			y:= y + 1;
			gotoxy(x, y);
				for con:= 0 to (columna - 2) do
					write(chr(b), chr(g));
					write(chr(b));
					y:= y + 1;
		end;
	until y = (fila - 2);
	gotoxy(x, y);
	for con:= 0 to (columna - 2) do
		write(' ', chr(e));
		write(' ');									//esto dibuja la casillas internas/>
	
	y:= y + 1;	// cambio la posicion de y
	x:=x - 1;	// cambio la posicion de x
	gotoxy(x,(fila - 1));									//esto dibuja el borde inferiror
	write(chr(h));
		for con:=2 to columna do
			write(chr(b), chr(i));
			write(chr(b), chr(j));				//esto dibuja el borde inferiror/>


	x:=x + 60;	// cambio la posicion de x
	y:=11;		// cambio la posicion de y				
	while y <> fila do 								//esto dibuja el borde izquierdo
		begin
			gotoxy(x,y);
			write(chr(e));
			y:=y + 2;
		end;
	y:=y - 7;	// cambio la posicion de y
	while y <> (fila - 1) do
		begin
			gotoxy(x,y); 
			write(chr(k));
			y:=y + 2;
		end;										//esto dibuja el borde izquierdo/>

readln();
end.