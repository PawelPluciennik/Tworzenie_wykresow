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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_a = new System.Windows.Forms.TextBox();
            this.tBox_V_0 = new System.Windows.Forms.TextBox();
            this.tBoxX_0 = new System.Windows.Forms.TextBox();
            this.cBoxMotionType = new System.Windows.Forms.ComboBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lBoxEquations = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Typ ruchu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "V_0 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "X_0 =";
            // 
            // tBox_a
            // 
            this.tBox_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_a.Location = new System.Drawing.Point(89, 99);
            this.tBox_a.Name = "tBox_a";
            this.tBox_a.Size = new System.Drawing.Size(100, 35);
            this.tBox_a.TabIndex = 4;
            // 
            // tBox_V_0
            // 
            this.tBox_V_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBox_V_0.Location = new System.Drawing.Point(89, 145);
            this.tBox_V_0.Name = "tBox_V_0";
            this.tBox_V_0.Size = new System.Drawing.Size(100, 35);
            this.tBox_V_0.TabIndex = 5;
            // 
            // tBoxX_0
            // 
            this.tBoxX_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxX_0.Location = new System.Drawing.Point(89, 190);
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
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_generate.Location = new System.Drawing.Point(37, 249);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(121, 42);
            this.btn_generate.TabIndex = 8;
            this.btn_generate.Text = "Dodaj";
            this.btn_generate.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(222, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(650, 537);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_clear.Location = new System.Drawing.Point(60, 407);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 29);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Usuń";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // lBoxEquations
            // 
            this.lBoxEquations.FormattingEnabled = true;
            this.lBoxEquations.Location = new System.Drawing.Point(37, 306);
            this.lBoxEquations.Name = "lBoxEquations";
            this.lBoxEquations.Size = new System.Drawing.Size(128, 95);
            this.lBoxEquations.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lBoxEquations);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.cBoxMotionType);
            this.Controls.Add(this.tBoxX_0);
            this.Controls.Add(this.tBox_V_0);
            this.Controls.Add(this.tBox_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBox_a;
        private System.Windows.Forms.TextBox tBox_V_0;
        private System.Windows.Forms.TextBox tBoxX_0;
        private System.Windows.Forms.ComboBox cBoxMotionType;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox lBoxEquations;
    }
}

