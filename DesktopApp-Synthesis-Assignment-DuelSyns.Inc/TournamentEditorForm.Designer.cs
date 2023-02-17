namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    partial class TournamentEditorForm
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMinPlayers = new System.Windows.Forms.Label();
            this.labelMaxPlayers = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.monthCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelShowIdHere = new System.Windows.Forms.Label();
            this.labelIDShow = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxMaxPlayers = new System.Windows.Forms.TextBox();
            this.textBoxMinPlayers = new System.Windows.Forms.TextBox();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(368, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(270, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name :";
            // 
            // labelMinPlayers
            // 
            this.labelMinPlayers.AutoSize = true;
            this.labelMinPlayers.Location = new System.Drawing.Point(196, 137);
            this.labelMinPlayers.Name = "labelMinPlayers";
            this.labelMinPlayers.Size = new System.Drawing.Size(130, 20);
            this.labelMinPlayers.TabIndex = 2;
            this.labelMinPlayers.Text = "Minimum players :";
            // 
            // labelMaxPlayers
            // 
            this.labelMaxPlayers.AutoSize = true;
            this.labelMaxPlayers.Location = new System.Drawing.Point(232, 91);
            this.labelMaxPlayers.Name = "labelMaxPlayers";
            this.labelMaxPlayers.Size = new System.Drawing.Size(94, 20);
            this.labelMaxPlayers.TabIndex = 3;
            this.labelMaxPlayers.Text = "Max Players :";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(64, 209);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(104, 20);
            this.labelStartDate.TabIndex = 4;
            this.labelStartDate.Text = "Starting Date :";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(435, 209);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(77, 20);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "End Date :";
            // 
            // monthCalendarStart
            // 
            this.monthCalendarStart.Location = new System.Drawing.Point(170, 238);
            this.monthCalendarStart.Name = "monthCalendarStart";
            this.monthCalendarStart.TabIndex = 6;
            this.monthCalendarStart.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarStart_DateSelected);
            // 
            // monthCalendarEnd
            // 
            this.monthCalendarEnd.Location = new System.Drawing.Point(511, 238);
            this.monthCalendarEnd.Name = "monthCalendarEnd";
            this.monthCalendarEnd.TabIndex = 7;
            this.monthCalendarEnd.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarEnd_DateSelected);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(332, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 8;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Beige;
            this.buttonConfirm.Location = new System.Drawing.Point(646, 113);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(127, 69);
            this.buttonConfirm.TabIndex = 11;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelShowIdHere
            // 
            this.labelShowIdHere.AutoSize = true;
            this.labelShowIdHere.Location = new System.Drawing.Point(405, 22);
            this.labelShowIdHere.Name = "labelShowIdHere";
            this.labelShowIdHere.Size = new System.Drawing.Size(0, 20);
            this.labelShowIdHere.TabIndex = 12;
            // 
            // labelIDShow
            // 
            this.labelIDShow.AutoSize = true;
            this.labelIDShow.Location = new System.Drawing.Point(401, 22);
            this.labelIDShow.Name = "labelIDShow";
            this.labelIDShow.Size = new System.Drawing.Size(31, 20);
            this.labelIDShow.TabIndex = 13;
            this.labelIDShow.Text = "ID :";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Beige;
            this.buttonBack.Location = new System.Drawing.Point(12, 376);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 69);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxMaxPlayers
            // 
            this.textBoxMaxPlayers.Location = new System.Drawing.Point(332, 88);
            this.textBoxMaxPlayers.Name = "textBoxMaxPlayers";
            this.textBoxMaxPlayers.Size = new System.Drawing.Size(125, 27);
            this.textBoxMaxPlayers.TabIndex = 17;
            // 
            // textBoxMinPlayers
            // 
            this.textBoxMinPlayers.Location = new System.Drawing.Point(332, 134);
            this.textBoxMinPlayers.Name = "textBoxMinPlayers";
            this.textBoxMinPlayers.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinPlayers.TabIndex = 18;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(511, 206);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxEndDate.TabIndex = 19;
            this.textBoxEndDate.Click += new System.EventHandler(this.textBoxEndDate_Click);
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(170, 206);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxStartDate.TabIndex = 20;
            this.textBoxStartDate.Click += new System.EventHandler(this.textBoxStartDate_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(253, 177);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(73, 20);
            this.labelLocation.TabIndex = 21;
            this.labelLocation.Text = "Location :";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(332, 174);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(125, 27);
            this.textBoxLocation.TabIndex = 22;
            // 
            // TournamentEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.textBoxMinPlayers);
            this.Controls.Add(this.textBoxMaxPlayers);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelIDShow);
            this.Controls.Add(this.labelShowIdHere);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.monthCalendarEnd);
            this.Controls.Add(this.monthCalendarStart);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelMaxPlayers);
            this.Controls.Add(this.labelMinPlayers);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "TournamentEditorForm";
            this.Text = "TournamentEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelID;
        private Label labelName;
        private Label labelMinPlayers;
        private Label labelMaxPlayers;
        private Label labelStartDate;
        private Label labelEndDate;
        private MonthCalendar monthCalendarStart;
        private MonthCalendar monthCalendarEnd;
        private TextBox textBoxName;
        private Button buttonConfirm;
        private Label labelShowIdHere;
        private Label labelIDShow;
        private Button buttonBack;
        private TextBox textBoxMaxPlayers;
        private TextBox textBoxMinPlayers;
        private TextBox textBoxEndDate;
        private TextBox textBoxStartDate;
        private Label labelLocation;
        private TextBox textBoxLocation;
    }
}