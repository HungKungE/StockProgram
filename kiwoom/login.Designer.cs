
namespace kiwoom
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usrName = new System.Windows.Forms.Label();
            this.usrID = new System.Windows.Forms.Label();
            this.getServer = new System.Windows.Forms.Label();
            this.btnAccCheck = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labProfit = new System.Windows.Forms.Label();
            this.labValuation = new System.Windows.Forms.Label();
            this.labBuy = new System.Windows.Forms.Label();
            this.labDeposit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.종목조회_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목조회_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtpercent = new System.Windows.Forms.Label();
            this.txtvolume = new System.Windows.Forms.Label();
            this.txtdiff = new System.Windows.Forms.Label();
            this.txtcurPrice = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.curPrice = new System.Windows.Forms.Label();
            this.diff = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cmbAcc = new System.Windows.Forms.ComboBox();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            this.cmbSep = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvUn = new System.Windows.Forms.DataGridView();
            this.btnAccUn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUn)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(688, 10);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(529, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmbAccount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.usrName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usrID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.getServer, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(103, 4);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(93, 20);
            this.cmbAccount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용자이름";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "계좌번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "접속서버";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrName
            // 
            this.usrName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrName.AutoSize = true;
            this.usrName.Location = new System.Drawing.Point(103, 25);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(93, 23);
            this.usrName.TabIndex = 5;
            this.usrName.Text = "label5";
            // 
            // usrID
            // 
            this.usrID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrID.AutoSize = true;
            this.usrID.Location = new System.Drawing.Point(103, 49);
            this.usrID.Name = "usrID";
            this.usrID.Size = new System.Drawing.Size(93, 23);
            this.usrID.TabIndex = 6;
            this.usrID.Text = "label6";
            // 
            // getServer
            // 
            this.getServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getServer.AutoSize = true;
            this.getServer.Location = new System.Drawing.Point(103, 73);
            this.getServer.Name = "getServer";
            this.getServer.Size = new System.Drawing.Size(93, 26);
            this.getServer.TabIndex = 7;
            this.getServer.Text = "label7";
            // 
            // btnAccCheck
            // 
            this.btnAccCheck.Location = new System.Drawing.Point(529, 49);
            this.btnAccCheck.Name = "btnAccCheck";
            this.btnAccCheck.Size = new System.Drawing.Size(97, 23);
            this.btnAccCheck.TabIndex = 4;
            this.btnAccCheck.Text = "계좌정보조회";
            this.btnAccCheck.UseVisualStyleBackColor = true;
            this.btnAccCheck.Click += new System.EventHandler(this.btnAccCheck_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labProfit, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labValuation, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labBuy, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labDeposit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 124);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // labProfit
            // 
            this.labProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labProfit.AutoSize = true;
            this.labProfit.BackColor = System.Drawing.Color.White;
            this.labProfit.Location = new System.Drawing.Point(145, 91);
            this.labProfit.Name = "labProfit";
            this.labProfit.Size = new System.Drawing.Size(135, 32);
            this.labProfit.TabIndex = 9;
            this.labProfit.Text = "0";
            this.labProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labValuation
            // 
            this.labValuation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labValuation.AutoSize = true;
            this.labValuation.BackColor = System.Drawing.Color.White;
            this.labValuation.Location = new System.Drawing.Point(145, 61);
            this.labValuation.Name = "labValuation";
            this.labValuation.Size = new System.Drawing.Size(135, 29);
            this.labValuation.TabIndex = 8;
            this.labValuation.Text = "0";
            this.labValuation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labBuy
            // 
            this.labBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labBuy.AutoSize = true;
            this.labBuy.BackColor = System.Drawing.Color.White;
            this.labBuy.Location = new System.Drawing.Point(145, 31);
            this.labBuy.Name = "labBuy";
            this.labBuy.Size = new System.Drawing.Size(135, 29);
            this.labBuy.TabIndex = 7;
            this.labBuy.Text = "0";
            this.labBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDeposit
            // 
            this.labDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDeposit.AutoSize = true;
            this.labDeposit.BackColor = System.Drawing.Color.White;
            this.labDeposit.Location = new System.Drawing.Point(145, 1);
            this.labDeposit.Name = "labDeposit";
            this.labDeposit.Size = new System.Drawing.Size(135, 29);
            this.labDeposit.TabIndex = 6;
            this.labDeposit.Text = "0";
            this.labDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "예수금";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "총매입금액";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "전체손익금액";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "총평가금액";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 118);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 27);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(103, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "종목조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(94, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목조회_종목코드,
            this.종목조회_종목명});
            this.dgvItem.Location = new System.Drawing.Point(12, 151);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowTemplate.Height = 23;
            this.dgvItem.Size = new System.Drawing.Size(206, 432);
            this.dgvItem.TabIndex = 7;
            // 
            // 종목조회_종목코드
            // 
            this.종목조회_종목코드.HeaderText = "종목코드";
            this.종목조회_종목코드.Name = "종목조회_종목코드";
            this.종목조회_종목코드.ReadOnly = true;
            // 
            // 종목조회_종목명
            // 
            this.종목조회_종목명.HeaderText = "종목명";
            this.종목조회_종목명.Name = "종목조회_종목명";
            this.종목조회_종목명.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtpercent, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtvolume, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtdiff, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtcurPrice, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtItemName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.itemName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.curPrice, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.diff, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.volume, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.percent, 0, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(224, 151);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // txtpercent
            // 
            this.txtpercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpercent.AutoSize = true;
            this.txtpercent.Location = new System.Drawing.Point(103, 77);
            this.txtpercent.Name = "txtpercent";
            this.txtpercent.Size = new System.Drawing.Size(93, 22);
            this.txtpercent.TabIndex = 9;
            this.txtpercent.Text = "label";
            this.txtpercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtvolume
            // 
            this.txtvolume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvolume.AutoSize = true;
            this.txtvolume.Location = new System.Drawing.Point(103, 58);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(93, 18);
            this.txtvolume.TabIndex = 8;
            this.txtvolume.Text = "label";
            this.txtvolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdiff
            // 
            this.txtdiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiff.AutoSize = true;
            this.txtdiff.Location = new System.Drawing.Point(103, 39);
            this.txtdiff.Name = "txtdiff";
            this.txtdiff.Size = new System.Drawing.Size(93, 18);
            this.txtdiff.TabIndex = 7;
            this.txtdiff.Text = "label";
            this.txtdiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcurPrice
            // 
            this.txtcurPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcurPrice.AutoSize = true;
            this.txtcurPrice.Location = new System.Drawing.Point(103, 20);
            this.txtcurPrice.Name = "txtcurPrice";
            this.txtcurPrice.Size = new System.Drawing.Size(93, 18);
            this.txtcurPrice.TabIndex = 6;
            this.txtcurPrice.Text = "label";
            this.txtcurPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.AutoSize = true;
            this.txtItemName.Location = new System.Drawing.Point(103, 1);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(93, 18);
            this.txtItemName.TabIndex = 5;
            this.txtItemName.Text = "label";
            this.txtItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemName
            // 
            this.itemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(4, 1);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(92, 18);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "종목이름";
            this.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curPrice
            // 
            this.curPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curPrice.AutoSize = true;
            this.curPrice.Location = new System.Drawing.Point(4, 20);
            this.curPrice.Name = "curPrice";
            this.curPrice.Size = new System.Drawing.Size(92, 18);
            this.curPrice.TabIndex = 1;
            this.curPrice.Text = "현재가";
            this.curPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diff
            // 
            this.diff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diff.AutoSize = true;
            this.diff.Location = new System.Drawing.Point(4, 39);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(92, 18);
            this.diff.TabIndex = 2;
            this.diff.Text = "전일대비";
            this.diff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.AutoSize = true;
            this.volume.Location = new System.Drawing.Point(4, 58);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(92, 18);
            this.volume.TabIndex = 3;
            this.volume.Text = "거래량";
            this.volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percent
            // 
            this.percent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(4, 77);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(92, 22);
            this.percent.TabIndex = 4;
            this.percent.Text = "등락율";
            this.percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.txtCode, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.cmbAcc, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.numUpDown, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.priceUpDown, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.cmbSep, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.btnBuy, 0, 5);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(224, 272);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 222);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "계좌번호";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 35);
            this.label10.TabIndex = 1;
            this.label10.Text = "종목코드";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 35);
            this.label11.TabIndex = 2;
            this.label11.Text = "수량";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 35);
            this.label12.TabIndex = 3;
            this.label12.Text = "가격";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 35);
            this.label13.TabIndex = 4;
            this.label13.Text = "거래구분";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(103, 40);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(93, 21);
            this.txtCode.TabIndex = 5;
            // 
            // cmbAcc
            // 
            this.cmbAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAcc.FormattingEnabled = true;
            this.cmbAcc.Location = new System.Drawing.Point(103, 4);
            this.cmbAcc.Name = "cmbAcc";
            this.cmbAcc.Size = new System.Drawing.Size(93, 20);
            this.cmbAcc.TabIndex = 6;
            // 
            // numUpDown
            // 
            this.numUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown.Location = new System.Drawing.Point(103, 76);
            this.numUpDown.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(93, 21);
            this.numUpDown.TabIndex = 7;
            // 
            // priceUpDown
            // 
            this.priceUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceUpDown.Location = new System.Drawing.Point(103, 112);
            this.priceUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.Size = new System.Drawing.Size(93, 21);
            this.priceUpDown.TabIndex = 8;
            // 
            // cmbSep
            // 
            this.cmbSep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSep.FormattingEnabled = true;
            this.cmbSep.Location = new System.Drawing.Point(103, 148);
            this.cmbSep.Name = "cmbSep";
            this.cmbSep.Size = new System.Drawing.Size(93, 20);
            this.cmbSep.TabIndex = 9;
            this.cmbSep.Text = "선택";
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.btnBuy, 2);
            this.btnBuy.Location = new System.Drawing.Point(4, 184);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(192, 34);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "현금매수";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(224, 496);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 100);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAcc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "잔고";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAcc
            // 
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcc.Location = new System.Drawing.Point(0, 0);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.RowTemplate.Height = 23;
            this.dgvAcc.Size = new System.Drawing.Size(716, 78);
            this.dgvAcc.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvUn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "미체결";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUn
            // 
            this.dgvUn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUn.Location = new System.Drawing.Point(0, 0);
            this.dgvUn.Name = "dgvUn";
            this.dgvUn.RowTemplate.Height = 23;
            this.dgvUn.Size = new System.Drawing.Size(716, 74);
            this.dgvUn.TabIndex = 0;
            // 
            // btnAccUn
            // 
            this.btnAccUn.BackColor = System.Drawing.Color.White;
            this.btnAccUn.Location = new System.Drawing.Point(430, 471);
            this.btnAccUn.Name = "btnAccUn";
            this.btnAccUn.Size = new System.Drawing.Size(102, 23);
            this.btnAccUn.TabIndex = 1;
            this.btnAccUn.Text = "잔고미체결조회";
            this.btnAccUn.UseVisualStyleBackColor = false;
            this.btnAccUn.Click += new System.EventHandler(this.btnAccUn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1099, 595);
            this.Controls.Add(this.btnAccUn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnAccCheck);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usrName;
        private System.Windows.Forms.Label usrID;
        private System.Windows.Forms.Label getServer;
        private System.Windows.Forms.Button btnAccCheck;
        protected System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labProfit;
        private System.Windows.Forms.Label labValuation;
        private System.Windows.Forms.Label labBuy;
        private System.Windows.Forms.Label labDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목조회_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목조회_종목명;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label txtpercent;
        private System.Windows.Forms.Label txtvolume;
        private System.Windows.Forms.Label txtdiff;
        private System.Windows.Forms.Label txtcurPrice;
        private System.Windows.Forms.Label txtItemName;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label curPrice;
        private System.Windows.Forms.Label diff;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cmbAcc;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.NumericUpDown priceUpDown;
        private System.Windows.Forms.ComboBox cmbSep;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAcc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvUn;
        private System.Windows.Forms.Button btnAccUn;
    }
}

