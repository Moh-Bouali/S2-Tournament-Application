namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    partial class CreateTournamentForm
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
            this.labelAddingTournament = new System.Windows.Forms.Label();
            this.labelMaxPlayers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStrtDate = new System.Windows.Forms.Label();
            this.labelSport = new System.Windows.Forms.Label();
            this.labelMinPlayers = new System.Windows.Forms.Label();
            this.numericUpDownMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSportType = new System.Windows.Forms.ComboBox();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.monthCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.textBoxTournamentName = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddingTournament
            // 
            this.labelAddingTournament.AutoSize = true;
            this.labelAddingTournament.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddingTournament.Location = new System.Drawing.Point(311, 9);
            this.labelAddingTournament.Name = "labelAddingTournament";
            this.labelAddingTournament.Size = new System.Drawing.Size(227, 32);
            this.labelAddingTournament.TabIndex = 0;
            this.labelAddingTournament.Text = "Adding Tournament";
            // 
            // labelMaxPlayers
            // 
            this.labelMaxPlayers.AutoSize = true;
            this.labelMaxPlayers.Location = new System.Drawing.Point(95, 307);
            this.labelMaxPlayers.Name = "labelMaxPlayers";
            this.labelMaxPlayers.Size = new System.Drawing.Size(132, 20);
            this.labelMaxPlayers.TabIndex = 1;
            this.labelMaxPlayers.Text = "Maximum Players :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ending Date :";
            // 
            // labelStrtDate
            // 
            this.labelStrtDate.AutoSize = true;
            this.labelStrtDate.Location = new System.Drawing.Point(3, 82);
            this.labelStrtDate.Name = "labelStrtDate";
            this.labelStrtDate.Size = new System.Drawing.Size(104, 20);
            this.labelStrtDate.TabIndex = 3;
            this.labelStrtDate.Text = "Starting Date :";
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Location = new System.Drawing.Point(12, 33);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(96, 20);
            this.labelSport.TabIndex = 5;
            this.labelSport.Text = "Select Sport :";
            // 
            // labelMinPlayers
            // 
            this.labelMinPlayers.AutoSize = true;
            this.labelMinPlayers.Location = new System.Drawing.Point(95, 360);
            this.labelMinPlayers.Name = "labelMinPlayers";
            this.labelMinPlayers.Size = new System.Drawing.Size(129, 20);
            this.labelMinPlayers.TabIndex = 6;
            this.labelMinPlayers.Text = "Minimum Players :";
            // 
            // numericUpDownMaxPlayers
            // 
            this.numericUpDownMaxPlayers.Location = new System.Drawing.Point(233, 307);
            this.numericUpDownMaxPlayers.Name = "numericUpDownMaxPlayers";
            this.numericUpDownMaxPlayers.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownMaxPlayers.TabIndex = 7;
            // 
            // numericUpDownMinPlayers
            // 
            this.numericUpDownMinPlayers.Location = new System.Drawing.Point(233, 358);
            this.numericUpDownMinPlayers.Name = "numericUpDownMinPlayers";
            this.numericUpDownMinPlayers.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownMinPlayers.TabIndex = 8;
            // 
            // comboBoxSportType
            // 
            this.comboBoxSportType.FormattingEnabled = true;
            this.comboBoxSportType.Location = new System.Drawing.Point(121, 33);
            this.comboBoxSportType.Name = "comboBoxSportType";
            this.comboBoxSportType.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSportType.TabIndex = 9;
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.BackColor = System.Drawing.Color.Salmon;
            this.buttonCreateTournament.Location = new System.Drawing.Point(646, 393);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(142, 71);
            this.buttonCreateTournament.TabIndex = 13;
            this.buttonCreateTournament.Text = "Create Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = false;
            this.buttonCreateTournament.Click += new System.EventHandler(this.buttonCreateTournament_Click);
            // 
            // monthCalendarStart
            // 
            this.monthCalendarStart.Location = new System.Drawing.Point(121, 82);
            this.monthCalendarStart.Name = "monthCalendarStart";
            this.monthCalendarStart.TabIndex = 14;
            // 
            // monthCalendarEnd
            // 
            this.monthCalendarEnd.Location = new System.Drawing.Point(494, 82);
            this.monthCalendarEnd.Name = "monthCalendarEnd";
            this.monthCalendarEnd.TabIndex = 15;
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.Location = new System.Drawing.Point(85, 400);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(139, 20);
            this.labelTournamentName.TabIndex = 18;
            this.labelTournamentName.Text = "Tournament Name :";
            // 
            // textBoxTournamentName
            // 
            this.textBoxTournamentName.Location = new System.Drawing.Point(233, 397);
            this.textBoxTournamentName.Name = "textBoxTournamentName";
            this.textBoxTournamentName.Size = new System.Drawing.Size(125, 27);
            this.textBoxTournamentName.TabIndex = 19;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Salmon;
            this.buttonBack.Location = new System.Drawing.Point(654, 1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(145, 60);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(494, 314);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(156, 20);
            this.labelLocation.TabIndex = 21;
            this.labelLocation.Text = "Tournament Location :";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(654, 307);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(125, 27);
            this.textBoxLocation.TabIndex = 22;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxTournamentName);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.monthCalendarEnd);
            this.Controls.Add(this.monthCalendarStart);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.comboBoxSportType);
            this.Controls.Add(this.numericUpDownMinPlayers);
            this.Controls.Add(this.numericUpDownMaxPlayers);
            this.Controls.Add(this.labelMinPlayers);
            this.Controls.Add(this.labelSport);
            this.Controls.Add(this.labelStrtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMaxPlayers);
            this.Controls.Add(this.labelAddingTournament);
            this.Name = "CreateTournamentForm";
            this.Text = "CreatingTournamentForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAddingTournament;
        private Label labelMaxPlayers;
        private Label label2;
        private Label labelStrtDate;
        private Label labelSport;
        private Label labelMinPlayers;
        private NumericUpDown numericUpDownMaxPlayers;
        private NumericUpDown numericUpDownMinPlayers;
        private ComboBox comboBoxSportType;
        private Button buttonCreateTournament;
        private MonthCalendar monthCalendarStart;
        private MonthCalendar monthCalendarEnd;
        private Label labelTournamentName;
        private TextBox textBoxTournamentName;
        private Button buttonBack;
        private Label labelLocation;
        private TextBox textBoxLocation;
    }
}