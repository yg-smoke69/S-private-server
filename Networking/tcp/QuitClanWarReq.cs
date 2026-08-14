using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C98")]
public class QuitClanWarReq
{
	[Token(Token = "0x400B542")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cquit_member_id_003Ek__BackingField;

	[Token(Token = "0x400B543")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cnew_captain_id_003Ek__BackingField;

	[Token(Token = "0x17000A7C")]
	public ulong quit_member_id
	{
		[Token(Token = "0x6008401")]
		[Address(RVA = "0x435D054", Offset = "0x435D054", VA = "0x435D054")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008402")]
		[Address(RVA = "0x435D05C", Offset = "0x435D05C", VA = "0x435D05C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A7D")]
	public ulong new_captain_id
	{
		[Token(Token = "0x6008403")]
		[Address(RVA = "0x435D06C", Offset = "0x435D06C", VA = "0x435D06C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008404")]
		[Address(RVA = "0x435D074", Offset = "0x435D074", VA = "0x435D074")]
		set
		{
		}
	}

	[Token(Token = "0x6008400")]
	[Address(RVA = "0x435D04C", Offset = "0x435D04C", VA = "0x435D04C")]
	public QuitClanWarReq()
	{
	}
}
