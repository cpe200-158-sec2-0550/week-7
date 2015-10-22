using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form,View
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();

        }
        public void Notify(Model m)
        {
            UpdateEndScore(((TwoZeroFourEightModel)m).Score);
        }
        private void UpdateEndScore(int s)
        {
            lblScore.Text = "Score = " + s;
        }
private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
