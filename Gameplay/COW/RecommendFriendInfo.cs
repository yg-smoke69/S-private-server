using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200303A")]
public class RecommendFriendInfo
{
	[Token(Token = "0x401263A")]
	[FieldOffset(Offset = "0x8")]
	public ulong AccountID;

	[Token(Token = "0x401263B")]
	[FieldOffset(Offset = "0x10")]
	public string Nickname;

	[Token(Token = "0x401263C")]
	[FieldOffset(Offset = "0x14")]
	public int Rank;

	[Token(Token = "0x401263D")]
	[FieldOffset(Offset = "0x18")]
	public int RankPoint;

	[Token(Token = "0x401263E")]
	[FieldOffset(Offset = "0x1C")]
	public int PeakRankPos;

	[Token(Token = "0x401263F")]
	[FieldOffset(Offset = "0x20")]
	public ESocial.Gender Gender;

	[Token(Token = "0x4012640")]
	[FieldOffset(Offset = "0x24")]
	public EFriendRecommendType Type;

	[Token(Token = "0x601431A")]
	[Address(RVA = "0x1970C30", Offset = "0x1970C30", VA = "0x1970C30")]
	public RecommendFriendInfo()
	{
	}
}
