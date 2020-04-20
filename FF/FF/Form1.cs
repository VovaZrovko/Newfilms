using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;
using System.Configuration;

namespace FF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MongoClient client = new MongoClient();
            GetDatabaseNames(client).GetAwaiter();
            Console.ReadLine();*/
            Search f = new Search();
            f.Show();
            this.Hide();
        }
        /*
        private static async Task GetDatabaseNames(MongoClient client)
        {
            using (var cursor = await client.ListDatabasesAsync())
            {
                var databaseDocuments = await cursor.ToListAsync();
                foreach (var databaseDocument in databaseDocuments)
                {
                    Console.WriteLine(databaseDocument["name"]);
                }
            }
        }
        */

        private void button2_Click_1(object sender, EventArgs e)
        {
            Edit g = new Edit();
            g.Show();
            this.Hide();
        }
    }
}
