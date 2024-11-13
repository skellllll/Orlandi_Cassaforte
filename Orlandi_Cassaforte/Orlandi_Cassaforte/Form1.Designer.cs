namespace Orlandi_Cassaforte
{
    partial class Form1
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
            Open = new Button();
            Close2 = new Button();
            Unlock = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Open
            // 
            Open.Location = new Point(68, 67);
            Open.Name = "Open";
            Open.Size = new Size(88, 81);
            Open.TabIndex = 0;
            Open.Text = "OPEN";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // Close2
            // 
            Close2.Location = new Point(68, 187);
            Close2.Name = "Close2";
            Close2.Size = new Size(88, 81);
            Close2.TabIndex = 1;
            Close2.Text = "CLOSE";
            Close2.UseVisualStyleBackColor = true;
            Close2.Click += Close2_Click;
            // 
            // Unlock
            // 
            Unlock.Location = new Point(68, 310);
            Unlock.Name = "Unlock";
            Unlock.Size = new Size(88, 81);
            Unlock.TabIndex = 2;
            Unlock.Text = "UNLOCK";
            Unlock.UseVisualStyleBackColor = true;
            Unlock.Click += Unlock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 187);
            label1.Name = "label1";
            label1.Size = new Size(166, 65);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Unlock);
            Controls.Add(Close2);
            Controls.Add(Open);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Open;
        private Button Close2;
        private Button Unlock;
        private Label label1;
    }
}