using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B88")]
public class JsonWriter
{
	[Token(Token = "0x40195C2")]
	[FieldOffset(Offset = "0x0")]
	private static NumberFormatInfo number_format;

	[Token(Token = "0x40195C3")]
	[FieldOffset(Offset = "0x8")]
	private WriterContext context;

	[Token(Token = "0x40195C4")]
	[FieldOffset(Offset = "0xC")]
	private Stack<WriterContext> ctx_stack;

	[Token(Token = "0x40195C5")]
	[FieldOffset(Offset = "0x10")]
	private bool has_reached_end;

	[Token(Token = "0x40195C6")]
	[FieldOffset(Offset = "0x14")]
	private char[] hex_seq;

	[Token(Token = "0x40195C7")]
	[FieldOffset(Offset = "0x18")]
	private int indentation;

	[Token(Token = "0x40195C8")]
	[FieldOffset(Offset = "0x1C")]
	private int indent_value;

	[Token(Token = "0x40195C9")]
	[FieldOffset(Offset = "0x20")]
	private StringBuilder inst_string_builder;

	[Token(Token = "0x40195CA")]
	[FieldOffset(Offset = "0x24")]
	private bool pretty_print;

	[Token(Token = "0x40195CB")]
	[FieldOffset(Offset = "0x25")]
	private bool validate;

	[Token(Token = "0x40195CC")]
	[FieldOffset(Offset = "0x28")]
	private TextWriter writer;

	[Token(Token = "0x40195CD")]
	[FieldOffset(Offset = "0x2C")]
	private bool unicode;

	[Token(Token = "0x1700186E")]
	public int IndentValue
	{
		[Token(Token = "0x6017BDD")]
		[Address(RVA = "0x312D428", Offset = "0x312D428", VA = "0x312D428")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6017BDE")]
		[Address(RVA = "0x312D430", Offset = "0x312D430", VA = "0x312D430")]
		set
		{
		}
	}

	[Token(Token = "0x1700186F")]
	public bool PrettyPrint
	{
		[Token(Token = "0x6017BDF")]
		[Address(RVA = "0x312D45C", Offset = "0x312D45C", VA = "0x312D45C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017BE0")]
		[Address(RVA = "0x312D464", Offset = "0x312D464", VA = "0x312D464")]
		set
		{
		}
	}

	[Token(Token = "0x17001870")]
	public TextWriter TextWriter
	{
		[Token(Token = "0x6017BE1")]
		[Address(RVA = "0x3129704", Offset = "0x3129704", VA = "0x3129704")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001871")]
	public bool Validate
	{
		[Token(Token = "0x6017BE2")]
		[Address(RVA = "0x311FAE0", Offset = "0x311FAE0", VA = "0x311FAE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017BE3")]
		[Address(RVA = "0x311FAD8", Offset = "0x311FAD8", VA = "0x311FAD8")]
		set
		{
		}
	}

	[Token(Token = "0x17001872")]
	public bool Unicode
	{
		[Token(Token = "0x6017BE4")]
		[Address(RVA = "0x312D46C", Offset = "0x312D46C", VA = "0x312D46C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017BE5")]
		[Address(RVA = "0x312D474", Offset = "0x312D474", VA = "0x312D474")]
		set
		{
		}
	}

	[Token(Token = "0x6017BD9")]
	[Address(RVA = "0x312D20C", Offset = "0x312D20C", VA = "0x312D20C")]
	static JsonWriter()
	{
	}

	[Token(Token = "0x6017BDA")]
	[Address(RVA = "0x3120280", Offset = "0x3120280", VA = "0x3120280")]
	public JsonWriter()
	{
	}

	[Token(Token = "0x6017BDB")]
	[Address(RVA = "0x312D3A8", Offset = "0x312D3A8", VA = "0x312D3A8")]
	public JsonWriter(StringBuilder sb)
	{
	}

	[Token(Token = "0x6017BDC")]
	[Address(RVA = "0x311FA10", Offset = "0x311FA10", VA = "0x311FA10")]
	public JsonWriter(TextWriter writer)
	{
	}

	[Token(Token = "0x6017BE6")]
	[Address(RVA = "0x312D47C", Offset = "0x312D47C", VA = "0x312D47C")]
	private void DoValidation(Condition cond)
	{
	}

	[Token(Token = "0x6017BE7")]
	[Address(RVA = "0x312D2A0", Offset = "0x312D2A0", VA = "0x312D2A0")]
	private void Init()
	{
	}

	[Token(Token = "0x6017BE8")]
	[Address(RVA = "0x312D850", Offset = "0x312D850", VA = "0x312D850")]
	private static void IntToHex(int n, char[] hex)
	{
	}

	[Token(Token = "0x6017BE9")]
	[Address(RVA = "0x312D8C8", Offset = "0x312D8C8", VA = "0x312D8C8")]
	private void Indent()
	{
	}

	[Token(Token = "0x6017BEA")]
	[Address(RVA = "0x312D8E4", Offset = "0x312D8E4", VA = "0x312D8E4")]
	private void Put(string str)
	{
	}

	[Token(Token = "0x6017BEB")]
	[Address(RVA = "0x312D99C", Offset = "0x312D99C", VA = "0x312D99C")]
	private void PutNewline()
	{
	}

	[Token(Token = "0x6017BEC")]
	[Address(RVA = "0x312D9A4", Offset = "0x312D9A4", VA = "0x312D9A4")]
	private void PutNewline(bool add_comma)
	{
	}

	[Token(Token = "0x6017BED")]
	[Address(RVA = "0x312DA84", Offset = "0x312DA84", VA = "0x312DA84")]
	private void PutString(string str)
	{
	}

	[Token(Token = "0x6017BEE")]
	[Address(RVA = "0x312DEEC", Offset = "0x312DEEC", VA = "0x312DEEC")]
	private void Unindent()
	{
	}

	[Token(Token = "0x6017BEF")]
	[Address(RVA = "0x312DF08", Offset = "0x312DF08", VA = "0x312DF08", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6017BF0")]
	[Address(RVA = "0x31299F4", Offset = "0x31299F4", VA = "0x31299F4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017BF1")]
	[Address(RVA = "0x311E5C4", Offset = "0x311E5C4", VA = "0x311E5C4")]
	public void Write(bool boolean)
	{
	}

	[Token(Token = "0x6017BF2")]
	[Address(RVA = "0x312A898", Offset = "0x312A898", VA = "0x312A898")]
	public void Write(decimal number)
	{
	}

	[Token(Token = "0x6017BF3")]
	[Address(RVA = "0x311E684", Offset = "0x311E684", VA = "0x311E684")]
	public void Write(double number)
	{
	}

	[Token(Token = "0x6017BF4")]
	[Address(RVA = "0x311E828", Offset = "0x311E828", VA = "0x311E828")]
	public void Write(int number)
	{
	}

	[Token(Token = "0x6017BF5")]
	[Address(RVA = "0x311E938", Offset = "0x311E938", VA = "0x311E938")]
	public void Write(long number)
	{
	}

	[Token(Token = "0x6017BF6")]
	[Address(RVA = "0x311E510", Offset = "0x311E510", VA = "0x311E510")]
	public void Write(string str)
	{
	}

	[Token(Token = "0x6017BF7")]
	[Address(RVA = "0x312970C", Offset = "0x312970C", VA = "0x312970C")]
	public void Write(ulong number)
	{
	}

	[Token(Token = "0x6017BF8")]
	[Address(RVA = "0x311EB54", Offset = "0x311EB54", VA = "0x311EB54")]
	public void WriteArrayEnd()
	{
	}

	[Token(Token = "0x6017BF9")]
	[Address(RVA = "0x311EA50", Offset = "0x311EA50", VA = "0x311EA50")]
	public void WriteArrayStart()
	{
	}

	[Token(Token = "0x6017BFA")]
	[Address(RVA = "0x311EF88", Offset = "0x311EF88", VA = "0x311EF88")]
	public void WriteObjectEnd()
	{
	}

	[Token(Token = "0x6017BFB")]
	[Address(RVA = "0x311ECA0", Offset = "0x311ECA0", VA = "0x311ECA0")]
	public void WriteObjectStart()
	{
	}

	[Token(Token = "0x6017BFC")]
	[Address(RVA = "0x311EDA4", Offset = "0x311EDA4", VA = "0x311EDA4")]
	public void WritePropertyName(string property_name)
	{
	}
}
