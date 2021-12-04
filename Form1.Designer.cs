
namespace GestionDeVacunacion
{
    partial class Form_GDV
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GDV));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Dni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_TipoDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_provincia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_CodigoPostal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Calle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Otro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_Telefono_Emer = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_Registrar = new System.Windows.Forms.PictureBox();
            this.dataGridView_Vacunados = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Registrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vacunados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(69, 24);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(132, 23);
            this.textBox_Nombre.TabIndex = 1;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(271, 24);
            this.textBox_Apellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(138, 23);
            this.textBox_Apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // textBox_Dni
            // 
            this.textBox_Dni.Location = new System.Drawing.Point(457, 24);
            this.textBox_Dni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Dni.Name = "textBox_Dni";
            this.textBox_Dni.Size = new System.Drawing.Size(210, 23);
            this.textBox_Dni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI:";
            // 
            // comboBox_TipoDoc
            // 
            this.comboBox_TipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_TipoDoc.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "LC",
            "LE"});
            this.comboBox_TipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TipoDoc.FormattingEnabled = true;
            this.comboBox_TipoDoc.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.comboBox_TipoDoc.Location = new System.Drawing.Point(676, 24);
            this.comboBox_TipoDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_TipoDoc.Name = "comboBox_TipoDoc";
            this.comboBox_TipoDoc.Size = new System.Drawing.Size(56, 23);
            this.comboBox_TipoDoc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono Emergencia:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_Email.Location = new System.Drawing.Point(533, 59);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(181, 23);
            this.textBox_Email.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail:";
            // 
            // textBox_provincia
            // 
            this.textBox_provincia.Location = new System.Drawing.Point(69, 89);
            this.textBox_provincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_provincia.Name = "textBox_provincia";
            this.textBox_provincia.Size = new System.Drawing.Size(132, 23);
            this.textBox_provincia.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Provincia:";
            // 
            // textBox_ciudad
            // 
            this.textBox_ciudad.Location = new System.Drawing.Point(271, 89);
            this.textBox_ciudad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(132, 23);
            this.textBox_ciudad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ciudad:";
            // 
            // textBox_CodigoPostal
            // 
            this.textBox_CodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_CodigoPostal.Location = new System.Drawing.Point(449, 89);
            this.textBox_CodigoPostal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_CodigoPostal.Name = "textBox_CodigoPostal";
            this.textBox_CodigoPostal.Size = new System.Drawing.Size(76, 23);
            this.textBox_CodigoPostal.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "C.P:";
            // 
            // textBox_Calle
            // 
            this.textBox_Calle.Location = new System.Drawing.Point(69, 117);
            this.textBox_Calle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Calle.Name = "textBox_Calle";
            this.textBox_Calle.Size = new System.Drawing.Size(132, 23);
            this.textBox_Calle.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Calle:";
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(271, 117);
            this.textBox_Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(132, 23);
            this.textBox_Num.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Num:";
            // 
            // textBox_Otro
            // 
            this.textBox_Otro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_Otro.Location = new System.Drawing.Point(449, 117);
            this.textBox_Otro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Otro.Name = "textBox_Otro";
            this.textBox_Otro.Size = new System.Drawing.Size(265, 23);
            this.textBox_Otro.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Otro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.maskedTextBox_Telefono_Emer);
            this.groupBox1.Controls.Add(this.maskedTextBox_Telefono);
            this.groupBox1.Controls.Add(this.textBox_Otro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_Num);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_Calle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_CodigoPostal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_ciudad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_provincia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_TipoDoc);
            this.groupBox1.Controls.Add(this.textBox_Dni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(161, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(740, 152);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Vacunado";
            // 
            // maskedTextBox_Telefono_Emer
            // 
            this.maskedTextBox_Telefono_Emer.Location = new System.Drawing.Point(325, 59);
            this.maskedTextBox_Telefono_Emer.Mask = "(9999)00-0000";
            this.maskedTextBox_Telefono_Emer.Name = "maskedTextBox_Telefono_Emer";
            this.maskedTextBox_Telefono_Emer.Size = new System.Drawing.Size(131, 23);
            this.maskedTextBox_Telefono_Emer.TabIndex = 26;
            // 
            // maskedTextBox_Telefono
            // 
            this.maskedTextBox_Telefono.Location = new System.Drawing.Point(70, 59);
            this.maskedTextBox_Telefono.Mask = "(9999)00-0000";
            this.maskedTextBox_Telefono.Name = "maskedTextBox_Telefono";
            this.maskedTextBox_Telefono.Size = new System.Drawing.Size(131, 23);
            this.maskedTextBox_Telefono.TabIndex = 25;
            // 
            // pictureBox_Registrar
            // 
            this.pictureBox_Registrar.Image = global::GestionDeVacunacion.Properties.Resources.logo;
            this.pictureBox_Registrar.Location = new System.Drawing.Point(18, 60);
            this.pictureBox_Registrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox_Registrar.Name = "pictureBox_Registrar";
            this.pictureBox_Registrar.Size = new System.Drawing.Size(117, 112);
            this.pictureBox_Registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Registrar.TabIndex = 36;
            this.pictureBox_Registrar.TabStop = false;
            this.pictureBox_Registrar.Click += new System.EventHandler(this.pictureBox_Registrar_Click);
            // 
            // dataGridView_Vacunados
            // 
            this.dataGridView_Vacunados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Vacunados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vacunados.Location = new System.Drawing.Point(18, 312);
            this.dataGridView_Vacunados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_Vacunados.Name = "dataGridView_Vacunados";
            this.dataGridView_Vacunados.Size = new System.Drawing.Size(922, 207);
            this.dataGridView_Vacunados.TabIndex = 37;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_GDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.dataGridView_Vacunados);
            this.Controls.Add(this.pictureBox_Registrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_GDV";
            this.Text = "GDV-UTN";
            this.Load += new System.EventHandler(this.Form_GDV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Registrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vacunados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Dni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_TipoDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_provincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_CodigoPostal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Calle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Otro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_Registrar;
        private System.Windows.Forms.DataGridView dataGridView_Vacunados;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Telefono_Emer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Telefono;
    }
}

