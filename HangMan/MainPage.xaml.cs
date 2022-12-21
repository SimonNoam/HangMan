using System;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Popups;
using Windows.UI;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HangMan
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        GameManager gameManager;
        Wordes wordes;


        public MainPage()
        {
            this.InitializeComponent();
            Rect windowRectangle = ApplicationView.GetForCurrentView().VisibleBounds;
            MyCanvas.Width = windowRectangle.Width;
            MyCanvas.Height = windowRectangle.Height;

            MyCanvas.Background = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/14086487.548502b151465.jpg"))
            };



           gameManager = new GameManager();
            wordes = new Wordes();

        }

        private void NEWGAME_Click(object sender, RoutedEventArgs e)
        {
            gameManager._CountFalse = 0;
            gameManager._CountTrue = 0;
            switch (Difficulty_cmb.SelectedIndex)
            {
                case 0:
                    gameManager.RandomWord(0, 4);
                    break;
                case 1:
                    gameManager.RandomWord(5, 9);
                    break;
            }
            WordLetters.Text = gameManager.CreateUnderline();
            AddNewRect(gameManager);

        }

        private  void SendLetter_Click(object sender, RoutedEventArgs e)
        {

            gameManager.checkLetterExist(Convert.ToChar(LetterText.Text.ToLower()));
            LetterText.Text = "";
            WordLetters.Text = gameManager.LetterBox.Text;
            AddNewRect(gameManager);
            lose();
            Win();

        }
        public async void lose()
        {
            if (gameManager._CountFalse == 8)
            {
                await new MessageDialog("you lose!! \n Start new game").ShowAsync();
            }
        }
        public async void Win()
        {
            if (gameManager._CountTrue == gameManager.PickedWord.Length)
            {
                await new MessageDialog("you win \n Start new game").ShowAsync();
            }
            
        }
        public Rectangle AddNewRect(GameManager gameManager)
        {
            Rectangle rect = new Rectangle();

            if (gameManager._CountFalse == 1)
            {
                rect.Fill = new ImageBrush
                {

                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets//index1.jpg"))
                };

            }
            else if (gameManager._CountFalse == 2)
            {
                rect.Fill = new ImageBrush
                {

                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets//index2.jpg"))
                };
            }
            else if (gameManager._CountFalse == 3)
            {
                rect.Fill = new ImageBrush
                {

                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets//index3.jpg"))
                };
            }
            else if (gameManager._CountFalse == 4)
            {
                rect.Fill = new ImageBrush
                {

                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets//index4.jpg"))
                };
            }
            else if (gameManager._CountFalse == 5)
            {
                rect.Fill = new ImageBrush
                {

                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets//index5.jpg"))
                };
            }
            else if (gameManager._CountFalse == 6)
            {
                rect.Fill = new ImageBrush
                {

                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets//index6.jpg"))
                };
            }
            else if (gameManager._CountFalse == 7)
            {
                rect.Fill = new ImageBrush
                {

                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets//index7.jpg"))
                };
            }
            else if (gameManager._CountFalse == 8)
            {
                rect.Fill = new ImageBrush
                {

                    ImageSource = new BitmapImage(new Uri("ms-appx:///Assets//index8.jpg"))
                };
            }
            if (gameManager._CountFalse == 0)
            {
                rect.Fill = new SolidColorBrush(Colors.White);
            }
            rect.Width = 586;
            rect.Height = 539;
            Canvas.SetLeft(rect, 457);
            Canvas.SetTop(rect, 300);
            MyCanvas.Children.Add(rect);
            return rect;
        }

    }



}




