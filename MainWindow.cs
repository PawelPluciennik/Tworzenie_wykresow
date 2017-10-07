using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tworzenie_wykresow.Model;
using Tworzenie_wykresow.Properties;

namespace Tworzenie_wykresow
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            UpdateViewAfterInitialization();
            SetMotionTypeInComboBox();

            chartMotions.Series.Clear();
            chartMotions.ChartAreas[0].AxisX.ScaleView.Zoom(0, 10);
            chartMotions.ChartAreas[0].AxisY.ScaleView.Zoom(0, 10);
            chartMotions.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartMotions.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartMotions.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //label3.Text = "V" + (char)0x0052;
            //label4.Text = "x" + (char)0x0032;

            tBox_t_K.Text = "0";
            tBox_t_P.Text = "0";
            tBox_x_K.Text = "0";
            tBox_x_P.Text = "0";
            tBox_a.Text = "0";
            tBox_V_0.Text = "0";
            tBoxX_0.Text = "0";

            SetConstantStrings();
        }

        private void SetConstantStrings()
        {
            lblMotionType.Text = Resources.MotionType;
            btn_SetPosition.Text = Resources.Confirm;
        }

        private void UpdateViewAfterInitialization()
        {
            tBox_a.Enabled = false;
            tBox_V_0.Enabled = false;
            tBoxX_0.Enabled = false;
            btnClearMotion.Enabled = false;
            btnAddMotion.Enabled = false;
            lBoxEquations.Enabled = false;

            tBox_t_K.Enabled = false;
            tBox_t_P.Enabled = false;
            tBox_x_K.Enabled = false;
            tBox_x_P.Enabled = false;
            btn_SetPosition.Enabled = false;
        }

        private void SetMotionTypeInComboBox()
        {
            cBoxMotionType.Items.Insert(0, "- wybierz -");
            cBoxMotionType.Items.Insert(1, "Jednostajny");
            cBoxMotionType.Items.Insert(2, "Jednostajnie przyspieszony");
            cBoxMotionType.SelectedIndex = 0;
        }

        private MotionType GetSelectedMotionType()
        {
            switch (cBoxMotionType.SelectedIndex)
            {
                case 1:
                    return MotionType.UniformLinearMotion;
                case 2:
                    return MotionType.UniformAcceleratedLinearMotion;
                default:
                    return MotionType.NoMotion;
            }
        }

        private void cBoxMotionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MotionType type = GetSelectedMotionType();

            if (type == MotionType.NoMotion)
            {
                UpdateViewForNoMotionSelected();
            }
            else if (type == MotionType.UniformLinearMotion)
            {
                UpdateViewForLinearMotionSelected();
            }
            else if (type == MotionType.UniformAcceleratedLinearMotion)
            {
                UpdateViewForUniformlyAcceleratedLinearMotionSelected();
            }
        }

        private void UpdateViewForUniformlyAcceleratedLinearMotionSelected()
        {
            tBox_a.Enabled = true;
            tBox_V_0.Enabled = true;
            tBoxX_0.Enabled = true;
            btnAddMotion.Enabled = true;
            lBoxEquations.Enabled = false;

            tBox_t_K.Enabled = true;
            tBox_t_P.Enabled = true;
            tBox_x_K.Enabled = true;
            tBox_x_P.Enabled = true;
            btn_SetPosition.Enabled = true;
        }

        private void UpdateViewForLinearMotionSelected()
        {
            tBox_a.Enabled = false;
            tBox_V_0.Enabled = true;
            tBoxX_0.Enabled = true;
            btnAddMotion.Enabled = true;
            lBoxEquations.Enabled = false;

            tBox_t_K.Enabled = true;
            tBox_t_P.Enabled = true;
            tBox_x_K.Enabled = true;
            tBox_x_P.Enabled = true;
            btn_SetPosition.Enabled = true;
        }

        private void UpdateViewForNoMotionSelected()
        {
            tBox_a.Enabled = false;
            tBox_V_0.Enabled = false;
            tBoxX_0.Enabled = false;
            btnClearMotion.Enabled = false;
            btnAddMotion.Enabled = false;
            lBoxEquations.Enabled = false;

            tBox_t_K.Enabled = false;
            tBox_t_P.Enabled = false;
            tBox_x_K.Enabled = false;
            tBox_x_P.Enabled = false;
            btn_SetPosition.Enabled = false;
        }

        private void SetChart()
        {

        }

        private void btnAddMotion_Click(object sender, EventArgs e)
        {



            double position, aceeleration, velocity, x_P, x_K, t_P, t_K;







            if (GetSelectedMotionType() == MotionType.UniformLinearMotion)
            {


                if (VerifyVelocityAndPositionValues(out velocity, out position))
                {

                    UniformLinearMotion motion = new UniformLinearMotion(Convert.ToDouble(tBoxX_0.Text), Convert.ToDouble(tBox_V_0.Text));

                    EquationListBox.Items.Add((EquationListBox.Items.Count + 1).ToString() + ". " + motion.ToString());

                    DrawMotion(motion);


                }





            }
            else if (GetSelectedMotionType() == MotionType.UniformAcceleratedLinearMotion)
            {
                if (VerifyAccelerationVelocityAndPositionValues(out aceeleration, out velocity, out position))
                {
                    UniformlyAcceleratedLinearMotion motion = new UniformlyAcceleratedLinearMotion(Convert.ToDouble(tBoxX_0.Text), Convert.ToDouble(tBox_V_0.Text), Convert.ToDouble(tBox_a.Text));
                    EquationListBox.Items.Add((EquationListBox.Items.Count + 1).ToString() + ". " + motion.ToString());
                    DrawMotion(motion);

                }


            }

            ListBoxRefresh();
        }

        private bool VerifyAccelerationVelocityAndPositionValues(out double aceeleration, out double velocity, out double position)
        {
            aceeleration = 0;
            if (VerifyVelocityAndPositionValues(out velocity, out position))
                if (!Double.TryParse(tBox_a.Text, out aceeleration))
                {
                    MessageBox.Show("Uzupelnij poprawnie pole 'a ='");
                    return false;
                }
                else
                {
                    return true;
                }
            else
            {
                return false;
            }

        }

        private bool VerifyVelocityAndPositionValues(out double velocity, out double position)
        {
            velocity = 0;
            position = 0;
            if (!Double.TryParse(tBoxX_0.Text, out position))
            {
                MessageBox.Show("Uzupelnij poprawnie pole 'x_0 ='");
                return false;
            }
            if (!Double.TryParse(tBox_V_0.Text, out velocity))
            {
                MessageBox.Show("Uzupelnij poprawnie pole 'V_0 ='");
                return false;
            }
            return true;
        }

        private void VerifyVelocityAndPositionValues()
        {

        }


        private void DrawMotion(UniformLinearMotion motion)
        {
            string index = EquationListBox.Items.Count.ToString();
            chartMotions.Series.Add(index);
            chartMotions.Series[index].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartMotions.Series[index].BorderWidth = 4;
            for (int i = 0; i < 100; i++)
            {
                chartMotions.Series[index].Points.AddXY(i, motion.GetPosition(i));

            }

          
        }

        private void ListBoxRefresh()
        {
            if (lBoxEquations.Items.Count > 0)
            {
                lBoxEquations.Enabled = true;
                btnClearMotion.Enabled = true;
            }
            else
            {
                lBoxEquations.Enabled = false;
                btnClearMotion.Enabled = false;
            }
        }

        public ListBox EquationListBox
        {
            get
            {
                return lBoxEquations;

            }
            set
            {
                lBoxEquations = value;
            }
        }

        private void btnClearMotion_Click(object sender, EventArgs e)
        {
            int index = EquationListBox.SelectedIndex;
            if (index >= 0)
            {
                EquationListBox.Items.RemoveAt(index);
                DeleteMotionFromChart(index);
                ListBoxRefresh();

            }

        }

        private void DeleteMotionFromChart(int index)
        {
            chartMotions.Series.RemoveAt(index);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }




        private void btn_SetPosition_Click(object sender, EventArgs e)
        {
            double initial_time, initial_position, final_time, final_position;



            if (!Double.TryParse(tBox_t_P.Text, out initial_time))
            {
                MessageBox.Show("Uzupelnij poprawnie pole 't_P ='");
                return;
            }

            if (!Double.TryParse(tBox_t_K.Text, out final_time))
            {
                MessageBox.Show("Uzupelnij poprawnie pole 't_K ='");
                return;
            }

            if (!Double.TryParse(tBox_x_K.Text, out final_position))
            {
                MessageBox.Show("Uzupelnij poprawnie pole 'x_K ='");
                return;
            }

            if (!Double.TryParse(tBox_x_P.Text, out initial_position))
            {
                MessageBox.Show("Uzupelnij poprawnie pole 'x_P ='");
                return;
            }





            chartMotions.ChartAreas[0].AxisY.ScaleView.Zoom(initial_position, final_position);
            chartMotions.ChartAreas[0].AxisX.ScaleView.Zoom(initial_time, (final_time - 1));


        }
    }
}
