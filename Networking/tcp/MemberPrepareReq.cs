using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C9D")]
public class MemberPrepareReq
{
	[Token(Token = "0x400B54B")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cmember_id_003Ek__BackingField;

	[Token(Token = "0x400B54C")]
	[FieldOffset(Offset = "0x10")]
	private bool _003Cneed_prepare_003Ek__BackingField;

	[Token(Token = "0x17000A85")]
	public ulong member_id
	{
		[Token(Token = "0x6008418")]
		[Address(RVA = "0x435C914", Offset = "0x435C914", VA = "0x435C914")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008419")]
		[Address(RVA = "0x435C91C", Offset = "0x435C91C", VA = "0x435C91C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A86")]
	public bool need_prepare
	{
		[Token(Token = "0x600841A")]
		[Address(RVA = "0x435C92C", Offset = "0x435C92C", VA = "0x435C92C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600841B")]
		[Address(RVA = "0x435C934", Offset = "0x435C934", VA = "0x435C934")]
		set
		{
		}
	}

	[Token(Token = "0x6008417")]
	[Address(RVA = "0x435C90C", Offset = "0x435C90C", VA = "0x435C90C")]
	public MemberPrepareReq()
	{
	}
}
