using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace TestCode
{
    class Program
    {
        static IDictionary<string, string> keySymbols = new Dictionary<string, string>();
        static string examplText = String.Empty;

        public static bool  BoolValue { get; set; }
        
        public enum MyEnum
        {
            One ,
            Two 

        }
        
        // Імпорт функції Windows API для виводу тексту
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        static void ShowMessageBox()
        {
            // Викликаємо функцію MessageBox, передаючи рядок для виводу
            MessageBox(IntPtr.Zero, "Привіт, це приклад marshalling!", "Повідомлення", 0);
        }
        public static void Main(string[] args)
        {

            // string mac = "70:4a:0e:81:e4:ec"; //123463373284588
            // Console.WriteLine(MacToULong(mac));
            
            
        }
        
        public string LongestCommonPrefix(string[] strs)
        {
            strs.Append("flfsfs");
            strs.Append("flgsgs");
            strs.Append("flfsss");

            string result = "";
            
            
            for (int i = 0; i < strs.Length; i++)
            {
                
            }

            return result;
        }
        
        public static  ulong MacToULong(string macAddress)
        {
            string hex = macAddress.Replace(":", "");
            return Convert.ToUInt64(hex, 16);
        }
        
        public static string ReorganizeString(string s)
        {

            var a = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            char lastAdded = '-';
            int t = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (lastAdded != a[i])
                {
                    lastAdded = a[i];
                    sb.Append(lastAdded);
                    t--;
                }
                else
                {
                    t++;
                }
              
            }

            if (t > 0)
            {
                return "";
            }

            Console.WriteLine(t);

            return sb.ToString();


        }
        
        public static bool IsPalindrome(int x) {
            var s = x.ToString();
            var a = s.ToCharArray();

            var l = a.Length / 2;
          
            for (int i = 0; i < l; i++)
            {
                if (a[i] != a[a.Length-1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        
        
        public static string Convert24TO12HourFormat(string time)
        {
            var arrayTime = time.Split(":");
            if(19 <= Convert.ToInt32(arrayTime[0]) &&  Convert.ToInt32(arrayTime[0])<= 24)
                return $"{Convert.ToInt32(arrayTime[0]) - 8}:{arrayTime[1]}:{arrayTime[2]}";
            
            if(0 <= Convert.ToInt32(arrayTime[0]) &&  Convert.ToInt32(arrayTime[0])<= 8)
                return $"{Convert.ToInt32(arrayTime[0]) + 9}:{arrayTime[1]}:{arrayTime[2]}";
            
            return $"{Convert.ToInt32(arrayTime[0])}:{arrayTime[1]}:{arrayTime[2]}";
        }
        
        public static ulong MAC802DOT3(string macAddress)
        {
            string hex = macAddress.Replace(":", "");
            return Convert.ToUInt64(hex, 16);
        }

        public static void Initialization()
        {
            examplText =
                "bookkeepings Some of (these cookies) are necessary for the website (to function)," +
                " whilst others require your consent.";
            
            keySymbols.Add("A", "!");
            keySymbols.Add("B", "№");
            keySymbols.Add("C", "%");
            keySymbols.Add("D", "+");
            keySymbols.Add("E", "-");
            keySymbols.Add("F", "/");
            keySymbols.Add("G", "<");
            keySymbols.Add("H", ">");
            keySymbols.Add("I", "=");
            keySymbols.Add("J", "*");
            keySymbols.Add("K", "(");
            keySymbols.Add("L", ")");
            keySymbols.Add("M", "{");
            keySymbols.Add("N", "[");
            keySymbols.Add("O", "]");
            keySymbols.Add("P", "}");
            keySymbols.Add("Q", "1");
            keySymbols.Add("R", "2");
            keySymbols.Add("S", "3");
            keySymbols.Add("T", "4");
            keySymbols.Add("U", "5");
            keySymbols.Add("W", "6");
            keySymbols.Add("X", "7");
            keySymbols.Add("Y", "8");
            keySymbols.Add("Z", "0");
            Console.WriteLine("Enter the task number (1.4/1.5/1.6/2.1/2.6)");
            Console.WriteLine("To end enter -stop-");
            
        }

        //--------Task_1_4
        public static void Task_1_4(string text)
        {
            Console.WriteLine("Input text: -" + text);
            var wordsWithQ = new List<string>();
            string[] words = text.Split(' ');
            foreach (var word in words)
            {
                if (word.Contains("q"))
                {
                    wordsWithQ.Add(word);
                }
            }

            Console.WriteLine("Result task_1_4: - ");
            // output in console
            foreach (var word in wordsWithQ)
            {
                Console.WriteLine(word);
            }
        }

        //--------Task_1_5
        public static void Task_1_5(string text)
        {
            Console.WriteLine("Input text: - "+ text);

            int kCount = 0;
            string firstWord = text.Split(' ')[0];
            char[] symbols = firstWord.ToArray();
            foreach (var symbol in symbols)
            {
                if (symbol.ToString() == "k")
                {
                    kCount += 1;
                }
            }

            //Output in console
            Console.WriteLine("Result task_1_5: - "+kCount);
        }

        //--------Task_1_6
        public static void Task_1_6(string text)
        {
            Console.WriteLine("Input text: -" + text);

            string pattern = "\\(.*?\\) ?";
            string target = "";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, target);
            Console.WriteLine("Result task_1_6: - "+result);
        }

        //Method for Task 2_1 and 2_6
        public static string ReadTextFromFile()
        {
            string path = @"D:\C\Projects\TestCode\TestCode\someText.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine("Text from file: - "+text);
            return text;
        }

        // ----Task_2_1
        public static string EncryptText_Task_2_1(string text)
        {
            char[] arrSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
            StringBuilder encryptText = new StringBuilder();
            char[] inputSymbols = text.ToArray();

            foreach (var symbol in inputSymbols)
            {
                for (int i = 0; i < arrSymbols.Length; i++)
                {
                    if (arrSymbols[i].ToString().ToLower() == symbol.ToString().ToLower())
                    {
                        if ((i + 4) < arrSymbols.Length)
                        {
                            encryptText.Append(arrSymbols[i + 4].ToString());
                            break;
                        }
                        else
                        {
                            int numItem = i + 4 - arrSymbols.Length;
                            encryptText.Append(arrSymbols[numItem].ToString());
                            break;
                        }
                    }
                    else
                    {
                        if (i == arrSymbols.Length - 1)
                        {
                            encryptText.Append(symbol.ToString());
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Result task_2_1 (encrypted text): - " +encryptText.ToString());
            return encryptText.ToString();
        }

        public static void DecryptText_Task_2_1(string text)
        {
            char[] arrSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();

            StringBuilder dencryptText = new StringBuilder();
            char[] inputSymbols = text.ToArray();

            foreach (var symbol in inputSymbols)
            {
                for (int i = 0; i < arrSymbols.Length; i++)
                {
                    if (arrSymbols[i].ToString().ToLower() == symbol.ToString().ToLower())
                    {
                        if ((i - 4) >= 0)
                        {
                            dencryptText.Append(arrSymbols[i - 4].ToString());
                            break;
                        }
                        else
                        {
                            int numItem = arrSymbols.Length + i - 4;
                            dencryptText.Append(arrSymbols[numItem].ToString());
                            break;
                        }
                    }
                    else
                    {
                        if (i == arrSymbols.Length - 1)
                        {
                            dencryptText.Append(symbol.ToString());
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Result task_2_1 (decrypted text): - " +dencryptText.ToString());
        }

        //-----Task 2_6
        public static string EncryptText_Task_2_6(string text, IDictionary<string, string> dictionary)
        {
            StringBuilder encryptText = new StringBuilder();
            char[] inputSymbols = text.ToArray();

            foreach (var symbol in inputSymbols)
            {
                foreach (var kvp in dictionary)
                {
                    if (kvp.Key.ToLower() == symbol.ToString().ToLower())
                    {
                        encryptText.Append(kvp.Value);
                        break;
                    }
                    else
                    {
                        var arrayOfAllKeys = dictionary.Keys.ToArray();
                        StringBuilder strOfAllKeys = new StringBuilder();
                        foreach (var key in arrayOfAllKeys)
                        {
                            strOfAllKeys.Append(key);
                        }

                        if (!strOfAllKeys.ToString().Contains(symbol.ToString().ToUpper()))
                        {
                            encryptText.Append(symbol.ToString());
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Result task_2_6 (encrypted text): - " +encryptText.ToString());
            return encryptText.ToString();
        }

        public static string DecryptText_Task_2_6(string text, IDictionary<string, string> dictionary)
        {
            StringBuilder dencryptText = new StringBuilder();
            char[] inputSymbols = text.ToArray();

            foreach (var symbol in inputSymbols)
            {
                foreach (var kvp in dictionary)
                {
                    if (kvp.Value.ToLower() == symbol.ToString().ToLower())
                    {
                        dencryptText.Append(kvp.Key);
                        break;
                    }
                    else
                    {
                        var arrayOfAllValues = dictionary.Values.ToArray();
                        StringBuilder strOfAllValues = new StringBuilder();
                        foreach (var v in arrayOfAllValues)
                        {
                            strOfAllValues.Append(v);
                        }

                        if (!strOfAllValues.ToString().Contains(symbol.ToString().ToUpper()))
                        {
                            dencryptText.Append(symbol.ToString());
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Result task_2_6 (decrypted text): - " +dencryptText.ToString());
            return dencryptText.ToString();
        }
    }
}