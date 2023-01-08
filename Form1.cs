using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Addon_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string verison = textBox2.Text;
            string script = richTextBox1.Text;
            System.IO.Directory.CreateDirectory(name+"-"+verison);
            String json = "{\n\"manifest_version\":2,\n\"name\":\" "+name+"\",\n \"version\": \""+verison+"\",\n \"content_scripts\": [ \n{ \n   \"matches\": [\"<all_urls>\"],\n\"js\": [\""+name+".js\"]}\n]\n}";
            File.WriteAllText(@"" + name + "-" + verison + "/" + "manifest.json", json);
            File.WriteAllText(@"" + name + "-" + verison + "/" + name+".js", script);

        }
    }
}
