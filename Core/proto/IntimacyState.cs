using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013D5")]
public class IntimacyState
{
	[Token(Token = "0x4008B3C")]
	[FieldOffset(Offset = "0x8")]
	public ulong friend_id;

	[Token(Token = "0x4008B3D")]
	[FieldOffset(Offset = "0x10")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x4008B3E")]
	[FieldOffset(Offset = "0x14")]
	public uint intimacy;

	[Token(Token = "0x4008B3F")]
	[FieldOffset(Offset = "0x18")]
	public long create_at;

	[Token(Token = "0x4008B40")]
	[FieldOffset(Offset = "0x20")]
	public uint maintain_days;

	[Token(Token = "0x4008B41")]
	[FieldOffset(Offset = "0x24")]
	public EFriend.SpecialFriendState state;

	[Token(Token = "0x4008B42")]
	[FieldOffset(Offset = "0x28")]
	public long request_at;

	[Token(Token = "0x4008B43")]
	[FieldOffset(Offset = "0x30")]
	public bool is_visible;

	[Token(Token = "0x6007AB8")]
	[Address(RVA = "0x30A3E60", Offset = "0x30A3E60", VA = "0x30A3E60")]
	public IntimacyState()
	{
	}
}
