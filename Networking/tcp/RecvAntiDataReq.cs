using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C53")]
public class RecvAntiDataReq
{
	[Token(Token = "0x400B44A")]
	[FieldOffset(Offset = "0x8")]
	private byte[] _003Canti_data_003Ek__BackingField;

	[Token(Token = "0x400B44B")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cdata_len_003Ek__BackingField;

	[Token(Token = "0x170009F6")]
	public byte[] anti_data
	{
		[Token(Token = "0x60082C3")]
		[Address(RVA = "0x435D10C", Offset = "0x435D10C", VA = "0x435D10C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082C4")]
		[Address(RVA = "0x435D114", Offset = "0x435D114", VA = "0x435D114")]
		set
		{
		}
	}

	[Token(Token = "0x170009F7")]
	public uint data_len
	{
		[Token(Token = "0x60082C5")]
		[Address(RVA = "0x435D11C", Offset = "0x435D11C", VA = "0x435D11C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082C6")]
		[Address(RVA = "0x435D124", Offset = "0x435D124", VA = "0x435D124")]
		set
		{
		}
	}

	[Token(Token = "0x60082C2")]
	[Address(RVA = "0x435D104", Offset = "0x435D104", VA = "0x435D104")]
	public RecvAntiDataReq()
	{
	}
}
