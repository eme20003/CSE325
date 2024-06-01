using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DataGridApp
{
    public partial class Form1 : Form
    {

        public class MyObject
        { 
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText("C:\\Users\\emers\\source\\repos\\CSE325\\DataGridApp\\DataGridApp\\Info.json");

            List<MyObject> data = JsonConvert.DeserializeObject<List<MyObject>>(json);

            dataGridView1.DataSource = data;

        }
    }
}
