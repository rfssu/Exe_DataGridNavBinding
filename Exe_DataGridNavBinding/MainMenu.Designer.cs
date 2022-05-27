
namespace Exe_DataGridNavBinding
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridbutton = new System.Windows.Forms.Button();
            this.NavBindingbutton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraft", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA GRID VIEW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minecraft", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(353, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BINDING NAVIGATION";
            // 
            // DataGridbutton
            // 
            this.DataGridbutton.BackColor = System.Drawing.Color.Transparent;
            this.DataGridbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataGridbutton.BackgroundImage")));
            this.DataGridbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DataGridbutton.ForeColor = System.Drawing.Color.Transparent;
            this.DataGridbutton.Image = ((System.Drawing.Image)(resources.GetObject("DataGridbutton.Image")));
            this.DataGridbutton.Location = new System.Drawing.Point(104, 254);
            this.DataGridbutton.Name = "DataGridbutton";
            this.DataGridbutton.Size = new System.Drawing.Size(162, 115);
            this.DataGridbutton.TabIndex = 3;
            this.DataGridbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DataGridbutton.UseVisualStyleBackColor = false;
            this.DataGridbutton.Click += new System.EventHandler(this.DataGridbutton_Click);
            // 
            // NavBindingbutton
            // 
            this.NavBindingbutton.BackColor = System.Drawing.Color.Transparent;
            this.NavBindingbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavBindingbutton.BackgroundImage")));
            this.NavBindingbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NavBindingbutton.Location = new System.Drawing.Point(379, 254);
            this.NavBindingbutton.Name = "NavBindingbutton";
            this.NavBindingbutton.Size = new System.Drawing.Size(162, 115);
            this.NavBindingbutton.TabIndex = 4;
            this.NavBindingbutton.UseVisualStyleBackColor = false;
            this.NavBindingbutton.Click += new System.EventHandler(this.NavBindingbutton_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Font = new System.Drawing.Font("Minecraft", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(547, 567);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(76, 34);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "<<<";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(666, 637);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NavBindingbutton);
            this.Controls.Add(this.DataGridbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DataGridbutton;
        private System.Windows.Forms.Button NavBindingbutton;
        private System.Windows.Forms.Button Exit;
    }
}