using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private startpage1 startPage;
        private Inputpage1 inputPage;
        private ProgramPage programPage;

        public Form1()
        {
            InitializeComponent();

            // Inicializuojame puslapius
            startPage = new startpage1();
            inputPage = new Inputpage1();
            programPage = new ProgramPage();

            // Rodyti pradinį puslapį
            ShowPage(startPage);

            // Susiejame įvykius
            startPage.OnStartButtonClicked += () => ShowPage(inputPage);
            inputPage.OnScenarioSelected += scenario => ShowProgramPage(scenario);
        }

        private void ShowPage(UserControl page)
        {
            panel1.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panel1.Controls.Add(page);
        }

        private void ShowProgramPage(string scenario)
        {
            programPage.LoadProgram(scenario);
            ShowPage(programPage);
        }
    }
}
