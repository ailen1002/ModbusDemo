using System.Net.Security;

namespace ModbusDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiLine1 = new Sunny.UI.UILine();
            uiLine2 = new Sunny.UI.UILine();
            uiLine3 = new Sunny.UI.UILine();
            uiLine4 = new Sunny.UI.UILine();
            uiLine5 = new Sunny.UI.UILine();
            uiLine6 = new Sunny.UI.UILine();
            uiLine7 = new Sunny.UI.UILine();
            uiLine8 = new Sunny.UI.UILine();
            SerialportComboBox = new Sunny.UI.UIComboBox();
            BaudComboBox = new Sunny.UI.UIComboBox();
            ParityComboBox = new Sunny.UI.UIComboBox();
            DataBitsComboBox = new Sunny.UI.UIComboBox();
            StopBitsComboBox = new Sunny.UI.UIComboBox();
            FuncCode = new Sunny.UI.UIComboBox();
            uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            AddrTextBox = new Sunny.UI.UITextBox();
            StartAddrTextBox = new Sunny.UI.UITextBox();
            LangthTextBox = new Sunny.UI.UITextBox();
            ReadAndWrite = new Sunny.UI.UIButton();
            LedConnected = new Sunny.UI.UILedBulb();
            BtnOpen = new Sunny.UI.UIButton();
            BtnClose = new Sunny.UI.UIButton();
            SlaveIDLabel = new Sunny.UI.UILabel();
            AddrLabel = new Sunny.UI.UILabel();
            QuantityLabel = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine1.Location = new Point(30, 30);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(969, 30);
            uiLine1.TabIndex = 0;
            uiLine1.Text = "串口设置";
            uiLine1.TextAlign = ContentAlignment.MiddleLeft;
            uiLine1.TextInterval = 40;
            // 
            // uiLine2
            // 
            uiLine2.BackColor = Color.Transparent;
            uiLine2.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            uiLine2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine2.Location = new Point(30, 46);
            uiLine2.MinimumSize = new Size(1, 1);
            uiLine2.Name = "uiLine2";
            uiLine2.Size = new Size(1, 107);
            uiLine2.TabIndex = 1;
            // 
            // uiLine3
            // 
            uiLine3.BackColor = Color.Transparent;
            uiLine3.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            uiLine3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine3.Location = new Point(998, 46);
            uiLine3.MinimumSize = new Size(1, 1);
            uiLine3.Name = "uiLine3";
            uiLine3.Size = new Size(1, 107);
            uiLine3.TabIndex = 2;
            // 
            // uiLine4
            // 
            uiLine4.BackColor = Color.Transparent;
            uiLine4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine4.Location = new Point(30, 152);
            uiLine4.MinimumSize = new Size(1, 1);
            uiLine4.Name = "uiLine4";
            uiLine4.Size = new Size(969, 1);
            uiLine4.TabIndex = 3;
            // 
            // uiLine5
            // 
            uiLine5.BackColor = Color.Transparent;
            uiLine5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine5.Location = new Point(30, 728);
            uiLine5.MinimumSize = new Size(1, 1);
            uiLine5.Name = "uiLine5";
            uiLine5.Size = new Size(969, 1);
            uiLine5.TabIndex = 7;
            // 
            // uiLine6
            // 
            uiLine6.BackColor = Color.Transparent;
            uiLine6.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            uiLine6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine6.Location = new Point(998, 249);
            uiLine6.MinimumSize = new Size(1, 1);
            uiLine6.Name = "uiLine6";
            uiLine6.Size = new Size(1, 480);
            uiLine6.TabIndex = 6;
            // 
            // uiLine7
            // 
            uiLine7.BackColor = Color.Transparent;
            uiLine7.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            uiLine7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine7.Location = new Point(30, 249);
            uiLine7.MinimumSize = new Size(1, 1);
            uiLine7.Name = "uiLine7";
            uiLine7.Size = new Size(1, 480);
            uiLine7.TabIndex = 5;
            // 
            // uiLine8
            // 
            uiLine8.BackColor = Color.Transparent;
            uiLine8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine8.Location = new Point(30, 233);
            uiLine8.MinimumSize = new Size(1, 1);
            uiLine8.Name = "uiLine8";
            uiLine8.Size = new Size(969, 30);
            uiLine8.TabIndex = 4;
            uiLine8.Text = "数据窗口";
            uiLine8.TextAlign = ContentAlignment.MiddleLeft;
            uiLine8.TextInterval = 40;
            // 
            // SerialportComboBox
            // 
            SerialportComboBox.DataSource = null;
            SerialportComboBox.FillColor = Color.White;
            SerialportComboBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            SerialportComboBox.ItemHoverColor = Color.FromArgb(155, 200, 255);
            SerialportComboBox.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            SerialportComboBox.Location = new Point(71, 84);
            SerialportComboBox.Margin = new Padding(4, 5, 4, 5);
            SerialportComboBox.MinimumSize = new Size(63, 0);
            SerialportComboBox.Name = "SerialportComboBox";
            SerialportComboBox.Padding = new Padding(0, 0, 30, 2);
            SerialportComboBox.Size = new Size(150, 29);
            SerialportComboBox.TabIndex = 8;
            SerialportComboBox.Text = "串口号";
            SerialportComboBox.TextAlignment = ContentAlignment.MiddleLeft;
            SerialportComboBox.Watermark = "";
            SerialportComboBox.SelectedIndexChanged += SerialportComboBox_SelectedIndexChanged;
            SerialportComboBox.Load += SerialportComboBox_Load;
            // 
            // BaudComboBox
            // 
            BaudComboBox.DataSource = null;
            BaudComboBox.FillColor = Color.White;
            BaudComboBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BaudComboBox.ItemHoverColor = Color.FromArgb(155, 200, 255);
            BaudComboBox.Items.AddRange(new object[] { "波特率：4800", "波特率：9600", "波特率：19200", "波特率：115200" });
            BaudComboBox.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            BaudComboBox.Location = new Point(254, 84);
            BaudComboBox.Margin = new Padding(4, 5, 4, 5);
            BaudComboBox.MinimumSize = new Size(63, 0);
            BaudComboBox.Name = "BaudComboBox";
            BaudComboBox.Padding = new Padding(0, 0, 30, 2);
            BaudComboBox.Size = new Size(150, 29);
            BaudComboBox.TabIndex = 9;
            BaudComboBox.Text = "波特率";
            BaudComboBox.TextAlignment = ContentAlignment.MiddleLeft;
            BaudComboBox.Watermark = "";
            BaudComboBox.SelectedIndexChanged += BaudComboBox_SelectedIndexChanged;
            // 
            // ParityComboBox
            // 
            ParityComboBox.DataSource = null;
            ParityComboBox.FillColor = Color.White;
            ParityComboBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ParityComboBox.ItemHoverColor = Color.FromArgb(155, 200, 255);
            ParityComboBox.Items.AddRange(new object[] { "无校验", "偶校验", "奇校验", "" });
            ParityComboBox.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            ParityComboBox.Location = new Point(437, 84);
            ParityComboBox.Margin = new Padding(4, 5, 4, 5);
            ParityComboBox.MinimumSize = new Size(63, 0);
            ParityComboBox.Name = "ParityComboBox";
            ParityComboBox.Padding = new Padding(0, 0, 30, 2);
            ParityComboBox.Size = new Size(150, 29);
            ParityComboBox.TabIndex = 10;
            ParityComboBox.Text = "奇偶校验";
            ParityComboBox.TextAlignment = ContentAlignment.MiddleLeft;
            ParityComboBox.Watermark = "";
            ParityComboBox.SelectedIndexChanged += ParityComboBox_SelectedIndexChanged;
            // 
            // DataBitsComboBox
            // 
            DataBitsComboBox.DataSource = null;
            DataBitsComboBox.FillColor = Color.White;
            DataBitsComboBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            DataBitsComboBox.ItemHoverColor = Color.FromArgb(155, 200, 255);
            DataBitsComboBox.Items.AddRange(new object[] { "数据位：7 Data Bit", "数据位：8 Data Bit" });
            DataBitsComboBox.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            DataBitsComboBox.Location = new Point(620, 84);
            DataBitsComboBox.Margin = new Padding(4, 5, 4, 5);
            DataBitsComboBox.MinimumSize = new Size(63, 0);
            DataBitsComboBox.Name = "DataBitsComboBox";
            DataBitsComboBox.Padding = new Padding(0, 0, 30, 2);
            DataBitsComboBox.Size = new Size(150, 29);
            DataBitsComboBox.TabIndex = 11;
            DataBitsComboBox.Text = "数据位";
            DataBitsComboBox.TextAlignment = ContentAlignment.MiddleLeft;
            DataBitsComboBox.Watermark = "";
            DataBitsComboBox.SelectedIndexChanged += DataBitsComboBox_SelectedIndexChanged;
            // 
            // StopBitsComboBox
            // 
            StopBitsComboBox.DataSource = null;
            StopBitsComboBox.FillColor = Color.White;
            StopBitsComboBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            StopBitsComboBox.ItemHoverColor = Color.FromArgb(155, 200, 255);
            StopBitsComboBox.Items.AddRange(new object[] { "停止位：1 Stop Bit", "停止位：2 Stop Bit" });
            StopBitsComboBox.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            StopBitsComboBox.Location = new Point(803, 84);
            StopBitsComboBox.Margin = new Padding(4, 5, 4, 5);
            StopBitsComboBox.MinimumSize = new Size(63, 0);
            StopBitsComboBox.Name = "StopBitsComboBox";
            StopBitsComboBox.Padding = new Padding(0, 0, 30, 2);
            StopBitsComboBox.Size = new Size(150, 29);
            StopBitsComboBox.TabIndex = 12;
            StopBitsComboBox.Text = "停止位";
            StopBitsComboBox.TextAlignment = ContentAlignment.MiddleLeft;
            StopBitsComboBox.Watermark = "";
            StopBitsComboBox.SelectedIndexChanged += StopBitsComboBox_SelectedIndexChanged;
            // 
            // FuncCode
            // 
            FuncCode.DataSource = null;
            FuncCode.FillColor = Color.White;
            FuncCode.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            FuncCode.ItemHoverColor = Color.FromArgb(155, 200, 255);
            FuncCode.Items.AddRange(new object[] { "03", "04" });
            FuncCode.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            FuncCode.Location = new Point(71, 298);
            FuncCode.Margin = new Padding(4, 5, 4, 5);
            FuncCode.MinimumSize = new Size(63, 0);
            FuncCode.Name = "FuncCode";
            FuncCode.Padding = new Padding(0, 0, 30, 2);
            FuncCode.Size = new Size(150, 29);
            FuncCode.TabIndex = 9;
            FuncCode.Text = "功能码";
            FuncCode.TextAlignment = ContentAlignment.MiddleLeft;
            FuncCode.Watermark = "";
            // 
            // uiRichTextBox1
            // 
            uiRichTextBox1.FillColor = Color.White;
            uiRichTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRichTextBox1.Location = new Point(71, 349);
            uiRichTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiRichTextBox1.MinimumSize = new Size(1, 1);
            uiRichTextBox1.Name = "uiRichTextBox1";
            uiRichTextBox1.Padding = new Padding(2);
            uiRichTextBox1.ScrollBarStyleInherited = false;
            uiRichTextBox1.ShowText = false;
            uiRichTextBox1.Size = new Size(882, 344);
            uiRichTextBox1.TabIndex = 13;
            uiRichTextBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // AddrTextBox
            // 
            AddrTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AddrTextBox.Location = new Point(315, 298);
            AddrTextBox.Margin = new Padding(4, 5, 4, 5);
            AddrTextBox.MinimumSize = new Size(1, 16);
            AddrTextBox.Name = "AddrTextBox";
            AddrTextBox.Padding = new Padding(5);
            AddrTextBox.ShowText = false;
            AddrTextBox.Size = new Size(89, 29);
            AddrTextBox.TabIndex = 14;
            AddrTextBox.TagString = "";
            AddrTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            AddrTextBox.Watermark = "";
            AddrTextBox.Leave += AddrTextBox_Leave;
            AddrTextBox.Enter += AddrTextBox_Enter;
            // 
            // StartAddrTextBox
            // 
            StartAddrTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            StartAddrTextBox.Location = new Point(500, 298);
            StartAddrTextBox.Margin = new Padding(4, 5, 4, 5);
            StartAddrTextBox.MinimumSize = new Size(1, 16);
            StartAddrTextBox.Name = "StartAddrTextBox";
            StartAddrTextBox.Padding = new Padding(5);
            StartAddrTextBox.ShowText = false;
            StartAddrTextBox.Size = new Size(87, 29);
            StartAddrTextBox.TabIndex = 15;
            StartAddrTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            StartAddrTextBox.Watermark = "";
            StartAddrTextBox.Leave += StartAddrTextBox_Leave;
            StartAddrTextBox.Enter += StartAddrTextBox_Enter;
            // 
            // LangthTextBox
            // 
            LangthTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LangthTextBox.Location = new Point(686, 298);
            LangthTextBox.Margin = new Padding(4, 5, 4, 5);
            LangthTextBox.MinimumSize = new Size(1, 16);
            LangthTextBox.Name = "LangthTextBox";
            LangthTextBox.Padding = new Padding(5);
            LangthTextBox.ShowText = false;
            LangthTextBox.Size = new Size(84, 29);
            LangthTextBox.TabIndex = 16;
            LangthTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            LangthTextBox.Watermark = "";
            LangthTextBox.Leave += LangthTextBox_Leave;
            LangthTextBox.Enter += LangthTextBox_Enter;
            // 
            // ReadAndWrite
            // 
            ReadAndWrite.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ReadAndWrite.Location = new Point(803, 298);
            ReadAndWrite.MinimumSize = new Size(1, 1);
            ReadAndWrite.Name = "ReadAndWrite";
            ReadAndWrite.Size = new Size(150, 29);
            ReadAndWrite.TabIndex = 17;
            ReadAndWrite.Text = "操作";
            ReadAndWrite.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ReadAndWrite.Click += ReadAndWrite_Click;
            // 
            // LedConnected
            // 
            LedConnected.Color = Color.LightGray;
            LedConnected.Location = new Point(555, 185);
            LedConnected.Name = "LedConnected";
            LedConnected.Size = new Size(32, 32);
            LedConnected.TabIndex = 18;
            LedConnected.Text = "uiLedBulb1";
            // 
            // BtnOpen
            // 
            BtnOpen.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnOpen.Location = new Point(620, 185);
            BtnOpen.MinimumSize = new Size(1, 1);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(150, 29);
            BtnOpen.TabIndex = 19;
            BtnOpen.Text = "连接";
            BtnOpen.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnOpen.Click += BtnOpen_Click;
            // 
            // BtnClose
            // 
            BtnClose.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnClose.Location = new Point(803, 185);
            BtnClose.MinimumSize = new Size(1, 1);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(150, 29);
            BtnClose.TabIndex = 20;
            BtnClose.Text = "关闭";
            BtnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnClose.Click += BtnClose_Click;
            // 
            // SlaveIDLabel
            // 
            SlaveIDLabel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            SlaveIDLabel.ForeColor = Color.FromArgb(48, 48, 48);
            SlaveIDLabel.Location = new Point(228, 298);
            SlaveIDLabel.Name = "SlaveIDLabel";
            SlaveIDLabel.Size = new Size(80, 23);
            SlaveIDLabel.TabIndex = 21;
            SlaveIDLabel.Text = "Slave ID:";
            SlaveIDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddrLabel
            // 
            AddrLabel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AddrLabel.ForeColor = Color.FromArgb(48, 48, 48);
            AddrLabel.Location = new Point(412, 298);
            AddrLabel.Name = "AddrLabel";
            AddrLabel.Size = new Size(81, 23);
            AddrLabel.TabIndex = 22;
            AddrLabel.Text = "Address:";
            AddrLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // QuantityLabel
            // 
            QuantityLabel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            QuantityLabel.ForeColor = Color.FromArgb(48, 48, 48);
            QuantityLabel.Location = new Point(594, 298);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(85, 23);
            QuantityLabel.TabIndex = 23;
            QuantityLabel.Text = "Quantity:";
            QuantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(QuantityLabel);
            Controls.Add(AddrLabel);
            Controls.Add(SlaveIDLabel);
            Controls.Add(BtnClose);
            Controls.Add(BtnOpen);
            Controls.Add(LedConnected);
            Controls.Add(ReadAndWrite);
            Controls.Add(LangthTextBox);
            Controls.Add(StartAddrTextBox);
            Controls.Add(AddrTextBox);
            Controls.Add(uiRichTextBox1);
            Controls.Add(FuncCode);
            Controls.Add(StopBitsComboBox);
            Controls.Add(DataBitsComboBox);
            Controls.Add(ParityComboBox);
            Controls.Add(BaudComboBox);
            Controls.Add(SerialportComboBox);
            Controls.Add(uiLine5);
            Controls.Add(uiLine6);
            Controls.Add(uiLine7);
            Controls.Add(uiLine8);
            Controls.Add(uiLine4);
            Controls.Add(uiLine3);
            Controls.Add(uiLine2);
            Controls.Add(uiLine1);
            Name = "Form1";
            Text = "ModbusDemo程序";
            Load += Form1_Load;
            ResumeLayout(false);
        }
        #endregion

        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UILine uiLine4;
        private Sunny.UI.UILine uiLine5;
        private Sunny.UI.UILine uiLine6;
        private Sunny.UI.UILine uiLine7;
        private Sunny.UI.UILine uiLine8;
        private Sunny.UI.UIComboBox SerialportComboBox;
        private Sunny.UI.UIComboBox BaudComboBox;
        private Sunny.UI.UIComboBox ParityComboBox;
        private Sunny.UI.UIComboBox DataBitsComboBox;
        private Sunny.UI.UIComboBox StopBitsComboBox;
        private Sunny.UI.UIComboBox FuncCode;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UITextBox AddrTextBox;
        private Sunny.UI.UITextBox StartAddrTextBox;
        private Sunny.UI.UITextBox LangthTextBox;
        private Sunny.UI.UIButton ReadAndWrite;
        private Sunny.UI.UILedBulb LedConnected;
        private Sunny.UI.UIButton BtnOpen;
        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UILabel SlaveIDLabel;
        private Sunny.UI.UILabel AddrLabel;
        private Sunny.UI.UILabel QuantityLabel;
    }
}
