using System.Text;
using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FF5")]
public class JSONString : JSONNode
{
	[Token(Token = "0x401AEB7")]
	[FieldOffset(Offset = "0x8")]
	private string m_Data;

	[Token(Token = "0x17001C91")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x601A0C3")]
		[Address(RVA = "0x21CDE40", Offset = "0x21CDE40", VA = "0x21CDE40", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17001C92")]
	public override bool IsString
	{
		[Token(Token = "0x601A0C4")]
		[Address(RVA = "0x21CDE48", Offset = "0x21CDE48", VA = "0x21CDE48", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C93")]
	public override string Value
	{
		[Token(Token = "0x601A0C6")]
		[Address(RVA = "0x21CDE6C", Offset = "0x21CDE6C", VA = "0x21CDE6C", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A0C7")]
		[Address(RVA = "0x21CDE74", Offset = "0x21CDE74", VA = "0x21CDE74", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x601A0C2")]
	[Address(RVA = "0x21C9E38", Offset = "0x21C9E38", VA = "0x21C9E38")]
	public JSONString(string aData)
	{
	}

	[Token(Token = "0x601A0C5")]
	[Address(RVA = "0x21CDE50", Offset = "0x21CDE50", VA = "0x21CDE50", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x601A0C8")]
	[Address(RVA = "0x21CDE7C", Offset = "0x21CDE7C", VA = "0x21CDE7C", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}

	[Token(Token = "0x601A0C9")]
	[Address(RVA = "0x21CDF70", Offset = "0x21CDF70", VA = "0x21CDF70", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601A0CA")]
	[Address(RVA = "0x21CE0F8", Offset = "0x21CE0F8", VA = "0x21CE0F8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
