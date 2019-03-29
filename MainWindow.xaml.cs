/*
 *Noah Irving
 * 3rd March 29th 2019 
 * This Program turns abbreviations that teenagers use into proper english for adults
 */ 
  
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

namespace I_Speak_TXTMSG
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

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            string textInput = txtInput.Text;

            textInput = txtInput.Text.ToUpper();



/* all of this Replace coding replaces the Words (CU) with new stuff that adults understand (See You) */
            textInput = textInput.Replace("CU", "See You" +Environment.NewLine);
            textInput = textInput.Replace(":-)", "I'm happy" +Environment.NewLine);
            textInput = textInput.Replace(":-(", "I'm unhappy" +Environment.NewLine);
            textInput = textInput.Replace(";-)", "Wink" +Environment.NewLine);
            textInput = textInput.Replace(":-P", "Tongue Out" +Environment.NewLine);
            textInput = textInput.Replace("(~.~)", "Sleepy" +Environment.NewLine);
            textInput = textInput.Replace("TA", "totally awesome" +Environment.NewLine);
            textInput = textInput.Replace("CCC", "Canadian Computing Competition" +Environment.NewLine);
            textInput = textInput.Replace("CUZ", "because" +Environment.NewLine);
            textInput = textInput.Replace("TY", "Thank you " +Environment.NewLine);
            textInput = textInput.Replace("YW", " you're welcome" +Environment.NewLine);
            textInput = textInput.Replace("TTYL", "talk to you later" +Environment.NewLine);

            /*this code ends the program when TTYL is entered */
            lblOutput.Content = " " + textInput;
            if (txtInput.Text.Contains( "TTYL"))
            {
                Environment.Exit(0);
            }



           
        }
    }
   
}
    

