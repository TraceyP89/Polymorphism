namespace Polymorphism
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
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.createDogButton = new System.Windows.Forms.Button();
            this.createCatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.BackColor = System.Drawing.Color.Salmon;
            this.createAnimalButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createAnimalButton.FlatAppearance.BorderSize = 3;
            this.createAnimalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createAnimalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createAnimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createAnimalButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAnimalButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.createAnimalButton.Location = new System.Drawing.Point(118, 103);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(195, 115);
            this.createAnimalButton.TabIndex = 0;
            this.createAnimalButton.Text = "Create an Animal";
            this.createAnimalButton.UseVisualStyleBackColor = false;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // createDogButton
            // 
            this.createDogButton.BackColor = System.Drawing.Color.Salmon;
            this.createDogButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createDogButton.FlatAppearance.BorderSize = 3;
            this.createDogButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createDogButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createDogButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createDogButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDogButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.createDogButton.Location = new System.Drawing.Point(118, 254);
            this.createDogButton.Name = "createDogButton";
            this.createDogButton.Size = new System.Drawing.Size(195, 115);
            this.createDogButton.TabIndex = 1;
            this.createDogButton.Text = "Create a Dog";
            this.createDogButton.UseVisualStyleBackColor = false;
            this.createDogButton.Click += new System.EventHandler(this.createDogButton_Click);
            // 
            // createCatButton
            // 
            this.createCatButton.BackColor = System.Drawing.Color.Salmon;
            this.createCatButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createCatButton.FlatAppearance.BorderSize = 3;
            this.createCatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createCatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createCatButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCatButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.createCatButton.Location = new System.Drawing.Point(118, 405);
            this.createCatButton.Name = "createCatButton";
            this.createCatButton.Size = new System.Drawing.Size(195, 115);
            this.createCatButton.TabIndex = 2;
            this.createCatButton.Text = "Create a Cat";
            this.createCatButton.UseVisualStyleBackColor = false;
            this.createCatButton.Click += new System.EventHandler(this.createCatButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.exitButton.Location = new System.Drawing.Point(118, 552);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(195, 115);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(440, 731);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createCatButton);
            this.Controls.Add(this.createDogButton);
            this.Controls.Add(this.createAnimalButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Polymorphism Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button createDogButton;
        private System.Windows.Forms.Button createCatButton;
        private System.Windows.Forms.Button exitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

