program vector56;

uses 
	crt;

type

	vector = array[1..20] of integer;

var
	n,min,max,pos,pos2:integer;
	azar:vector;


begin


	min:=0;

	randomize;
	for n:=1 to 20 do 
		begin

			azar[n]:=random(5);											//genera el numero al azar

			if (azar[n] <= min) or (min = 0) then						//el numero mas bajo
				begin
					min:=azar[n];
					pos:=n;
				end;

			if (azar[n] >= max)  then									//el numero mas alto
				begin
					max:=azar[n];
					pos2:=n;
				end;

		end;

	for n:=1 to 20 do
		begin
			textcolor(white);
			writeln(azar[n]);
		end;

		writeln('El numero mas bajo es ', min, ' y esta en la posicion ', pos);			//impredsion final
		writeln('El numero mas alto es ', max, ' y esta en la posicion ', pos2);		//impredsion final
	readln();
end.