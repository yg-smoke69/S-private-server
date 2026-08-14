using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200168A")]
public class CSUnlockAvatarAwakenComicReq
{
	[Token(Token = "0x4009664")]
	[FieldOffset(Offset = "0x8")]
	public uint original_avatar_id;

	[Token(Token = "0x4009665")]
	[FieldOffset(Offset = "0xC")]
	public uint comic_id;

	[Token(Token = "0x6007CD4")]
	[Address(RVA = "0x309A48C", Offset = "0x309A48C", VA = "0x309A48C")]
	public CSUnlockAvatarAwakenComicReq()
	{
	}
}
