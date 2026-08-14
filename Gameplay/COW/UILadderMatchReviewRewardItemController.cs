using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002169")]
public class UILadderMatchReviewRewardItemController : UIEasyListItemController
{
	[Token(Token = "0x400D1CE")]
	[FieldOffset(Offset = "0x38")]
	private LadderMatchReviewRewardItemView m_View;

	[Token(Token = "0x400D1CF")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelLadderMatch m_Model;

	[Token(Token = "0x400D1D0")]
	[FieldOffset(Offset = "0x40")]
	private List<UILadderMatchReviewMiniItemController> m_MiniItemCtrlList;

	[Token(Token = "0x600B0CD")]
	[Address(RVA = "0x22BF958", Offset = "0x22BF958", VA = "0x22BF958")]
	public UILadderMatchReviewRewardItemController()
	{
	}

	[Token(Token = "0x600B0CE")]
	[Address(RVA = "0x22BF9E4", Offset = "0x22BF9E4", VA = "0x22BF9E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B0CF")]
	[Address(RVA = "0x22BFA88", Offset = "0x22BFA88", VA = "0x22BFA88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B0D0")]
	[Address(RVA = "0x22BFBB4", Offset = "0x22BFBB4", VA = "0x22BFBB4")]
	private void SetArrowDark(bool value)
	{
	}

	[Token(Token = "0x600B0D1")]
	[Address(RVA = "0x22BFCD0", Offset = "0x22BFCD0", VA = "0x22BFCD0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B0D2")]
	[Address(RVA = "0x22C10AC", Offset = "0x22C10AC", VA = "0x22C10AC")]
	private void InitTrans()
	{
	}

	[Token(Token = "0x600B0D3")]
	[Address(RVA = "0x22C1278", Offset = "0x22C1278", VA = "0x22C1278")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
