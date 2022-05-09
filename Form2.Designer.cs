
namespace StockProgram
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvwStockInfo = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblNowMoney = new System.Windows.Forms.Label();
            this.btnMoneyAdd = new System.Windows.Forms.Button();
            this.btnMoneySub = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(549, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lvwStockInfo
            // 
            this.lvwStockInfo.HideSelection = false;
            this.lvwStockInfo.Location = new System.Drawing.Point(68, 67);
            this.lvwStockInfo.Name = "lvwStockInfo";
            this.lvwStockInfo.Size = new System.Drawing.Size(423, 149);
            this.lvwStockInfo.TabIndex = 1;
            this.lvwStockInfo.UseCompatibleStateImageBehavior = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(68, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(423, 21);
            this.txtSearch.TabIndex = 2;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(549, 67);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "구매";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(549, 109);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "판매";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(549, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblNowMoney
            // 
            this.lblNowMoney.AutoSize = true;
            this.lblNowMoney.Location = new System.Drawing.Point(682, 345);
            this.lblNowMoney.Name = "lblNowMoney";
            this.lblNowMoney.Size = new System.Drawing.Size(11, 12);
            this.lblNowMoney.TabIndex = 6;
            this.lblNowMoney.Text = "0";
            // 
            // btnMoneyAdd
            // 
            this.btnMoneyAdd.Location = new System.Drawing.Point(662, 231);
            this.btnMoneyAdd.Name = "btnMoneyAdd";
            this.btnMoneyAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMoneyAdd.TabIndex = 7;
            this.btnMoneyAdd.Text = "증가";
            this.btnMoneyAdd.UseVisualStyleBackColor = true;
            this.btnMoneyAdd.Click += new System.EventHandler(this.btnMoneyAdd_Click);
            // 
            // btnMoneySub
            // 
            this.btnMoneySub.Location = new System.Drawing.Point(662, 271);
            this.btnMoneySub.Name = "btnMoneySub";
            this.btnMoneySub.Size = new System.Drawing.Size(75, 23);
            this.btnMoneySub.TabIndex = 8;
            this.btnMoneySub.Text = "감소";
            this.btnMoneySub.UseVisualStyleBackColor = true;
            this.btnMoneySub.Click += new System.EventHandler(this.btnMoneySub_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(549, 253);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 21);
            this.txtInput.TabIndex = 9;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(570, 345);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 12);
            this.label.TabIndex = 10;
            this.label.Text = "현재자산";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnMoneySub);
            this.Controls.Add(this.btnMoneyAdd);
            this.Controls.Add(this.lblNowMoney);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvwStockInfo);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvwStockInfo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblNowMoney;
        private System.Windows.Forms.Button btnMoneyAdd;
        private System.Windows.Forms.Button btnMoneySub;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label;
    }
}