using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B56")]
public class JsonReader
{
	[Token(Token = "0x401943E")]
	[FieldOffset(Offset = "0x0")]
	private static IDictionary<int, IDictionary<int, int[]>> parse_table;

	[Token(Token = "0x401943F")]
	[FieldOffset(Offset = "0x8")]
	private Stack<int> automaton_stack;

	[Token(Token = "0x4019440")]
	[FieldOffset(Offset = "0xC")]
	private int current_input;

	[Token(Token = "0x4019441")]
	[FieldOffset(Offset = "0x10")]
	private int current_symbol;

	[Token(Token = "0x4019442")]
	[FieldOffset(Offset = "0x14")]
	private bool end_of_json;

	[Token(Token = "0x4019443")]
	[FieldOffset(Offset = "0x15")]
	private bool end_of_input;

	[Token(Token = "0x4019444")]
	[FieldOffset(Offset = "0x18")]
	private Lexer lexer;

	[Token(Token = "0x4019445")]
	[FieldOffset(Offset = "0x1C")]
	private bool parser_in_string;

	[Token(Token = "0x4019446")]
	[FieldOffset(Offset = "0x1D")]
	private bool parser_return;

	[Token(Token = "0x4019447")]
	[FieldOffset(Offset = "0x1E")]
	private bool read_started;

	[Token(Token = "0x4019448")]
	[FieldOffset(Offset = "0x20")]
	private TextReader reader;

	[Token(Token = "0x4019449")]
	[FieldOffset(Offset = "0x24")]
	private bool reader_is_owned;

	[Token(Token = "0x401944A")]
	[FieldOffset(Offset = "0x25")]
	private bool skip_non_members;

	[Token(Token = "0x401944B")]
	[FieldOffset(Offset = "0x28")]
	private object token_value;

	[Token(Token = "0x401944C")]
	[FieldOffset(Offset = "0x2C")]
	private JsonToken token;

	[Token(Token = "0x17001815")]
	public bool AllowComments
	{
		[Token(Token = "0x60179D4")]
		[Address(RVA = "0x26A3934", Offset = "0x26A3934", VA = "0x26A3934")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60179D5")]
		[Address(RVA = "0x26A3960", Offset = "0x26A3960", VA = "0x26A3960")]
		set
		{
		}
	}

	[Token(Token = "0x17001816")]
	public bool AllowSingleQuotedStrings
	{
		[Token(Token = "0x60179D6")]
		[Address(RVA = "0x26A3990", Offset = "0x26A3990", VA = "0x26A3990")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60179D7")]
		[Address(RVA = "0x26A39BC", Offset = "0x26A39BC", VA = "0x26A39BC")]
		set
		{
		}
	}

	[Token(Token = "0x17001817")]
	public bool SkipNonMembers
	{
		[Token(Token = "0x60179D8")]
		[Address(RVA = "0x26A39EC", Offset = "0x26A39EC", VA = "0x26A39EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60179D9")]
		[Address(RVA = "0x26A39F4", Offset = "0x26A39F4", VA = "0x26A39F4")]
		set
		{
		}
	}

	[Token(Token = "0x17001818")]
	public bool EndOfInput
	{
		[Token(Token = "0x60179DA")]
		[Address(RVA = "0x26A39FC", Offset = "0x26A39FC", VA = "0x26A39FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001819")]
	public bool EndOfJson
	{
		[Token(Token = "0x60179DB")]
		[Address(RVA = "0x26A3A04", Offset = "0x26A3A04", VA = "0x26A3A04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700181A")]
	public JsonToken Token
	{
		[Token(Token = "0x60179DC")]
		[Address(RVA = "0x26A3A0C", Offset = "0x26A3A0C", VA = "0x26A3A0C")]
		get
		{
			return default(JsonToken);
		}
	}

	[Token(Token = "0x1700181B")]
	public object Value
	{
		[Token(Token = "0x60179DD")]
		[Address(RVA = "0x26A3A14", Offset = "0x26A3A14", VA = "0x26A3A14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60179D0")]
	[Address(RVA = "0x26A2C98", Offset = "0x26A2C98", VA = "0x26A2C98")]
	static JsonReader()
	{
	}

	[Token(Token = "0x60179D1")]
	[Address(RVA = "0x26A362C", Offset = "0x26A362C", VA = "0x26A362C")]
	public JsonReader(string json_text)
	{
	}

	[Token(Token = "0x60179D2")]
	[Address(RVA = "0x26A3850", Offset = "0x26A3850", VA = "0x26A3850")]
	public JsonReader(TextReader reader)
	{
	}

	[Token(Token = "0x60179D3")]
	[Address(RVA = "0x26A36B0", Offset = "0x26A36B0", VA = "0x26A36B0")]
	private JsonReader(TextReader reader, bool owned)
	{
	}

	[Token(Token = "0x60179DE")]
	[Address(RVA = "0x26A2C9C", Offset = "0x26A2C9C", VA = "0x26A2C9C")]
	private static void PopulateParseTable()
	{
	}

	[Token(Token = "0x60179DF")]
	[Address(RVA = "0x26A3B6C", Offset = "0x26A3B6C", VA = "0x26A3B6C")]
	private static void TableAddCol(ParserToken row, int col, int[] symbols)
	{
	}

	[Token(Token = "0x60179E0")]
	[Address(RVA = "0x26A3A1C", Offset = "0x26A3A1C", VA = "0x26A3A1C")]
	private static void TableAddRow(ParserToken rule)
	{
	}

	[Token(Token = "0x60179E1")]
	[Address(RVA = "0x26A3D2C", Offset = "0x26A3D2C", VA = "0x26A3D2C")]
	private void ProcessNumber(string number)
	{
	}

	[Token(Token = "0x60179E2")]
	[Address(RVA = "0x26A3F38", Offset = "0x26A3F38", VA = "0x26A3F38")]
	private void ProcessSymbol()
	{
	}

	[Token(Token = "0x60179E3")]
	[Address(RVA = "0x26A4154", Offset = "0x26A4154", VA = "0x26A4154")]
	private bool ReadToken()
	{
		return default(bool);
	}

	[Token(Token = "0x60179E4")]
	[Address(RVA = "0x26A44D4", Offset = "0x26A44D4", VA = "0x26A44D4")]
	public void Close()
	{
	}

	[Token(Token = "0x60179E5")]
	[Address(RVA = "0x26A453C", Offset = "0x26A453C", VA = "0x26A453C")]
	public bool Read()
	{
		return default(bool);
	}
}
