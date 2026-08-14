using Il2CppDummyDll;

namespace WwiseGameSyncs.Switch;

[Token(Token = "0x20002B1")]
internal class Material_List : SwitchBase
{
	[Token(Token = "0x40032AF")]
	[FieldOffset(Offset = "0x0")]
	public static Material_List Player_Body_Armored;

	[Token(Token = "0x40032B0")]
	[FieldOffset(Offset = "0x4")]
	public static Material_List Player_Body_Bare;

	[Token(Token = "0x40032B1")]
	[FieldOffset(Offset = "0x8")]
	public static Material_List Player_Head_Bare;

	[Token(Token = "0x40032B2")]
	[FieldOffset(Offset = "0xC")]
	public static Material_List Player_Head_Helmeted;

	[Token(Token = "0x40032B3")]
	[FieldOffset(Offset = "0x10")]
	public static Material_List ShieldGun_Shield;

	[Token(Token = "0x40032B4")]
	[FieldOffset(Offset = "0x14")]
	public static Material_List Surface_Concrete;

	[Token(Token = "0x40032B5")]
	[FieldOffset(Offset = "0x18")]
	public static Material_List Surface_Metal;

	[Token(Token = "0x40032B6")]
	[FieldOffset(Offset = "0x1C")]
	public static Material_List Surface_Snow;

	[Token(Token = "0x40032B7")]
	[FieldOffset(Offset = "0x20")]
	public static Material_List Surface_Stone;

	[Token(Token = "0x40032B8")]
	[FieldOffset(Offset = "0x24")]
	public static Material_List Surface_Wood;

	[Token(Token = "0x40032B9")]
	[FieldOffset(Offset = "0x28")]
	public static Material_List Water_Deep;

	[Token(Token = "0x40032BA")]
	[FieldOffset(Offset = "0x2C")]
	public static Material_List Water_Shoal;

	[Token(Token = "0x40032BB")]
	[FieldOffset(Offset = "0x30")]
	public static Material_List Water_Wet;

	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x336E63C", Offset = "0x336E63C", VA = "0x336E63C")]
	private Material_List(uint _value)
	{
	}
}
