using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbsoluteCipher
{
    public partial class Form1 : Form
    {
        private Dictionary<char, string> cyrillicMap = new Dictionary<char, string>();
        private Dictionary<string, char> reverseMap = new Dictionary<string, char>();

        private readonly string[] symbols = {
            "/ *", "* /", "/ /", "* *", "\\ \\", "\\ /", "/ \\", "+ +", "- -", "[ *",
            "* ]", "[ ^", "^ ]", "{ #", "# }", "< >", "> <", "~ \\", "+ /", "/ -",
            "= %", "& ?", "! |", "( )", "_ ~", "@ #", "$ $", "^ ^", "& &", "| |",
            ": :", "; ;", "\" \""
        };

        private readonly char[] alphabet = "ÀÁÂÃÄÅ¨ÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞß".ToCharArray();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < Math.Min(alphabet.Length, symbols.Length); i++)
            {
                cyrillicMap.Add(alphabet[i], symbols[i]);
                reverseMap.Add(symbols[i], alphabet[i]);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.ToUpper();
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (cyrillicMap.ContainsKey(c))
                    result.Append(cyrillicMap[c] + " ");
                else
                    result.Append(c);
            }
            txtOutput.Text = result.ToString().Trim();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string[] parts = txtInput.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach (string part in parts)
            {
                if (reverseMap.ContainsKey(part))
                    result.Append(reverseMap[part]);
                else
                    result.Append(part);
            }
            txtOutput.Text = result.ToString();
        }

        private void btnAddNoise_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOutput.Text)) return;
            txtOutput.Text = string.Join("#", txtOutput.Text.ToCharArray());
        }

        private void btnClearNoise_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text.Replace("#", "");
        }
    }
}