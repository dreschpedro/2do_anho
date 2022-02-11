{Desarrolle un programa en Pascal que
-solicite ingresar 10 números los almacene en un vector,
-luego permita buscar un elemento e indique su posición en la lista}

program ejerc57;

uses Crt;

const cant=10;

type
	arrai=array[1..cant] of integer;

var
	i,num,pos:Integer;
	vector:arrai;
	bandera:boolean;

procedure cargar;//															cargar numeros
	begin
		for i:=1 to cant do
			begin
				write('Ingrese numero #',i,': '); readln(vector[i]);
			end;
	end;

procedure buscar;
	begin
		bandera:=false;
		clrscr;
		write('Numero a buscar: '); readln(num);

		for i:=1 to cant do
			begin
				if vector[i]=num then
					begin
						bandera:=true;//									guarda posicion del numero encontrado
						pos:=i;
					end;
			end;

			if bandera=true then
				write('El numero se encontro en la posicion: ',pos)
			else
				write('El numero no se encontro');
	end;

begin

	cargar;
	buscar;

	readln;
end.