namespace VocFilter
{
    partial class FVocFilter
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
            this.lbEnterText = new System.Windows.Forms.Label();
            this.tBText = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEnterText
            // 
            this.lbEnterText.AutoSize = true;
            this.lbEnterText.Location = new System.Drawing.Point(344, 9);
            this.lbEnterText.Name = "lbEnterText";
            this.lbEnterText.Size = new System.Drawing.Size(80, 13);
            this.lbEnterText.TabIndex = 0;
            this.lbEnterText.Text = "Введите текст";
            // 
            // tBText
            // 
            this.tBText.Location = new System.Drawing.Point(12, 44);
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(776, 20);
            this.tBText.TabIndex = 1;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(142, 87);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(500, 23);
            this.btFind.TabIndex = 2;
            this.btFind.Text = "Определить вероятность нежелательных вхождений";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(12, 87);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(124, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(656, 87);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(132, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FVocFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 158);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.tBText);
            this.Controls.Add(this.lbEnterText);
            this.Name = "FVocFilter";
            this.Text = "Фильтрация лексики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterText;
        private System.Windows.Forms.TextBox tBText;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btClose;
    }
}

