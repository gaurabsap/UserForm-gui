using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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

namespace UserForm
{
    public partial class Form1 : Form
    {
        public static IMongoClient obj = new MongoClient("mongodb://localhost:27017");
        public static IMongoDatabase db = obj.GetDatabase("UserForm");
        public static IMongoCollection<UserForm> collection = db.GetCollection<UserForm>("MyColl");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm data = new UserForm(username.Text, email.Text, cpassword.Text);
            collection.InsertOne(data);

        }
    }
    public class UserForm
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Username")]
        public string Username { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }


        [BsonElement("Password")]
        public string Password { get; set; }

        public UserForm(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
