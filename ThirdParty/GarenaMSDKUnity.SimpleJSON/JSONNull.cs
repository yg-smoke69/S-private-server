using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x2000027")]
public class JSONNull : JSONNode
{
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x0")]
	private static JSONNull m_StaticInstance;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x4")]
	public static bool reuseSameInstance;

	[Token(Token = "0x1700004A")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x34FFFD8", Offset = "0x34FFFD8", VA = "0x34FFFD8", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x1700004B")]
	public override bool IsNull
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x34FFFE0", Offset = "0x34FFFE0", VA = "0x34FFFE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700004C")]
	public override string Value
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x3500004", Offset = "0x3500004", VA = "0x3500004", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x3500060", Offset = "0x3500060", VA = "0x3500060", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public override bool AsBool
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x3500064", Offset = "0x3500064", VA = "0x3500064", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x350006C", Offset = "0x350006C", VA = "0x350006C", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x34FFE78", Offset = "0x34FFE78", VA = "0x34FFE78")]
	private JSONNull()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x34FFEFC", Offset = "0x34FFEFC", VA = "0x34FFEFC")]
	public static JSONNull CreateOrGet()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x34FFFE8", Offset = "0x34FFFE8", VA = "0x34FFFE8", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x3500070", Offset = "0x3500070", VA = "0x3500070", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x3500118", Offset = "0x3500118", VA = "0x3500118", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x3500120", Offset = "0x3500120", VA = "0x3500120", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}
}
