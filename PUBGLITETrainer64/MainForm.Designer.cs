namespace PUBGLITETrainer64
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Open = new System.Windows.Forms.Button();
            this.ant_chkbox = new System.Windows.Forms.CheckBox();
            this.fog_chkbox = new System.Windows.Forms.CheckBox();
            this.jump_chkbox = new System.Windows.Forms.CheckBox();
            this.norecoil_chkbox = new System.Windows.Forms.CheckBox();
            this.nograss_chkbox = new System.Windows.Forms.CheckBox();
            this.speed_chkbox = new System.Windows.Forms.CheckBox();
            this.driveText_chkbox = new System.Windows.Forms.CheckBox();
            this.noWater_chkbox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.whiteFloor_chkbox = new System.Windows.Forms.CheckBox();
            this.noObj_chkbox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.antiban_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.ForeColor = System.Drawing.Color.Lime;
            this.btn_Open.Location = new System.Drawing.Point(207, 391);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 37);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // ant_chkbox
            // 
            this.ant_chkbox.AutoSize = true;
            this.ant_chkbox.Enabled = false;
            this.ant_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ant_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant_chkbox.ForeColor = System.Drawing.Color.Black;
            this.ant_chkbox.Location = new System.Drawing.Point(61, 60);
            this.ant_chkbox.Name = "ant_chkbox";
            this.ant_chkbox.Size = new System.Drawing.Size(117, 31);
            this.ant_chkbox.TabIndex = 1;
            this.ant_chkbox.Text = "Antenna";
            this.ant_chkbox.UseVisualStyleBackColor = true;
            this.ant_chkbox.CheckedChanged += new System.EventHandler(this.ant_chkbox_CheckedChanged);
            // 
            // fog_chkbox
            // 
            this.fog_chkbox.AutoSize = true;
            this.fog_chkbox.Enabled = false;
            this.fog_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fog_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fog_chkbox.ForeColor = System.Drawing.Color.Black;
            this.fog_chkbox.Location = new System.Drawing.Point(297, 122);
            this.fog_chkbox.Name = "fog_chkbox";
            this.fog_chkbox.Size = new System.Drawing.Size(107, 31);
            this.fog_chkbox.TabIndex = 2;
            this.fog_chkbox.Text = "No Fog";
            this.fog_chkbox.UseVisualStyleBackColor = true;
            this.fog_chkbox.CheckedChanged += new System.EventHandler(this.fog_chkbox_CheckedChanged);
            // 
            // jump_chkbox
            // 
            this.jump_chkbox.AutoSize = true;
            this.jump_chkbox.Enabled = false;
            this.jump_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.jump_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jump_chkbox.ForeColor = System.Drawing.Color.Black;
            this.jump_chkbox.Location = new System.Drawing.Point(61, 179);
            this.jump_chkbox.Name = "jump_chkbox";
            this.jump_chkbox.Size = new System.Drawing.Size(143, 31);
            this.jump_chkbox.TabIndex = 3;
            this.jump_chkbox.Text = "High Jump";
            this.jump_chkbox.UseVisualStyleBackColor = true;
            this.jump_chkbox.CheckedChanged += new System.EventHandler(this.jump_chkbox_CheckedChanged);
            // 
            // norecoil_chkbox
            // 
            this.norecoil_chkbox.AutoSize = true;
            this.norecoil_chkbox.Enabled = false;
            this.norecoil_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.norecoil_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.norecoil_chkbox.ForeColor = System.Drawing.Color.Black;
            this.norecoil_chkbox.Location = new System.Drawing.Point(61, 122);
            this.norecoil_chkbox.Name = "norecoil_chkbox";
            this.norecoil_chkbox.Size = new System.Drawing.Size(221, 31);
            this.norecoil_chkbox.TabIndex = 5;
            this.norecoil_chkbox.Text = "No Recoil (Ingame)";
            this.norecoil_chkbox.UseVisualStyleBackColor = true;
            this.norecoil_chkbox.CheckedChanged += new System.EventHandler(this.norecoil_chkbox_CheckedChanged);
            // 
            // nograss_chkbox
            // 
            this.nograss_chkbox.AutoSize = true;
            this.nograss_chkbox.Enabled = false;
            this.nograss_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nograss_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nograss_chkbox.ForeColor = System.Drawing.Color.Black;
            this.nograss_chkbox.Location = new System.Drawing.Point(297, 60);
            this.nograss_chkbox.Name = "nograss_chkbox";
            this.nograss_chkbox.Size = new System.Drawing.Size(123, 31);
            this.nograss_chkbox.TabIndex = 4;
            this.nograss_chkbox.Text = "No Grass";
            this.nograss_chkbox.UseVisualStyleBackColor = true;
            this.nograss_chkbox.CheckedChanged += new System.EventHandler(this.nograss_chkbox_CheckedChanged);
            // 
            // speed_chkbox
            // 
            this.speed_chkbox.AutoSize = true;
            this.speed_chkbox.Enabled = false;
            this.speed_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.speed_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_chkbox.ForeColor = System.Drawing.Color.Black;
            this.speed_chkbox.Location = new System.Drawing.Point(61, 242);
            this.speed_chkbox.Name = "speed_chkbox";
            this.speed_chkbox.Size = new System.Drawing.Size(144, 31);
            this.speed_chkbox.TabIndex = 7;
            this.speed_chkbox.Text = "SpeedHack";
            this.speed_chkbox.UseVisualStyleBackColor = true;
            this.speed_chkbox.CheckedChanged += new System.EventHandler(this.speed_chkbox_CheckedChanged);
            // 
            // driveText_chkbox
            // 
            this.driveText_chkbox.AutoSize = true;
            this.driveText_chkbox.Enabled = false;
            this.driveText_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.driveText_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveText_chkbox.ForeColor = System.Drawing.Color.Black;
            this.driveText_chkbox.Location = new System.Drawing.Point(297, 242);
            this.driveText_chkbox.Name = "driveText_chkbox";
            this.driveText_chkbox.Size = new System.Drawing.Size(165, 31);
            this.driveText_chkbox.TabIndex = 8;
            this.driveText_chkbox.Text = "Vechicle Text";
            this.driveText_chkbox.UseVisualStyleBackColor = true;
            this.driveText_chkbox.CheckedChanged += new System.EventHandler(this.driveText_chkbox_CheckedChanged);
            // 
            // noWater_chkbox
            // 
            this.noWater_chkbox.AutoSize = true;
            this.noWater_chkbox.Enabled = false;
            this.noWater_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noWater_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noWater_chkbox.ForeColor = System.Drawing.Color.Black;
            this.noWater_chkbox.Location = new System.Drawing.Point(297, 179);
            this.noWater_chkbox.Name = "noWater_chkbox";
            this.noWater_chkbox.Size = new System.Drawing.Size(178, 31);
            this.noWater_chkbox.TabIndex = 9;
            this.noWater_chkbox.Text = "Remove Water";
            this.noWater_chkbox.UseVisualStyleBackColor = true;
            this.noWater_chkbox.CheckedChanged += new System.EventHandler(this.noWater_chkbox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox1.Location = new System.Drawing.Point(12, 472);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 23);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "unsafe/not working hacks";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // whiteFloor_chkbox
            // 
            this.whiteFloor_chkbox.AutoSize = true;
            this.whiteFloor_chkbox.Enabled = false;
            this.whiteFloor_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.whiteFloor_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteFloor_chkbox.ForeColor = System.Drawing.Color.Black;
            this.whiteFloor_chkbox.Location = new System.Drawing.Point(297, 311);
            this.whiteFloor_chkbox.Name = "whiteFloor_chkbox";
            this.whiteFloor_chkbox.Size = new System.Drawing.Size(149, 31);
            this.whiteFloor_chkbox.TabIndex = 11;
            this.whiteFloor_chkbox.Text = "White Floor";
            this.whiteFloor_chkbox.UseVisualStyleBackColor = true;
            this.whiteFloor_chkbox.CheckedChanged += new System.EventHandler(this.whiteFloor_chkbox_CheckedChanged);
            // 
            // noObj_chkbox
            // 
            this.noObj_chkbox.AutoSize = true;
            this.noObj_chkbox.Enabled = false;
            this.noObj_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noObj_chkbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noObj_chkbox.ForeColor = System.Drawing.Color.Black;
            this.noObj_chkbox.Location = new System.Drawing.Point(61, 311);
            this.noObj_chkbox.Name = "noObj_chkbox";
            this.noObj_chkbox.Size = new System.Drawing.Size(135, 31);
            this.noObj_chkbox.TabIndex = 12;
            this.noObj_chkbox.Text = "No Object";
            this.noObj_chkbox.UseVisualStyleBackColor = true;
            this.noObj_chkbox.CheckedChanged += new System.EventHandler(this.noObj_chkbox_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(154, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(240, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Waiting.";
            // 
            // antiban_btn
            // 
            this.antiban_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.antiban_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiban_btn.ForeColor = System.Drawing.Color.Lime;
            this.antiban_btn.Location = new System.Drawing.Point(390, 463);
            this.antiban_btn.Name = "antiban_btn";
            this.antiban_btn.Size = new System.Drawing.Size(99, 32);
            this.antiban_btn.TabIndex = 15;
            this.antiban_btn.Text = "Anti Ban";
            this.antiban_btn.UseVisualStyleBackColor = true;
            this.antiban_btn.Click += new System.EventHandler(this.antiban_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PUBGLITETrainer64.Properties.Resources.pubg_mobile;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 507);
            this.Controls.Add(this.antiban_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noObj_chkbox);
            this.Controls.Add(this.whiteFloor_chkbox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.noWater_chkbox);
            this.Controls.Add(this.driveText_chkbox);
            this.Controls.Add(this.speed_chkbox);
            this.Controls.Add(this.norecoil_chkbox);
            this.Controls.Add(this.nograss_chkbox);
            this.Controls.Add(this.jump_chkbox);
            this.Controls.Add(this.fog_chkbox);
            this.Controls.Add(this.ant_chkbox);
            this.Controls.Add(this.btn_Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PubgTrainer";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.CheckBox ant_chkbox;
        private System.Windows.Forms.CheckBox fog_chkbox;
        private System.Windows.Forms.CheckBox jump_chkbox;
        private System.Windows.Forms.CheckBox norecoil_chkbox;
        private System.Windows.Forms.CheckBox nograss_chkbox;
        private System.Windows.Forms.CheckBox speed_chkbox;
        private System.Windows.Forms.CheckBox driveText_chkbox;
        private System.Windows.Forms.CheckBox noWater_chkbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox whiteFloor_chkbox;
        private System.Windows.Forms.CheckBox noObj_chkbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button antiban_btn;
    }
}

