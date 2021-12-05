using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Game : Form
    {
        static string[] words = { };
        static string current_word;
        static string show_text;
        static int lives;
        static PictureBox[] lives_image;
        public Game()
        {
            InitializeComponent();
           
        }

        public static void start_game(RichTextBox wordArea)
        {
            
        }
        public static void start_game(RichTextBox wordArea, PictureBox[] lives_image)
        {
            
        }

        public static string get_show_text(string word)
        {
            return "";
        }

        public static void centering_text(RichTextBox word_area)
        {
            
        }

        public static bool is_contains(string word, char symbol)
        {
            bool isContains = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    isContains = true;
                    return isContains;
                }
            }
            return isContains;
        }

        public static string get_new_show_text(string word, char symbol, string old_show_text)
        {
            
            return "";
        }

        public static void button_symbol_click(TextBox wordArea, char symbol, Button cur_button, Button startButton)
        {
            
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
        }

        private void wordArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'а', button1, startGame);
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'б', button2, startGame);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'в', button3, startGame);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'г', button4, startGame);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'д', button5, startGame);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'е', button6, startGame);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ж', button7, startGame);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'з', button8, startGame);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'и', button9, startGame);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'к', button10, startGame);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'л', button11, startGame);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'м', button12, startGame);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'н', button13, startGame);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'о', button14, startGame);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'п', button15, startGame);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'р', button16, startGame);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'с', button17, startGame);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'т', button18, startGame);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'у', button19, startGame);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ф', button20, startGame);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'х', button21, startGame);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ц', button22, startGame);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ч', button23, startGame);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ш', button24, startGame);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'щ', button25, startGame);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ъ', button26, startGame);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ы', button27, startGame);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ь', button28, startGame);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'э', button29, startGame);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ю', button31, startGame);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'я', button31, startGame);
        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wordArea_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
