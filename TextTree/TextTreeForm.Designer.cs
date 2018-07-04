namespace TextTree
{
    partial class TextTreeForm
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
            this.a_button = new System.Windows.Forms.Button();
            this.b_button = new System.Windows.Forms.Button();
            this.c_button = new System.Windows.Forms.Button();
            this.a_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.b_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // a_button
            // 
            this.a_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.a_button.Location = new System.Drawing.Point(12, 234);
            this.a_button.Name = "a_button";
            this.a_button.Size = new System.Drawing.Size(75, 23);
            this.a_button.TabIndex = 0;
            this.a_button.Text = "Read File A";
            this.a_button.UseVisualStyleBackColor = true;
            this.a_button.Click += new System.EventHandler(this.a_button_Click);
            // 
            // b_button
            // 
            this.b_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.b_button.Location = new System.Drawing.Point(94, 233);
            this.b_button.Name = "b_button";
            this.b_button.Size = new System.Drawing.Size(75, 23);
            this.b_button.TabIndex = 1;
            this.b_button.Text = "Read File B";
            this.b_button.UseVisualStyleBackColor = true;
            this.b_button.Click += new System.EventHandler(this.b_button_Click);
            // 
            // c_button
            // 
            this.c_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_button.Location = new System.Drawing.Point(418, 234);
            this.c_button.Name = "c_button";
            this.c_button.Size = new System.Drawing.Size(88, 23);
            this.c_button.TabIndex = 2;
            this.c_button.Text = "Write To File C";
            this.c_button.UseVisualStyleBackColor = true;
            this.c_button.Click += new System.EventHandler(this.c_button_Click);
            // 
            // a_openFileDialog
            // 
            this.a_openFileDialog.FileName = "a_openFileDialog";
            // 
            // b_openFileDialog
            // 
            this.b_openFileDialog.FileName = "b_openFileDialog";
            // 
            // TextTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 269);
            this.Controls.Add(this.c_button);
            this.Controls.Add(this.b_button);
            this.Controls.Add(this.a_button);
            this.Name = "TextTreeForm";
            this.Text = "TextTree";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button a_button;
        private System.Windows.Forms.Button b_button;
        private System.Windows.Forms.Button c_button;
        private System.Windows.Forms.OpenFileDialog a_openFileDialog;
        private System.Windows.Forms.OpenFileDialog b_openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

