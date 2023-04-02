
namespace PracticaFosagroTask1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DetailsListBox = new System.Windows.Forms.ComboBox();
            this.ChoseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DetailsListBox
            // 
            this.DetailsListBox.FormattingEnabled = true;
            this.DetailsListBox.Location = new System.Drawing.Point(38, 26);
            this.DetailsListBox.Name = "DetailsListBox";
            this.DetailsListBox.Size = new System.Drawing.Size(220, 21);
            this.DetailsListBox.TabIndex = 0;
            // 
            // ChoseButton
            // 
            this.ChoseButton.Location = new System.Drawing.Point(91, 130);
            this.ChoseButton.Name = "ChoseButton";
            this.ChoseButton.Size = new System.Drawing.Size(97, 44);
            this.ChoseButton.TabIndex = 1;
            this.ChoseButton.Text = "Выбрать";
            this.ChoseButton.UseVisualStyleBackColor = true;
            this.ChoseButton.Click += new System.EventHandler(this.ChoseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 200);
            this.Controls.Add(this.ChoseButton);
            this.Controls.Add(this.DetailsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox DetailsListBox;
        private System.Windows.Forms.Button ChoseButton;
    }
}

