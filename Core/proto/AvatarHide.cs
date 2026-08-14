using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A54")]
public class AvatarHide
{
	[Token(Token = "0x400A4EA")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400A4EB")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400A4EC")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400A4ED")]
	[FieldOffset(Offset = "0x20")]
	public long ip_expired_time;

	[Token(Token = "0x60080AC")]
	[Address(RVA = "0x317B184", Offset = "0x317B184", VA = "0x317B184")]
	public AvatarHide()
	{
	}
}
