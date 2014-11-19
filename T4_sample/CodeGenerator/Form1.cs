using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGenerator.Model;
using DLLTemp = CodeGenerator.Template.DLLTemp;

namespace CodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;//设置第一项为默认选择项。
        }

        private void generate_Click(object sender, EventArgs e)
        {
            //TODO 工廠模式 可選擇BLL DLL Controller View*2

            //參數
            BaseModel model = new BaseModel();
            model.TypeName = comboBox1.SelectedItem.ToString();
            model.Namespace = txtNamespace.Text;
            model.DataAccessContext = txtdbContext.Text;
            model.ClassName = txtClassName.Text;
            model.ModelName = txtModelName.Text;

            //TODO 工廠模式 
            Factory temp = new Factory(model);
            if (temp.Interface == null) return;
            richTextBox1.Text = temp.Interface.TransformText();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDLL.Visible = false;

            if (comboBox1.SelectedItem.ToString() == "DLL")
            {
                panelDLL.Visible = true;
            }
            
        }
    }
}
