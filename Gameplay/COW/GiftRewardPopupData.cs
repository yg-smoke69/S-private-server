using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022E1")]
public class GiftRewardPopupData
{
	[Token(Token = "0x400D9C7")]
	[FieldOffset(Offset = "0x8")]
	public string Message;

	[Token(Token = "0x400D9C8")]
	[FieldOffset(Offset = "0xC")]
	public RewardBtn BtnData;

	[Token(Token = "0x400D9C9")]
	[FieldOffset(Offset = "0x10")]
	public string ReceiverName;

	[Token(Token = "0x400D9CA")]
	[FieldOffset(Offset = "0x14")]
	public string SenderName;

	[Token(Token = "0x600C019")]
	[Address(RVA = "0x2591248", Offset = "0x2591248", VA = "0x2591248")]
	public GiftRewardPopupData(string receiverName, string message, string senderName)
	{
	}

	[Token(Token = "0x600C01A")]
	[Address(RVA = "0x2591280", Offset = "0x2591280", VA = "0x2591280")]
	public GiftRewardPopupData(string receiverName, string message, string senderName, RewardBtn btnData)
	{
	}
}
