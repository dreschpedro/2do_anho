//Desarrolle un programa en Pascal que
//-permita cargar el código, el precio y el stock de 20 artículos,
//-luego el usuario ingresa el código y el programa le devuelve el precio y el stock,
//-hasta que el usuario desee salir

program ejer67;

uses Crt;

const
	cant=5;

type
	arrai=record
		cod:string[10];
		precio:integer;
		stock:integer;
	end;

var
	i,pos:integer;
	codBus,opc:string[10];
	bandera:boolean;
	vector:array [1..cant] of arrai;

procedure cargar;
	begin
		for i:=1 to cant do
			begin
				write('Ingrese codigo: '); readln(vector[i].cod);
				write('Ingrese precio: '); readln(vector[i].precio);
				write('Ingrese stock: '); readln(vector[i].stock);
				writeln;
			end;
	end;

procedure buscar;
	begin
		repeat
			clrscr;
			bandera:=false;
			
			while bandera<> true do
				begin
					write('Ingresa el codigo a buscar: '); readln(codBus);
					writeln;

					for i:=1 to cant do
						begin//															inicio for
							if codBus=vector[i].cod then
								begin
									bandera:=true;
									pos:=i;
								end;
						end;//															fin for

					if bandera=true then
						write('el precio del codigo seleccionado es: ',vector[pos].precio,' con ',vector[pos].stock,' unidades en stock')
					else
						write('No hay ningun registro de ese codigo');

					writeln;

				end;
			write('Desea seguir buscando (s/n): '); readln(opc);
		until opc='n';
	end;

begin

	cargar;
	buscar;

	readln;
end.
