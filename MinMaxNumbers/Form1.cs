//int[] degrees = new int[14];

namespace MinMaxNumbers
{
    public partial class Form1 : Form
    {

        //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        //int[] array = new int[14];
        int[] array = new int[]{};

        // double[] balance = new double[10];

        public Form1()
        {
            InitializeComponent(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Lable

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Lable
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int max = array.Max();
            int maxIndex = Array.IndexOf(array, max);
            listBox1.Items.Add(array[maxIndex]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            int min = array.Min();
            int minIndex = Array.IndexOf(array, min);

            listBox1.Items.Add(array[minIndex]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int j = 0; j < array.Length; j++)
            {
                listBox1.Items.Add(array[j]);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();// Medelknappen
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            listBox1.Items.Add(sum/array.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var fff = textBox1.Text;

            //int[] myArray = new int[] { 1, 2, 3, 4 };
            var tempList = array.ToList();
            tempList.Add(Int32.Parse(fff));
            array = tempList.ToArray();   //equiv: myArray.Push(5);


            textBox1.Clear();

            //listBox1.Items.Add(array[0] = 4500);
            //listBox1.Items.Add(fff);
            //listBox1.Items.Add(array);
            listBox1.Items.Add(fff);

            //for (int j = 0; j < array.Length; j++)
            //{
            //    listBox1.Items.Add(array[j]);
            //}
        }
    }
}