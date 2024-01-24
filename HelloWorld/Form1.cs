using NModbus;
using NModbus.Serial;
using Sunny.UI;
using System.IO.Ports;
using System.Text.RegularExpressions;


namespace ModbusDemo
{
    public partial class Form1 : Form
    {
        private string? _serialPortName;
        private SerialPort? _serialPort;
        private Int32 _baudRate;
        private Int32 _dataBits;
        private Parity _parity;
        private StopBits _stopBits;
        private byte _addr;
        private ushort _startAddr;
        private ushort _langth;
        IModbusMaster? _master;
        public Form1()
        {
            InitializeComponent();

            SetDefaultText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaudComboBox.SelectedIndex = 3;
            ParityComboBox.SelectedIndex = 0;
            DataBitsComboBox.SelectedIndex = 1;
            StopBitsComboBox.SelectedIndex = 0;
        }
        private void SetDefaultText()
        {
            AddrTextBox.Text = "站地址";
            AddrTextBox.ForeColor = Color.Gray;
            StartAddrTextBox.Text = "起始地址";
            StartAddrTextBox.ForeColor = Color.Gray;
            LangthTextBox.Text = "长度";
            LangthTextBox.ForeColor = Color.Gray;
        }

        private void AddrTextBox_Leave(object sender, EventArgs e)
        {
            if (AddrTextBox.Text == "")
            {
                AddrTextBox.Text = "站地址";
            }
        }

        private void AddrTextBox_Enter(object sender, EventArgs e)
        {
            if (AddrTextBox.Text == "站地址")
            {
                AddrTextBox.Text = "";
            }
        }

        private void StartAddrTextBox_Leave(object sender, EventArgs e)
        {
            if (StartAddrTextBox.Text == "")
            {
                StartAddrTextBox.Text = "起始地址";
            }
        }

        private void StartAddrTextBox_Enter(object sender, EventArgs e)
        {
            if (StartAddrTextBox.Text == "起始地址")
            {
                StartAddrTextBox.Text = "";
            }
        }

        private void LangthTextBox_Leave(object sender, EventArgs e)
        {
            if (LangthTextBox.Text == "")
            {
                LangthTextBox.Text = "长度";
            }
        }

        private void LangthTextBox_Enter(object sender, EventArgs e)
        {
            if (LangthTextBox.Text == "长度")
            {
                LangthTextBox.Text = "";
            }
        }

        static int ExtractExceptionCode(string exceptionMessage)
        {
            string pattern = @"Exception Code: (\d+)";
            Match match = Regex.Match(exceptionMessage, pattern);

            if (match.Success)
            {
                string exceptionCodeValue = match.Groups[1].Value;
                return int.Parse(exceptionCodeValue);
            }
            else
            {
                // Return -1 or any other value to indicate that the Exception Code was not found
                return -1;
            }
        }
        private void HandleModbusException(string Exception)
        {
            int exceptionCode = ExtractExceptionCode(Exception);

            switch (exceptionCode)
            {
                case 1:
                    ShowErrorDialog("非法功能");
                    break;
                case 2:
                    ShowErrorDialog("非法数据地址");
                    break;
                case 3:
                    ShowErrorDialog("非法数据值");
                    break;
                case 4:
                    ShowErrorDialog("从站设备故障");
                    break;
                case 5:
                    ShowErrorDialog("确认");
                    break;
                case 6:
                    ShowErrorDialog("从属设备忙");
                    break;
                case 8:
                    ShowErrorDialog("存储奇偶性差错");
                    break;
                case 10:
                    ShowErrorDialog("不可用网关路径");
                    break;
                case 11:
                    ShowErrorDialog("网关目标设备响应失败");
                    break;
                // Add more cases for other exception codes as needed
                default:
                    ShowErrorDialog(Exception);
                    break;
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort = new SerialPort()
                {
                    PortName = _serialPortName,
                    BaudRate = _baudRate,
                    DataBits = _dataBits,
                    Parity = _parity,
                    StopBits = _stopBits,
                    ReadTimeout = 1000,
                    WriteTimeout = 1000
                };

                _serialPort.Open();

                var factory = new ModbusFactory();
                _master = factory.CreateRtuMaster(_serialPort);

                LedConnected.Color = Color.LawnGreen;
            }
            catch (Exception exception)
            {
                LedConnected.Color = Color.LightGray;
                MessageBox.Show(exception.Message);
            }
        }

        private void ReadAndWrite_Click(object sender, EventArgs e)
        {
            int addr = int.Parse(AddrTextBox.Text);
            int startAddr = int.Parse(StartAddrTextBox.Text);
            int langth = int.Parse(LangthTextBox.Text);
            _addr = (byte)addr;
            _startAddr = (ushort)startAddr;
            _langth = (ushort)langth;
            if (_master == null)
            {
                ShowSuccessDialog("从站为空");
            }
            else
            {
                if (FuncCode.Text == "03")
                {
                    try
                    {
                        var readData = _master.ReadHoldingRegisters(_addr, _startAddr, _langth);
                        // bool[] ת string
                        // string coilDataString = string.Join(", ", readData.Select(b => b.ToString()));
                        string result = string.Join(", ", readData);
                        uiRichTextBox1.Text = result;
                    }
                    catch (Exception exception)
                    {
                        HandleModbusException(exception.Message);
                    }
                }
                if (FuncCode.Text == "04")
                {
                    try
                    {
                        var readData = _master.ReadInputRegisters(_addr, _startAddr, _langth);
                        // bool[] ת string
                        // string coilDataString = string.Join(", ", readData.Select(b => b.ToString()));
                        string result = string.Join(", ", readData);
                        uiRichTextBox1.Text = result;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (_serialPort == null)
            {
                ShowSuccessDialog("串口为空");
            }
            else
            {
                LedConnected.Color = Color.LightGray;
                _serialPort.Close();
            }
        }

        private void SerialportComboBox_Load(object sender, EventArgs e)
        {
            SerialportComboBox.Items.Clear();

            string[] ArryPort = SerialPort.GetPortNames();

            for (int i = 0; i < ArryPort.Length; i++)
            {
                SerialportComboBox.Items.Add(ArryPort[i]);
            }
        }

        private void SerialportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serialPortName = SerialportComboBox.Text;
        }

        private void BaudComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _baudRate = BaudComboBox.SelectedItem.ToString() switch
            {
                "波特率：4800" => 4800,
                "波特率：9600" => 9600,
                "波特率：19200" => 19200,
                "波特率：115200" => 115200,
                _ => 115200,
            };
        }

        private void DataBitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dataBits = DataBitsComboBox.SelectedItem.ToString() switch
            {
                "数据位：8 Data Bit" => 8,
                "数据位：7 Data Bit" => 7,
                _ => 8,
            };
        }

        private void ParityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parity = ParityComboBox.SelectedItem.ToString() switch
            {
                "无校验" => Parity.None,
                "奇校验" => Parity.Even,
                "偶校验" => Parity.Odd,
                _ => Parity.None,
            };
        }

        private void StopBitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _stopBits = ParityComboBox.SelectedItem.ToString() switch
            {
                "停止位：1 Stop Bit" => StopBits.One,
                "停止位：2 Stop Bit" => StopBits.Two,
                _ => StopBits.Two,
            };
        }

        public static void ShowSuccessDialog(string msg, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, UILocalize.SuccessTitle, showCancelButton: false, UIStyle.Green, showMask);
        }

        public static void ShowInfoDialog(string msg, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, UILocalize.InfoTitle, showCancelButton: false, UIStyle.Gray, showMask);
        }

        public static void ShowWarningDialog(string msg, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, UILocalize.WarningTitle, showCancelButton: false, UIStyle.Orange, showMask);
        }

        public static void ShowErrorDialog(string msg, bool showMask = false)
        {
            UIMessageDialog.ShowMessageDialog(msg, UILocalize.ErrorTitle, showCancelButton: false, UIStyle.Red, showMask);
        }
    }
}
