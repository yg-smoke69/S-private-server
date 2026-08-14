using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200169B")]
public class CSGetFriendListReq
{
	[Token(Token = "0x400968D")]
	[FieldOffset(Offset = "0x8")]
	public bool need_presence;

	[Token(Token = "0x400968E")]
	[FieldOffset(Offset = "0x9")]
	public bool need_stats;

	[Token(Token = "0x400968F")]
	[FieldOffset(Offset = "0xA")]
	public bool need_ranking_stats;

	[Token(Token = "0x4009690")]
	[FieldOffset(Offset = "0xB")]
	public bool need_casual_stats;

	[Token(Token = "0x4009691")]
	[FieldOffset(Offset = "0xC")]
	public bool need_cs_ranking_stats;

	[Token(Token = "0x4009692")]
	[FieldOffset(Offset = "0x10")]
	public uint need_periodic_ranking_game_mode;

	[Token(Token = "0x6007CF6")]
	[Address(RVA = "0x31852F0", Offset = "0x31852F0", VA = "0x31852F0")]
	public CSGetFriendListReq()
	{
	}

	[Token(Token = "0x6007CF7")]
	[Address(RVA = "0x31852F8", Offset = "0x31852F8", VA = "0x31852F8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CF8")]
	[Address(RVA = "0x318545C", Offset = "0x318545C", VA = "0x318545C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
