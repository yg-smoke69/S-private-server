using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023C0")]
public class UIStandardSubTabItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DE79")]
	[FieldOffset(Offset = "0x28")]
	protected UIStandardSubTabItemView m_View;

	[Token(Token = "0x400DE7A")]
	[FieldOffset(Offset = "0x2C")]
	protected StandardSubTabItemViewData m_Data;

	[Token(Token = "0x400DE7B")]
	[FieldOffset(Offset = "0x30")]
	private int m_Index;

	[Token(Token = "0x400DE7C")]
	[FieldOffset(Offset = "0x34")]
	public UIStandardTabItemController mainTab;

	[Token(Token = "0x400DE7D")]
	[FieldOffset(Offset = "0x38")]
	private List<int> tipList;

	[Token(Token = "0x600C967")]
	[Address(RVA = "0x206E8DC", Offset = "0x206E8DC", VA = "0x206E8DC")]
	public UIStandardSubTabItemController()
	{
	}

	[Token(Token = "0x600C968")]
	[Address(RVA = "0x206E994", Offset = "0x206E994", VA = "0x206E994")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C969")]
	[Address(RVA = "0x206EA3C", Offset = "0x206EA3C", VA = "0x206EA3C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C96A")]
	[Address(RVA = "0x206EBF0", Offset = "0x206EBF0", VA = "0x206EBF0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C96B")]
	[Address(RVA = "0x206EE34", Offset = "0x206EE34", VA = "0x206EE34")]
	public void SetViewData(StandardSubTabItemViewData data, int data_index)
	{
	}

	[Token(Token = "0x600C96C")]
	[Address(RVA = "0x206F29C", Offset = "0x206F29C", VA = "0x206F29C", Slot = "32")]
	public virtual void SetExtraView(bool isLast)
	{
	}

	[Token(Token = "0x600C96D")]
	[Address(RVA = "0x206F2F8", Offset = "0x206F2F8", VA = "0x206F2F8")]
	private void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C96E")]
	[Address(RVA = "0x206F378", Offset = "0x206F378", VA = "0x206F378")]
	public void UpdateSelectState(bool isSelect)
	{
	}

	[Token(Token = "0x600C96F")]
	[Address(RVA = "0x206F5E0", Offset = "0x206F5E0", VA = "0x206F5E0")]
	public void ExecuteBtnTabItemClick()
	{
	}

	[Token(Token = "0x600C970")]
	[Address(RVA = "0x206F68C", Offset = "0x206F68C", VA = "0x206F68C", Slot = "31")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600C971")]
	[Address(RVA = "0x206F774", Offset = "0x206F774", VA = "0x206F774", Slot = "33")]
	public virtual void CheckTagState()
	{
	}

	[Token(Token = "0x600C972")]
	[Address(RVA = "0x206F150", Offset = "0x206F150", VA = "0x206F150")]
	public void CheckTipButton()
	{
	}

	[Token(Token = "0x600C973")]
	[Address(RVA = "0x206FC64", Offset = "0x206FC64", VA = "0x206FC64")]
	public void SetLock(bool b)
	{
	}

	[Token(Token = "0x600C974")]
	[Address(RVA = "0x206FD1C", Offset = "0x206FD1C", VA = "0x206FD1C")]
	public void RegistTipEvent(ETipsType tipType)
	{
	}

	[Token(Token = "0x600C975")]
	[Address(RVA = "0x206FE88", Offset = "0x206FE88", VA = "0x206FE88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C976")]
	[Address(RVA = "0x206FE90", Offset = "0x206FE90", VA = "0x206FE90")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
