using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2.figureCreator;
using lab2.DrawFigure;
using lab2.Serializers;
using BasicLibrary;
using Figures1;
using EncryptAdapter;


namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g.FillRectangle(new SolidBrush(Color.White), 0,0,
                804, 414);
            pictureBox1.Image = bmp;
            Area();
            Perimeter();
            XJBox.Items.Add(formplugs[formplugs.Count - 1].Description);
            XJBox.Items.Add(Adapter.Description);
        }
        static Bitmap bmp = new Bitmap(804, 400);
        Graphics g = Graphics.FromImage(bmp);
        Color Color1 = Color.Red;
        bool isDrawing = false;
        Point[] arrayPoints = new Point[3];
        FigureCreator thisCreator;
        int clicksNumber, currentClicks = 0;
        public List<Figure> list = new List<Figure>();
        List<IMath> plugins = PluginInvoker.InvokeMathPlugin();
        List<IFormatter> formplugs = PluginInvoker.InvokeTransformPlugin();
        Dictionary<string, IMath> area = new Dictionary<string, IMath>();
        Dictionary<string, IMath> perimeter = new Dictionary<string, IMath>();
        Adapter Adapter = new Adapter();
        private void Area()
        {
            area.Add("Круг", plugins[0]);
            area.Add("Эллипс", plugins[1]);
            area.Add("Прямоугольник", plugins[2]);
            area.Add("Квадрат", plugins[3]);
            area.Add("Треугольник", plugins[4]);
        }
        private void Perimeter()
        {
            perimeter.Add("Круг", plugins[5]);
            perimeter.Add("Эллипс", plugins[6]);
            perimeter.Add("Прямоугольник", plugins[7]);
            perimeter.Add("Квадрат", plugins[8]);
            perimeter.Add("Треугольник", plugins[9]);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            thisCreator = new TriangleFigureCreator();
            clicksNumber = 3;
            currentClicks = 0;
            isDrawing = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            thisCreator = new EllipseFigureCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            thisCreator = new CircleFigureCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            thisCreator = new RectangleFigureCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color1 = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color1 = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color1 = Color.Yellow;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color1 = Color.Green;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color1 = Color.Black;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
           if (list.Count == 0)
            {
                MessageBox.Show("Область рисования чиста");
           }
          else
        
           {
                g.Clear(Color.White);
                //g.Dispose();
                pictureBox1.Image = bmp;
                list.Clear();
            }
          

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
             
            BinarySerializer.Serialize(list);
        }


        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            list = BinarySerializer.Deserialize();
            for (int i = 0; i < list.Count(); i++)
            {
                pictureBox1Paint(list[list.Count - i - 1]);
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            XmlSerialize.Serialize(list);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            list = XmlSerialize.Deserialize();
            for (int i = 0; i < list.Count(); i++)
            {
                pictureBox1Paint(list[list.Count - i - 1]);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double value = 0;
            if (list.Count == 0)
            {
                MessageBox.Show("Фигура не нарисована");
                listBoxPlugin.SelectedItems.Clear();
                return;
            }
            if (listBoxPlugin.SelectedItem == null)
            {
                MessageBox.Show("Выберите функцию");
                return;
            }
            if (listBoxPlugin.SelectedIndex == 0)
            {

                value = area[list[list.Count - 1].Title].Calculate(list[list.Count - 1]);
                if (value != 0)
                { 
                    MessageBox.Show("Площадь фигуры равна " + value.ToString());
                    listBoxPlugin.SelectedItems.Clear();
                }
                return;
            }
            if (listBoxPlugin.SelectedIndex == 1)
            {
                value = perimeter[list[list.Count - 1].Title].Calculate(list[list.Count - 1]);
                if (value != 0)
                {
                    MessageBox.Show("Периметр фигуры равен " + value.ToString());
                    listBoxPlugin.SelectedItems.Clear();
                }
                return;
            }
        }

        private void listBoxPlugin_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1Paint(Figure f)
        {
          
            IDrawFigure draw;
                if (f.GetType() == typeof(Ellipse))
                {
                    draw = new DrawEllipse((Ellipse)f);
                    draw.Draw(g);
                    pictureBox1.Image = bmp;
                }
                if (f.GetType() == typeof(Circle))
                {
                    draw = new DrawCircle((Circle)f);
                    draw.Draw(g);
                    pictureBox1.Image = bmp;
                }

                if (f.GetType() == typeof(Figures1.Rectangle))
                {
                    draw = new DrawRectangle((Figures1.Rectangle)f);
                    draw.Draw(g);
                    pictureBox1.Image = bmp;
                }

                if (f.GetType() == typeof(Square))
                {
                    draw = new DrawRectangle((Figures1.Rectangle)f);
                    draw.Draw(g);
                    pictureBox1.Image = bmp;
                }

                if (f.GetType() == typeof(Triangle))
                {
                    draw = new DrawTriangle((Triangle)f);
                    draw.Draw(g);
                    pictureBox1.Image = bmp;
                }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (currentClicks < clicksNumber)
                {
                    if (currentClicks == 0)
                        arrayPoints[0] = new Point(e.X, e.Y);
                    if (currentClicks == 1)
                        arrayPoints[1] = new Point(e.X, e.Y);
                    if (currentClicks == 2)
                        arrayPoints[2] = new Point(e.X, e.Y);
                    currentClicks++;
                }
                if (currentClicks == clicksNumber)
                {
                    currentClicks = 0;
                    list.Add(thisCreator.FactoryMethod(arrayPoints, Color1));

                    pictureBox1Paint(list[list.Count - 1]);
                    currentClicks = 0;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Нечего удалять");
            }
            else
            {
                list.Remove(list.Last());
                if (list.Count == 0)
                {
                    g.Clear(Color.White);
                    pictureBox1.Image = bmp;
                }
                else
                { 
                    g.Clear(Color.White);
                    for (int i = 0; i<list.Count(); i++)
                    {
                        pictureBox1Paint(list[list.Count - i - 1]);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (XJBox.SelectedIndex == 0)
            {
                formplugs[formplugs.Count - 1].Transform(list);
                XJBox.SelectedItems.Clear();
            }
            else
            {
                MessageBox.Show("Выберите плагин");
                XJBox.SelectedItems.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (XJBox.SelectedIndex == 0)
            {
                list = formplugs[0].Restore();
                for (int i = 0; i < list.Count(); i++)
                {
                    pictureBox1Paint(list[list.Count - i - 1]);
                    XJBox.SelectedItems.Clear();
                }
            }
            else
            {
                XJBox.SelectedItems.Clear();
                MessageBox.Show("Выберите плагин");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (XJBox.SelectedIndex == 1)
            {
                Adapter.List= list;
                Adapter.WrapperTransform();
                XJBox.SelectedItems.Clear();
            }
            else
            {
                XJBox.SelectedItems.Clear();
                MessageBox.Show("Выберите правильный плагин");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (XJBox.SelectedIndex == 1)
            {
                list = Adapter.WrapperRestore();
                XJBox.SelectedItems.Clear();
                foreach (Figure figure in list)
                {
                    pictureBox1Paint(figure);
                }
            }
            else
            {
                XJBox.SelectedItems.Clear();
                MessageBox.Show("Выберите правильный плагин");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            thisCreator = new SquareFigureCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;
        }
    }
}
