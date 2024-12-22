﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizForm : DevExpress.XtraEditors.XtraForm
    {
        private List<(string Word, string Meaning)> wordsList;
        private (string Word, string Meaning)? currentWord;
        private int lastColorIndex = -1;
        private List<System.Drawing.Color> colorList = new List<System.Drawing.Color>
        {
            // DevExpress Renk Paleti
            ColorTranslator.FromHtml("#1976D2"), // Primary Color (DevExpress Blue)
            ColorTranslator.FromHtml("#388E3C"), // Success Color (Green)
            ColorTranslator.FromHtml("#D32F2F"), // Danger Color (Red)
            ColorTranslator.FromHtml("#0288D1"), // Info Color (Light Blue)

            // Yeni eklenen renkler
            ColorTranslator.FromHtml("#0097A7"), // Teal Blue (daha derin mavi)
            ColorTranslator.FromHtml("#0288D1"), // Bright Blue (çok belirgin mavi)
            ColorTranslator.FromHtml("#1565C0"), // Medium Blue (orta mavi)
            ColorTranslator.FromHtml("#5C6BC0"), // Indigo (morumsu mavi)
            ColorTranslator.FromHtml("#7B1FA2"), // Deep Purple (mor)
            ColorTranslator.FromHtml("#FFB300"), // Amber (sarımsı turuncu)
            ColorTranslator.FromHtml("#8E24AA"), // Deep Pink (derin pembe)
            ColorTranslator.FromHtml("#43A047"), // Light Green (açık yeşil)
            ColorTranslator.FromHtml("#F57C00"), // Orange (turuncu)
        };
        private Random random;


        public QuizForm(string filePath)
        {
            InitializeComponent();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("JSON dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                MessageBox.Show("JSON dosyası boş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var wordData = JsonSerializer.Deserialize<WordList>(json);

                if (wordData == null || wordData.words == null || !wordData.words.Any())
                {
                    throw new Exception("JSON verisi geçersiz veya boş.");
                }

                wordsList = wordData.words.Select(w => (w.word, w.meaning)).ToList();
            }
            catch (JsonException ex)
            {
                XtraMessageBox.Show($"JSON deserialization hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wordsList = new List<(string Word, string Meaning)>();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Beklenmeyen hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wordsList = new List<(string Word, string Meaning)>();
            }

            lblAll.Text = wordsList.Count.ToString();
            random = new Random();
            LoadNextWord();
        }

        private void LoadNextWord()
        {
            if (wordsList.Count == 0)
            {
                XtraMessageBox.Show("Tüm kelimeler bitti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentWord = null;
                textEdit1.Enabled = false;
                return;
            }
            int index = random.Next(wordsList.Count);
            currentWord = wordsList[index];
            wordsList.RemoveAt(index);
            btnWord.Text = currentWord.Value.Word;
            textEdit1.Text = "";
            int newColorIndex;
            do
            {
                newColorIndex = random.Next(colorList.Count);
            } while (newColorIndex == lastColorIndex);

            lastColorIndex = newColorIndex; 
            btnWord.Appearance.BackColor = colorList[newColorIndex];
        }
        private void textEdit1_KeyUp(object sender, KeyEventArgs e)
        {
            if (currentWord != null && textEdit1.Text.Trim().ToLower() == currentWord.Value.Meaning.ToLower())
            {
                lblSay.Text = (Convert.ToInt64(lblSay.Text) + 1).ToString();
                LoadNextWord();
            }

        }
    }
    public class WordList
    {
        public List<WordItem> words { get; set; }
    }

    public class WordItem
    {
        public string word { get; set; }
        public string meaning { get; set; } 
    }
}