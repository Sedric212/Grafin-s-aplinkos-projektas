using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Inputpage1 : UserControl
    {
        public event Action<string> OnScenarioSelected; // Įvykis perduoti scenarijų

        public Inputpage1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Validacija
            if (!ValidateInputs(out string message))
            {
                MessageBox.Show(message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parinkti scenarijų pagal įvestus duomenis
            string scenario = SelectScenario(GetComboBoxGender());
            OnScenarioSelected?.Invoke(scenario);
        }

        private bool ValidateInputs(out string message)
        {
            message = string.Empty;

            // Patikriname ūgį
            if (!int.TryParse(textBoxHeight.Text, out int height) || height < 100 || height > 250)
            {
                message = "Prašome įvesti tinkamą ūgį (100–250 cm).";
                return false;
            }

            // Patikriname svorį
            if (!int.TryParse(textBoxWeight.Text, out int weight) || weight < 30 || weight > 300)
            {
                message = "Prašome įvesti tinkamą svorį (30–300 kg).";
                return false;
            }

            // Patikriname, ar pasirinkta lytis
            if (comboBoxGender.SelectedIndex == -1)
            {
                message = "Prašome pasirinkti lytį.";
                return false;
            }

            // Patikriname, ar pasirinktas tikslas
            if (comboBoxGoal.SelectedIndex == -1)
            {
                message = "Prašome pasirinkti tikslą.";
                return false;
            }

            return true;
        }

        private ComboBox GetComboBoxGender()
        {
            return comboBoxGender;
        }

        private string SelectScenario(ComboBox comboBoxGender)
        {
            string gender = comboBoxGender.SelectedItem.ToString();
            string goal = comboBoxGoal.SelectedItem.ToString();

            if (gender == "Vyras")
            {
                if (goal == "Numesti svorio") return "Scenario1";
                if (goal == "Padidinti svorį") return "Scenario2";
                if (goal == "Išlaikyti formą") return "Scenario3";
            }
            else if (gender == "Moteris")
            {
                if (goal == "Numesti svorio") return "Scenario4";
                if (goal == "Padidinti svorį") return "Scenario5";
                if (goal == "Išlaikyti formą") return "Scenario6";
            }

            return string.Empty; // Neturėtų nutikti
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGoal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
