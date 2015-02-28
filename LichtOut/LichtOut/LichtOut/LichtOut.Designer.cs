using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace LichtOut
{
    partial class LichtOut
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.easy = new System.Windows.Forms.Button();
            this.local_highscores = new System.Windows.Forms.Button();
            this.classic = new System.Windows.Forms.Button();
            this.pnl_chooseTileColor = new System.Windows.Forms.Panel();
            this.pnl_startGame = new System.Windows.Forms.Panel();
            this.btn_sartGame = new System.Windows.Forms.Button();
            this.gb_offColors = new System.Windows.Forms.GroupBox();
            this.rb_off_pink = new System.Windows.Forms.RadioButton();
            this.rb_off_grey = new System.Windows.Forms.RadioButton();
            this.rb_off_blue = new System.Windows.Forms.RadioButton();
            this.rb_off_green = new System.Windows.Forms.RadioButton();
            this.gb_onColors = new System.Windows.Forms.GroupBox();
            this.rb_on_pink = new System.Windows.Forms.RadioButton();
            this.rb_on_blue = new System.Windows.Forms.RadioButton();
            this.rb_on_green = new System.Windows.Forms.RadioButton();
            this.rb_on_yellow = new System.Windows.Forms.RadioButton();
            this.lbl_offLight = new System.Windows.Forms.Label();
            this.lbl_onLight = new System.Windows.Forms.Label();
            this.pnl_OffLight = new System.Windows.Forms.Panel();
            this.pnl_OnLight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnl_chooseTileColor.SuspendLayout();
            this.pnl_startGame.SuspendLayout();
            this.gb_offColors.SuspendLayout();
            this.gb_onColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::LichtOut.Properties.Resources.LichtOutLogo1;
            this.logo.Location = new System.Drawing.Point(73, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(554, 190);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // easy
            // 
            this.easy.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(12, 297);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(688, 98);
            this.easy.TabIndex = 1;
            this.easy.Text = "EASY";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.Click += new System.EventHandler(this.game_Click);
            // 
            // classic
            // 
            this.classic.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classic.Location = new System.Drawing.Point(12, 479);
            this.classic.Name = "classic";
            this.classic.Size = new System.Drawing.Size(688, 98);
            this.classic.TabIndex = 2;
            this.classic.Text = "CLASSIC";
            this.classic.UseVisualStyleBackColor = true;
            this.classic.Click += new System.EventHandler(this.game_Click);
            // 
            // local_highscores
            // 
            this.local_highscores.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.local_highscores.Location = new System.Drawing.Point(12, 640);
            this.local_highscores.Name = "local_highscores";
            this.local_highscores.Size = new System.Drawing.Size(200, 58);
            this.local_highscores.TabIndex = 1;
            this.local_highscores.Text = "LOCAL HIGHSCORES";
            this.local_highscores.UseVisualStyleBackColor = true;
            this.local_highscores.Click += new System.EventHandler(this.ShowLocalHighscores);
            // 
            // pnl_chooseTileColor
            // 
            this.pnl_chooseTileColor.Controls.Add(this.pnl_startGame);
            this.pnl_chooseTileColor.Controls.Add(this.btn_sartGame);
            this.pnl_chooseTileColor.Controls.Add(this.gb_offColors);
            this.pnl_chooseTileColor.Controls.Add(this.gb_onColors);
            this.pnl_chooseTileColor.Controls.Add(this.lbl_offLight);
            this.pnl_chooseTileColor.Controls.Add(this.lbl_onLight);
            this.pnl_chooseTileColor.Controls.Add(this.pnl_OffLight);
            this.pnl_chooseTileColor.Controls.Add(this.pnl_OnLight);
            this.pnl_chooseTileColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_chooseTileColor.Location = new System.Drawing.Point(0, 0);
            this.pnl_chooseTileColor.Name = "pnl_chooseTileColor";
            this.pnl_chooseTileColor.Size = new System.Drawing.Size(712, 723);
            this.pnl_chooseTileColor.TabIndex = 3;
            this.pnl_chooseTileColor.Visible = false;
            // 
            // pnl_startGame
            // 
            this.pnl_startGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_startGame.Location = new System.Drawing.Point(0, 0);
            this.pnl_startGame.Name = "pnl_startGame";
            this.pnl_startGame.Size = new System.Drawing.Size(712, 723);
            this.pnl_startGame.TabIndex = 7;
            this.pnl_startGame.Visible = false;
            // 
            // btn_sartGame
            // 
            this.btn_sartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sartGame.Location = new System.Drawing.Point(191, 30);
            this.btn_sartGame.Name = "btn_sartGame";
            this.btn_sartGame.Size = new System.Drawing.Size(277, 93);
            this.btn_sartGame.TabIndex = 6;
            this.btn_sartGame.Text = "START GAME";
            this.btn_sartGame.UseVisualStyleBackColor = true;
            this.btn_sartGame.Click += new System.EventHandler(this.btn_sartGame_Click);
            // 
            // gb_offColors
            // 
            this.gb_offColors.Controls.Add(this.rb_off_pink);
            this.gb_offColors.Controls.Add(this.rb_off_grey);
            this.gb_offColors.Controls.Add(this.rb_off_blue);
            this.gb_offColors.Controls.Add(this.rb_off_green);
            this.gb_offColors.Location = new System.Drawing.Point(435, 223);
            this.gb_offColors.Name = "gb_offColors";
            this.gb_offColors.Size = new System.Drawing.Size(216, 268);
            this.gb_offColors.TabIndex = 5;
            this.gb_offColors.TabStop = false;
            this.gb_offColors.Text = "OFF COLORS";
            // 
            // rb_off_pink
            // 
            this.rb_off_pink.AutoSize = true;
            this.rb_off_pink.Location = new System.Drawing.Point(57, 220);
            this.rb_off_pink.Name = "rb_off_pink";
            this.rb_off_pink.Size = new System.Drawing.Size(101, 21);
            this.rb_off_pink.TabIndex = 7;
            this.rb_off_pink.Text = "DEEP PINK";
            this.rb_off_pink.UseVisualStyleBackColor = true;
            this.rb_off_pink.CheckedChanged += new System.EventHandler(this.rb_off_color);
            // 
            // rb_off_grey
            // 
            this.rb_off_grey.AutoSize = true;
            this.rb_off_grey.Checked = true;
            this.rb_off_grey.Location = new System.Drawing.Point(57, 66);
            this.rb_off_grey.Name = "rb_off_grey";
            this.rb_off_grey.Size = new System.Drawing.Size(68, 21);
            this.rb_off_grey.TabIndex = 4;
            this.rb_off_grey.TabStop = true;
            this.rb_off_grey.Text = "GRAY";
            this.rb_off_grey.UseVisualStyleBackColor = true;
            this.rb_off_grey.CheckedChanged += new System.EventHandler(this.rb_off_color);
            // 
            // rb_off_blue
            // 
            this.rb_off_blue.AutoSize = true;
            this.rb_off_blue.Location = new System.Drawing.Point(57, 169);
            this.rb_off_blue.Name = "rb_off_blue";
            this.rb_off_blue.Size = new System.Drawing.Size(107, 21);
            this.rb_off_blue.TabIndex = 6;
            this.rb_off_blue.Text = "DARK BLUE";
            this.rb_off_blue.UseVisualStyleBackColor = true;
            this.rb_off_blue.CheckedChanged += new System.EventHandler(this.rb_off_color);
            // 
            // rb_off_green
            // 
            this.rb_off_green.AutoSize = true;
            this.rb_off_green.Location = new System.Drawing.Point(57, 121);
            this.rb_off_green.Name = "rb_off_green";
            this.rb_off_green.Size = new System.Drawing.Size(120, 21);
            this.rb_off_green.TabIndex = 5;
            this.rb_off_green.Text = "DARK GREEN";
            this.rb_off_green.UseVisualStyleBackColor = true;
            this.rb_off_green.CheckedChanged += new System.EventHandler(this.rb_off_color);
            // 
            // gb_onColors
            // 
            this.gb_onColors.Controls.Add(this.rb_on_pink);
            this.gb_onColors.Controls.Add(this.rb_on_blue);
            this.gb_onColors.Controls.Add(this.rb_on_green);
            this.gb_onColors.Controls.Add(this.rb_on_yellow);
            this.gb_onColors.Location = new System.Drawing.Point(12, 223);
            this.gb_onColors.Name = "gb_onColors";
            this.gb_onColors.Size = new System.Drawing.Size(216, 268);
            this.gb_onColors.TabIndex = 4;
            this.gb_onColors.TabStop = false;
            this.gb_onColors.Text = "ON COLORS";
            // 
            // rb_on_pink
            // 
            this.rb_on_pink.AutoSize = true;
            this.rb_on_pink.Location = new System.Drawing.Point(32, 220);
            this.rb_on_pink.Name = "rb_on_pink";
            this.rb_on_pink.Size = new System.Drawing.Size(60, 21);
            this.rb_on_pink.TabIndex = 3;
            this.rb_on_pink.Text = "PINK";
            this.rb_on_pink.UseVisualStyleBackColor = true;
            this.rb_on_pink.CheckedChanged += new System.EventHandler(this.rb_on_color);
            // 
            // rb_on_blue
            // 
            this.rb_on_blue.AutoSize = true;
            this.rb_on_blue.Location = new System.Drawing.Point(32, 169);
            this.rb_on_blue.Name = "rb_on_blue";
            this.rb_on_blue.Size = new System.Drawing.Size(65, 21);
            this.rb_on_blue.TabIndex = 2;
            this.rb_on_blue.Text = "BLUE";
            this.rb_on_blue.UseVisualStyleBackColor = true;
            this.rb_on_blue.CheckedChanged += new System.EventHandler(this.rb_on_color);
            // 
            // rb_on_green
            // 
            this.rb_on_green.AutoSize = true;
            this.rb_on_green.Location = new System.Drawing.Point(32, 121);
            this.rb_on_green.Name = "rb_on_green";
            this.rb_on_green.Size = new System.Drawing.Size(78, 21);
            this.rb_on_green.TabIndex = 1;
            this.rb_on_green.Text = "GREEN";
            this.rb_on_green.UseVisualStyleBackColor = true;
            this.rb_on_green.CheckedChanged += new System.EventHandler(this.rb_on_color);
            // 
            // rb_on_yellow
            // 
            this.rb_on_yellow.AutoSize = true;
            this.rb_on_yellow.Checked = true;
            this.rb_on_yellow.Location = new System.Drawing.Point(32, 66);
            this.rb_on_yellow.Name = "rb_on_yellow";
            this.rb_on_yellow.Size = new System.Drawing.Size(87, 21);
            this.rb_on_yellow.TabIndex = 0;
            this.rb_on_yellow.TabStop = true;
            this.rb_on_yellow.Text = "YELLOW";
            this.rb_on_yellow.UseVisualStyleBackColor = true;
            this.rb_on_yellow.CheckedChanged += new System.EventHandler(this.rb_on_color);
            // 
            // lbl_offLight
            // 
            this.lbl_offLight.AutoSize = true;
            this.lbl_offLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offLight.Location = new System.Drawing.Point(556, 143);
            this.lbl_offLight.Name = "lbl_offLight";
            this.lbl_offLight.Size = new System.Drawing.Size(71, 32);
            this.lbl_offLight.TabIndex = 3;
            this.lbl_offLight.Text = "OFF";
            // 
            // lbl_onLight
            // 
            this.lbl_onLight.AutoSize = true;
            this.lbl_onLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_onLight.Location = new System.Drawing.Point(38, 143);
            this.lbl_onLight.Name = "lbl_onLight";
            this.lbl_onLight.Size = new System.Drawing.Size(57, 32);
            this.lbl_onLight.TabIndex = 2;
            this.lbl_onLight.Text = "ON";
            // 
            // pnl_OffLight
            // 
            this.pnl_OffLight.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_OffLight.Location = new System.Drawing.Point(529, 12);
            this.pnl_OffLight.Name = "pnl_OffLight";
            this.pnl_OffLight.Size = new System.Drawing.Size(122, 128);
            this.pnl_OffLight.TabIndex = 1;
            // 
            // pnl_OnLight
            // 
            this.pnl_OnLight.BackColor = System.Drawing.Color.LightYellow;
            this.pnl_OnLight.Location = new System.Drawing.Point(12, 12);
            this.pnl_OnLight.Name = "pnl_OnLight";
            this.pnl_OnLight.Size = new System.Drawing.Size(122, 128);
            this.pnl_OnLight.TabIndex = 0;
            // 
            // LichtOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 723);
            this.Controls.Add(this.pnl_chooseTileColor);
            this.Controls.Add(this.classic);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.local_highscores);
            this.Controls.Add(this.logo);
            this.Name = "LichtOut";
            this.Text = "LichtOut";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnl_chooseTileColor.ResumeLayout(false);
            this.pnl_chooseTileColor.PerformLayout();
            this.pnl_startGame.ResumeLayout(false);
            this.gb_offColors.ResumeLayout(false);
            this.gb_offColors.PerformLayout();
            this.gb_onColors.ResumeLayout(false);
            this.gb_onColors.PerformLayout();
            this.ResumeLayout(false);

        }

        private void ShowLocalHighscores(object sender, System.EventArgs e)
        {
            StringBuilder output = new StringBuilder();
            try
            {
                IEnumerable<string> scores = File.ReadLines(@"Resources/HighScores.txt");
                int count = 5;
                List<Tuple<string, int, double>> highscores = new List<Tuple<string, int, double>>();

                foreach (var line in scores)
                {
                    string[] split = line.Split('|');
                    highscores.Add(new Tuple<string, int, double>(split[0], int.Parse(split[2]), double.Parse(split[1])));
                }

                highscores = highscores.OrderBy(x => x.Item2)
                    .ThenBy(x => x.Item3)
                    .ThenBy(x => x.Item1)
                    .ToList();

                output.AppendLine(String.Format("TOP {0}: {1}", (highscores.Count >= 5) ? "5" : highscores.Count.ToString(), Environment.NewLine));
                foreach (var score in highscores)
                {
                    if (count == 0) break;
                    output.AppendLine(String.Format("[{0} / clicks: {1} / secs: {2:F2}]", score.Item1, score.Item2, score.Item3));
                    --count;
                }

            }
            catch (FileNotFoundException)
            {
                output.Clear();
                output.AppendLine("There are no highscores yet!");
            }
            catch (FileLoadException)
            {
                output.Clear();
                output.AppendLine("There are no highscores yet!");
            }
            catch (Exception ex)
            {
                output.Clear();
                output.AppendLine(ex.Message);
            }
            finally
            {
                MessageBox.Show(output.ToString());
            }
        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button classic;
        private System.Windows.Forms.Button local_highscores;
        private System.Windows.Forms.Panel pnl_chooseTileColor;
        private System.Windows.Forms.Label lbl_offLight;
        private System.Windows.Forms.Label lbl_onLight;
        private System.Windows.Forms.Panel pnl_OffLight;
        private System.Windows.Forms.Panel pnl_OnLight;
        private System.Windows.Forms.GroupBox gb_offColors;
        private System.Windows.Forms.RadioButton rb_off_pink;
        private System.Windows.Forms.RadioButton rb_off_grey;
        private System.Windows.Forms.RadioButton rb_off_blue;
        private System.Windows.Forms.RadioButton rb_off_green;
        private System.Windows.Forms.GroupBox gb_onColors;
        private System.Windows.Forms.RadioButton rb_on_pink;
        private System.Windows.Forms.RadioButton rb_on_blue;
        private System.Windows.Forms.RadioButton rb_on_green;
        private System.Windows.Forms.RadioButton rb_on_yellow;
        private System.Windows.Forms.Button btn_sartGame;
        private System.Windows.Forms.Panel pnl_startGame;
    }
}