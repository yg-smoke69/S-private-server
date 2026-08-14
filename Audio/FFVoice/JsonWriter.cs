using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B59")]
public class JsonWriter
{
	[Token(Token = "0x4019458")]
	[FieldOffset(Offset = "0x0")]
	private static NumberFormatInfo number_format;

	[Token(Token = "0x4019459")]
	[FieldOffset(Offset = "0x8")]
	private WriterContext context;

	[Token(Token = "0x401945A")]
	[FieldOffset(Offset = "0xC")]
	private Stack<WriterContext> ctx_stack;

	[Token(Token = "0x401945B")]
	[FieldOffset(Offset = "0x10")]
	private bool has_reached_end;

	[Token(Token = "0x401945C")]
	[FieldOffset(Offset = "0x14")]
	private char[] hex_seq;

	[Token(Token = "0x401945D")]
	[FieldOffset(Offset = "0x18")]
	private int indentation;

	[Token(Token = "0x401945E")]
	[FieldOffset(Offset = "0x1C")]
	private int indent_value;

	[Token(Token = "0x401945F")]
	[FieldOffset(Offset = "0x20")]
	private StringBuilder inst_string_builder;

	[Token(Token = "0x4019460")]
	[FieldOffset(Offset = "0x24")]
	private bool pretty_print;

	[Token(Token = "0x4019461")]
	[FieldOffset(Offset = "0x25")]
	private bool validate;

	[Token(Token = "0x4019462")]
	[FieldOffset(Offset = "0x28")]
	private TextWriter writer;

	[Token(Token = "0x1700181C")]
	public int IndentValue
	{
		[Token(Token = "0x60179EB")]
		[Address(RVA = "0x26A4E78", Offset = "0x26A4E78", VA = "0x26A4E78")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60179EC")]
		[Address(RVA = "0x26A4E80", Offset = "0x26A4E80", VA = "0x26A4E80")]
		set
		{
		}
	}

	[Token(Token = "0x1700181D")]
	public bool PrettyPrint
	{
		[Token(Token = "0x60179ED")]
		[Address(RVA = "0x26A4EAC", Offset = "0x26A4EAC", VA = "0x26A4EAC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60179EE")]
		[Address(RVA = "0x26A4EB4", Offset = "0x26A4EB4", VA = "0x26A4EB4")]
		set
		{
		}
	}

	[Token(Token = "0x1700181E")]
	public TextWriter TextWriter
	{
		[Token(Token = "0x60179EF")]
		[Address(RVA = "0x26A4EBC", Offset = "0x26A4EBC", VA = "0x26A4EBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700181F")]
	public bool Validate
	{
		[Token(Token = "0x60179F0")]
		[Address(RVA = "0x26A4EC4", Offset = "0x26A4EC4", VA = "0x26A4EC4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60179F1")]
		[Address(RVA = "0x26A4ECC", Offset = "0x26A4ECC", VA = "0x26A4ECC")]
		set
		{
		}
	}

	[Token(Token = "0x60179E7")]
	[Address(RVA = "0x26A4AE8", Offset = "0x26A4AE8", VA = "0x26A4AE8")]
	static JsonWriter()
	{
	}

	[Token(Token = "0x60179E8")]
	[Address(RVA = "0x26A4B7C", Offset = "0x26A4B7C", VA = "0x26A4B7C")]
	public JsonWriter()
	{
	}

	[Token(Token = "0x60179E9")]
	[Address(RVA = "0x26A4D30", Offset = "0x26A4D30", VA = "0x26A4D30")]
	public JsonWriter(StringBuilder sb)
	{
	}

	[Token(Token = "0x60179EA")]
	[Address(RVA = "0x26A4DB0", Offset = "0x26A4DB0", VA = "0x26A4DB0")]
	public JsonWriter(TextWriter writer)
	{
	}

	[Token(Token = "0x60179F2")]
	[Address(RVA = "0x26A4ED4", Offset = "0x26A4ED4", VA = "0x26A4ED4")]
	private void DoValidation(Condition cond)
	{
	}

	[Token(Token = "0x60179F3")]
	[Address(RVA = "0x26A4C28", Offset = "0x26A4C28", VA = "0x26A4C28")]
	private void Init()
	{
	}

	[Token(Token = "0x60179F4")]
	[Address(RVA = "0x26A52B0", Offset = "0x26A52B0", VA = "0x26A52B0")]
	private static void IntToHex(int n, char[] hex)
	{
	}

	[Token(Token = "0x60179F5")]
	[Address(RVA = "0x26A5328", Offset = "0x26A5328", VA = "0x26A5328")]
	private void Indent()
	{
	}

	[Token(Token = "0x60179F6")]
	[Address(RVA = "0x26A5344", Offset = "0x26A5344", VA = "0x26A5344")]
	private void Put(string str)
	{
	}

	[Token(Token = "0x60179F7")]
	[Address(RVA = "0x26A53FC", Offset = "0x26A53FC", VA = "0x26A53FC")]
	private void PutNewline()
	{
	}

	[Token(Token = "0x60179F8")]
	[Address(RVA = "0x26A5404", Offset = "0x26A5404", VA = "0x26A5404")]
	private void PutNewline(bool add_comma)
	{
	}

	[Token(Token = "0x60179F9")]
	[Address(RVA = "0x26A54E4", Offset = "0x26A54E4", VA = "0x26A54E4")]
	private void PutString(string str)
	{
	}

	[Token(Token = "0x60179FA")]
	[Address(RVA = "0x26A5930", Offset = "0x26A5930", VA = "0x26A5930")]
	private void Unindent()
	{
	}

	[Token(Token = "0x60179FB")]
	[Address(RVA = "0x26A594C", Offset = "0x26A594C", VA = "0x26A594C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60179FC")]
	[Address(RVA = "0x26A59FC", Offset = "0x26A59FC", VA = "0x26A59FC")]
	public void Reset()
	{
	}

	[Token(Token = "0x60179FD")]
	[Address(RVA = "0x26A5AFC", Offset = "0x26A5AFC", VA = "0x26A5AFC")]
	public void Write(bool boolean)
	{
	}

	[Token(Token = "0x60179FE")]
	[Address(RVA = "0x26A5BBC", Offset = "0x26A5BBC", VA = "0x26A5BBC")]
	public void Write(decimal number)
	{
	}

	[Token(Token = "0x60179FF")]
	[Address(RVA = "0x26A5CE8", Offset = "0x26A5CE8", VA = "0x26A5CE8")]
	public void Write(double number)
	{
	}

	[Token(Token = "0x6017A00")]
	[Address(RVA = "0x26A5E8C", Offset = "0x26A5E8C", VA = "0x26A5E8C")]
	public void Write(int number)
	{
	}

	[Token(Token = "0x6017A01")]
	[Address(RVA = "0x26A5F9C", Offset = "0x26A5F9C", VA = "0x26A5F9C")]
	public void Write(long number)
	{
	}

	[Token(Token = "0x6017A02")]
	[Address(RVA = "0x26A60B4", Offset = "0x26A60B4", VA = "0x26A60B4")]
	public void Write(string str)
	{
	}

	[Token(Token = "0x6017A03")]
	[Address(RVA = "0x26A6168", Offset = "0x26A6168", VA = "0x26A6168")]
	public void Write(ulong number)
	{
	}

	[Token(Token = "0x6017A04")]
	[Address(RVA = "0x26A6280", Offset = "0x26A6280", VA = "0x26A6280")]
	public void WriteArrayEnd()
	{
	}

	[Token(Token = "0x6017A05")]
	[Address(RVA = "0x26A63CC", Offset = "0x26A63CC", VA = "0x26A63CC")]
	public void WriteArrayStart()
	{
	}

	[Token(Token = "0x6017A06")]
	[Address(RVA = "0x26A64D0", Offset = "0x26A64D0", VA = "0x26A64D0")]
	public void WriteObjectEnd()
	{
	}

	[Token(Token = "0x6017A07")]
	[Address(RVA = "0x26A661C", Offset = "0x26A661C", VA = "0x26A661C")]
	public void WriteObjectStart()
	{
	}

	[Token(Token = "0x6017A08")]
	[Address(RVA = "0x26A6720", Offset = "0x26A6720", VA = "0x26A6720")]
	public void WritePropertyName(string property_name)
	{
	}
}
