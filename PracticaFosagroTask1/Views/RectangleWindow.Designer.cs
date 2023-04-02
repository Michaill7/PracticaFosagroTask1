
namespace PracticaFosagroTask1.Views
{
    partial class RectangleWindow
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
            this.RecA = new System.Windows.Forms.TextBox();
            this.RecB = new System.Windows.Forms.TextBox();
            this.RecH = new System.Windows.Forms.TextBox();
            this.AddRectangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecA
            // 
            this.RecA.Location = new System.Drawing.Point(73, 56);
            this.RecA.Name = "RecA";
            this.RecA.Size = new System.Drawing.Size(154, 20);
            this.RecA.TabIndex = 0;
            // 
            // RecB
            // 
            this.RecB.Location = new System.Drawing.Point(73, 122);
            this.RecB.Name = "RecB";
            this.RecB.Size = new System.Drawing.Size(154, 20);
            this.RecB.TabIndex = 1;
            // 
            // RecH
            // 
            this.RecH.Location = new System.Drawing.Point(73, 189);
            this.RecH.Name = "RecH";
            this.RecH.Size = new System.Drawing.Size(154, 20);
            this.RecH.TabIndex = 2;
            // 
            // AddRectangle
            // 
            this.AddRectangle.Location = new System.Drawing.Point(73, 270);
            this.AddRectangle.Name = "AddRectangle";
            this.AddRectangle.Size = new System.Drawing.Size(154, 90);
            this.AddRectangle.TabIndex = 3;
            this.AddRectangle.Text = "Добавить";
            this.AddRectangle.UseVisualStyleBackColor = true;
            this.AddRectangle.Click += new System.EventHandler(this.AddRectangle_Click);
            // 
            // RectangleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 372);
            this.Controls.Add(this.AddRectangle);
            this.Controls.Add(this.RecH);
            this.Controls.Add(this.RecB);
            this.Controls.Add(this.RecA);
            this.Name = "RectangleWindow";
            this.Text = "RectangleWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecA;
        private System.Windows.Forms.TextBox RecB;
        private System.Windows.Forms.TextBox RecH;
        private System.Windows.Forms.Button AddRectangle;
    }
}