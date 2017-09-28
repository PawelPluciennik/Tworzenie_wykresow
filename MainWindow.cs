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

namespace Tworzenie_wykresow
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
            UpdateViewAfterInitialization();
            SetMotionTypeInComboBox();
            label3.Text = "V" + (char)0x0052;
            label4.Text = "x" + (char)0x0032;
        }

        private void UpdateViewAfterInitialization()
        {
            tBox_a.Enabled = false;
            tBox_V_0.Enabled = false;
            tBoxX_0.Enabled = false;
            btn_clear.Enabled = false;
            btn_generate.Enabled = false;
            lBoxEquations.Enabled = false;
        }

        private void SetMotionTypeInComboBox()
        {
            cBoxMotionType.Items.Insert(0, "- wybierz -");
            cBoxMotionType.Items.Insert(1,"Jednostajny");
            cBoxMotionType.Items.Insert(2,"Jednostajnie przyspieszony");
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
            btn_clear.Enabled = true;
            btn_generate.Enabled = true;
            lBoxEquations.Enabled = false;
        }

        private void UpdateViewForLinearMotionSelected()
        {
            tBox_a.Enabled = false;
            tBox_V_0.Enabled = true;
            tBoxX_0.Enabled = true;
            btn_clear.Enabled = true;
            btn_generate.Enabled = true;
            lBoxEquations.Enabled = false;
        }

        private void UpdateViewForNoMotionSelected()
        {
            tBox_a.Enabled = false;
            tBox_V_0.Enabled = false;
            tBoxX_0.Enabled = false;
            btn_clear.Enabled = false;
            btn_generate.Enabled = false;
            lBoxEquations.Enabled = false;
        }

        private void SetChart()
        {



        }
    }
}
