namespace InventoryService
{
    public partial class Form1 : Form
    {
        InventoryManager inventoryManager;
        public Form1()
        {
            InitializeComponent();
            inventoryManager = new InventoryManager();
            UpdateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                String name = textBox1.Text;
                int Quantity = Convert.ToInt32(textBox2.Text);
                Double price = Convert.ToDouble(textBox3.Text);

                inventoryManager.Add(new Item(name, Quantity,price));
                MessageBox.Show("Added item to  inventory");
                UpdateUI();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateUI()
        {
            List<object> dstock = inventoryManager.GetAll();
            BindingSource bs = new BindingSource();
            bs.DataSource = dstock;
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            try
            {

                int id = Convert.ToInt32(textBox4.Text);
                String name = textBox1.Text;
                int Quantity = Convert.ToInt32(textBox2.Text);
                Double price = Convert.ToDouble(textBox3.Text);

                inventoryManager.Update(new Item(name, Quantity, price), id);
                MessageBox.Show("Item Updated");
                UpdateUI();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > -1)
            {
                Item selected = (Item)dataGridView1.CurrentRow.DataBoundItem;
                inventoryManager.Remove(selected);
            }

            UpdateUI();
        }
    }
}