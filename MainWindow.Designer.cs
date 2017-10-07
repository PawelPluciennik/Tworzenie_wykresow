namespace Tworzenie_wykresow
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblMotionType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_a = new System.Windows.Forms.TextBox();
            this.tBox_V_0 = new System.Windows.Forms.TextBox();
            this.tBoxX_0 = new System.Windows.Forms.TextBox();
            this.cBoxMotionType = new System.Windows.Forms.ComboBox();
            this.btnAddMotion = new System.Windows.Forms.Button();
            this.chartMotions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClearMotion = new System.Windows.Forms.Button();
            this.lBoxEquations = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBox_x_P = new System.Windows.Forms.TextBox();
            this.tBox_x_K = new System.Windows.Forms.TextBox();
            this.tBox_t_P = new System.Windows.Forms.TextBox();
            this.tBox_t_K = new System.Windows.Forms.TextBox();
            this.btn_SetPosition = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMotions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMotionType
            // 
            this.lblMotionType.AutoSize = true;
            this.lblMotionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMotionType.Location = new System.Drawing.Point(32, 12);
            this.lblMotionType.Name = "lblMotionType";
            this.lblMotionType.Size = new System.Drawing.Size(119, 29);
            this.lblMotionType.TabIndex = 0;
            this.lblMotionType.Text = "Typ ruchu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "V. =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "x. =";
            // 
            // tBox_a
            // 
            this.tBox_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_a.Location = new System.Drawing.Point(81, 85);
            this.tBox_a.Name = "tBox_a";
            this.tBox_a.Size = new System.Drawing.Size(100, 35);
            this.tBox_a.TabIndex = 4;
            // 
            // tBox_V_0
            // 
            this.tBox_V_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_V_0.Location = new System.Drawing.Point(81, 144);
            this.tBox_V_0.Name = "tBox_V_0";
            this.tBox_V_0.Size = new System.Drawing.Size(100, 35);
            this.tBox_V_0.TabIndex = 5;
            // 
            // tBoxX_0
            // 
            this.tBoxX_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxX_0.Location = new System.Drawing.Point(81, 200);
            this.tBoxX_0.Name = "tBoxX_0";
            this.tBoxX_0.Size = new System.Drawing.Size(100, 35);
            this.tBoxX_0.TabIndex = 6;
            // 
            // cBoxMotionType
            // 
            this.cBoxMotionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMotionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxMotionType.FormattingEnabled = true;
            this.cBoxMotionType.Location = new System.Drawing.Point(14, 44);
            this.cBoxMotionType.Name = "cBoxMotionType";
            this.cBoxMotionType.Size = new System.Drawing.Size(202, 28);
            this.cBoxMotionType.TabIndex = 7;
            this.cBoxMotionType.SelectedIndexChanged += new System.EventHandler(this.cBoxMotionType_SelectedIndexChanged);
            // 
            // btnAddMotion
            // 
            this.btnAddMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddMotion.Location = new System.Drawing.Point(37, 267);
            this.btnAddMotion.Name = "btnAddMotion";
            this.btnAddMotion.Size = new System.Drawing.Size(128, 42);
            this.btnAddMotion.TabIndex = 8;
            this.btnAddMotion.Text = "Dodaj";
            this.btnAddMotion.UseVisualStyleBackColor = true;
            this.btnAddMotion.Click += new System.EventHandler(this.btnAddMotion_Click);
            // 
            // chartMotions
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMotions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMotions.Legends.Add(legend1);
            this.chartMotions.Location = new System.Drawing.Point(222, 54);
            this.chartMotions.Name = "chartMotions";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMotions.Series.Add(series1);
            this.chartMotions.Size = new System.Drawing.Size(692, 495);
            this.chartMotions.TabIndex = 9;
            this.chartMotions.Text = "chart1";
            // 
            // btnClearMotion
            // 
            this.btnClearMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearMotion.Location = new System.Drawing.Point(37, 425);
            this.btnClearMotion.Name = "btnClearMotion";
            this.btnClearMotion.Size = new System.Drawing.Size(128, 29);
            this.btnClearMotion.TabIndex = 10;
            this.btnClearMotion.Text = "Usuń";
            this.btnClearMotion.UseVisualStyleBackColor = true;
            this.btnClearMotion.Click += new System.EventHandler(this.btnClearMotion_Click);
            // 
            // lBoxEquations
            // 
            this.lBoxEquations.FormattingEnabled = true;
            this.lBoxEquations.Location = new System.Drawing.Point(37, 324);
            this.lBoxEquations.Name = "lBoxEquations";
            this.lBoxEquations.Size = new System.Drawing.Size(128, 95);
            this.lBoxEquations.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(187, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(188, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(189, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(187, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(188, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(189, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "s";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(183, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "m";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "2";
            // 
            // tBox_x_P
            // 
            this.tBox_x_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_x_P.Location = new System.Drawing.Point(268, 9);
            this.tBox_x_P.Name = "tBox_x_P";
            this.tBox_x_P.Size = new System.Drawing.Size(100, 35);
            this.tBox_x_P.TabIndex = 14;
            // 
            // tBox_x_K
            // 
            this.tBox_x_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_x_K.Location = new System.Drawing.Point(424, 9);
            this.tBox_x_K.Name = "tBox_x_K";
            this.tBox_x_K.Size = new System.Drawing.Size(100, 35);
            this.tBox_x_K.TabIndex = 15;
            // 
            // tBox_t_P
            // 
            this.tBox_t_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_t_P.Location = new System.Drawing.Point(575, 9);
            this.tBox_t_P.Name = "tBox_t_P";
            this.tBox_t_P.Size = new System.Drawing.Size(100, 35);
            this.tBox_t_P.TabIndex = 16;
            // 
            // tBox_t_K
            // 
            this.tBox_t_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_t_K.Location = new System.Drawing.Point(726, 9);
            this.tBox_t_K.Name = "tBox_t_K";
            this.tBox_t_K.Size = new System.Drawing.Size(100, 35);
            this.tBox_t_K.TabIndex = 17;
            // 
            // btn_SetPosition
            // 
            this.btn_SetPosition.Location = new System.Drawing.Point(831, 9);
            this.btn_SetPosition.Name = "btn_SetPosition";
            this.btn_SetPosition.Size = new System.Drawing.Size(83, 35);
            this.btn_SetPosition.TabIndex = 18;
            this.btn_SetPosition.Text = "Zatwierdź";
            this.btn_SetPosition.UseVisualStyleBackColor = true;
            this.btn_SetPosition.Click += new System.EventHandler(this.btn_SetPosition_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(218, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 29);
            this.label13.TabIndex = 19;
            this.label13.Text = "x  =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(374, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "x  =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(530, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 29);
            this.label15.TabIndex = 21;
            this.label15.Text = "t  =";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(681, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 29);
            this.label16.TabIndex = 22;
            this.label16.Text = "t  =";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(543, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "P";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(693, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "K";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(390, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "K";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(237, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "P";
            this.label20.Click += new System.EventHandler(this.label17_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(42, 222);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(39, 166);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 561);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_SetPosition);
            this.Controls.Add(this.tBox_t_K);
            this.Controls.Add(this.tBox_t_P);
            this.Controls.Add(this.tBox_x_K);
            this.Controls.Add(this.tBox_x_P);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lBoxEquations);
            this.Controls.Add(this.btnClearMotion);
            this.Controls.Add(this.chartMotions);
            this.Controls.Add(this.btnAddMotion);
            this.Controls.Add(this.cBoxMotionType);
            this.Controls.Add(this.tBoxX_0);
            this.Controls.Add(this.tBox_V_0);
            this.Controls.Add(this.tBox_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMotionType);
            this.Name = "MainWindow";
            this.Text = "Tworzenie Wykresów";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMotions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMotionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBox_a;
        private System.Windows.Forms.TextBox tBox_V_0;
        private System.Windows.Forms.TextBox tBoxX_0;
        private System.Windows.Forms.ComboBox cBoxMotionType;
        private System.Windows.Forms.Button btnAddMotion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMotions;
        private System.Windows.Forms.Button btnClearMotion;
        private System.Windows.Forms.ListBox lBoxEquations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBox_x_P;
        private System.Windows.Forms.TextBox tBox_x_K;
        private System.Windows.Forms.TextBox tBox_t_P;
        private System.Windows.Forms.TextBox tBox_t_K;
        private System.Windows.Forms.Button btn_SetPosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

