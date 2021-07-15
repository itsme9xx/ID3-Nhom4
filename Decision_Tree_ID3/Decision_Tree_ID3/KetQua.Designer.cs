namespace Decision_Tree_ID3
{
    partial class KetQua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KetQua));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID3_Algorithm = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlDecisionTree = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(375, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "DECISION TREE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID3_Algorithm
            // 
            this.txtID3_Algorithm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID3_Algorithm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID3_Algorithm.Location = new System.Drawing.Point(12, 124);
            this.txtID3_Algorithm.Multiline = true;
            this.txtID3_Algorithm.Name = "txtID3_Algorithm";
            this.txtID3_Algorithm.ReadOnly = true;
            this.txtID3_Algorithm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtID3_Algorithm.Size = new System.Drawing.Size(453, 439);
            this.txtID3_Algorithm.TabIndex = 9;
            this.txtID3_Algorithm.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(12, 46);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(88, 28);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "<< Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlDecisionTree
            // 
            this.pnlDecisionTree.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlDecisionTree.Location = new System.Drawing.Point(471, 124);
            this.pnlDecisionTree.Name = "pnlDecisionTree";
            this.pnlDecisionTree.Size = new System.Drawing.Size(451, 438);
            this.pnlDecisionTree.TabIndex = 11;
            this.pnlDecisionTree.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDecisionTree_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(191, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thuật Toán ID3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(638, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decision Tree";
            // 
            // KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 575);
            this.Controls.Add(this.pnlDecisionTree);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtID3_Algorithm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KetQua";
            this.Text = "Show Decision Tree";
            this.Load += new System.EventHandler(this.FormViewResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID3_Algorithm;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlDecisionTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}