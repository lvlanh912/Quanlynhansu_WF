using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu
{
    public class MControl
    {
        public void ManagerControl(Form _fr, int _state)
        {
            switch (_state)
            {
                case 1:
                    InsertState(_fr);
                    break;
                case 2:
                    UpdateState(_fr);
                    break;
                default:
                    NewState(_fr);
                    break;
            }
        }
        private void NewState(Form _fr)
        {
            foreach (Control c in _fr.Controls)
            {
                if (c is TextBox) c.Enabled = false;
                if (c is DataGridView) c.Enabled = true;
                if (c is DateTimePicker) c.Enabled = false;
                if(c is GroupBox) c.Enabled = false;
                if (c is CheckBox) c.Enabled = false;
                if (c is ComboBox)
                {
                   
                    c.Enabled = false;
                }
                if (c is Button)
                {
                    if (c.Name == "btnluu") c.Enabled = false;
                    if (c.Name == "btnhuy") c.Enabled = false;

                    if (c.Name == "btnthem") c.Enabled = true;
                    if (c.Name == "btnsua") c.Enabled = true;
                    if (c.Name == "btnxoa") c.Enabled = true;
                    if (c.Name == "btnthoat") c.Enabled = true;
                }
               
            }
        }
        private void InsertState(Form _fr)//thêm
        {
            foreach (Control c in _fr.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                    c.Text = "";
                }
                if (c is DataGridView) c.Enabled = false;
                if (c is DateTimePicker) c.Enabled = true;
                if (c is GroupBox) c.Enabled = true;
                if (c is CheckBox) c.Enabled = true;
                if (c is ComboBox) c.Enabled = true;
                if (c is Button)
                {
                    if (c.Name == "btnluu") c.Enabled = true;
                    if (c.Name == "btnhuy") c.Enabled = true;

                    if (c.Name == "btnthem") c.Enabled = false;
                    if (c.Name == "btnsua") c.Enabled = false;
                    if (c.Name == "btnxoa") c.Enabled = false;
                    if (c.Name == "btnthoat") c.Enabled = false;
                }
                if (c is ComboBox)
                {
                    c.Enabled = true;
                }
            }
        }
        private void UpdateState(Form _fr)//sửa
        {
            Regex _regex = new Regex("^txtMa.*");
            foreach (Control c in _fr.Controls)
            {
                if (c is TextBox)
                {
                    if (_regex.IsMatch(c.Name))
                        c.Enabled = false;
                    else
                    {
                        c.Enabled = true;
                    }
                }

                if (c is DataGridView) c.Enabled = false;
                if (c is DateTimePicker) c.Enabled = true;
                if (c is GroupBox) c.Enabled = true;
                if (c is CheckBox) c.Enabled = true;
                if (c is ComboBox) c.Enabled = true;
                if (c is Button)
                {
                    if (c.Name == "btnluu") c.Enabled = true;
                    if (c.Name == "btnhuy") c.Enabled = true;

                    if (c.Name == "btnthem") c.Enabled = false;
                    if (c.Name == "btnsua") c.Enabled = false;
                    if (c.Name == "btnxoa") c.Enabled = false;
                    if (c.Name == "btnthoat") c.Enabled = false;
                }
                if (c is ComboBox)
                {
                    c.Enabled = true;
                }
            }
        }

        public void CloseForm(Form _fr)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không [y/n] ?", "Thoát Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
                _fr.Close();
        }
    }
}
