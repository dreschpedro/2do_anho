program crt41;

uses 
	crt;

var
x,con:integer;
	
begin
	x:=3;//elegi el color cyan por que con el blue parece la bandera de los unitarios
	con:=0;

	REPEAT		//esto dibuja la bandera
		textcolor(x);
		write(chr(219));
		con:=con+1;
		IF (con >= 640) and (con < 1279) THEN x:= 15	//estp cambia los colores segun la posicion.
		else if con >1279 THEN x:= 3;
	until con = 1920;

readln();
end.
