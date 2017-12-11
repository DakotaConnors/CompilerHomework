//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from antlrParser.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class antlrParserLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		OPTIONAL_EOL=1, EOL=2, LINE=3, OPERATOR=4, ID=5, NUMBER=6, OPTIONAL_WS=7;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"OPTIONAL_EOL", "EOL", "LINE", "OPERATOR", "ID", "NUMBER", "OPTIONAL_WS"
	};


	public antlrParserLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public antlrParserLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
	};
	private static readonly string[] _SymbolicNames = {
		null, "OPTIONAL_EOL", "EOL", "LINE", "OPERATOR", "ID", "NUMBER", "OPTIONAL_WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "antlrParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static antlrParserLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	public override void Action(RuleContext _localctx, int ruleIndex, int actionIndex) {
		switch (ruleIndex) {
		case 3 : OPERATOR_action(_localctx, actionIndex); break;
		}
	}
	private void OPERATOR_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 0: Console.WriteLine("Found a +"); break;
		}
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\t', '=', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', 
		'\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', 
		'\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', 
		'\b', '\x3', '\x2', '\x3', '\x2', '\x5', '\x2', '\x14', '\n', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x6', '\x4', '\x19', '\n', '\x4', 
		'\r', '\x4', '\xE', '\x4', '\x1A', '\x3', '\x4', '\x6', '\x4', '\x1E', 
		'\n', '\x4', '\r', '\x4', '\xE', '\x4', '\x1F', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x5', '\x4', '%', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x5', '\x5', '*', '\n', '\x5', '\x3', '\x6', '\x6', '\x6', 
		'-', '\n', '\x6', '\r', '\x6', '\xE', '\x6', '.', '\x3', '\a', '\x6', 
		'\a', '\x32', '\n', '\a', '\r', '\a', '\xE', '\a', '\x33', '\x3', '\b', 
		'\x6', '\b', '\x37', '\n', '\b', '\r', '\b', '\xE', '\b', '\x38', '\x3', 
		'\b', '\x5', '\b', '<', '\n', '\b', '\x2', '\x2', '\t', '\x3', '\x3', 
		'\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', 
		'\t', '\x3', '\x2', '\a', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x5', 
		'\x2', ',', ',', '/', '/', '\x31', '\x31', '\x3', '\x2', '\x63', '|', 
		'\x3', '\x2', '\x32', ';', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x2', 
		'\x45', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x13', '\x3', '\x2', '\x2', '\x2', '\x5', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\a', '$', '\x3', '\x2', '\x2', '\x2', '\t', ')', '\x3', 
		'\x2', '\x2', '\x2', '\v', ',', '\x3', '\x2', '\x2', '\x2', '\r', '\x31', 
		'\x3', '\x2', '\x2', '\x2', '\xF', ';', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x14', '\x5', '\x5', '\x3', '\x2', '\x12', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\x13', '\x11', '\x3', '\x2', '\x2', '\x2', '\x13', '\x12', '\x3', 
		'\x2', '\x2', '\x2', '\x14', '\x4', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x16', '\t', '\x2', '\x2', '\x2', '\x16', '\x6', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x19', '\x5', '\r', '\a', '\x2', '\x18', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'\x18', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1E', '\x5', 
		'\t', '\x5', '\x2', '\x1D', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', ' ', '\x3', '\x2', '\x2', '\x2', ' ', '!', '\x3', '\x2', 
		'\x2', '\x2', '!', '\"', '\x5', '\r', '\a', '\x2', '\"', '%', '\x3', '\x2', 
		'\x2', '\x2', '#', '%', '\x5', '\r', '\a', '\x2', '$', '\x18', '\x3', 
		'\x2', '\x2', '\x2', '$', '#', '\x3', '\x2', '\x2', '\x2', '%', '\b', 
		'\x3', '\x2', '\x2', '\x2', '&', '\'', '\a', '-', '\x2', '\x2', '\'', 
		'*', '\b', '\x5', '\x2', '\x2', '(', '*', '\t', '\x3', '\x2', '\x2', ')', 
		'&', '\x3', '\x2', '\x2', '\x2', ')', '(', '\x3', '\x2', '\x2', '\x2', 
		'*', '\n', '\x3', '\x2', '\x2', '\x2', '+', '-', '\t', '\x4', '\x2', '\x2', 
		',', '+', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', '\x2', '\x2', '\x2', 
		'.', ',', '\x3', '\x2', '\x2', '\x2', '.', '/', '\x3', '\x2', '\x2', '\x2', 
		'/', '\f', '\x3', '\x2', '\x2', '\x2', '\x30', '\x32', '\t', '\x5', '\x2', 
		'\x2', '\x31', '\x30', '\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\x31', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\x34', '\xE', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\x37', '\t', '\x6', '\x2', '\x2', '\x36', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\x38', '\x3', '\x2', '\x2', '\x2', '\x38', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x38', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x39', '<', '\x3', '\x2', '\x2', '\x2', ':', '<', '\x3', '\x2', 
		'\x2', '\x2', ';', '\x36', '\x3', '\x2', '\x2', '\x2', ';', ':', '\x3', 
		'\x2', '\x2', '\x2', '<', '\x10', '\x3', '\x2', '\x2', '\x2', '\f', '\x2', 
		'\x13', '\x1A', '\x1F', '$', ')', '.', '\x33', '\x38', ';', '\x3', '\x3', 
		'\x5', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
