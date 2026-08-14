using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A58")]
public class AvatarLevelCardInfo
{
	[Token(Token = "0x400A4FB")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A4FC")]
	[FieldOffset(Offset = "0xC")]
	public uint max_level;

	[Token(Token = "0x60080B0")]
	[Address(RVA = "0x317B220", Offset = "0x317B220", VA = "0x317B220")]
	public AvatarLevelCardInfo()
	{
	}
}
