using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D94")]
public class PetSkillInfo
{
	[Token(Token = "0x400BAAD")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cskill_id_003Ek__BackingField;

	[Token(Token = "0x400BAAE")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cskill_level_003Ek__BackingField;

	[Token(Token = "0x17000D59")]
	public uint skill_id
	{
		[Token(Token = "0x6008A72")]
		[Address(RVA = "0x435CCF8", Offset = "0x435CCF8", VA = "0x435CCF8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A73")]
		[Address(RVA = "0x435CD00", Offset = "0x435CD00", VA = "0x435CD00")]
		set
		{
		}
	}

	[Token(Token = "0x17000D5A")]
	public uint skill_level
	{
		[Token(Token = "0x6008A74")]
		[Address(RVA = "0x435CD08", Offset = "0x435CD08", VA = "0x435CD08")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A75")]
		[Address(RVA = "0x435CD10", Offset = "0x435CD10", VA = "0x435CD10")]
		set
		{
		}
	}

	[Token(Token = "0x6008A71")]
	[Address(RVA = "0x435CCF0", Offset = "0x435CCF0", VA = "0x435CCF0")]
	public PetSkillInfo()
	{
	}
}
