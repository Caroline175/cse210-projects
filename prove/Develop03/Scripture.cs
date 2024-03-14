using System;
{
    class Scripture
    {
        private readonly ScriptureReference reference;
        private readonly List<Word> words;

        public Scripture(ScriptureReference reference, string text)
        {
            this.reference = reference;
            words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWord()
        {
            var hiddenWordIndices = Enumerable.Range(0, words.Count)
                                              .Where(i => !words[i].Hidden)
                                              .ToList();

            if (hiddenWordIndices.Any())
            {
                var randomIndex = new Random().Next(0, hiddenWordIndices.Count);
                words[randomIndex].Hide();
            }
        }

        public bool AllWordsHidden()
        {
            return words.All(word => word.Hidden);
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine(reference);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}



