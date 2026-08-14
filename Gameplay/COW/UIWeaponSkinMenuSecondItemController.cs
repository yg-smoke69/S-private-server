using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C07")]
public class UIWeaponSkinMenuSecondItemController : UIEasyListItemController
{
	[Token(Token = "0x4010D01")]
	[FieldOffset(Offset = "0x38")]
	private UIWeaponSkinMenuSecondItemView m_View;

	[Token(Token = "0x4010D02")]
	[FieldOffset(Offset = "0x3C")]
	private object m_Data;

	[Token(Token = "0x4010D03")]
	[FieldOffset(Offset = "0x40")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x601249D")]
	[Address(RVA = "0x2EDECBC", Offset = "0x2EDECBC", VA = "0x2EDECBC")]
	public UIWeaponSkinMenuSecondItemController()
	{
	}

	[Token(Token = "0x601249E")]
	[Address(RVA = "0x2EDECC4", Offset = "0x2EDECC4", VA = "0x2EDECC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601249F")]
	[Address(RVA = "0x2EDED6C", Offset = "0x2EDED6C", VA = "0x2EDED6C", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60124A0")]
	[Address(RVA = "0x2EDEDC8", Offset = "0x2EDEDC8", VA = "0x2EDEDC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60124A1")]
	[Address(RVA = "0x2EDF090", Offset = "0x2EDF090", VA = "0x2EDF090")]
	private void RefreshRedTips(bool flag)
	{
	}

	[Token(Token = "0x60124A2")]
	[Address(RVA = "0x2EDF128", Offset = "0x2EDF128", VA = "0x2EDF128")]
	private void OnRefreshRed(object[] data)
	{
	}

	[Token(Token = "0x60124A3")]
	[Address(RVA = "0x2EDF384", Offset = "0x2EDF384", VA = "0x2EDF384", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60124A4")]
	[Address(RVA = "0x2EDF520", Offset = "0x2EDF520", VA = "0x2EDF520")]
	private void OnRefreshIcon(object[] data)
	{
	}

	[Token(Token = "0x60124A5")]
	[Address(RVA = "0x2EE0950", Offset = "0x2EE0950", VA = "0x2EE0950", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60124A6")]
	[Address(RVA = "0x2EDF700", Offset = "0x2EDF700", VA = "0x2EDF700")]
	private void RefreshSecondGridIcon(uint weaponId)
	{
	}

	[Token(Token = "0x60124A7")]
	[Address(RVA = "0x2EE0CA4", Offset = "0x2EE0CA4", VA = "0x2EE0CA4", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60124A8")]
	[Address(RVA = "0x2EE0FDC", Offset = "0x2EE0FDC", VA = "0x2EE0FDC", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x60124A9")]
	[Address(RVA = "0x2EE1078", Offset = "0x2EE1078", VA = "0x2EE1078")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60124AA")]
	[Address(RVA = "0x2EE1080", Offset = "0x2EE1080", VA = "0x2EE1080")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60124AB")]
	[Address(RVA = "0x2EE1088", Offset = "0x2EE1088", VA = "0x2EE1088")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60124AC")]
	[Address(RVA = "0x2EE1090", Offset = "0x2EE1090", VA = "0x2EE1090")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60124AD")]
	[Address(RVA = "0x2EE1098", Offset = "0x2EE1098", VA = "0x2EE1098")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
