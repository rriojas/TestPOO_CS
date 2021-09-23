using System;

using System.Windows.Forms;

namespace TestPOO_CS
{
  class Alumno
  {
    //I21050329
    //Variables
    private string matricula;
    private string nombre;
    private string fechaNacimiento;
    //Propiedades
    public string FechaNacimiento
    {
      get
      {
        return fechaNacimiento;
      }
      set
      {
        fechaNacimiento = value;
      }
    }

    public string Nombre
    {
      get
      {
        return nombre;
      }
      set
      {
        nombre = value;
      }
    }

    public string Matricula
    {
      get
      {
        return matricula;
      }
      set
      {
        matricula = value;
      }
    }

    //Constructores Inicializa los valores de las vrs de la clase
    public Alumno()
    {
      matricula = "";
      nombre = "";
      fechaNacimiento = "";
    }
    public Alumno(string matricula, string nombre, string fechaNacimiento)
    {
      this.matricula = matricula;
      this.nombre = nombre;
      this.fechaNacimiento = fechaNacimiento;
    }

    public void Estudiar()
    {
      MessageBox.Show("Estudiando");
    }

    public override string ToString()
    {
      return matricula + " " + nombre + " " + fechaNacimiento;
    }

  }
}
