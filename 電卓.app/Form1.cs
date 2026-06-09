using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 電卓.app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算に用いるフラグ　１は入力切替用・２は計算用
        int signalCode1;
        int signalCode2;

        // 計算に用いる箱
        decimal number1;

        private void Form1_Load(object sender, EventArgs e)
        {
            //　最初のテキスト
            textBox1.Text = "0";
        }

        /// <summary>
        /// 数字ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            string box1 = ((System.Windows.Forms.Button)sender).Text;
            SetNumber(box1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="btnNumber"></param>
        private void SetNumber(string btnNumber)
        {
            if (signalCode1 != default)
            {
                //　演算子が入力されている場合、任意の数字を上書き
                textBox1.Text = btnNumber;
                signalCode1 = default;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    //　０が入力されているとき、任意の数字を上書き
                    textBox1.Text = btnNumber;
                }
                else
                {
                    //　０以外が入力されている場合、任意の数字を文字列結合
                    textBox1.Text += btnNumber;
                }
            }
        }

        /// <summary>
        /// 演算子ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOperator_Click(object sender, EventArgs e)
        {
            string box2 = ((System.Windows.Forms.Button)sender).Text;
            SetSignal(box2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="btnSignal"></param>
        private void SetSignal(string btnSignal)
        {
            //　演算子が入力されたことと１つ目の数字の保存
            signalCode1 = 1;
            number1 = decimal.Parse(textBox1.Text);

            switch (btnSignal)
            {
                //　演算子の保存
                case "+":
                    signalCode2 = 1;
                    break;
                case "-":
                    signalCode2 = 2;
                    break;
                case "/":
                    signalCode2 = 3;
                    break;
                case "*":
                    signalCode2 = 4;
                    break;
            }
        }

        /// <summary>
        /// 小数点ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonD_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
            
        }

        /// <summary>
        /// クリアボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            signalCode1 = default;
            signalCode2 = default;
        }

        /// <summary>
        /// イコールボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonE_Click(object sender, EventArgs e)
        {
            textBox1.Text = SetEqual();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string SetEqual()
        {
            decimal number3 = 0;
            decimal number2 = decimal.Parse(textBox1.Text);
            signalCode1 = 1;

            switch(signalCode2)
            {
                //　各計算処理
                case 1:
                    number3 = number1 + number2;
                    break;

                case 2:
                    number3 = number1 - number2;
                    break;

                case 3:
                    number3 = number1 / number2;
                    break;

                case 4:
                    number3 = number1 * number2;
                    break;
            }

            return number3.ToString();
        }


        /// <summary>
        /// デリートボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (signalCode1 == default)
            {
                int number4 = textBox1.Text.Length;

                switch (number4)
                {
                    // 後ろの数字削除
                    case 1:
                        textBox1.Text = "0";
                        break;
                    default:
                        textBox1.Text = textBox1.Text.Remove(number4 - 1, 1);
                        break;
                }
                

                
            }
        }
    }
}
