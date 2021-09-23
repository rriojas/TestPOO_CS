
namespace TestPOO_CS
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.  
    /// a menos que sepa lo que esta haciendo
    /// </summary>
    private void InitializeComponent()
    {
      this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
      this.btnTest = new System.Windows.Forms.Button();
      this.txtMatricula = new System.Windows.Forms.TextBox();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.lblMatricula = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // dtpFechaNacimiento
      // 
      this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaNacimiento.Location = new System.Drawing.Point(931, 192);
      this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
      this.dtpFechaNacimiento.Size = new System.Drawing.Size(267, 45);
      this.dtpFechaNacimiento.TabIndex = 4;
      // 
      // btnTest
      // 
      this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTest.Location = new System.Drawing.Point(919, 301);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(307, 144);
      this.btnTest.TabIndex = 5;
      this.btnTest.Text = "Test";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // txtMatricula
      // 
      this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMatricula.Location = new System.Drawing.Point(931, 48);
      this.txtMatricula.Name = "txtMatricula";
      this.txtMatricula.Size = new System.Drawing.Size(267, 45);
      this.txtMatricula.TabIndex = 6;
      // 
      // txtNombre
      // 
      this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNombre.Location = new System.Drawing.Point(931, 122);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(267, 45);
      this.txtNombre.TabIndex = 7;
      // 
      // lblMatricula
      // 
      this.lblMatricula.AutoSize = true;
      this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMatricula.Location = new System.Drawing.Point(745, 48);
      this.lblMatricula.Name = "lblMatricula";
      this.lblMatricula.Size = new System.Drawing.Size(164, 39);
      this.lblMatricula.TabIndex = 8;
      this.lblMatricula.Text = "Matricula:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(762, 122);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(147, 39);
      this.label1.TabIndex = 9;
      this.label1.Text = "Nombre:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1592, 849);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblMatricula);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.txtMatricula);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.dtpFechaNacimiento);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.TextBox txtMatricula;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblMatricula;
    private System.Windows.Forms.Label label1;
  }
}

