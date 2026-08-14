using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C91")]
public class DismissReq
{
	[Token(Token = "0x400B52F")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cclan_id_003Ek__BackingField;

	[Token(Token = "0x400B530")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cdismisser_id_003Ek__BackingField;

	[Token(Token = "0x400B531")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cclan_name_003Ek__BackingField;

	[Token(Token = "0x17000A69")]
	public ulong clan_id
	{
		[Token(Token = "0x60083D4")]
		[Address(RVA = "0x33E8F84", Offset = "0x33E8F84", VA = "0x33E8F84")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083D5")]
		[Address(RVA = "0x33E8F8C", Offset = "0x33E8F8C", VA = "0x33E8F8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A6A")]
	public ulong dismisser_id
	{
		[Token(Token = "0x60083D6")]
		[Address(RVA = "0x33E8F9C", Offset = "0x33E8F9C", VA = "0x33E8F9C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083D7")]
		[Address(RVA = "0x33E8FA4", Offset = "0x33E8FA4", VA = "0x33E8FA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000A6B")]
	public string clan_name
	{
		[Token(Token = "0x60083D8")]
		[Address(RVA = "0x33E8FB4", Offset = "0x33E8FB4", VA = "0x33E8FB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60083D9")]
		[Address(RVA = "0x33E8F7C", Offset = "0x33E8F7C", VA = "0x33E8F7C")]
		set
		{
		}
	}

	[Token(Token = "0x60083D3")]
	[Address(RVA = "0x33E8EDC", Offset = "0x33E8EDC", VA = "0x33E8EDC")]
	public DismissReq()
	{
	}
}
