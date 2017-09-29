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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartMotions)).BeginInit();
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
            // btnAddMotion
            // 
            this.btnAddMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddMotion.Location = new System.Drawing.Point(37, 249);
            this.btnAddMotion.Name = "btnAddMotion";
            this.btnAddMotion.Size = new System.Drawing.Size(128, 42);
            this.btnAddMotion.TabIndex = 8;
            this.btnAddMotion.Text = "Dodaj";
            this.btnAddMotion.UseVisualStyleBackColor = true;
            this.btnAddMotion.Click += new System.EventHandler(this.btnAddMotion_Click);
            // 
            // chartMotions
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMotions.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMotions.Legends.Add(legend2);
            this.chartMotions.Location = new System.Drawing.Point(222, 54);
            this.chartMotions.Name = "chartMotions";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMotions.Series.Add(series2);
            this.chartMotions.Size = new System.Drawing.Size(650, 495);
            this.chartMotions.TabIndex = 9;
            this.chartMotions.Text = "chart1";
            // 
            // btnClearMotion
            // 
            this.btnClearMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearMotion.Location = new System.Drawing.Point(37, 407);
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
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartMotions)).EndInit();
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
        private System.Windows.Forms.Button btnAddMotion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMotions;
        private System.Windows.Forms.Button btnClearMotion;
        private System.Windows.Forms.ListBox lBoxEquations;
    }
}

