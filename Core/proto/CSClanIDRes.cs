using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001622")]
public class CSClanIDRes
{
	[Token(Token = "0x400953B")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x400953C")]
	[FieldOffset(Offset = "0x10")]
	public string clan_channel_secret;

	[Token(Token = "0x6007C6C")]
	[Address(RVA = "0x317EAC8", Offset = "0x317EAC8", VA = "0x317EAC8")]
	public CSClanIDRes()
	{
	}
}
