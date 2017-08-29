using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace SpeechApp
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recognitionEngine = new SpeechRecognitionEngine();
        SpeechRecognitionEngine recognitionEngine1 = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
            recognitionEngine.SetInputToDefaultAudioDevice();
            recognitionEngine.SpeechRecognized += (s, args) =>
            {
                foreach (RecognizedWordUnit word in args.Result.Words)
                {
                    if (word.Confidence > 0.5f)
                    {

                        switch (word.Text)
                        {
                            case "akar":
                                richTextBox1.Text += "া";
                                break;
                            case "roshikar":
                                richTextBox1.Text += "ি";
                                break;
                            case "dirgikar":
                                richTextBox1.Text += "ী";
                                break;
                            case "roshuukar":
                                richTextBox1.Text += "ু";
                                break;
                            case "dirguukar":
                                richTextBox1.Text += "ূ";
                                break;
                            case "ekar":
                                richTextBox1.Text += "ে";
                                break;
                            case "oikar":
                                richTextBox1.Text += "ৈ";
                                break;
                            case "okar":
                                richTextBox1.Text += "ো";
                                break;
                            case "ouukar":
                                richTextBox1.Text += "ৌ";
                                break;
                            case "rikar":
                                richTextBox1.Text += "ৃ";
                                break;
                            case "shoreo":
                                richTextBox1.Text += "অ";
                                break;
                            case "shariaa":
                                richTextBox1.Text += "আ";
                                break;
                            case "roshoi":
                                richTextBox1.Text += "ই";
                                break;
                            case "dirgoi":
                                richTextBox1.Text += "ঈ";
                                break;
                            case "roshou":
                                richTextBox1.Text += "উ";
                                break;
                            case "dirgou":
                                richTextBox1.Text += "ঊ";
                                break;
                            case "eeh":
                                richTextBox1.Text += "এ";
                                break;
                            case "oih":
                                richTextBox1.Text += "ঐ";
                                break;
                            case "own":
                                richTextBox1.Text += "ও";
                                break;
                            case "ouu":
                                richTextBox1.Text += "ঔ";
                                break;
                            case "rin":
                                richTextBox1.Text += "ঋ";
                                break;
                            case "koh":
                                richTextBox1.Text += "ক";
                                break;
                            case "khoh":
                                richTextBox1.Text += "খ";
                                break;
                            case "goh":
                                richTextBox1.Text += "গ";
                                break;
                            case "gawh":
                                richTextBox1.Text += "ঘ";
                                break;
                            case "umo":
                                richTextBox1.Text += "ঙ";
                                break;
                            case "cho":
                                richTextBox1.Text += "চ";
                                break;
                            case "chho":
                                richTextBox1.Text += "ছ";
                                break;
                            case "borgijaw":
                                richTextBox1.Text += "জ";
                                break;
                            case "jawh":
                                richTextBox1.Text += "ঝ";
                                break;
                            case "neo":
                                richTextBox1.Text += "ঞ";
                                break;
                            case "boroto":
                                richTextBox1.Text += "ট";
                                break;
                            case "Toh":
                                richTextBox1.Text += "ঠ";
                                break;
                            case "doll":
                                richTextBox1.Text += "ড";
                                break;
                            case "dho":
                                richTextBox1.Text += "ঢ";
                                break;
                            case "moddenno":
                                richTextBox1.Text += "ণ";
                                break;
                            case "halkato":
                                richTextBox1.Text += "ত";
                                break;
                            case "halkatho":
                                richTextBox1.Text += "থ";
                                break;
                            case "chikondo":
                                richTextBox1.Text += "দ";
                                break;
                            case "dhawl":
                                richTextBox1.Text += "ধ";
                                break;

                            case "dontono":
                                richTextBox1.Text += "ন";
                                break;
                            case "pole":
                                richTextBox1.Text += "প";
                                break;
                            case "fo":
                                richTextBox1.Text += "ফ";
                                break;
                            case "bone":
                                richTextBox1.Text += "ব";
                                break;
                            case "bhone":
                                richTextBox1.Text += "ভ";
                                break;
                            case "mo":
                                richTextBox1.Text += "ম";
                                break;
                            case "ontojo":
                                richTextBox1.Text += "য";
                                break;
                            case "raw":
                                richTextBox1.Text += "র";
                                break;
                            case "lawn":
                                richTextBox1.Text += "ল";
                                break;
                            case "matrahinsho":
                                richTextBox1.Text += "শ";
                                break;
                            case "talobbosho":
                                richTextBox1.Text += "শ";
                                break;
                            case "petkatasho":
                                richTextBox1.Text += "ষ";
                                break;
                            case "dontosho":
                                richTextBox1.Text += "স";
                                break;
                            case "ho":
                                richTextBox1.Text += "হ";
                                break;
                            case "doshunoro":
                                richTextBox1.Text += "ড়";
                                break;
                            case "dhoshunoro":
                                richTextBox1.Text += "ঢ়";
                                break;
                            case "ontostho":
                                richTextBox1.Text += "য়";
                                break;
                            case "khondoto":
                                richTextBox1.Text += "ৎ";
                                break;
                            case "oneshar":
                                richTextBox1.Text += "ং";
                                break;
                            case "bishorgo":
                                richTextBox1.Text += "ঃ";
                                break;
                            case "sondrobind":
                                richTextBox1.Text += "ঁ";
                                break;
                            case "jofola":
                                richTextBox1.Text += "্য";
                                break;
                            case "rofola":
                                richTextBox1.Text += "্র";
                                break;
                            case "Muchun":
                                if (richTextBox1.Text.Length == 0)
                                {
                                    richTextBox1.Text += richTextBox1.Text;
                                }
                                else
                                {
                                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
                                }
                                break;
                            case "hoshonto":
                                richTextBox1.Text += "্";
                                break;
                            case "dari":
                                richTextBox1.Text += "l";
                                break;
                            case "coma":
                                richTextBox1.Text += ",";
                                break;
                            case "bissoi":
                                richTextBox1.Text += "!";
                                break;
                            case "prosno":
                                richTextBox1.Text += "?";
                                break;
                            case "biroti":
                                richTextBox1.Text += " ";
                                break;
                            case "notunline":
                                richTextBox1.Text += Environment.NewLine;
                                break;
                            

                        }
                    }
                }
            };
            Grammar g = new Grammar("Grammar.xml", "command1");
            recognitionEngine.LoadGrammar(g);
            recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
        
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "বন্ধ")
            {
                recognitionEngine.RecognizeAsyncStop();
                button1.Text = "চালু";
            }
            else
            {
                recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
                button1.Text = "বন্ধ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            recognitionEngine.RecognizeAsyncStop();
            recognitionEngine1.SetInputToDefaultAudioDevice();
            recognitionEngine1.SpeechRecognized += (s, args) =>
                {
                    foreach (RecognizedWordUnit word in args.Result.Words)
                    {
                        if (word.Confidence > 0.5f)
                        {
                            switch (word.Text)
                            {
                                case "Gonit":
                                    Process.Start("calc.exe");
                                    break;
                                case "notkhata":
                                    Process.Start("notepad.exe");
                                    break;
                                case "chobiakbo":
                                    Process.Start("mspaint.exe");
                                    break;
                                case "netchalabo":
                                    Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe");
                                    break;
                                case "ganshunbo":
                                    Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe");
                                    break;
                                case "likhtechai":
                                    Process.Start(@"C:\Program Files\Windows NT\Accessories\wordpad.exe");
                                    break;
                                case "shobdokhujbo":
                                    Process.Start(@"C:\Program Files(x86)\B_dictionary\Dictionary.exe");
                                    break;
                                case "shuvobidai":
                                    ProcessStartInfo startinfo = new ProcessStartInfo("shutdown.exe", "-s");
                                    Process.Start(startinfo);
                                    break;
                            }
                        }
                    }
                };
                Grammar g = new Grammar("Grammar.xml", "command2");
                recognitionEngine1.LoadGrammar(g);
                recognitionEngine1.RecognizeAsync(RecognizeMode.Multiple);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = true;
            recognitionEngine1.RecognizeAsyncStop();
            recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }
    }
    
}
