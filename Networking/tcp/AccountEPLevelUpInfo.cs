using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CB2")]
public class AccountEPLevelUpInfo
{
	[Token(Token = "0x400B599")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B59A")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Clevel_before_003Ek__BackingField;

	[Token(Token = "0x400B59B")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Clevel_after_003Ek__BackingField;

	[Token(Token = "0x400B59C")]
	[FieldOffset(Offset = "0x18")]
	private uint[] _003Cunlock_ids_003Ek__BackingField;

	[Token(Token = "0x17000AB9")]
	public ulong account_id
	{
		[Token(Token = "0x600848F")]
		[Address(RVA = "0x33E6E84", Offset = "0x33E6E84", VA = "0x33E6E84")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008490")]
		[Address(RVA = "0x33E6E8C", Offset = "0x33E6E8C", VA = "0x33E6E8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000ABA")]
	public uint level_before
	{
		[Token(Token = "0x6008491")]
		[Address(RVA = "0x33E6E9C", Offset = "0x33E6E9C", VA = "0x33E6E9C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008492")]
		[Address(RVA = "0x33E6EA4", Offset = "0x33E6EA4", VA = "0x33E6EA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000ABB")]
	public uint level_after
	{
		[Token(Token = "0x6008493")]
		[Address(RVA = "0x33E6EAC", Offset = "0x33E6EAC", VA = "0x33E6EAC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008494")]
		[Address(RVA = "0x33E6EB4", Offset = "0x33E6EB4", VA = "0x33E6EB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000ABC")]
	public uint[] unlock_ids
	{
		[Token(Token = "0x6008495")]
		[Address(RVA = "0x33E6EBC", Offset = "0x33E6EBC", VA = "0x33E6EBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008496")]
		[Address(RVA = "0x33E6EC4", Offset = "0x33E6EC4", VA = "0x33E6EC4")]
		set
		{
		}
	}

	[Token(Token = "0x600848E")]
	[Address(RVA = "0x33E6E7C", Offset = "0x33E6E7C", VA = "0x33E6E7C")]
	public AccountEPLevelUpInfo()
	{
	}
}
