using System.Text;
using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FF6")]
public class JSONNumber : JSONNode
{
	[Token(Token = "0x401AEB8")]
	[FieldOffset(Offset = "0x8")]
	private double m_Data;

	[Token(Token = "0x17001C94")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x601A0CD")]
		[Address(RVA = "0x21CC488", Offset = "0x21CC488", VA = "0x21CC488", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17001C95")]
	public override bool IsNumber
	{
		[Token(Token = "0x601A0CE")]
		[Address(RVA = "0x21CC490", Offset = "0x21CC490", VA = "0x21CC490", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C96")]
	public override string Value
	{
		[Token(Token = "0x601A0D0")]
		[Address(RVA = "0x21CC4B4", Offset = "0x21CC4B4", VA = "0x21CC4B4", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A0D1")]
		[Address(RVA = "0x21CC4C0", Offset = "0x21CC4C0", VA = "0x21CC4C0", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17001C97")]
	public override double AsDouble
	{
		[Token(Token = "0x601A0D2")]
		[Address(RVA = "0x21CC504", Offset = "0x21CC504", VA = "0x21CC504", Slot = "29")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x601A0D3")]
		[Address(RVA = "0x21CC510", Offset = "0x21CC510", VA = "0x21CC510", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x601A0CB")]
	[Address(RVA = "0x21C8CD8", Offset = "0x21C8CD8", VA = "0x21C8CD8")]
	public JSONNumber(double aData)
	{
	}

	[Token(Token = "0x601A0CC")]
	[Address(RVA = "0x21CC3E8", Offset = "0x21CC3E8", VA = "0x21CC3E8")]
	public JSONNumber(string aData)
	{
	}

	[Token(Token = "0x601A0CF")]
	[Address(RVA = "0x21CC498", Offset = "0x21CC498", VA = "0x21CC498", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x601A0D4")]
	[Address(RVA = "0x21CC520", Offset = "0x21CC520", VA = "0x21CC520", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}

	[Token(Token = "0x601A0D5")]
	[Address(RVA = "0x21CC568", Offset = "0x21CC568", VA = "0x21CC568")]
	private static bool IsNumeric(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x601A0D6")]
	[Address(RVA = "0x21CC6C4", Offset = "0x21CC6C4", VA = "0x21CC6C4", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601A0D7")]
	[Address(RVA = "0x21CC848", Offset = "0x21CC848", VA = "0x21CC848", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
