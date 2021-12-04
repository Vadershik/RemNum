
namespace RemNum
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
            this.components = new System.ComponentModel.Container();
            this.recordText = new System.Windows.Forms.Label();
            this.NumText = new System.Windows.Forms.Label();
            this.PrintNum = new System.Windows.Forms.TextBox();
            this.CheckBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // recordText
            // 
            this.recordText.AutoSize = true;
            this.recordText.Location = new System.Drawing.Point(276, 9);
            this.recordText.Name = "recordText";
            this.recordText.Size = new System.Drawing.Size(56, 13);
            this.recordText.TabIndex = 0;
            this.recordText.Text = "Рекорд: 0";
            // 
            // NumText
            // 
            this.NumText.AutoSize = true;
            this.NumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumText.Location = new System.Drawing.Point(143, 44);
            this.NumText.Name = "NumText";
            this.NumText.Size = new System.Drawing.Size(63, 24);
            this.NumText.TabIndex = 1;
            this.NumText.Text = "Число";
            // 
            // PrintNum
            // 
            this.PrintNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintNum.Location = new System.Drawing.Point(96, 90);
            this.PrintNum.Name = "PrintNum";
            this.PrintNum.Size = new System.Drawing.Size(163, 22);
            this.PrintNum.TabIndex = 2;
            // 
            // CheckBut
            // 
            this.CheckBut.Location = new System.Drawing.Point(138, 129);
            this.CheckBut.Name = "CheckBut";
            this.CheckBut.Size = new System.Drawing.Size(75, 23);
            this.CheckBut.TabIndex = 3;
            this.CheckBut.Text = "Check";
            this.CheckBut.UseVisualStyleBackColor = true;
            this.CheckBut.Click += new System.EventHandler(this.CheckBut_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 187);
            this.Controls.Add(this.CheckBut);
            this.Controls.Add(this.PrintNum);
            this.Controls.Add(this.NumText);
            this.Controls.Add(this.recordText);
            this.Name = "Form1";
            this.Text = "RemNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recordText;
        private System.Windows.Forms.Label NumText;
        private System.Windows.Forms.TextBox PrintNum;
        private System.Windows.Forms.Button CheckBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

