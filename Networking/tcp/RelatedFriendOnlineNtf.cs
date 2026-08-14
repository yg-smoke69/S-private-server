using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CBF")]
public class RelatedFriendOnlineNtf
{
	[Token(Token = "0x400B5C3")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B5C4")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Crelation_type_003Ek__BackingField;

	[Token(Token = "0x17000AD1")]
	public ulong account_id
	{
		[Token(Token = "0x60084C8")]
		[Address(RVA = "0x435D340", Offset = "0x435D340", VA = "0x435D340")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60084C9")]
		[Address(RVA = "0x435D348", Offset = "0x435D348", VA = "0x435D348")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD2")]
	public uint relation_type
	{
		[Token(Token = "0x60084CA")]
		[Address(RVA = "0x435D358", Offset = "0x435D358", VA = "0x435D358")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084CB")]
		[Address(RVA = "0x435D360", Offset = "0x435D360", VA = "0x435D360")]
		set
		{
		}
	}

	[Token(Token = "0x60084C7")]
	[Address(RVA = "0x435D338", Offset = "0x435D338", VA = "0x435D338")]
	public RelatedFriendOnlineNtf()
	{
	}
}
