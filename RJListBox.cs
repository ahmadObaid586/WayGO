using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGo
{
    public partial class RJListBox : UserControl
    {
        private ListBox listBox;
        private int radius = 10;

        public RJListBox()
        {
            InitializeComponent();
            InitializeListBox();

        }
        private void InitializeListBox()
        {
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            Controls.Add(listBox);
        }
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate(); // Redraw the control when the radius is changed
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = e.Graphics)
            {
                // Set the background color and smoothing mode
                graphics.Clear(BackColor);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Create a rounded rectangle path
                GraphicsPath path = new GraphicsPath();
                int x = ClientRectangle.X;
                int y = ClientRectangle.Y;
                int width = ClientRectangle.Width;
                int height = ClientRectangle.Height;
                path.AddArc(x, y, radius * 2, radius * 2, 180, 90);
                path.AddArc(width - radius * 2, y, radius * 2, radius * 2, 270, 90);
                path.AddArc(width - radius * 2, height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(x, height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                // Fill the rounded rectangle with the back color
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    graphics.FillPath(brush, path);
                }
            }
        }

        // Expose the ListBox's properties and methods
        public object DataSource
        {
            get { return listBox.DataSource; }
            set { listBox.DataSource = value; }
        }

        public string DisplayMember
        {
            get { return listBox.DisplayMember; }
            set { listBox.DisplayMember = value; }
        }

        public int SelectedIndex
        {
            get { return listBox.SelectedIndex; }
            set { listBox.SelectedIndex = value; }
        }

        public object SelectedItem
        {
            get { return listBox.SelectedItem; }
            set { listBox.SelectedItem = value; }
        }

        public ListBox.ObjectCollection Items => listBox.Items;

    }
}