using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D00")]
public class InventoryRebateCardNtf
{
	[Token(Token = "0x400B768")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ctxn_type_003Ek__BackingField;

	[Token(Token = "0x400B769")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Crebate_card_id_003Ek__BackingField;

	[Token(Token = "0x400B76A")]
	[FieldOffset(Offset = "0x10")]
	private int _003Cpoint_amount_003Ek__BackingField;

	[Token(Token = "0x400B76B")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cchannel_id_003Ek__BackingField;

	[Token(Token = "0x400B76C")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cchannel_name_003Ek__BackingField;

	[Token(Token = "0x400B76D")]
	[FieldOffset(Offset = "0x1C")]
	private string _003Ccurrency_003Ek__BackingField;

	[Token(Token = "0x400B76E")]
	[FieldOffset(Offset = "0x20")]
	private float _003Ccurrency_amount_003Ek__BackingField;

	[Token(Token = "0x17000BB7")]
	public uint txn_type
	{
		[Token(Token = "0x60086C5")]
		[Address(RVA = "0x33EBA30", Offset = "0x33EBA30", VA = "0x33EBA30")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086C6")]
		[Address(RVA = "0x33EBA38", Offset = "0x33EBA38", VA = "0x33EBA38")]
		set
		{
		}
	}

	[Token(Token = "0x17000BB8")]
	public uint rebate_card_id
	{
		[Token(Token = "0x60086C7")]
		[Address(RVA = "0x33EBA40", Offset = "0x33EBA40", VA = "0x33EBA40")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086C8")]
		[Address(RVA = "0x33EBA48", Offset = "0x33EBA48", VA = "0x33EBA48")]
		set
		{
		}
	}

	[Token(Token = "0x17000BB9")]
	public int point_amount
	{
		[Token(Token = "0x60086C9")]
		[Address(RVA = "0x33EBA50", Offset = "0x33EBA50", VA = "0x33EBA50")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60086CA")]
		[Address(RVA = "0x33EBA58", Offset = "0x33EBA58", VA = "0x33EBA58")]
		set
		{
		}
	}

	[Token(Token = "0x17000BBA")]
	public uint channel_id
	{
		[Token(Token = "0x60086CB")]
		[Address(RVA = "0x33EBA60", Offset = "0x33EBA60", VA = "0x33EBA60")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086CC")]
		[Address(RVA = "0x33EBA68", Offset = "0x33EBA68", VA = "0x33EBA68")]
		set
		{
		}
	}

	[Token(Token = "0x17000BBB")]
	public string channel_name
	{
		[Token(Token = "0x60086CD")]
		[Address(RVA = "0x33EBA70", Offset = "0x33EBA70", VA = "0x33EBA70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086CE")]
		[Address(RVA = "0x33EBA20", Offset = "0x33EBA20", VA = "0x33EBA20")]
		set
		{
		}
	}

	[Token(Token = "0x17000BBC")]
	public string currency
	{
		[Token(Token = "0x60086CF")]
		[Address(RVA = "0x33EBA78", Offset = "0x33EBA78", VA = "0x33EBA78")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086D0")]
		[Address(RVA = "0x33EBA28", Offset = "0x33EBA28", VA = "0x33EBA28")]
		set
		{
		}
	}

	[Token(Token = "0x17000BBD")]
	public float currency_amount
	{
		[Token(Token = "0x60086D1")]
		[Address(RVA = "0x33EBA80", Offset = "0x33EBA80", VA = "0x33EBA80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60086D2")]
		[Address(RVA = "0x33EBA88", Offset = "0x33EBA88", VA = "0x33EBA88")]
		set
		{
		}
	}

	[Token(Token = "0x60086C4")]
	[Address(RVA = "0x33EB974", Offset = "0x33EB974", VA = "0x33EB974")]
	public InventoryRebateCardNtf()
	{
	}
}
