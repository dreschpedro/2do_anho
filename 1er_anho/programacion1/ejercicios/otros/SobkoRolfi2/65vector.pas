program vector65;
uses Crt;
type
  tmenu= record
        cena: string[10];
	      almuerzo: string[20];
	end;
var
  vector: array[1..5] of tmenu;
  i: integer;
BEGIN
  ClrScr;
  writeln('Menu del dia(lunes = 1, martes = 2, miercoles =3, jueves = 4, viernes = 5): ');
  writeln;
  for i:=1 to 5 do
   Begin
     write('Escriba la cena del dia ',i,': ');
	 readln(vector[i].cena);
	 write('Escriba el almuerzo del dia ',i,': ');
	 readln(vector[i].almuerzo);
	 writeln
   End;
  

  ClrScr;
  writeln('escriba un dia para saber el Menu (lunes = 1, martes = 2, miercoles =3, jueves = 4, viernes = 5):');
  readln(i);
  writeln('el almuerzo es: ', vector[i].almuerzo);
  writeln('y la cena es: ', vector[i].cena);
  readln();
END. 