namespace Farmgame
{
    partial class frmain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbltest1 = new System.Windows.Forms.Label();
            this.btntest1 = new System.Windows.Forms.Button();
            this.btnbuycow = new System.Windows.Forms.Button();
            this.lbltest2 = new System.Windows.Forms.Label();
            this.btnbuychicken = new System.Windows.Forms.Button();
            this.lblmoney1 = new System.Windows.Forms.Label();
            this.lblmoney2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbltest1
            // 
            this.lbltest1.AutoSize = true;
            this.lbltest1.Location = new System.Drawing.Point(605, 132);
            this.lbltest1.Name = "lbltest1";
            this.lbltest1.Size = new System.Drawing.Size(37, 13);
            this.lbltest1.TabIndex = 4;
            this.lbltest1.Text = "Test 1";
            // 
            // btntest1
            // 
            this.btntest1.Location = new System.Drawing.Point(573, 69);
            this.btntest1.Name = "btntest1";
            this.btntest1.Size = new System.Drawing.Size(100, 36);
            this.btntest1.TabIndex = 2;
            this.btntest1.Text = "Milk the cow";
            this.btntest1.UseVisualStyleBackColor = true;
            this.btntest1.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // btnbuycow
            // 
            this.btnbuycow.Location = new System.Drawing.Point(286, 49);
            this.btnbuycow.Name = "btnbuycow";
            this.btnbuycow.Size = new System.Drawing.Size(100, 36);
            this.btnbuycow.TabIndex = 5;
            this.btnbuycow.Text = "Buy a cow";
            this.btnbuycow.UseVisualStyleBackColor = true;
            this.btnbuycow.Click += new System.EventHandler(this.Btnbuycow_Click);
            // 
            // lbltest2
            // 
            this.lbltest2.AutoSize = true;
            this.lbltest2.Location = new System.Drawing.Point(313, 114);
            this.lbltest2.Name = "lbltest2";
            this.lbltest2.Size = new System.Drawing.Size(37, 13);
            this.lbltest2.TabIndex = 6;
            this.lbltest2.Text = "Test 2";
            // 
            // btnbuychicken
            // 
            this.btnbuychicken.Location = new System.Drawing.Point(286, 142);
            this.btnbuychicken.Name = "btnbuychicken";
            this.btnbuychicken.Size = new System.Drawing.Size(100, 36);
            this.btnbuychicken.TabIndex = 7;
            this.btnbuychicken.Text = "Buy a chicken";
            this.btnbuychicken.UseVisualStyleBackColor = true;
            this.btnbuychicken.Click += new System.EventHandler(this.Btnbuychicken_Click);
            // 
            // lblmoney1
            // 
            this.lblmoney1.AutoSize = true;
            this.lblmoney1.Location = new System.Drawing.Point(315, 202);
            this.lblmoney1.Name = "lblmoney1";
            this.lblmoney1.Size = new System.Drawing.Size(82, 13);
            this.lblmoney1.TabIndex = 8;
            this.lblmoney1.Text = "Your wallet has:";
            // 
            // lblmoney2
            // 
            this.lblmoney2.AutoSize = true;
            this.lblmoney2.Location = new System.Drawing.Point(403, 202);
            this.lblmoney2.Name = "lblmoney2";
            this.lblmoney2.Size = new System.Drawing.Size(0, 13);
            this.lblmoney2.TabIndex = 9;
            // 
            // frmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmoney2);
            this.Controls.Add(this.lblmoney1);
            this.Controls.Add(this.btnbuychicken);
            this.Controls.Add(this.lbltest2);
            this.Controls.Add(this.btnbuycow);
            this.Controls.Add(this.lbltest1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btntest1);
            this.Name = "frmain";
            this.Text = " Farm simulator";
            this.Load += new System.EventHandler(this.frmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbltest1;
        private System.Windows.Forms.Button btntest1;
        private System.Windows.Forms.Button btnbuycow;
        private System.Windows.Forms.Label lbltest2;
        private System.Windows.Forms.Button btnbuychicken;
        private System.Windows.Forms.Label lblmoney1;
        private System.Windows.Forms.Label lblmoney2;
    }
}

