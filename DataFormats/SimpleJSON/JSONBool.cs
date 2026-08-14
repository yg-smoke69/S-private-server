using System.Text;
using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FF7")]
public class JSONBool : JSONNode
{
	[Token(Token = "0x401AEB9")]
	[FieldOffset(Offset = "0x8")]
	private bool m_Data;

	[Token(Token = "0x17001C98")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x601A0DA")]
		[Address(RVA = "0x21C845C", Offset = "0x21C845C", VA = "0x21C845C", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17001C99")]
	public override bool IsBoolean
	{
		[Token(Token = "0x601A0DB")]
		[Address(RVA = "0x21C8464", Offset = "0x21C8464", VA = "0x21C8464", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C9A")]
	public override string Value
	{
		[Token(Token = "0x601A0DD")]
		[Address(RVA = "0x21C8488", Offset = "0x21C8488", VA = "0x21C8488", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A0DE")]
		[Address(RVA = "0x21C8494", Offset = "0x21C8494", VA = "0x21C8494", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17001C9B")]
	public override bool AsBool
	{
		[Token(Token = "0x601A0DF")]
		[Address(RVA = "0x21C853C", Offset = "0x21C853C", VA = "0x21C853C", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A0E0")]
		[Address(RVA = "0x21C8544", Offset = "0x21C8544", VA = "0x21C8544", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x601A0D8")]
	[Address(RVA = "0x21C8330", Offset = "0x21C8330", VA = "0x21C8330")]
	public JSONBool(bool aData)
	{
	}

	[Token(Token = "0x601A0D9")]
	[Address(RVA = "0x21C83BC", Offset = "0x21C83BC", VA = "0x21C83BC")]
	public JSONBool(string aData)
	{
	}

	[Token(Token = "0x601A0DC")]
	[Address(RVA = "0x21C846C", Offset = "0x21C846C", VA = "0x21C846C", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x601A0E1")]
	[Address(RVA = "0x21C854C", Offset = "0x21C854C", VA = "0x21C854C", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}

	[Token(Token = "0x601A0E2")]
	[Address(RVA = "0x21C85E0", Offset = "0x21C85E0", VA = "0x21C85E0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601A0E3")]
	[Address(RVA = "0x21C8674", Offset = "0x21C8674", VA = "0x21C8674", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
