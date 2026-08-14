using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C97")]
public class JoinClanWarReq
{
	[Token(Token = "0x400B540")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cnew_member_id_003Ek__BackingField;

	[Token(Token = "0x400B541")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cnew_member_type_003Ek__BackingField;

	[Token(Token = "0x17000A7A")]
	public ulong new_member_id
	{
		[Token(Token = "0x60083FC")]
		[Address(RVA = "0x33EBF1C", Offset = "0x33EBF1C", VA = "0x33EBF1C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083FD")]
		[Address(RVA = "0x33EBF24", Offset = "0x33EBF24", VA = "0x33EBF24")]
		set
		{
		}
	}

	[Token(Token = "0x17000A7B")]
	public uint new_member_type
	{
		[Token(Token = "0x60083FE")]
		[Address(RVA = "0x33EBF34", Offset = "0x33EBF34", VA = "0x33EBF34")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60083FF")]
		[Address(RVA = "0x33EBF3C", Offset = "0x33EBF3C", VA = "0x33EBF3C")]
		set
		{
		}
	}

	[Token(Token = "0x60083FB")]
	[Address(RVA = "0x33EBF14", Offset = "0x33EBF14", VA = "0x33EBF14")]
	public JoinClanWarReq()
	{
	}
}
