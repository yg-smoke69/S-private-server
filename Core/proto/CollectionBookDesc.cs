using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C1E")]
public class CollectionBookDesc : _Attribute
{
	[Token(Token = "0x400B0F8")]
	[FieldOffset(Offset = "0x8")]
	public uint book_id;

	[Token(Token = "0x400B0F9")]
	[FieldOffset(Offset = "0xC")]
	public EStore.HyperBookType type;

	[Token(Token = "0x400B0FA")]
	[FieldOffset(Offset = "0x10")]
	public long time_pre_start;

	[Token(Token = "0x400B0FB")]
	[FieldOffset(Offset = "0x18")]
	public long time_pre_end;

	[Token(Token = "0x400B0FC")]
	[FieldOffset(Offset = "0x20")]
	public long time_open_start;

	[Token(Token = "0x400B0FD")]
	[FieldOffset(Offset = "0x28")]
	public long time_open_end;

	[Token(Token = "0x400B0FE")]
	[FieldOffset(Offset = "0x30")]
	public uint go_pos;

	[Token(Token = "0x400B0FF")]
	[FieldOffset(Offset = "0x34")]
	public string sub_go_pos;

	[Token(Token = "0x400B100")]
	[FieldOffset(Offset = "0x38")]
	public uint sort_id;

	[Token(Token = "0x400B101")]
	[FieldOffset(Offset = "0x3C")]
	public uint obtain_go_pos;

	[Token(Token = "0x400B102")]
	[FieldOffset(Offset = "0x40")]
	public string obtain_sub_go_pos;

	[Token(Token = "0x400B103")]
	[FieldOffset(Offset = "0x44")]
	private int m_HiddenPageIdx;

	[Token(Token = "0x400B104")]
	[FieldOffset(Offset = "0x48")]
	private List<CollectionBookItemDesc> m_CollectionBookItemDescList;

	[Token(Token = "0x170009E6")]
	public int HiddenPageIdx
	{
		[Token(Token = "0x6008279")]
		[Address(RVA = "0x309CDC0", Offset = "0x309CDC0", VA = "0x309CDC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008278")]
	[Address(RVA = "0x309CC84", Offset = "0x309CC84", VA = "0x309CC84")]
	public CollectionBookDesc()
	{
	}

	[Token(Token = "0x600827A")]
	[Address(RVA = "0x309CD38", Offset = "0x309CD38", VA = "0x309CD38")]
	private void OnConstructor()
	{
	}

	[Token(Token = "0x600827B")]
	[Address(RVA = "0x309CDC8", Offset = "0x309CDC8", VA = "0x309CDC8")]
	public void AddCollectionBookItemDesc(CollectionBookItemDesc itemDesc)
	{
	}

	[Token(Token = "0x600827C")]
	[Address(RVA = "0x309D01C", Offset = "0x309D01C", VA = "0x309D01C")]
	public CollectionBookItemDesc GetCollectionBookItemDesc(int index)
	{
		return null;
	}

	[Token(Token = "0x600827D")]
	[Address(RVA = "0x309D0D8", Offset = "0x309D0D8", VA = "0x309D0D8")]
	public void SortCollectionBookItemDesc()
	{
	}

	[Token(Token = "0x600827E")]
	[Address(RVA = "0x309D144", Offset = "0x309D144", VA = "0x309D144")]
	public int GetBookPageCount()
	{
		return default(int);
	}

	[Token(Token = "0x600827F")]
	[Address(RVA = "0x309D1B8", Offset = "0x309D1B8", VA = "0x309D1B8", Slot = "4")]
	public int CompareTo(object obj)
	{
		return default(int);
	}

	[Token(Token = "0x6008280")]
	[Address(RVA = "0x309D280", Offset = "0x309D280", VA = "0x309D280")]
	public List<AwardDesc> GetHyperBookAwardList()
	{
		return null;
	}
}
