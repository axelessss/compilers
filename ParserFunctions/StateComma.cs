namespace Parse
{
	public partial class Parser
	{
		private void StateComma(string input, ref int position)
		{
			if (position >= input.Length)
			{
				errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 5", position, position, ErrorType.UnfinishedExpression));
				return;
			}
			int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова
			bool CommaMet = false;
			// Пропускаем пробелы до начала ключевого слова
			while (position < input.Length && char.IsWhiteSpace(input[position]))
			{
				position++; // Продвигаем позицию на следующий символ
			}
			char currentSymbol;

			ParserError error = new ParserError("Ожидалась левая скобка", keywordStartPos + 1, position + 1);

			while (position < input.Length && (!char.IsWhiteSpace(input[position]) && input[position] != '$' && input[position] != ')'))
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

				if (currentSymbol == ',')
				{

					CommaMet = true;
					if (error.Value != string.Empty)
						errors.Add(error);
					error = new ParserError("Ожидалась запятая", keywordStartPos + 1, position + 1);
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

			if (!CommaMet)
			{
				errors.Add(new ParserError("Не найдена запятая", keywordStartPos, position, ErrorType.UnfinishedExpression));
			}


		}
	}
}