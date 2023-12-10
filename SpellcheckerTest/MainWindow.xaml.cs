using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpellcheckerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            // スペルチェッカーのカスタム処理を呼び出す
            RunSpellCheck(txtInput.Text);
        }

        private void RunSpellCheck(string text)
        {
            // ここでカスタムのスペルチェッカーを実装する
            // 例: 簡易なスペルチェッカー
            List<string> dictionary = new List<string> { "apple", "orange", "banana" };
            string[] words = text.Split(' ');

           

            foreach (string word in words)
            {
                if (!dictionary.Contains(word.ToLower()))
                {
                    // スペルミスが検出された場合の処理
                    // 例: 背景色を変更する
                    txtInput.Background = Brushes.LightPink;
                }
                else
                {
                    // スペルが正しい場合の処理
                    txtInput.Background = Brushes.White;
                }
            }
        }
    }
}
