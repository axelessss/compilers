using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    public enum TokenType
    {
        While,
        Or,
        And,
        Rel,
        Do,
        Var,
        Const,
        Assignment,
        End,
        Semicolon,
        ArithOp,
        Error
    }

    public class Token7
    {
        public TokenType Type { get; set; }
        public string Value { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }

        public Token7(TokenType type, string value, int startIndex, int endIndex)
        {
            Type = type;
            Value = value;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }
    }
}
