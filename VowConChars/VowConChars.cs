namespace VowCon
{
    public class VowConChars
    {
        private string VowelArray = "уеёыаоэяию";
        private string ConsonantArray = "йцкнгшщзхфвпрлджчсмтб";        
        public string Text { set; get; }

        public VowConChars()
        {            
            Text = "";
        }

        public VowConChars(string Text)
        {            
            this.Text = Text;
        }

        public async Task<long> AsyncCountVowel()
        {
            CheckText();
            return await Task<long>.Run(() =>
            {
                long count = 0L;
                foreach(var symbol in Text)
                {
                    foreach (var vowelsymbol in VowelArray)
                    {
                        if(symbol == vowelsymbol || 
                           symbol == Char.ToUpper(vowelsymbol))
                        {
                            count++;
                            continue;
                        }
                    }
                }
                return count;
            });
        }

        public async Task<long> AsyncCountConsonant()
        {
            CheckText();
            return await Task<long>.Run(() =>
            {
                long count = 0L;
                foreach (var symbol in Text)
                {
                    foreach (var consonantsymbol in ConsonantArray)
                    {
                        if (symbol == consonantsymbol ||
                            symbol == Char.ToUpper(consonantsymbol))
                        {
                            count++;
                            continue;
                        }
                    }
                }
                return count;
            });
        }

        public async Task<long> FirmSign()
        {
            CheckText();
            return await Task<long>.Run(() =>
            {
                long count = 0L;
                foreach (var symbol in Text)
                {

                    if (symbol == 'ъ' ||
                        symbol == 'Ъ')
                    {
                        count++;                        
                    }
                    
                }
                return count;
            });
        }

        public async Task<long> SoftSign()
        {
            CheckText();
            return await Task<long>.Run(() =>
            {
                long count = 0L;
                foreach (var symbol in Text)
                {

                    if (symbol == 'ь' ||
                        symbol == 'Ь')
                    {
                        count++;
                    }

                }
                return count;
            });
        }

        private void CheckText()
        {
            if (string.IsNullOrEmpty(Text) ||
               string.IsNullOrWhiteSpace(Text))
            {
                throw new Exception("Слово пустое!");
            }
        }
    }
}