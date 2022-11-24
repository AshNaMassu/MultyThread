using System.Threading;
using System.Windows.Forms;

namespace MultyThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbLog.Clear();
        }

        public Task[] tasks = new Task[3];
        
        private void bTAll_Click(object sender, EventArgs e)
        {
            pbT0.Image = null; pbT1.Image = null; pbT2.Image = null;
            //rtbLog.Clear();
            tasks[0] = new Task(() => UpdateThread(0, pbT0, Color.Yellow, Convert.ToInt32(tbT0.Text))); //left параллельные отрисовки
            tasks[1] = new Task(() => UpdateThread(1, pbT1, Color.Blue, Convert.ToInt32(tbT1.Text))); //right
            tasks[2] = new Task(() => UpdateThread(2, pbT2, Color.Green, Convert.ToInt32(tbT2.Text))); //center
            foreach (var t in tasks)
                t.Start();
            //Task.WaitAll(tasks);
        }

        public void UpdateThread(int treadId, PictureBox threadPB, Color threadColor, int threadDelay)
        { // Form и RichTextBox передаются только ради обновления формы в IF'е, но это не работает
            Bitmap bmp = new Bitmap(threadPB.Width, threadPB.Height); // чтобы можно было пиксели picturebox заполнять
            for (int y = 0; y < bmp.Height; y++) // проходимся по высоте
            {
                for (int x = 0; x < bmp.Width; x++) // по ширине
                {
                    bmp.SetPixel(x, bmp.Height - y - 1, threadColor); // ставим пиксель с указанными параметрами
                    
                    if (x % threadPB.Width == 0) // это условие для заметного поэтапного заполнения picturebox и richtextbox
                    {
                        //logRTB.Text += $"Поток {threadDelay}: установил цвет {threadColor.Name} в пиксель ({x}, {y})\threadDelay";
                        //logRTB.Invoke(new AddRTextDelegate(RTextAdd), threadColor.Name, x, y, threadDelay); не надо
                        SetNewImage(threadPB, bmp); // обновляем threadPB

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

        public void UpdateRichTextBox(string logValue)
        {
            rtbLog.AppendText(logValue + Environment.NewLine);
            rtbLog.ScrollToCaret();
        }


        public delegate void UpdatePictureBoxDelegate(PictureBox imageControl, Image imageValue);

        private void SetNewImage(PictureBox imageControl, Image imageValue)
        {
            imageControl.BeginInvoke(new UpdatePictureBoxDelegate(UpdatePictureBox), new object[] { imageControl, imageValue });
        }

        public void UpdatePictureBox(PictureBox imageControl, Image imageValue)
        {
            imageControl.Image = imageValue;
        }

        
    }
}