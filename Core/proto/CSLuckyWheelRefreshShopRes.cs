using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018B6")]
public class CSLuckyWheelRefreshShopRes
{
	[Token(Token = "0x4009DA7")]
	[FieldOffset(Offset = "0x8")]
	public uint remain_free_refresh_times;

	[Token(Token = "0x4009DA8")]
	[FieldOffset(Offset = "0xC")]
	public uint[] current_shop_item_id_list;

	[Token(Token = "0x6007F0F")]
	[Address(RVA = "0x3097A40", Offset = "0x3097A40", VA = "0x3097A40")]
	public CSLuckyWheelRefreshShopRes()
	{
	}
}
