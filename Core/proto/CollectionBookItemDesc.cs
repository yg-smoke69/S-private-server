using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C1F")]
public class CollectionBookItemDesc : _Attribute
{
	[Token(Token = "0x400B105")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400B106")]
	[FieldOffset(Offset = "0xC")]
	public uint book_id;

	[Token(Token = "0x400B107")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x400B108")]
	[FieldOffset(Offset = "0x14")]
	public bool hidden_state;

	[Token(Token = "0x400B109")]
	[FieldOffset(Offset = "0x18")]
	public AwardDesc award;

	[Token(Token = "0x400B10A")]
	[FieldOffset(Offset = "0x1C")]
	public uint token_id;

	[Token(Token = "0x400B10B")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.AwardType token_type;

	[Token(Token = "0x400B10C")]
	[FieldOffset(Offset = "0x24")]
	public uint token_num;

	[Token(Token = "0x400B10D")]
	[FieldOffset(Offset = "0x28")]
	public uint back_token_num;

	[Token(Token = "0x400B10E")]
	[FieldOffset(Offset = "0x2C")]
	public uint unlock_hidden_probability;

	[Token(Token = "0x6008281")]
	[Address(RVA = "0x309D474", Offset = "0x309D474", VA = "0x309D474")]
	public CollectionBookItemDesc()
	{
	}

	[Token(Token = "0x6008282")]
	[Address(RVA = "0x309D47C", Offset = "0x309D47C", VA = "0x309D47C", Slot = "4")]
	public int CompareTo(object obj)
	{
		return default(int);
	}

	[Token(Token = "0x6008283")]
	[Address(RVA = "0x309D548", Offset = "0x309D548", VA = "0x309D548")]
	public CollectionBookItemDesc Clone()
	{
		return null;
	}
}
