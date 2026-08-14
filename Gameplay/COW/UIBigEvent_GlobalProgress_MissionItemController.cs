using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E97")]
public class UIBigEvent_GlobalProgress_MissionItemController : UIEasyListItemController
{
	[Token(Token = "0x400C053")]
	[FieldOffset(Offset = "0x38")]
	private UIBigEvent_GlobalProgress_MissionItemView m_View;

	[Token(Token = "0x400C054")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	[Token(Token = "0x400C055")]
	[FieldOffset(Offset = "0x40")]
	private List<UIStandardItemMiniController> m_ListRewardItemCtrl;

	[Token(Token = "0x400C056")]
	[FieldOffset(Offset = "0x44")]
	private ClientActivityDesc m_ActivityDesc;

	[Token(Token = "0x400C057")]
	[FieldOffset(Offset = "0x48")]
	private EActivity.State m_ActivityState;

	[Token(Token = "0x6009388")]
	[Address(RVA = "0x3029218", Offset = "0x3029218", VA = "0x3029218")]
	public UIBigEvent_GlobalProgress_MissionItemController()
	{
	}

	[Token(Token = "0x6009389")]
	[Address(RVA = "0x3029220", Offset = "0x3029220", VA = "0x3029220")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600938A")]
	[Address(RVA = "0x30292C8", Offset = "0x30292C8", VA = "0x30292C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600938B")]
	[Address(RVA = "0x302976C", Offset = "0x302976C", VA = "0x302976C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600938C")]
	[Address(RVA = "0x3029904", Offset = "0x3029904", VA = "0x3029904")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600938D")]
	[Address(RVA = "0x302949C", Offset = "0x302949C", VA = "0x302949C")]
	private void PrepareAwardCtrls()
	{
	}

	[Token(Token = "0x600938E")]
	[Address(RVA = "0x302A360", Offset = "0x302A360", VA = "0x302A360")]
	private void RefreshAward()
	{
	}

	[Token(Token = "0x600938F")]
	[Address(RVA = "0x302AAD0", Offset = "0x302AAD0", VA = "0x302AAD0")]
	private void OnClickBtnReceive()
	{
	}

	[Token(Token = "0x6009390")]
	[Address(RVA = "0x302AE98", Offset = "0x302AE98", VA = "0x302AE98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
