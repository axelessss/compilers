namespace Parse
{
	public partial class Parser
	{
		private void StateKeywordFunction(string input, ref int position)
		{
            string expectedKeyword = "func";
            int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова
            char currentSymbol;
            // Проверка на наличие символов во входной строке
            if (position >= input.Length)
            {
                errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 1", position, position));
                return;
            }

            // Пропускаем пробелы до начала ключевого слова
            while (position < input.Length && (char.IsWhiteSpace(input[position]) || input[position] == '\n'))            
                position++; // Продвигаем позицию на следующий символ
            

            // Проверяем, начинается ли ключевое слово "function" с текущей позиции
            foreach (char c in expectedKeyword)
            {
                ParserError error = new ParserError("Ожидалось ключевое слово \"func\"", keywordStartPos + 1, position + 1);
                while (true)
                {
                    if (input[position] == '(') 
                    {
                        position = keywordStartPos;
                        errors.Add(new ParserError("Отсутствует ключевое слово func", keywordStartPos, position, ErrorType.UnfinishedExpression));
                        return;
                    }

                    if (position >= input.Length)
                    {                       
                        errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
                        return;
                    }

                    if (char.IsWhiteSpace(input[position]))
                    {
                        errors.Add(error);
                        return;
                    }

                    currentSymbol = input[position];

                    if (currentSymbol == c)
                    {
                        if (error.Value != string.Empty)
                            errors.Add(error);
                        position++;
                        break;
                    }
                    else
                    {
                        error.Value += input[position];
                        error.EndIndex = position + 1;
                    }
                    position++; // Переходим к следующему символу
                }

            }
        }
	}
}