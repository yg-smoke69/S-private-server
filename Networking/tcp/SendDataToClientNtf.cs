using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C54")]
public class SendDataToClientNtf
{
	[Token(Token = "0x400B44C")]
	[FieldOffset(Offset = "0x8")]
	private byte[] _003Canti_data_003Ek__BackingField;

	[Token(Token = "0x400B44D")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cdata_len_003Ek__BackingField;

	[Token(Token = "0x170009F8")]
	public byte[] anti_data
	{
		[Token(Token = "0x60082C8")]
		[Address(RVA = "0x435F130", Offset = "0x435F130", VA = "0x435F130")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082C9")]
		[Address(RVA = "0x435F138", Offset = "0x435F138", VA = "0x435F138")]
		set
		{
		}
	}

	[Token(Token = "0x170009F9")]
	public uint data_len
	{
		[Token(Token = "0x60082CA")]
		[Address(RVA = "0x435F140", Offset = "0x435F140", VA = "0x435F140")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082CB")]
		[Address(RVA = "0x435F148", Offset = "0x435F148", VA = "0x435F148")]
		set
		{
		}
	}

	[Token(Token = "0x60082C7")]
	[Address(RVA = "0x435F128", Offset = "0x435F128", VA = "0x435F128")]
	public SendDataToClientNtf()
	{
	}
}
