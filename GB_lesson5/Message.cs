using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GB_lesson5
{
	static class Message
	{
		public static void PrintWordLessLength(string message, int maxLength)
		{
			string[] words = message.Split(' ', ',', '.', '!');

			Console.WriteLine("Слова, длина которых меньше, чем " + maxLength + ":");

			foreach(string word in words)
				if (word != "\n" && word.Length < maxLength) Console.WriteLine(word);

			Console.WriteLine();
		}

		public static string RemoveWordsEndSym(string message, char sym)
		{
			Regex regex = new Regex($@"(\s|,|!|.)(\w*){sym}\b");

			string newMessage = regex.Replace(message, "");

			return newMessage;
		}

		public static string FindMaxLengthWord(string message)
		{
			string[] words = message.Split(' ', ',', '.', '!');
			int maxLength = words[0].Length;
			int indexWord = 0;

			for(int i = 1; i < words.Length; i++)
			{
				if(words[i].Length > maxLength)
				{
					maxLength = words[i].Length;
					indexWord = i;
				}
			}

			return words[indexWord];
		}

		public static StringBuilder FindAllMaxLengthWords(string message)
		{
			StringBuilder newMessage = new StringBuilder();

			string[] words = message.Split(' ', ',', '.', '!');
			int maxLength = FindMaxLengthWord(message).Length;

			foreach(string word in words)
				if (word.Length == maxLength) newMessage.Append(word + " ");

			return newMessage;
		}

		public static Dictionary<string, int> TextFrequencyAnalysis(string[] templateWords, string message)
		{
			Dictionary<string, int> frequencyWords = new Dictionary<string, int>();

			foreach (string templateWord in templateWords)
				frequencyWords.Add(templateWord, 0);

			string[] words = message.Split(' ', ',', '.', '!');

			foreach(string word in words)
				if (frequencyWords.ContainsKey(word)) frequencyWords[word]++;

			return frequencyWords;
		}
	}
}