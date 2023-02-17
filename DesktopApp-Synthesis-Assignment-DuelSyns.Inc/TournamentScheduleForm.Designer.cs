namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    partial class TournamentScheduleForm
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
            this.listBoxTournamentScehdule = new System.Windows.Forms.ListBox();
            this.buttonCreateSchedule = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSaveGameResult = new System.Windows.Forms.Button();
            this.labelIDTrnmnt = new System.Windows.Forms.Label();
            this.labeIdToShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTournamentScehdule
            // 
            this.listBoxTournamentScehdule.FormattingEnabled = true;
            this.listBoxTournamentScehdule.ItemHeight = 20;
            this.listBoxTournamentScehdule.Location = new System.Drawing.Point(121, 52);
            this.listBoxTournamentScehdule.Name = "listBoxTournamentScehdule";
            this.listBoxTournamentScehdule.Size = new System.Drawing.Size(529, 224);
            this.listBoxTournamentScehdule.TabIndex = 0;
            // 
            // buttonCreateSchedule
            // 
            this.buttonCreateSchedule.Location = new System.Drawing.Point(664, 344);
            this.buttonCreateSchedule.Name = "buttonCreateSchedule";
            this.buttonCreateSchedule.Size = new System.Drawing.Size(124, 61);
            this.buttonCreateSchedule.TabIndex = 1;
            this.buttonCreateSchedule.Text = "Create Schedule";
            this.buttonCreateSchedule.UseVisualStyleBackColor = true;
            this.buttonCreateSchedule.Click += new System.EventHandler(this.buttonCreateSchedule_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 344);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(124, 61);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSaveGameResult
            // 
            this.buttonSaveGameResult.Location = new System.Drawing.Point(329, 344);
            this.buttonSaveGameResult.Name = "buttonSaveGameResult";
            this.buttonSaveGameResult.Size = new System.Drawing.Size(124, 61);
            this.buttonSaveGameResult.TabIndex = 3;
            this.buttonSaveGameResult.Text = "Save Result";
            this.buttonSaveGameResult.UseVisualStyleBackColor = true;
            this.buttonSaveGameResult.Click += new System.EventHandler(this.buttonSaveGameResult_Click);
            // 
            // labelIDTrnmnt
            // 
            this.labelIDTrnmnt.AutoSize = true;
            this.labelIDTrnmnt.Location = new System.Drawing.Point(247, 16);
            this.labelIDTrnmnt.Name = "labelIDTrnmnt";
            this.labelIDTrnmnt.Size = new System.Drawing.Size(114, 20);
            this.labelIDTrnmnt.TabIndex = 4;
            this.labelIDTrnmnt.Text = "Tournament ID :";
            // 
            // labeIdToShow
            // 
            this.labeIdToShow.AutoSize = true;
            this.labeIdToShow.Location = new System.Drawing.Point(357, 16);
            this.labeIdToShow.Name = "labeIdToShow";
            this.labeIdToShow.Size = new System.Drawing.Size(24, 20);
            this.labeIdToShow.TabIndex = 5;
            this.labeIdToShow.Text = "ID";
            // 
            // TournamentScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeIdToShow);
            this.Controls.Add(this.labelIDTrnmnt);
            this.Controls.Add(this.buttonSaveGameResult);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCreateSchedule);
            this.Controls.Add(this.listBoxTournamentScehdule);
            this.Name = "TournamentScheduleForm";
            this.Text = "TournamentScheduleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxTournamentScehdule;
        private Button buttonCreateSchedule;
        private Button buttonBack;
        private Button buttonSaveGameResult;
        private Label labelIDTrnmnt;
        private Label labeIdToShow;
    }
}