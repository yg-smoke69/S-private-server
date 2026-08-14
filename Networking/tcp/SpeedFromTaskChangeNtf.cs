using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D07")]
public class SpeedFromTaskChangeNtf
{
	[Token(Token = "0x400B784")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cdeposit_003Ek__BackingField;

	[Token(Token = "0x400B785")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccurrent_speed_from_task_003Ek__BackingField;

	[Token(Token = "0x400B786")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cspeed_change_time_003Ek__BackingField;

	[Token(Token = "0x17000BC8")]
	public uint deposit
	{
		[Token(Token = "0x60086EC")]
		[Address(RVA = "0x435F340", Offset = "0x435F340", VA = "0x435F340")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086ED")]
		[Address(RVA = "0x435F348", Offset = "0x435F348", VA = "0x435F348")]
		set
		{
		}
	}

	[Token(Token = "0x17000BC9")]
	public uint current_speed_from_task
	{
		[Token(Token = "0x60086EE")]
		[Address(RVA = "0x435F350", Offset = "0x435F350", VA = "0x435F350")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086EF")]
		[Address(RVA = "0x435F358", Offset = "0x435F358", VA = "0x435F358")]
		set
		{
		}
	}

	[Token(Token = "0x17000BCA")]
	public uint speed_change_time
	{
		[Token(Token = "0x60086F0")]
		[Address(RVA = "0x435F360", Offset = "0x435F360", VA = "0x435F360")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086F1")]
		[Address(RVA = "0x435F368", Offset = "0x435F368", VA = "0x435F368")]
		set
		{
		}
	}

	[Token(Token = "0x60086EB")]
	[Address(RVA = "0x435F338", Offset = "0x435F338", VA = "0x435F338")]
	public SpeedFromTaskChangeNtf()
	{
	}
}
