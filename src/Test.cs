using System;
using System.Collections.Generic;
using System.Text;
using sly.lexer;
using sly.parser.generator;
using sly.parser.parser;
using System.Linq;

namespace netSchematron
{
    public class Test
    {
        public Test()
        {

        }

        [Production("XPath: Expr")]
        public string XPath(string expr)
        {
            return expr;
        }

        // [Production("ParamList: Param (COMMA [d] Param)*")]
        // public int ParamList(string param, List<Group<TokenEnum, string>> groupList)
        // {
        //     return 5;
        // }

        // [Production("Param: DOLAR [d] EQName TypeDeclaration?")]
        // public int Param(string eqName, ValueOption<string> optionalExpr)
        // {
        //     return 5;
        // }

        // [Production("FunctionBody: EnclosedExpr")]
        // public int FunctionBody(string enclosedExpr)
        // {
        //     return 5;
        // }

        // [Production("EnclosedExpr: LCURLYBRACKET [d] Expr? RCURLYBRACKET [d]")]
        // public int EnclosedExpr(ValueOption<string> optionalExpr)
        // {
        //     return 5;
        // }

        [Production("Expr: ExprSingle")]
        public string Expr(string exprSingle)
        {
            // StringBuilder result = new StringBuilder(exprSingle);

            // foreach (Group<TokenEnum, string> group in groupList)
            // {
            //     foreach (GroupItem<TokenEnum, string> item in group.Items)
            //     {
            //         result.Append(",");
            //         result.Append(item.Token.Value);
            //     }
            // }

            // return result.ToString();
            return exprSingle;
        }

        // [Production("ExprSingle: ForExpr")]
        // [Production("ExprSingle: LetExpr")]
        // [Production("ExprSingle: QuantifiedExpr")]
        // [Production("ExprSingle: IfExpr")]
        [Production("ExprSingle: OrExpr")]
        public string ExprSingle(string orExpr)
        {
            return orExpr;
        }

        // [Production("ForExpr: SimpleForClause RETURN [d] ExprSingle")]
        // public int ForExpr()
        // {
        //     return 5;
        // }

        // [Production("SimpleForClause: FOR [d] SimpleForBinding (COMMA [d] SimpleForBinding)*")]
        // public int SimpleForClause()
        // {
        //     return 5;
        // }

        // [Production("SimpleForBinding: DOLAR [d] VarName IN [d] ExprSingle")]
        // public int SimpleForBinding()
        // {
        //     return 5;
        // }

        // [Production("LetExpr: SimpleLetClause RETURN [d] ExprSingle")]
        // public int LetExpr()
        // {
        //     return 5;
        // }

        // [Production("SimpleLetClause: LET [d] SimpleLetBinding (COMMA [d] SimpleLetBinding)*")]
        // public int SimpleLetClause()
        // {
        //     return 5;
        // }

        // [Production("SimpleLetBinding: DOLAR [d] VarName ASSIGN [d] ExprSingle")]
        // public int SimpleLetBinding()
        // {
        //     return 5;
        // }

        // [Production("QuantifiedExpr: SOMEEVERY [d] DOLAR [d] VarName IN [d] ExprSingle (COMMA [d] DOLAR [d] VarName IN [d] ExprSingle)* SATISFIES [d] ExprSingle")]
        // public int QuantifiedExpr()
        // {
        //     return 5;
        // }

        // [Production("IfExpr: IF [d] LPARENTHESIS [d] Expr RPARENTHESIS [d] THEN [d] ExprSingle ELSE [d] ExprSingle")]
        // public int IfExpr()
        // {
        //     return 5;
        // }

        [Production("OrExpr: AndExpr")]
        public string OrExpr(string andExpr)
        {
            // StringBuilder result = new StringBuilder(andExpr);

            // foreach (Group<TokenEnum, string> group in groupList)
            // {
            //     foreach (GroupItem<TokenEnum, string> item in group.Items)
            //     {
            //         result.Append("or");
            //         result.Append(item.Value);
            //     }
            // }

            // return result.ToString();
            return andExpr;
        }

        [Production("AndExpr: ComparisonExpr")]
        public string AndExpr(string comparisonExpr)
        {
            // StringBuilder result = new StringBuilder(comparisonExpr);

            // foreach (Group<TokenEnum, string> group in groupList)
            // {
            //     foreach (GroupItem<TokenEnum, string> item in group.Items)
            //     {
            //         result.Append("and");
            //         result.Append(item.Value);
            //     }
            // }

            // return result.ToString();
            return comparisonExpr;
        }

        // [Production("ComparisonExpr: StringConcatExpr (ValueComp StringConcatExpr)?")]
        // [Operation((int)TokenEnum.COMPARATOR, Affix.PostFix, Associativity.Right, (int)TokenEnum.COMPARATOR)]
        [Production("ComparisonExpr: StringConcatExpr (COMPARATOR StringConcatExpr)?")]
        // [Production("ComparisonExpr: StringConcatExpr (NodeComp StringConcatExpr)?")]
        public string ComparisonExpr(string stringConcatExpr)
        {
            // string result;
            // if (optionalGroup.IsSome)
            // {
            //     optionalGroup.Match(
            //         (group) =>
            //         {
            //             switch (group.Value(0))
            //             {
            //                 case "a":
            //                 {
            //                     break;
            //                 }
            //             }

            //             return group;
            //         },
            //         null
            //     );
            // }

            return stringConcatExpr;
        }

        // [Operand]
        [Production("StringConcatExpr: RangeExpr")]
        public string StringConcatExpr(string rangeExpr)
        {
            return rangeExpr;
        }

        [Production("RangeExpr: AdditiveExpr")]
        public string RangeExpr(string additiveExpr)
        {
            return additiveExpr;
        }

        [Production("AdditiveExpr: MultiplicativeExpr (MinusOrPlusExpr MultiplicativeExpr)*")]
        public string AdditiveExpr(string multiplicativeExpr, List<Group<TokenEnum, string>> groupList)
        {
            string result = multiplicativeExpr;
            foreach (Group<TokenEnum, string> group in groupList)
            {
                result += group.Value(0);
                result += group.Value(1);
            }
            return result;
        }

        [Production("MinusOrPlusExpr: MINUS")]
        [Production("MinusOrPlusExpr: PLUS")]
        public string MinusOrPlusExpr(Token<TokenEnum> token)
        {
            return token.Value;
        }

        [Production("MultiplicativeExpr: UnionExpr (MultiplicativeOperatorExpr UnionExpr)*")]
        public object MultiplicativeExpr(object unionExpr, List<Group<TokenEnum, string>> list)
        {
            return 5;
        }

        [Production("MultiplicativeExpr: MULTIPLICATIVE")]
        [Production("MultiplicativeExpr: STAR")]
        public string MultiplicativeOperatorExpr(Token<TokenEnum> token)
        {
            return token.Value;
        }

        [Production("UnionExpr: IntersectExceptExpr")]
        public object UnionExpr(object intersectExceptExpr)
        {
            return intersectExceptExpr;
        }

        [Production("IntersectExceptExpr: InstanceofExpr")]
        public object IntersectExceptExpr(object instanceOfExpr)
        {
            return instanceOfExpr;
        }

        [Production("InstanceofExpr: TreatExpr")]
        public object InstanceofExpr(object treatExpr)
        {
            return treatExpr;
        }

        [Production("TreatExpr: CastableExpr")]
        public object TreatExpr(object castableExpr)
        {
            return castableExpr;
        }

        [Production("CastableExpr: CastExpr")]
        public object CastableExpr(object castExpr)
        {
            return castExpr;
        }

        [Production("CastExpr: ArrowExpr")]
        public object CastExpr(object arrowExpr)
        {
            return arrowExpr;
        }

        [Production("ArrowExpr: ValueExpr")]
        public object ArrowExpr(object unaryExpr)
        {
            return unaryExpr;
        }

        // [Production("UnaryExpr: MinusOrPlusExpr* ValueExpr")]
        // public string UnaryExpr(List<string> uMinusPlus, string valueExpr)
        // {
        //     string result = String.Empty;
        //     int minusCount = uMinusPlus.Count(x => x == "-");
        //     if (minusCount % 2 == 0)
        //     {
        //         result += $"+{valueExpr}";
        //     }
        //     else
        //     {
        //         result += $"-{valueExpr}";
        //     }

        //     return result;
        // }

        // [Production("UnaryExprExtra: MINUS")]
        // [Production("UnaryExprExtra: PLUS")]
        // public string UnaryExprExtra(Token<TokenEnum> token)
        // {
        //     return token.Value;
        // }

        [Production("ValueExpr: SimpleMapExpr")]
        public object ValueExpr(object simpleMapExpr)
        {
            return simpleMapExpr;
        }

        [Production("SimpleMapExpr: PathExpr")]
        public object SimpleMapExpr(object pathExpr)
        {
            return pathExpr;
        }

        // [Production("PathExpr: PATH [d] RelativePathExpr?")]
        // public int PathExpr(ValueOption<string> option)
        // {
        //     return 5;
        // }

        // [Production("PathExpr: ALLPATH [d] RelativePathExpr")]
        [Production("PathExpr: RelativePathExpr")]
        public object PathExpr(object relativePathExpr)
        {
            return relativePathExpr;
        }

        [Production("RelativePathExpr: StepExpr")]
        // [Production("RelativePathExpr: StepExpr (ALLPATH StepExpr)*")]
        public object RelativePathExpr(object stepExpr)
        {
            return stepExpr;
        }

        [Production("StepExpr: PostfixExpr")]
        // [Production("StepExpr: AxisStep")]
        public object StepExpr(object expr)
        {
            return expr;
        }

        // [Production("AxisStep: ReverseStep PredicateList")]
        // [Production("AxisStep: ForwardStep PredicateList")]
        // public int AxisStep(string reverseStep, string predicateList)
        // {
        //     return 5;
        // }

        // [Production("ForwardStep: ForwardAxis NodeTest")]
        // public int ForwardStep(string forwardAxis, string nodeTest)
        // {
        //     return 5;
        // }

        // [Production("ForwardStep: AbbrevForwardStep")]
        // public int ForwardStep(string abbrevForwardStep)
        // {
        //     return 5;
        // }

        // [Production("ForwardAxis: FWDAXIS DOUBLECOLON [d]")]
        // public int ForwardAxis(Token<TokenEnum> token)
        // {
        //     return 5;
        // }

        // [Production("AbbrevForwardStep: AT? NodeTest")]
        // public int AbbrevForwardStep(ValueOption<Token<TokenEnum>> optionalToken, string nodeTest)
        // {
        //     return 5;
        // }

        // [Production("ReverseStep: ReverseAxis NodeTest")]
        // public int ReverseStep(string reverseAxis, string nodeTest)
        // {
        //     return 5;
        // }

        // [Production("ReverseStep: DOUBLEDOT [d]")]
        // public int ReverseStep()
        // {
        //     return 5;
        // }

        // [Production("ReverseAxis: RVEAXIS DOUBLECOLON [d]")]
        // public int ReverseAxis(Token<TokenEnum> token)
        // {
        //     return 5;
        // }

        // [Production("NodeTest: KindTest")]
        // [Production("NodeTest: NameTest")]
        // public int NodeTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("NameTest: EQName")]
        // [Production("NameTest: Wildcard")]
        // public int NameTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("Wildcard: STAR [d]")]
        // public int Wildcard()
        // {
        //     return 5;
        // }

        // [Production("Wildcard: NCName COLONWILDCARD [d]")]
        // [Production("Wildcard: WILDCARDCOLON [d] NCName")]
        // [Production("Wildcard: BracedURILiteral STAR [d]")]
        // public int Wildcard(string expr)
        // {
        //     return 5;
        // }

        [Production("PostfixExpr: PrimaryExpr")]
        // [Production("PostfixExpr: PrimaryExpr ArgumentList*")]
        // [Production("PostfixExpr: PrimaryExpr Lookup*")]
        public object PostfixExpr(object primaryExpr)
        {
            return primaryExpr;
        }

        // [Production("ArgumentList: LPARENTHESIS [d] (Argument ExtraArgumentList)? RPARENTHESIS [d]")]
        // public int ArgumentList(ValueOption<GroupItem<TokenEnum, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraArgumentList: (COMMA [d] Argument)*")]
        // public int ExtraArgumentList(List<Group<TokenEnum, string>> list)
        // {
        //     return 5;
        // }

        // [Production("PredicateList: Predicate*")]
        // public int PredicateList(List<string> list)
        // {
        //     return 5;
        // }

        // [Production("Predicate: LSQRBRACKET [d] Expr RSQRBRACKET [d]")]
        // public int Predicate(string expr)
        // {
        //     return 5;
        // }

        // [Production("Lookup: QUESTION [d] KeySpecifier")]
        // public int Lookup(string keySpecifier)
        // {
        //     return 5;
        // }

        // [Production("KeySpecifier: NCName")]
        // [Production("KeySpecifier: IntegerLiteral")]
        // [Production("KeySpecifier: ParenthesizedExpr")]

        // public int KeySpecifier(string expr)
        // {
        //     return 5;
        // }

        // [Production("KeySpecifier: STAR [d]")]
        // public int KeySpecifier()
        // {
        //     return 5;
        // }

        // [Production("ArrowFunctionSpecifier: EQName")]
        // [Production("ArrowFunctionSpecifier: VarRef")]
        // [Production("ArrowFunctionSpecifier: ParenthesizedExpr")]
        // public int ArrowFunctionSpecifier(string expr)
        // {
        //     return 5;
        // }

        [Production("PrimaryExpr: Literal")]
        // [Production("PrimaryExpr: VarRef")]
        [Production("PrimaryExpr: ParenthesizedExpr")]
        // [Production("PrimaryExpr: ContextItemExpr")]
        // [Production("PrimaryExpr: FunctionCall")]
        // [Production("PrimaryExpr: FunctionItemExpr")]
        // [Production("PrimaryExpr: MapConstructor")]
        // [Production("PrimaryExpr: ArrayConstructor")]
        // [Production("PrimaryExpr: UnaryLookup")]
        public object PrimaryExpr(object expr)
        {
            return expr;
        }

        [Production("Literal: NumericLiteral")]
        [Production("Literal: StringLiteral")]
        public object Literal(object expr)
        {
            return expr;
        }

        [Production("NumericLiteral: IntegerLiteral")]
        [Production("NumericLiteral: DecimalLiteral")]
        [Production("NumericLiteral: DoubleLiteral")]
        public object NumericLiteral(object expr)
        {
            return expr;
        }

        // [Production("VarRef: DOLAR [d] VarName")]
        // public int VarRef(string varName)
        // {
        //     return 5;
        // }

        // [Production("VarName: EQName")]
        // public int VarName(string eqName)
        // {
        //     return 5;
        // }

        [Production("ParenthesizedExpr: LPARENTHESIS [d] Expr? RPARENTHESIS [d]")]
        public object ParenthesizedExpr(ValueOption<object> option)
        {
            var gg = option.Match((expr) => expr, null);
            return gg;
        }

        // [Production("ContextItemExpr: DOT [d]")]
        // public string ContextItemExpr()
        // {
        //     return ".";
        // }

        // [Production("FunctionCall: EQName ArgumentList")]
        // public int FunctionCall(string eqName, string argumentList)
        // {
        //     return 5;
        // }

        // [Production("Argument: ExprSingle")]
        // [Production("Argument: ArgumentPlaceholder")]
        // public int Argument(string expr)
        // {
        //     return 5;
        // }

        // [Production("ArgumentPlaceholder: QUESTION [d]")]
        // public string ArgumentPlaceholder()
        // {
        //     return "*";
        // }

        // [Production("FunctionItemExpr: NamedFunctionRef")]
        // [Production("FunctionItemExpr: InlineFunctionExpr")]
        // public int FunctionItemExpr(string expr)
        // {
        //     return 5;
        // }

        // [Production("NamedFunctionRef: EQName SQUARE [d] IntegerLiteral")]
        // public int NamedFunctionRef(string eqName, string integerLiteral)
        // {
        //     return 5;
        // }

        // [Production("InlineFunctionExpr: FUNCTION [d] LPARENTHESIS [d] ParamList? RPARENTHESIS [d] (AS [d] SequenceType)? FunctionBody")]
        // public int InlineFunctionExpr(ValueOption<string> option_first, ValueOption<Group<TokenEnum, string>> option_second, string functionBody)
        // {
        //     return 5;
        // }

        // [Production("MapConstructor: MAP [d] LCURLYBRACKET [d] (MapConstructorEntry ExtraMapConstructor)? RCURLYBRACKET [d]")]
        // public int MapConstructor(ValueOption<Group<TokenEnum, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraMapConstructor: (COMMA [d] MapConstructorEntry)*")]
        // public int ExtraMapConstructor(List<Group<TokenEnum, string>> list)
        // {
        //     return 5;
        // }

        // [Production("MapConstructorEntry: MapKeyExpr COLON [d] MapValueExpr")]
        // public int MapConstructorEntry(string mapKeyExpr, string mapValueExpr)
        // {
        //     return 5;
        // }

        // [Production("MapKeyExpr: ExprSingle")]
        // public int MapKeyExpr(string exprSingle)
        // {
        //     return 5;
        // }

        // [Production("MapValueExpr: ExprSingle")]
        // public int MapValueExpr(string exprSingle)
        // {
        //     return 5;
        // }

        // [Production("ArrayConstructor: SquareArrayConstructor")]
        // [Production("ArrayConstructor: CurlyArrayConstructor")]
        // public int ArrayConstructor(string expr)
        // {
        //     return 5;
        // }

        // [Production("SquareArrayConstructor: LSQRBRACKET [d] (ExprSingle ExtraSquareArrayConstructor)? RSQRBRACKET [d]")]
        // public int SquareArrayConstructor(ValueOption<Group<TokenEnum, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraSquareArrayConstructor: (COMMA [d] ExprSingle)*")]
        // public int ExtraSquareArrayConstructor(List<Group<TokenEnum, string>> list)
        // {
        //     return 5;
        // }

        // [Production("CurlyArrayConstructor: ARRAY [d] EnclosedExpr")]
        // public int CurlyArrayConstructor(string enclosedExpr)
        // {
        //     return 5;
        // }

        // [Production("UnaryLookup: QUESTION [d] KeySpecifier")]
        // public int UnaryLookup(string keySpecifier)
        // {
        //     return 5;
        // }

        // [Production("SingleType: SimpleTypeName QUESTION?")]
        // public int SingleType(string simpleTypeName, ValueOption<Token<TokenEnum>> option)
        // {
        //     return 5;
        // }

        // [Production("TypeDeclaration: AS [d] SequenceType")]
        // public int TypeDeclaration(string sequenceType)
        // {
        //     return 5;
        // }

        // [Production("SequenceType: EMPTYSEQUENCE [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int SequenceType()
        // {
        //     return 5;
        // }

        // [Production("SequenceType: ItemType OccurrenceIndicator?")]
        // public int SequenceType(string itemType, ValueOption<string> occurenceIndicator)
        // {
        //     return 5;
        // }

        // [Production("OccurrenceIndicator: QUESTION")]
        // [Production("OccurrenceIndicator: STAR")]
        // [Production("OccurrenceIndicator: PLUS")]
        // public int OccurrenceIndicator(Token<TokenEnum> token)
        // {
        //     return 5;
        // }

        // [Production("ItemType: KindTest")]
        // [Production("ItemType: FunctionTest")]
        // [Production("ItemType: MapTest")]
        // [Production("ItemType: ArrayTest")]
        // [Production("ItemType: AtomicOrUnionType")]
        // [Production("ItemType: ParenthesizedItemType")]
        // public int ItemType(string expr)
        // {
        //     return 5;
        // }

        // [Production("ItemType: ITEM [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int ItemType()
        // {
        //     return 5;
        // }

        // [Production("AtomicOrUnionType: EQName")]
        // public int AtomicOrUnionType(string eqName)
        // {
        //     return 5;
        // }

        // [Production("KindTest: DocumentTest")]
        // [Production("KindTest: ElementTest")]
        // [Production("KindTest: AttributeTest")]
        // [Production("KindTest: SchemaElementTest")]
        // [Production("KindTest: SchemaAttributeTest")]
        // [Production("KindTest: PITest")]
        // [Production("KindTest: CommentTest")]
        // [Production("KindTest: TextTest")]
        // [Production("KindTest: NamespaceNodeTest")]
        // [Production("KindTest: AnyKindTest")]
        // public int KindTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("AnyKindTest: NODE [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int AnyKindTest()
        // {
        //     return 5;
        // }

        // [Production("DocumentTest: DOCUMENTNODE [d] LPARENTHESIS [d] ElementTest? RPARENTHESIS [d]")]
        // [Production("DocumentTest: DOCUMENTNODE [d] LPARENTHESIS [d] SchemaElementTest? RPARENTHESIS [d]")]
        // public int DocumentTest(ValueOption<string> option)
        // {
        //     return 5;
        // }

        // [Production("TextTest: TEXT [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int TextTest()
        // {
        //     return 5;
        // }

        // [Production("CommentTest: COMMENT [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int CommentTest()
        // {
        //     return 5;
        // }

        // [Production("NamespaceNodeTest: NAMESPACENODE [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int NamespaceNodeTest()
        // {
        //     return 5;
        // }

        // [Production("PITest: PROCESSINGINSTRUCTION [d] LPARENTHESIS [d] NCName? RPARENTHESIS [d]")]
        // [Production("PITest: PROCESSINGINSTRUCTION [d] LPARENTHESIS [d] StringLiteral? RPARENTHESIS [d]")]
        // public int PITest(ValueOption<string> option)
        // {
        //     return 5;
        // }

        // [Production("AttributeTest: ATTRIBUTE [d] LPARENTHESIS [d] (AttributeNameOrWildcard ExtraAttributeTest)? RPARENTHESIS [d]")]
        // public int AttributeTest(ValueOption<Group<TokenEnum, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraAttributeTest: (COMMA [d] TypeName)?")]
        // public int ExtraAttributeTest(ValueOption<Group<TokenEnum, string>> option)
        // {
        //     return 5;
        // }

        // [Production("AttributeNameOrWildcard: AttributeName")]
        // public int AttributeNameOrWildcard(string attributeName)
        // {
        //     return 5;
        // }

        // [Production("AttributeNameOrWildcard: STAR [d]")]
        // public int AttributeNameOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("SchemaAttributeTest: SCHEMAATTRIBUTE [d] LPARENTHESIS [d] AttributeDeclaration RPARENTHESIS [d]")]
        // public int SchemaAttributeTest(string attributeDeclaration)
        // {
        //     return 5;
        // }

        // [Production("AttributeDeclaration: AttributeName")]
        // public int AttributeDeclaration(string attributeName)
        // {
        //     return 5;
        // }

        // [Production("ElementTest: ELEMENT [d] LPARENTHESIS [d] (ElementNameOrWildcard ExtraElementTest)? RPARENTHESIS [d]")]
        // public int ElementTest(ValueOption<Group<TokenEnum, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraElementTest: (COMMA [d] TypeName ZeroOrOne)?")]
        // public int ExtraElementTest(ValueOption<Group<TokenEnum, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ZeroOrOne: QUESTION?")]
        // public int ZeroOrOne(ValueOption<Token<TokenEnum>> option)
        // {
        //     return 5;
        // }

        // [Production("ElementNameOrWildcard: ElementName")]
        // public int ElementNameOrWildcard(string elementName)
        // {
        //     return 5;
        // }

        // [Production("ElementNameOrWildcard: STAR [d]")]
        // public int ElementNameOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("SchemaElementTest: SCHEMAELEMENT [d] LPARENTHESIS [d] ElementDeclaration RPARENTHESIS [d]")]
        // public int SchemaElementTest(string elementDeclaration)
        // {
        //     return 5;
        // }

        // [Production("ElementDeclaration: ElementName")]
        // public int ElementDeclaration(string elementName)
        // {
        //     return 5;
        // }

        // [Production("AttributeName: EQName")]
        // public int AttributeName(string eqName)
        // {
        //     return 5;
        // }

        // [Production("ElementName: EQName")]
        // public int ElementName(string eqName)
        // {
        //     return 5;
        // }

        // [Production("SimpleTypeName: TypeName")]
        // public int SimpleTypeName(string typeName)
        // {
        //     return 5;
        // }

        // [Production("TypeName: EQName")]
        // public int TypeName(string eqName)
        // {
        //     return 5;
        // }

        // [Production("FunctionTest: AnyFunctionTest")]
        // [Production("FunctionTest: TypedFunctionTest")]
        // public int FunctionTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("AnyFunctionTest: FUNCTION [d] LPARENTHESIS [d] STAR [d] RPARENTHESIS [d]")]
        // public int AnyFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("TypedFunctionTest: FUNCTION [d] LPARENTHESIS [d] (SequenceType ExtraTypedFunctionTest)? RPARENTHESIS [d] AS [d] SequenceType")]
        // public int TypedFunctionTest(ValueOption<Group<TokenEnum, string>> option, string sequenceType)
        // {
        //     return 5;
        // }

        // [Production("ExtraTypedFunctionTest: (COMMA [d] SequenceType)*")]
        // public int ExtraTypedFunctionTest(List<Group<TokenEnum, string>> list)
        // {
        //     return 5;
        // }

        // [Production("MapTest: AnyMapTest")]
        // [Production("MapTest: TypedMapTest")]
        // public int MapTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("AnyMapTest: MAP [d] LPARENTHESIS [d] STAR [d] RPARENTHESIS [d]")]
        // public int AnyMapTest()
        // {
        //     return 5;
        // }

        // [Production("TypedMapTest: MAP [d] LPARENTHESIS [d] AtomicOrUnionType COMMA [d] SequenceType RPARENTHESIS [d]")]
        // public int TypedMapTest(string atomicOrUnionType, string sequenceType)
        // {
        //     return 5;
        // }

        // [Production("ArrayTest: AnyArrayTest")]
        // [Production("ArrayTest: TypedArrayTest")]
        // public int ArrayTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("AnyArrayTest: ARRAY [d] LPARENTHESIS [d] STAR RPARENTHESIS [d]")]
        // public int AnyArrayTest(Token<TokenEnum> token)
        // {
        //     return 5;
        // }

        // [Production("TypedArrayTest: ARRAY [d] LPARENTHESIS [d] SequenceType RPARENTHESIS [d]")]
        // public int TypedArrayTest(string sequenceType)
        // {
        //     return 5;
        // }

        // [Operand]
        // [Production("ParenthesizedItemType: LPARENTHESIS [d] ItemType RPARENTHESIS [d]")]
        // public string ParenthesizedItemType(string itemType)
        // {
        //     return itemType;
        // }

        // [Production("EQName: QName")]
        // [Production("EQName: URIQualifiedName")]
        // public string EQName(string expr)
        // {
        //     return expr;
        // }

        // [Operand]
        [Production("IntegerLiteral: INTEGER")]
        public object IntegerLiteral(Token<TokenEnum> token)
        {
            return token.IntValue;
        }

        [Production("DecimalLiteral: DOT [d] INTEGER")]
        public object DecimalLiteral(Token<TokenEnum> token)
        {
            return Decimal.Parse(token.Value);
        }

        [Production("DecimalLiteral: INTEGER DOT [d] INTEGER*")] // INETEGER* migth not work here!
        public object DecimalLiteral(Token<TokenEnum> token, List<Token<TokenEnum>> list)
        {
            return Decimal.Parse(token.Value);
        }

        // [Operand]
        [Production("DoubleLiteral: DOUBLE")]
        public object DoubleLiteral(Token<TokenEnum> token)
        {
            return token.DoubleValue;
        }

        [Production("StringLiteral: STRING")]
        public object StringLiteral(Token<TokenEnum> token)
        {
            return token.Value;
        }

        // [Production("URIQualifiedName: BracedURILiteral NCName")]
        // public int URIQualifiedName(string bacedUriLiteral, string ncName)
        // {
        //     return 5;
        // }

        // // [Operand]
        // [Production("BracedURILiteral: Q [d] LCURLYBRACKET [d] STRING RCURLYBRACKET [d]")]
        // public string BracedURILiteral(Token<TokenEnum> token)
        // {
        //     return token.Value;
        // }

        // [Production("Comment: LCOMMENT [d] CommentContents* RCOMMENT [d]")]
        // [Production("Comment: LCOMMENT [d] Comment* RCOMMENT [d]")]
        // public int Comment()
        // {
        //     return 5;
        // }

        // [Operand]
        // [Production("QName: STRING")]
        // public string QName(Token<TokenEnum> token)
        // {
        //     return token.Value;
        // }

        // [Operand]
        // [Production("NCName: STRING")]
        // public string NCName(Token<TokenEnum> token)
        // {
        //     return token.Value;
        // }

        // [Production("Char: STRING")]
        // public int Char()
        // {
        //     return 5;
        // }

        // [Production("CommentContents: STRING")]
        // public int CommentContents()
        // {
        //     return 5;
        // }
    }
}