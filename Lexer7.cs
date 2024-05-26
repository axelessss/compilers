using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    public class Lexer7
    {
        private List<Token7> Tokens;

        public List<Token7> Analyze(string input)
        {
            int i;
            string value;

            Tokens.Clear();

            for (i = 0; i < input.Length; i++)
            {
                value = string.Empty + input[i];

                if (char.IsLetter(input[i]))
                {
                    int startIndex = i;

                    while ((i + 1) < input.Length && char.IsLetter(input[i + 1]))
                    {
                        i++;
                        value += input[i];
                    }

                    switch (value)
                    {
                        case "while":
                            Tokens.Add(new Token7(TokenType.While, value, startIndex + 1, i + 1));
                            break;
                        case "do":
                            Tokens.Add(new Token7(TokenType.Do, value, startIndex + 1, i + 1));
                            break;
                        case "end":
                            Tokens.Add(new Token7(TokenType.End, value, startIndex + 1, i + 1));
                            break;
                        case "and":
                            Tokens.Add(new Token7(TokenType.And, value, startIndex + 1, i + 1));
                            break;
                        case "or":
                            Tokens.Add(new Token7(TokenType.Or, value, startIndex + 1, i + 1));
                            break;
                        default:
                            Tokens.Add(new Token7(TokenType.Var, value, startIndex + 1, i + 1));
                            break;
                    }
                }
                else
                {
                    if (char.IsDigit(input[i]))
                    {
                        int startIndex = i;

                        while ((i + 1) < input.Length && char.IsDigit(input[i + 1]))
                        {
                            i++;
                            value += input[i];
                        }

                        Tokens.Add(new Token7(TokenType.Const, value, startIndex + 1, i + 1));
                    }
                    else
                    {
                        switch (input[i])
                        {
                            case '\n':
                            case ' ':
                                break;
                            case (char)13:
                                if ((i + 1) < input.Length && input[i + 1] == (char)10)
                                {
                                    i++;
                                    value = "\\n";
                                }
                                break;
                            case '>':
                            case '<':
                            case '!':
                                if ((i + 1) < input.Length && input[i + 1] == '=')
                                {
                                    i++;
                                    value += input[i];
                                    Tokens.Add(new Token7(TokenType.Rel, value, i, i + 1));
                                }
                                else
                                {
                                    if (input[i] == '!')
                                    {
                                        Tokens.Add(new Token7(TokenType.Error, value, i + 1, i + 1));
                                    }
                                    else
                                    {
                                        Tokens.Add(new Token7(TokenType.Rel, value, i + 1, i + 1));
                                    }
                                }
                                break;
                            case '=':
                                if ((i + 1) < input.Length && input[i + 1] == '=')
                                {
                                    i++;
                                    value += input[i];
                                    Tokens.Add(new Token7(TokenType.Rel, value, i, i + 1));
                                }
                                else
                                {
                                    Tokens.Add(new Token7(TokenType.Assignment, value, i, i + 1));
                                }
                                break;
                            case '+':
                            case '-':
                                Tokens.Add(new Token7(TokenType.ArithOp, value, i + 1, i + 1));
                                break;
                            case ';':
                                Tokens.Add(new Token7(TokenType.Semicolon, value, i + 1, i + 1));
                                break;
                            default:
                                Tokens.Add(new Token7(TokenType.Error, value, i + 1, i + 1));
                                break;
                        }
                    }
                }
            }

            return Tokens;
        }

        public Lexer7()
        {
            Tokens = new List<Token7>();
        }
    }
}
