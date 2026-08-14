using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CFE")]
public class InventoryWalletUpdateNtf
{
	[Token(Token = "0x400B762")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ccoins_003Ek__BackingField;

	[Token(Token = "0x400B763")]
	[FieldOffset(Offset = "0xC")]
	private int _003Cgems_003Ek__BackingField;

	[Token(Token = "0x17000BB1")]
	public uint coins
	{
		[Token(Token = "0x60086B7")]
		[Address(RVA = "0x33EBB78", Offset = "0x33EBB78", VA = "0x33EBB78")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086B8")]
		[Address(RVA = "0x33EBB80", Offset = "0x33EBB80", VA = "0x33EBB80")]
		set
		{
		}
	}

	[Token(Token = "0x17000BB2")]
	public int gems
	{
		[Token(Token = "0x60086B9")]
		[Address(RVA = "0x33EBB88", Offset = "0x33EBB88", VA = "0x33EBB88")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60086BA")]
		[Address(RVA = "0x33EBB90", Offset = "0x33EBB90", VA = "0x33EBB90")]
		set
		{
		}
	}

	[Token(Token = "0x60086B6")]
	[Address(RVA = "0x33EBB70", Offset = "0x33EBB70", VA = "0x33EBB70")]
	public InventoryWalletUpdateNtf()
	{
	}
}
