program vector50;

uses 
	crt;

type

	vector = array[1..10] of integer;

var
	n,min,max,sum:integer;
	azar:vector;
	prom:real;


begin
randomize;
	for n:=1 to 10 do 
		begin

			azar[n]:=random(5);											//genera el numero al azar
			sum:=sum+azar[n];

			if (azar[n] <= min) or (min = 0) then						//el numero mas bajo
				min:=azar[n];
				
			if (azar[n] >= max) then									//el numero mas elevado
				max:=azar[n];
		end;

	prom:=sum/10;// promedio

	for n:=1 to 10 do
		begin
			if (azar[n] <= prom) then 					//ipresion de numeros con color
				begin
					textcolor(red);
					writeln(azar[n]);
				end
			else if (azar[n] > prom) then
				begin
					textcolor(white);
					writeln(azar[n]);
				end;									//impresion de numero con color/>

		end;

		writeln('El numero mas bajo es ', min, ' y el mas alto es ', max);		//impredsion final
	readln();
end.