using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F9E")]
public class UIHudArmsListController : UIBaseController
{
	[Token(Token = "0x400C659")]
	[FieldOffset(Offset = "0x28")]
	private UIHudArmsListView m_View;

	[Token(Token = "0x400C65A")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCall;

	[Token(Token = "0x400C65B")]
	[FieldOffset(Offset = "0x30")]
	private int m_DelayTime;

	[Token(Token = "0x400C65C")]
	[FieldOffset(Offset = "0x34")]
	private List<IJKEMPEMMDN> m_ArmsInfoList;

	[Token(Token = "0x400C65D")]
	[FieldOffset(Offset = "0x38")]
	private List<UIHudArmsItemController> m_ArmsItemCtrl;

	[Token(Token = "0x6009D73")]
	[Address(RVA = "0x1704198", Offset = "0x1704198", VA = "0x1704198")]
	public UIHudArmsListController()
	{
	}

	[Token(Token = "0x6009D74")]
	[Address(RVA = "0x1704284", Offset = "0x1704284", VA = "0x1704284")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D75")]
	[Address(RVA = "0x170432C", Offset = "0x170432C", VA = "0x170432C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D76")]
	[Address(RVA = "0x17047EC", Offset = "0x17047EC", VA = "0x17047EC")]
	public void SetUIData(List<IJKEMPEMMDN> armsInfoList)
	{
	}

	[Token(Token = "0x6009D77")]
	[Address(RVA = "0x1704AB8", Offset = "0x1704AB8", VA = "0x1704AB8")]
	private void OnGridReposition()
	{
	}

	[Token(Token = "0x6009D78")]
	[Address(RVA = "0x1704EF4", Offset = "0x1704EF4", VA = "0x1704EF4")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x6009D79")]
	[Address(RVA = "0x17046A0", Offset = "0x17046A0", VA = "0x17046A0")]
	private void StartDelayCall()
	{
	}

	[Token(Token = "0x6009D7A")]
	[Address(RVA = "0x1704F58", Offset = "0x1704F58", VA = "0x1704F58", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6009D7B")]
	[Address(RVA = "0x1705074", Offset = "0x1705074", VA = "0x1705074")]
	private void _003CStartDelayCall_003Em__0()
	{
	}

	[Token(Token = "0x6009D7C")]
	[Address(RVA = "0x170518C", Offset = "0x170518C", VA = "0x170518C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009D7D")]
	[Address(RVA = "0x1705194", Offset = "0x1705194", VA = "0x1705194")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
