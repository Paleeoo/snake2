using System;
using System.Windows.Forms;

namespace snake
{
    public static class Game
    {
        private static UI _ui;
        public static int _score = 0;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ReInitializeGame();
        }

        private static void ReInitializeGame()
        {
            _ui = new UI();
            _ui.labelscore.Text = "Punkte: " + _score.ToString();
            _ui.ShowDialog();
        }


        public static bool move(Field field, int y, int x)
        {
            bool apple = true;
            if (_ui.fields[y, x]._status == Field.Status.Apple) apple = false;
            
            _ui.fields[y, x].MakeSnakeHead();
            _ui.fields[y, x].NEXT = field;
            while (true)
            {
                field.MakeSnake();
                if (field.NEXT.NEXT == null)
                {
                    field.NEXT.MakeNormal();
                    if (apple) field.NEXT = null;
                    break;
                }
                field = field.NEXT;
            }

            return apple;
        }


        

        public static void GameOver(bool f)
        {
            _ui.timer1.Stop();
            if (f) MessageBox.Show("Du hast echt kein Leben");
            else MessageBox.Show("Du hast verloren");

            _ui.Close();
            _ui.Dispose();
            _score = 0;
            ReInitializeGame();
        }

    }
}
