namespace QuizApp
{
    partial class QuizForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnWord = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAll = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblSay = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnIpucu = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGetir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnWord);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(473, 337);
            this.panelControl1.TabIndex = 0;
            // 
            // btnWord
            // 
            this.btnWord.AllowFocus = false;
            this.btnWord.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnWord.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWord.Appearance.Options.UseBackColor = true;
            this.btnWord.Appearance.Options.UseFont = true;
            this.btnWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWord.Location = new System.Drawing.Point(2, 2);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(469, 333);
            this.btnWord.TabIndex = 0;
            this.btnWord.Text = "simpleButton1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panel2);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.textEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(473, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(502, 337);
            this.panelControl2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAll);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.lblSay);
            this.panel1.Location = new System.Drawing.Point(314, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 57);
            this.panel1.TabIndex = 5;
            // 
            // lblAll
            // 
            this.lblAll.Appearance.Font = new System.Drawing.Font("Tahoma", 28.2F);
            this.lblAll.Appearance.Options.UseFont = true;
            this.lblAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAll.Location = new System.Drawing.Point(43, 0);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(52, 57);
            this.lblAll.TabIndex = 4;
            this.lblAll.Text = "50";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 28.2F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl3.Location = new System.Drawing.Point(26, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 57);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "-";
            // 
            // lblSay
            // 
            this.lblSay.Appearance.Font = new System.Drawing.Font("Tahoma", 28.2F);
            this.lblSay.Appearance.Options.UseFont = true;
            this.lblSay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSay.Location = new System.Drawing.Point(0, 0);
            this.lblSay.Name = "lblSay";
            this.lblSay.Size = new System.Drawing.Size(26, 57);
            this.lblSay.TabIndex = 2;
            this.lblSay.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(301, 57);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "İlerleme/Soru:";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(4, 130);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Size = new System.Drawing.Size(491, 68);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyUp);
            // 
            // btnIpucu
            // 
            this.btnIpucu.AllowFocus = false;
            this.btnIpucu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnIpucu.Appearance.Options.UseBackColor = true;
            this.btnIpucu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIpucu.Location = new System.Drawing.Point(0, 0);
            this.btnIpucu.Name = "btnIpucu";
            this.btnIpucu.Size = new System.Drawing.Size(79, 61);
            this.btnIpucu.TabIndex = 6;
            this.btnIpucu.Text = "İpucu";
            this.btnIpucu.Click += new System.EventHandler(this.btnIpucu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGetir);
            this.panel2.Controls.Add(this.btnIpucu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 61);
            this.panel2.TabIndex = 8;
            // 
            // btnGetir
            // 
            this.btnGetir.AllowFocus = false;
            this.btnGetir.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnGetir.Appearance.Options.UseBackColor = true;
            this.btnGetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetir.Location = new System.Drawing.Point(79, 0);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnGetir.Size = new System.Drawing.Size(419, 61);
            this.btnGetir.TabIndex = 7;
            this.btnGetir.Visible = false;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 337);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnWord;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblSay;
        private DevExpress.XtraEditors.LabelControl lblAll;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnIpucu;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnGetir;
    }
}