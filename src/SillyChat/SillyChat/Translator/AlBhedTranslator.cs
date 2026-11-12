using System.Collections.Generic;
using System.Text;

namespace SillyChat
{
    /// <summary>
    /// Translate to Al Bhed.
    /// </summary>
    public class AlBhedTranslator : BaseTranslator
    {
        private readonly Dictionary<char, char> mappedCharacters = new ();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlBhedTranslator"/> class.
        /// </summary>
        /// <param name="plugin">SillyChat plugin.</param>
        public AlBhedTranslator(ISillyChatPlugin plugin)
            : base(plugin)
        {
            this.SetCharacterMapping();
        }

        /// <inheritdoc />
        public override string Translate(string input)
        {
            StringBuilder output = new ();
            foreach (var c in input)
            {
                var lowerCh = char.ToLowerInvariant(c);
                if (this.mappedCharacters.ContainsKey(lowerCh))
                {
                    var outputCh = this.mappedCharacters[lowerCh];
                    output.Append(char.IsUpper(c) ? char.ToUpperInvariant(outputCh) : outputCh);
                }
                else
                {
                    output.Append(c);
                }
            }

            return output.ToString();
        }

        private void SetCharacterMapping()
        {
            this.mappedCharacters.Add('a', 'y');
            this.mappedCharacters.Add('b', 'p');
            this.mappedCharacters.Add('c', 'l');
            this.mappedCharacters.Add('d', 't');
            this.mappedCharacters.Add('e', 'a');
            this.mappedCharacters.Add('f', 'v');
            this.mappedCharacters.Add('g', 'k');
            this.mappedCharacters.Add('h', 'r');
            this.mappedCharacters.Add('i', 'e');
            this.mappedCharacters.Add('j', 'z');
            this.mappedCharacters.Add('k', 'g');
            this.mappedCharacters.Add('l', 'm');
            this.mappedCharacters.Add('m', 's');
            this.mappedCharacters.Add('n', 'h');
            this.mappedCharacters.Add('o', 'u');
            this.mappedCharacters.Add('p', 'b');
            this.mappedCharacters.Add('q', 'x');
            this.mappedCharacters.Add('r', 'n');
            this.mappedCharacters.Add('s', 'c');
            this.mappedCharacters.Add('t', 'd');
            this.mappedCharacters.Add('u', 'i');
            this.mappedCharacters.Add('v', 'j');
            this.mappedCharacters.Add('w', 'f');
            this.mappedCharacters.Add('x', 'q');
            this.mappedCharacters.Add('y', 'o');
            this.mappedCharacters.Add('z', 'w');
        }
    }
}
