using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A9")]
public class AvatarLevelUpItem
{
	[Token(Token = "0x400E327")]
	[FieldOffset(Offset = "0x8")]
	public BaseItemInfo info;

	[Token(Token = "0x400E328")]
	[FieldOffset(Offset = "0xC")]
	public int currentlevel;

	[Token(Token = "0x400E329")]
	[FieldOffset(Offset = "0x10")]
	public int itemlevel;

	[Token(Token = "0x600D1D8")]
	[Address(RVA = "0x234D59C", Offset = "0x234D59C", VA = "0x234D59C")]
	public AvatarLevelUpItem()
	{
	}
}
