namespace find_a_word
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
            this.firstQuestion = new System.Windows.Forms.Label();
            this.typeIt = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.showPath = new System.Windows.Forms.TextBox();
            this.showWords = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstQuestion
            // 
            this.firstQuestion.AutoSize = true;
            this.firstQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestion.Location = new System.Drawing.Point(280, 23);
            this.firstQuestion.Name = "firstQuestion";
            this.firstQuestion.Size = new System.Drawing.Size(239, 25);
            this.firstQuestion.TabIndex = 0;
            this.firstQuestion.Text = "what word do you search?";
            this.firstQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeIt
            // 
            this.typeIt.AutoSize = true;
            this.typeIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeIt.Location = new System.Drawing.Point(154, 102);
            this.typeIt.Name = "typeIt";
            this.typeIt.Size = new System.Drawing.Size(166, 25);
            this.typeIt.TabIndex = 1;
            this.typeIt.Text = "Type it and Enter!";
            this.typeIt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.Location = new System.Drawing.Point(392, 104);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(332, 24);
            this.word.TabIndex = 2;
            this.word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter the file path!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browse
            // 
            this.browse.AutoSize = true;
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(26, 264);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(95, 35);
            this.browse.TabIndex = 4;
            this.browse.Text = "open file";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.pathInput);
            // 
            // showPath
            // 
            this.showPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPath.Location = new System.Drawing.Point(159, 269);
            this.showPath.Name = "showPath";
            this.showPath.ReadOnly = true;
            this.showPath.Size = new System.Drawing.Size(565, 30);
            this.showPath.TabIndex = 5;
            // 
            // showWords
            // 
            this.showWords.AutoSize = true;
            this.showWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showWords.Location = new System.Drawing.Point(159, 398);
            this.showWords.Name = "showWords";
            this.showWords.Size = new System.Drawing.Size(471, 25);
            this.showWords.TabIndex = 6;
            this.showWords.Text = "Press F3 to see the words found, or press Esc to exit!";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.AntiqueWhite;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(159, 346);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(565, 30);
            this.result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.result);
            this.Controls.Add(this.showWords);
            this.Controls.Add(this.showPath);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word);
            this.Controls.Add(this.typeIt);
            this.Controls.Add(this.firstQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.showResult);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstQuestion;
        private System.Windows.Forms.Label typeIt;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox showPath;
        private System.Windows.Forms.Label showWords;
        private System.Windows.Forms.TextBox result;
    }
}

