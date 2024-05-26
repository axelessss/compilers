namespace Parse
{
	public partial class Parser
	{
		private void StateReturn(string input, ref int position)
		{
			string expectedKeyword = "return";
			int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова

			if (position >= input.Length)
			{
				errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 9", position, position));
				return;
			}

			// Пропускаем пробелы до начала ключевого слова
			while (position < input.Length && char.IsWhiteSpace(input[position]))
			{
				position++; // Продвигаем позицию на следующий символ
			}

			foreach (char c in expectedKeyword)
			{
				ParserError error = new ParserError("Ожидалось ключевое слово \"return\"", keywordStartPos + 1, position + 1);
				while (true)
				{
                    if (input[position] == '+' || input[position] == '-' || input[position] == '*' || input[position] == '/')
                    {
                        position = keywordStartPos;
                        errors.Add(new ParserError("Отсутствует ключевое слово return", keywordStartPos, position, ErrorType.UnfinishedExpression));
                        return;
                    }

                    if (position >= input.Length || char.IsWhiteSpace(input[position]) || input[position] == '\n' || input[position] == '}')
					{
						if (error.Value != string.Empty)
							errors.Add(error);
						else
							errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
						return;
					}
					char currentSymbol = input[position];

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