using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CFA")]
public class UGCDebugStartReq
{
	[Token(Token = "0x400B74F")]
	[FieldOffset(Offset = "0x8")]
	private byte[] _003Cexport_settings_003Ek__BackingField;

	[Token(Token = "0x400B750")]
	[FieldOffset(Offset = "0xC")]
	private byte[] _003Cdebug_settings_003Ek__BackingField;

	[Token(Token = "0x17000BAF")]
	public byte[] export_settings
	{
		[Token(Token = "0x60086B1")]
		[Address(RVA = "0x435FC3C", Offset = "0x435FC3C", VA = "0x435FC3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086B2")]
		[Address(RVA = "0x435FC44", Offset = "0x435FC44", VA = "0x435FC44")]
		set
		{
		}
	}

	[Token(Token = "0x17000BB0")]
	public byte[] debug_settings
	{
		[Token(Token = "0x60086B3")]
		[Address(RVA = "0x435FC4C", Offset = "0x435FC4C", VA = "0x435FC4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086B4")]
		[Address(RVA = "0x435FC54", Offset = "0x435FC54", VA = "0x435FC54")]
		set
		{
		}
	}

	[Token(Token = "0x60086B0")]
	[Address(RVA = "0x435FC34", Offset = "0x435FC34", VA = "0x435FC34")]
	public UGCDebugStartReq()
	{
	}
}
