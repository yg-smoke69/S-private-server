using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C99")]
public class RemoveClanWarMemberReq
{
	[Token(Token = "0x400B544")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cremovee_id_003Ek__BackingField;

	[Token(Token = "0x400B545")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cnew_captain_id_003Ek__BackingField;

	[Token(Token = "0x17000A7E")]
	public ulong removee_id
	{
		[Token(Token = "0x6008406")]
		[Address(RVA = "0x435D400", Offset = "0x435D400", VA = "0x435D400")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008407")]
		[Address(RVA = "0x435D408", Offset = "0x435D408", VA = "0x435D408")]
		set
		{
		}
	}

	[Token(Token = "0x17000A7F")]
	public ulong new_captain_id
	{
		[Token(Token = "0x6008408")]
		[Address(RVA = "0x435D418", Offset = "0x435D418", VA = "0x435D418")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008409")]
		[Address(RVA = "0x435D420", Offset = "0x435D420", VA = "0x435D420")]
		set
		{
		}
	}

	[Token(Token = "0x6008405")]
	[Address(RVA = "0x435D3F8", Offset = "0x435D3F8", VA = "0x435D3F8")]
	public RemoveClanWarMemberReq()
	{
	}
}
