namespace Parse
{
	public partial class Parser
	{
		private void StateLeftCurly(string input, ref int position)
		{
            int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова
            if (position >= input.Length)
            {
                errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 8", position, position, ErrorType.UnfinishedExpression));
                return;
            }
            // Пропускаем пробелы до начала ключевого слова
            while (position < input.Length && (char.IsWhiteSpace(input[position])))
            {
                position++; // Продвигаем позицию на следующий символ
            }

            char currentSymbol;

            ParserError error = new ParserError("Ожидалась левая фигурная скобка", keywordStartPos + 1, position + 1);

            while (position < input.Length && !char.IsLetter(input[position]) && !char.IsDigit(input[position])) //  input[position]!=' '
            {

                if (position >= input.Length)
                {
                    if (error.Value != string.Empty)
                        errors.Add(error);
                    errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
                    return;
                }

                currentSymbol = input[position];

                if (currentSymbol == '{')
                {
                    IsLeftPartofCurlyMet = true;
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

            // Если левая скобка не была найдена, добавляем сообщение об ошибке
            if (!IsLeftPartofCurlyMet)
            {
                errors.Add(new ParserError("Не найдена левая фигурная скобка", keywordStartPos, position - 1, ErrorType.UnfinishedExpression));
            }


        }
	}
}