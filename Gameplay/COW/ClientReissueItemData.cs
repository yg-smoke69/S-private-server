using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200317D")]
public class ClientReissueItemData
{
	[Token(Token = "0x4012D08")]
	[FieldOffset(Offset = "0x8")]
	public EClientReissueItemType ClientReissueItemType;

	[Token(Token = "0x4012D09")]
	[FieldOffset(Offset = "0x10")]
	public DateTime DateTime;

	[Token(Token = "0x4012D0A")]
	[FieldOffset(Offset = "0x20")]
	public uint ClaimTime;

	[Token(Token = "0x4012D0B")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<uint, EClientCardTypeReissueAwardStatus> AwardStatusDic;

	[Token(Token = "0x4012D0C")]
	[FieldOffset(Offset = "0x28")]
	public List<ClientReissueAward> Awards;

	[Token(Token = "0x4012D0D")]
	[FieldOffset(Offset = "0x2C")]
	public Dictionary<uint, List<ClientReissueAward>> AwardsDic;

	[Token(Token = "0x6014CAE")]
	[Address(RVA = "0x172C98C", Offset = "0x172C98C", VA = "0x172C98C")]
	public ClientReissueItemData()
	{
	}

	[Token(Token = "0x6014CAF")]
	[Address(RVA = "0x172CA80", Offset = "0x172CA80", VA = "0x172CA80")]
	public EClientReissueAwardStatus GetAwardStatus()
	{
		return default(EClientReissueAwardStatus);
	}

	[Token(Token = "0x6014CB0")]
	[Address(RVA = "0x172CC78", Offset = "0x172CC78", VA = "0x172CC78")]
	public List<ClientReissueAward> GetShowAwards()
	{
		return null;
	}
}
