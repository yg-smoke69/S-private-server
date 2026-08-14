using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030B6")]
public class InventoryClothInfo : InventoryItemInfo, _Attribute
{
	[Token(Token = "0x4012866")]
	[FieldOffset(Offset = "0x48")]
	public AvatarWardrobeData wardrobeData;

	[Token(Token = "0x601463F")]
	[Address(RVA = "0x1EE008C", Offset = "0x1EE008C", VA = "0x1EE008C")]
	public InventoryClothInfo(Item it)
	{
	}

	[Token(Token = "0x6014640")]
	[Address(RVA = "0x1EE0314", Offset = "0x1EE0314", VA = "0x1EE0314")]
	public static implicit operator InventoryClothInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6014641")]
	[Address(RVA = "0x1EE03CC", Offset = "0x1EE03CC", VA = "0x1EE03CC", Slot = "5")]
	public int CompareTo(InventoryClothInfo other)
	{
		return default(int);
	}
}
