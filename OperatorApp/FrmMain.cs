using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace OperatorApp
{
    public partial class frmMain : Form
    {
        SerialPort serialPort;
        MatchCollection regexResult;
        bool status_left = false;
        bool status_right = false;
        long time = 0;
        int counter = 0;
        int left_score = 0;
        int right_score = 0;
        int winner = 0;
        int phase = 0;

        public frmMain()
        {
            InitializeComponent();
            serialPort = new SerialPort
            {
                BaudRate = 115200,
                Parity = Parity.None,
                StopBits = StopBits.One
            };
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = ((SerialPort)sender).ReadLine();
            if (line == null) return;
            line.Trim();
            regexResult = Regex.Matches(line, "[STCLRWP]:[0-9]+");
            foreach (Match match in regexResult)
            {
                if (match.Success)
                {
                    switch (match.Value[0])
                    {
                        case 'S':
                            status_left = match.Value.Substring(2, 1) == "1" ? true : false;
                            status_right = match.Value.Substring(3, 1) == "1" ? true : false;
                            break;
                        case 'T':
                            time = long.Parse(match.Value.Substring(2));
                            break;
                        case 'C':
                            counter = int.Parse(match.Value.Substring(2));
                            break;
                        case 'L':
                            left_score = int.Parse(match.Value.Substring(2));
                            break;
                        case 'R':
                            right_score = int.Parse(match.Value.Substring(2));
                            break;
                        case 'W':
                            winner = int.Parse(match.Value.Substring(2));
                            break;
                        case 'P':
                            phase = int.Parse(match.Value.Substring(2));
                            break;
                        default:
                            break;
                    }
                }
                Invoke(new MethodInvoker(delegate ()
                {
                    txtSerial.Text = $"P:{phase}S:{(status_left ? 1 : 0)}{(status_right ? 1 : 0)}T:{time}C:{counter}L:{left_score}R:{right_score}W:{winner}\n";
                    showScore(1, left_score);
                    showScore(2, right_score);
                }));
                Invoke(new MethodInvoker(delegate ()
                {
                    if (phase == 0)
                    {
                        lblResult.Text = "Ready...";
                        winner = 0;
                        counter = 0;
                        lblTimer.Text = "";
                        showScore(1, 0);
                        showScore(2, 0);
                    }
                    else if (phase == 1)
                        lblResult.Text = counter > 0 ? counter.ToString() : "Ready...";
                    else if (phase == 2)
                    {
                        lblResult.Text = "GO";
                        lblTimer.Text = time.ToString();
                    }
                    else
                    {
                        lblTimer.Text = time.ToString();
                        if (winner == 1)
                            lblResult.Text = "RED WINS";
                        else if (winner == 2)
                            lblResult.Text = "BLUE WINS";
                        else if (winner == 3)
                            lblResult.Text = "DRAW";
                        else
                            lblResult.Text = "";
                    }
                    bannerLeft.BackColor = status_left && winner != 2 ? Color.Red : Color.Gray;
                    BannerLeft2.BackColor = status_left && winner != 2 ? Color.Red : Color.Gray;
                    BannerRight2.BackColor = status_right && winner != 1 ? Color.Blue : Color.Gray;
                    bannerRight.BackColor = status_right && winner != 1 ? Color.Blue : Color.Gray;
                }));
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            txtSerial.Clear();
            serialPort.Close();
            comboPorts.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())
            {
                comboPorts.Items.Add(item);
            }
            cmdOpen.Enabled = false;
        }

        private void comboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPorts.Items != null && (String)comboPorts.SelectedItem != "")
            {
                if (serialPort.IsOpen) serialPort.Close();
                serialPort.PortName = (string)comboPorts.SelectedItem;
                cmdOpen.Enabled = true;
            }
            else
                cmdOpen.Enabled = false;
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen) return;
            serialPort.Open();
            txtSerial.Text = "Connected to " + serialPort.PortName;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void showScore(int position, int score)
        {
            byte score2 = (byte)(score / 10);
            byte score1 = (byte)(score % 10);
            bool[] segments1 = numToBin(score1);
            bool[] segments2 = numToBin(score2);
            if (position == 1) //left
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    segmentL1A.BackColor = segments1[0] ? Color.Black : Color.Transparent;
                    segmentL1B.BackColor = segments1[1] ? Color.Black : Color.Transparent;
                    segmentL1C.BackColor = segments1[2] ? Color.Black : Color.Transparent;
                    segmentL1D.BackColor = segments1[3] ? Color.Black : Color.Transparent;
                    segmentL1E.BackColor = segments1[4] ? Color.Black : Color.Transparent;
                    segmentL1F.BackColor = segments1[5] ? Color.Black : Color.Transparent;
                    segmentL1G.BackColor = segments1[6] ? Color.Black : Color.Transparent;

                    segmentL2A.BackColor = segments2[0] ? Color.Black : Color.Transparent;
                    segmentL2B.BackColor = segments2[1] ? Color.Black : Color.Transparent;
                    segmentL2C.BackColor = segments2[2] ? Color.Black : Color.Transparent;
                    segmentL2D.BackColor = segments2[3] ? Color.Black : Color.Transparent;
                    segmentL2E.BackColor = segments2[4] ? Color.Black : Color.Transparent;
                    segmentL2F.BackColor = segments2[5] ? Color.Black : Color.Transparent;
                    segmentL2G.BackColor = segments2[6] ? Color.Black : Color.Transparent;
                }));
            }
            else if (position == 2) //right
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    segmentR1A.BackColor = segments1[0] ? Color.Black : Color.Transparent;
                    segmentR1B.BackColor = segments1[1] ? Color.Black : Color.Transparent;
                    segmentR1C.BackColor = segments1[2] ? Color.Black : Color.Transparent;
                    segmentR1D.BackColor = segments1[3] ? Color.Black : Color.Transparent;
                    segmentR1E.BackColor = segments1[4] ? Color.Black : Color.Transparent;
                    segmentR1F.BackColor = segments1[5] ? Color.Black : Color.Transparent;
                    segmentR1G.BackColor = segments1[6] ? Color.Black : Color.Transparent;

                    segmentR2A.BackColor = segments2[0] ? Color.Black : Color.Transparent;
                    segmentR2B.BackColor = segments2[1] ? Color.Black : Color.Transparent;
                    segmentR2C.BackColor = segments2[2] ? Color.Black : Color.Transparent;
                    segmentR2D.BackColor = segments2[3] ? Color.Black : Color.Transparent;
                    segmentR2E.BackColor = segments2[4] ? Color.Black : Color.Transparent;
                    segmentR2F.BackColor = segments2[5] ? Color.Black : Color.Transparent;
                    segmentR2G.BackColor = segments2[6] ? Color.Black : Color.Transparent;
                }));
            }
        }

        private bool[] numToBin(byte value)
        {
            bool In0, In1, In2, In3;
            In3 = (value & (1 << 3)) > 0;
            In2 = (value & (1 << 2)) > 0;
            In1 = (value & (1 << 1)) > 0;
            In0 = (value & (1 << 0)) > 0;
            bool[] segments = new bool[7];
            segments[0] = (!In2 && !In0) || (!In3 && In1) || (In2 && In1) || (In3 && !In0) || (!In3 && In2 && In0) || (In3 && !In2 && !In1);
            segments[1] = (!In2 && !In0) || (!In2 && !In1) || (!In3 && !In1 && !In0) || (In3 && !In1 && In0) || (!In3 && In1 && In0);
            segments[2] = (In3 && !In2) || (!In1 && In0) || (!In2 && !In1) || (!In3 && In0) || (!In3 && In2);
            segments[3] = (!In3 && !In2 && !In0) || (!In2 && In1 && In0) || (In2 && !In1 && In0) || (In3 && !In1) || (In2 && In1 && !In0);
            segments[4] = (!In2 && !In0) || (In3 && In2) || (In1 && !In0) || (In3 && In1);
            segments[5] = (!In1 && !In0) || (In3 && !In2) || (In2 && !In0) || (In3 && In1) || (!In3 && In2);
            segments[6] = (In3 && !In2) || (In1 && !In0) || (In3 && In0) || (!In3 && In2 && !In1) || (!In2 && In1);
            return segments;
        }
    }
}
