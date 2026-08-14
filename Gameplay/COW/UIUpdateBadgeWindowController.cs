using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BC7")]
public class UIUpdateBadgeWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010B86")]
	[FieldOffset(Offset = "0x48")]
	private UIUpdateBadgeWindowView m_View;

	[Token(Token = "0x4010B87")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_CurrentUsingBadgeID;

	[Token(Token = "0x4010B88")]
	[FieldOffset(Offset = "0x50")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x4010B89")]
	[FieldOffset(Offset = "0x54")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x4010B8A")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, UIBadgeItemController> m_BadgeItemDic;

	[Token(Token = "0x4010B8B")]
	[FieldOffset(Offset = "0x5C")]
	private List<UIBadgeItemController> m_BadgeItemList;

	[Token(Token = "0x4010B8C")]
	[FieldOffset(Offset = "0x60")]
	private UIClanEditController.FuntionType m_MyFunctionType;

	[Token(Token = "0x4010B8D")]
	[FieldOffset(Offset = "0x64")]
	private uint m_CurrentSelectBadgeID;

	[Token(Token = "0x60121A8")]
	[Address(RVA = "0xF53B80", Offset = "0xF53B80", VA = "0xF53B80")]
	public UIUpdateBadgeWindowController()
	{
	}

	[Token(Token = "0x60121A9")]
	[Address(RVA = "0xF53C40", Offset = "0xF53C40", VA = "0xF53C40")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60121AA")]
	[Address(RVA = "0xF53CE4", Offset = "0xF53CE4", VA = "0xF53CE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60121AB")]
	[Address(RVA = "0xF54030", Offset = "0xF54030", VA = "0xF54030")]
	private void SetInactiveState()
	{
	}

	[Token(Token = "0x60121AC")]
	[Address(RVA = "0xF54BC4", Offset = "0xF54BC4", VA = "0xF54BC4")]
	public void SetFunctionType(UIClanEditController.FuntionType type)
	{
	}

	[Token(Token = "0x60121AD")]
	[Address(RVA = "0xF54220", Offset = "0xF54220", VA = "0xF54220")]
	private void InitBadgeItemGrid()
	{
	}

	[Token(Token = "0x60121AE")]
	[Address(RVA = "0xF54C24", Offset = "0xF54C24", VA = "0xF54C24", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60121AF")]
	[Address(RVA = "0xF54CB8", Offset = "0xF54CB8", VA = "0xF54CB8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60121B0")]
	[Address(RVA = "0xF565AC", Offset = "0xF565AC", VA = "0xF565AC")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x60121B1")]
	[Address(RVA = "0xF55964", Offset = "0xF55964", VA = "0xF55964")]
	private void RefreshBadgeInfo(object[] data)
	{
	}

	[Token(Token = "0x60121B2")]
	[Address(RVA = "0xF566F8", Offset = "0xF566F8", VA = "0xF566F8")]
	private void OnRequestUpdateClanBadge()
	{
	}

	[Token(Token = "0x60121B3")]
	[Address(RVA = "0xF54F20", Offset = "0xF54F20", VA = "0xF54F20")]
	private void UpdateClanBadgeUsing(uint clanId)
	{
	}

	[Token(Token = "0x60121B4")]
	[Address(RVA = "0xF568E8", Offset = "0xF568E8", VA = "0xF568E8")]
	private void OnUnlockClanBadge()
	{
	}

	[Token(Token = "0x60121B5")]
	[Address(RVA = "0xF552D8", Offset = "0xF552D8", VA = "0xF552D8")]
	private void RefreshBadgeItemGrid()
	{
	}

	[Token(Token = "0x60121B6")]
	[Address(RVA = "0xF56A54", Offset = "0xF56A54", VA = "0xF56A54")]
	private void Clear()
	{
	}

	[Token(Token = "0x60121B7")]
	[Address(RVA = "0xF56B40", Offset = "0xF56B40", VA = "0xF56B40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
