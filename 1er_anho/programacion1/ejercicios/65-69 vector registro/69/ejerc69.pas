{Desarrolle un programa en Pascal que permita
-cargar la patente, la marca, el modelo y el año de 10 autos,
-luego listar en forma descendente por año,
-con color rojo aquellos con mas de 10 años, con color amarillo aquellos con mas de 5 años, y con color blanco los ultimo modelo.
-Debe permitir también buscar datos del auto ingresando la patente}

program eje69;

uses Crt;

const
	cant=2;

type arrai=record
		patente:string[10];
		marca:string[10];
		modelo:string[10];
		anho:integer;
	end;

var
	i:integer;
	bandera:boolean;
	vector:array [1..cant] of arrai;

procedure cargar;
	begin
		for i:=1 to cant do
			begin
				write('Ingresa patente del #',i,' auto: '); readln(vector[i].patente);
				write('Ingresa marca del #',i,' auto: '); readln(vector[i].marca);
				write('Ingresa modelo del #',i,' auto: '); readln(vector[i].modelo);
				write('Ingresa anho del #',i,' auto: '); readln(vector[i].anho);
				writeln;
			end
	end;

procedure imprimir;
	begin
		for i:=1 to cant
			begin
				
			end;
	end;

// procedure buscar;
// 	begin
// 		bandera:=false;
// 		ClrScr;
// 		repeat

// 		until 
// 	end;

begin

	cargar;
	// buscar;

	readln;
end.