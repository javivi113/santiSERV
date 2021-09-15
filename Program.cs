using System;
Console.WriteLine("Hello World!");
var b = 0;
var sumaMedia = 0M;
var notas = new[] { 7.1M, 4M, 6M, 5M, 4M, 6.5M, 7M };
var longArray = notas.Length;


var aprobados=0;
/////////////////////////////////////////////////////////////////////////////
Console.WriteLine("--------------------------------------------------------");
/////////////////////////////////////////////////////////////////////////////
 /*aqui:
      
    if (notas[b]>=5)goto penco;
    aprobados++;
    penco:
    b++;
    if(b!=longArray)goto aqui;
     sumaMedia=sumaMedia/longArray;
     var porcentaje=100-(aprobados*100)/longArray;
     Console.WriteLine("Hay "+longArray+" notas");
     Console.WriteLine("La media es "+sumaMedia);
     Console.WriteLine("La media de aprobados es %" +porcentaje) ;
*/
/////////////////////////////////////////////////////////////////////////////
Console.WriteLine("--------------------------------------------------------");
/////////////////////////////////////////////////////////////////////////////
/*for(var i=0; i<notas.Length;i++){
    sumaMedia= sumaMedia + notas[i];
    if (notas[i]>=5)aprobados++;
}
var porcentaje=(aprobados*100)/longArray;
Console.WriteLine("La media es de " + sumaMedia/longArray);
Console.WriteLine("La media de aprobados es del %"+porcentaje);
/////////////////////////////////////////////////////////////////////////////
Console.WriteLine("--------------------------------------------------------");
/////////////////////////////////////////////////////////////////////////////
     /*var i=1;
     var j=0;
     var aux = 0M;
bucle1:
    bucle2:
        if (notas[j]>notas[j+1]){
            aux=notas[j];
            notas[j]=notas[j+1];
            notas[j+1]=aux;
        }
        j++;
    if(j < longArray-i)goto bucle2;
    i++;
if (i>longArray)goto bucle1;
b=0;
bMostrarRespuesta:
    Console.WriteLine(notas[b]);
    b++;
 if(b!=longArray)goto bMostrarRespuesta;*/
/////////////////////////////////////////////////////////////////////////////
Console.WriteLine("--------------------------------------------------------");
/////////////////////////////////////////////////////////////////////////////
/*int i;
decimal media;

Inicializacion();
while(i<notas.Length)Proceso();
Finalizacion();
void Inicializacion(){
i=0;
media=0;
}
void Proceso(){
    media=media+notas[i];
    i++;
}
void Finalizacion(){
    Console.WriteLine("La media es de " + media/notas.Length);
}*/
/////////////////////////////////////////////////////////////////////////////
Console.WriteLine("--------------------------------------------------------");
/////////////////////////////////////////////////////////////////////////////
/*decimal CalcularMediaArray(decimal[] x){
    decimal resul=0;
    for (int i = 0; i < x.Length; i++)
    {
        resul+=x[i];
    }
    return resul/x.Length;
}
decimal MediaArrayMenorDe5(decimal[] x){
    int f=0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i]>=5)
        {
            f++;
        }
    }
    return (f*100)/x.Length;
}
Console.WriteLine("La media es de " + CalcularMediaArray(notas));
Console.WriteLine("La media es de aprobados " + MediaArrayMenorDe5(notas));*/
/////////////////////////////////////////////////////////////////////////////
Console.WriteLine("--------------------------------------------------------");
/////////////////////////////////////////////////////////////////////////////
/*(String,Char,decimal) A1=("Luis",'H',7.5M);
(String,Char,decimal) A2=("Mara",'M',4M);
(String,Char,decimal) A3=("Marcos",'H',6M);
(String,Char,decimal) A4=("Aroa",'M',5M);
(String,Char,decimal) A5=("Nerea",'M',4M);
(String,Char,decimal) A6=("Kike",'H',6.5M);
(String,Char,decimal) A7=("Juan",'H',7M);
var alumnos = new[] { A1, A2, A3, A4, A5, A6, A7};
//Console.WriteLine("El alumno " + A1.Item1+ " es " + A1.Item2 + " y la media es de " + A1.Item3);
decimal media=0;
for (int i = 0; i < alumnos.Length; i++){
    media+=alumnos[i].Item3;
}
Console.WriteLine("La media de los " + alumnos.Length + " es de " + media/alumnos.Length);*/
/////////////////////////////////////////////////////////////////////////////
Console.WriteLine("--------------------------------------------------------");
/////////////////////////////////////////////////////////////////////////////
(String,Char,decimal) A1=("Luis",'H',7.5M);
(String,Char,decimal) A2=("Mara",'M',4M);
(String,Char,decimal) A3=("Marcos",'H',6M);
(String,Char,decimal) A4=("Aroa",'M',5M);
(String,Char,decimal) A5=("Nerea",'M',4M);
(String,Char,decimal) A6=("Kike",'H',6.5M);
(String,Char,decimal) A7=("Juan",'H',7M);
var alumnos = new[] { A1, A2, A3, A4, A5, A6, A7};
//Console.WriteLine("El alumno " + A1.Item1+ " es " + A1.Item2 + " y la media es de " + A1.Item3);
decimal media=0;
for (int i = 0; i < alumnos.Length; i++){
    media+=alumnos[i].Item3;
}
Console.WriteLine("La media de los " + alumnos.Length + " es de " + media/alumnos.Length);