program vector69;

uses
	crt;
var

	car: array [1..10] of 
		record
		patente:string[8];
		marca:string[8];
		modelo:string[8];
		year:integer;
		end;

	x,y,pos,i,j,aux:integer;
	flag:boolean;
	des:string[2];
	bus:string[8];


begin

	for i:=1 to 10 do 														//se carga el vector
		begin 
			clrscr;	
			writeln('ingrese la patente del vehiculo ', i); readln(car[i].patente);
			writeln('ahora ingrese la marca del vehiculo ', i); readln(car[i].marca);
			writeln('ahora ingrese el modelo del vehiculo ', i); readln(car[i].modelo);
			writeln('ahora ingrese el anho del vehiculo ', i); readln(car[i].year);
		end;

	clrscr;

	for  i:=1 to 10 do 													//metodo burbuja
			for j:=1 to 10 - i do
				begin
					if (car[j].year >  car[j+1].year) then 
						begin
							aux:=car[j].year;
							car[j].year:=car[j+1].year;
							car[j+1].year:=aux;
						end;
				end;
	

	repeat																//impresion final

		for i:=10 downto 1 do
		begin
			if car[i].year = 2021 then
				begin
					textcolor(green);
					writeln('anho: ', car[i].year, ' patente: ', car[i].patente);
				end 
			 else if (car[i].year >= 2011) and (car[i].year <> 2021) then
				begin
					textcolor(yellow);
					writeln('anho: ', car[i].year, ' patente: ', car[i].patente);
				end
			else if car[i].year < 2011 then
				begin
					textcolor(red);
					writeln('anho: ', car[i].year, ' patente: ', car[i].patente);
				end
			else textcolor(red);

			
		end;

	writeln();
	writeln();
	writeln();

	
		flag:=false;																		//buscador
		while flag <> true do
			begin
				textcolor(green);
				writeln('ingrese la patente de un vehiculo para saber sus datos ');
				readln(bus);
			
					for i:=1 to 10 do 
						begin
							if (car[i].patente = bus) then
								begin
									pos:=i;
									flag:=true;
								end;
						end;
		
			end;

		writeln('Datos del vehiculo num ', pos, ': patente; ', car[pos].patente, ', marca; ', car[pos].marca, ', modelo; ', car[pos].modelo, ', anho; ', car[pos].year);
		writeln();
		writeln();
		writeln();
		writeln('desea continuar?(si o no)');
		readln(des);
		clrscr;
	until des = 'no';
end.