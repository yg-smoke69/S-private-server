using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A81")]
public class EPUpdateDesc
{
	[Token(Token = "0x400A60C")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_id;

	[Token(Token = "0x400A60D")]
	[FieldOffset(Offset = "0xC")]
	public bool ep_entrance;

	[Token(Token = "0x400A60E")]
	[FieldOffset(Offset = "0xD")]
	public bool ep_quest;

	[Token(Token = "0x400A60F")]
	[FieldOffset(Offset = "0xE")]
	public bool ep_badge;

	[Token(Token = "0x60080DE")]
	[Address(RVA = "0x309F76C", Offset = "0x309F76C", VA = "0x309F76C")]
	public EPUpdateDesc()
	{
	}
}
