public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWords(int numberToHide)
        {
            var random = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                var wordIndex = random.Next(0, _words.Count);
                _words[wordIndex].Hide();
            }
        }

        public string GetDisplayText()
        {
            var displayText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
            return $"{_reference.GetDisplayText()}: {displayText}";
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }