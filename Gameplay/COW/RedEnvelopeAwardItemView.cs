using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A90")]
internal class RedEnvelopeAwardItemView : MonoBehaviour
{
	[Token(Token = "0x4018E85")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_ReceiverLabel;

	[Token(Token = "0x4018E86")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_CoinIcon;

	[Token(Token = "0x4018E87")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_GemIcon;

	[Token(Token = "0x4018E88")]
	[FieldOffset(Offset = "0x18")]
	public UILabel m_CountLabel;

	[Token(Token = "0x4018E89")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel m_ItemCountLabel;

	[Token(Token = "0x4018E8A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_LuckyIcon;

	[Token(Token = "0x4018E8B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject m_Container;

	[Token(Token = "0x6017355")]
	[Address(RVA = "0x19717EC", Offset = "0x19717EC", VA = "0x19717EC")]
	public RedEnvelopeAwardItemView()
	{
	}

	[Token(Token = "0x6017356")]
	[Address(RVA = "0x19717F4", Offset = "0x19717F4", VA = "0x19717F4")]
	public void SetItemData(RedEnvelopeAwardDisplayInfo awardInfo)
	{
	}
}
