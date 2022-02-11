{Desarrolle un programa en Pascal que
-permita cargar la patente, la marca, el modelo y el año de 10 autos,
-luego listar en forma descendente por año,
-con color rojo aquellos con mas de 10 años, con color amarillo aquellos con mas de 5 años, y con color blanco los ultimo modelo.
-Debe permitir también buscar datos del auto ingresando la patente}

program ejeps;
uses
	crt;

const
	cant=3;
	aactual=2021;

type
	auto=record
		patente:string[6];
		ano:integer;
		modelo:string[20];
		marca:string[20];
	end;
var
	fila:integer;
	most:string;
	p:string;
	i:integer;
	caract:array[1..cant] of auto;

procedure cargar;
begin
	for i:=1 to cant do
		begin
			clrscr;
			write('ingrese la patente: ');
			readln(caract[i].patente);
			write('ingrese el ano: ');
			readln(caract[i].ano);
			write('ingrese el modelo: ');
			readln(caract[i].modelo);
			write('ingrese la marca: ');
			readln(caract[i].marca);
		end;
end;
procedure mostrar;

begin

	for i:=1 to cant do
	begin
		fila:=i+(5*3);

		if caract[i].ano<2011 then
			textcolor(red)
		else
			if (caract[i].ano>=2011) and (caract[i].ano<2017) then
				textcolor(yellow)
			else
				textcolor(green);

			gotoxy(30,fila);
			write(caract[i].patente);
			gotoxy(50,fila);
			write(caract[i].ano);
			gotoxy(70,fila);
			write(caract[i].modelo);
			gotoxy(90,fila);
			write(caract[i].marca);
	end;

			readln();
			clrscr;
end;

procedure buscar(bus:string);
var
	bandera:boolean;
	pos:integer;
begin
	for i:=1 to cant do
		begin
			if bus=caract[i].patente then
			begin
				bandera:=true;
				pos:=i;
			end;
		end;
	if bandera=true then
		begin
			writeln(caract[pos].patente);
			writeln(caract[pos].ano);
			writeln(caract[pos].modelo);
			writeln(caract[pos].marca);
			readln();
		end;
	end;
begin
	cargar;
	clrscr;
	mostrar;
	clrscr;
	writeln('ingrese la patente a buscar');
	readln(p);
	buscar(p);
	readln();
end.