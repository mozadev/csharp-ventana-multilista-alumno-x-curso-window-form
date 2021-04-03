namespace multilistasAlumnosxCurso
{
    partial class frmEliminarCursocs
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
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbcursos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresarAlumno = new System.Windows.Forms.Button();
            this.txtTIU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(39, 163);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 33);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lbcursos
            // 
            this.lbcursos.FormattingEnabled = true;
            this.lbcursos.Location = new System.Drawing.Point(341, 88);
            this.lbcursos.Name = "lbcursos";
            this.lbcursos.Size = new System.Drawing.Size(183, 277);
            this.lbcursos.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "cursos";
            // 
            // btnIngresarAlumno
            // 
            this.btnIngresarAlumno.Location = new System.Drawing.Point(39, 114);
            this.btnIngresarAlumno.Name = "btnIngresarAlumno";
            this.btnIngresarAlumno.Size = new System.Drawing.Size(100, 23);
            this.btnIngresarAlumno.TabIndex = 18;
            this.btnIngresarAlumno.Text = "matricula";
            this.btnIngresarAlumno.UseVisualStyleBackColor = true;
            // 
            // txtTIU
            // 
            this.txtTIU.Location = new System.Drawing.Point(39, 70);
            this.txtTIU.Name = "txtTIU";
            this.txtTIU.Size = new System.Drawing.Size(163, 20);
            this.txtTIU.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "codigo del curso";
            // 
            // frmEliminarCursocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 462);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbcursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIngresarAlumno);
            this.Controls.Add(this.txtTIU);
            this.Controls.Add(this.label1);
            this.Name = "frmEliminarCursocs";
            this.Text = "frmEliminarCursocs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lbcursos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresarAlumno;
        private System.Windows.Forms.TextBox txtTIU;
        private System.Windows.Forms.Label label1;
    }
}