
namespace RacingSportGame_ReBGaN
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.labellosse = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.lablecoins = new System.Windows.Forms.Label();
            this.GG = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(800, 619);
            this.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DimGray;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(531, 374);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(107, 233);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // bg2
            // 
            this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
            this.bg2.Location = new System.Drawing.Point(0, -619);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(800, 619);
            this.bg2.TabIndex = 2;
            this.bg2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(167, -320);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(104, 194);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(531, -800);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(104, 194);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy2.TabIndex = 4;
            this.enemy2.TabStop = false;
            // 
            // labellosse
            // 
            this.labellosse.AutoSize = true;
            this.labellosse.BackColor = System.Drawing.Color.Wheat;
            this.labellosse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labellosse.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellosse.Location = new System.Drawing.Point(136, 37);
            this.labellosse.Name = "labellosse";
            this.labellosse.Size = new System.Drawing.Size(535, 160);
            this.labellosse.TabIndex = 5;
            this.labellosse.Text = "Бим-Бим Бам-Бам\r\n  ВЫ ПРОИГРАЛИ!!!";
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Wheat;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.Location = new System.Drawing.Point(251, 227);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(298, 66);
            this.restart.TabIndex = 6;
            this.restart.Text = "Ah shit, here we go again";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(445, -550);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(32, 32);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 7;
            this.coin.TabStop = false;
            // 
            // lablecoins
            // 
            this.lablecoins.AutoSize = true;
            this.lablecoins.BackColor = System.Drawing.Color.Wheat;
            this.lablecoins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lablecoins.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lablecoins.Location = new System.Drawing.Point(12, 9);
            this.lablecoins.Name = "lablecoins";
            this.lablecoins.Size = new System.Drawing.Size(120, 36);
            this.lablecoins.TabIndex = 8;
            this.lablecoins.Text = "Монет: 0";
            // 
            // GG
            // 
            this.GG.BackColor = System.Drawing.Color.Wheat;
            this.GG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GG.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GG.Location = new System.Drawing.Point(313, 495);
            this.GG.Name = "GG";
            this.GG.Size = new System.Drawing.Size(183, 65);
            this.GG.TabIndex = 9;
            this.GG.Text = "GG я ливаю";
            this.GG.UseVisualStyleBackColor = false;
            this.GG.Click += new System.EventHandler(this.button1_Click);
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.Wheat;
            this.credits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.credits.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.credits.Location = new System.Drawing.Point(313, 374);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(183, 65);
            this.credits.TabIndex = 10;
            this.credits.Text = "О программе";
            this.credits.UseVisualStyleBackColor = false;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.GG);
            this.Controls.Add(this.lablecoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.labellosse);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label labellosse;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label lablecoins;
        private System.Windows.Forms.Button GG;
        private System.Windows.Forms.Button credits;
    }
}

