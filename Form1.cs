using System.Drawing;
namespace NotPad
{
    public partial class Form1 : Form
    {
        bool Bold=false;
        bool UnderLine=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.No;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox1.Text);
                richTextBox1.Clear();
            }
            catch { }
        }
        private void button3_Click(object sender, EventArgs e)
        {

                FontStyle currentStyle = richTextBox1.Font.Style;

                if (!UnderLine)
                {
                    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, currentStyle | FontStyle.Underline);
                    UnderLine = true;
                }
                else
                {
                    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, currentStyle & ~FontStyle.Underline);
                    UnderLine = false;
                }
            }


        
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox1.Text);
            }
            catch { }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.FileName = "Txt.txt";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text file |*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += Clipboard.GetText();
            }
            catch { }
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
         
            FontStyle currentStyle = richTextBox1.Font.Style;

            if (!Bold)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, currentStyle | FontStyle.Bold);
                Bold = true;
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, currentStyle & ~FontStyle.Bold);
                Bold = false;
            }
            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            richTextBox1.Font = fontDialog1.Font;
            fontDialog1.ShowApply = true;
            richTextBox1.ForeColor = fontDialog1.Color;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fontDialog1.Color;
                richTextBox1.Font = fontDialog1.Font;

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, new Point(100, 100));
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            richTextBox1.Font = fontDialog1.Font;
            richTextBox1.ForeColor = fontDialog1.Color;
        }
    }
}
