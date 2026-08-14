using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DAE")]
public class IntimacyRelation
{
	[Token(Token = "0x400BC1C")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Crelated_friend_id_003Ek__BackingField;

	[Token(Token = "0x400BC1D")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Crelation_type_003Ek__BackingField;

	[Token(Token = "0x400BC1E")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cintimacy_003Ek__BackingField;

	[Token(Token = "0x17000EC2")]
	public ulong related_friend_id
	{
		[Token(Token = "0x6008D5D")]
		[Address(RVA = "0x33EB87C", Offset = "0x33EB87C", VA = "0x33EB87C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008D5E")]
		[Address(RVA = "0x33EB884", Offset = "0x33EB884", VA = "0x33EB884")]
		set
		{
		}
	}

	[Token(Token = "0x17000EC3")]
	public uint relation_type
	{
		[Token(Token = "0x6008D5F")]
		[Address(RVA = "0x33EB894", Offset = "0x33EB894", VA = "0x33EB894")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D60")]
		[Address(RVA = "0x33EB89C", Offset = "0x33EB89C", VA = "0x33EB89C")]
		set
		{
		}
	}

	[Token(Token = "0x17000EC4")]
	public uint intimacy
	{
		[Token(Token = "0x6008D61")]
		[Address(RVA = "0x33EB8A4", Offset = "0x33EB8A4", VA = "0x33EB8A4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D62")]
		[Address(RVA = "0x33EB8AC", Offset = "0x33EB8AC", VA = "0x33EB8AC")]
		set
		{
		}
	}

	[Token(Token = "0x6008D5C")]
	[Address(RVA = "0x33EB874", Offset = "0x33EB874", VA = "0x33EB874")]
	public IntimacyRelation()
	{
	}
}
