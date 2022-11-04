
namespace Calculator
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
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTRu = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(280, 249);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(88, 56);
            this.btnNhan.TabIndex = 31;
            this.btnNhan.Text = "nhân ";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(390, 251);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(88, 56);
            this.btnChia.TabIndex = 30;
            this.btnChia.Text = "Chia ";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(674, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "CHƯƠNG TRÌNH MÁY TÍNH ĐƠN GIẢN ";
            // 
            // btnTRu
            // 
            this.btnTRu.Location = new System.Drawing.Point(174, 249);
            this.btnTRu.Name = "btnTRu";
            this.btnTRu.Size = new System.Drawing.Size(84, 60);
            this.btnTRu.TabIndex = 28;
            this.btnTRu.Text = "trừ ";
            this.btnTRu.UseVisualStyleBackColor = true;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(62, 249);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(88, 56);
            this.btnCong.TabIndex = 27;
            this.btnCong.Text = "cộng ";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click_1);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(305, 158);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 22);
            this.txtSo2.TabIndex = 26;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(292, 193);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 22);
            this.txtKQ.TabIndex = 25;
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(305, 104);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 22);
            this.txtSo1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "kết quả ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "số thứ hai ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "số thứ  nhất ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTRu);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTRu;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

