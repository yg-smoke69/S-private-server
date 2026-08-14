using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D02")]
public class ELimitedEvent
{
	[Token(Token = "0x2001D03")]
	public enum Proto
	{
		[Token(Token = "0x400B772")]
		Proto_NONE = 0,
		[Token(Token = "0x400B773")]
		Proto_RAMPAGE_POINTS_UPDATE_NTF = 1,
		[Token(Token = "0x400B774")]
		Proto_ADD_MONEY_HEIST_HELP_NTF = 2,
		[Token(Token = "0x400B775")]
		Proto_SPEED_FROM_TASK_CHANGE_NTF = 3,
		[Token(Token = "0x400B776")]
		Proto_GOLIATH_AFK_GROUP_UPDATE_NTF = 4,
		[Token(Token = "0x400B777")]
		Proto_SUPERCAR_RECEIVE_HELP_NTF = 7,
		[Token(Token = "0x400B778")]
		Proto_JUMPSUIT_RECEIVE_HELP_NTF = 8,
		[Token(Token = "0x400B779")]
		Proto_DIGITALUNIVERSEB_TIME_ATTACK_START_NTF = 9
	}

	[Token(Token = "0x2001D04")]
	public enum ErrCode
	{
		[Token(Token = "0x400B77B")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60086D8")]
	[Address(RVA = "0x33E9054", Offset = "0x33E9054", VA = "0x33E9054")]
	public ELimitedEvent()
	{
	}
}
