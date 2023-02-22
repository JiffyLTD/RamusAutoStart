namespace PathFinder
{
    partial class PathFinder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.JavaPathObserverButton = new System.Windows.Forms.Button();
            this.RamusPathObserverButton = new System.Windows.Forms.Button();
            this.textBoxJavaPath = new System.Windows.Forms.TextBox();
            this.textBoxRamusPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(297, 126);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // JavaPathObserverButton
            // 
            this.JavaPathObserverButton.Location = new System.Drawing.Point(297, 97);
            this.JavaPathObserverButton.Name = "JavaPathObserverButton";
            this.JavaPathObserverButton.Size = new System.Drawing.Size(75, 23);
            this.JavaPathObserverButton.TabIndex = 1;
            this.JavaPathObserverButton.Text = "Обзор";
            this.JavaPathObserverButton.UseVisualStyleBackColor = true;
            this.JavaPathObserverButton.Click += new System.EventHandler(this.JavaPathObserverButton_Click);
            // 
            // RamusPathObserverButton
            // 
            this.RamusPathObserverButton.Location = new System.Drawing.Point(297, 46);
            this.RamusPathObserverButton.Name = "RamusPathObserverButton";
            this.RamusPathObserverButton.Size = new System.Drawing.Size(75, 23);
            this.RamusPathObserverButton.TabIndex = 2;
            this.RamusPathObserverButton.Text = "Обзор";
            this.RamusPathObserverButton.UseVisualStyleBackColor = true;
            this.RamusPathObserverButton.Click += new System.EventHandler(this.RamusPathObserverButton_Click);
            // 
            // textBoxJavaPath
            // 
            this.textBoxJavaPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJavaPath.Location = new System.Drawing.Point(12, 97);
            this.textBoxJavaPath.Name = "textBoxJavaPath";
            this.textBoxJavaPath.Size = new System.Drawing.Size(279, 23);
            this.textBoxJavaPath.TabIndex = 3;
            // 
            // textBoxRamusPath
            // 
            this.textBoxRamusPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRamusPath.Location = new System.Drawing.Point(12, 46);
            this.textBoxRamusPath.Name = "textBoxRamusPath";
            this.textBoxRamusPath.Size = new System.Drawing.Size(279, 23);
            this.textBoxRamusPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пожалуйста проверьте или укажите пути до Java и Ramus на вашем компьютере\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пример : C:\\Ramus\\bin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пример : C:\\Program Files\\Java\\jdk1.8.0_261\\bin";
            // 
            // PathFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRamusPath);
            this.Controls.Add(this.textBoxJavaPath);
            this.Controls.Add(this.RamusPathObserverButton);
            this.Controls.Add(this.JavaPathObserverButton);
            this.Controls.Add(this.NextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "PathFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RamusAutoStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NextButton;
        private Button JavaPathObserverButton;
        private Button RamusPathObserverButton;
        private TextBox textBoxJavaPath;
        private TextBox textBoxRamusPath;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}