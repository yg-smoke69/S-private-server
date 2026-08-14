using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A0C")]
public class VeteranRewardDesc
{
	[Token(Token = "0x400A348")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A349")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400A34A")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc award;

	[Token(Token = "0x400A34B")]
	[FieldOffset(Offset = "0x14")]
	public string cdn_url_key;

	[Token(Token = "0x6008064")]
	[Address(RVA = "0x33E46D0", Offset = "0x33E46D0", VA = "0x33E46D0")]
	public VeteranRewardDesc()
	{
	}
}
