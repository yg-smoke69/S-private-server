using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200235F")]
public class UISceneEditUGCRankRewardItemController : UIEasyListItemController
{
	[Token(Token = "0x400DC50")]
	[FieldOffset(Offset = "0x38")]
	private UISceneEditUGCRankRewardItemView m_View;

	[Token(Token = "0x400DC51")]
	[FieldOffset(Offset = "0x3C")]
	private List<UISceneEditRankRewardReviewMiniItemController> m_MiniItemCtrlList;

	[Token(Token = "0x600C552")]
	[Address(RVA = "0x1A3DB10", Offset = "0x1A3DB10", VA = "0x1A3DB10")]
	public UISceneEditUGCRankRewardItemController()
	{
	}

	[Token(Token = "0x600C553")]
	[Address(RVA = "0x1A3DB9C", Offset = "0x1A3DB9C", VA = "0x1A3DB9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C554")]
	[Address(RVA = "0x1A3DC58", Offset = "0x1A3DC58", VA = "0x1A3DC58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C555")]
	[Address(RVA = "0x1A3DCFC", Offset = "0x1A3DCFC", VA = "0x1A3DCFC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C556")]
	[Address(RVA = "0x1A3E780", Offset = "0x1A3E780", VA = "0x1A3E780")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
