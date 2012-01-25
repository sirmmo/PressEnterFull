using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PressEnter.Flow;

namespace PressEnter.Gui
{
    public partial class PressEnterForm : Form
    {
        public PressEnterForm()
        {
            InitializeComponent();
            InitFlow();
            InitUI();
            RunFlow();
        }

        private void RunFlow()
        {
            
        }

        private void InitUI()
        {
            foreach (var button in _flow.Buttons)
            {
                Button b = new Button();
                b.Text = button;
                b.Click +=new EventHandler(b_Click);
                _buttons.Controls.Add(b);
            }
            _curStatus.Text = _flow.CurrentState;
        }

        void b_Click(object sender, EventArgs e)
        {
            _flow.SendEvent((sender as Button).Text);
        }
        private PressFlow _flow;
        private void InitFlow()
        {
            _flow = PressFlow.DoLoad();
            _flow.StateChanged += new EventHandler(_flow_StateChanged);
        }

        void _flow_StateChanged(object sender, EventArgs e)
        {
            string newState = sender as string;
            _curStatus.Text = newState;
        }
        private string _base = "/data/";



    }
}
