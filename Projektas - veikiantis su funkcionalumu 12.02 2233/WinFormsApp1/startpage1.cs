using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class startpage1 : UserControl
    {
        public event Action OnStartButtonClicked;

        public startpage1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Trigger the event to switch to the input page
            OnStartButtonClicked?.Invoke();
        }

        private void startpage1_Load(object sender, EventArgs e)
        {

        }
    }
}
