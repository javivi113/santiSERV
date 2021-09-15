using System;
class Program
{
    public struct Alumnos
    {
        public String Nombre;
        public char Sexo;
        public decimal Nota;
    }
    public static void Main()
    {
        Console.WriteLine("Hello World!");
        var b = 0;
        var sumaMedia = 0M;
        var notas = new[] { 7.1M, 4M, 6M, 5M, 4M, 6.5M, 7M };
        var longArray = notas.Length;


        var aprobados = 0;
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
        // EJERCICIO 5 
        //TUPLAS /
        /*public class Tuplas
        {
            public static void Main()
            {
                decimal media = 0;
                Tuple<string, char, decimal>[] datos =
                {
                    Tuple.Create("Luis", 'H',7.5M),
                    Tuple.Create("Marta", 'M',4M),
                    Tuple.Create("Marcos", 'H',6M),
                    Tuple.Create("Aroa", 'M',5M),
                    Tuple.Create("Nerea", 'M',4M),
                    Tuple.Create("Kike", 'H', 6.5M),
                    Tuple.Create("Juan", 'H',7.5M)
            };
                for (var i = 0; i < datos.Length; i++)
                {
                    Console.WriteLine("Nombre: " + datos[i].Item1 + " | Genero: " + datos[i].Item2 + " | Nota: " + datos[i].Item3);
                    media = media + datos[i].Item3;
                }
                Console.WriteLine("La nota media de los alumnos es " + media / datos.Length);
            }
        }
        */
        Alumnos A1; A1.Nombre = "Luis"; A1.Sexo = 'H'; A1.Nota = 7.5M;
        Alumnos A2; A2.Nombre = "Marta"; A2.Sexo = 'M'; A2.Nota = 4M;
        Alumnos A3; A3.Nombre = "Marcos"; A3.Sexo = 'H'; A3.Nota = 6M;
        Alumnos A4; A4.Nombre = "Aroa"; A4.Sexo = 'M'; A4.Nota = 5M;
        Alumnos A5; A5.Nombre = "Nerea"; A5.Sexo = 'M'; A5.Nota = 4M;
        Alumnos A6; A6.Nombre = "Kike"; A6.Sexo = 'H'; A6.Nota = 6.5M;
        Alumnos A7; A7.Nombre = "Juan"; A7.Sexo = 'H'; A7.Nota = 7.5M;
        var alumnos = new[] { A1, A2, A3, A4, A5, A6, A7 };
        decimal media=0;
        for (int i = 0; i < alumnos.Length; i++)
        {
            media+=alumnos[i].Nota;
        }
        Console.WriteLine("La media de la clase es de " +media/alumnos.Length);
    }
}