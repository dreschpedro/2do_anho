program vector67;

uses
	crt;
var

	art: array [1..20] of 
		record
			codigo: string[8];
			precio:	real;
			stock:integer;
		end;

	pos,i:integer;
	flag:boolean;
	des:string[2];
	bus:string[8];

begin

	for i:=1 to 20 do 
		begin 	
			writeln('ingrese el codigo del articulo ', i);
			readln(art[i].codigo);
			writeln('ahora ingrese el precio del articulo ', i);
			readln(art[i].precio);
			writeln('ahora ingrese el stock del articulo ', i);
			readln(art[i].stock);
		end;

	clrscr;

	repeat

		flag:=false;
		while flag <> true do
			begin
				writeln('que articulo desea buscar?(ingrese el cidogo del articulo) ');
				readln(bus);
			
					for i:=1 to 20 do 
						begin
							if (art[i].codigo = bus) then
								begin
									pos:=i;
									flag:=true;
								end;
						end;
		
			end;

		writeln('el articulo ', art[pos].codigo, ' esta en la posicion ', pos, ', costo: ', art[pos].precio:5:2,', stock: ', art[pos].stock, '.');
		readln();
		writeln('desea continuar?(si o no)');
		readln(des);

	until des = 'no';

	readln();
end.