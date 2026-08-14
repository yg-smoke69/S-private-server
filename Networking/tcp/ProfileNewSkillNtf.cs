using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D3F")]
public class ProfileNewSkillNtf
{
	[Token(Token = "0x400B878")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cnew_skill_id_003Ek__BackingField;

	[Token(Token = "0x17000C49")]
	public uint new_skill_id
	{
		[Token(Token = "0x6008813")]
		[Address(RVA = "0x435CFEC", Offset = "0x435CFEC", VA = "0x435CFEC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008814")]
		[Address(RVA = "0x435CFF4", Offset = "0x435CFF4", VA = "0x435CFF4")]
		set
		{
		}
	}

	[Token(Token = "0x6008812")]
	[Address(RVA = "0x435CFE4", Offset = "0x435CFE4", VA = "0x435CFE4")]
	public ProfileNewSkillNtf()
	{
	}
}
