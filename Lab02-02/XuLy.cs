using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    /// <summary>
    /// Mấy cái hàm xử lý gì đó xài nhiều được gom vào cái class này cho gọn
    /// </summary>
    class XuLy
    {
        /// <summary>
        /// hàm này để kiểm tra rỗng tất cả các Textbox trong một Control
        /// </summary>
        /// <param name="ct">thường là GroupBox, Panel...bla...bla...</param>
        /// <returns>nếu có một TextBox nào rỗng thì trả về false</returns>
        public bool checkTextBox(Control ct)
        {
            foreach (TextBox item in ct.Controls.OfType<TextBox>())
            {
                if(string.IsNullOrEmpty(item.Text.Trim())||string.IsNullOrWhiteSpace(item.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// hàm này để truyền vào 1 cái Control
        /// sau đó làm rỗng tất cả các Textbox có trong Control đó
        /// </summary>
        /// <param name="ct">thường là GroupBox, Panel...bla...bla...</param>
        public void ClearTextBox(Control ct)
        {
            foreach (TextBox item in ct.Controls.OfType<TextBox>())
            {
                item.Text = string.Empty;
            }
        }

 /// <summary>
 /// Hàm này để tìm ra coi có dòng nào có mã sinh viên được truyền vào không
 /// </summary>
 /// <param name="dt">cái datagridview cần kiểm tra</param>
 /// <param name="key">cái mã cần kiểm tra</param>
 /// <returns>trả về rowindex nơi có mã cần tìm,
 /// nếu không có, trả về -1 </returns>
        public int FindKey(DataGridView dt,string key)
        {
            for (int i = 0; i < dt.RowCount; i++)
            {
                if (dt.Rows[i].Cells[0].Value.Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
