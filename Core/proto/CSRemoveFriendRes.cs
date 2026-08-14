using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200169A")]
public class CSRemoveFriendRes
{
	[Token(Token = "0x4009689")]
	[FieldOffset(Offset = "0x8")]
	public ulong remover;

	[Token(Token = "0x400968A")]
	[FieldOffset(Offset = "0x10")]
	public ulong removee;

	[Token(Token = "0x400968B")]
	[FieldOffset(Offset = "0x18")]
	public string lock_region;

	[Token(Token = "0x400968C")]
	[FieldOffset(Offset = "0x1C")]
	public string noti_region;

	[Token(Token = "0x6007CF5")]
	[Address(RVA = "0x3099118", Offset = "0x3099118", VA = "0x3099118")]
	public CSRemoveFriendRes()
	{
	}
}
