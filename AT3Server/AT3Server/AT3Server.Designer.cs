namespace AT3Server
{
    partial class AT3Server
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
            this.LBOutputLog = new System.Windows.Forms.ListBox();
            this.GBServer = new System.Windows.Forms.GroupBox();
            this.LblPipelineStatus = new System.Windows.Forms.Label();
            this.LblPipelineStatusLBL = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.GBValidate = new System.Windows.Forms.GroupBox();
            this.TBVPwd = new System.Windows.Forms.TextBox();
            this.TBVUser = new System.Windows.Forms.TextBox();
            this.BtnValidate = new System.Windows.Forms.Button();
            this.GBCreate = new System.Windows.Forms.GroupBox();
            this.TBNPwd = new System.Windows.Forms.TextBox();
            this.TBNUser = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.GBServer.SuspendLayout();
            this.GBValidate.SuspendLayout();
            this.GBCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBOutputLog
            // 
            this.LBOutputLog.FormattingEnabled = true;
            this.LBOutputLog.Location = new System.Drawing.Point(13, 238);
            this.LBOutputLog.Name = "LBOutputLog";
            this.LBOutputLog.Size = new System.Drawing.Size(536, 186);
            this.LBOutputLog.TabIndex = 8;
            // 
            // GBServer
            // 
            this.GBServer.Controls.Add(this.LblPipelineStatus);
            this.GBServer.Controls.Add(this.LblPipelineStatusLBL);
            this.GBServer.Controls.Add(this.BtnStop);
            this.GBServer.Controls.Add(this.BtnStart);
            this.GBServer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GBServer.Location = new System.Drawing.Point(13, 12);
            this.GBServer.Name = "GBServer";
            this.GBServer.Size = new System.Drawing.Size(535, 92);
            this.GBServer.TabIndex = 7;
            this.GBServer.TabStop = false;
            this.GBServer.Tag = "";
            this.GBServer.Text = "Server";
            // 
            // LblPipelineStatus
            // 
            this.LblPipelineStatus.AutoSize = true;
            this.LblPipelineStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPipelineStatus.ForeColor = System.Drawing.Color.Red;
            this.LblPipelineStatus.Location = new System.Drawing.Point(6, 71);
            this.LblPipelineStatus.Name = "LblPipelineStatus";
            this.LblPipelineStatus.Size = new System.Drawing.Size(93, 16);
            this.LblPipelineStatus.TabIndex = 5;
            this.LblPipelineStatus.Text = "Not Connected";
            // 
            // LblPipelineStatusLBL
            // 
            this.LblPipelineStatusLBL.AutoSize = true;
            this.LblPipelineStatusLBL.Location = new System.Drawing.Point(3, 48);
            this.LblPipelineStatusLBL.Name = "LblPipelineStatusLBL";
            this.LblPipelineStatusLBL.Size = new System.Drawing.Size(102, 17);
            this.LblPipelineStatusLBL.TabIndex = 3;
            this.LblPipelineStatusLBL.Text = "Pipeline/Client\r\n";
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(280, 22);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(249, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(6, 22);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(268, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // GBValidate
            // 
            this.GBValidate.Controls.Add(this.TBVPwd);
            this.GBValidate.Controls.Add(this.TBVUser);
            this.GBValidate.Controls.Add(this.BtnValidate);
            this.GBValidate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBValidate.Location = new System.Drawing.Point(293, 110);
            this.GBValidate.Name = "GBValidate";
            this.GBValidate.Size = new System.Drawing.Size(255, 122);
            this.GBValidate.TabIndex = 6;
            this.GBValidate.TabStop = false;
            this.GBValidate.Text = "Validate User";
            // 
            // TBVPwd
            // 
            this.TBVPwd.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBVPwd.Location = new System.Drawing.Point(55, 58);
            this.TBVPwd.Name = "TBVPwd";
            this.TBVPwd.Size = new System.Drawing.Size(145, 23);
            this.TBVPwd.TabIndex = 6;
            this.TBVPwd.Text = "Password";
            this.TBVPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBVPwd.Enter += new System.EventHandler(this.TBVPwd_Enter);
            this.TBVPwd.Leave += new System.EventHandler(this.TBVPwd_Leave);
            // 
            // TBVUser
            // 
            this.TBVUser.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBVUser.Location = new System.Drawing.Point(55, 22);
            this.TBVUser.Name = "TBVUser";
            this.TBVUser.Size = new System.Drawing.Size(145, 23);
            this.TBVUser.TabIndex = 5;
            this.TBVUser.Text = "Staff ID";
            this.TBVUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBVUser.Enter += new System.EventHandler(this.TBVUser_Enter);
            this.TBVUser.Leave += new System.EventHandler(this.TBVUser_Leave);
            // 
            // BtnValidate
            // 
            this.BtnValidate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidate.Location = new System.Drawing.Point(92, 93);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(75, 23);
            this.BtnValidate.TabIndex = 0;
            this.BtnValidate.Text = "Validate";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // GBCreate
            // 
            this.GBCreate.Controls.Add(this.TBNPwd);
            this.GBCreate.Controls.Add(this.TBNUser);
            this.GBCreate.Controls.Add(this.BtnCreate);
            this.GBCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCreate.Location = new System.Drawing.Point(13, 110);
            this.GBCreate.Name = "GBCreate";
            this.GBCreate.Size = new System.Drawing.Size(274, 122);
            this.GBCreate.TabIndex = 5;
            this.GBCreate.TabStop = false;
            this.GBCreate.Text = "Create User";
            // 
            // TBNPwd
            // 
            this.TBNPwd.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBNPwd.Location = new System.Drawing.Point(66, 58);
            this.TBNPwd.Name = "TBNPwd";
            this.TBNPwd.Size = new System.Drawing.Size(145, 23);
            this.TBNPwd.TabIndex = 4;
            this.TBNPwd.Text = "Password";
            this.TBNPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBNPwd.Enter += new System.EventHandler(this.TBNPwd_Enter);
            this.TBNPwd.Leave += new System.EventHandler(this.TBNPwd_Leave);
            // 
            // TBNUser
            // 
            this.TBNUser.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBNUser.Location = new System.Drawing.Point(66, 22);
            this.TBNUser.Name = "TBNUser";
            this.TBNUser.Size = new System.Drawing.Size(145, 23);
            this.TBNUser.TabIndex = 1;
            this.TBNUser.Text = "Staff ID";
            this.TBNUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBNUser.Enter += new System.EventHandler(this.TBNUser_Enter);
            this.TBNUser.Leave += new System.EventHandler(this.TBNUser_Leave);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(101, 93);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // AT3Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 439);
            this.Controls.Add(this.LBOutputLog);
            this.Controls.Add(this.GBServer);
            this.Controls.Add(this.GBValidate);
            this.Controls.Add(this.GBCreate);
            this.Name = "AT3Server";
            this.Text = "uMelody Server";
            this.Load += new System.EventHandler(this.AT3Server_Load);
            this.GBServer.ResumeLayout(false);
            this.GBServer.PerformLayout();
            this.GBValidate.ResumeLayout(false);
            this.GBValidate.PerformLayout();
            this.GBCreate.ResumeLayout(false);
            this.GBCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBOutputLog;
        private System.Windows.Forms.GroupBox GBServer;
        private System.Windows.Forms.Label LblPipelineStatus;
        private System.Windows.Forms.Label LblPipelineStatusLBL;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.GroupBox GBValidate;
        private System.Windows.Forms.TextBox TBVPwd;
        private System.Windows.Forms.TextBox TBVUser;
        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.GroupBox GBCreate;
        private System.Windows.Forms.TextBox TBNPwd;
        private System.Windows.Forms.TextBox TBNUser;
        private System.Windows.Forms.Button BtnCreate;
    }
}

