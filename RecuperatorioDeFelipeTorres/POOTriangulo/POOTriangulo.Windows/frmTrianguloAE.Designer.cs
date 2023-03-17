
namespace POOTriangulo.Windows
{
    partial class frmTrianguloAE
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
            this.components = new System.ComponentModel.Container();
            this.CantidadPanel = new System.Windows.Forms.Panel();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LadoATextBox = new System.Windows.Forms.TextBox();
            this.RellenoComboBox = new System.Windows.Forms.ComboBox();
            this.ContinuoRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LadoBTextBox = new System.Windows.Forms.TextBox();
            this.LadoCTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PunteadoRadioButton = new System.Windows.Forms.RadioButton();
            this.RayasRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CantidadPanel
            // 
            this.CantidadPanel.Location = new System.Drawing.Point(0, 350);
            this.CantidadPanel.Name = "CantidadPanel";
            this.CantidadPanel.Size = new System.Drawing.Size(800, 100);
            this.CantidadPanel.TabIndex = 0;
            this.CantidadPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CantidadPanel_Paint);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(12, 252);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 1;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LadoATextBox
            // 
            this.LadoATextBox.Location = new System.Drawing.Point(76, 31);
            this.LadoATextBox.Name = "LadoATextBox";
            this.LadoATextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoATextBox.TabIndex = 4;
            // 
            // RellenoComboBox
            // 
            this.RellenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RellenoComboBox.FormattingEnabled = true;
            this.RellenoComboBox.Location = new System.Drawing.Point(76, 118);
            this.RellenoComboBox.Name = "RellenoComboBox";
            this.RellenoComboBox.Size = new System.Drawing.Size(100, 21);
            this.RellenoComboBox.TabIndex = 5;
            // 
            // ContinuoRadioButton
            // 
            this.ContinuoRadioButton.AutoSize = true;
            this.ContinuoRadioButton.Checked = true;
            this.ContinuoRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ContinuoRadioButton.Name = "ContinuoRadioButton";
            this.ContinuoRadioButton.Size = new System.Drawing.Size(67, 17);
            this.ContinuoRadioButton.TabIndex = 6;
            this.ContinuoRadioButton.TabStop = true;
            this.ContinuoRadioButton.Text = "Continuo";
            this.ContinuoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lado A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lado C";
            // 
            // LadoBTextBox
            // 
            this.LadoBTextBox.Location = new System.Drawing.Point(76, 57);
            this.LadoBTextBox.Name = "LadoBTextBox";
            this.LadoBTextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoBTextBox.TabIndex = 4;
            // 
            // LadoCTextBox
            // 
            this.LadoCTextBox.Location = new System.Drawing.Point(76, 83);
            this.LadoCTextBox.Name = "LadoCTextBox";
            this.LadoCTextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoCTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Relleno";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PunteadoRadioButton
            // 
            this.PunteadoRadioButton.AutoSize = true;
            this.PunteadoRadioButton.Location = new System.Drawing.Point(6, 42);
            this.PunteadoRadioButton.Name = "PunteadoRadioButton";
            this.PunteadoRadioButton.Size = new System.Drawing.Size(71, 17);
            this.PunteadoRadioButton.TabIndex = 6;
            this.PunteadoRadioButton.Text = "Punteado";
            this.PunteadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // RayasRadioButton
            // 
            this.RayasRadioButton.AutoSize = true;
            this.RayasRadioButton.Location = new System.Drawing.Point(6, 65);
            this.RayasRadioButton.Name = "RayasRadioButton";
            this.RayasRadioButton.Size = new System.Drawing.Size(55, 17);
            this.RayasRadioButton.TabIndex = 6;
            this.RayasRadioButton.Text = "Rayas";
            this.RayasRadioButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(136, 252);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContinuoRadioButton);
            this.groupBox1.Controls.Add(this.RayasRadioButton);
            this.groupBox1.Controls.Add(this.PunteadoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(32, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Trazo";
            // 
            // frmTrianguloAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RellenoComboBox);
            this.Controls.Add(this.LadoCTextBox);
            this.Controls.Add(this.LadoBTextBox);
            this.Controls.Add(this.LadoATextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.CantidadPanel);
            this.Name = "frmTrianguloAE";
            this.Text = "frmTrianguloAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CantidadPanel;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox LadoATextBox;
        private System.Windows.Forms.ComboBox RellenoComboBox;
        private System.Windows.Forms.RadioButton ContinuoRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LadoBTextBox;
        private System.Windows.Forms.TextBox LadoCTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PunteadoRadioButton;
        private System.Windows.Forms.RadioButton RayasRadioButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}