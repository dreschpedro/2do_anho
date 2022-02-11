{Desarrolle un programa que genere e imprima la tabla de multiplicar de un número ingresado por el usuario}

program ejer38;


uses
	CRT;

var
	i,j,y,x,num:Integer;

begin

	write('Ingresa un numero para multiplicar: ');
	readln(num);

	y:=5;
	x:=50;

	for j:=1 to 11 do {filas}
		begin
			for i:=1 to 16 do {cantidad de puntos}
				begin
					delay(1);
					gotoxy(x,y);
					write('-'); {imprime horizontalmente}
					x:= x + 1; {hace salto hacia la derecha de posicion}
				end;
			y:= y + 2; {hace salto de lineas}
			x:= 50;
		end;

	y:=5;
	x:=50;

	for j:=1 to 2 do {columnas}
		begin
			for i:=1 to 21 do
				begin
					delay(1);
					gotoxy(x,y);
					textcolor(2);
					write('|'); {imprime verticalmente}
					y:= y + 1; {hace salto hacia abajo de posicion}
				end;
			x:= x + 15; {hace salto de columnas}
			y:= 5;
		end;

	y:=6;
	x:=52;

	for j:=1 to 10 do {filas de los numeros impresos}
		begin
			delay(1);
			gotoxy(x,y);
			textcolor(green);
			write(num,' x ',j,'= ',num*j);
			y:= y + 2; {hace salto de linea}
			x:= 52;
		end;

	readln();
end.