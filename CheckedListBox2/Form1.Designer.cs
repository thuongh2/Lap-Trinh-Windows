namespace CheckedListBox2
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
            this.clbList2 = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbList1
            // 
            this.clbList1.FormattingEnabled = true;
            this.clbList1.Items.AddRange(new object[] {
            "CTDL1",
            "CTDL2",
            "LTDT",
            "LTWindows"});
            this.clbList1.Location = new System.Drawing.Point(64, 86);
            this.clbList1.Name = "clbList1";
            this.clbList1.Size = new System.Drawing.Size(173, 191);
            this.clbList1.TabIndex = 1;
            // 
            // clbList2
            // 
            this.clbList2.FormattingEnabled = true;
            this.clbList2.Location = new System.Drawing.Point(504, 86);
            this.clbList2.Name = "clbList2";
            this.clbList2.Size = new System.Drawing.Size(173, 191);
            this.clbList2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(324, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(324, 155);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "<";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.clbList2);
            this.Controls.Add(this.clbList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbList1;
        private System.Windows.Forms.CheckedListBox clbList2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn;
    }
}

