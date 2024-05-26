namespace Parse
{
	public partial class Parser
	{
		private void StateSecondArg(string input, ref int position)
		{
			int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова


			if (position >= input.Length)
			{
				errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось", position, position, ErrorType.UnfinishedExpression));
				return;
			}

			// Пропускаем пробелы до начала ключевого слова
			while (position < input.Length && (char.IsWhiteSpace(input[position]) || input[position] == '\n'))
			{
				position++; // Продвигаем позицию на следующий символ
			}

			bool IsNotFirstSymbol = false;
			bool IsNotMissingSymbol = false;
			char currentSymbol;
			ParserError error = new ParserError("Ожидалась переменная", keywordStartPos + 1, position + 1);

			while (position < input.Length && (!char.IsWhiteSpace(input[position]) && input[position] != '\n'))
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

				if (char.IsLetter(currentSymbol) && !IsNotFirstSymbol)
				{
					IsNotFirstSymbol = true;
					if (error.Value != string.Empty)
						errors.Add(error);
					else
						error = new ParserError("Ожидалась переменная", position, position);
				}
				else if (IsNotFirstSymbol && !IsNotMissingSymbol && (char.IsLetter(currentSymbol) || currentSymbol == '_'))
				{
					IsNotMissingSymbol = true;
					if (error.Value != string.Empty)
						errors.Add(error);
					else
						error = new ParserError("Ожидалась переменная", position, position);
				}
				else if (IsNotFirstSymbol && (char.IsLetter(currentSymbol) || char.IsDigit(currentSymbol) || currentSymbol == '_'))
				{
					if (error.Value != string.Empty)
						errors.Add(error);
					else
						error = new ParserError("Ожидалась переменная", position, position);
				}

                else if (IsNotFirstSymbol && !(char.IsLetter(currentSymbol) || char.IsDigit(currentSymbol) || currentSymbol == '_' || currentSymbol == '\n' || char.IsWhiteSpace(currentSymbol)))
                {
                    if (error.Value != string.Empty)
                        errors.Add(error);
                    else
                        errors.Add(new ParserError("Ожидалась переменная", position, position));
                }

                else
				{
					error.Value += input[position];
					error.EndIndex = position + 1;
				}

				position++;

				// Если цикл завершился из-за пробела, но символ '$' не был считан, продолжаем цикл
				if (position < input.Length && char.IsWhiteSpace(input[position]) && !IsNotFirstSymbol)
				{
					position++; // Продвигаем позицию на следующий символ
				}
			}
		}
	}
}