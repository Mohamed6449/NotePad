namespace NotPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            richTextBox1.Clear();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.FileName = "Txt.txt";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text file |*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text= File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This action will delete data ", "sure", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.OK)
              richTextBox1.Text +=  Clipboard.GetText();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"c:\";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text File |*.txt";
            saveFileDialog1.FileName = "Txt.txt";
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text); ;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
