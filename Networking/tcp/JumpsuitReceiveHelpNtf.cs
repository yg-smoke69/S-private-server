using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D09")]
public class JumpsuitReceiveHelpNtf
{
	[Token(Token = "0x400B788")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Chelper_id_003Ek__BackingField;

	[Token(Token = "0x400B789")]
	[FieldOffset(Offset = "0x10")]
	private string _003Chelper_name_003Ek__BackingField;

	[Token(Token = "0x400B78A")]
	[FieldOffset(Offset = "0x18")]
	private long _003Chelp_time_003Ek__BackingField;

	[Token(Token = "0x17000BCC")]
	public ulong helper_id
	{
		[Token(Token = "0x60086F6")]
		[Address(RVA = "0x33EC1E4", Offset = "0x33EC1E4", VA = "0x33EC1E4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60086F7")]
		[Address(RVA = "0x33EC1EC", Offset = "0x33EC1EC", VA = "0x33EC1EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000BCD")]
	public string helper_name
	{
		[Token(Token = "0x60086F8")]
		[Address(RVA = "0x33EC1FC", Offset = "0x33EC1FC", VA = "0x33EC1FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086F9")]
		[Address(RVA = "0x33EC1DC", Offset = "0x33EC1DC", VA = "0x33EC1DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000BCE")]
	public long help_time
	{
		[Token(Token = "0x60086FA")]
		[Address(RVA = "0x33EC204", Offset = "0x33EC204", VA = "0x33EC204")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60086FB")]
		[Address(RVA = "0x33EC20C", Offset = "0x33EC20C", VA = "0x33EC20C")]
		set
		{
		}
	}

	[Token(Token = "0x60086F5")]
	[Address(RVA = "0x33EC13C", Offset = "0x33EC13C", VA = "0x33EC13C")]
	public JumpsuitReceiveHelpNtf()
	{
	}
}
