
using ConsoleApp3;

Ciudadano c;

List<Ciudadano> ciudadanos = new List<Ciudadano>();
c = new("ADSFASD4532", "AMERICA", "LOPEZ", "PEREZ", 10);
ciudadanos.Add(c);

var menoresEdad = from menor in ciudadanos
                  where menor.edad < 18
                  select menor;

foreach(Ciudadano ciudadano in menoresEdad)
{
  Console.WriteLine("CURP: {0} NOMBRE: {1} EDAD {2}", 
    ciudadano.curp, ciudadano.nombre, ciudadano.edad);
}


