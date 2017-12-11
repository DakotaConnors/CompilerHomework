// Generated from antlrParser.g4 by ANTLR 4.7
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class antlrParserParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		OPTIONAL_EOL=1, EOL=2, LINE=3, OPERATOR=4, ID=5, NUMBER=6, OPTIONAL_WS=7;
	public static final int
		RULE_prog = 0;
	public static final String[] ruleNames = {
		"prog"
	};

	private static final String[] _LITERAL_NAMES = {
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, "OPTIONAL_EOL", "EOL", "LINE", "OPERATOR", "ID", "NUMBER", "OPTIONAL_WS"
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "antlrParser.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public antlrParserParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class ProgContext extends ParserRuleContext {
		public List<TerminalNode> OPTIONAL_EOL() { return getTokens(antlrParserParser.OPTIONAL_EOL); }
		public TerminalNode OPTIONAL_EOL(int i) {
			return getToken(antlrParserParser.OPTIONAL_EOL, i);
		}
		public List<TerminalNode> LINE() { return getTokens(antlrParserParser.LINE); }
		public TerminalNode LINE(int i) {
			return getToken(antlrParserParser.LINE, i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_prog; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof antlrParserListener ) ((antlrParserListener)listener).enterProg(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof antlrParserListener ) ((antlrParserListener)listener).exitProg(this);
		}
	}

	public final ProgContext prog() throws RecognitionException {
		ProgContext _localctx = new ProgContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(10);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==LINE) {
				{
				{
				setState(3); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(2);
					match(LINE);
					}
					}
					setState(5); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==LINE );
				setState(7);
				match(OPTIONAL_EOL);
				}
				}
				setState(12);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\t\20\4\2\t\2\3\2"+
		"\6\2\6\n\2\r\2\16\2\7\3\2\7\2\13\n\2\f\2\16\2\16\13\2\3\2\2\2\3\2\2\2"+
		"\2\20\2\f\3\2\2\2\4\6\7\5\2\2\5\4\3\2\2\2\6\7\3\2\2\2\7\5\3\2\2\2\7\b"+
		"\3\2\2\2\b\t\3\2\2\2\t\13\7\3\2\2\n\5\3\2\2\2\13\16\3\2\2\2\f\n\3\2\2"+
		"\2\f\r\3\2\2\2\r\3\3\2\2\2\16\f\3\2\2\2\4\7\f";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}