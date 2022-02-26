namespace ComboBox1
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
            this.cbList1 = new System.Windows.Forms.ComboBox();
            this.lbList1 = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbList1
            // 
            this.cbList1.FormattingEnabled = true;
            this.cbList1.Items.AddRange(new object[] {
            "LTDT",
            "CTDL"});
            this.cbList1.Location = new System.Drawing.Point(223, 43);
            this.cbList1.Name = "cbList1";
            this.cbList1.Size = new System.Drawing.Size(335, 24);
            this.cbList1.TabIndex = 1;
            this.cbList1.SelectedIndexChanged += new System.EventHandler(this.cbList1_SelectedIndexChanged);
            // 
            // lbList1
            // 
            this.lbList1.FormattingEnabled = true;
            this.lbList1.ItemHeight = 16;
            this.lbList1.Location = new System.Drawing.Point(223, 126);
            this.lbList1.Name = "lbList1";
            this.lbList1.Size = new System.Drawing.Size(335, 212);
            this.lbList1.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(646, 126);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbList1);
            this.Controls.Add(this.cbList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbList1;
        private System.Windows.Forms.ListBox lbList1;
        private System.Windows.Forms.Button btnRemove;
    }
}

