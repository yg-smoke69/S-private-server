using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A28")]
public class ClanRacePointsGainDesc
{
	[Token(Token = "0x400A3DE")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A3DF")]
	[FieldOffset(Offset = "0xC")]
	public uint type;

	[Token(Token = "0x400A3E0")]
	[FieldOffset(Offset = "0x10")]
	public uint race_points;

	[Token(Token = "0x400A3E1")]
	[FieldOffset(Offset = "0x14")]
	public uint rank_solo;

	[Token(Token = "0x400A3E2")]
	[FieldOffset(Offset = "0x18")]
	public uint rank_duo;

	[Token(Token = "0x400A3E3")]
	[FieldOffset(Offset = "0x1C")]
	public uint rank_squad;

	[Token(Token = "0x400A3E4")]
	[FieldOffset(Offset = "0x20")]
	public uint match_mode;

	[Token(Token = "0x400A3E5")]
	[FieldOffset(Offset = "0x24")]
	public uint game_mode;

	[Token(Token = "0x6008080")]
	[Address(RVA = "0x309BFF4", Offset = "0x309BFF4", VA = "0x309BFF4")]
	public ClanRacePointsGainDesc()
	{
	}
}
