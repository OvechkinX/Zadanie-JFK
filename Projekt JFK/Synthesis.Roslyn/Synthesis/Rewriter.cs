namespace Synthesis
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    internal sealed class Rewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            var typ = node.ChildNodes().OfType<PredefinedTypeSyntax>().FirstOrDefault();
                
            var parametr = node.ChildNodes().OfType<ParameterListSyntax>().FirstOrDefault();
            string parametry = "";
            foreach (ParameterSyntax p in parametr.ChildNodes())
                {

                parametry = parametry + p + " ";

                }


            if (parametry == "") parametry = "Brak parametrów";

                return base.VisitMethodDeclaration(node).WithLeadingTrivia(SyntaxFactory.Comment("\n//Typ zwracany przez metodę: "+ typ + "\n" + "//Parametry metody:  " + parametry + "\n"));

        }
    }
}
