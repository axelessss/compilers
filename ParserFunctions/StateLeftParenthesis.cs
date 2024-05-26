namespace Parse
{
	public partial class Parser
	{
		private void StateLeftParenthesis(string input, ref int position) //4
		{
            int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова
            if (position >= input.Length)
            {
                errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 3", position, position, ErrorType.UnfinishedExpression));
                return;
            }

            // Пропускаем пробелы до начала ключевого слова
            while (position < input.Length && char.IsWhiteSpace(input[position]))
            {
                position++; // Продвигаем позицию на следующий символ
            }
            char currentSymbol;

            ParserError error = new ParserError("Ожидалась левая скобка", keywordStartPos + 1, position + 1);

            while (position < input.Length && input[position] != '\n'  && !char.IsLetter(input[position]) && input[position] != '_')
            {

                if (position >= input.Length)
                {
                    if (error.Value != string.Empty)
                        errors.Add(error);
                    else
                        errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
                    return;
                }

                currentSymbol = input[position];

                if (currentSymbol == '(')
                {
                    IsLeftPartofParMet = true;
                    if (error.Value != string.Empty)
                        errors.Add(error);
                    _ = new ParserError("Ожидалась левая скобка", keywordStartPos + 1, position + 1);
                    position++;
                    break;
                }
                else
                {
                    error.Value += input[position];
                    error.EndIndex = position + 1;
                }

                position++;
            }

            if (!IsLeftPartofParMet)
            {
                errors.Add(new ParserError("Не найдена левая скобка", keywordStartPos, position, ErrorType.UnfinishedExpression));
            }

        }
	}
}
