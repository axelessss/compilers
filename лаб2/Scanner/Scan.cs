using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanner
{
    public class Scan
    {
        private int code;
        private string input;
        private string text;
        Dictionary<string, string> parts = new Dictionary<string, string>();

        public struct Lex_Data
        {
            public int code;
            public int line;
            public int chr_num_start;
            public int chr_num_end;
            public string lex;
            public string identifier;
        }

        public List<Lex_Data> data = new List<Lex_Data>();

        public Scan(string input)
        {
            this.input = input;
        }

        public string Text
        {
            get => text;
        }
       
        public bool IsOperator(string text)
        {
            switch (text)
            {
                case "const":
                    this.code = 11;
                    break;

                case "func":
                    this.code = 12;
                    break;

                case "return":
                    this.code = 13;
                    break;

                case "var":
                    this.code = 14;
                    break;

                case "true":
                    this.code = 15;
                    break;

                case "false":
                    this.code = 16;
                    break;

                default:
                    return false;
            }       
            return true;
        }

        public bool IsDataType(string text)
        {
            switch (text)
            {
                case "int":
                    this.code = 1;
                    break;

                case "float32":
                    this.code = 2;
                    break;

                case "float64":
                    this.code = 3;
                    break;

                case "complex32":
                    this.code = 4;
                    break;

                case "complex64":
                    this.code = 5;
                    break;

                case "bool":
                    this.code = 6;
                    break;

                case "string":
                    this.code = 8;
                    break;

                default:
                    return false;
            }
            return true;
        }

       
        public bool IsArithmOperator(string text)
        {
            switch (text)
            {
                case "+":
                    this.code = 21;
                    break;

                case "-":
                    this.code = 22;
                    break;

                case "*":
                    this.code = 23;
                    break;

                case "/":
                    this.code = 24;
                    break;

                case "%":
                    this.code = 25;
                    break;

                case "==":
                    this.code = 26;
                    break;

                case "!":
                    this.code = 27;
                    break;

                case "<":
                    this.code = 28;
                    break;

                case "<=":
                    this.code = 29;
                    break;

                case ">":
                    this.code = 30;
                    break;

                case ">=":
                    this.code = 31;
                    break;

                case "!=":
                    this.code = 32;
                    break;

                default:
                    return false;
            }
            return true;
        }
       
        public bool IsNumber(string text)
        {
            int x;
            return Int32.TryParse(text, out x);
        }

        
        public bool CanBeVariable(string text)
        {
            bool CanBe = true;

            if (text.Length == 0 || !Char.IsLetter(text[0]))
                return false;

            else
                foreach (char s in text)
                {
                    if (s != '_' && !Char.IsDigit(s) && !Char.IsLetter(s))
                        return false;
                }

            this.code = 7;
            return true;
        }

        public bool IsInvalid(string text)
        {
            if (text.Length > 1)
                if (Char.IsLetter(text[text.Length - 1]) && Char.IsDigit(text[0]))
                {
                    this.code = -1;
                    return true;                    
                }

            return false;
        }
       
        public bool IsBracket(string text)
        {
            if (text == "(")
                this.code = 33;
            else if (text == ")")
                this.code = 34;
            else 
                return false;
            
            return true;
        }

        public bool IsBrace(string text)
        {
            if (text == "{")
                this.code = 9;
            else if (text == "}")
                this.code = 10;
            else
                return false;

            return true;
        }
        
        public bool IsIf(string text)
        {
            if (text == "if")
                this.code = 33;
            else if (text == "else")
                this.code = 34;
            else
                return false;

            return true;
        }

        public void Scanned()
        {
            this.parts = new Dictionary<string, string>();
            this.text = "";
            int i = 0;
            int start = 1;
            int end = 0;
            int line = 1;

            string subText = "";
            foreach (char s in this.input + " ")
            {
                if (IsOperator(subText) &&
                    (s == ' ' || s == '<' || s == '>' || s == ';' || s == '(' || s == '\n'))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Ключевое слово";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;
                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "Operator");
                    subText = "";
                }

                if (IsDataType(subText) && (s == ' ' || s == '<' || s == '>' || s == ';' || s == '('))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Ключевое слово";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;

                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "DataType");
                    subText = "";
                }

                else if (IsArithmOperator(subText) &&
                    (s == ' ' || s == '(' || Char.IsDigit(s) || Char.IsLetter(s)))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Арифметический оператор";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;

                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "Oper");
                    subText = "";
                }

                else if (IsNumber(subText) &&
                    (s == ' ' || s == '\n' || s == ')'))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Целое число";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;

                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "Number");
                    subText = "";
                }

                else if (CanBeVariable(subText) &&
                    !IsOperator(subText) && !IsDataType(subText) &&
                    (s == ' ' || s == '<' || s == '>' || s == ';' ||
                    s == '+' || s == '-' || s == '*' || s == '/' || s == '(' || s == ')' || s == '\n'))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Идентификатор";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;
                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "Variable");
                    subText = "";
                }

                else if (IsBracket(subText))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Скобка";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;

                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "Bracket");
                    subText = "";
                }

                else if (IsBrace(subText))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Фигурная скобка";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;

                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "Brace");
                    subText = "";
                }
                else if (IsIf(subText) &&
                    (s == ' ' || s == '('))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Условный оператор";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;
                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "If");
                    subText = "";
                }

                else if(IsInvalid(subText) && (s == ' ' || s == '(' || s == '\n'))
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = this.code;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "Недопустимый символ";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;
                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "ERROR");
                    subText = "";
                }

                else if (subText == "\n")
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = 38;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "конец оператора";
                    str_data.lex = "(перенос строки)";
                    data.Add(str_data);
                    start = end;
                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "NewLine");
                    line++;
                    start = end = 1;
                    subText = "";
                }

                else if(subText == " ")
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = 18;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "разделитель";
                    str_data.lex = "(пробел)";
                    data.Add(str_data);
                    start = end;
                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "Space");
                    subText = "";
                }

                else if (subText == "=" && s != '=')
                {
                    Lex_Data str_data = new Lex_Data();
                    str_data.code = 19;
                    str_data.line = line;
                    str_data.chr_num_start = start;
                    str_data.chr_num_end = end;
                    str_data.identifier = "оператор присваивания";
                    str_data.lex = subText;
                    data.Add(str_data);
                    start = end;
                    //i++;
                    //parts.Add(i.ToString() + " " + subText, "Assignment");
                    subText = "";
                }
                subText += s;
                end++;
            }

            
            foreach (Lex_Data lexema in data)
            {
                text += "\n" +
                    lexema.code.ToString() + " - " + lexema.identifier + " - " + lexema.lex + " - " + lexema.line.ToString() + " линия с" + 
                    lexema.chr_num_start.ToString() + " по " + lexema.chr_num_end.ToString() + " символ";
            }
        }
    }
}
