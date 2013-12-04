namespace BenchmarkAppCSharp
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabArrayTests = new System.Windows.Forms.TabPage();
            this.tabDatabaseTests = new System.Windows.Forms.TabPage();
            this.tabObjectTests = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArrayTests);
            this.tabControl1.Controls.Add(this.tabDatabaseTests);
            this.tabControl1.Controls.Add(this.tabObjectTests);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabArrayTests
            // 
            this.tabArrayTests.Location = new System.Drawing.Point(4, 22);
            this.tabArrayTests.Name = "tabArrayTests";
            this.tabArrayTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabArrayTests.Size = new System.Drawing.Size(776, 536);
            this.tabArrayTests.TabIndex = 0;
            this.tabArrayTests.Text = "Array tests";
            this.tabArrayTests.UseVisualStyleBackColor = true;
            // 
            // tabDatabaseTests
            // 
            this.tabDatabaseTests.Location = new System.Drawing.Point(4, 22);
            this.tabDatabaseTests.Name = "tabDatabaseTests";
            this.tabDatabaseTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabaseTests.Size = new System.Drawing.Size(776, 536);
            this.tabDatabaseTests.TabIndex = 1;
            this.tabDatabaseTests.Text = "Database tests";
            this.tabDatabaseTests.UseVisualStyleBackColor = true;
            // 
            // tabObjectTests
            // 
            this.tabObjectTests.Location = new System.Drawing.Point(4, 22);
            this.tabObjectTests.Name = "tabObjectTests";
            this.tabObjectTests.Size = new System.Drawing.Size(776, 536);
            this.tabObjectTests.TabIndex = 2;
            this.tabObjectTests.Text = "Object tests";
            this.tabObjectTests.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Benchmark app C#";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArrayTests;
        private System.Windows.Forms.TabPage tabDatabaseTests;
        private System.Windows.Forms.TabPage tabObjectTests;

    }
}

