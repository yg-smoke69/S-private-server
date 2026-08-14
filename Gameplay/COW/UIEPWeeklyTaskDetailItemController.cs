using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20020E7")]
public class UIEPWeeklyTaskDetailItemController : UIEasyListItemController
{
	[Token(Token = "0x400CDD7")]
	[FieldOffset(Offset = "0x38")]
	private UIEPWeeklyTaskDetailItemView m_View;

	[Token(Token = "0x400CDD8")]
	[FieldOffset(Offset = "0x3C")]
	private EPWeeklyQuestInfo m_Info;

	[Token(Token = "0x400CDD9")]
	[FieldOffset(Offset = "0x40")]
	private EPTarget_Status m_State;

	[Token(Token = "0x400CDDA")]
	[FieldOffset(Offset = "0x44")]
	private List<UIStandardItemMiniController> m_CacheRewardList;

	[Token(Token = "0x600AA65")]
	[Address(RVA = "0x2A365B0", Offset = "0x2A365B0", VA = "0x2A365B0")]
	public UIEPWeeklyTaskDetailItemController()
	{
	}

	[Token(Token = "0x600AA66")]
	[Address(RVA = "0x2A3663C", Offset = "0x2A3663C", VA = "0x2A3663C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AA67")]
	[Address(RVA = "0x2A36798", Offset = "0x2A36798", VA = "0x2A36798")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA68")]
	[Address(RVA = "0x2A3683C", Offset = "0x2A3683C", VA = "0x2A3683C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600AA69")]
	[Address(RVA = "0x2A36998", Offset = "0x2A36998", VA = "0x2A36998")]
	private void SetUI()
	{
	}

	[Token(Token = "0x600AA6A")]
	[Address(RVA = "0x2A36A08", Offset = "0x2A36A08", VA = "0x2A36A08")]
	private void SetDesc()
	{
	}

	[Token(Token = "0x600AA6B")]
	[Address(RVA = "0x2A372DC", Offset = "0x2A372DC", VA = "0x2A372DC")]
	private void _SetDesc()
	{
	}

	[Token(Token = "0x600AA6C")]
	[Address(RVA = "0x2A36F8C", Offset = "0x2A36F8C", VA = "0x2A36F8C")]
	private void SetReward()
	{
	}

	[Token(Token = "0x600AA6D")]
	[Address(RVA = "0x2A36C40", Offset = "0x2A36C40", VA = "0x2A36C40")]
	private void SetButtonState()
	{
	}

	[Token(Token = "0x600AA6E")]
	[Address(RVA = "0x2A37C44", Offset = "0x2A37C44", VA = "0x2A37C44")]
	private void OnOperateBtn()
	{
	}

	[Token(Token = "0x600AA6F")]
	[Address(RVA = "0x2A37E40", Offset = "0x2A37E40", VA = "0x2A37E40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
