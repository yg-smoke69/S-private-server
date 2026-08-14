using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D05")]
public class RampagePointsUpdateNtf
{
	[Token(Token = "0x400B77C")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B77D")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Crampage_points_003Ek__BackingField;

	[Token(Token = "0x400B77E")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Crampage_rank_003Ek__BackingField;

	[Token(Token = "0x17000BC0")]
	public ulong account_id
	{
		[Token(Token = "0x60086DA")]
		[Address(RVA = "0x435D0C4", Offset = "0x435D0C4", VA = "0x435D0C4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60086DB")]
		[Address(RVA = "0x435D0CC", Offset = "0x435D0CC", VA = "0x435D0CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000BC1")]
	public ulong rampage_points
	{
		[Token(Token = "0x60086DC")]
		[Address(RVA = "0x435D0DC", Offset = "0x435D0DC", VA = "0x435D0DC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60086DD")]
		[Address(RVA = "0x435D0E4", Offset = "0x435D0E4", VA = "0x435D0E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000BC2")]
	public uint rampage_rank
	{
		[Token(Token = "0x60086DE")]
		[Address(RVA = "0x435D0F4", Offset = "0x435D0F4", VA = "0x435D0F4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086DF")]
		[Address(RVA = "0x435D0FC", Offset = "0x435D0FC", VA = "0x435D0FC")]
		set
		{
		}
	}

	[Token(Token = "0x60086D9")]
	[Address(RVA = "0x435D0BC", Offset = "0x435D0BC", VA = "0x435D0BC")]
	public RampagePointsUpdateNtf()
	{
	}
}
