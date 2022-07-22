
namespace _20220316_WinFormlar
{
    partial class MenüEkleForm
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
            this.gecBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuEkleTxt = new System.Windows.Forms.TextBox();
            this.MenuFiyatEkleNum = new System.Windows.Forms.NumericUpDown();
            this.MenuEkleBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuFiyatEkleNum)).BeginInit();
            this.MenuEkleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gecBtn
            // 
            this.gecBtn.Location = new System.Drawing.Point(60, 108);
            this.gecBtn.Name = "gecBtn";
            this.gecBtn.Size = new System.Drawing.Size(107, 38);
            this.gecBtn.TabIndex = 0;
            this.gecBtn.Text = "Kaydet";
            this.gecBtn.UseVisualStyleBackColor = true;
            this.gecBtn.Click += new System.EventHandler(this.gecBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menü Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fiyat:";
            // 
            // MenuEkleTxt
            // 
            this.MenuEkleTxt.Location = new System.Drawing.Point(92, 28);
            this.MenuEkleTxt.Name = "MenuEkleTxt";
            this.MenuEkleTxt.Size = new System.Drawing.Size(100, 20);
            this.MenuEkleTxt.TabIndex = 4;
            // 
            // MenuFiyatEkleNum
            // 
            this.MenuFiyatEkleNum.Location = new System.Drawing.Point(92, 58);
            this.MenuFiyatEkleNum.Name = "MenuFiyatEkleNum";
            this.MenuFiyatEkleNum.Size = new System.Drawing.Size(100, 20);
            this.MenuFiyatEkleNum.TabIndex = 5;
            // 
            // MenuEkleBox
            // 
            this.MenuEkleBox.Controls.Add(this.label2);
            this.MenuEkleBox.Controls.Add(this.gecBtn);
            this.MenuEkleBox.Controls.Add(this.MenuFiyatEkleNum);
            this.MenuEkleBox.Controls.Add(this.label3);
            this.MenuEkleBox.Controls.Add(this.MenuEkleTxt);
            this.MenuEkleBox.Location = new System.Drawing.Point(52, 44);
            this.MenuEkleBox.Name = "MenuEkleBox";
            this.MenuEkleBox.Size = new System.Drawing.Size(247, 176);
            this.MenuEkleBox.TabIndex = 6;
            this.MenuEkleBox.TabStop = false;
            this.MenuEkleBox.Text = "Menü Ekle";
            this.MenuEkleBox.Enter += new System.EventHandler(this.MenuEkleBox_Enter);
            // 
            // MenüEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuEkleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenüEkleForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenüEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuFiyatEkleNum)).EndInit();
            this.MenuEkleBox.ResumeLayout(false);
            this.MenuEkleBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gecBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MenuEkleTxt;
        private System.Windows.Forms.NumericUpDown MenuFiyatEkleNum;
        private System.Windows.Forms.GroupBox MenuEkleBox;
    }
}

