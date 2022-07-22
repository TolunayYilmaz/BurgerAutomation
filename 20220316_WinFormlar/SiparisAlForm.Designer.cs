
namespace _20220316_WinFormlar
{
    partial class SiparisAlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisAlForm));
            this.hamburgerAdet = new System.Windows.Forms.NumericUpDown();
            this.fiyatLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sprsVerBtn = new System.Windows.Forms.Button();
            this.SosPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BoyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SiparisKydtBtn = new System.Windows.Forms.Button();
            this.HamburgerBox = new System.Windows.Forms.ComboBox();
            this.tutarLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hamburgerAdet
            // 
            this.hamburgerAdet.Location = new System.Drawing.Point(37, 411);
            this.hamburgerAdet.Name = "hamburgerAdet";
            this.hamburgerAdet.Size = new System.Drawing.Size(244, 20);
            this.hamburgerAdet.TabIndex = 70;
            // 
            // fiyatLbl
            // 
            this.fiyatLbl.AutoSize = true;
            this.fiyatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatLbl.Location = new System.Drawing.Point(475, 374);
            this.fiyatLbl.Name = "fiyatLbl";
            this.fiyatLbl.Size = new System.Drawing.Size(0, 20);
            this.fiyatLbl.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(322, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Toplam Tutar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(311, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(680, 134);
            this.listBox1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Menü Seçin";
            // 
            // sprsVerBtn
            // 
            this.sprsVerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sprsVerBtn.Location = new System.Drawing.Point(41, 437);
            this.sprsVerBtn.Name = "sprsVerBtn";
            this.sprsVerBtn.Size = new System.Drawing.Size(184, 41);
            this.sprsVerBtn.TabIndex = 63;
            this.sprsVerBtn.Text = "Sipariş Ver";
            this.sprsVerBtn.UseVisualStyleBackColor = true;
            this.sprsVerBtn.Click += new System.EventHandler(this.sprsVerBtn_Click);
            // 
            // SosPanel
            // 
            this.SosPanel.Location = new System.Drawing.Point(43, 298);
            this.SosPanel.Name = "SosPanel";
            this.SosPanel.Size = new System.Drawing.Size(205, 73);
            this.SosPanel.TabIndex = 74;
            // 
            // BoyPanel
            // 
            this.BoyPanel.Location = new System.Drawing.Point(43, 220);
            this.BoyPanel.Name = "BoyPanel";
            this.BoyPanel.Size = new System.Drawing.Size(200, 56);
            this.BoyPanel.TabIndex = 75;
            // 
            // SiparisKydtBtn
            // 
            this.SiparisKydtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparisKydtBtn.Location = new System.Drawing.Point(596, 437);
            this.SiparisKydtBtn.Name = "SiparisKydtBtn";
            this.SiparisKydtBtn.Size = new System.Drawing.Size(184, 41);
            this.SiparisKydtBtn.TabIndex = 76;
            this.SiparisKydtBtn.Text = "Sipariş Kaydet";
            this.SiparisKydtBtn.UseVisualStyleBackColor = true;
            this.SiparisKydtBtn.Click += new System.EventHandler(this.SiparisKydtBtn_Click);
            // 
            // HamburgerBox
            // 
            this.HamburgerBox.FormattingEnabled = true;
            this.HamburgerBox.Location = new System.Drawing.Point(41, 183);
            this.HamburgerBox.Name = "HamburgerBox";
            this.HamburgerBox.Size = new System.Drawing.Size(202, 21);
            this.HamburgerBox.TabIndex = 77;
            // 
            // tutarLbl
            // 
            this.tutarLbl.AutoSize = true;
            this.tutarLbl.Location = new System.Drawing.Point(467, 464);
            this.tutarLbl.Name = "tutarLbl";
            this.tutarLbl.Size = new System.Drawing.Size(13, 13);
            this.tutarLbl.TabIndex = 78;
            this.tutarLbl.Text = "0";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(311, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(693, 402);
            this.listView1.TabIndex = 79;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // SiparisAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 598);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tutarLbl);
            this.Controls.Add(this.HamburgerBox);
            this.Controls.Add(this.SiparisKydtBtn);
            this.Controls.Add(this.BoyPanel);
            this.Controls.Add(this.SosPanel);
            this.Controls.Add(this.hamburgerAdet);
            this.Controls.Add(this.fiyatLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sprsVerBtn);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SiparisAlForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SiparişAlForm";
            this.Load += new System.EventHandler(this.SiparişAlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown hamburgerAdet;
        private System.Windows.Forms.Label fiyatLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sprsVerBtn;
        private System.Windows.Forms.FlowLayoutPanel SosPanel;
        private System.Windows.Forms.FlowLayoutPanel BoyPanel;
        private System.Windows.Forms.Button SiparisKydtBtn;
        private System.Windows.Forms.ComboBox HamburgerBox;
        private System.Windows.Forms.Label tutarLbl;
        private System.Windows.Forms.ListView listView1;
    }
}