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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        private IDatabase db = ConnectionMultiplexer.Connect("127.0.0.1:6379").GetDatabase();

        private void btn_Get_Click(object sender, EventArgs e)
        {
            //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");

            //// 获取Redis数据库
            //IDatabase db = redis.GetDatabase();


            // 从队列中获取产品
            string product = db.ListLeftPop("GetSN");
            // 显示获取的产品
            labelControl1.Text = product;


        }

        private void btn_Supply_Click(object sender, EventArgs e)
        {
            //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");

            //// 获取Redis数据库
            //IDatabase db = redis.GetDatabase();


            //补充数据
            RedisValue value = db.ListGetByIndex("GetSN", -1);
            string Idx = value.ToString().Substring(value.ToString().Length - 4);
            string Head = value.ToString().Substring(0, value.ToString().Length - 4);
            // 检查List的条目数量
            long count = db.ListLength("GetSN");   //返回类型是long

            // 如果不足1000条，添加数据
            if (count < 1000)
            {
                long remaining = 1000 - count;

                for (long i = 0; i < remaining; i++)
                {
                    string newstr = Head + (Convert.ToInt32(Idx) + i + 1).ToString("0000");
                    db.ListRightPush("GetSN", newstr);
                }
                labelControl2.Text = ($"{remaining} 条数据已添加到List中");
            }
            else
                labelControl2.Text = "无需补充";
        }

        private void btn_Head_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Head.Text))
            {
                labelControl3.Text = ("Head不能为空！");
                return;
            }

            // 判断Key是否存在
            bool keyExists = db.KeyExists(txt_Head.Text);
            if (keyExists)
            {
                RedisType keyType = db.KeyType(txt_Head.Text);

                if (keyType == RedisType.List)
                {
                    // 键存在且是一个List类型
                    long length = db.ListLength(txt_Head.Text);
                    if (length == 0)
                    {
                        // List为空，生成队列
                        for (int i = 1; i <= 1000; i++)
                        {
                            db.ListRightPush(txt_Head.Text, txt_Head.Text + i.ToString("0000"));
                        }
                        labelControl3.Text = "生成键值成功！";
                    }
                    else
                    {
                        labelControl3.Text = "已存在无需生成";
                    }
                }
                else
                {
                    // 删除之前的键
                    db.KeyDelete(txt_Head.Text);

                    // 在Redis数据库中生成一个队列
                    for (int i = 1; i <= 1000; i++)
                    {
                        db.ListRightPush(txt_Head.Text, txt_Head.Text + i.ToString("0000"));
                    }
                    labelControl3.Text = "生成键值成功！";
                }
            }
            else
            {
                // 在Redis数据库中生成一个队列
                for (int i = 1; i <= 1000; i++)
                {
                    db.ListRightPush(txt_Head.Text, txt_Head.Text + i.ToString("0000"));
                }
                labelControl3.Text = "生成键值成功！";
            }

        }
    }
}