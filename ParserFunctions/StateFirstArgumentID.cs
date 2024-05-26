namespace Parse
{
	public partial class Parser
	{
		private void StateFirstArgID(string input, ref int position) //5
		{
			int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова

			if (position >= input.Length)
			{
				errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 4", position, position, ErrorType.UnfinishedExpression));
				return;
			}

			// Пропускаем пробелы до начала ключевого слова
			while (position < input.Length && (char.IsWhiteSpace(input[position])))
			{
				position++; // Продвигаем позицию на следующий символ
			}

			bool IsNotFirstSymbol = false;
			bool IsNotMissingSymbol = false;
			char currentSymbol;
			ParserError error = new ParserError("Ожидался аргумент функции", keywordStartPos + 1, position + 1);

			while (position < input.Length && (!char.IsWhiteSpace(input[position]) && input[position] != ',' && input[position] != ')'))
			{
				if (position >= input.Length)
				{
					if (error.Value != string.Empty)
						errors.Add(error);
					errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
					return;
				}

				currentSymbol = input[position];

				if (char.IsLetter(currentSymbol) && !IsNotFirstSymbol)
				{
					IsNotFirstSymbol = true;
					if (error.Value != string.Empty)
						errors.Add(error);
					error = new ParserError("Ожидался аргумент функции", position, position);
				}

				else if (IsNotFirstSymbol && !IsNotMissingSymbol && (char.IsLetter(currentSymbol) || currentSymbol == '_'))
				{
					IsNotMissingSymbol = true;
					if (error.Value != string.Empty)
						errors.Add(error);
					error = new ParserError("Ожидался аргумент функции", position, position);
				}
				else if (IsNotFirstSymbol && IsNotMissingSymbol && (char.IsLetter(currentSymbol) || char.IsDigit(currentSymbol) || currentSymbol == '_'))
				{
					if (error.Value != string.Empty)
						errors.Add(error);
					error = new ParserError("Ожидался аргумент функции", position, position+1);
				}                

				else if(IsNotFirstSymbol && !(char.IsLetter(currentSymbol) || char.IsDigit(currentSymbol) || currentSymbol == '_' || currentSymbol == '\n' || char.IsWhiteSpace(currentSymbol)))
				{
					if (error.Value != string.Empty)
						errors.Add(error);
					else
						errors.Add(new ParserError("Ожидался аргумент функции", position, position));
                }

                else
				{
					error.Value += input[position];
					error.EndIndex = position + 1;
				}

				position++;
			}

			if (!IsNotFirstSymbol && !IsNotMissingSymbol)
			{
				errors.Add(error);
			}


			/*if (!IsNotMissingSymbol && IsNotFirstSymbol)
			{
				errors.Add(new ParserError("Незаконченный аргумент функции", keywordStartPos, position, ErrorType.UnfinishedExpression));
			}*/


		}
	}
}