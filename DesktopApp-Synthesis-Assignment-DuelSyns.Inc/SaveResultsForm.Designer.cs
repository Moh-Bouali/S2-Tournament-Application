namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    partial class SaveResultsForm
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
            this.labelScorePlayer1 = new System.Windows.Forms.Label();
            this.labelScorePlayer2 = new System.Windows.Forms.Label();
            this.textBoxScorePlyr1 = new System.Windows.Forms.TextBox();
            this.textBoxScorePlyr2 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelScoreOf1 = new System.Windows.Forms.Label();
            this.labelScoreOf2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScorePlayer1
            // 
            this.labelScorePlayer1.AutoSize = true;
            this.labelScorePlayer1.Location = new System.Drawing.Point(63, 82);
            this.labelScorePlayer1.Name = "labelScorePlayer1";
            this.labelScorePlayer1.Size = new System.Drawing.Size(73, 20);
            this.labelScorePlayer1.TabIndex = 0;
            this.labelScorePlayer1.Text = "Score Of :";
            // 
            // labelScorePlayer2
            // 
            this.labelScorePlayer2.AutoSize = true;
            this.labelScorePlayer2.Location = new System.Drawing.Point(63, 131);
            this.labelScorePlayer2.Name = "labelScorePlayer2";
            this.labelScorePlayer2.Size = new System.Drawing.Size(73, 20);
            this.labelScorePlayer2.TabIndex = 1;
            this.labelScorePlayer2.Text = "Score Of :";
            // 
            // textBoxScorePlyr1
            // 
            this.textBoxScorePlyr1.Location = new System.Drawing.Point(225, 79);
            this.textBoxScorePlyr1.Name = "textBoxScorePlyr1";
            this.textBoxScorePlyr1.Size = new System.Drawing.Size(125, 27);
            this.textBoxScorePlyr1.TabIndex = 2;
            // 
            // textBoxScorePlyr2
            // 
            this.textBoxScorePlyr2.Location = new System.Drawing.Point(225, 128);
            this.textBoxScorePlyr2.Name = "textBoxScorePlyr2";
            this.textBoxScorePlyr2.Size = new System.Drawing.Size(125, 27);
            this.textBoxScorePlyr2.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(63, 227);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(448, 227);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 29);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelScoreOf1
            // 
            this.labelScoreOf1.AutoSize = true;
            this.labelScoreOf1.Location = new System.Drawing.Point(142, 82);
            this.labelScoreOf1.Name = "labelScoreOf1";
            this.labelScoreOf1.Size = new System.Drawing.Size(12, 20);
            this.labelScoreOf1.TabIndex = 6;
            this.labelScoreOf1.Text = ":";
            // 
            // labelScoreOf2
            // 
            this.labelScoreOf2.AutoSize = true;
            this.labelScoreOf2.Location = new System.Drawing.Point(142, 131);
            this.labelScoreOf2.Name = "labelScoreOf2";
            this.labelScoreOf2.Size = new System.Drawing.Size(12, 20);
            this.labelScoreOf2.TabIndex = 7;
            this.labelScoreOf2.Text = ":";
            // 
            // SaveResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(587, 294);
            this.Controls.Add(this.labelScoreOf2);
            this.Controls.Add(this.labelScoreOf1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxScorePlyr2);
            this.Controls.Add(this.textBoxScorePlyr1);
            this.Controls.Add(this.labelScorePlayer2);
            this.Controls.Add(this.labelScorePlayer1);
            this.Name = "SaveResultsForm";
            this.Text = "SaveResultsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelScorePlayer1;
        private Label labelScorePlayer2;
        private TextBox textBoxScorePlyr1;
        private TextBox textBoxScorePlyr2;
        private Button buttonSave;
        private Button buttonBack;
        private Label labelScoreOf1;
        private Label labelScoreOf2;
    }
}