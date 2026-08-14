using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001385")]
public class AvatarAwakenRefreshCount
{
	[Token(Token = "0x40089C6")]
	[FieldOffset(Offset = "0x8")]
	public uint original_avatar_id;

	[Token(Token = "0x40089C7")]
	[FieldOffset(Offset = "0xC")]
	public uint refresh_count;

	[Token(Token = "0x6007A86")]
	[Address(RVA = "0x317B15C", Offset = "0x317B15C", VA = "0x317B15C")]
	public AvatarAwakenRefreshCount()
	{
	}
}
