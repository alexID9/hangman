namespace hangman
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
            titlelbl = new Label();
            sendbtn = new Button();
            errorlbl = new Label();
            guesslbl = new Label();
            lettertxt = new TextBox();
            hangmanpicturebox = new PictureBox();
            wordlbl = new Label();
            errornum = new Label();
            ((System.ComponentModel.ISupportInitialize)hangmanpicturebox).BeginInit();
            SuspendLayout();
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            titlelbl.Location = new Point(358, 48);
            titlelbl.Margin = new Padding(5, 0, 5, 0);
            titlelbl.Name = "titlelbl";
            titlelbl.Size = new Size(153, 45);
            titlelbl.TabIndex = 0;
            titlelbl.Text = "hangman";
            // 
            // sendbtn
            // 
            sendbtn.Location = new Point(133, 355);
            sendbtn.Name = "sendbtn";
            sendbtn.Size = new Size(100, 50);
            sendbtn.TabIndex = 2;
            sendbtn.Text = "send";
            sendbtn.UseVisualStyleBackColor = true;
            sendbtn.Click += sendbtn_Click;
            // 
            // errorlbl
            // 
            errorlbl.AutoSize = true;
            errorlbl.Location = new Point(50, 150);
            errorlbl.Name = "errorlbl";
            errorlbl.Size = new Size(131, 45);
            errorlbl.TabIndex = 3;
            errorlbl.Text = "# errors";
            // 
            // guesslbl
            // 
            guesslbl.AutoSize = true;
            guesslbl.Location = new Point(50, 250);
            guesslbl.Name = "guesslbl";
            guesslbl.Size = new Size(102, 45);
            guesslbl.TabIndex = 4;
            guesslbl.Text = "guess";
            // 
            // lettertxt
            // 
            lettertxt.Location = new Point(183, 245);
            lettertxt.Name = "lettertxt";
            lettertxt.Size = new Size(50, 50);
            lettertxt.TabIndex = 5;
            // 
            // hangmanpicturebox
            // 
            hangmanpicturebox.Location = new Point(450, 150);
            hangmanpicturebox.Name = "hangmanpicturebox";
            hangmanpicturebox.Size = new Size(300, 600);
            hangmanpicturebox.TabIndex = 6;
            hangmanpicturebox.TabStop = false;
            // 
            // wordlbl
            // 
            wordlbl.AutoSize = true;
            wordlbl.Location = new Point(152, 497);
            wordlbl.Name = "wordlbl";
            wordlbl.Size = new Size(0, 45);
            wordlbl.TabIndex = 7;
            // 
            // errornum
            // 
            errornum.AutoSize = true;
            errornum.Location = new Point(183, 150);
            errornum.Name = "errornum";
            errornum.Size = new Size(37, 45);
            errornum.TabIndex = 8;
            errornum.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 844);
            Controls.Add(errornum);
            Controls.Add(wordlbl);
            Controls.Add(hangmanpicturebox);
            Controls.Add(lettertxt);
            Controls.Add(guesslbl);
            Controls.Add(errorlbl);
            Controls.Add(sendbtn);
            Controls.Add(titlelbl);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "hangman";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)hangmanpicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlelbl;
        private Button sendbtn;
        private Label errorlbl;
        private Label guesslbl;
        private TextBox lettertxt;
        private PictureBox hangmanpicturebox;
        private Label wordlbl;
        private Label errornum;
    }
}