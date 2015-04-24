using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SoyService
{
    public partial class SoyService : ServiceBase
    {
        public SoyService()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            MessageBox.Show("Soy Service Started");

            try
            {
                System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not create file");
            }
        }

        protected override void OnStop()
        {
            MessageBox.Show("Soy Service Stopped");

            try
            {
                System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStop.txt");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not create file");
            }
        }
    }
}
