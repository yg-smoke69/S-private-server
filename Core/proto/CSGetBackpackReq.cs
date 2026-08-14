using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015AE")]
public class CSGetBackpackReq
{
	[Token(Token = "0x40093E5")]
	[FieldOffset(Offset = "0x8")]
	public uint item_type;

	[Token(Token = "0x40093E6")]
	[FieldOffset(Offset = "0xC")]
	public bool is_login;

	[Token(Token = "0x40093E7")]
	[FieldOffset(Offset = "0x10")]
	public string language;

	[Token(Token = "0x6007BF6")]
	[Address(RVA = "0x3181DB0", Offset = "0x3181DB0", VA = "0x3181DB0")]
	public CSGetBackpackReq()
	{
	}

	[Token(Token = "0x6007BF7")]
	[Address(RVA = "0x3181E50", Offset = "0x3181E50", VA = "0x3181E50", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6007BF8")]
	[Address(RVA = "0x3181F28", Offset = "0x3181F28", VA = "0x3181F28", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
