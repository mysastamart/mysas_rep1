using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.IO;
namespace ws1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer tm = new Timer();
            tm.Interval = 3000;
            tm.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_tick);
        }

        protected override void OnStop()
        {
        }
        public void timer1_tick(object sender, ElapsedEventArgs e)
        {

            StreamWriter st = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\tf1.txt", true);

            st.WriteLine(DateTime.Now.ToString());
        }
      
    }
}
