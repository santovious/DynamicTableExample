namespace FormTableExample1
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
            this.Table1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // Table1
            // 
            this.Table1.ColumnCount = 4;
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table1.Location = new System.Drawing.Point(13, 13);
            this.Table1.Name = "Table1";
            this.Table1.RowCount = 1;
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table1.Size = new System.Drawing.Size(200, 100);
            this.Table1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Table1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table1;
    }
}

