using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace snake
{
    public partial class UI : Form
    {
        private static string _key;
        private static string _key2;
        public Field[,] fields = new Field[20, 36];
        public UI()
        {
            _key = "A";
            _key2 = "A";
            InitializeComponent();
            CreateGamefield();
        }

        public void CreateGamefield()
        {
            int y;
            int x;
            for (y = 0; y < fields.GetLength(0); y++)
            {
                for (x = 0; x < fields.GetLength(1); x++)
                {
                    Field field = new Field(y, x);
                    fields[y, x] = field;
                    gamefield.Controls.Add(field);
                }
            }
            fields[7, 10].MakeSnakeHead();
            fields[7, 10].NEXT = fields[7, 11];
            fields[7, 11].MakeSnakeTail();

            Apple(3);
        }

        public void Apple( int zahl)
        {
            List<Field> apple = new List<Field>();

            foreach (var item in fields)
            {
                if (item._status == Field.Status.Free)
                {
                    apple.Add(item);
                }
            }

            if (apple.Count < 1) return;

            Random random = new Random();

            for (int i = 0; i < zahl; i++)
            {
                int f = random.Next(0, apple.Count);
                apple[f].MakeApple();
                apple.Remove(apple[f]);
            }
        }

        private void UI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
            {
                switch(_key2)
                {
                    case "W":
                        if ("S" == e.KeyCode.ToString()) break;
                        _key = e.KeyCode.ToString();
                        break;

                    case "A":
                        if ("D" == e.KeyCode.ToString()) break;
                        _key = e.KeyCode.ToString();
                        break;

                    case "S":
                        if ("W" == e.KeyCode.ToString()) break;
                        _key = e.KeyCode.ToString();
                        break;

                    case "D":
                        if ("A" == e.KeyCode.ToString()) break;
                        _key = e.KeyCode.ToString();
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _key2 = _key;
            bool apple = true;
            Field field = null;
            
            if (Game._score == (fields.GetLength(0) * fields.GetLength(1)) - 2) Game.GameOver(true);

            foreach (var item in fields)
            {
                if (item._status == Field.Status.SnakeHead)
                {
                    field = item;
                    break;
                }
            }
            
            switch (_key)
            {
                case "W":
                    if (field.y - 1 >= 0 && fields[field.y - 1, field.x]._status != Field.Status.Snake) 
                        apple = Game.move(field, field.y - 1, field.x);
                    else Game.GameOver(false);
                    break;

                case "A":
                    if (field.x - 1 >= 0 && fields[field.y, field.x - 1]._status != Field.Status.Snake)
                        apple = Game.move(field, field.y, field.x - 1);
                    else Game.GameOver(false);
                    break;

                case "S":
                    if (field.y + 1 < fields.GetLength(0) && fields[field.y + 1, field.x]._status != Field.Status.Snake)
                        apple = Game.move(field, field.y + 1, field.x);
                    else Game.GameOver(false);
                    break;

                case "D":
                    if (field.x + 1 < fields.GetLength(1) && fields[field.y, field.x + 1]._status != Field.Status.Snake)
                        apple = Game.move(field, field.y, field.x + 1);
                    else Game.GameOver(false);
                    break;
            }
            if (apple)
            {
                Game._score ++ ;
                Apple(1);
            }

            labelscore.Text = "Punkte: " + Game._score.ToString();
        }
    }
}
