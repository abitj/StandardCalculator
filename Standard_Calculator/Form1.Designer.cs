﻿
namespace Standard_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.labeltxt = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnPM = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(21, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 82);
            this.button1.TabIndex = 10;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clear_Button);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Desktop;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(287, 116);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 82);
            this.button4.TabIndex = 12;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.basicMath_Button);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Desktop;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.Location = new System.Drawing.Point(286, 206);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 82);
            this.button5.TabIndex = 16;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.basicMath_Button);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button6.Location = new System.Drawing.Point(198, 206);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 82);
            this.button6.TabIndex = 15;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button7.Location = new System.Drawing.Point(110, 206);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 82);
            this.button7.TabIndex = 14;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button8.Location = new System.Drawing.Point(21, 206);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 82);
            this.button8.TabIndex = 13;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Desktop;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.Location = new System.Drawing.Point(286, 297);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 82);
            this.button9.TabIndex = 20;
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.basicMath_Button);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button10.Location = new System.Drawing.Point(198, 297);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 82);
            this.button10.TabIndex = 19;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button11.Location = new System.Drawing.Point(110, 297);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 82);
            this.button11.TabIndex = 18;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Button_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button12.Location = new System.Drawing.Point(21, 297);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 82);
            this.button12.TabIndex = 17;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Button_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Desktop;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button13.Location = new System.Drawing.Point(286, 388);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 82);
            this.button13.TabIndex = 24;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.basicMath_Button);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button14.Location = new System.Drawing.Point(198, 388);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 82);
            this.button14.TabIndex = 23;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Button_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button15.Location = new System.Drawing.Point(110, 388);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 82);
            this.button15.TabIndex = 22;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Button_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button16.Location = new System.Drawing.Point(21, 388);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 82);
            this.button16.TabIndex = 21;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Button_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.DarkGreen;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button18.Location = new System.Drawing.Point(198, 478);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(168, 82);
            this.button18.TabIndex = 27;
            this.button18.Text = "=";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.equal_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button19.Location = new System.Drawing.Point(110, 478);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(80, 82);
            this.button19.TabIndex = 26;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Button_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button20.Location = new System.Drawing.Point(21, 478);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(80, 82);
            this.button20.TabIndex = 25;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.Button_Click);
            // 
            // labeltxt
            // 
            this.labeltxt.AutoSize = true;
            this.labeltxt.BackColor = System.Drawing.SystemColors.Window;
            this.labeltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltxt.Location = new System.Drawing.Point(24, 48);
            this.labeltxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltxt.Name = "labeltxt";
            this.labeltxt.Size = new System.Drawing.Size(0, 22);
            this.labeltxt.TabIndex = 28;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(20, 45);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(346, 61);
            this.textBox.TabIndex = 2;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.Click += new System.EventHandler(this.basicMath_Button);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPM.Location = new System.Drawing.Point(198, 116);
            this.btnPM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(80, 82);
            this.btnPM.TabIndex = 29;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(386, 577);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.labeltxt);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label labeltxt;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnPM;
    }
}

