using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProgramPage : UserControl
    {
        public ProgramPage()
        {
            InitializeComponent();
        }

        public void LoadProgram(string scenario)
        {
            // Pavyzdinės treniruočių programos
            string programText = scenario switch
            {
                "Scenario1" => "Vyras, numesti svorio:\n10 atsispaudimų\n20 pritūpimų\n30 sekundžių lentos",
                "Scenario2" => "Vyras, priaugti svorio:\n15 atsispaudimų\n15 pritūpimų\n10 prisitraukimų",
                "Scenario3" => "Vyras, išlaikyti formą:\n20 atsispaudimų\n25 pritūpimų\n1 minutės lenta",
                "Scenario4" => "Moteris, numesti svorio:\n10 pritūpimų\n15 šuoliukų\n20 sekundžių lentos",
                "Scenario5" => "Moteris, priaugti svorio:\n10 pritūpimų\n10 atsispaudimų\n5 prisitraukimai",
                "Scenario6" => "Moteris, išlaikyti formą:\n15 pritūpimų\n20 atsispaudimų\n30 sekundžių lenta",
                _ => "Nėra tokio scenarijaus"
            };

            textBoxProgram.Text = programText;
        }
    }
}
