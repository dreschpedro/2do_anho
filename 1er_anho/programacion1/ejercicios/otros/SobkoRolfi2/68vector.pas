program vector68;

uses
	crt;
var

	art: array [1..10] of record
			codigo: string[8];
			precio:	real;
			stock:integer;
			desc:string[10];
			tot:real;
		end;

	pos,i:integer;
	flag:boolean;
	des:string[2];
	bus:string[8];


begin



	for i:=1 to 10 do 
		begin 
			clrscr;	
			writeln('ingrese el codigo del articulo ', i);
			readln(art[i].codigo);
			writeln('ahora ingrese una descripcion del articulo ', i);
			readln(art[i].desc);
			writeln('ahora ingrese el precio del articulo ', i);
			readln(art[i].precio);
			writeln('ahora ingrese cuanto se vendio del articulo ', i);
			readln(art[i].stock);
		end;


	for i:=1 to 10 do
		begin 
			art[i].tot:=art[i].precio * art[i].stock;
		end;

	clrscr;

	repeat
	
		flag:=false;
		while flag <> true do
			begin
				writeln('que articulo desea buscar?(ingrese el codigo del articulo) ');
				readln(bus);
			
					for i:=1 to 10 do 
						begin
							if (art[i].codigo = bus) then
								begin
									pos:=i;
									flag:=true;
								end;
						end;
		
			end;

		writeln('el articulo ', art[pos].codigo, ' esta en la posicion ', pos, ', costo: $', art[pos].precio:5:2,', se vendio: ', art[pos].stock, '.');
		writeln('y la cantidad de ganancias es: $', art[pos].tot:5:2);
		writeln();
		writeln();
		writeln();
		writeln('desea continuar?(si o no)');
		readln(des);
		clrscr;
	until des = 'no';

end.