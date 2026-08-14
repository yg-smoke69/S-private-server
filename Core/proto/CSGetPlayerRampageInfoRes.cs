using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017EF")]
public class CSGetPlayerRampageInfoRes
{
	[Token(Token = "0x4009BB7")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009BB8")]
	[FieldOffset(Offset = "0x10")]
	public ELimitedEvent.RampageFaction faction;

	[Token(Token = "0x4009BB9")]
	[FieldOffset(Offset = "0x18")]
	public ulong rampage_points;

	[Token(Token = "0x4009BBA")]
	[FieldOffset(Offset = "0x20")]
	public uint rampage_rank;

	[Token(Token = "0x6007E49")]
	[Address(RVA = "0x3094978", Offset = "0x3094978", VA = "0x3094978")]
	public CSGetPlayerRampageInfoRes()
	{
	}
}
