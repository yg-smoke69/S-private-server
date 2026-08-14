using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200155D")]
public class CSLeaderboardReq
{
	[Token(Token = "0x40092E1")]
	[FieldOffset(Offset = "0x8")]
	public int main_type;

	[Token(Token = "0x40092E2")]
	[FieldOffset(Offset = "0xC")]
	public int sub_type;

	[Token(Token = "0x40092E3")]
	[FieldOffset(Offset = "0x10")]
	public ulong main_key;

	[Token(Token = "0x40092E4")]
	[FieldOffset(Offset = "0x18")]
	public ulong sub_key;

	[Token(Token = "0x40092E5")]
	[FieldOffset(Offset = "0x20")]
	public uint page_index;

	[Token(Token = "0x40092E6")]
	[FieldOffset(Offset = "0x24")]
	public uint page_size;

	[Token(Token = "0x40092E7")]
	[FieldOffset(Offset = "0x28")]
	public bool get_self;

	[Token(Token = "0x40092E8")]
	[FieldOffset(Offset = "0x2C")]
	public string region;

	[Token(Token = "0x40092E9")]
	[FieldOffset(Offset = "0x30")]
	public string lock_region;

	[Token(Token = "0x6007BA5")]
	[Address(RVA = "0x30975AC", Offset = "0x30975AC", VA = "0x30975AC")]
	public CSLeaderboardReq()
	{
	}
}
