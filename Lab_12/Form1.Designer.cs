
namespace Lab_12
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
            this.startBut = new System.Windows.Forms.Button();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.stopBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmdSun = new System.Windows.Forms.NumericUpDown();
            this.nmdCloud = new System.Windows.Forms.NumericUpDown();
            this.nmdRain = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmdSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdRain)).BeginInit();
            this.SuspendLayout();
            // 
            // startBut
            // 
            this.startBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.Location = new System.Drawing.Point(60, 79);
            this.startBut.Margin = new System.Windows.Forms.Padding(2);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(133, 34);
            this.startBut.TabIndex = 0;
            this.startBut.Text = "Simulate";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.ForeColor = System.Drawing.Color.Black;
            this.weatherLabel.Location = new System.Drawing.Point(53, 22);
            this.weatherLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(144, 42);
            this.weatherLabel.TabIndex = 1;
            this.weatherLabel.Text = "Погода";
            // 
            // stopBut
            // 
            this.stopBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBut.Location = new System.Drawing.Point(60, 117);
            this.stopBut.Margin = new System.Windows.Forms.Padding(2);
            this.stopBut.Name = "stopBut";
            this.stopBut.Size = new System.Drawing.Size(133, 34);
            this.stopBut.TabIndex = 2;
            this.stopBut.Text = "Stop";
            this.stopBut.UseVisualStyleBackColor = true;
            this.stopBut.Click += new System.EventHandler(this.stopBut_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Солнечно:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Облачно:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дождливо:";
            // 
            // nmdSun
            // 
            this.nmdSun.DecimalPlaces = 2;
            this.nmdSun.Location = new System.Drawing.Point(145, 175);
            this.nmdSun.Margin = new System.Windows.Forms.Padding(2);
            this.nmdSun.Name = "nmdSun";
            this.nmdSun.Size = new System.Drawing.Size(67, 20);
            this.nmdSun.TabIndex = 6;
            this.nmdSun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmdCloud
            // 
            this.nmdCloud.DecimalPlaces = 2;
            this.nmdCloud.Location = new System.Drawing.Point(145, 212);
            this.nmdCloud.Margin = new System.Windows.Forms.Padding(2);
            this.nmdCloud.Name = "nmdCloud";
            this.nmdCloud.Size = new System.Drawing.Size(66, 20);
            this.nmdCloud.TabIndex = 7;
            this.nmdCloud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmdRain
            // 
            this.nmdRain.DecimalPlaces = 2;
            this.nmdRain.Location = new System.Drawing.Point(145, 254);
            this.nmdRain.Margin = new System.Windows.Forms.Padding(2);
            this.nmdRain.Name = "nmdRain";
            this.nmdRain.Size = new System.Drawing.Size(66, 20);
            this.nmdRain.TabIndex = 8;
            this.nmdRain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 292);
            this.Controls.Add(this.nmdRain);
            this.Controls.Add(this.nmdCloud);
            this.Controls.Add(this.nmdSun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBut);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.startBut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmdSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdRain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Button stopBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmdSun;
        private System.Windows.Forms.NumericUpDown nmdCloud;
        private System.Windows.Forms.NumericUpDown nmdRain;
    }
}

