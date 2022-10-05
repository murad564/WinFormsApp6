namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public object MyProduct { get; private set; }

        public Form1()
        {
            InitializeComponent();
            listBox.SelectionMode = SelectionMode.MultiSimple;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (listBox.Items.Count > 0)
            {
                listBox.Items.Remove(listBox.Items[0]);
            }
        }


        private void btn1_AddProduct_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                listBox.Items.Add(form2.MyProduct);
            }

        }

        private void btn2_EditProduct_Click(object sender, EventArgs e)
        {

            while (listBox.SelectedItems.Count > 0)
            {
                listBox.Items.Remove(listBox.SelectedItems[0]);
            }
        }

        private void btn3_RemoveProduct_Click(object sender, EventArgs e)
        {

        }
        private void btn4_ClearList_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Form1(Form2 v)
        {
            throw new NotImplementedException();
        }
    }
}