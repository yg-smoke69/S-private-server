using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D13")]
public class PushMailNtf
{
	[Token(Token = "0x400B79D")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cnew_mail_cnt_003Ek__BackingField;

	[Token(Token = "0x400B79E")]
	[FieldOffset(Offset = "0xC")]
	private bool _003Chas_survey_mail_003Ek__BackingField;

	[Token(Token = "0x17000BD6")]
	public uint new_mail_cnt
	{
		[Token(Token = "0x6008710")]
		[Address(RVA = "0x435D02C", Offset = "0x435D02C", VA = "0x435D02C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008711")]
		[Address(RVA = "0x435D034", Offset = "0x435D034", VA = "0x435D034")]
		set
		{
		}
	}

	[Token(Token = "0x17000BD7")]
	public bool has_survey_mail
	{
		[Token(Token = "0x6008712")]
		[Address(RVA = "0x435D03C", Offset = "0x435D03C", VA = "0x435D03C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008713")]
		[Address(RVA = "0x435D044", Offset = "0x435D044", VA = "0x435D044")]
		set
		{
		}
	}

	[Token(Token = "0x600870F")]
	[Address(RVA = "0x435D024", Offset = "0x435D024", VA = "0x435D024")]
	public PushMailNtf()
	{
	}
}
