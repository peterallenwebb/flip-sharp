using System;
using System.Collections.Generic;
using System.Linq;

namespace TextFlip
{
	public class TextFlip
	{
		private static Dictionary<char, char> FlipDict = 
			new Dictionary<char, char> () {
				{'a', '\u0250'},
				{'b', 'q'},
				{'c', '\u0254'},  
				{'d', 'p'},
				{'e', '\u01DD'},
				{'f', '\u025F'},
				{'g', 'b'},
				{'h', '\u0265'},
				{'i', '\u0131'},
				{'j', '\u0638'},
				{'k', '\u029E'},
				{'l', '\u05DF'},
				{'m', '\u026F'},
				{'n','u'},
				{'o', 'o'},
				{'p', 'd'},
				{'q', 'b'},
				{'r', '\u0279'},
				{'s', 's'},
				{'t', '\u0287'},
				{'u', 'n'},
				{'v', '\u028C'},
				{'w', '\u028D' },
				{'x', 'x'},
				{'y', '\u028E'},
				{'z', 'z'},
				{'[', ']'},
				{']', '['},
				{'(', ')' },
				{')', '(' },
				{'{', '}' },
				{'}', '{'},
				{'?', '\u00BF'},
				{'\u00BF','?'},
				{'!', '\u00A1'},
				{'.', '\u02D9'},
				{'_', '\u203E'},
				{';', '\u061B'},
				{'&', '⅋'},
				{'A', '∀'},
				{'B', 'q'},
				{'C', 'Ͻ'},
				{'D', 'ᗡ'},
        {'E', 'Ǝ'},
				{'F', 'Ⅎ'},
				{'G', 'ƃ'},
				{'H', 'H'},
				{'I', 'I'},
				{'J', 'ſ'},
				{'K', 'ʞ'},
				{'L', '˥'},
				{'M', 'W'},
				{'N', 'N'},
				{'O', 'O'},
				{'P', 'Ԁ'},
				{'Q', 'Ὁ'},
				{'R', 'ᴚ'},
				{'S', 'S'},
				{'T', '⊥'},
				{'U', '∩'},
				{'V', 'Λ'},
				{'W', 'M'},
				{'X', 'X'},
				{'Y', 'ʎ'},
				{'Z', 'Z'},
				{'0', '0'},
				{'1', '⇂'},
				{'2', 'ᄅ'},
				{'3', 'Ɛ'}, 
				{'4', 'ᔭ'}, 
				{'5', 'S'},
				{'6', '9'},
				{'7','Ɫ'},
				{'8', '8'},
				{'9', '6'}
			};

		private static char TryToFlip(char c)
		{
			if (FlipDict.ContainsKey(c))
				return FlipDict[c];
			else
				return c;
		}

		public static string Flip(string text)
		{
			var origChars = text.ToCharArray();
			var flipChars = origChars.Select(c => TryToFlip(c))
				                     .Reverse();

			return new String(flipChars.ToArray());
		}
	}
}
