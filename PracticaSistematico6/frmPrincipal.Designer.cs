namespace PracticaSistematico6
{
    partial class frmPrincipal
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            txtEdad = new TextBox();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            txtNota1 = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dgvEstudiantes = new DataGridView();
            tabPage2 = new TabPage();
            label7 = new Label();
            cboOpcion = new ComboBox();
            txtBusqueda = new TextBox();
            dgvBusqueda = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(82, 26);
            tabControl1.Margin = new Padding(6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1330, 909);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtEdad);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtNota3);
            tabPage1.Controls.Add(txtNota2);
            tabPage1.Controls.Add(txtNota1);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(dgvEstudiantes);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(6);
            tabPage1.Size = new Size(1314, 855);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar Estudiantes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(903, 122);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 32);
            label6.TabIndex = 13;
            label6.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(888, 203);
            txtEdad.Margin = new Padding(6);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(82, 39);
            txtEdad.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1047, 207);
            btnAgregar.Margin = new Padding(6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 49);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(778, 130);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 10;
            label5.Text = "Nota 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 130);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 9;
            label4.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 126);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 8;
            label3.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 130);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 126);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(758, 211);
            txtNota3.Margin = new Padding(6);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(95, 39);
            txtNota3.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(624, 211);
            txtNota2.Margin = new Padding(6);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(99, 39);
            txtNota2.TabIndex = 4;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(475, 211);
            txtNota1.Margin = new Padding(6);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(112, 39);
            txtNota1.TabIndex = 3;
            txtNota1.KeyPress += txtNota1_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(258, 211);
            txtApellido.Margin = new Padding(6);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 39);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 211);
            txtNombre.Margin = new Padding(6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 39);
            txtNombre.TabIndex = 1;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(35, 361);
            dgvEstudiantes.Margin = new Padding(6);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 82;
            dgvEstudiantes.RowTemplate.Height = 25;
            dgvEstudiantes.Size = new Size(1246, 365);
            dgvEstudiantes.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(cboOpcion);
            tabPage2.Controls.Add(txtBusqueda);
            tabPage2.Controls.Add(dgvBusqueda);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(6);
            tabPage2.Size = new Size(1314, 855);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Busqueda";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 99);
            label7.Name = "label7";
            label7.Size = new Size(119, 32);
            label7.TabIndex = 3;
            label7.Text = "Busqueda";
            // 
            // cboOpcion
            // 
            cboOpcion.FormattingEnabled = true;
            cboOpcion.Location = new Point(527, 167);
            cboOpcion.Name = "cboOpcion";
            cboOpcion.Size = new Size(213, 40);
            cboOpcion.TabIndex = 2;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(103, 170);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(355, 39);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.KeyDown += txtBusqueda_KeyDown;
            // 
            // dgvBusqueda
            // 
            dgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBusqueda.Location = new Point(35, 307);
            dgvBusqueda.Name = "dgvBusqueda";
            dgvBusqueda.RowHeadersWidth = 82;
            dgvBusqueda.RowTemplate.Height = 41;
            dgvBusqueda.Size = new Size(1242, 400);
            dgvBusqueda.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(tabControl1);
            Margin = new Padding(6);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private TextBox txtNota1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DataGridView dgvEstudiantes;
        private Button btnAgregar;
        private Label label6;
        private TextBox txtEdad;
        private Label label7;
        private ComboBox cboOpcion;
        private TextBox txtBusqueda;
        private DataGridView dgvBusqueda;
    }
}