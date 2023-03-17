
namespace POOTriangulo.Windows
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.TrianguloDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RestaurarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GuardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CerrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CantidadPanel = new System.Windows.Forms.Panel();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColLadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLadoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLadoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrianguloDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.CantidadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaPanel
            // 
            this.GrillaPanel.Controls.Add(this.TrianguloDataGridView);
            this.GrillaPanel.Location = new System.Drawing.Point(0, 61);
            this.GrillaPanel.Name = "GrillaPanel";
            this.GrillaPanel.Size = new System.Drawing.Size(747, 348);
            this.GrillaPanel.TabIndex = 0;
            // 
            // TrianguloDataGridView
            // 
            this.TrianguloDataGridView.AllowUserToAddRows = false;
            this.TrianguloDataGridView.AllowUserToDeleteRows = false;
            this.TrianguloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrianguloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLadoA,
            this.ColLadoB,
            this.ColLadoC,
            this.ColArea,
            this.ColPerimetro,
            this.ColRelleno,
            this.ColTrazo});
            this.TrianguloDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrianguloDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TrianguloDataGridView.MultiSelect = false;
            this.TrianguloDataGridView.Name = "TrianguloDataGridView";
            this.TrianguloDataGridView.ReadOnly = true;
            this.TrianguloDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrianguloDataGridView.Size = new System.Drawing.Size(747, 348);
            this.TrianguloDataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.EditarToolStripButton,
            this.BorrarToolStripButton,
            this.toolStripSeparator1,
            this.FiltarToolStripButton,
            this.RestaurarToolStripButton,
            this.toolStripSeparator3,
            this.GuardarToolStripButton,
            this.toolStripSeparator2,
            this.CerrarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 58);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::POOTriangulo.Windows.Properties.Resources.add_file_36px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::POOTriangulo.Windows.Properties.Resources.edit_property_36px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::POOTriangulo.Windows.Properties.Resources.delete_file_36px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // FiltarToolStripButton
            // 
            this.FiltarToolStripButton.Image = global::POOTriangulo.Windows.Properties.Resources.filled_filter_36px;
            this.FiltarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltarToolStripButton.Name = "FiltarToolStripButton";
            this.FiltarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.FiltarToolStripButton.Text = "Filtrar";
            this.FiltarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // RestaurarToolStripButton
            // 
            this.RestaurarToolStripButton.Image = global::POOTriangulo.Windows.Properties.Resources.refresh_36px;
            this.RestaurarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RestaurarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestaurarToolStripButton.Name = "RestaurarToolStripButton";
            this.RestaurarToolStripButton.Size = new System.Drawing.Size(60, 55);
            this.RestaurarToolStripButton.Text = "Restaurar";
            this.RestaurarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            // 
            // GuardarToolStripButton
            // 
            this.GuardarToolStripButton.Image = global::POOTriangulo.Windows.Properties.Resources.save_36px;
            this.GuardarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarToolStripButton.Name = "GuardarToolStripButton";
            this.GuardarToolStripButton.Size = new System.Drawing.Size(53, 55);
            this.GuardarToolStripButton.Text = "Guardar";
            this.GuardarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarToolStripButton.Click += new System.EventHandler(this.GuardarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // CerrarToolStripButton
            // 
            this.CerrarToolStripButton.Image = global::POOTriangulo.Windows.Properties.Resources.exit_36px;
            this.CerrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CerrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CerrarToolStripButton.Name = "CerrarToolStripButton";
            this.CerrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.CerrarToolStripButton.Text = "Cerrar";
            this.CerrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrarToolStripButton.Click += new System.EventHandler(this.CerrarToolStripButton_Click);
            // 
            // CantidadPanel
            // 
            this.CantidadPanel.Controls.Add(this.CantidadLabel);
            this.CantidadPanel.Controls.Add(this.label1);
            this.CantidadPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CantidadPanel.Location = new System.Drawing.Point(0, 415);
            this.CantidadPanel.Name = "CantidadPanel";
            this.CantidadPanel.Size = new System.Drawing.Size(752, 35);
            this.CantidadPanel.TabIndex = 2;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Location = new System.Drawing.Point(65, 10);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(13, 13);
            this.CantidadLabel.TabIndex = 0;
            this.CantidadLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad:";
            // 
            // ColLadoA
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            this.ColLadoA.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColLadoA.HeaderText = "Lado A";
            this.ColLadoA.Name = "ColLadoA";
            this.ColLadoA.ReadOnly = true;
            // 
            // ColLadoB
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColLadoB.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColLadoB.HeaderText = "Lado B";
            this.ColLadoB.Name = "ColLadoB";
            this.ColLadoB.ReadOnly = true;
            // 
            // ColLadoC
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColLadoC.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColLadoC.HeaderText = "Lado C";
            this.ColLadoC.Name = "ColLadoC";
            this.ColLadoC.ReadOnly = true;
            // 
            // ColArea
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColArea.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColArea.HeaderText = "Area";
            this.ColArea.Name = "ColArea";
            this.ColArea.ReadOnly = true;
            // 
            // ColPerimetro
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColPerimetro.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColPerimetro.HeaderText = "Perimetro";
            this.ColPerimetro.Name = "ColPerimetro";
            this.ColPerimetro.ReadOnly = true;
            // 
            // ColRelleno
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColRelleno.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColRelleno.HeaderText = "Relleno";
            this.ColRelleno.Name = "ColRelleno";
            this.ColRelleno.ReadOnly = true;
            // 
            // ColTrazo
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColTrazo.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColTrazo.HeaderText = "Trazo";
            this.ColTrazo.Name = "ColTrazo";
            this.ColTrazo.ReadOnly = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CantidadPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GrillaPanel);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.GrillaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrianguloDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CantidadPanel.ResumeLayout(false);
            this.CantidadPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GrillaPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.Panel CantidadPanel;
        private System.Windows.Forms.DataGridView TrianguloDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton FiltarToolStripButton;
        private System.Windows.Forms.ToolStripButton RestaurarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CerrarToolStripButton;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton GuardarToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLadoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLadoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLadoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrazo;
    }
}