using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA1")]
public class CollectionBaseInfo : _Attribute
{
	[Token(Token = "0x401227D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x401227E")]
	[FieldOffset(Offset = "0xC")]
	public uint sort_id;

	[Token(Token = "0x401227F")]
	[FieldOffset(Offset = "0x10")]
	public bool is_default;

	[Token(Token = "0x4012280")]
	[FieldOffset(Offset = "0x11")]
	public bool is_owned;

	[Token(Token = "0x4012281")]
	[FieldOffset(Offset = "0x14")]
	public Item item;

	[Token(Token = "0x4012282")]
	[FieldOffset(Offset = "0x18")]
	public CSSharedItemData item_data;

	[Token(Token = "0x4012283")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_withEffect;

	[Token(Token = "0x6013E92")]
	[Address(RVA = "0x172F018", Offset = "0x172F018", VA = "0x172F018")]
	public CollectionBaseInfo()
	{
	}

	[Token(Token = "0x6013E93")]
	[Address(RVA = "0x172F020", Offset = "0x172F020", VA = "0x172F020", Slot = "5")]
	public virtual uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013E94")]
	[Address(RVA = "0x172F078", Offset = "0x172F078", VA = "0x172F078", Slot = "4")]
	public int CompareTo(CollectionBaseInfo other)
	{
		return default(int);
	}
}
