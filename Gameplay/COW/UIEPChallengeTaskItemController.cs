using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20020CC")]
public class UIEPChallengeTaskItemController : UIEasyListItemController
{
	[Token(Token = "0x400CD4E")]
	[FieldOffset(Offset = "0x38")]
	private UIEPChallengeTaskItemView m_View;

	[Token(Token = "0x400CD4F")]
	[FieldOffset(Offset = "0x3C")]
	private EPMonthlyQuestInfo m_Info;

	[Token(Token = "0x400CD50")]
	[FieldOffset(Offset = "0x40")]
	private EPTarget_Status m_State;

	[Token(Token = "0x400CD51")]
	[FieldOffset(Offset = "0x44")]
	private List<UIStandardItemMiniController> m_CacheRewardList;

	[Token(Token = "0x600A987")]
	[Address(RVA = "0x2BA023C", Offset = "0x2BA023C", VA = "0x2BA023C")]
	public UIEPChallengeTaskItemController()
	{
	}

	[Token(Token = "0x600A988")]
	[Address(RVA = "0x2BA02C8", Offset = "0x2BA02C8", VA = "0x2BA02C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A989")]
	[Address(RVA = "0x2BA0424", Offset = "0x2BA0424", VA = "0x2BA0424")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A98A")]
	[Address(RVA = "0x2BA04C8", Offset = "0x2BA04C8", VA = "0x2BA04C8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A98B")]
	[Address(RVA = "0x2BA0634", Offset = "0x2BA0634", VA = "0x2BA0634")]
	private void SetDesc()
	{
	}

	[Token(Token = "0x600A98C")]
	[Address(RVA = "0x2BA0FC8", Offset = "0x2BA0FC8", VA = "0x2BA0FC8")]
	private void _SetDesc()
	{
	}

	[Token(Token = "0x600A98D")]
	[Address(RVA = "0x2BA0B7C", Offset = "0x2BA0B7C", VA = "0x2BA0B7C")]
	private void SetReward()
	{
	}

	[Token(Token = "0x600A98E")]
	[Address(RVA = "0x2BA0830", Offset = "0x2BA0830", VA = "0x2BA0830")]
	private void SetButtonState()
	{
	}

	[Token(Token = "0x600A98F")]
	[Address(RVA = "0x2BA1930", Offset = "0x2BA1930", VA = "0x2BA1930")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600A990")]
	[Address(RVA = "0x2BA1B00", Offset = "0x2BA1B00", VA = "0x2BA1B00")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
