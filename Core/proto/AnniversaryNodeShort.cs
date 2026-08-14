using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017E3")]
public class AnniversaryNodeShort
{
	[Token(Token = "0x4009B9C")]
	[FieldOffset(Offset = "0x8")]
	public uint node_id;

	[Token(Token = "0x4009B9D")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.NodeStatus status;

	[Token(Token = "0x4009B9E")]
	[FieldOffset(Offset = "0x10")]
	public uint unlocked_timestamp;

	[Token(Token = "0x4009B9F")]
	[FieldOffset(Offset = "0x18")]
	public ulong materials_progress;

	[Token(Token = "0x4009BA0")]
	[FieldOffset(Offset = "0x20")]
	public ulong materials_target;

	[Token(Token = "0x6007E3D")]
	[Address(RVA = "0x317A8D0", Offset = "0x317A8D0", VA = "0x317A8D0")]
	public AnniversaryNodeShort()
	{
	}
}
