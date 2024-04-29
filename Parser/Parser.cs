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
    public class Parser
    {
        private List<Scan.Lex_Data> tokens;
        private List<Scan.Lex_Data> errorTokens;
        private int current; // для отслеживания текущего индекса в списке токенов	 
        private int currentState;
        private string errors_list;
        Scan.Lex_Data prev_token;

        public Parser(List<Scan.Lex_Data> tokens)
        {
            this.tokens = tokens;
            this.prev_token = tokens[0];
            current = 0;
            currentState = 1;
            errorTokens = new List<Scan.Lex_Data>(); // Создаем список ошибок в конструкторе парсера
        }

        public void Parse()
        {
            foreach (Scan.Lex_Data token in tokens)
            {
                if (token.code == TokenType.Space)
                    // Пропускаем токены NewLine и Space
                    continue;

                switch (currentState)
                {
                    case 1:
                        State1(token);
                        break;
                    case 3:
                        State3(token);
                        break;
                    case 4:
                        State4(token);
                        break;
                    case 5:
                        State5(token);
                        break;
                    case 6:
                        State6(token);
                        break;
                    case 7:
                        State7(token);
                        break;
                    case 8:
                        State8(token);
                        break;
                    case 9:
                        State9(token);
                        break;
                    case 11:
                        State1112(token);
                        break;
                    case 12:
                        State1213(token);
                        break;
                    case 14:
                        State1415(token);
                        break;
                    case 16:
                        State16(token);
                        break;
                    case 17:
                        State17(token);
                        break;
                }
                this.prev_token = token;

                current++;
            }

            if (errorTokens.Count > 0)
            {
                errors_list += "Список ошибок:";
                foreach (Lex_Data lexema in errorTokens)
                {
                    errors_list += "\n" +
                        lexema.code.ToString() + " - " + lexema.identifier + " - " + lexema.lex + " - " + lexema.line.ToString() + " линия с" +
                        lexema.chr_num_start.ToString() + " по " + lexema.chr_num_end.ToString() + " символ";
                }
            }
        }

        public string Errors_list
        { 
            get => errors_list; 
        }

        private void State1(Scan.Lex_Data token)
        {
            if (token.code != TokenType.KeyWordFunc||token.code == TokenType.Invalid) // если не совпадает с ожидаемым, добавить в список ошибок           
                errorTokens.Add(token);            
            
            currentState = 3;
        }

        private void State3(Scan.Lex_Data token)
        {
            if (token.code != TokenType.Identifier || token.code == TokenType.Invalid)            
                errorTokens.Add(token);
            
            currentState = 4;
        }

        private void State4(Scan.Lex_Data token)
        {
            if (token.code != TokenType.BracketLeft || token.code == TokenType.Invalid)            
                errorTokens.Add(token);
            
            currentState = 5;
        }

        private void State5(Scan.Lex_Data token)
        {
            if (token.code != TokenType.Identifier || token.code == TokenType.Invalid)            
                errorTokens.Add(token);
            
            currentState = 6;
        }

        private void State6(Scan.Lex_Data token)
        {
            if (token.code == TokenType.Comma)
                currentState = 5;

            else if (token.code == TokenType.KeyWordInt)
                currentState = 7;

            else if(token.code == TokenType.BracketRight)
                currentState = 8;
            //else if(token.code )
            else
                errorTokens.Add(token);
        }

        private void State7(Scan.Lex_Data token)
        {
            if (token.code == TokenType.BracketRight)        
                currentState = 8;
                      
            else
            {
                errorTokens.Add(token);
                currentState = 7;
            }
        }

        private void State8(Scan.Lex_Data token)
        {
            if (token.code == TokenType.EndLine || token.code == TokenType.KeyWordInt)            
                currentState = 8;
            
            else if (token.code == TokenType.BraceLeft)            
                currentState = 9;           
            else
                errorTokens.Add(token);    
        }

        private void State9(Scan.Lex_Data token)
        {
            if (token.code == TokenType.EndLine)         
                currentState = 9;
            
            else if (token.code == TokenType.KeyWordReturn) // добавить пробел            
                currentState = 11;
            
            else            
                errorTokens.Add(token);
            
        }

        private void State1112(Scan.Lex_Data token)
        {
            if (token.code == TokenType.Identifier || token.code == TokenType.Digit)
                currentState = 12;

            else if (token.code == TokenType.EndLine)
                currentState = 17;

            else if (token.code == TokenType.BraceRight)
                currentState = 18;
            else
                errorTokens.Add(token);            
        }

        private void State1213(Scan.Lex_Data token)
        {
            if (token.code == TokenType.Sum || token.code == TokenType.Subtract || token.code == TokenType.Multiply || token.code == TokenType.Division)
                currentState = 14;
            

            else if (token.code == TokenType.EndLine)
                currentState = 16;

            else if (token.code == TokenType.BraceRight)
                currentState = 18;

            else
            {
                errorTokens.Add(token);
                currentState = 16;
            }
        }

        private void State1415(Scan.Lex_Data token)
        {

            //currentState = 14;

            if (token.code == TokenType.EndLine)
            {
                errorTokens.Add(prev_token);
                currentState = 16;
            }

            else if (token.code == TokenType.BraceRight)
            {
                errorTokens.Add(prev_token);
                currentState = 18;
            }

            else if (token.code == TokenType.Identifier || token.code == TokenType.Digit)
                currentState = 16;

            else
            {
                errorTokens.Add(token);
                currentState = 14;
            }
        }

        private void State16(Scan.Lex_Data token)
        {
            if (token.code == TokenType.EndLine)            
                currentState = 17;
            
            else if(token.code == TokenType.BraceRight)
                currentState = 18;

            else            
                errorTokens.Add(token);
            
        }

        private void State17(Scan.Lex_Data token)
        {
            if (token.code == TokenType.BraceRight)            
                currentState = 18; //end
            
            else            
                errorTokens.Add(token);            
        }
    }
}

