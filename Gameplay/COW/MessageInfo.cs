using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002F3F")]
public class MessageInfo
{
	[Token(Token = "0x40120AD")]
	[FieldOffset(Offset = "0x8")]
	public EChannel.ChannelType RecvType;

	[Token(Token = "0x40120AE")]
	[FieldOffset(Offset = "0x10")]
	public ulong RecvID;

	[Token(Token = "0x40120AF")]
	[FieldOffset(Offset = "0x18")]
	public ulong SenderID;

	[Token(Token = "0x40120B0")]
	[FieldOffset(Offset = "0x20")]
	public BaseProfileInfo SenderInfo;

	[Token(Token = "0x40120B1")]
	[FieldOffset(Offset = "0x24")]
	public EChannel.MsgType MessageType;

	[Token(Token = "0x40120B2")]
	[FieldOffset(Offset = "0x28")]
	public string MessageContent;

	[Token(Token = "0x40120B3")]
	[FieldOffset(Offset = "0x2C")]
	public string ExtraInfo;

	[Token(Token = "0x40120B4")]
	[FieldOffset(Offset = "0x30")]
	public ulong SendTimeStamp;

	[Token(Token = "0x40120B5")]
	[FieldOffset(Offset = "0x38")]
	public EChatMessageSendState SendState;

	[Token(Token = "0x40120B6")]
	[FieldOffset(Offset = "0x40")]
	public ulong GroupId;

	[Token(Token = "0x40120B7")]
	[FieldOffset(Offset = "0x48")]
	public EChatTipsType ChatTipsType;

	[Token(Token = "0x40120B8")]
	[FieldOffset(Offset = "0x4C")]
	public bool Reported;

	[Token(Token = "0x40120B9")]
	[FieldOffset(Offset = "0x4D")]
	public bool IsShowProfile;

	[Token(Token = "0x40120BA")]
	[FieldOffset(Offset = "0x4E")]
	public bool IsNeedHide;

	[Token(Token = "0x6013C31")]
	[Address(RVA = "0x2274B80", Offset = "0x2274B80", VA = "0x2274B80")]
	public MessageInfo()
	{
	}

	[Token(Token = "0x6013C32")]
	[Address(RVA = "0x2274B94", Offset = "0x2274B94", VA = "0x2274B94")]
	public MessageInfo(TextMsgReq req)
	{
	}

	[Token(Token = "0x6013C33")]
	[Address(RVA = "0x2274E48", Offset = "0x2274E48", VA = "0x2274E48")]
	public void UpdateProfileInfo()
	{
	}

	[Token(Token = "0x6013C34")]
	[Address(RVA = "0x227504C", Offset = "0x227504C", VA = "0x227504C")]
	public string GetSenderName()
	{
		return null;
	}

	[Token(Token = "0x6013C35")]
	[Address(RVA = "0x2275404", Offset = "0x2275404", VA = "0x2275404")]
	public bool IsFastClanRecruit()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C36")]
	[Address(RVA = "0x2275668", Offset = "0x2275668", VA = "0x2275668")]
	public bool IsFastGroupRecruit()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C37")]
	[Address(RVA = "0x22758CC", Offset = "0x22758CC", VA = "0x22758CC")]
	public bool IsFastClanGroupRecruit()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C38")]
	[Address(RVA = "0x2275B30", Offset = "0x2275B30", VA = "0x2275B30")]
	public bool IsFastTutorRecruit()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C39")]
	[Address(RVA = "0x2275D94", Offset = "0x2275D94", VA = "0x2275D94")]
	public bool IsFastTutorRecruitByIdentifyTutor()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C3A")]
	[Address(RVA = "0x2275FA8", Offset = "0x2275FA8", VA = "0x2275FA8")]
	public bool IsFastChampionshipTeamRecruit()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C3B")]
	[Address(RVA = "0x227620C", Offset = "0x227620C", VA = "0x227620C")]
	public bool IsFastCupMatchTeamRecruit()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C3C")]
	[Address(RVA = "0x2276470", Offset = "0x2276470", VA = "0x2276470")]
	public bool CheckContentHasFlag(string key)
	{
		return default(bool);
	}
}
