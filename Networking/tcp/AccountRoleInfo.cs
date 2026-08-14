using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C4A")]
public class AccountRoleInfo
{
	[Token(Token = "0x400B435")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B436")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Crole_003Ek__BackingField;

	[Token(Token = "0x170009EF")]
	public ulong account_id
	{
		[Token(Token = "0x60082B0")]
		[Address(RVA = "0x33E783C", Offset = "0x33E783C", VA = "0x33E783C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60082B1")]
		[Address(RVA = "0x33E7844", Offset = "0x33E7844", VA = "0x33E7844")]
		set
		{
		}
	}

	[Token(Token = "0x170009F0")]
	public uint role
	{
		[Token(Token = "0x60082B2")]
		[Address(RVA = "0x33E7854", Offset = "0x33E7854", VA = "0x33E7854")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082B3")]
		[Address(RVA = "0x33E785C", Offset = "0x33E785C", VA = "0x33E785C")]
		set
		{
		}
	}

	[Token(Token = "0x60082AF")]
	[Address(RVA = "0x33E7834", Offset = "0x33E7834", VA = "0x33E7834")]
	public AccountRoleInfo()
	{
	}
}
