namespace JSUtilidades
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
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHr = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtMedidas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmb = new System.Windows.Forms.TextBox();
            this.txtkb = new System.Windows.Forms.TextBox();
            this.txtgb = new System.Windows.Forms.TextBox();
            this.txttb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMb = new System.Windows.Forms.Label();
            this.lblKb = new System.Windows.Forms.Label();
            this.lblGb = new System.Windows.Forms.Label();
            this.lblTb = new System.Windows.Forms.Label();
            this.cboMedidas = new System.Windows.Forms.ComboBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 331);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtBinario);
            this.tabPage1.Controls.Add(this.cboMedidas);
            this.tabPage1.Controls.Add(this.lblTb);
            this.tabPage1.Controls.Add(this.lblGb);
            this.tabPage1.Controls.Add(this.lblKb);
            this.tabPage1.Controls.Add(this.lblMb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txttb);
            this.tabPage1.Controls.Add(this.txtgb);
            this.tabPage1.Controls.Add(this.txtkb);
            this.tabPage1.Controls.Add(this.txtmb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMedidas);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medidas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblHr});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(409, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(238, 18);
            this.toolStripStatusLabel1.Text = " Desenvolvido por:  João Victor Souza";
            // 
            // lblHr
            // 
            this.lblHr.Margin = new System.Windows.Forms.Padding(0, 3, 0, 5);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(0, 15);
            // 
            // txtMedidas
            // 
            this.txtMedidas.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedidas.Location = new System.Drawing.Point(123, 66);
            this.txtMedidas.Name = "txtMedidas";
            this.txtMedidas.Size = new System.Drawing.Size(139, 23);
            this.txtMedidas.TabIndex = 0;
            this.txtMedidas.Text = "0";
            this.txtMedidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMedidas.TextChanged += new System.EventHandler(this.txtMedidas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor:";
            // 
            // txtmb
            // 
            this.txtmb.BackColor = System.Drawing.Color.White;
            this.txtmb.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmb.HideSelection = false;
            this.txtmb.Location = new System.Drawing.Point(44, 158);
            this.txtmb.Name = "txtmb";
            this.txtmb.ReadOnly = true;
            this.txtmb.Size = new System.Drawing.Size(100, 23);
            this.txtmb.TabIndex = 2;
            this.txtmb.Text = "0";
            this.txtmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtkb
            // 
            this.txtkb.BackColor = System.Drawing.Color.White;
            this.txtkb.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtkb.HideSelection = false;
            this.txtkb.Location = new System.Drawing.Point(44, 129);
            this.txtkb.Name = "txtkb";
            this.txtkb.ReadOnly = true;
            this.txtkb.Size = new System.Drawing.Size(100, 23);
            this.txtkb.TabIndex = 3;
            this.txtkb.Text = "0";
            this.txtkb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtgb
            // 
            this.txtgb.BackColor = System.Drawing.Color.White;
            this.txtgb.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgb.HideSelection = false;
            this.txtgb.Location = new System.Drawing.Point(44, 187);
            this.txtgb.Name = "txtgb";
            this.txtgb.ReadOnly = true;
            this.txtgb.Size = new System.Drawing.Size(100, 23);
            this.txtgb.TabIndex = 4;
            this.txtgb.Text = "0";
            this.txtgb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttb
            // 
            this.txttb.BackColor = System.Drawing.Color.White;
            this.txttb.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttb.HideSelection = false;
            this.txttb.Location = new System.Drawing.Point(44, 216);
            this.txttb.Name = "txttb";
            this.txttb.ReadOnly = true;
            this.txttb.Size = new System.Drawing.Size(100, 23);
            this.txttb.TabIndex = 5;
            this.txttb.Text = "0";
            this.txttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conversor de Bytes";
            // 
            // lblMb
            // 
            this.lblMb.AutoSize = true;
            this.lblMb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMb.Location = new System.Drawing.Point(150, 158);
            this.lblMb.Name = "lblMb";
            this.lblMb.Size = new System.Drawing.Size(130, 23);
            this.lblMb.TabIndex = 7;
            this.lblMb.Text = "Mb  ( formula )";
            // 
            // lblKb
            // 
            this.lblKb.AutoSize = true;
            this.lblKb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKb.Location = new System.Drawing.Point(150, 129);
            this.lblKb.Name = "lblKb";
            this.lblKb.Size = new System.Drawing.Size(178, 23);
            this.lblKb.TabIndex = 8;
            this.lblKb.Text = "Kilobytes  ( formula )";
            // 
            // lblGb
            // 
            this.lblGb.AutoSize = true;
            this.lblGb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGb.Location = new System.Drawing.Point(150, 187);
            this.lblGb.Name = "lblGb";
            this.lblGb.Size = new System.Drawing.Size(183, 23);
            this.lblGb.TabIndex = 9;
            this.lblGb.Text = "Gigabytes  ( formula )";
            // 
            // lblTb
            // 
            this.lblTb.AutoSize = true;
            this.lblTb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTb.Location = new System.Drawing.Point(150, 216);
            this.lblTb.Name = "lblTb";
            this.lblTb.Size = new System.Drawing.Size(183, 23);
            this.lblTb.TabIndex = 10;
            this.lblTb.Text = "Terabytes  ( formula )";
            // 
            // cboMedidas
            // 
            this.cboMedidas.DisplayMember = "MB";
            this.cboMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboMedidas.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMedidas.FormattingEnabled = true;
            this.cboMedidas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboMedidas.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cboMedidas.Location = new System.Drawing.Point(268, 66);
            this.cboMedidas.Name = "cboMedidas";
            this.cboMedidas.Size = new System.Drawing.Size(51, 23);
            this.cboMedidas.TabIndex = 11;
            this.cboMedidas.ValueMember = "MB";
            this.cboMedidas.SelectedValueChanged += new System.EventHandler(this.cboMedidas_SelectedValueChanged);
            this.cboMedidas.TextChanged += new System.EventHandler(this.cboMedidas_SelectedValueChanged);
            // 
            // txtBinario
            // 
            this.txtBinario.BackColor = System.Drawing.Color.White;
            this.txtBinario.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinario.HideSelection = false;
            this.txtBinario.Location = new System.Drawing.Point(44, 245);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.ReadOnly = true;
            this.txtBinario.Size = new System.Drawing.Size(100, 23);
            this.txtBinario.TabIndex = 12;
            this.txtBinario.Text = "01101101";
            this.txtBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Binários";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 355);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSUtilidades - Solução de Utilidades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblHr;
        private System.Windows.Forms.ComboBox cboMedidas;
        private System.Windows.Forms.Label lblTb;
        private System.Windows.Forms.Label lblGb;
        private System.Windows.Forms.Label lblKb;
        private System.Windows.Forms.Label lblMb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttb;
        private System.Windows.Forms.TextBox txtgb;
        private System.Windows.Forms.TextBox txtkb;
        private System.Windows.Forms.TextBox txtmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMedidas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Timer timer;
    }
}

