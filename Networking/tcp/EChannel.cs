using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C70")]
public class EChannel
{
	[Token(Token = "0x2001C71")]
	public enum Proto
	{
		[Token(Token = "0x400B49E")]
		Proto_NONE,
		[Token(Token = "0x400B49F")]
		Proto_TEXT_MSG,
		[Token(Token = "0x400B4A0")]
		Proto_TEXT_MSG_NTF,
		[Token(Token = "0x400B4A1")]
		Proto_JOIN_CHANNEL,
		[Token(Token = "0x400B4A2")]
		Proto_LEAVE_CHANNEL,
		[Token(Token = "0x400B4A3")]
		Proto_JOIN_WORLD_CHAN_NTF,
		[Token(Token = "0x400B4A4")]
		Proto_JOIN_GENERAL_CHAN_NTF
	}

	[Token(Token = "0x2001C72")]
	public enum ErrCode
	{
		[Token(Token = "0x400B4A6")]
		ErrCode_SUSS,
		[Token(Token = "0x400B4A7")]
		ErrCode_INVALIDCHANNELTYPE,
		[Token(Token = "0x400B4A8")]
		ErrCode_ALREADYINCHANNEL,
		[Token(Token = "0x400B4A9")]
		ErrCode_CREATEPLAYERFAIL,
		[Token(Token = "0x400B4AA")]
		ErrCode_CREATECHANNELFAIL,
		[Token(Token = "0x400B4AB")]
		ErrCode_MAXMEMBERLIMIT,
		[Token(Token = "0x400B4AC")]
		ErrCode_NOCHANNEL,
		[Token(Token = "0x400B4AD")]
		ErrCode_NOTINCHANNEL,
		[Token(Token = "0x400B4AE")]
		ErrCode_REACHMSGLIMIT,
		[Token(Token = "0x400B4AF")]
		ErrCode_WORLDCHANNELDISABLED,
		[Token(Token = "0x400B4B0")]
		ErrCode_CUSTOMMSGDISABLED,
		[Token(Token = "0x400B4B1")]
		ErrCode_RESERVATIONREACHLIMIT,
		[Token(Token = "0x400B4B2")]
		ErrCode_INVALIDCHANNELSECRET,
		[Token(Token = "0x400B4B3")]
		ErrCode_ALLOCATEWORLDCHANNELFAIL,
		[Token(Token = "0x400B4B4")]
		ErrCode_ALLOCATEMENTORINGCHANNELFAIL
	}

	[Token(Token = "0x2001C73")]
	public enum ChannelType
	{
		[Token(Token = "0x400B4B6")]
		ChannelType_GROUP,
		[Token(Token = "0x400B4B7")]
		ChannelType_CLAN,
		[Token(Token = "0x400B4B8")]
		ChannelType_WHISPER,
		[Token(Token = "0x400B4B9")]
		ChannelType_ROOM,
		[Token(Token = "0x400B4BA")]
		ChannelType_CHAMPIONSHIPTEAM,
		[Token(Token = "0x400B4BB")]
		ChannelType_WORLD,
		[Token(Token = "0x400B4BC")]
		ChannelType_GROUP_FAST,
		[Token(Token = "0x400B4BD")]
		ChannelType_CUP,
		[Token(Token = "0x400B4BE")]
		ChannelType_SERIES_TEAM,
		[Token(Token = "0x400B4BF")]
		ChannelType_MENTORING,
		[Token(Token = "0x400B4C0")]
		ChannelType_MAX
	}

	[Token(Token = "0x2001C74")]
	public enum MsgType
	{
		[Token(Token = "0x400B4C2")]
		MsgType_DEFAULT,
		[Token(Token = "0x400B4C3")]
		MsgType_FAST,
		[Token(Token = "0x400B4C4")]
		MsgType_STICKY_SPEAKER,
		[Token(Token = "0x400B4C5")]
		MsgType_RESERVATION,
		[Token(Token = "0x400B4C6")]
		MsgType_INTERACTION
	}

	[Token(Token = "0x2001C75")]
	public enum MsgLimitType
	{
		[Token(Token = "0x400B4C8")]
		MsgLimitType_DEFAULT,
		[Token(Token = "0x400B4C9")]
		MsgLimitType_FAST
	}

	[Token(Token = "0x600833F")]
	[Address(RVA = "0x33E8FE4", Offset = "0x33E8FE4", VA = "0x33E8FE4")]
	public EChannel()
	{
	}
}
