using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Паклина_Учебка
{
    public partial class MainWindow : Window
    {
        string[] cards_a = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "Ace" };
        string[] cards_b = new string[4] { "clubs", "diamonds", "hearts", "spades" };
        Random rnd = new Random();
        string curcard;

        List<string> row1 = new List<string>();
        List<string> row2 = new List<string>();
        List<string> row3 = new List<string>();
        int row1c = 0;
        int row2c = 0;
        int row3c = 0;
        int row1p = 0;
        int row2p = 0;
        int row3p = 0;
        int hp = 3;
        int pts = 0;
        string messageBoxText = "Do you want to save changes?";
        string caption = "Word Processor";
        MessageBoxButton button = MessageBoxButton.OK;
        MessageBoxImage icon = MessageBoxImage.Warning;
        MessageBoxResult result;

       
        public MainWindow()
        {
            InitializeComponent();
            curcard = shuffle();
            hpUpd();
            ScoreUpd();
            row1_pts.Content = "0";
            row2_pts.Content = "0";
            row3_pts.Content = "0";
            LastScore.Content = "Last score: ";

        }
        public string shuffle()
        {
            string curr_card = $"{cards_b[rnd.Next(cards_b.Count())]} {cards_a[rnd.Next(cards_a.Count())]}";
            ChangeImage(curCard, curr_card);
            return curr_card;
        }
        public void ChangeImage(Image img, string card)
        {
            switch (card)
            {
                case "clubs 2":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/2c.jpg"));
                        break;
                    }
                case "clubs 3":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/3c.jpg"));
                        break;
                    }
                case "clubs 4":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/4c.jpg"));
                        break;
                    }
                case "clubs 5":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/5c.jpg"));
                        break;
                    }
                case "clubs 6":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/6c.jpg"));
                        break;
                    }
                case "clubs 7":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/7c.jpg"));
                        break;
                    }
                case "clubs 8":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/8c.jpg"));
                        break;
                    }
                case "clubs 9":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/9c.jpg"));
                        break;
                    }
                case "clubs 10":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/10c.jpg"));
                        break;
                    }
                case "clubs J":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/jc.jpg"));
                        break;
                    }
                case "clubs Q":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/qc.jpg"));
                        break;
                    }
                case "clubs K":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/kc.jpg"));
                        break;
                    }
                case "clubs Ace":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/ac.jpg"));
                        break;
                    }
                case "diamonds 2":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/2d.jpg"));
                        break;
                    }
                case "diamonds 3":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/3d.jpg"));
                        break;
                    }
                case "diamonds 4":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/4d.jpg"));
                        break;
                    }
                case "diamonds 5":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/5d.jpg"));
                        break;
                    }
                case "diamonds 6":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/6d.jpg"));
                        break;
                    }
                case "diamonds 7":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/7d.jpg"));
                        break;
                    }
                case "diamonds 8":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/8d.jpg"));
                        break;
                    }
                case "diamonds 9":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/9d.jpg"));
                        break;
                    }
                case "diamonds 10":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/10d.jpg"));
                        break;
                    }
                case "diamonds J":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/jd.jpg"));
                        break;
                    }
                case "diamonds Q":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/qd.jpg"));
                        break;
                    }
                case "diamonds K":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/kd.jpg"));
                        break;
                    }
                case "diamonds Ace":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/ad.jpg"));
                        break;
                    }
                case "hearts 2":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/2h.jpg"));
                        break;
                    }
                case "hearts 3":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/3h.jpg"));
                        break;
                    }
                case "hearts 4":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/4h.jpg"));
                        break;
                    }
                case "hearts 5":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/5h.jpg"));
                        break;
                    }
                case "hearts 6":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/6h.jpg"));
                        break;
                    }
                case "hearts 7":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/7h.jpg"));
                        break;
                    }
                case "hearts 8":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/8h.jpg"));
                        break;
                    }
                case "hearts 9":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/9h.jpg"));
                        break;
                    }
                case "hearts 10":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/10h.jpg"));
                        break;
                    }
                case "hearts J":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/jh.jpg"));
                        break;
                    }
                case "hearts Q":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/qh.jpg"));
                        break;
                    }
                case "hearts K":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/kh.jpg"));
                        break;
                    }
                case "hearts Ace":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/ah.jpg"));
                        break;
                    }
                case "spades 2":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/2s.jpg"));
                        break;
                    }
                case "spades 3":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/3s.jpg"));
                        break;
                    }
                case "spades 4":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/4s.jpg"));
                        break;
                    }
                case "spades 5":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/5s.jpg"));
                        break;
                    }
                case "spades 6":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/6s.jpg"));
                        break;
                    }
                case "spades 7":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/7s.jpg"));
                        break;
                    }
                case "spades 8":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/8s.jpg"));
                        break;
                    }
                case "spades 9":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/9s.jpg"));
                        break;
                    }
                case "spades 10":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/10s.jpg"));
                        break;
                    }
                case "spades J":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/js.jpg"));
                        break;
                    }
                case "spades Q":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/qs.jpg"));
                        break;
                    }
                case "spades K":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/ks.jpg"));
                        break;
                    }
                case "spades Ace":
                    {
                        img.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/as.jpg"));
                        break;
                    }
            }
        }

        private void row1_btn_Click(object sender, RoutedEventArgs e)
        {
            row1.Add(curcard);
            row1c++;
            switch (row1c)
            {
                case 1:
                    {
                        ChangeImage(row1_1, curcard);
                        break;
                    }
                case 2:
                    {
                        ChangeImage(row1_2, curcard);
                        break;
                    }
                case 3:
                    {
                        ChangeImage(row1_3, curcard);
                        break;
                    }
                case 4:
                    {
                        ChangeImage(row1_4, curcard);
                        break;
                    }
                case 5:
                    {
                        ChangeImage(row1_5, curcard);
                        break;
                    }
                case 6:
                    {
                        RowEnd("1");
                        row1c = 0;
                        break;
                    }
            }
            curcard = shuffle();
            RowEnd("1");
        }

        private void row2_btn_Click(object sender, RoutedEventArgs e)
        {
            row2.Add(curcard);
            row2c++;
            switch (row2c)
            {
                case 1:
                    {
                        ChangeImage(row2_1, curcard);
                        break;
                    }
                case 2:
                    {
                        ChangeImage(row2_2, curcard);
                        break;
                    }
                case 3:
                    {
                        ChangeImage(row2_3, curcard);
                        break;
                    }
                case 4:
                    {
                        ChangeImage(row2_4, curcard);
                        break;
                    }
                case 5:
                    {
                        ChangeImage(row2_5, curcard);
                        break;
                    }
                case 6:
                    {
                        RowEnd("2");
                        row2c = 0;
                        break;
                    }
            }
            curcard = shuffle();
            RowEnd("2");
        }

        private void row3_btn_Click(object sender, RoutedEventArgs e)
        {
            row3.Add(curcard);
            row3c++;
            switch (row3c)
            {
                case 1:
                    {
                        ChangeImage(row3_1, curcard);
                        break;
                    }
                case 2:
                    {
                        ChangeImage(row3_2, curcard);
                        break;
                    }
                case 3:
                    {
                        ChangeImage(row3_3, curcard);
                        break;
                    }
                case 4:
                    {
                        ChangeImage(row3_4, curcard);
                        break;
                    }
                case 5:
                    {
                        ChangeImage(row3_5, curcard);
                        break;
                    }
                case 6:
                    {
                        RowEnd("3");
                        row3c = 0;
                        break;
                    }
            }
            curcard = shuffle();
            RowEnd("3");
        }
        public void hpUpd()
        {
            Lives.Content = $"Lives: {hp}";
            if (hp == 0)
            {
                messageBoxText = "Вы проиграли!";
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                row1.Clear();
                row2.Clear();
                row3.Clear();
                row1_1.Source = null;
                row1_2.Source = null;
                row1_3.Source = null;
                row1_4.Source = null;
                row1_5.Source = null;
                row2_1.Source = null;
                row2_2.Source = null;
                row2_3.Source = null;
                row2_4.Source = null;
                row2_5.Source = null;
                row3_1.Source = null;
                row3_2.Source = null;
                row3_3.Source = null;
                row3_4.Source = null;
                row3_5.Source = null;
                row1p = 0;
                row2p = 0;
                row3p = 0;
                row1c = 0;
                row2c = 0;
                row3c = 0;
                row1_pts.Content = 0;
                row2_pts.Content = 0;
                row3_pts.Content = 0;
                row1.Clear();
                row2.Clear();
                row3.Clear();
                hp = 3;
                LastScore.Content = $"Last score: {pts}";
                pts = 0;
                Lives.Content = $"Lives: {hp}";
                ScoreUpd();
            }
        }
        public void ScoreUpd()
        {
            Score.Content = $"Score: {pts}";
        }
        public void RowEnd(string rw)
        {
            if (rw == "1")
            {
                foreach (string c in row1)
                {
                    if (c.Contains("2"))
                    {
                        row1p += 2;
                        continue;
                    }
                    if (c.Contains("3"))
                    {
                        row1p += 3;
                        continue;
                    }
                    if (c.Contains("4"))
                    {
                        row1p += 4;
                        continue;
                    }
                    if (c.Contains("5"))
                    {
                        row1p += 5;
                        continue;
                    }
                    if (c.Contains("6"))
                    {
                        row1p += 6;
                        continue;
                    }
                    if (c.Contains("7"))
                    {
                        row1p += 7;
                        continue;
                    }
                    if (c.Contains("8"))
                    {
                        row1p += 8;
                        continue;
                    }
                    if (c.Contains("9"))
                    {
                        row1p += 9;
                        continue;
                    }
                    if (c.Contains("10"))
                    {
                        row1p += 10;
                        continue;
                    }
                    if (c.Contains("J"))
                    {
                        row1p += 10;
                        continue;
                    }
                    if (c.Contains("Q"))
                    {
                        row1p += 10;
                        continue;
                    }
                    if (c.Contains("K"))
                    {
                        row1p += 10;
                        continue;
                    }
                    if (c.Contains("Ace"))
                    {
                        if (row1p + 11 <= 21)
                            row1p += 11;
                        else
                            row1p += 1;
                        continue;
                    }
                }
                row1_pts.Content = row1p;
                if (row1p == 21)
                {
                    messageBoxText = "21!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row1_1.Source = null;
                    row1_2.Source = null;
                    row1_3.Source = null;
                    row1_4.Source = null;
                    row1_5.Source = null;
                    row1.Clear();
                    row1c = 0;
                    row1_pts.Content = 0;
                    pts += 300;
                }
                else if (row1p > 21 & row1c =< 5)
                {
                    messageBoxText = "Слишком много очков!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row1_1.Source = null;
                    row1_2.Source = null;
                    row1_3.Source = null;
                    row1_4.Source = null;
                    row1_5.Source = null;
                    row1.Clear();
                    row1c = 0;
                    row1_pts.Content = 0;
                    if (pts >= 50)
                        pts -= 50;
                    hp--;
                }
                else if (row1p < 21 & row1c == 5)
                {
                    messageBoxText = "БЛЕКДЖЕК!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row1_1.Source = null;
                    row1_2.Source = null;
                    row1_3.Source = null;
                    row1_4.Source = null;
                    row1_5.Source = null;
                    row1.Clear();
                    row1c = 0;
                    row1_pts.Content = 0;
                    pts += 150;
                }
                row1p = 0;
            }
            if (rw == "2")
            {
                foreach (string c in row2)
                {
                    if (c.Contains("2"))
                    {
                        row2p += 2;
                        continue;
                    }
                    if (c.Contains("3"))
                    {
                        row2p += 3;
                        continue;
                    }
                    if (c.Contains("4"))
                    {
                        row2p += 4;
                        continue;
                    }
                    if (c.Contains("5"))
                    {
                        row2p += 5;
                        continue;
                    }
                    if (c.Contains("6"))
                    {
                        row2p += 6;
                        continue;
                    }
                    if (c.Contains("7"))
                    {
                        row2p += 7;
                        continue;
                    }
                    if (c.Contains("8"))
                    {
                        row2p += 8;
                        continue;
                    }
                    if (c.Contains("9"))
                    {
                        row2p += 9;
                        continue;
                    }
                    if (c.Contains("10"))
                    {
                        row2p += 10;
                        continue;
                    }
                    if (c.Contains("J"))
                    {
                        row2p += 10;
                        continue;
                    }
                    if (c.Contains("Q"))
                    {
                        row2p += 10;
                        continue;
                    }
                    if (c.Contains("K"))
                    {
                        row2p += 10;
                        continue;
                    }
                    if (c.Contains("Ace"))
                    {
                        if (row2p + 11 <= 21)
                            row2p += 11;
                        else
                            row2p += 1;
                        continue;
                    }
                }
                row2_pts.Content = row2p;
                if (row2p == 21)
                {
                    messageBoxText = "21!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row2_1.Source = null;
                    row2_2.Source = null;
                    row2_3.Source = null;
                    row2_4.Source = null;
                    row2_5.Source = null;
                    row2.Clear();
                    row2c = 0;
                    row2_pts.Content = 0;
                    pts += 300;
                }
                else if (row2p > 21 & row2c =< 5)
                {
                    messageBoxText = "Слишком много карт!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row2_1.Source = null;
                    row2_2.Source = null;
                    row2_3.Source = null;
                    row2_4.Source = null;
                    row2_5.Source = null;
                    row2.Clear();
                    row2c = 0;
                    row2_pts.Content = 0;
                    if (pts >= 50)
                        pts -= 50;
                    hp--;
                }
                else if (row2p < 21 & row2c == 5)
                {
                    messageBoxText = "БЛЕКДЖЕК!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row2_1.Source = null;
                    row2_2.Source = null;
                    row2_3.Source = null;
                    row2_4.Source = null;
                    row2_5.Source = null;
                    row2.Clear();
                    row2c = 0;
                    row2_pts.Content = 0;
                    pts += 150;
                }
                row2p = 0;
            }
            if (rw == "3")
            {
                foreach (string c in row3)
                {
                    if (c.Contains("2"))
                    {
                        row3p += 2;
                        continue;
                    }
                    if (c.Contains("3"))
                    {
                        row3p += 3;
                        continue;
                    }
                    if (c.Contains("4"))
                    {
                        row3p += 4;
                        continue;
                    }
                    if (c.Contains("5"))
                    {
                        row3p += 5;
                        continue;
                    }
                    if (c.Contains("6"))
                    {
                        row3p += 6;
                        continue;
                    }
                    if (c.Contains("7"))
                    {
                        row3p += 7;
                        continue;
                    }
                    if (c.Contains("8"))
                    {
                        row3p += 8;
                        continue;
                    }
                    if (c.Contains("9"))
                    {
                        row3p += 9;
                        continue;
                    }
                    if (c.Contains("10"))
                    {
                        row3p += 10;
                        continue;
                    }
                    if (c.Contains("J"))
                    {
                        row3p += 10;
                        continue;
                    }
                    if (c.Contains("Q"))
                    {
                        row3p += 10;
                        continue;
                    }
                    if (c.Contains("K"))
                    {
                        row3p += 10;
                        continue;
                    }
                    if (c.Contains("Ace"))
                    {
                        if (row3p + 11 <= 21)
                            row3p += 11;
                        else
                            row3p += 1;
                        continue;
                    }
                }
                row3_pts.Content = row3p;
                if (row3p == 21)
                {
                    messageBoxText = "21!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row3_1.Source = null;
                    row3_2.Source = null;
                    row3_3.Source = null;
                    row3_4.Source = null;
                    row3_5.Source = null;
                    row3.Clear();
                    row3c = 0;
                    row3_pts.Content = 0;
                    pts += 300;
                }
                else if (row3p > 21 & row3c =< 5)
                {
                    messageBoxText = "Слишком много карт!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row3_1.Source = null;
                    row3_2.Source = null;
                    row3_3.Source = null;
                    row3_4.Source = null;
                    row3_5.Source = null;
                    row3.Clear();
                    row3c = 0;
                    row3_pts.Content = 0;
                    if (pts >= 50)
                        pts -= 50;
                    hp--;
                }
                else if (row3p < 21 & row3c == 5)
                {
                    messageBoxText = "БЛЕКДЖЕК!";
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    row3_1.Source = null;
                    row3_2.Source = null;
                    row3_3.Source = null;
                    row3_4.Source = null;
                    row3_5.Source = null;
                    row3.Clear();
                    row3c = 0;
                    row3_pts.Content = 0;
                    pts += 150;
                }
                row3p = 0;
            }
            hpUpd();
            ScoreUpd();
        }
    }
}
