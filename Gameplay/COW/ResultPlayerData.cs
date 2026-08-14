using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003261")]
internal class ResultPlayerData
{
	[Token(Token = "0x40132B7")]
	[FieldOffset(Offset = "0x8")]
	public ulong userId;

	[Token(Token = "0x40132B8")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x40132B9")]
	[FieldOffset(Offset = "0x14")]
	public uint kill;

	[Token(Token = "0x40132BA")]
	[FieldOffset(Offset = "0x18")]
	public uint deadCnt;

	[Token(Token = "0x40132BB")]
	[FieldOffset(Offset = "0x1C")]
	public uint assistCnt;

	[Token(Token = "0x40132BC")]
	[FieldOffset(Offset = "0x20")]
	public uint damage;

	[Token(Token = "0x40132BD")]
	[FieldOffset(Offset = "0x24")]
	public int factionId;

	[Token(Token = "0x40132BE")]
	[FieldOffset(Offset = "0x28")]
	public int score;

	[Token(Token = "0x40132BF")]
	[FieldOffset(Offset = "0x30")]
	public IHAAMHPPLMG player_id;

	[Token(Token = "0x60153D5")]
	[Address(RVA = "0x2408CA0", Offset = "0x2408CA0", VA = "0x2408CA0")]
	public ResultPlayerData()
	{
	}
}
