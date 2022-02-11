program matriz62;

uses
	crt;

type
	matriz = array [1..10, 1..3] of integer;

procedure tablas;

	var
		y,x,sum,f,c,n:integer;
		tabla:matriz;

	begin

		writeln('introduzaca el numero de la tabla de multilplicar que necesite');
		read(n);


		sum:=1;
		for f:=1 to 10 do										//asigna el valor a lac columnas
			begin
				tabla[f,1]:=n;
				tabla[f,2]:=sum;
				tabla[f,3]:=tabla[f,1] * tabla[f,2];
				sum:=sum+1;
			end;

		x:=5;
		y:=5;
		gotoxy(x,y);
		textcolor(green);
		
		write('c1= su numero(factor), c2= factor y c3= producto.'); //no se por que pascal imprime mal el mensaje
																	//creo que es por el crt
		for c:=1 to 3 do 
			begin
				for f:=1 to 10 do 									//este for concatenado imprime la matriz
					begin
						gotoxy(x,y);
						write(tabla[f,c]);
						y:=y+2;
					end;
				y:=y-20;
				x:=x+5;
			end;
	readln();
	end;

begin									//begin principal(me salta aunque tenga un readln, por eso puse 2)
	tablas;
	readln();
end.