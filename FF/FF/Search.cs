using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchAsync();
        }
        public async Task searchAsync()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Filmdb");
            var collection = database.GetCollection<BsonDocument>("Films");
            var filter = new BsonDocument();
            var people = await collection.Find(filter).ToListAsync();
            foreach (var doc in people)
            {
                Console.WriteLine(doc);
            }
        }
    }
}
