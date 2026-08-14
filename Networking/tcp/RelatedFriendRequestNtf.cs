using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CC0")]
public class RelatedFriendRequestNtf
{
	[Token(Token = "0x400B5C5")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cfriend_id_003Ek__BackingField;

	[Token(Token = "0x400B5C6")]
	[FieldOffset(Offset = "0x10")]
	private long _003Crequest_time_003Ek__BackingField;

	[Token(Token = "0x400B5C7")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Crelation_type_003Ek__BackingField;

	[Token(Token = "0x400B5C8")]
	[FieldOffset(Offset = "0x1C")]
	private bool _003Cis_create_003Ek__BackingField;

	[Token(Token = "0x17000AD3")]
	public ulong friend_id
	{
		[Token(Token = "0x60084CD")]
		[Address(RVA = "0x435D370", Offset = "0x435D370", VA = "0x435D370")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60084CE")]
		[Address(RVA = "0x435D378", Offset = "0x435D378", VA = "0x435D378")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD4")]
	public long request_time
	{
		[Token(Token = "0x60084CF")]
		[Address(RVA = "0x435D388", Offset = "0x435D388", VA = "0x435D388")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60084D0")]
		[Address(RVA = "0x435D390", Offset = "0x435D390", VA = "0x435D390")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD5")]
	public uint relation_type
	{
		[Token(Token = "0x60084D1")]
		[Address(RVA = "0x435D3A0", Offset = "0x435D3A0", VA = "0x435D3A0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084D2")]
		[Address(RVA = "0x435D3A8", Offset = "0x435D3A8", VA = "0x435D3A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD6")]
	public bool is_create
	{
		[Token(Token = "0x60084D3")]
		[Address(RVA = "0x435D3B0", Offset = "0x435D3B0", VA = "0x435D3B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60084D4")]
		[Address(RVA = "0x435D3B8", Offset = "0x435D3B8", VA = "0x435D3B8")]
		set
		{
		}
	}

	[Token(Token = "0x60084CC")]
	[Address(RVA = "0x435D368", Offset = "0x435D368", VA = "0x435D368")]
	public RelatedFriendRequestNtf()
	{
	}
}
