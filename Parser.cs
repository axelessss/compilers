using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scanner;
using static Scanner.Scan;
using static System.Net.Mime.MediaTypeNames;

namespace Parse
{
    public partial class Parser
    {

        public string input;
        public int position;
        public List<ParserError> errors;
        public bool IsLeftPartofParMet = false; // для скобок
        public bool IsLeftPartofCurlyMet = false; // для фигурных скобок
        public bool LastState = false; // для фигурных скобок
        public string errors_list;

        public string ErrorsList { get => errors_list; }
        public Parser(string input)
        {
            this.input = input;
            position = 0;
            errors = new List<ParserError>(); // Создаем список ошибок в конструкторе парсера

        }
        public List<ParserError> Parse()
        {
            while (position < input.Length)
            {
                StateKeywordFunction(input, ref position);
                StateFunctionID(input, ref position);
                StateLeftParenthesis(input, ref position);
                StateFirstArgID(input, ref position);
                StateComma(input, ref position);
                StateSecondArgID(input, ref position);
                StateInt(input, ref position);
                StateRightParenthesis(input, ref position);
                StateInt(input, ref position);
                StateLeftCurly(input, ref position);
                StateReturn(input, ref position);
                StateFirstArg(input, ref position);
                StateArifOperator(input, ref position);
                StateSecondArg(input, ref position);
                StateRightCurly(input, ref position);
                if (LastState) { break; }
            }

            if (errors.Count > 0)
            {
                int ernum = 1;
                errors_list += "Список ошибок:";
                foreach (ParserError error in errors)
                {
                    errors_list += "\n" + ernum.ToString() + " - " + error.Message + " - " + error.Position;
                    ernum++;
                }
            }

            else
                errors_list = "Ошибок нет";
            return errors;
        }
    }
}

