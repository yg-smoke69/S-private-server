using System.Text;
using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FF8")]
public class JSONNull : JSONNode
{
	[Token(Token = "0x401AEBA")]
	[FieldOffset(Offset = "0x0")]
	private static JSONNull m_StaticInstance;

	[Token(Token = "0x401AEBB")]
	[FieldOffset(Offset = "0x4")]
	public static bool reuseSameInstance;

	[Token(Token = "0x17001C9C")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x601A0E6")]
		[Address(RVA = "0x21CC1A8", Offset = "0x21CC1A8", VA = "0x21CC1A8", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17001C9D")]
	public override bool IsNull
	{
		[Token(Token = "0x601A0E7")]
		[Address(RVA = "0x21CC1B0", Offset = "0x21CC1B0", VA = "0x21CC1B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C9E")]
	public override string Value
	{
		[Token(Token = "0x601A0E9")]
		[Address(RVA = "0x21CC1D4", Offset = "0x21CC1D4", VA = "0x21CC1D4", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A0EA")]
		[Address(RVA = "0x21CC230", Offset = "0x21CC230", VA = "0x21CC230", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17001C9F")]
	public override bool AsBool
	{
		[Token(Token = "0x601A0EB")]
		[Address(RVA = "0x21CC234", Offset = "0x21CC234", VA = "0x21CC234", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A0EC")]
		[Address(RVA = "0x21CC23C", Offset = "0x21CC23C", VA = "0x21CC23C", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x601A0E4")]
	[Address(RVA = "0x21CC124", Offset = "0x21CC124", VA = "0x21CC124")]
	private JSONNull()
	{
	}

	[Token(Token = "0x601A0E5")]
	[Address(RVA = "0x21C7798", Offset = "0x21C7798", VA = "0x21C7798")]
	public static JSONNull CreateOrGet()
	{
		return null;
	}

	[Token(Token = "0x601A0E8")]
	[Address(RVA = "0x21CC1B8", Offset = "0x21CC1B8", VA = "0x21CC1B8", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x601A0ED")]
	[Address(RVA = "0x21CC240", Offset = "0x21CC240", VA = "0x21CC240", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601A0EE")]
	[Address(RVA = "0x21CC2E8", Offset = "0x21CC2E8", VA = "0x21CC2E8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x601A0EF")]
	[Address(RVA = "0x21CC2F0", Offset = "0x21CC2F0", VA = "0x21CC2F0", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}
}
