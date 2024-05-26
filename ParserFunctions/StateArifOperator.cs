namespace Parse
{
	public partial class Parser
	{
		private void StateArifOperator(string input, ref int position)
		{
			if (position >= input.Length)
			{
				errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 10", position, position, ErrorType.UnfinishedExpression));
				return;
			}

			int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова
			bool ArifOperMet = false;
			// Пропускаем пробелы до начала ключевого слова
			while (position < input.Length && (char.IsWhiteSpace(input[position])))
			{
				position++; // Продвигаем позицию на следующий символ
			}
			char currentSymbol;

			ParserError error = new ParserError("Ожидался арифметический оператор", keywordStartPos + 1, position + 1);

			while (position < input.Length && (!char.IsWhiteSpace(input[position]) && (input[position] != '\n' && input[position] != '}')))
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

				if (currentSymbol == '+' || currentSymbol == '-' || currentSymbol == '*' || currentSymbol == '/')
				{

					ArifOperMet = true;
					if (error.Value != string.Empty)
						errors.Add(error);
					_ = new ParserError("Ожидался арифметический оператор", keywordStartPos + 1, position + 1);
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
			if (!ArifOperMet)
			{
				errors.Add(new ParserError("Не найден арифметический оператор", keywordStartPos, position, ErrorType.UnfinishedExpression));
			}
		}
	}
}