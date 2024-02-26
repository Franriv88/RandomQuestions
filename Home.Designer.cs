namespace RandomQuestions
{
    partial class Home
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonImport = new System.Windows.Forms.Button();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelSetNumbers = new System.Windows.Forms.Label();
            this.labelRandomQuestions = new System.Windows.Forms.Label();
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 230);
            this.dataGridView1.TabIndex = 18;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(713, 29);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 17;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click_1);
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(604, 103);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(53, 13);
            this.labelAvailable.TabIndex = 16;
            this.labelAvailable.Text = "Available:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(604, 84);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(38, 13);
            this.labelStock.TabIndex = 15;
            this.labelStock.Text = "Stock:";
            // 
            // labelSetNumbers
            // 
            this.labelSetNumbers.AutoSize = true;
            this.labelSetNumbers.Location = new System.Drawing.Point(30, 140);
            this.labelSetNumbers.Name = "labelSetNumbers";
            this.labelSetNumbers.Size = new System.Drawing.Size(142, 13);
            this.labelSetNumbers.TabIndex = 14;
            this.labelSetNumbers.Text = "Set the number of questions:";
            // 
            // labelRandomQuestions
            // 
            this.labelRandomQuestions.AutoSize = true;
            this.labelRandomQuestions.Location = new System.Drawing.Point(175, 49);
            this.labelRandomQuestions.Name = "labelRandomQuestions";
            this.labelRandomQuestions.Size = new System.Drawing.Size(97, 13);
            this.labelRandomQuestions.TabIndex = 13;
            this.labelRandomQuestions.Text = "Random Questions";
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(178, 137);
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(34, 20);
            this.textBoxNumbers.TabIndex = 12;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Image = global::RandomQuestions.Properties.Resources.copy__black_;
            this.buttonCopy.Location = new System.Drawing.Point(393, 122);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(51, 48);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Image = global::RandomQuestions.Properties.Resources.random;
            this.buttonShuffle.Location = new System.Drawing.Point(335, 122);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(52, 48);
            this.buttonShuffle.TabIndex = 10;
            this.buttonShuffle.UseVisualStyleBackColor = true;
            // 
            // Home
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
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelSetNumbers;
        private System.Windows.Forms.Label labelRandomQuestions;
        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonShuffle;
    }
}