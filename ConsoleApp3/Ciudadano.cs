using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  internal class Ciudadano
  {
    public string curp { get; }
    public string nombre { get; }
    public string apePat { get; }
    public string apeMat { get; }
    public int edad { get; }

    public Ciudadano(string curp, string nombre, string apePat, string apeMat, int edad)
    {
      this.curp = curp;
      this.nombre = nombre;
      this.apePat = apePat;
      this.apeMat = apeMat;
      this.edad = edad;
    }
  }
}
