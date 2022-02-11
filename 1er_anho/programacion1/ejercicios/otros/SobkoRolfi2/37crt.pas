program crt37;

uses
	crt;

var
	con,suma,i:integer;

begin
	i:=1;						//realiza la operacion 
	suma:=0;

	for i:=1 to 100 do
 		begin
 			suma:=suma+i;
 		end;

	clrscr;
	con:=1;						//realiza la operacion/>
	
		repeat					//imprime los numeros
			begin
				textcolor(green);
				write(con, ' + ');	
				con:=con+1;	
			end;
		until con = 99;			//imprime los numero/>

textcolor(green);				//uso un poco el crt 
write(' + 100 = ', suma); 	{me habia puesto a experimentar con los margenes pero quedo un desastre, asi que lo deje por defecto.}
readln();
end.