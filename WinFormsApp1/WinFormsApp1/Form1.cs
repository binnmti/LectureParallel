namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            MessageBox.Show("Hello World!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Thread.Sleep(3000);
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Thread.Sleep(3000);
            Cursor = Cursors.Default;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("Hello World!");
            });
            thread.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            Cursor = Cursors.WaitCursor;

            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("Hello World!");
                Invoke(() => {
                    Cursor = Cursors.Default;
                    button5.Enabled = true;
                });
            });

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            Cursor = Cursors.WaitCursor;
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("Hello World!");
            });
            Cursor = Cursors.Default;
            button6.Enabled = true;
        }
    }
}
