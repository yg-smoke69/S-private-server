using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CFF")]
public class InventoryTopupNtf
{
	[Token(Token = "0x400B764")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ctxn_type_003Ek__BackingField;

	[Token(Token = "0x400B765")]
	[FieldOffset(Offset = "0xC")]
	private int _003Crecharge_points_003Ek__BackingField;

	[Token(Token = "0x400B766")]
	[FieldOffset(Offset = "0x10")]
	private string _003Ccurrency_003Ek__BackingField;

	[Token(Token = "0x400B767")]
	[FieldOffset(Offset = "0x14")]
	private float _003Ccurrency_amount_003Ek__BackingField;

	[Token(Token = "0x17000BB3")]
	public uint txn_type
	{
		[Token(Token = "0x60086BC")]
		[Address(RVA = "0x33EBB38", Offset = "0x33EBB38", VA = "0x33EBB38")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086BD")]
		[Address(RVA = "0x33EBB40", Offset = "0x33EBB40", VA = "0x33EBB40")]
		set
		{
		}
	}

	[Token(Token = "0x17000BB4")]
	public int recharge_points
	{
		[Token(Token = "0x60086BE")]
		[Address(RVA = "0x33EBB48", Offset = "0x33EBB48", VA = "0x33EBB48")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60086BF")]
		[Address(RVA = "0x33EBB50", Offset = "0x33EBB50", VA = "0x33EBB50")]
		set
		{
		}
	}

	[Token(Token = "0x17000BB5")]
	public string currency
	{
		[Token(Token = "0x60086C0")]
		[Address(RVA = "0x33EBB58", Offset = "0x33EBB58", VA = "0x33EBB58")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086C1")]
		[Address(RVA = "0x33EBB30", Offset = "0x33EBB30", VA = "0x33EBB30")]
		set
		{
		}
	}

	[Token(Token = "0x17000BB6")]
	public float currency_amount
	{
		[Token(Token = "0x60086C2")]
		[Address(RVA = "0x33EBB60", Offset = "0x33EBB60", VA = "0x33EBB60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60086C3")]
		[Address(RVA = "0x33EBB68", Offset = "0x33EBB68", VA = "0x33EBB68")]
		set
		{
		}
	}

	[Token(Token = "0x60086BB")]
	[Address(RVA = "0x33EBA90", Offset = "0x33EBA90", VA = "0x33EBA90")]
	public InventoryTopupNtf()
	{
	}
}
