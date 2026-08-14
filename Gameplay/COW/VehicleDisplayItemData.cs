using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200213C")]
public class VehicleDisplayItemData
{
	[Token(Token = "0x400D064")]
	[FieldOffset(Offset = "0x8")]
	public VehicleSkinBaseInfo Info;

	[Token(Token = "0x400D065")]
	[FieldOffset(Offset = "0xC")]
	public bool IsEquipped;

	[Token(Token = "0x600AE95")]
	[Address(RVA = "0x219B5E0", Offset = "0x219B5E0", VA = "0x219B5E0")]
	public VehicleDisplayItemData()
	{
	}

	[Token(Token = "0x600AE96")]
	[Address(RVA = "0x219B5E8", Offset = "0x219B5E8", VA = "0x219B5E8")]
	public int CompareTo(VehicleDisplayItemData other)
	{
		return default(int);
	}
}
