namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.btnSonrakiSoru = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSecenekA = new System.Windows.Forms.Button();
            this.btnSecenekB = new System.Windows.Forms.Button();
            this.btnSecenekC = new System.Windows.Forms.Button();
            this.btnSecenekD = new System.Windows.Forms.Button();
            this.lblOdul = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru";
            // 
            // lblSoru
            // 
            this.lblSoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(81, 12);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(335, 138);
            this.lblSoru.TabIndex = 1;
            this.lblSoru.Text = "1.soru";
            this.lblSoru.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSonrakiSoru
            // 
            this.btnSonrakiSoru.Location = new System.Drawing.Point(435, 13);
            this.btnSonrakiSoru.Name = "btnSonrakiSoru";
            this.btnSonrakiSoru.Size = new System.Drawing.Size(103, 137);
            this.btnSonrakiSoru.TabIndex = 2;
            this.btnSonrakiSoru.Text = "Sonraki Soru";
            this.btnSonrakiSoru.UseVisualStyleBackColor = true;
            this.btnSonrakiSoru.Click += new System.EventHandler(this.btnSonrakiSoru_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSecenekD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSecenekC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSecenekA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSecenekB, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(84, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 120);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "D";
            // 
            // btnSecenekA
            // 
            this.btnSecenekA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSecenekA.Location = new System.Drawing.Point(23, 3);
            this.btnSecenekA.Name = "btnSecenekA";
            this.btnSecenekA.Size = new System.Drawing.Size(306, 23);
            this.btnSecenekA.TabIndex = 4;
            this.btnSecenekA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecenekA.UseVisualStyleBackColor = true;
            this.btnSecenekA.Click += new System.EventHandler(this.btnSecenekA_Click);
            // 
            // btnSecenekB
            // 
            this.btnSecenekB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSecenekB.Location = new System.Drawing.Point(23, 35);
            this.btnSecenekB.Name = "btnSecenekB";
            this.btnSecenekB.Size = new System.Drawing.Size(306, 19);
            this.btnSecenekB.TabIndex = 5;
            this.btnSecenekB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecenekB.UseVisualStyleBackColor = true;
            this.btnSecenekB.Click += new System.EventHandler(this.btnSecenekB_Click);
            // 
            // btnSecenekC
            // 
            this.btnSecenekC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSecenekC.Location = new System.Drawing.Point(23, 65);
            this.btnSecenekC.Name = "btnSecenekC";
            this.btnSecenekC.Size = new System.Drawing.Size(306, 19);
            this.btnSecenekC.TabIndex = 6;
            this.btnSecenekC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecenekC.UseVisualStyleBackColor = true;
            this.btnSecenekC.Click += new System.EventHandler(this.btnSecenekC_Click);
            // 
            // btnSecenekD
            // 
            this.btnSecenekD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSecenekD.Location = new System.Drawing.Point(23, 95);
            this.btnSecenekD.Name = "btnSecenekD";
            this.btnSecenekD.Size = new System.Drawing.Size(306, 19);
            this.btnSecenekD.TabIndex = 7;
            this.btnSecenekD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecenekD.UseVisualStyleBackColor = true;
            this.btnSecenekD.Click += new System.EventHandler(this.btnSecenekD_Click);
            // 
            // lblOdul
            // 
            this.lblOdul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOdul.Location = new System.Drawing.Point(435, 170);
            this.lblOdul.Name = "lblOdul";
            this.lblOdul.Size = new System.Drawing.Size(103, 120);
            this.lblOdul.TabIndex = 4;
            this.lblOdul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblOdul);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSonrakiSoru);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kim Milyoner Olmak İster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Button btnSonrakiSoru;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSecenekD;
        private System.Windows.Forms.Button btnSecenekC;
        private System.Windows.Forms.Button btnSecenekB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSecenekA;
        private System.Windows.Forms.Label lblOdul;
    }
}

