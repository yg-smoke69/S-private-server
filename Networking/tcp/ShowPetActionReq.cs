using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CEC")]
public class ShowPetActionReq
{
	[Token(Token = "0x400B735")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B736")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Caction_id_003Ek__BackingField;

	[Token(Token = "0x17000B9C")]
	public ulong group_id
	{
		[Token(Token = "0x600867F")]
		[Address(RVA = "0x435F310", Offset = "0x435F310", VA = "0x435F310")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008680")]
		[Address(RVA = "0x435F318", Offset = "0x435F318", VA = "0x435F318")]
		set
		{
		}
	}

	[Token(Token = "0x17000B9D")]
	public uint action_id
	{
		[Token(Token = "0x6008681")]
		[Address(RVA = "0x435F328", Offset = "0x435F328", VA = "0x435F328")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008682")]
		[Address(RVA = "0x435F330", Offset = "0x435F330", VA = "0x435F330")]
		set
		{
		}
	}

	[Token(Token = "0x600867E")]
	[Address(RVA = "0x435F308", Offset = "0x435F308", VA = "0x435F308")]
	public ShowPetActionReq()
	{
	}
}
