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
            _tasks[0] = new Task(() => UpdateThread(0, pbT0, Color.Yellow, Convert.ToInt32(tbT0.Text), ref _isWorkT0)); //left параллельные отрисовки
            _tasks[1] = new Task(() => UpdateThread(1, pbT1, Color.Blue, Convert.ToInt32(tbT1.Text), ref _isWorkT1)); //right
            _tasks[2] = new Task(() => UpdateThread(2, pbT2, Color.Green, Convert.ToInt32(tbT2.Text), ref _isWorkT2)); //center
        }

        public void UpdateThread(int treadId, PictureBox threadPB, Color threadColor, int threadDelay, ref bool isWork)
        { // Form и RichTextBox передаются только ради обновления формы в IF'е, но это не работает
            Bitmap bmp = new Bitmap(threadPB.Width, threadPB.Height); // чтобы можно было пиксели picturebox заполнять
            for (int y = 0; y < bmp.Height; y++) // проходимся по высоте
            {
                for (int x = 0; x < bmp.Width; x++) // по ширине
                {

                    while (!isWork)
                    {
                        Thread.Sleep(100);
                    } 

                    bmp.SetPixel(x, bmp.Height - y - 1, threadColor); // ставим пиксель с указанными параметрами
                    
                    if (x % threadPB.Width == 0) // это условие для заметного поэтапного заполнения picturebox и richtextbox
                    {
                        //lock (threadPB) //блокировка ресурса
                        //{
                            SetNewImage(threadPB, bmp); // обновляем threadPB
                        //}

                        AddToLog($"Поток {treadId}: установил цвет {threadColor.Name} в {y} строку пикселей)"); ;

                        //form.Update(); // не надо
                        Thread.Sleep(threadDelay); // по идее чтобы нагляднее был виден процесс
                    }
                }
            }
            SetNewImage(threadPB, bmp); // обновляем threadPB чтоб наверняка
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
                AddToLog($"Работа всех потоков поставлена на паузу");
            else
                AddToLog($"Работа всех потоков остановлен");
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
                AddToLog($"Поток {id} поставлен на паузу");
            else
                AddToLog($"Поток {id} возобновил работу");
        }
    }
}