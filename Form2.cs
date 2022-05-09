using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram
{
    
    public partial class Form2 : Form
    {

        public enum ControlParseCase {
            None,
            Name
        }

        public Form2()
        {
            InitializeComponent();
        }

        //6개월중 고가로 가야하는가 이부분 토의 필요
        private void Form2_Load(object sender, EventArgs e)
        {
            lvwStockInfo.View = View.Details;

            lvwStockInfo.Columns.Add("Name", "종목명");
            lvwStockInfo.Columns.Add("High", "고가");
            lvwStockInfo.Columns.Add("Low", "저가");
            lvwStockInfo.Columns.Add("Current", "현재가");
            lvwStockInfo.Columns.Add("Profit", "수익률");
            //lvwStockInfo.Columns.Add("Profit", "수익금");
            lvwStockInfo.Columns.Add("Count", "보유 주식수");

            lvwStockInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            var lvwItem = new ListViewItem("스마트팜");
            
            
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");

            lvwStockInfo.Items.Add(lvwItem);

            lvwItem = new ListViewItem(new string[lvwStockInfo.Columns.Count]);

            lvwItem.SubItems.Add("스마트팜");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");

            lvwStockInfo.Items.Add(lvwItem);

            lvwItem = new ListViewItem(new string[lvwStockInfo.Columns.Count]);

            lvwItem.SubItems.Add("스마트팜");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");
            lvwItem.SubItems.Add("5000");

            lvwStockInfo.Items.Add(lvwItem);
           

            

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (/*어떻게 검색되는지 몰라서 문제*/false)
                MessageBox.Show("잘못된 종목명입니다.");

            var lvwItem = new ListViewItem(new string[lvwStockInfo.Columns.Count]);

            for (int i = 0; i<lvwStockInfo.Columns.Count; i++) {
                lvwItem.SubItems[i].Name = lvwStockInfo.Columns[i].Name;
            }
                

            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                   //someControlOnForm1.Text = form3.TheCount;
                }
            }
        }
        private void sell(string how)
        {
            lvwStockInfo.FocusedItem.SubItems[5].Text = (int.Parse(lvwStockInfo.FocusedItem.SubItems[5].Text) - int.Parse(how)).ToString();
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            if (lvwStockInfo.FocusedItem == null) return;
            
            //생각해보니 다 안팔수도 있어서 remove가 아니라 소유 개수만 줄여야 할수있음.
            using (Form3 form3 = new Form3())
            {
                form3.ChildFormEvent += sell;
                form3.ShowDialog();
                form3.Owner = this;
            }
        }
    }
}
