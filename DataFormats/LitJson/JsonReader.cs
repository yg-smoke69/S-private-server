using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B85")]
public class JsonReader
{
	[Token(Token = "0x40195A8")]
	[FieldOffset(Offset = "0x0")]
	private static IDictionary<int, IDictionary<int, int[]>> parse_table;

	[Token(Token = "0x40195A9")]
	[FieldOffset(Offset = "0x8")]
	private Stack<int> automaton_stack;

	[Token(Token = "0x40195AA")]
	[FieldOffset(Offset = "0xC")]
	private int current_input;

	[Token(Token = "0x40195AB")]
	[FieldOffset(Offset = "0x10")]
	private int current_symbol;

	[Token(Token = "0x40195AC")]
	[FieldOffset(Offset = "0x14")]
	private bool end_of_json;

	[Token(Token = "0x40195AD")]
	[FieldOffset(Offset = "0x15")]
	private bool end_of_input;

	[Token(Token = "0x40195AE")]
	[FieldOffset(Offset = "0x18")]
	private Lexer lexer;

	[Token(Token = "0x40195AF")]
	[FieldOffset(Offset = "0x1C")]
	private bool parser_in_string;

	[Token(Token = "0x40195B0")]
	[FieldOffset(Offset = "0x1D")]
	private bool parser_return;

	[Token(Token = "0x40195B1")]
	[FieldOffset(Offset = "0x1E")]
	private bool read_started;

	[Token(Token = "0x40195B2")]
	[FieldOffset(Offset = "0x20")]
	private TextReader reader;

	[Token(Token = "0x40195B3")]
	[FieldOffset(Offset = "0x24")]
	private bool reader_is_owned;

	[Token(Token = "0x40195B4")]
	[FieldOffset(Offset = "0x25")]
	private bool skip_non_members;

	[Token(Token = "0x40195B5")]
	[FieldOffset(Offset = "0x28")]
	private object token_value;

	[Token(Token = "0x40195B6")]
	[FieldOffset(Offset = "0x2C")]
	private JsonToken token;

	[Token(Token = "0x17001867")]
	public bool AllowComments
	{
		[Token(Token = "0x6017BC6")]
		[Address(RVA = "0x312C8F4", Offset = "0x312C8F4", VA = "0x312C8F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017BC7")]
		[Address(RVA = "0x312C920", Offset = "0x312C920", VA = "0x312C920")]
		set
		{
		}
	}

	[Token(Token = "0x17001868")]
	public bool AllowSingleQuotedStrings
	{
		[Token(Token = "0x6017BC8")]
		[Address(RVA = "0x312C954", Offset = "0x312C954", VA = "0x312C954")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017BC9")]
		[Address(RVA = "0x312C980", Offset = "0x312C980", VA = "0x312C980")]
		set
		{
		}
	}

	[Token(Token = "0x17001869")]
	public bool SkipNonMembers
	{
		[Token(Token = "0x6017BCA")]
		[Address(RVA = "0x31268BC", Offset = "0x31268BC", VA = "0x31268BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017BCB")]
		[Address(RVA = "0x312C9B4", Offset = "0x312C9B4", VA = "0x312C9B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700186A")]
	public bool EndOfInput
	{
		[Token(Token = "0x6017BCC")]
		[Address(RVA = "0x312C9BC", Offset = "0x312C9BC", VA = "0x312C9BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700186B")]
	public bool EndOfJson
	{
		[Token(Token = "0x6017BCD")]
		[Address(RVA = "0x312C9C4", Offset = "0x312C9C4", VA = "0x312C9C4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700186C")]
	public JsonToken Token
	{
		[Token(Token = "0x6017BCE")]
		[Address(RVA = "0x3126804", Offset = "0x3126804", VA = "0x3126804")]
		get
		{
			return default(JsonToken);
		}
	}

	[Token(Token = "0x1700186D")]
	public object Value
	{
		[Token(Token = "0x6017BCF")]
		[Address(RVA = "0x312680C", Offset = "0x312680C", VA = "0x312680C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017BC2")]
	[Address(RVA = "0x312BDBC", Offset = "0x312BDBC", VA = "0x312BDBC")]
	static JsonReader()
	{
	}

	[Token(Token = "0x6017BC3")]
	[Address(RVA = "0x312A248", Offset = "0x312A248", VA = "0x312A248")]
	public JsonReader(string json_text)
	{
	}

	[Token(Token = "0x6017BC4")]
	[Address(RVA = "0x3129FA0", Offset = "0x3129FA0", VA = "0x3129FA0")]
	public JsonReader(TextReader reader)
	{
	}

	[Token(Token = "0x6017BC5")]
	[Address(RVA = "0x312C750", Offset = "0x312C750", VA = "0x312C750")]
	private JsonReader(TextReader reader, bool owned)
	{
	}

	[Token(Token = "0x6017BD0")]
	[Address(RVA = "0x312BDC0", Offset = "0x312BDC0", VA = "0x312BDC0")]
	private static void PopulateParseTable()
	{
	}

	[Token(Token = "0x6017BD1")]
	[Address(RVA = "0x312CB1C", Offset = "0x312CB1C", VA = "0x312CB1C")]
	private static void TableAddCol(ParserToken row, int col, int[] symbols)
	{
	}

	[Token(Token = "0x6017BD2")]
	[Address(RVA = "0x312C9CC", Offset = "0x312C9CC", VA = "0x312C9CC")]
	private static void TableAddRow(ParserToken rule)
	{
	}

	[Token(Token = "0x6017BD3")]
	[Address(RVA = "0x312CCDC", Offset = "0x312CCDC", VA = "0x312CCDC")]
	private void ProcessNumber(string number)
	{
	}

	[Token(Token = "0x6017BD4")]
	[Address(RVA = "0x312CEE0", Offset = "0x312CEE0", VA = "0x312CEE0")]
	private void ProcessSymbol()
	{
	}

	[Token(Token = "0x6017BD5")]
	[Address(RVA = "0x312D108", Offset = "0x312D108", VA = "0x312D108")]
	private bool ReadToken()
	{
		return default(bool);
	}

	[Token(Token = "0x6017BD6")]
	[Address(RVA = "0x312D1AC", Offset = "0x312D1AC", VA = "0x312D1AC")]
	public void Close()
	{
	}

	[Token(Token = "0x6017BD7")]
	[Address(RVA = "0x312625C", Offset = "0x312625C", VA = "0x312625C")]
	public bool Read()
	{
		return default(bool);
	}
}
