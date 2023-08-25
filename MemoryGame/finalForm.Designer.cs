namespace MemoryGame
{
    partial class finalForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.winnerPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desktopBtn = new System.Windows.Forms.Button();
            this.movesmade = new System.Windows.Forms.Label();
            this.totalPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.winnerPicture, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.desktopBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.movesmade, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.totalPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TimeLabel, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1898, 1024);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // winnerPicture
            // 
            this.winnerPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winnerPicture.Location = new System.Drawing.Point(952, 3);
            this.winnerPicture.Name = "winnerPicture";
            this.winnerPicture.Size = new System.Drawing.Size(943, 506);
            this.winnerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.winnerPicture.TabIndex = 0;
            this.winnerPicture.TabStop = false;
            this.winnerPicture.Click += new System.EventHandler(this.winnerPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(943, 512);
            this.label1.TabIndex = 1;
            this.label1.Text = "Winner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(943, 102);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moves Made:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(943, 102);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Points:";
            // 
            // desktopBtn
            // 
            this.desktopBtn.Location = new System.Drawing.Point(952, 923);
            this.desktopBtn.Name = "desktopBtn";
            this.desktopBtn.Size = new System.Drawing.Size(943, 98);
            this.desktopBtn.TabIndex = 5;
            this.desktopBtn.Text = "Return to Desktop";
            this.desktopBtn.UseVisualStyleBackColor = true;
            this.desktopBtn.Click += new System.EventHandler(this.desktopBtn_Click);
            // 
            // movesmade
            // 
            this.movesmade.AutoSize = true;
            this.movesmade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movesmade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesmade.Location = new System.Drawing.Point(952, 512);
            this.movesmade.Name = "movesmade";
            this.movesmade.Size = new System.Drawing.Size(943, 102);
            this.movesmade.TabIndex = 6;
            this.movesmade.Click += new System.EventHandler(this.movesmade_Click);
            // 
            // totalPoints
            // 
            this.totalPoints.AutoSize = true;
            this.totalPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPoints.Location = new System.Drawing.Point(952, 614);
            this.totalPoints.Name = "totalPoints";
            this.totalPoints.Size = new System.Drawing.Size(943, 102);
            this.totalPoints.TabIndex = 7;
            this.totalPoints.Click += new System.EventHandler(this.totalPoints_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 716);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(943, 102);
            this.label4.TabIndex = 8;
            this.label4.Text = "Elapsed Time:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(952, 716);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 37);
            this.TimeLabel.TabIndex = 9;
            // 
            // finalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "finalForm";
            this.Text = "finalForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.Load += new System.EventHandler(this.start);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox winnerPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button desktopBtn;
        private System.Windows.Forms.Label movesmade;
        private System.Windows.Forms.Label totalPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TimeLabel;
    }
}