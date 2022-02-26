namespace CheckedListBox1
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
            this.clbList1 = new System.Windows.Forms.CheckedListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbList1
            // 
            this.clbList1.FormattingEnabled = true;
            this.clbList1.Items.AddRange(new object[] {
            "CTDL 1",
            "CTDL 2",
            "LTDT",
            "CNPM",
            "LTWindows"});
            this.clbList1.Location = new System.Drawing.Point(44, 63);
            this.clbList1.Name = "clbList1";
            this.clbList1.Size = new System.Drawing.Size(258, 276);
            this.clbList1.TabIndex = 0;
            this.clbList1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(444, 63);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(123, 39);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.clbList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbList1;
        private System.Windows.Forms.Button btnShow;
    }
}

