using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002F2E")]
public class LikeWorldChannelInfo
{
	[Token(Token = "0x4012017")]
	[FieldOffset(Offset = "0x8")]
	public ulong m_ChannelID;

	[Token(Token = "0x4012018")]
	[FieldOffset(Offset = "0x10")]
	public uint m_LeftTalkTimesDefault;

	[Token(Token = "0x4012019")]
	[FieldOffset(Offset = "0x14")]
	public uint m_LeftTalkTimesFast;

	[Token(Token = "0x401201A")]
	[FieldOffset(Offset = "0x18")]
	public uint m_DailyMsgLimitDefault;

	[Token(Token = "0x401201B")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_DailyMsgLimitFast;

	[Token(Token = "0x401201C")]
	[FieldOffset(Offset = "0x20")]
	public bool m_EnableCustomMsg;

	[Token(Token = "0x401201D")]
	[FieldOffset(Offset = "0x24")]
	public EChannel.ChannelType m_ChannelType;

	[Token(Token = "0x401201E")]
	[FieldOffset(Offset = "0x28")]
	public ulong m_LastUpdateTimesLimitTs;

	[Token(Token = "0x401201F")]
	[FieldOffset(Offset = "0x30")]
	public ulong m_LastSendTs;

	[Token(Token = "0x4012020")]
	[FieldOffset(Offset = "0x38")]
	public ulong m_LastJoinChannelTimeStamp;

	[Token(Token = "0x4012021")]
	[FieldOffset(Offset = "0x0")]
	public static ulong JOIN_CHANNEL_CD;

	[Token(Token = "0x4012022")]
	[FieldOffset(Offset = "0x8")]
	public static int SERVER_UPDATE_HOUR;

	[Token(Token = "0x6013BB6")]
	[Address(RVA = "0xEC0C8C", Offset = "0xEC0C8C", VA = "0xEC0C8C")]
	public LikeWorldChannelInfo()
	{
	}

	[Token(Token = "0x6013BB7")]
	[Address(RVA = "0xEC0CA0", Offset = "0xEC0CA0", VA = "0xEC0CA0")]
	public static implicit operator LikeWorldChannelInfo(JoinGeneralChanNtf info)
	{
		return null;
	}

	[Token(Token = "0x6013BB8")]
	[Address(RVA = "0xEC0E84", Offset = "0xEC0E84", VA = "0xEC0E84")]
	public static implicit operator LikeWorldChannelInfo(JoinWorldChanNtf info)
	{
		return null;
	}

	[Token(Token = "0x6013BB9")]
	[Address(RVA = "0xEC1050", Offset = "0xEC1050", VA = "0xEC1050")]
	public void SetLikeWorldChatLeftTimes(uint leftTalk, uint leftFast)
	{
	}

	[Token(Token = "0x6013BBA")]
	[Address(RVA = "0xEC1140", Offset = "0xEC1140", VA = "0xEC1140")]
	public bool IsLikeWorldTimesLimit(EChannel.MsgType msgType)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BBB")]
	[Address(RVA = "0xEC11C0", Offset = "0xEC11C0", VA = "0xEC11C0")]
	public bool IsEnableCustomTalk()
	{
		return default(bool);
	}

	[Token(Token = "0x6013BBC")]
	[Address(RVA = "0xEC1218", Offset = "0xEC1218", VA = "0xEC1218")]
	public void SetLeftFastTimesDown()
	{
	}

	[Token(Token = "0x6013BBD")]
	[Address(RVA = "0xEC127C", Offset = "0xEC127C", VA = "0xEC127C")]
	public void SetLeftTalkTimesDown()
	{
	}

	[Token(Token = "0x6013BBE")]
	[Address(RVA = "0xEC12E0", Offset = "0xEC12E0", VA = "0xEC12E0")]
	public void SetLastSendTs(ulong time)
	{
	}

	[Token(Token = "0x6013BBF")]
	[Address(RVA = "0xEC135C", Offset = "0xEC135C", VA = "0xEC135C")]
	public void ResetLastJoinChannelTimeStamp()
	{
	}

	[Token(Token = "0x6013BC0")]
	[Address(RVA = "0xEC13BC", Offset = "0xEC13BC", VA = "0xEC13BC")]
	public void UpdateLikeWorldChatLimit()
	{
	}
}
