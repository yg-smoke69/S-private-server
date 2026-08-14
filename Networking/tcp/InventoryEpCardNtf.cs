using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D01")]
public class InventoryEpCardNtf
{
	[Token(Token = "0x400B76F")]
	[FieldOffset(Offset = "0x8")]
	private string _003Ccode_003Ek__BackingField;

	[Token(Token = "0x400B770")]
	[FieldOffset(Offset = "0xC")]
	private bool _003Cis_active_003Ek__BackingField;

	[Token(Token = "0x17000BBE")]
	public string code
	{
		[Token(Token = "0x60086D4")]
		[Address(RVA = "0x33EB95C", Offset = "0x33EB95C", VA = "0x33EB95C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086D5")]
		[Address(RVA = "0x33EB954", Offset = "0x33EB954", VA = "0x33EB954")]
		set
		{
		}
	}

	[Token(Token = "0x17000BBF")]
	public bool is_active
	{
		[Token(Token = "0x60086D6")]
		[Address(RVA = "0x33EB964", Offset = "0x33EB964", VA = "0x33EB964")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60086D7")]
		[Address(RVA = "0x33EB96C", Offset = "0x33EB96C", VA = "0x33EB96C")]
		set
		{
		}
	}

	[Token(Token = "0x60086D3")]
	[Address(RVA = "0x33EB8B4", Offset = "0x33EB8B4", VA = "0x33EB8B4")]
	public InventoryEpCardNtf()
	{
	}
}
