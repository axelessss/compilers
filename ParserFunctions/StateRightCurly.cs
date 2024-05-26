namespace Parse
{
	public partial class Parser
	{
		private void StateRightCurly(string input, ref int position)
		{
			if (position >= input.Length)
			{
				errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 13", position, position, ErrorType.UnfinishedExpression));
				return;
			}
			LastState = true;
			int keywordStartPos = position; // Запоминаем начальную позицию
			bool RightCurlyMet = false;

			// Пропускаем пробелы до начала ключевого слова
			while (position < input.Length && char.IsWhiteSpace(input[position]))
			{
				position++; // Продвигаем позицию на следующий символ
			}

			char currentSymbol;
			ParserError error = new ParserError("Ожидалась правая фигурная скобка", keywordStartPos + 1, position + 1);

			while (position < input.Length)
			{
				if (position >= input.Length)
				{
					if (error.Value != string.Empty)
						errors.Add(error);
					errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
					return;
				}

				currentSymbol = input[position];

				if (currentSymbol == '}')
				{
					RightCurlyMet = true;
					if (error.Value != string.Empty)
						errors.Add(error);
					_ = new ParserError("Ожидалась правая фигурная скобка", keywordStartPos + 1, position + 1);
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

			if (!RightCurlyMet)
			{
				errors.Add(new ParserError("Не найдена правая фигурная скобка", keywordStartPos, keywordStartPos + 1, ErrorType.UnfinishedExpression));
			}
		}
	}
}