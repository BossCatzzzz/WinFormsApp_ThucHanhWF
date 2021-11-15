using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_SoanVanBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetSysFont();
            ResetFontStyle();

            ComboBox cb = new ComboBox();
            

            f = new FontFamily("Tahoma");
            size = 14;

            this.cbbFont.SelectedIndexChanged += new System.EventHandler(this.cbbFont_SelectedIndexChanged);
            this.cbbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbbFontSize_SelectedIndexChanged);
        }

        private void GetSysFont()
        {
            foreach (FontFamily item in new InstalledFontCollection().Families)
            {
                cbbFont.Items.Add(item.Name);
            }
            for (int i = 8; i < 73; i++)
            {
                cbbFontSize.Items.Add(i);
            }

        }
        private void ResetFontStyle()
        {
            richTextBox1.Font = new Font("Tahoma", 14);
            cbbFont.SelectedItem = "Tahoma";
            cbbFontSize.SelectedItem = 14;
            i = 0; b = 0; u = 0;
            toolStripButtonItalic.BackColor = Color.LightSteelBlue;
            toolStripButtonBold.BackColor = Color.LightSteelBlue;
            toolStripButtonUnderline.BackColor = Color.LightSteelBlue;
        }

        #region StyleChoose

        int b = 0, i = 0, u = 0;
        private void SetStyle(object sender, EventArgs e)
        {
            ToolStripButton bt = sender as ToolStripButton;
            switch (bt.Text)
            {
                case "B":
                    if (bt.BackColor == Color.LightCoral)//tức là đã bật
                    {
                        bt.BackColor = Color.LightSteelBlue;
                        b = 0;
                        break;
                    }
                    b = 1;
                    bt.BackColor = Color.LightCoral;
                    break;
                case "I":
                    if (bt.BackColor == Color.LightCoral)
                    {
                        bt.BackColor = Color.LightSteelBlue;
                        i = 0;
                        break;
                    }
                    i = 3;
                    bt.BackColor = Color.LightCoral;
                    break;
                case "U":
                    if (bt.BackColor == Color.LightCoral)
                    {
                        bt.BackColor = Color.LightSteelBlue;
                        u = 0;
                        break;
                    }
                    u = 5;
                    bt.BackColor = Color.LightCoral;
                    break;
            }
            FontStyle style = Style(b, i, u);
            richTextBox1.Font = new Font(f, size, style);
        }

        private FontStyle Style(int x, int y, int z)
        {
            FontStyle style_choose = FontStyle.Regular;
            int sum = x + y + z;//1    3    5
            if (sum == 1)
            {
                style_choose = FontStyle.Bold;
            }
            if (sum == 3)
            {
                style_choose = FontStyle.Italic;
            }
            if (sum == 5)
            {
                style_choose = FontStyle.Underline;
            }
            if (sum == 4)
            {
                style_choose = FontStyle.Italic | FontStyle.Bold;
            }
            if (sum == 6)
            {
                style_choose = FontStyle.Underline | FontStyle.Bold;
            }
            if (sum == 8)
            {
                style_choose = FontStyle.Italic | FontStyle.Underline;
            }
            if (sum == 9)
            {
                style_choose = FontStyle.Italic | FontStyle.Bold | FontStyle.Underline;
            }
            return style_choose;
        }
        #endregion


        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text file|*.txt;*.rtf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                dlg.FileName = dlg.FileName;
                if (dlg.FileName != "")
                {
                    if (Path.GetExtension(dlg.FileName) == ".rtf" || Path.GetExtension(dlg.FileName) == ".txt")
                    {
                        richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        MessageBox.Show("Định dạng không được hỗ trợ");
                    }

                }
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fdl = new FontDialog();
            fdl.ShowColor = true;
            fdl.ShowApply = true;
            fdl.ShowEffects = true;
            fdl.ShowHelp = true;
            if (fdl.ShowDialog() != DialogResult.Cancel)
            {

                ResetFontStyle();
                FontStyle style = fdl.Font.Style;
                Font font= fdl.Font;
                richTextBox1.Font = new Font(font, style);
                richTextBox1.ForeColor = fdl.Color;
                cbbFont.SelectedItem = fdl.Font.FontFamily.Name.ToString();
                cbbFontSize.SelectedItem = (int)fdl.Font.Size;
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            ResetFontStyle();
        }


        FontFamily f;
        int size;
        private void cbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = new FontFamily(cbbFont.SelectedItem.ToString());
            richTextBox1.Font = new Font(f, size, FontStyle.Regular);
        }
        private void cbbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = int.Parse(cbbFontSize.SelectedItem.ToString());
            richTextBox1.Font = new Font(f, size, FontStyle.Regular);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file | *.txt |Rich text format | *.rtf| All files | *.*";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
