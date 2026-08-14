using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200225A")]
public class UIHudUGCMultiTeamMatchResultTeamItemController : UIEasyListItemController
{
	[Token(Token = "0x400D6F9")]
	[FieldOffset(Offset = "0x38")]
	private UIHudUGCMultiTeamMatchResultTeamItemView m_View;

	[Token(Token = "0x400D6FA")]
	[FieldOffset(Offset = "0x3C")]
	private UIHudUGCMultiTeamMatchResultController m_parentController;

	[Token(Token = "0x400D6FB")]
	[FieldOffset(Offset = "0x40")]
	private UIDetailTipsInUGCMatchResultController m_Tips;

	[Token(Token = "0x400D6FC")]
	[FieldOffset(Offset = "0x44")]
	private int[] m_RankToScoreRule;

	[Token(Token = "0x400D6FD")]
	[FieldOffset(Offset = "0x48")]
	private List<UIHudUGCMultiTeamMatchResultPlayerItemController> m_items;

	[Token(Token = "0x400D6FE")]
	[FieldOffset(Offset = "0x0")]
	private static float playerItemHeight;

	[Token(Token = "0x400D6FF")]
	[FieldOffset(Offset = "0x4")]
	private static float selfHeight;

	[Token(Token = "0x600BB8D")]
	[Address(RVA = "0x1A633F8", Offset = "0x1A633F8", VA = "0x1A633F8")]
	public UIHudUGCMultiTeamMatchResultTeamItemController()
	{
	}

	[Token(Token = "0x600BB8E")]
	[Address(RVA = "0x1A63400", Offset = "0x1A63400", VA = "0x1A63400")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB8F")]
	[Address(RVA = "0x1A615D4", Offset = "0x1A615D4", VA = "0x1A615D4")]
	internal void SetParentController(UIHudUGCMultiTeamMatchResultController parentController)
	{
	}

	[Token(Token = "0x600BB90")]
	[Address(RVA = "0x1A61634", Offset = "0x1A61634", VA = "0x1A61634")]
	public void SetRankToScoreRule(int[] rankToScoreRule)
	{
	}

	[Token(Token = "0x600BB91")]
	[Address(RVA = "0x1A634A8", Offset = "0x1A634A8", VA = "0x1A634A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BB92")]
	[Address(RVA = "0x1A636CC", Offset = "0x1A636CC", VA = "0x1A636CC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600BB93")]
	[Address(RVA = "0x1A637D4", Offset = "0x1A637D4", VA = "0x1A637D4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BB94")]
	[Address(RVA = "0x1A60E3C", Offset = "0x1A60E3C", VA = "0x1A60E3C")]
	public static int CalculateContainerHeight(int numOfPlayerItem)
	{
		return default(int);
	}

	[Token(Token = "0x600BB95")]
	[Address(RVA = "0x1A64310", Offset = "0x1A64310", VA = "0x1A64310")]
	private void OnQuestionBtnClick()
	{
	}

	[Token(Token = "0x600BB97")]
	[Address(RVA = "0x1A645A0", Offset = "0x1A645A0", VA = "0x1A645A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BB98")]
	[Address(RVA = "0x1A645A8", Offset = "0x1A645A8", VA = "0x1A645A8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
