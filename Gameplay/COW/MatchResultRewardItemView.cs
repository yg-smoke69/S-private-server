using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200338D")]
public class MatchResultRewardItemView : MonoBehaviour
{
	[Token(Token = "0x4013A94")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_ItemNameLabel;

	[Token(Token = "0x4013A95")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_ItemCountLabel;

	[Token(Token = "0x6015E5E")]
	[Address(RVA = "0x1544924", Offset = "0x1544924", VA = "0x1544924")]
	public MatchResultRewardItemView()
	{
	}

	[Token(Token = "0x6015E5F")]
	[Address(RVA = "0x154492C", Offset = "0x154492C", VA = "0x154492C")]
	public void SetItemData(BaseItemInfo rewardInfo)
	{
	}
}
