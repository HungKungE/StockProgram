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
            lvwStockInfo.Columns.Add("last", "last");

            lvwStockInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvwStockInfo.Columns.RemoveByKey("last");

            //lvwStockInfo.Columns[0].Text

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (/*어떻게 검색되는지 몰라서 문제*/false)
                MessageBox.Show("잘못된 종목명입니다.");

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (lvwStockInfo.FocusedItem == null) return;
            lvwStockInfo.FocusedItem.Remove();
        }
    }
}
