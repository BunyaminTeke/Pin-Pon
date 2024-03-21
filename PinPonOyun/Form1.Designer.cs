namespace PinPonOyun
{
    partial class PinPon
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
            components = new System.ComponentModel.Container();
            solDuvar = new Label();
            sagDuvar = new Label();
            platform = new Button();
            lbl_skor = new Label();
            label6 = new Label();
            lbl_sure = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pb_icon = new PictureBox();
            label8 = new Label();
            btn_close = new Button();
            ustDuvar = new Label();
            button1 = new Button();
            btn_tekrar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_icon).BeginInit();
            SuspendLayout();
            // 
            // solDuvar
            // 
            solDuvar.BackColor = SystemColors.ActiveCaptionText;
            solDuvar.Location = new Point(-3, 1);
            solDuvar.Name = "solDuvar";
            solDuvar.Size = new Size(30, 595);
            solDuvar.TabIndex = 0;
            // 
            // sagDuvar
            // 
            sagDuvar.BackColor = SystemColors.ActiveCaptionText;
            sagDuvar.Location = new Point(929, 2);
            sagDuvar.Name = "sagDuvar";
            sagDuvar.Size = new Size(30, 594);
            sagDuvar.TabIndex = 2;
            // 
            // platform
            // 
            platform.BackColor = Color.DarkSlateGray;
            platform.Enabled = false;
            platform.FlatAppearance.BorderSize = 0;
            platform.FlatStyle = FlatStyle.Flat;
            platform.Location = new Point(402, 545);
            platform.Name = "platform";
            platform.Size = new Size(165, 30);
            platform.TabIndex = 3;
            platform.UseVisualStyleBackColor = false;
            // 
            // lbl_skor
            // 
            lbl_skor.AutoSize = true;
            lbl_skor.BackColor = Color.DarkGray;
            lbl_skor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lbl_skor.Location = new Point(234, 611);
            lbl_skor.Name = "lbl_skor";
            lbl_skor.Size = new Size(36, 25);
            lbl_skor.TabIndex = 3;
            lbl_skor.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkGray;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.Location = new Point(170, 609);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 2;
            label6.Text = "Skor";
            // 
            // lbl_sure
            // 
            lbl_sure.AutoSize = true;
            lbl_sure.BackColor = Color.DarkGray;
            lbl_sure.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lbl_sure.Location = new Point(84, 611);
            lbl_sure.Name = "lbl_sure";
            lbl_sure.Size = new Size(36, 25);
            lbl_sure.TabIndex = 1;
            lbl_sure.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGray;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.Location = new Point(20, 611);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 0;
            label4.Text = "Süre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pb_icon);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 39);
            panel2.TabIndex = 5;
            // 
            // pb_icon
            // 
            pb_icon.Location = new Point(0, 0);
            pb_icon.Name = "pb_icon";
            pb_icon.Size = new Size(37, 37);
            pb_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_icon.TabIndex = 9;
            pb_icon.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(36, 9);
            label8.Name = "label8";
            label8.Size = new Size(78, 22);
            label8.TabIndex = 7;
            label8.Text = "Pin Pon";
            // 
            // btn_close
            // 
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Location = new Point(920, 1);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(36, 36);
            btn_close.TabIndex = 6;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // ustDuvar
            // 
            ustDuvar.BackColor = SystemColors.ActiveCaptionText;
            ustDuvar.Location = new Point(24, 39);
            ustDuvar.Name = "ustDuvar";
            ustDuvar.Size = new Size(906, 30);
            ustDuvar.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Dock = DockStyle.Bottom;
            button1.Enabled = false;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 596);
            button1.Name = "button1";
            button1.Size = new Size(959, 55);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_tekrar
            // 
            btn_tekrar.BackColor = Color.DarkGray;
            btn_tekrar.FlatAppearance.BorderSize = 0;
            btn_tekrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_tekrar.FlatStyle = FlatStyle.Flat;
            btn_tekrar.Location = new Point(911, 605);
            btn_tekrar.Name = "btn_tekrar";
            btn_tekrar.Size = new Size(38, 38);
            btn_tekrar.TabIndex = 8;
            btn_tekrar.UseVisualStyleBackColor = false;
            btn_tekrar.Click += btn_tekrar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // PinPon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 651);
            Controls.Add(btn_tekrar);
            Controls.Add(lbl_skor);
            Controls.Add(label6);
            Controls.Add(lbl_sure);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(ustDuvar);
            Controls.Add(panel2);
            Controls.Add(platform);
            Controls.Add(sagDuvar);
            Controls.Add(solDuvar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PinPon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pin Pon";
            KeyDown += PinPon_KeyDown;
            MouseMove += Form1_MouseMove;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label solDuvar;
        private Label sagDuvar;
        private Button platform;
        private Label lbl_skor;
        private Label label6;
        private Label lbl_sure;
        private Label label4;
        private Panel panel2;
        private Button btn_close;
        private Label ustDuvar;
        private Button button1;
        private Label label8;
        private Button btn_tekrar;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pb_icon;
    }
}
