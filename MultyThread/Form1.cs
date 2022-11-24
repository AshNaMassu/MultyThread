using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MultyThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbLog.Clear();
            InitializationThreads();
        }

        private Task[] _tasks { get; set; } = new Task[3];
        private bool _isWork { get; set; } = false;
        private bool _isAlreadyStart { get; set; } = false;
        private bool _isWorkT0 = false;
        private bool _isWorkT1 = false;
        private bool _isWorkT2 = false;

        private int _delayT0;
        private int _delayT1;
        private int _delayT2;

        private bool _isInit { get; set; } = false;


        private void bTAll_Click(object sender, EventArgs e)
        {
            if (!_isAlreadyStart)
            {
                foreach (var t in _tasks)
                    t.Start();
                _isAlreadyStart = true;
            }

            WorkStatusUpdate();
        }

        public void InitializationThreads()
        {
            pbT0.Image = null; pbT1.Image = null; pbT2.Image = null;
            //rtbLog.Clear();
            try
            {
                _delayT0 = Convert.ToInt32(tbT0.Text);
                _delayT1 = Convert.ToInt32(tbT1.Text);
                _delayT2 = Convert.ToInt32(tbT2.Text);

                _tasks[0] = new Task(() => UpdateThread(0, pbT0, Color.Yellow, ref _delayT0, ref _isWorkT0)); //left ������������ ���������
                _tasks[1] = new Task(() => UpdateThread(1, pbT1, Color.Blue, ref _delayT1, ref _isWorkT1)); //right
                _tasks[2] = new Task(() => UpdateThread(2, pbT2, Color.Green, ref _delayT2, ref _isWorkT2)); //center
            }
            catch(Exception e)
            {
                AddToLog(e.Message);
                return;
            }
        }

        public void UpdateThread(int treadId, PictureBox threadPB, Color threadColor, ref int threadDelay, ref bool isWork)
        { // Form � RichTextBox ���������� ������ ���� ���������� ����� � IF'�, �� ��� �� ��������
            Bitmap bmp = new Bitmap(threadPB.Width, threadPB.Height); // ����� ����� ���� ������� picturebox ���������
            for (int y = 0; y < bmp.Height; y++) // ���������� �� ������
            {
                for (int x = 0; x < bmp.Width; x++) // �� ������
                {

                    while (!isWork)
                    {
                        Thread.Sleep(100);
                    } 

                    bmp.SetPixel(x, bmp.Height - y - 1, threadColor); // ������ ������� � ���������� �����������
                    
                    if (x % threadPB.Width == 0) // ��� ������� ��� ��������� ���������� ���������� picturebox � richtextbox
                    {
                        //lock (threadPB) //���������� �������
                        //{
                            SetNewImage(threadPB, bmp); // ��������� threadPB
                        //}

                        AddToLog($"����� {treadId}: ��������� ���� {threadColor.Name} � {y} ������ ��������)"); ;

                        //form.Update(); // �� ����
                        Thread.Sleep(threadDelay); // �� ���� ����� ��������� ��� ����� �������
                    }
                }
            }
            SetNewImage(threadPB, bmp); // ��������� threadPB ���� ���������
        }


        public delegate void UpdateRichTextBoxDelegate(string logValue);

        private void AddToLog(string logValue)
        {
            rtbLog.BeginInvoke(new UpdateRichTextBoxDelegate(UpdateRichTextBox), logValue);
        }

        private void UpdateRichTextBox(string logValue)
        {
            rtbLog.AppendText(logValue + Environment.NewLine);
            rtbLog.ScrollToCaret();
        }


        public delegate void UpdatePictureBoxDelegate(PictureBox imageControl, Image imageValue);

        private void SetNewImage(PictureBox imageControl, Image imageValue)
        {
            imageControl.BeginInvoke(new UpdatePictureBoxDelegate(UpdatePictureBox), new object[] { imageControl, imageValue });
        }

        private void UpdatePictureBox(PictureBox imageControl, Image imageValue)
        {
            imageControl.Image = imageValue;
        }

        private void WorkStatusUpdate()
        {
            _isWork = !_isWork;
            _isWorkT0 = _isWorkT1 = _isWorkT2 = _isWork;

            if (_isWork)
                AddToLog($"������ ���� ������� ���������� �� �����");
            else
                AddToLog($"������ ���� ������� ����������");

            UpdateStatusThread();
        }

        private void bT0Click_Click(object sender, EventArgs e)
        {
            ThreadStateToLog(0, _isWorkT0 = !_isWorkT0);
        }

        private void bT1Click_Click(object sender, EventArgs e)
        {
            ThreadStateToLog(1, _isWorkT1 = !_isWorkT1);
        }

        private void bT3Click_Click(object sender, EventArgs e)
        {
            ThreadStateToLog(2, _isWorkT2 = !_isWorkT2);
        }

        private void ThreadStateToLog(int id, bool state)
        {
            if (state)
                AddToLog($"����� {id} ��������� �� �����");
            else
                AddToLog($"����� {id} ���������� ������");

            UpdateStatusThread();
        }

        private void UpdateStatusThread()
        {
            pbStatusT0.BackColor = _isWorkT0 ? Color.Green : Color.Red;
            pbStatusT1.BackColor = _isWorkT1 ? Color.Green : Color.Red;
            pbStatusT2.BackColor = _isWorkT2 ? Color.Green : Color.Red;
        }

        private void UpdateDelay(TextBox tb, int id)
        {
            try
            {
                var value = Convert.ToInt32(tb.Text);

                switch (id)
                {
                    case 0: _delayT0 = value; break;
                    case 1: _delayT1 = value; break;
                    case 2: _delayT2 = value; break;
                }

                AddToLog($"������ {id} ����������� ����� ����� ����������: {value} ��");
            }
            catch
            {
                return;
            }
        }

        private void tbT0_TextChanged(object sender, EventArgs e)
        {
            UpdateDelay(tbT0, 0);
        }

        private void tbT1_TextChanged(object sender, EventArgs e)
        {
            UpdateDelay(tbT1, 1);
        }

        private void tbT2_TextChanged(object sender, EventArgs e)
        {
            UpdateDelay(tbT2, 2);
        }
    }
}