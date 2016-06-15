namespace HaloVersionSelector
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
            this.button108 = new System.Windows.Forms.Button();
            this.button109 = new System.Windows.Forms.Button();
            this.button110 = new System.Windows.Forms.Button();
            this.sapien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button108
            // 
            this.button108.Location = new System.Drawing.Point(12, 12);
            this.button108.Name = "button108";
            this.button108.Size = new System.Drawing.Size(101, 25);
            this.button108.TabIndex = 0;
            this.button108.Text = "Halo108";
            this.button108.UseVisualStyleBackColor = true;
            this.button108.Click += new System.EventHandler(this.button108_Click);
            // 
            // button109
            // 
            this.button109.Location = new System.Drawing.Point(119, 12);
            this.button109.Name = "button109";
            this.button109.Size = new System.Drawing.Size(101, 25);
            this.button109.TabIndex = 1;
            this.button109.Text = "Halo109";
            this.button109.UseVisualStyleBackColor = true;
            this.button109.Click += new System.EventHandler(this.button109_Click);
            // 
            // button110
            // 
            this.button110.Location = new System.Drawing.Point(226, 12);
            this.button110.Name = "button110";
            this.button110.Size = new System.Drawing.Size(101, 25);
            this.button110.TabIndex = 2;
            this.button110.Text = "Halo110";
            this.button110.UseVisualStyleBackColor = true;
            this.button110.Click += new System.EventHandler(this.button110_Click);
            // 
            // sapien
            // 
            this.sapien.Location = new System.Drawing.Point(119, 44);
            this.sapien.Name = "sapien";
            this.sapien.Size = new System.Drawing.Size(101, 25);
            this.sapien.TabIndex = 3;
            this.sapien.Text = "Sapien";
            this.sapien.UseVisualStyleBackColor = true;
            this.sapien.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 71);
            this.Controls.Add(this.sapien);
            this.Controls.Add(this.button110);
            this.Controls.Add(this.button109);
            this.Controls.Add(this.button108);
            this.Name = "Form1";
            this.Text = "Version Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button108;
        private System.Windows.Forms.Button button109;
        private System.Windows.Forms.Button button110;
        private System.Windows.Forms.Button sapien;

    }
}

