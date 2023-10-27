namespace WinMicReset
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MicGain = new TrackBar();
            TurnOn = new CheckBox();
            Mute = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)MicGain).BeginInit();
            SuspendLayout();
            // 
            // MicGain
            // 
            MicGain.Cursor = Cursors.VSplit;
            MicGain.LargeChange = 10;
            MicGain.Location = new Point(60, 3);
            MicGain.Maximum = 100;
            MicGain.Name = "MicGain";
            MicGain.Size = new Size(170, 45);
            MicGain.TabIndex = 1;
            MicGain.Value = 50;
            MicGain.Scroll += MicGain_Scroll;
            // 
            // TurnOn
            // 
            TurnOn.AutoSize = true;
            TurnOn.Location = new Point(227, 3);
            TurnOn.Name = "TurnOn";
            TurnOn.Size = new Size(42, 19);
            TurnOn.TabIndex = 2;
            TurnOn.Text = "On";
            TurnOn.UseVisualStyleBackColor = true;
            TurnOn.CheckedChanged += TurnOn_CheckedChanged;
            // 
            // Mute
            // 
            Mute.AutoSize = true;
            Mute.Location = new Point(0, 3);
            Mute.Name = "Mute";
            Mute.RightToLeft = RightToLeft.Yes;
            Mute.Size = new Size(54, 19);
            Mute.TabIndex = 3;
            Mute.Text = "Mute";
            Mute.UseVisualStyleBackColor = true;
            Mute.CheckedChanged += Mute_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 27);
            ControlBox = false;
            Controls.Add(Mute);
            Controls.Add(TurnOn);
            Controls.Add(MicGain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mic Volume override";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)MicGain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar MicGain;
        private CheckBox TurnOn;
        private CheckBox Mute;
    }
}