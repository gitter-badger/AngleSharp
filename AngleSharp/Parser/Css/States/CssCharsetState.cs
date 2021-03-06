﻿namespace AngleSharp.Parser.Css.States
{
    using AngleSharp.Dom.Css;

    sealed class CssCharsetState : CssParseState
    {
        public CssCharsetState(CssTokenizer tokenizer)
            : base(tokenizer)
        {
        }

        public override CssRule Create(CssToken current)
        {
            var token = _tokenizer.Get();
            var rule = new CssCharsetRule();

            if (token.Type == CssTokenType.String)
                rule.CharacterSet = token.Data;

            _tokenizer.JumpToNextSemicolon();
            return rule;
        }
    }
}
