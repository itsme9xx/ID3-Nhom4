namespace Decision_Tree_ID3
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateBest_ID3 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtClause = new System.Windows.Forms.TextBox();
            this.btnAddClause = new System.Windows.Forms.Button();
            this.btnOpenExcelSource = new System.Windows.Forms.Button();
            this.dataGridViewClauses = new System.Windows.Forms.DataGridView();
            this.btnRemoveClause = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenTextSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClauses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "DECISION TREE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // btnCreateBest_ID3
            // 
            this.btnCreateBest_ID3.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateBest_ID3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBest_ID3.FlatAppearance.BorderSize = 0;
            this.btnCreateBest_ID3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCreateBest_ID3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateBest_ID3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBest_ID3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBest_ID3.ForeColor = System.Drawing.Color.Yellow;
            this.btnCreateBest_ID3.Location = new System.Drawing.Point(260, 415);
            this.btnCreateBest_ID3.Name = "btnCreateBest_ID3";
            this.btnCreateBest_ID3.Size = new System.Drawing.Size(217, 34);
            this.btnCreateBest_ID3.TabIndex = 4;
            this.btnCreateBest_ID3.Text = ">>Tạo Cây Quyết Định<<";
            this.btnCreateBest_ID3.UseVisualStyleBackColor = false;
            this.btnCreateBest_ID3.Click += new System.EventHandler(this.btnCreateBest_ID3_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(375, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 5;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtClause
            // 
            this.txtClause.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtClause.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtClause.Location = new System.Drawing.Point(1, 3);
            this.txtClause.Multiline = true;
            this.txtClause.Name = "txtClause";
            this.txtClause.Size = new System.Drawing.Size(161, 28);
            this.txtClause.TabIndex = 0;
            
            this.txtClause.Enter += new System.EventHandler(this.txtClause_Enter);
            // 
            // btnAddClause
            // 
            this.btnAddClause.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClause.FlatAppearance.BorderSize = 0;
            this.btnAddClause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAddClause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddClause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClause.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClause.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddClause.Location = new System.Drawing.Point(188, 3);
            this.btnAddClause.Name = "btnAddClause";
            this.btnAddClause.Size = new System.Drawing.Size(87, 28);
            this.btnAddClause.TabIndex = 1;
            this.btnAddClause.Text = "Thêm Cột";
            this.btnAddClause.UseVisualStyleBackColor = false;
            this.btnAddClause.Click += new System.EventHandler(this.btnAddClause_Click);
            // 
            // btnOpenExcelSource
            // 
            this.btnOpenExcelSource.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenExcelSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenExcelSource.FlatAppearance.BorderSize = 0;
            this.btnOpenExcelSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnOpenExcelSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenExcelSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenExcelSource.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenExcelSource.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenExcelSource.Location = new System.Drawing.Point(590, 2);
            this.btnOpenExcelSource.Name = "btnOpenExcelSource";
            this.btnOpenExcelSource.Size = new System.Drawing.Size(119, 28);
            this.btnOpenExcelSource.TabIndex = 6;
            this.btnOpenExcelSource.TabStop = false;
            this.btnOpenExcelSource.Text = "Mở File Excel";
            this.btnOpenExcelSource.UseVisualStyleBackColor = false;
            this.btnOpenExcelSource.Click += new System.EventHandler(this.btnOpenExcelSource_Click);
            // 
            // dataGridViewClauses
            // 
            this.dataGridViewClauses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClauses.Location = new System.Drawing.Point(12, 131);
            this.dataGridViewClauses.Name = "dataGridViewClauses";
            this.dataGridViewClauses.Size = new System.Drawing.Size(714, 278);
            this.dataGridViewClauses.TabIndex = 3;
            this.dataGridViewClauses.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClauses_ColumnHeaderMouseClick);
            // 
            // btnRemoveClause
            // 
            this.btnRemoveClause.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveClause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveClause.FlatAppearance.BorderSize = 0;
            this.btnRemoveClause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRemoveClause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveClause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveClause.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveClause.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveClause.Location = new System.Drawing.Point(281, 2);
            this.btnRemoveClause.Name = "btnRemoveClause";
            this.btnRemoveClause.Size = new System.Drawing.Size(102, 28);
            this.btnRemoveClause.TabIndex = 2;
            this.btnRemoveClause.Text = "Xóa Cột";
            this.btnRemoveClause.UseVisualStyleBackColor = false;
            this.btnRemoveClause.Click += new System.EventHandler(this.btnRemoveClause_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOpenTextSource);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.txtClause);
            this.panel1.Controls.Add(this.btnRemoveClause);
            this.panel1.Controls.Add(this.btnAddClause);
            this.panel1.Controls.Add(this.btnOpenExcelSource);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 35);
            this.panel1.TabIndex = 5;
            // 
            // btnOpenTextSource
            // 
            this.btnOpenTextSource.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenTextSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenTextSource.FlatAppearance.BorderSize = 0;
            this.btnOpenTextSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnOpenTextSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenTextSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTextSource.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTextSource.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenTextSource.Location = new System.Drawing.Point(456, 2);
            this.btnOpenTextSource.Name = "btnOpenTextSource";
            this.btnOpenTextSource.Size = new System.Drawing.Size(116, 28);
            this.btnOpenTextSource.TabIndex = 5;
            this.btnOpenTextSource.TabStop = false;
            this.btnOpenTextSource.Text = "Mở FileTxt";
            this.btnOpenTextSource.UseVisualStyleBackColor = false;
            this.btnOpenTextSource.Click += new System.EventHandler(this.btnOpenTextSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Dữ Liệu";
            
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(651, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 461);
            this.Controls.Add(this.dataGridViewClauses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateBest_ID3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClauses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateBest_ID3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtClause;
        private System.Windows.Forms.Button btnAddClause;
        private System.Windows.Forms.Button btnOpenExcelSource;
        private System.Windows.Forms.DataGridView dataGridViewClauses;
        private System.Windows.Forms.Button btnRemoveClause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenTextSource;
        private System.Windows.Forms.Button button1;
    }
}

