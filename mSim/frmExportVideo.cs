using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mSim
{
    public partial class frmExportVideo : Form
    {
        public int minStep { get; set; }
        public int maxStep { get; set; }

        public frmExportVideo(string lang)
        {
            InitializeComponent();
        }

    }
}
