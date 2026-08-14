using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030B3")]
public class InventoryItemInfo : BaseItemInfo, _Attribute
{
	[Token(Token = "0x401285D")]
	[FieldOffset(Offset = "0x38")]
	public CSSharedItemData itemData;

	[Token(Token = "0x401285E")]
	[FieldOffset(Offset = "0x3C")]
	public Item protoItem;

	[Token(Token = "0x401285F")]
	[FieldOffset(Offset = "0x40")]
	public bool IsNewOwned;

	[Token(Token = "0x4012860")]
	[FieldOffset(Offset = "0x44")]
	public uint iID;

	[Token(Token = "0x6014626")]
	[Address(RVA = "0x1EE0164", Offset = "0x1EE0164", VA = "0x1EE0164")]
	public InventoryItemInfo(Item it)
	{
	}

	[Token(Token = "0x6014627")]
	[Address(RVA = "0x1EE17C0", Offset = "0x1EE17C0", VA = "0x1EE17C0")]
	public static implicit operator InventoryItemInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6014628")]
	[Address(RVA = "0x1EE1878", Offset = "0x1EE1878", VA = "0x1EE1878")]
	public static implicit operator CSVBaseData(InventoryItemInfo info)
	{
		return null;
	}

	[Token(Token = "0x6014629")]
	[Address(RVA = "0x1EE18E4", Offset = "0x1EE18E4", VA = "0x1EE18E4", Slot = "4")]
	public int CompareTo(InventoryItemInfo other)
	{
		return default(int);
	}
}
