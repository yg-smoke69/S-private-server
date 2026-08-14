using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C90")]
public class RemoveMemberReq
{
	[Token(Token = "0x400B52D")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cclan_id_003Ek__BackingField;

	[Token(Token = "0x400B52E")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cremover_id_003Ek__BackingField;

	[Token(Token = "0x17000A67")]
	public ulong clan_id
	{
		[Token(Token = "0x60083CF")]
		[Address(RVA = "0x435D490", Offset = "0x435D490", VA = "0x435D490")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083D0")]
		[Address(RVA = "0x435D498", Offset = "0x435D498", VA = "0x435D498")]
		set
		{
		}
	}

	[Token(Token = "0x17000A68")]
	public ulong remover_id
	{
		[Token(Token = "0x60083D1")]
		[Address(RVA = "0x435D4A8", Offset = "0x435D4A8", VA = "0x435D4A8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083D2")]
		[Address(RVA = "0x435D4B0", Offset = "0x435D4B0", VA = "0x435D4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60083CE")]
	[Address(RVA = "0x435D488", Offset = "0x435D488", VA = "0x435D488")]
	public RemoveMemberReq()
	{
	}
}
