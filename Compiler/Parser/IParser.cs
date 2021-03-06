﻿using System;
using System.Collections.Generic;
using System.Text;
using Compiler.Parser.Nodes;
using Compiler.Tokenizer;

namespace Compiler.Parser
{
    public interface IParser
    {
        ImmutableRootSyntaxNode ParseTokens(ReadOnlySpan<IToken> tokens);
    }
}
