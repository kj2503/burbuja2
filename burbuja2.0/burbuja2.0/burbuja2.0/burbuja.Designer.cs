namespace app_de_ordenamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar numeros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simulacion de ordenamiento";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(38, 430);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2457, 817);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(12, 58);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tabPage1.Size = new System.Drawing.Size(2433, 747);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(1159, 157);
            this.BtnOrdenar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(238, 65);
            this.BtnOrdenar.TabIndex = 5;
            this.BtnOrdenar.Text = "Ordenar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(814, 157);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(238, 65);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(339, 162);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(308, 44);
            this.txtNumero.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::app_de_ordenamiento.Properties.Resources.darth_vader_icon_icons_com_76959_removebg_preview;
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnOrdenar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Darth-vader";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnOrdenar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
    }
}

