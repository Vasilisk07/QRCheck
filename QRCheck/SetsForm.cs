using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCheck
{
    public partial class SetsForm : Form
    {

        string PathFile;
        Logic Lg;
        FileInfo fileDT;
        GlobalData GlobalDt;
        public SetsForm()
        {
            InitializeComponent();
        }



        public SetsForm(Logic lg)
        {
            InitializeComponent();
            PathFile = lg.PathDb;
            Lg = lg;
        }

        private void SetingsForm_Load(object sender, EventArgs e)
        {

            if (File.Exists(PathFile))
            {
                fileDT = new FileInfo(PathFile);
                GlobalDt = Lg.DEserialXML();
                if (GlobalDt.TimeOfModified != fileDT.LastWriteTime)
                {
                    MessageBox.Show("Файл Шаблонів було модифіковано стороннім Програмним забезпеченням\nДата Модифікації: " + fileDT.LastWriteTime.ToString(), "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GlobalDt.ValidModify = false;
                    DrawListbox();
                }


                


            }

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        void DrawListbox()
        {
            listBox1.Items.Clear();
            foreach (var item in GlobalDt.patternObjList)
            {
                listBox1.Items.Add(item);


            }

        }



    }
}
