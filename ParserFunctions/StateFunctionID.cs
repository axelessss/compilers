namespace Parse
{
	public partial class Parser
	{
		private void StateFunctionID(string input, ref int position) //3
		{
            int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова
            bool FuncIDMet = false;
            bool IsNotFirstSymbol = false;
            char currentSymbol;
            if (position >= input.Length)
            {
                errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 2", position, position, ErrorType.UnfinishedExpression));
                return;
            }

            // Пропускаем пробелы до начала ключевого слова
            while (position < input.Length && char.IsWhiteSpace(input[position]))
            {
                position++; // Продвигаем позицию на следующий символ
            }

            ParserError error = new ParserError("Ожидался идентификатор функции", keywordStartPos + 1, position + 1);

            while (position < input.Length && input[position] != '(' && !char.IsWhiteSpace(input[position])) // $ мб убрать
            {
                if (position >= input.Length)
                {
                    if (error.Value != string.Empty)
                        errors.Add(error);
                    else
                        errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
                    return;
                }

                if (input[position] == ',') 
                {
                    position = keywordStartPos;
                    if (error.Value != string.Empty)
                        errors.Add(error);
                    else
                        errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
                    return;
                }
                currentSymbol = input[position];

                if (!IsNotFirstSymbol && (char.IsLetter(currentSymbol) || currentSymbol == '_'))

                {
                    FuncIDMet = true;
                    IsNotFirstSymbol = true;
                    if (error.Value != string.Empty)
                        errors.Add(error);
                    error = new ParserError("Ожидался идентификатор функции", position, position, ErrorType.UnfinishedExpression);
                }
                else if ((char.IsLetter(currentSymbol) || char.IsDigit(currentSymbol) || currentSymbol == '_') && IsNotFirstSymbol)
                {
                    if (error.Value != string.Empty)
                        errors.Add(error);
                    error = new ParserError("Ожидался идентификатор функции", position, position, ErrorType.UnfinishedExpression);
                }
                else
                {
                    error.Value += input[position];
                    error.EndIndex = position + 1;
                }

                position++;
            }

            if (!FuncIDMet)
            {
                errors.Add(new ParserError("Не найден идентификатор функции", keywordStartPos, position, ErrorType.UnfinishedExpression));
            }
        }
	}
}
