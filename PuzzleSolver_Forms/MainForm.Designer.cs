namespace PuzzleSolver_Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSolve = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_2_2 = new System.Windows.Forms.Button();
            this.btn_2_1 = new System.Windows.Forms.Button();
            this.btn_2_0 = new System.Windows.Forms.Button();
            this.btn_1_2 = new System.Windows.Forms.Button();
            this.btn_1_1 = new System.Windows.Forms.Button();
            this.btn_1_0 = new System.Windows.Forms.Button();
            this.btn_0_2 = new System.Windows.Forms.Button();
            this.btn_0_1 = new System.Windows.Forms.Button();
            this.btn_0_0 = new System.Windows.Forms.Button();
            this.btnSetCurrentState = new System.Windows.Forms.Button();
            this.btnSetGoalState = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.timerSolving = new System.Windows.Forms.Timer(this.components);
            this.btnShuffle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPleaseWait = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSolve.Location = new System.Drawing.Point(6, 125);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(214, 45);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.TabStop = false;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_2_2);
            this.panel1.Controls.Add(this.btn_2_1);
            this.panel1.Controls.Add(this.btn_2_0);
            this.panel1.Controls.Add(this.btn_1_2);
            this.panel1.Controls.Add(this.btn_1_1);
            this.panel1.Controls.Add(this.btn_1_0);
            this.panel1.Controls.Add(this.btn_0_2);
            this.panel1.Controls.Add(this.btn_0_1);
            this.panel1.Controls.Add(this.btn_0_0);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(311, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 2;
            // 
            // btn_2_2
            // 
            this.btn_2_2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2_2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2_2.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_2_2.Location = new System.Drawing.Point(100, 100);
            this.btn_2_2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_2_2.Name = "btn_2_2";
            this.btn_2_2.Size = new System.Drawing.Size(50, 50);
            this.btn_2_2.TabIndex = 0;
            this.btn_2_2.TabStop = false;
            this.btn_2_2.Text = "0";
            this.btn_2_2.UseVisualStyleBackColor = false;
            this.btn_2_2.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btn_2_1
            // 
            this.btn_2_1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2_1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2_1.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_2_1.Location = new System.Drawing.Point(50, 100);
            this.btn_2_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_2_1.Name = "btn_2_1";
            this.btn_2_1.Size = new System.Drawing.Size(50, 50);
            this.btn_2_1.TabIndex = 0;
            this.btn_2_1.TabStop = false;
            this.btn_2_1.Text = "8";
            this.btn_2_1.UseVisualStyleBackColor = false;
            this.btn_2_1.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btn_2_0
            // 
            this.btn_2_0.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_2_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2_0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2_0.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_2_0.Location = new System.Drawing.Point(0, 100);
            this.btn_2_0.Margin = new System.Windows.Forms.Padding(0);
            this.btn_2_0.Name = "btn_2_0";
            this.btn_2_0.Size = new System.Drawing.Size(50, 50);
            this.btn_2_0.TabIndex = 0;
            this.btn_2_0.TabStop = false;
            this.btn_2_0.Text = "7";
            this.btn_2_0.UseVisualStyleBackColor = false;
            this.btn_2_0.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btn_1_2
            // 
            this.btn_1_2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1_2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1_2.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_1_2.Location = new System.Drawing.Point(100, 50);
            this.btn_1_2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_1_2.Name = "btn_1_2";
            this.btn_1_2.Size = new System.Drawing.Size(50, 50);
            this.btn_1_2.TabIndex = 0;
            this.btn_1_2.TabStop = false;
            this.btn_1_2.Text = "6";
            this.btn_1_2.UseVisualStyleBackColor = false;
            this.btn_1_2.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btn_1_1
            // 
            this.btn_1_1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1_1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1_1.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_1_1.Location = new System.Drawing.Point(50, 50);
            this.btn_1_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_1_1.Name = "btn_1_1";
            this.btn_1_1.Size = new System.Drawing.Size(50, 50);
            this.btn_1_1.TabIndex = 0;
            this.btn_1_1.TabStop = false;
            this.btn_1_1.Text = "5";
            this.btn_1_1.UseVisualStyleBackColor = false;
            this.btn_1_1.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btn_1_0
            // 
            this.btn_1_0.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_1_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1_0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1_0.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_1_0.Location = new System.Drawing.Point(0, 50);
            this.btn_1_0.Margin = new System.Windows.Forms.Padding(0);
            this.btn_1_0.Name = "btn_1_0";
            this.btn_1_0.Size = new System.Drawing.Size(50, 50);
            this.btn_1_0.TabIndex = 0;
            this.btn_1_0.TabStop = false;
            this.btn_1_0.Text = "4";
            this.btn_1_0.UseVisualStyleBackColor = false;
            this.btn_1_0.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btn_0_2
            // 
            this.btn_0_2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_0_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0_2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0_2.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_0_2.Location = new System.Drawing.Point(100, 0);
            this.btn_0_2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_0_2.Name = "btn_0_2";
            this.btn_0_2.Size = new System.Drawing.Size(50, 50);
            this.btn_0_2.TabIndex = 0;
            this.btn_0_2.TabStop = false;
            this.btn_0_2.Text = "3";
            this.btn_0_2.UseVisualStyleBackColor = false;
            this.btn_0_2.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btn_0_1
            // 
            this.btn_0_1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_0_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0_1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0_1.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_0_1.Location = new System.Drawing.Point(50, 0);
            this.btn_0_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_0_1.Name = "btn_0_1";
            this.btn_0_1.Size = new System.Drawing.Size(50, 50);
            this.btn_0_1.TabIndex = 0;
            this.btn_0_1.TabStop = false;
            this.btn_0_1.Text = "2";
            this.btn_0_1.UseVisualStyleBackColor = false;
            this.btn_0_1.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btn_0_0
            // 
            this.btn_0_0.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_0_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0_0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0_0.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_0_0.Location = new System.Drawing.Point(0, 0);
            this.btn_0_0.Margin = new System.Windows.Forms.Padding(0);
            this.btn_0_0.Name = "btn_0_0";
            this.btn_0_0.Size = new System.Drawing.Size(50, 50);
            this.btn_0_0.TabIndex = 0;
            this.btn_0_0.TabStop = false;
            this.btn_0_0.Text = "1";
            this.btn_0_0.UseVisualStyleBackColor = false;
            this.btn_0_0.Click += new System.EventHandler(this.Button_Pressed);
            // 
            // btnSetCurrentState
            // 
            this.btnSetCurrentState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetCurrentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCurrentState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSetCurrentState.Location = new System.Drawing.Point(6, 20);
            this.btnSetCurrentState.Name = "btnSetCurrentState";
            this.btnSetCurrentState.Size = new System.Drawing.Size(104, 48);
            this.btnSetCurrentState.TabIndex = 3;
            this.btnSetCurrentState.TabStop = false;
            this.btnSetCurrentState.Text = "Set Current";
            this.btnSetCurrentState.UseVisualStyleBackColor = true;
            this.btnSetCurrentState.Click += new System.EventHandler(this.btnSetCurrentState_Click);
            // 
            // btnSetGoalState
            // 
            this.btnSetGoalState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetGoalState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetGoalState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSetGoalState.Location = new System.Drawing.Point(116, 20);
            this.btnSetGoalState.Name = "btnSetGoalState";
            this.btnSetGoalState.Size = new System.Drawing.Size(104, 48);
            this.btnSetGoalState.TabIndex = 3;
            this.btnSetGoalState.TabStop = false;
            this.btnSetGoalState.Text = "Set Goal";
            this.btnSetGoalState.UseVisualStyleBackColor = true;
            this.btnSetGoalState.Click += new System.EventHandler(this.btnSetGoalState_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblPleaseWait);
            this.pnlMain.Controls.Add(this.progressBar1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(510, 370);
            this.pnlMain.TabIndex = 13;
            // 
            // timerSolving
            // 
            this.timerSolving.Interval = 500;
            this.timerSolving.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShuffle
            // 
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShuffle.Location = new System.Drawing.Point(6, 75);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(104, 43);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.TabStop = false;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(308, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 56);
            this.label1.TabIndex = 15;
            this.label1.Text = "8 Puzzle";
            // 
            // btnUndo
            // 
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUndo.Location = new System.Drawing.Point(116, 75);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(104, 43);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.TabStop = false;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetCurrentState);
            this.groupBox1.Controls.Add(this.btnSetGoalState);
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.btnSolve);
            this.groupBox1.Controls.Add(this.btnShuffle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 177);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puzzle Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(325, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "All rights reserved\r\nBashir Manafikhi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseWait.Location = new System.Drawing.Point(35, 246);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.Size = new System.Drawing.Size(217, 94);
            this.lblPleaseWait.TabIndex = 18;
            this.lblPleaseWait.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 223);
            this.progressBar1.MarqueeAnimationSpeed = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Value = 25;
            this.progressBar1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 370);
            this.Controls.Add(this.pnlMain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_2_2;
        private System.Windows.Forms.Button btn_2_1;
        private System.Windows.Forms.Button btn_2_0;
        private System.Windows.Forms.Button btn_1_2;
        private System.Windows.Forms.Button btn_1_1;
        private System.Windows.Forms.Button btn_1_0;
        private System.Windows.Forms.Button btn_0_2;
        private System.Windows.Forms.Button btn_0_1;
        private System.Windows.Forms.Button btn_0_0;
        private System.Windows.Forms.Button btnSetCurrentState;
        private System.Windows.Forms.Button btnSetGoalState;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Timer timerSolving;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPleaseWait;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

