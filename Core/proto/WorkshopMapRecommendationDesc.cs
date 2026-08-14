using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD5")]
public class WorkshopMapRecommendationDesc
{
	[Token(Token = "0x400AF16")]
	[FieldOffset(Offset = "0x8")]
	public string id;

	[Token(Token = "0x400AF17")]
	[FieldOffset(Offset = "0xC")]
	public uint order;

	[Token(Token = "0x400AF18")]
	[FieldOffset(Offset = "0x10")]
	public string picture;

	[Token(Token = "0x400AF19")]
	[FieldOffset(Offset = "0x18")]
	public long shelf_time;

	[Token(Token = "0x400AF1A")]
	[FieldOffset(Offset = "0x20")]
	public long under_time;

	[Token(Token = "0x400AF1B")]
	[FieldOffset(Offset = "0x28")]
	public uint map_logo;

	[Token(Token = "0x400AF1C")]
	[FieldOffset(Offset = "0x2C")]
	public bool mandatory;

	[Token(Token = "0x6008230")]
	[Address(RVA = "0x33E67C0", Offset = "0x33E67C0", VA = "0x33E67C0")]
	public WorkshopMapRecommendationDesc()
	{
	}
}
