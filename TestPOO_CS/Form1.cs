using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPOO_CS
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      //Variables - Tipo de dato
      int entero = -3;
      double real = 3.1415;
      char caracter = 'x';
      bool booleano = true;
      long numeroLargo = 34342321231231231;
      decimal numeroDecimal = (decimal)3.421312312;
      float numeroFlotante = (float)4.5512312;
      string cadena = "hola";
      uint enteroPositivos = 5;

      // Crear un obj del tipo de la clase Alumno
      Alumno angel;
      string nombre, matricula, fechaNacimiento;
      nombre = txtNombre.Text;
      matricula = txtMatricula.Text;
      fechaNacimiento = dtpFechaNacimiento.Text;
      angel = new Alumno(matricula,nombre, fechaNacimiento);
      MessageBox.Show(angel.ToString());

    }
  }
}
