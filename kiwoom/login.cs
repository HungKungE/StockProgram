using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiwoom {
    public partial class login : Form {
        List<unbuy> unbuyList;
        List<balance> balanceList;
        public login() {
            InitializeComponent();
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData; // 계좌 잔고 불러오는 함수
        }
        //로그인 버튼
        public void btnLogin_Click(object sender, EventArgs e) {
            axKHOpenAPI1.CommConnect(); // 로그인 서버 연결
            axKHOpenAPI1.OnEventConnect += OnEventConnect; // 로그인 후 사용자의 접속 정보 가져오기
        }
        public void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e) {

            if (e.nErrCode == 0) // 값이 0이면 정상적으로 로그인됨
            {

                string AccList = axKHOpenAPI1.GetLoginInfo("ACCLIST").Trim();
                string[] userAccount = AccList.Split(';');

                for (int i = 0; i < userAccount.Length; i++) {
                    // 계좌번호 comboBox에 계좌 목록 추가
                    cmbAccount.Items.Add(userAccount[i]);

                }
                // 사용자 이름 표시
                string userName = axKHOpenAPI1.GetLoginInfo("USER_NAME");
                usrName.Text = userName;

                // 사용자 아이디 표시
                string userId = axKHOpenAPI1.GetLoginInfo("USER_ID");
                usrID.Text = userId;

                // 접속 서버 표시 (모의투자서버 or 실거래서버)
                string serv = axKHOpenAPI1.GetLoginInfo("GetServerGubun");
                getServer.Text = serv;

                // 종목 조회
                string codeList = axKHOpenAPI1.GetCodeListByMarket("0"); // 전체 시장 조회 가능
                string[] codes = codeList.Split(';');

                for (int i = 0; i < codes.Length; i++) {
                    dgvItem.Rows.Add();
                    dgvItem["종목조회_종목코드", i].Value = codes[i];
                    dgvItem["종목조회_종목명", i].Value = axKHOpenAPI1.GetMasterCodeName(codes[i]);
                }

                cmbSep.Items.Add("00:지정가".ToString());
                cmbSep.Items.Add("03:시장가".ToString());

                



            }

        }
        // 계좌정보조회 버튼
        public void btnAccCheck_Click(object sender, EventArgs e) {
            // 계좌 정보 조회
            string account = cmbAccount.Text;
            axKHOpenAPI1.SetInputValue("계좌번호", account);
            axKHOpenAPI1.SetInputValue("비밀번호", "0000");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "2");

            axKHOpenAPI1.CommRqData("계좌잔고평가내역", "opw00018", 0, "5000");
        }
        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e) {
            // 계좌 잔고 불러오기
            if (e.sRQName == "계좌잔고평가내역") {
                int buy = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액"));
                int deposit = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "추정예탁자산"));
                int val = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가금액"));
                int profit = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가손익금액"));

                labDeposit.Text = String.Format("{0:#,###}", deposit);
                labBuy.Text = buy.ToString();
                labValuation.Text = val.ToString();
                labProfit.Text = profit.ToString();

                int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                dgvAcc.Rows.Clear();
                for (int i = 0; i < count; i++) {
                    string code = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목번호").TrimStart('0');
                    string name = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    int num = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량"));
                    int buys = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입가"));
                    int price = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가"));
                    int profits = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평가손익"));
                    int percentage = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "수익률(%)"));

                    balance stockBalance = new balance(code, name, num, buys, price, profits, percentage);
                    balanceList.Add(stockBalance);
                }

                dgvAcc.DataSource = balanceList;

            }
            else if (e.sRQName.Equals("실시간미체결요청")) {
                int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                dgvUn.Rows.Clear();
                for (int i = 0; i < 10; i++) {
                    try {
                        string orderNumber = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문번호").Trim();
                        string code = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                        string name = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                        int orderNum = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문수량"));
                        int orderPrice = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문가격"));
                        int unorderNum = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "미체결수량"));
                        string sep = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문구분").Trim();
                        string time = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "시간").Trim();
                        int price = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가"));
                        unbuyList.Add(new unbuy(orderNumber,code,name,orderNum,orderPrice,unorderNum,sep,time,price));
                    }
                    catch (Exception exception) {
                        Console.WriteLine(exception.Message.ToString());
                    }
                }
                dgvUn.DataSource = unbuyList;
            }
            else if (e.sRQName == "종목정보요청") {
                string name = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                long price = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim().Substring(1));
                long dif = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim());
                long vol = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim());
                string percentage = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();

                //MessageBox.Show(dif.ToString());
                txtItemName.Text = name;
                txtcurPrice.Text = String.Format("{0:#,###}", price);
                txtdiff.Text = String.Format("{0:#,###}", dif);
                txtvolume.Text = String.Format("{0:#,###}", vol);
                txtpercent.Text = percentage;

                cmbAcc.Text = cmbAccount.Text;
                txtCode.Text = txtSearch.Text;
                priceUpDown.Value = price;

            }

        }
        // 종목조회 버튼
        public void btnSearch_Click(object sender, EventArgs e) {
            string code = txtSearch.Text;
            if (txtSearch.Text.Length > 0) {
                axKHOpenAPI1.SetInputValue("종목코드", code);
                axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");
            }
        }

        public void btnBuy_Click(object sender, EventArgs e) {
            if(priceUpDown.Value>0 && numUpDown.Value>0 && txtCode.Text.Length >0 && cmbAcc.Text.Length > 0) {
                string acc = cmbAcc.Text;
                string code = txtCode.Text;
                int num = int.Parse(numUpDown.Value.ToString());
                int price = int.Parse(priceUpDown.Value.ToString());
                string[] sepList = cmbSep.Text.Split(':');
                string sep = sepList[0];

                int result=axKHOpenAPI1.SendOrder("현금매수주문", "5001", acc, 1, code, num, price, sep, "");

                if (result == 0)
                    MessageBox.Show("주문성공");
            }
        }

        private void btnAccUn_Click(object sender, EventArgs e) {

            unbuyList = new List<unbuy>();
            balanceList = new List<balance>();
            
            string acc = cmbAccount.Text;

            axKHOpenAPI1.SetInputValue("계좌번호", acc);
            axKHOpenAPI1.SetInputValue("비밀번호", "0000");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "2");
            axKHOpenAPI1.CommRqData("계좌잔고평가내역", "opw00018", 0, "5003");
      
            axKHOpenAPI1.SetInputValue("계좌번호", acc);
            axKHOpenAPI1.SetInputValue("체결구분", "1");
            axKHOpenAPI1.SetInputValue("매매구분", "0");
            axKHOpenAPI1.CommRqData("실시간미체결요청", "opt10075", 0, "5002");
        }
    }
}
