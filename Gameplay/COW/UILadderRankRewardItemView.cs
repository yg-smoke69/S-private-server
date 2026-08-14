using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002177")]
public class UILadderRankRewardItemView : UIBaseController
{
	[Token(Token = "0x400D211")]
	[FieldOffset(Offset = "0x28")]
	public BaseItemView itemView;

	[Token(Token = "0x400D212")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LevelRewardCount;

	[Token(Token = "0x400D213")]
	[FieldOffset(Offset = "0x30")]
	public GameObject timePanel;

	[Token(Token = "0x400D214")]
	[FieldOffset(Offset = "0x34")]
	public UILabel time;

	[Token(Token = "0x400D215")]
	[FieldOffset(Offset = "0x38")]
	public UIButton clickBtn;

	[Token(Token = "0x400D216")]
	[FieldOffset(Offset = "0x3C")]
	private BaseItemInfo m_data;

	[Token(Token = "0x600B15D")]
	[Address(RVA = "0x22D9BA8", Offset = "0x22D9BA8", VA = "0x22D9BA8")]
	public UILadderRankRewardItemView()
	{
	}

	[Token(Token = "0x600B15E")]
	[Address(RVA = "0x22D9C2C", Offset = "0x22D9C2C", VA = "0x22D9C2C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B15F")]
	[Address(RVA = "0x22D9DA0", Offset = "0x22D9DA0", VA = "0x22D9DA0")]
	public void SetData(BaseItemInfo itemData)
	{
	}

	[Token(Token = "0x600B160")]
	[Address(RVA = "0x22DA154", Offset = "0x22DA154", VA = "0x22DA154")]
	private void OnClickBtn()
	{
	}

	[Token(Token = "0x600B161")]
	[Address(RVA = "0x22DA620", Offset = "0x22DA620", VA = "0x22DA620")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
