using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200196C")]
public class DigitalUniverseBStarCraftPlayerInitInfo
{
	[Token(Token = "0x4009FC7")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009FC8")]
	[FieldOffset(Offset = "0x10")]
	public string nick_name;

	[Token(Token = "0x4009FC9")]
	[FieldOffset(Offset = "0x14")]
	public uint head_pic;

	[Token(Token = "0x6007FC5")]
	[Address(RVA = "0x309E8AC", Offset = "0x309E8AC", VA = "0x309E8AC")]
	public DigitalUniverseBStarCraftPlayerInitInfo()
	{
	}
}
