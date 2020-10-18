﻿using System.Collections.Generic;

namespace ZaraEngine.StateManaging
{
    public abstract class SnippetBase : IStateSnippet
    {

        public SnippetBase()
        {

        }

        public SnippetBase(object contract)
        {
            FromContract(contract);
        }

        public Dictionary<string, IStateSnippet> ChildStates { get; } = new Dictionary<string, IStateSnippet>();

        public virtual void FromContract(object o) { }

        public virtual object ToContract() { return null; }
    }
}
