using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinitabApplication.Control
{
    public partial class Capability : UserControl
    {
        private Dictionary<string, object> resultObject = new Dictionary<string, object>();
        public Capability()
        {
            InitializeComponent();
        }
        public Capability(Dictionary<string, object> resultObject)
        {
            this.resultObject = resultObject;
            InitializeComponent();
        }

        public void DrawImage(string imgpath)
        {
            try
            {
                System.IO.FileInfo file = new System.IO.FileInfo(imgpath);
                if (!file.Exists) return;
                System.IO.FileStream stream = file.OpenRead();
                Image img = Image.FromStream(stream);
                stream.Close();
                this.pBox.Image = img;
                //this.pBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayResultInfo()
        {
            try
            {
                Object aver = this.resultObject["平均值"];
                Object sample = this.resultObject["样本N"];
                Object LSL = this.resultObject["LSL"];
                Object Target = this.resultObject["Target"];
                Object USL = this.resultObject["USL"];
                Object WSt_Dev = this.resultObject["WStDev"];
                Object OSt_Dev = this.resultObject["OStDev"];
                Object Cp = this.resultObject["Cp"];
                Object Pp = this.resultObject["Pp"];
                Object CPL = this.resultObject["CPL"];
                Object CPU = this.resultObject["CPU"];
                Object CPK = this.resultObject["Cpk"];
                Object PPL = this.resultObject["PPL"];
                Object PPU = this.resultObject["PPU"];
                Object PPK = this.resultObject["Ppk"];
                Object CPM = this.resultObject["Cpm"];
                if (Target is double[])
                    this.tbTarget.Text = ((double[])Target)[0].ToString();
                if (aver is double[])
                    this.tbAverage.Text = ((double[])aver)[0].ToString();
                if (sample is double[])
                    this.tbSample.Text = ((double[])sample)[0].ToString();
                if (LSL is double[])
                    this.tbLSL.Text = ((double[])LSL)[0].ToString();
                if (USL is double[])
                    this.tbUSL.Text = ((double[])USL)[0].ToString();
                if (WSt_Dev is double[])
                    this.tbWSt_Dev.Text = ((double[])WSt_Dev)[0].ToString();
                if (OSt_Dev is double[])
                    this.tbOSt_Dev.Text = ((double[])OSt_Dev)[0].ToString();
                if (Cp is double[])
                    this.tbCp.Text = ((double[])Cp)[0].ToString();
                if (CPK is double[])
                    this.tbCPK.Text = ((double[])CPK)[0].ToString();
                if (Pp is double[])
                    this.tbPp.Text = ((double[])Pp)[0].ToString();
                if (PPK is double[])
                    this.tbPPK.Text = ((double[])PPK)[0].ToString();
                if (CPL is double[])
                    this.tbCPL.Text = ((double[])CPL)[0].ToString();
                if (CPU is double[])
                    this.tbCPU.Text = ((double[])CPU)[0].ToString();
                if (CPM is double[])
                    this.tbCPM.Text = ((double[])CPM)[0].ToString();
                if (PPL is double[])
                    this.tbPPL.Text = ((double[])PPL)[0].ToString();
                if (PPU is double[])
                    this.tbPPU.Text = ((double[])PPU)[0].ToString();
                this.tbAverage.Select(0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
