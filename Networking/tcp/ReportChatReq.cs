using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C7F")]
public class ReportChatReq
{
	[Token(Token = "0x400B4F4")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Ctarget_account_id_003Ek__BackingField;

	[Token(Token = "0x400B4F5")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Creason_003Ek__BackingField;

	[Token(Token = "0x400B4F6")]
	[FieldOffset(Offset = "0x14")]
	private string _003Cmessage_003Ek__BackingField;

	[Token(Token = "0x17000A4C")]
	public ulong target_account_id
	{
		[Token(Token = "0x600838C")]
		[Address(RVA = "0x435D568", Offset = "0x435D568", VA = "0x435D568")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600838D")]
		[Address(RVA = "0x435D570", Offset = "0x435D570", VA = "0x435D570")]
		set
		{
		}
	}

	[Token(Token = "0x17000A4D")]
	public uint reason
	{
		[Token(Token = "0x600838E")]
		[Address(RVA = "0x435D580", Offset = "0x435D580", VA = "0x435D580")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600838F")]
		[Address(RVA = "0x435D588", Offset = "0x435D588", VA = "0x435D588")]
		set
		{
		}
	}

	[Token(Token = "0x17000A4E")]
	public string message
	{
		[Token(Token = "0x6008390")]
		[Address(RVA = "0x435D590", Offset = "0x435D590", VA = "0x435D590")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008391")]
		[Address(RVA = "0x435D560", Offset = "0x435D560", VA = "0x435D560")]
		set
		{
		}
	}

	[Token(Token = "0x600838B")]
	[Address(RVA = "0x435D4C0", Offset = "0x435D4C0", VA = "0x435D4C0")]
	public ReportChatReq()
	{
	}
}
