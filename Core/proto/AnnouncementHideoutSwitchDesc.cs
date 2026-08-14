using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C2C")]
public class AnnouncementHideoutSwitchDesc
{
	[Token(Token = "0x400B16A")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400B16B")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x6008290")]
	[Address(RVA = "0x317AB3C", Offset = "0x317AB3C", VA = "0x317AB3C")]
	public AnnouncementHideoutSwitchDesc()
	{
	}
}
