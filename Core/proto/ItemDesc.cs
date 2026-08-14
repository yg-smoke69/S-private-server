using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200199C")]
public class ItemDesc
{
	[Token(Token = "0x400A087")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A088")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.ItemType type;

	[Token(Token = "0x400A089")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400A08A")]
	[FieldOffset(Offset = "0x14")]
	public string desc;

	[Token(Token = "0x400A08B")]
	[FieldOffset(Offset = "0x18")]
	public uint is_unique;

	[Token(Token = "0x400A08C")]
	[FieldOffset(Offset = "0x1C")]
	public EInventory.GenderType gender;

	[Token(Token = "0x400A08D")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.CollectionType collection_type;

	[Token(Token = "0x400A08E")]
	[FieldOffset(Offset = "0x24")]
	public uint Rare;

	[Token(Token = "0x400A08F")]
	[FieldOffset(Offset = "0x28")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x400A090")]
	[FieldOffset(Offset = "0x2C")]
	public uint return_id;

	[Token(Token = "0x400A091")]
	[FieldOffset(Offset = "0x30")]
	public uint return_num;

	[Token(Token = "0x400A092")]
	[FieldOffset(Offset = "0x34")]
	public EInventory.ItemSubType sub_type;

	[Token(Token = "0x400A093")]
	[FieldOffset(Offset = "0x38")]
	public string end_time;

	[Token(Token = "0x400A094")]
	[FieldOffset(Offset = "0x3C")]
	public bool test_data;

	[Token(Token = "0x6007FF3")]
	[Address(RVA = "0x30A3FAC", Offset = "0x30A3FAC", VA = "0x30A3FAC")]
	public ItemDesc()
	{
	}
}
