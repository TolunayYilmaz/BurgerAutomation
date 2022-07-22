
namespace _20220316_WinFormlar
{
    partial class ExtraMalzemeEkleForm
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
            this.extraMalzemeBox = new System.Windows.Forms.GroupBox();
            this.kydtBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SosFiyatiNmrc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SosAdiTxt = new System.Windows.Forms.TextBox();
            this.extraMalzemeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SosFiyatiNmrc)).BeginInit();
            this.SuspendLayout();
            // 
            // extraMalzemeBox
            // 
            this.extraMalzemeBox.Controls.Add(this.kydtBtn);
            this.extraMalzemeBox.Controls.Add(this.label2);
            this.extraMalzemeBox.Controls.Add(this.SosFiyatiNmrc);
            this.extraMalzemeBox.Controls.Add(this.label3);
            this.extraMalzemeBox.Controls.Add(this.SosAdiTxt);
            this.extraMalzemeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.extraMalzemeBox.Location = new System.Drawing.Point(40, 36);
            this.extraMalzemeBox.Name = "extraMalzemeBox";
            this.extraMalzemeBox.Size = new System.Drawing.Size(285, 166);
            this.extraMalzemeBox.TabIndex = 8;
            this.extraMalzemeBox.TabStop = false;
            this.extraMalzemeBox.Text = "Extra Malzeme Bilgisi";
            this.extraMalzemeBox.Enter += new System.EventHandler(this.extraMalzemeBox_Enter);
            // 
            // kydtBtn
            // 
            this.kydtBtn.Location = new System.Drawing.Point(75, 124);
            this.kydtBtn.Name = "kydtBtn";
            this.kydtBtn.Size = new System.Drawing.Size(128, 36);
            this.kydtBtn.TabIndex = 9;
            this.kydtBtn.Text = "Kaydet";
            this.kydtBtn.UseVisualStyleBackColor = true;
            this.kydtBtn.Click += new System.EventHandler(this.kydtBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adı:";
            // 
            // SosFiyatiNmrc
            // 
            this.SosFiyatiNmrc.Location = new System.Drawing.Point(75, 79);
            this.SosFiyatiNmrc.Name = "SosFiyatiNmrc";
            this.SosFiyatiNmrc.Size = new System.Drawing.Size(164, 26);
            this.SosFiyatiNmrc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fiyat:";
            // 
            // SosAdiTxt
            // 
            this.SosAdiTxt.Location = new System.Drawing.Point(75, 47);
            this.SosAdiTxt.Name = "SosAdiTxt";
            this.SosAdiTxt.Size = new System.Drawing.Size(164, 26);
            this.SosAdiTxt.TabIndex = 0;
            // 
            // ExtraMalzemeEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.extraMalzemeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtraMalzemeEkleForm";
            this.Text = "ExtraMalzemeBilgi";
            this.Load += new System.EventHandler(this.ExtraMalzemeEkleForm_Load);
            this.extraMalzemeBox.ResumeLayout(false);
            this.extraMalzemeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SosFiyatiNmrc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox extraMalzemeBox;
        private System.Windows.Forms.TextBox SosAdiTxt;
        private System.Windows.Forms.NumericUpDown SosFiyatiNmrc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kydtBtn;
        private System.Windows.Forms.Label label2;
    }
}