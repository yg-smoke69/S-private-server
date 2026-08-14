using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C9B")]
public class PrepareClanWarReq
{
	[Token(Token = "0x400B548")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cmember_id_003Ek__BackingField;

	[Token(Token = "0x400B549")]
	[FieldOffset(Offset = "0x10")]
	private bool _003Chas_prepared_003Ek__BackingField;

	[Token(Token = "0x17000A82")]
	public ulong member_id
	{
		[Token(Token = "0x6008410")]
		[Address(RVA = "0x435CDA0", Offset = "0x435CDA0", VA = "0x435CDA0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008411")]
		[Address(RVA = "0x435CDA8", Offset = "0x435CDA8", VA = "0x435CDA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000A83")]
	public bool has_prepared
	{
		[Token(Token = "0x6008412")]
		[Address(RVA = "0x435CDB8", Offset = "0x435CDB8", VA = "0x435CDB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008413")]
		[Address(RVA = "0x435CDC0", Offset = "0x435CDC0", VA = "0x435CDC0")]
		set
		{
		}
	}

	[Token(Token = "0x600840F")]
	[Address(RVA = "0x435CD98", Offset = "0x435CD98", VA = "0x435CD98")]
	public PrepareClanWarReq()
	{
	}
}
