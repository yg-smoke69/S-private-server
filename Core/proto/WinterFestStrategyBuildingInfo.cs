using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001854")]
public class WinterFestStrategyBuildingInfo
{
	[Token(Token = "0x4009CC3")]
	[FieldOffset(Offset = "0x8")]
	public EMiniGame.BuildingType buidling_type;

	[Token(Token = "0x4009CC4")]
	[FieldOffset(Offset = "0xC")]
	public uint building_level;

	[Token(Token = "0x4009CC5")]
	[FieldOffset(Offset = "0x10")]
	public uint last_update_at;

	[Token(Token = "0x4009CC6")]
	[FieldOffset(Offset = "0x14")]
	public uint uncollected_product;

	[Token(Token = "0x6007EAD")]
	[Address(RVA = "0x33E5C6C", Offset = "0x33E5C6C", VA = "0x33E5C6C")]
	public WinterFestStrategyBuildingInfo()
	{
	}
}
