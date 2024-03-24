using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClassLibrary2;
using ClassLibrary2.PRESENTER;


namespace WinFormsApp1
{
    public partial class Form10 : Form, IPresenter

    {
        SlaveSend SendingCosm;
        AddPlanet ShowPlan;
        public Form10()
        {
            InitializeComponent();
            SendingCosm = new SlaveSend(this);
            ShowPlan = new AddPlanet(this);

        }
             
        public string EarthPeople { 
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string SendingPeople {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string Description {
            get { return richTextBox2.Text; }
            set { richTextBox2.Text = value; }
        }
        public string Sended
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }
        public string Atmosphere
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string PlanetName
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string Radius
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public string? Log { get; set; }
        public string Date
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        private void Sending(object sender, EventArgs e)
        {   
            SendingCosm.Send();
        }
        private void AddingPlanet(object sender, EventArgs e)
        {           
            ShowPlan.Show();
        }
    }
}

