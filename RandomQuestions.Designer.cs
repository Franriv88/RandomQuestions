namespace RandomQuestions
{
    partial class Shuffle
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
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.labelRandomQuestions = new System.Windows.Forms.Label();
            this.labelSetNumbers = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(178, 111);
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumbers.TabIndex = 2;
            // 
            // labelRandomQuestions
            // 
            this.labelRandomQuestions.AutoSize = true;
            this.labelRandomQuestions.Location = new System.Drawing.Point(175, 23);
            this.labelRandomQuestions.Name = "labelRandomQuestions";
            this.labelRandomQuestions.Size = new System.Drawing.Size(97, 13);
            this.labelRandomQuestions.TabIndex = 3;
            this.labelRandomQuestions.Text = "Random Questions";
            // 
            // labelSetNumbers
            // 
            this.labelSetNumbers.AutoSize = true;
            this.labelSetNumbers.Location = new System.Drawing.Point(164, 95);
            this.labelSetNumbers.Name = "labelSetNumbers";
            this.labelSetNumbers.Size = new System.Drawing.Size(142, 13);
            this.labelSetNumbers.TabIndex = 4;
            this.labelSetNumbers.Text = "Set the number of questions:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(604, 58);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(38, 13);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Stock:";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(604, 77);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(53, 13);
            this.labelAvailable.TabIndex = 6;
            this.labelAvailable.Text = "Available:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Image = global::RandomQuestions.Properties.Resources.copy__black_;
            this.buttonCopy.Location = new System.Drawing.Point(393, 96);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(51, 48);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Image = global::RandomQuestions.Properties.Resources.random;
            this.buttonShuffle.Location = new System.Drawing.Point(335, 96);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(52, 48);
            this.buttonShuffle.TabIndex = 0;
            this.buttonShuffle.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(713, 3);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 8;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 230);
            this.dataGridView1.TabIndex = 9;
            // 
            // Shuffle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelSetNumbers);
            this.Controls.Add(this.labelRandomQuestions);
            this.Controls.Add(this.textBoxNumbers);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonShuffle);
            this.Name = "Shuffle";
            this.Text = "Shuffle";
            this.Load += new System.EventHandler(this.Shuffle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.Label labelRandomQuestions;
        private System.Windows.Forms.Label labelSetNumbers;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}