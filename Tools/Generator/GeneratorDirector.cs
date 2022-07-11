using System.Collections.Generic;

namespace Tools.Generator
{
    public class GeneratorDirector
    {
        private IBuilderGenerator _builderGenerator;

        public GeneratorDirector(IBuilderGenerator builder)
        {
            SetGenerator(builder);
        }

        public void SetGenerator(IBuilderGenerator builder) => _builderGenerator = builder;

        public void CreateSimpleJsonGenerator(List<string> content, string path)
        {
            _builderGenerator.Reset();
            _builderGenerator.SetContent(content);
            _builderGenerator.SetPath(path);
            _builderGenerator.SetFormat(TypeFormat.Json);
        }

        public void CreateSimplePipeGenerator(List<string> content, string path)
        {
            _builderGenerator.Reset();
            _builderGenerator.SetContent(content);
            _builderGenerator.SetPath(path);
            _builderGenerator.SetFormat(TypeFormat.Pipes);
            _builderGenerator.SetCharacter(TypeCharacter.UpperCase);
        }
    }
}
