
using NAudio.Wave;

namespace SplitAudioFile
{
    partial class AudioSlicer
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
            this.chooseAudioL = new System.Windows.Forms.Label();
            this.timerL = new System.Windows.Forms.Label();
            this.showNameT = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopB = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.startRecordBtn = new System.Windows.Forms.Button();
            this.stopRecordBtn = new System.Windows.Forms.Button();
            this.saveRecordBtn = new System.Windows.Forms.Button();
            this.nameOnRecordL = new System.Windows.Forms.Label();
            this.nameRecordT = new System.Windows.Forms.TextBox();
            this.timerAudio = new System.Windows.Forms.Timer(this.components);
            this.showTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseAudioL
            // 
            this.chooseAudioL.AutoSize = true;
            this.chooseAudioL.Location = new System.Drawing.Point(30, 28);
            this.chooseAudioL.Name = "chooseAudioL";
            this.chooseAudioL.Size = new System.Drawing.Size(115, 16);
            this.chooseAudioL.TabIndex = 0;
            this.chooseAudioL.Text = "Изберете аудио";
            // 
            // timerL
            // 
            this.timerL.Location = new System.Drawing.Point(0, 0);
            this.timerL.Name = "timerL";
            this.timerL.Size = new System.Drawing.Size(100, 23);
            this.timerL.TabIndex = 14;
            // 
            // showNameT
            // 
            this.showNameT.Location = new System.Drawing.Point(33, 60);
            this.showNameT.Multiline = true;
            this.showNameT.Name = "showNameT";
            this.showNameT.Size = new System.Drawing.Size(788, 37);
            this.showNameT.TabIndex = 2;
            this.showNameT.TextChanged += new System.EventHandler(this.ShowNameT);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(33, 123);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(138, 67);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Пусни";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(177, 123);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(138, 67);
            this.pauseBtn.TabIndex = 13;
            this.pauseBtn.Text = "Пауза";
            this.pauseBtn.Click += new System.EventHandler(this.PauseAudioBtn);
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(321, 123);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(138, 67);
            this.stopB.TabIndex = 12;
            this.stopB.Text = "Спри";
            this.stopB.Click += new System.EventHandler(this.StopAudioBtn);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(844, 30);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(138, 67);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Търси";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // startRecordBtn
            // 
            this.startRecordBtn.Location = new System.Drawing.Point(33, 344);
            this.startRecordBtn.Name = "startRecordBtn";
            this.startRecordBtn.Size = new System.Drawing.Size(138, 67);
            this.startRecordBtn.TabIndex = 7;
            this.startRecordBtn.Text = "Започни запис";
            this.startRecordBtn.UseVisualStyleBackColor = true;
            this.startRecordBtn.Click += new System.EventHandler(this.StartRecordBtn);
            // 
            // stopRecordBtn
            // 
            this.stopRecordBtn.Location = new System.Drawing.Point(177, 344);
            this.stopRecordBtn.Name = "stopRecordBtn";
            this.stopRecordBtn.Size = new System.Drawing.Size(138, 67);
            this.stopRecordBtn.TabIndex = 8;
            this.stopRecordBtn.Text = "Спри записа";
            this.stopRecordBtn.UseVisualStyleBackColor = true;
            this.stopRecordBtn.Click += new System.EventHandler(this.StopRecordBtn);
            // 
            // saveRecordBtn
            // 
            this.saveRecordBtn.Location = new System.Drawing.Point(844, 344);
            this.saveRecordBtn.Name = "saveRecordBtn";
            this.saveRecordBtn.Size = new System.Drawing.Size(138, 67);
            this.saveRecordBtn.TabIndex = 9;
            this.saveRecordBtn.Text = "Запази";
            this.saveRecordBtn.UseVisualStyleBackColor = true;
            this.saveRecordBtn.Click += new System.EventHandler(this.SaveRecordBtn);
            // 
            // nameOnRecordL
            // 
            this.nameOnRecordL.AutoSize = true;
            this.nameOnRecordL.Location = new System.Drawing.Point(321, 353);
            this.nameOnRecordL.Name = "nameOnRecordL";
            this.nameOnRecordL.Size = new System.Drawing.Size(103, 16);
            this.nameOnRecordL.TabIndex = 10;
            this.nameOnRecordL.Text = "Име на записа";
            // 
            // nameRecordT
            // 
            this.nameRecordT.Location = new System.Drawing.Point(321, 373);
            this.nameRecordT.Multiline = true;
            this.nameRecordT.Name = "nameRecordT";
            this.nameRecordT.Size = new System.Drawing.Size(500, 37);
            this.nameRecordT.TabIndex = 11;
            // 
            // timerAudio
            // 
            this.timerAudio.Interval = 1000;
            this.timerAudio.Tick += new System.EventHandler(this.TimerAudio);
            // 
            // showTime
            // 
            this.showTime.AutoSize = true;
            this.showTime.Location = new System.Drawing.Point(760, 41);
            this.showTime.Name = "showTime";
            this.showTime.Size = new System.Drawing.Size(55, 16);
            this.showTime.TabIndex = 15;
            this.showTime.Text = "00:00:00";
            // 
            // AudioSlicer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 493);
            this.Controls.Add(this.showTime);
            this.Controls.Add(this.nameRecordT);
            this.Controls.Add(this.nameOnRecordL);
            this.Controls.Add(this.saveRecordBtn);
            this.Controls.Add(this.stopRecordBtn);
            this.Controls.Add(this.startRecordBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.stopB);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.showNameT);
            this.Controls.Add(this.timerL);
            this.Controls.Add(this.chooseAudioL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AudioSlicer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        #endregion

        private System.Windows.Forms.Label chooseAudioL;
        private System.Windows.Forms.Label timerL;
        private System.Windows.Forms.TextBox showNameT;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button startRecordBtn;
        private System.Windows.Forms.Button stopRecordBtn;
        private System.Windows.Forms.Button saveRecordBtn;
        private System.Windows.Forms.Label nameOnRecordL;
        private System.Windows.Forms.TextBox nameRecordT;
        private System.Windows.Forms.Timer timerAudio;
        private System.Windows.Forms.Label showTime;
    }
}

