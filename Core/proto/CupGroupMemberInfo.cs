using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013EB")]
public class CupGroupMemberInfo
{
	[Token(Token = "0x4008B7E")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x4008B7F")]
	[FieldOffset(Offset = "0xC")]
	public uint cs_rank;

	[Token(Token = "0x4008B80")]
	[FieldOffset(Offset = "0x10")]
	public uint cs_ranking_points;

	[Token(Token = "0x4008B81")]
	[FieldOffset(Offset = "0x14")]
	public uint cs_peak_ranking_pos;

	[Token(Token = "0x6007ACC")]
	[Address(RVA = "0x309DC80", Offset = "0x309DC80", VA = "0x309DC80")]
	public CupGroupMemberInfo()
	{
	}
}
