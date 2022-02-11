program ejerc;

uses
	crt;

type 
	alumno= record
		nom:string[40];
		curso:string[20];
		materia:string[20];
		nota:Real;
	end;

const
	cant=2;

var
	registro:array[1..5] of alumno;
	i,j,fila,fila2:Integer;
	suma,prom:real;

begin
	
	for i:= 1 to cant do{for para ingresar datos}
		begin
			clrscr;
			write('Ingrese nombre: ');
			readln(registro[i].nom);
			write('Ingrese curso: ');
			readln(registro[i].curso);
			write('Ingrese materia: ');
			readln(registro[i].materia);
			write('Ingrese nota: ');
			readln(registro[i].nota);
			suma:= suma + registro[i].nota;
		end;
	clrscr;
	prom:= suma / cant;
	writeln(prom:5:2);
	clrscr;

	fila2:= i + (5*2);

	gotoxy(10,fila2);
	write('Nombre');{    titulo columna         }
	gotoxy(40,fila2);
	write('Curso');{    titulo columna         }
	gotoxy(50,fila2);
	write('Materia');{    titulo columna         }
	gotoxy(65,fila2);
	write('Nota');{    titulo columna         }

	for i:=1 to cant do {for para imprimir datos}
		begin
			for j:=1 to 4 do
				begin

					fila:= i+(5*3);

					if registro[i].nota >= prom then
						textcolor(green)
					else
						begin
							textcolor(red);
						end;

					gotoxy(10,fila);
					write(registro[i].nom);
					
					gotoxy(40,fila);
					write(registro[i].curso);
					
					gotoxy(50,fila);
					write(registro[i].materia);
					
					gotoxy(65,fila);
					write(registro[i].nota:5:2);

			end;
		end;




	readln();
end.