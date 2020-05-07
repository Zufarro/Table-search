using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tables
{
    public partial class MainForm : Form
    {
        Hash_Table hash_table = new Hash_Table();
        Sorted_Table sorted_table = new Sorted_Table();

        public MainForm()
        {
            InitializeComponent();
            cbAction.Items.Add("Удалить");
            cbAction.Items.Add("Поиск методом перебора");
            cbAction.Items.Add("Поиск методом половинного деления");
            cbAction.Items.Add("Поиск методом хеширования");
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            hash_table.Insert(Convert.ToInt32(tbKey.Text), tbValue.Text);
            sorted_table.InsertSorted(Convert.ToInt32(tbKey.Text), tbValue.Text);
            tbKey.Clear();
            tbValue.Clear();
        }


            private void CbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = (string)cbAction.SelectedItem;
            switch (Item)
            {
                case "Удалить":
                    tbResult.Clear();
                    hash_table.Delete(Convert.ToInt32(tbExistKey.Text));
                    sorted_table.Delete(Convert.ToInt32(tbExistKey.Text));
                    tbResult.AppendText(hash_table.GetMess());
                    tbExistKey.Clear();
                    break;
                case "Поиск методом перебора":
                    tbResult.Clear();
                    sorted_table.Search_brute_force(Convert.ToInt32(tbExistKey.Text));
                    tbResult.AppendText(sorted_table.GetMess());
                    tbExistKey.Clear();
                    break;
                case "Поиск методом половинного деления":
                    tbResult.Clear();
                    sorted_table.Search_half_division(0, sorted_table.GetNum() - 1, Convert.ToInt32(tbExistKey.Text));
                    tbResult.AppendText(sorted_table.GetMess());
                    tbExistKey.Clear();
                    break;
                case "Поиск методом хеширования":
                    tbResult.Clear();
                    hash_table.Search_hash(Convert.ToInt32(tbExistKey.Text));
                    tbResult.AppendText(hash_table.GetMess());
                    tbExistKey.Clear();

  
                    break;
                default:
                    break;
            } 
        }

        private void TbKey_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            hash_table.Print(tbResult);
        }

        private void TbExistKey_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
