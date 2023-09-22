using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");

            // 获取Redis数据库
            IDatabase db = redis.GetDatabase();

            // 在Redis数据库中生成一个队列
            for (int i = 1; i <= 10; i++)
            {
                db.ListRightPush("product:queue", "Product " + i);
            }

            // 从队列中获取产品
            string product = db.ListLeftPop("product:queue");

            // 显示获取的产品
            Console.WriteLine("获取的产品是: " + product);
            label1.Text = product;
        }
    }
}
