﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BgLevelApp
{
    partial class BgMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BgMonitor));
            this.closeWindow = new System.Windows.Forms.Panel();
            this.transparentOffTimer = new System.Windows.Forms.Timer(this.components);
            this.BgLabel = new System.Windows.Forms.Label();
            this.GetBgTimer = new System.Windows.Forms.Timer(this.components);
            this.minutesSinceLastBgLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSettings = new System.Windows.Forms.Panel();
            this.buttonInfoHelp = new System.Windows.Forms.Panel();
            this.AlarmpictureBox = new System.Windows.Forms.PictureBox();
            this.ArrowStraitBox = new System.Windows.Forms.PictureBox();
            this.ArrowDoubleDownBox = new System.Windows.Forms.PictureBox();
            this.Arrow45DownBox = new System.Windows.Forms.PictureBox();
            this.ArrowDoubleUpBox = new System.Windows.Forms.PictureBox();
            this.ArrowOneUpBox = new System.Windows.Forms.PictureBox();
            this.Arrow45UpBox = new System.Windows.Forms.PictureBox();
            this.ArrowOneDownBox = new System.Windows.Forms.PictureBox();
            this.buttonMinimized = new System.Windows.Forms.PictureBox();
            this.CloseDownTimer = new System.Windows.Forms.Timer(this.components);
            this.SnoozeBgTimer = new System.Windows.Forms.Timer(this.components);
            this.SnoozeMinutesSinceTimer = new System.Windows.Forms.Timer(this.components);
            this.MinimizeTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonGoToNS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowStraitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDoubleDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow45DownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDoubleUpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowOneUpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow45UpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowOneDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGoToNS)).BeginInit();
            this.SuspendLayout();
            // 
            // closeWindow
            // 
            resources.ApplyResources(this.closeWindow, "closeWindow");
            this.closeWindow.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow.Name = "closeWindow";
            this.toolTip1.SetToolTip(this.closeWindow, resources.GetString("closeWindow.ToolTip"));
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            this.closeWindow.MouseLeave += new System.EventHandler(this.closeWindow_MouseLeave);
            this.closeWindow.MouseHover += new System.EventHandler(this.closeWindow_MouseHover);
            // 
            // transparentOffTimer
            // 
            this.transparentOffTimer.Enabled = true;
            this.transparentOffTimer.Interval = 5000;
            this.transparentOffTimer.Tick += new System.EventHandler(this.transparentOffTimer_Tick);
            // 
            // BgLabel
            // 
            resources.ApplyResources(this.BgLabel, "BgLabel");
            this.BgLabel.BackColor = System.Drawing.Color.Transparent;
            this.BgLabel.CausesValidation = false;
            this.BgLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BgLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BgLabel.Name = "BgLabel";
            this.toolTip1.SetToolTip(this.BgLabel, resources.GetString("BgLabel.ToolTip"));
            this.BgLabel.Click += new System.EventHandler(this.BgLabel_Click);
            this.BgLabel.MouseLeave += new System.EventHandler(this.BgLabel_MouseLeave);
            this.BgLabel.MouseHover += new System.EventHandler(this.BgLabel_MouseHover);
            // 
            // GetBgTimer
            // 
            this.GetBgTimer.Interval = 58000;
            this.GetBgTimer.Tick += new System.EventHandler(this.GetBg_Tick);
            // 
            // minutesSinceLastBgLabel
            // 
            resources.ApplyResources(this.minutesSinceLastBgLabel, "minutesSinceLastBgLabel");
            this.minutesSinceLastBgLabel.BackColor = System.Drawing.Color.Transparent;
            this.minutesSinceLastBgLabel.CausesValidation = false;
            this.minutesSinceLastBgLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.minutesSinceLastBgLabel.ForeColor = System.Drawing.Color.Yellow;
            this.minutesSinceLastBgLabel.Name = "minutesSinceLastBgLabel";
            this.toolTip1.SetToolTip(this.minutesSinceLastBgLabel, resources.GetString("minutesSinceLastBgLabel.ToolTip"));
            this.minutesSinceLastBgLabel.MouseLeave += new System.EventHandler(this.minutesSinceLastBgLabel_MouseLeave);
            this.minutesSinceLastBgLabel.MouseHover += new System.EventHandler(this.minutesSinceLastBgLabel_MouseHover);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BackgroundImage = global::BgLevelApp.Properties.Resources.settingsIco;
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.Name = "buttonSettings";
            this.toolTip1.SetToolTip(this.buttonSettings, resources.GetString("buttonSettings.ToolTip"));
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            this.buttonSettings.MouseLeave += new System.EventHandler(this.buttonSettings_MouseLeave);
            this.buttonSettings.MouseHover += new System.EventHandler(this.buttonSettings_MouseHover);
            // 
            // buttonInfoHelp
            // 
            this.buttonInfoHelp.BackColor = System.Drawing.Color.Transparent;
            this.buttonInfoHelp.BackgroundImage = global::BgLevelApp.Properties.Resources.Info;
            resources.ApplyResources(this.buttonInfoHelp, "buttonInfoHelp");
            this.buttonInfoHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoHelp.Name = "buttonInfoHelp";
            this.toolTip1.SetToolTip(this.buttonInfoHelp, resources.GetString("buttonInfoHelp.ToolTip"));
            this.buttonInfoHelp.Click += new System.EventHandler(this.infoHelp_Click);
            this.buttonInfoHelp.MouseLeave += new System.EventHandler(this.licensAgree_MouseLeave);
            this.buttonInfoHelp.MouseHover += new System.EventHandler(this.licensAgree_MouseHover);
            // 
            // AlarmpictureBox
            // 
            this.AlarmpictureBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.AlarmpictureBox, "AlarmpictureBox");
            this.AlarmpictureBox.Name = "AlarmpictureBox";
            this.AlarmpictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.AlarmpictureBox, resources.GetString("AlarmpictureBox.ToolTip"));
            this.AlarmpictureBox.Click += new System.EventHandler(this.AlarmpictureBox_Click);
            // 
            // ArrowStraitBox
            // 
            this.ArrowStraitBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ArrowStraitBox, "ArrowStraitBox");
            this.ArrowStraitBox.Image = global::BgLevelApp.Properties.Resources.ArrowStrait;
            this.ArrowStraitBox.Name = "ArrowStraitBox";
            this.ArrowStraitBox.TabStop = false;
            this.toolTip1.SetToolTip(this.ArrowStraitBox, resources.GetString("ArrowStraitBox.ToolTip"));
            this.ArrowStraitBox.MouseLeave += new System.EventHandler(this.ArrowStraitBox_MouseLeave);
            this.ArrowStraitBox.MouseHover += new System.EventHandler(this.ArrowStraitBox_MouseHover);
            // 
            // ArrowDoubleDownBox
            // 
            this.ArrowDoubleDownBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ArrowDoubleDownBox, "ArrowDoubleDownBox");
            this.ArrowDoubleDownBox.Image = global::BgLevelApp.Properties.Resources.ArrowDoubleD;
            this.ArrowDoubleDownBox.Name = "ArrowDoubleDownBox";
            this.ArrowDoubleDownBox.TabStop = false;
            this.toolTip1.SetToolTip(this.ArrowDoubleDownBox, resources.GetString("ArrowDoubleDownBox.ToolTip"));
            this.ArrowDoubleDownBox.MouseLeave += new System.EventHandler(this.ArrowDoubleDownBox_MouseLeave);
            this.ArrowDoubleDownBox.MouseHover += new System.EventHandler(this.ArrowDoubleDownBox_MouseHover);
            // 
            // Arrow45DownBox
            // 
            this.Arrow45DownBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Arrow45DownBox, "Arrow45DownBox");
            this.Arrow45DownBox.Image = global::BgLevelApp.Properties.Resources.Arrow45Down;
            this.Arrow45DownBox.Name = "Arrow45DownBox";
            this.Arrow45DownBox.TabStop = false;
            this.toolTip1.SetToolTip(this.Arrow45DownBox, resources.GetString("Arrow45DownBox.ToolTip"));
            this.Arrow45DownBox.MouseLeave += new System.EventHandler(this.Arrow45DownBox_MouseLeave);
            this.Arrow45DownBox.MouseHover += new System.EventHandler(this.Arrow45DownBox_MouseHover);
            // 
            // ArrowDoubleUpBox
            // 
            this.ArrowDoubleUpBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ArrowDoubleUpBox, "ArrowDoubleUpBox");
            this.ArrowDoubleUpBox.Image = global::BgLevelApp.Properties.Resources.ArrowDoubleU;
            this.ArrowDoubleUpBox.Name = "ArrowDoubleUpBox";
            this.ArrowDoubleUpBox.TabStop = false;
            this.toolTip1.SetToolTip(this.ArrowDoubleUpBox, resources.GetString("ArrowDoubleUpBox.ToolTip"));
            this.ArrowDoubleUpBox.MouseLeave += new System.EventHandler(this.ArrowDoubleUpBox_MouseLeave);
            this.ArrowDoubleUpBox.MouseHover += new System.EventHandler(this.ArrowDoubleUpBox_MouseHover);
            // 
            // ArrowOneUpBox
            // 
            this.ArrowOneUpBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ArrowOneUpBox, "ArrowOneUpBox");
            this.ArrowOneUpBox.Image = global::BgLevelApp.Properties.Resources.AwwowOneUp;
            this.ArrowOneUpBox.Name = "ArrowOneUpBox";
            this.ArrowOneUpBox.TabStop = false;
            this.toolTip1.SetToolTip(this.ArrowOneUpBox, resources.GetString("ArrowOneUpBox.ToolTip"));
            this.ArrowOneUpBox.MouseLeave += new System.EventHandler(this.ArrowOneUpBox_MouseLeave);
            this.ArrowOneUpBox.MouseHover += new System.EventHandler(this.ArrowOneUpBox_MouseHover);
            // 
            // Arrow45UpBox
            // 
            this.Arrow45UpBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Arrow45UpBox, "Arrow45UpBox");
            this.Arrow45UpBox.Image = global::BgLevelApp.Properties.Resources.Arrow45Upt;
            this.Arrow45UpBox.Name = "Arrow45UpBox";
            this.Arrow45UpBox.TabStop = false;
            this.toolTip1.SetToolTip(this.Arrow45UpBox, resources.GetString("Arrow45UpBox.ToolTip"));
            this.Arrow45UpBox.MouseLeave += new System.EventHandler(this.Arrow45UpBox_MouseLeave);
            this.Arrow45UpBox.MouseHover += new System.EventHandler(this.Arrow45UpBox_MouseHover);
            // 
            // ArrowOneDownBox
            // 
            this.ArrowOneDownBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ArrowOneDownBox, "ArrowOneDownBox");
            this.ArrowOneDownBox.Image = global::BgLevelApp.Properties.Resources.ArrowOneDown;
            this.ArrowOneDownBox.Name = "ArrowOneDownBox";
            this.ArrowOneDownBox.TabStop = false;
            this.toolTip1.SetToolTip(this.ArrowOneDownBox, resources.GetString("ArrowOneDownBox.ToolTip"));
            this.ArrowOneDownBox.MouseLeave += new System.EventHandler(this.ArrowOneDownBox_MouseLeave);
            this.ArrowOneDownBox.MouseHover += new System.EventHandler(this.ArrowOneDownBox_MouseHover);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimized.Image = global::BgLevelApp.Properties.Resources.minimize15;
            resources.ApplyResources(this.buttonMinimized, "buttonMinimized");
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonMinimized, resources.GetString("buttonMinimized.ToolTip"));
            this.buttonMinimized.Click += new System.EventHandler(this.MinimizedBox_Click);
            this.buttonMinimized.MouseLeave += new System.EventHandler(this.ArrowOneDownBox_MouseLeave);
            this.buttonMinimized.MouseHover += new System.EventHandler(this.ArrowOneDownBox_MouseHover);
            // 
            // CloseDownTimer
            // 
            this.CloseDownTimer.Tick += new System.EventHandler(this.CloseDownTimer_Tick);
            // 
            // SnoozeBgTimer
            // 
            this.SnoozeBgTimer.Tick += new System.EventHandler(this.SnoozeBgTimer_Tick);
            // 
            // SnoozeMinutesSinceTimer
            // 
            this.SnoozeMinutesSinceTimer.Tick += new System.EventHandler(this.SnoozeMinutesSinceTimer_Tick);
            // 
            // MinimizeTimer
            // 
            this.MinimizeTimer.Interval = 900000;
            this.MinimizeTimer.Tick += new System.EventHandler(this.MinimizeTimer_Tick);
            // 
            // buttonGoToNS
            // 
            this.buttonGoToNS.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonGoToNS, "buttonGoToNS");
            this.buttonGoToNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToNS.Image = global::BgLevelApp.Properties.Resources.NSlogoBlack;
            this.buttonGoToNS.Name = "buttonGoToNS";
            this.buttonGoToNS.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonGoToNS, resources.GetString("buttonGoToNS.ToolTip"));
            this.buttonGoToNS.Click += new System.EventHandler(this.buttonGoToNS_Click);
            // 
            // BgMonitor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BgLevelApp.Properties.Resources.BackgroundBlueElipse;
            this.Controls.Add(this.buttonGoToNS);
            this.Controls.Add(this.buttonMinimized);
            this.Controls.Add(this.ArrowOneDownBox);
            this.Controls.Add(this.Arrow45UpBox);
            this.Controls.Add(this.ArrowOneUpBox);
            this.Controls.Add(this.ArrowDoubleUpBox);
            this.Controls.Add(this.Arrow45DownBox);
            this.Controls.Add(this.ArrowDoubleDownBox);
            this.Controls.Add(this.ArrowStraitBox);
            this.Controls.Add(this.AlarmpictureBox);
            this.Controls.Add(this.buttonInfoHelp);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.minutesSinceLastBgLabel);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.BgLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BgMonitor";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Activated += new System.EventHandler(this.BgMonitor_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowStraitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDoubleDownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow45DownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDoubleUpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowOneUpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow45UpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowOneDownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGoToNS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel closeWindow;
        private System.Windows.Forms.Timer transparentOffTimer;
        private Label BgLabel;
        private Timer GetBgTimer;
        private Label minutesSinceLastBgLabel;
        private ToolTip toolTip1;
        private Timer CloseDownTimer;
        private Panel buttonSettings;
        private Panel buttonInfoHelp;
        private PictureBox AlarmpictureBox;
        private Timer SnoozeBgTimer;
        private Timer SnoozeMinutesSinceTimer;
        private PictureBox ArrowStraitBox;
        private PictureBox ArrowDoubleDownBox;
        private PictureBox Arrow45DownBox;
        private PictureBox ArrowDoubleUpBox;
        private PictureBox ArrowOneUpBox;
        private PictureBox Arrow45UpBox;
        private PictureBox ArrowOneDownBox;
        private PictureBox buttonMinimized;
        private Timer MinimizeTimer;
        private PictureBox buttonGoToNS;
    }
}

