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
        }

        private void generate_Click(object sender, EventArgs e)
        {
            //TODO 可選擇BLL DLL Controller View*2

            //參數
            BaseModel model = new BaseModel();
            model.Namespace = "namespace";
            model.DataAccessContext = "DataAccessContext";
            model.ClassName = "className";
            model.ModelName = "modelName";
            //
            DLLTemp temp = new DLLTemp(model);
            richTextBox1.Text = temp.TransformText();

        }
    }
}
