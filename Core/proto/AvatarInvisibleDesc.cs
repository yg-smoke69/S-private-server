using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A5F")]
public class AvatarInvisibleDesc
{
	[Token(Token = "0x400A51A")]
	[FieldOffset(Offset = "0x8")]
	public uint invisible_avatar_id;

	[Token(Token = "0x400A51B")]
	[FieldOffset(Offset = "0xC")]
	public uint original_ip_avatar_id;

	[Token(Token = "0x60080B7")]
	[Address(RVA = "0x317B218", Offset = "0x317B218", VA = "0x317B218")]
	public AvatarInvisibleDesc()
	{
	}
}
