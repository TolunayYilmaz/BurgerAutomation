
namespace _20220316_WinFormlar
{
    partial class BabaMdiForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tümSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraMalzemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.ürünYönetimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişAlToolStripMenuItem,
            this.tümSiparişlerToolStripMenuItem});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişAlToolStripMenuItem
            // 
            this.siparişAlToolStripMenuItem.Name = "siparişAlToolStripMenuItem";
            this.siparişAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişAlToolStripMenuItem.Text = "Sipariş Al";
            this.siparişAlToolStripMenuItem.Click += new System.EventHandler(this.siparişAlToolStripMenuItem_Click);
            // 
            // ürünYönetimToolStripMenuItem
            // 
            this.ürünYönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüBilgiToolStripMenuItem,
            this.extraMalzemeToolStripMenuItem});
            this.ürünYönetimToolStripMenuItem.Name = "ürünYönetimToolStripMenuItem";
            this.ürünYönetimToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ürünYönetimToolStripMenuItem.Text = "Ürün Yönetim";
            // 
            // menüBilgiToolStripMenuItem
            // 
            this.menüBilgiToolStripMenuItem.Name = "menüBilgiToolStripMenuItem";
            this.menüBilgiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menüBilgiToolStripMenuItem.Text = "Menü Bilgi";
            this.menüBilgiToolStripMenuItem.Click += new System.EventHandler(this.menüBilgiToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1097, 628);
            this.flowLayoutPanel1.TabIndex = 23;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tümSiparişlerToolStripMenuItem
            // 
            this.tümSiparişlerToolStripMenuItem.Name = "tümSiparişlerToolStripMenuItem";
            this.tümSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tümSiparişlerToolStripMenuItem.Text = "Tüm Siparişler";
            this.tümSiparişlerToolStripMenuItem.Click += new System.EventHandler(this.tümSiparişlerToolStripMenuItem_Click_1);
            // 
            // extraMalzemeToolStripMenuItem
            // 
            this.extraMalzemeToolStripMenuItem.Name = "extraMalzemeToolStripMenuItem";
            this.extraMalzemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extraMalzemeToolStripMenuItem.Text = "Extra Malzeme";
            this.extraMalzemeToolStripMenuItem.Click += new System.EventHandler(this.extraMalzemeToolStripMenuItem_Click);
            // 
            // BabaMdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1097, 652);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "BabaMdiForm";
            this.Text = "BabaForm";
            this.Load += new System.EventHandler(this.BabaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüBilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişAlToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem tümSiparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraMalzemeToolStripMenuItem;
    }
}