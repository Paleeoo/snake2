using System.Drawing;
using System.Windows.Forms;

namespace snake
{
    public class Field : Panel
    {
        public const int SIZE = 30;
        public readonly int x, y;
        public Field NEXT;
        public Label Label;

        public enum Status
        {
            Free,
            Apple,
            Snake,
            SnakeHead
        }
        public Status _status;

        public Field(int y, int x)
        {
            this.x = x;
            this.y = y;
            BackColor = Color.Transparent;
            Location = new Point(x * SIZE, y * SIZE);
            Label = new Label();
            Label.Size = new Size(SIZE, SIZE);
            Label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.ForeColor = Color.Red;
            Controls.Add(Label);
            Size = new Size(SIZE, SIZE);
        }

        public void MakeSnakeHead()
        {
            _status = Status.SnakeHead;
            BackColor = Color.Green;
            Label.Text = "😃";
        }

        public void MakeSnake()
        {
            _status = Status.Snake;
            BackColor = Color.Green;
            Label.Text = null;
        }

        public void MakeApple()
        {
            _status = Status.Apple; 
            Label.Text = "🍎";
        }

        public void MakeNormal()
        {
            _status = Status.Free;
            BackColor = Color.Transparent;
            Label.Text = null;
           
        }
    }
}
