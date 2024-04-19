using System.Drawing.Text;

namespace Provhanterare_Osama_TE2 {
    public partial class Form1 : Form {
        // Array to hold correct answers
        private List<string> facit = new List<string>() { "C1", "B2", "A3", "A4", "D5", "B6", "B7", "B8" };
        // List to hold user's answers
        private List<string> answers;

        public Form1() {
            InitializeComponent();
            answers = new List<string>();

        }

        private void groupBox7_Enter(object sender, EventArgs e) {

        }

        private void groupBox12_Enter(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save a text file";
            saveFileDialog.ShowDialog();

            // Check if user selected a file
            if (saveFileDialog.FileName != "") {                // Write user's answers and results to the selected file
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName)) {
                    SaveRadioButtonAnswers(writer);
                    writer.WriteLine("---------------------------------------------------------");
                    SaveResultsRadiobutton(writer);
                    writer.WriteLine("---------------------------------------------------------");
                    SaveTextBoxAnswers(writer);
                    writer.WriteLine("---------------------------------------------------------");
                    SaveResultText(writer);

                }
            }


        }

        private void SaveRadioButtonAnswers(StreamWriter writer) {
            writer.WriteLine("Your Results:");
            int checkedOptionCounter = 0;

            foreach (GroupBox question in panel1.Controls.OfType<GroupBox>()) {
                foreach (RadioButton option in question.Controls.OfType<RadioButton>()) {
                    if (option.Checked) {
                        checkedOptionCounter++;
                        writer.WriteLine($"Radio Button Question {checkedOptionCounter} Answer : {option.Name}");
                        answers.Add(option.Name);
                    }
                }
            }
        }


        private void SaveTextBoxAnswers(StreamWriter writer) {
            writer.WriteLine("Test Results (Text):");

            foreach (GroupBox question in panel1.Controls.OfType<GroupBox>()) {
                foreach (TextBox textBox in question.Controls.OfType<TextBox>()) {
                    writer.WriteLine(textBox.Text);
                    answers.Add(textBox.Text);
                }
            }

        }
    


        private void SaveResultsRadiobutton(StreamWriter writer) {
            writer.WriteLine("Test Results (Radiobuttons):");
            bool allQuestionsAnswered = true;

            for (int i = 0; i < facit.Count; i++) {
                // Check if the answer exists and compare it with the correct answers
                if (i < answers.Count) {
                    if (facit.Contains(answers[i])) {
                        writer.WriteLine($"Question {i + 1}: Correct!");
                    }
                    else {
                        writer.WriteLine($"Question {i + 1}: Incorrect. Correct answer is {facit[i]}");
                    }
                }
                else {
                    allQuestionsAnswered = false;
                }
            }

            // Show message box if not all questions are answered
            if (!allQuestionsAnswered) {
                MessageBox.Show("Did not answer all questions.");

            }
        }

        private void SaveResultText(StreamWriter writer) {
            writer.WriteLine("Text Results");

            writer.WriteLine("Question 9:  Moores lag kommer att tappa tempo eftersom tillverkningen blivit så komplex.");
            writer.WriteLine("Question 10: Open-source erbjuder kostnadsbesparingar och samarbete, men medför säkerhetsrisker och brist på support.");
            writer.WriteLine("Question 11: En konsekvent kodningsstil förbättrar läsbarheten, underhållet och samarbetet kring koden.");
            writer.WriteLine("Question 12: Det är pågrund av operativsystemens unika krav och kompatibilitet.");
            writer.WriteLine("Question 13: AI har breddat programmeringens möjligheter med automatisering och komplexitet.");


        }








        private void Form1_Load(object sender, EventArgs e) {

        }


        private void groupBox7_Enter_1(object sender, EventArgs e) {

        }

        private void groupBox8_Enter(object sender, EventArgs e) {

        }

        private void groupBox9_Enter(object sender, EventArgs e) {

        }

        private void groupBox10_Enter(object sender, EventArgs e) {

        }

        private void groupBox11_Enter(object sender, EventArgs e) {

        }

        private void groupBox12_Enter_1(object sender, EventArgs e) {

        }

        private void groupBox13_Enter(object sender, EventArgs e) {

        }

        private void groupBox6_Enter(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void groupBox4_Enter(object sender, EventArgs e) {

        }

        private void groupBox5_Enter(object sender, EventArgs e) {

        }

        private void groupBox3_Enter(object sender, EventArgs e) {

        }
    }

}