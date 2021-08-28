
namespace Ejercicio_Formuarios
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Agg_Alumnolbl = new System.Windows.Forms.Label();
            this.Nombre_TextBox = new System.Windows.Forms.TextBox();
            this.ApellidoPaterno_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ApellidoMaterno_TextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DataGridAlumno = new System.Windows.Forms.DataGridView();
            this.Name_search = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // Agg_Alumnolbl
            // 
            this.Agg_Alumnolbl.AutoSize = true;
            this.Agg_Alumnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agg_Alumnolbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Agg_Alumnolbl.Location = new System.Drawing.Point(12, 39);
            this.Agg_Alumnolbl.Name = "Agg_Alumnolbl";
            this.Agg_Alumnolbl.Size = new System.Drawing.Size(219, 31);
            this.Agg_Alumnolbl.TabIndex = 0;
            this.Agg_Alumnolbl.Text = "Agregar alumno";
            this.Agg_Alumnolbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre_TextBox
            // 
            this.Nombre_TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_TextBox.Location = new System.Drawing.Point(18, 120);
            this.Nombre_TextBox.Name = "Nombre_TextBox";
            this.Nombre_TextBox.Size = new System.Drawing.Size(231, 32);
            this.Nombre_TextBox.TabIndex = 1;
            // 
            // ApellidoPaterno_TextBox
            // 
            this.ApellidoPaterno_TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoPaterno_TextBox.Location = new System.Drawing.Point(274, 120);
            this.ApellidoPaterno_TextBox.Name = "ApellidoPaterno_TextBox";
            this.ApellidoPaterno_TextBox.Size = new System.Drawing.Size(231, 32);
            this.ApellidoPaterno_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido Materno";
            // 
            // ApellidoMaterno_TextBox
            // 
            this.ApellidoMaterno_TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoMaterno_TextBox.Location = new System.Drawing.Point(18, 206);
            this.ApellidoMaterno_TextBox.Name = "ApellidoMaterno_TextBox";
            this.ApellidoMaterno_TextBox.Size = new System.Drawing.Size(231, 32);
            this.ApellidoMaterno_TextBox.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(274, 210);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 28);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(375, 210);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(80, 28);
            this.CleanButton.TabIndex = 8;
            this.CleanButton.Text = "Limpiar";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(12, 302);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(493, 32);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DataGridAlumno
            // 
            this.DataGridAlumno.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_search,
            this.Ap_Paterno,
            this.Ap_Materno});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridAlumno.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridAlumno.Location = new System.Drawing.Point(12, 340);
            this.DataGridAlumno.Name = "DataGridAlumno";
            this.DataGridAlumno.Size = new System.Drawing.Size(493, 297);
            this.DataGridAlumno.TabIndex = 11;
            // 
            // Name_search
            // 
            this.Name_search.Frozen = true;
            this.Name_search.HeaderText = "Nombre";
            this.Name_search.Name = "Name_search";
            this.Name_search.ReadOnly = true;
            this.Name_search.Width = 155;
            // 
            // Ap_Paterno
            // 
            this.Ap_Paterno.Frozen = true;
            this.Ap_Paterno.HeaderText = "Apellido Paterno";
            this.Ap_Paterno.Name = "Ap_Paterno";
            this.Ap_Paterno.ReadOnly = true;
            this.Ap_Paterno.Width = 155;
            // 
            // Ap_Materno
            // 
            this.Ap_Materno.Frozen = true;
            this.Ap_Materno.HeaderText = "Apellido Materno";
            this.Ap_Materno.Name = "Ap_Materno";
            this.Ap_Materno.ReadOnly = true;
            this.Ap_Materno.Width = 155;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 661);
            this.Controls.Add(this.DataGridAlumno);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ApellidoMaterno_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApellidoPaterno_TextBox);
            this.Controls.Add(this.Nombre_TextBox);
            this.Controls.Add(this.Agg_Alumnolbl);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Agg_Alumnolbl;
        private System.Windows.Forms.TextBox Nombre_TextBox;
        private System.Windows.Forms.TextBox ApellidoPaterno_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApellidoMaterno_TextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView DataGridAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap_Materno;
    }
}

