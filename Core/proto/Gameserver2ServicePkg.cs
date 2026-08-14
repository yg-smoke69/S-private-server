using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200136C")]
public class Gameserver2ServicePkg
{
	[Token(Token = "0x4008948")]
	[FieldOffset(Offset = "0x8")]
	public EGameServerManager.Proto cmd;

	[Token(Token = "0x4008949")]
	[FieldOffset(Offset = "0xC")]
	public uint match_mode;

	[Token(Token = "0x400894A")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x400894B")]
	[FieldOffset(Offset = "0x18")]
	public byte[] data;

	[Token(Token = "0x400894C")]
	[FieldOffset(Offset = "0x20")]
	public ulong group_id;

	[Token(Token = "0x400894D")]
	[FieldOffset(Offset = "0x28")]
	public ulong pre_group_id;

	[Token(Token = "0x400894E")]
	[FieldOffset(Offset = "0x30")]
	public ulong match_id;

	[Token(Token = "0x400894F")]
	[FieldOffset(Offset = "0x38")]
	public ulong room_id;

	[Token(Token = "0x6007A6D")]
	[Address(RVA = "0x30A1D50", Offset = "0x30A1D50", VA = "0x30A1D50")]
	public Gameserver2ServicePkg()
	{
	}
}
