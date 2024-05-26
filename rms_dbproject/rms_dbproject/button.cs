namespace rms_dbproject
{
    public partial class button : Button
    {
        ToolTip t1 = new ToolTip();
        private Image NormalImage;
        private Image HoverImage;
        private Color Hoverforecolor;
        private Color Normalforecolor;
        private string Tooltip;
        public button()
        {

        }

        public Image NormalImage1 { get => NormalImage; set => NormalImage = value; }
        public Image HoverImage1 { get => HoverImage; set => HoverImage = value; }
        public Color Hoverforecolor1 { get => Hoverforecolor; set => Hoverforecolor = value; }
        public Color Normalforecolor1 { get => Normalforecolor; set => Normalforecolor = value; }
        public string Tooltip1 { get => Tooltip; set => Tooltip = value; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Image = HoverImage;
            ForeColor = Hoverforecolor;
            t1.Show(Tooltip, this);

        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Image = NormalImage;
            ForeColor = Normalforecolor;
            t1.Hide(this);

        }
    }
}
