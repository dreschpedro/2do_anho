program vector64;

uses
	crt;

type
	matriz = array [1..3, 1..4] of integer;

procedure llenar;

	var
		max,x,y,f,c:integer;
		cosa:matriz;

	begin
		randomize;

		for f:=1 to 3 do					//llena la matriz con un numero al azar
			for c:=1 to 4 do
				begin
					cosa[f,c]:=random(9);
				end;
		

		max:=0;								//guarda el numero mas grande
		for f:=1 to 3 do
			for c:=1 to 4 do
				begin	
					if cosa[f,c] >= max then
					max:=cosa[f,c];
				end;

		x:=5;
		y:=5;
		
		for f:=1 to 3 do					//grafica la matriz para comprobar que es el numero mas grande
			begin
				for c:=1 to 4 do
					begin
						gotoxy(x,y);
						write(cosa[f,c]);
						x:=x+4;
					end;
				x:=x-16;
				y:=y+2;
			end;

		x:=5;
		y:=18;
		gotoxy(x,y);
		writeln('el numero mas grande de la matiz es: ', max);	//mensaje final

	end;

begin
	llenar;
	readln();
end.


