﻿using System.Collections.Generic;

namespace Tools.Generator
{
    public enum TypeFormat
    {
        Json,
        Pipes
    }

    public enum TypeCharacter
    {
        Normal,
        UpperCase,
        LowerCase
    }

    public interface IBuilderGenerator
    {
        public void Reset();
        public void SetContent(List<string> content);
        public void SetPath(string path);
        public void SetFormat(TypeFormat typeFormat);
        public void SetCharacter(TypeCharacter character = TypeCharacter.Normal);
    }
}
