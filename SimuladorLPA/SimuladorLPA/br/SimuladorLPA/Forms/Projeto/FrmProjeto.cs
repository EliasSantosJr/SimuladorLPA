using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.PowerPacks;

namespace br.SimuladorLPA.Forms
{


    public partial class FrmProjeto : Form
    {
        int mousex, mousey;
        Panel obj;
        Boolean Dragging;
        object objOrigem = new object();

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public FrmProjeto()
        {
            InitializeComponent();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Panel painel = (Panel)sender;
            if(e.Button == MouseButtons.Left)
            {
                obj = (Panel) sender;
                Dragging = true;
                mousex = -e.X;
                mousey = -e.Y;
                int clipleft  = panel1.PointToClient(MousePosition).X - obj.Location.X;
                int cliptop = panel1.PointToClient(MousePosition).Y - obj.Location.Y;
                int clipwidth = panel1.ClientSize.Width - (obj.Width - clipleft);
                int clipheight = panel1.ClientSize.Height - (obj.Height - cliptop);
                Cursor.Clip = panel1.RectangleToScreen(new Rectangle(clipleft, cliptop, clipwidth, clipheight));
                obj.Invalidate();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Panel painel = (Panel)sender;
            if (Dragging)
            {
                //end the dragging
                Dragging = false;
                //Me.Capture = False
                Cursor.Clip = Rectangle.Empty;
                painel.Invalidate();
            }

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Panel painel = (Panel)sender;
            if( Dragging )
            {
                //'move control to new position
                Point MPosition = new Point();
                MPosition = panel1.PointToClient(MousePosition);
                MPosition.Offset(mousex, mousey);
                //ensure control cannot leave container
                painel.Location = MPosition;
                traserparafrente(sender, e);
            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
         //'Pega cada ListViewItem da memória e adiciona um a um no listview

            if (sender.GetType() == typeof(ListView))
            {
                ListView lista = (ListView)sender;
                ListViewItem[] lista2 = (ListViewItem[])e.Data.GetData("System.Windows.Forms.ListViewItem()");

                if (objOrigem != sender)
                {
                    foreach (ListViewItem item in lista2)
                    {
                        lista.Items.Add(item);
                    }
                }

            }
            else
            {
                obj = (Panel)sender;
                int clipleft = this.PointToClient(MousePosition).X - obj.Location.X;
                int cliptop = this.PointToClient(MousePosition).Y - obj.Location.Y;

                Panel teste = (Panel)sender;
                Point ponto = new Point();
                ponto.X = clipleft;
                ponto.Y = cliptop;

                Panel painel = new Panel();
                painel.MouseDown += panel2_MouseDown;
                painel.MouseMove += panel2_MouseMove;
                painel.MouseUp += panel2_MouseUp;
                painel.MouseClick += traserparafrente;

                painel.BackColor = Color.Black;

                painel.Location = ponto;
                teste.Controls.Add(painel);

            }
            //objOrigem.Items.Remove(item);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)  
        {
            objOrigem = sender;
            try
            {
                ListView lista = (ListView)sender;
                ListViewItem[] listItem = new ListViewItem[lista.SelectedItems.Count];

                int i = 0;
                foreach (ListViewItem item in lista.SelectedItems)
                {
                    ListViewItem it = new ListViewItem();
                    it = (ListViewItem) item.Clone();

                    listItem[i] = it;

                    i++;
                }

                lista.DoDragDrop(new DataObject("System.Windows.Forms.ListViewItem()", listItem), DragDropEffects.Copy);
            }
            catch (Exception ex)
            {

            }
        }

        private void conexaoObjetos(object sender, EventArgs e)
        {

        }

        private void traserparafrente(object sender, MouseEventArgs e)
        {
            if (this.Cursor == Cursors.Hand)
            {
                if (objOrigem != sender)
                {
                    Panel painel = (Panel) objOrigem;
                    Panel painel2 = (Panel)sender;
                    this.Cursor = Cursors.Default;
                    Microsoft.VisualBasic.PowerPacks.LineShape linha = new Microsoft.VisualBasic.PowerPacks.LineShape();
                    linha.ContextMenuStrip = contextMenuStripObjetos;
                    ShapeContainer shapeContainer = new ShapeContainer();
                    shapeContainer.Shapes.Add(linha);
                    linha.X1 = painel.Location.X + painel.Size.Width;
                    linha.X2 =  painel2.Location.X;
                    linha.Y1 = painel.Location.Y + 4;
                    linha.Y2 = painel2.Location.Y + 3;
                    panel1.Controls.Add(shapeContainer);
                    /*
                    Graphics g = panel1.CreateGraphics();
                    Pen pen = new Pen(Color.Red);
                    g.DrawLine(pen, painel.Location.X, painel.Location.Y, painel2.Location.X, painel2.Location.Y);
                    g.Dispose();
                    */
                }

            }
            else
            {
                Panel painel = (Panel)sender;
                painel.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);
            g.DrawLine(pen, 122, 40, 122, 140);
            g.Dispose();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void contextMenuStripObjetos_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip menu = (ContextMenuStrip)sender;
            objOrigem = menu.SourceControl;
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Remove((Control)objOrigem);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Get a handle to the Calculator application. The window class
            // and window name were obtained using the Spy++ tool.
            IntPtr calculatorHandle = FindWindow("CalcFrame", "Calculadora");

            // Verify that Calculator is a running process.
            if (calculatorHandle == IntPtr.Zero)
            {
                MessageBox.Show("Calculator is not running.");
                return;
            }

            // Make Calculator the foreground application and send it 
            // a set of calculations.
            SetForegroundWindow(calculatorHandle);
            SendKeys.SendWait("111");
            SendKeys.SendWait("*");
            SendKeys.SendWait("11");
            SendKeys.SendWait("=");

        }

    }
}
