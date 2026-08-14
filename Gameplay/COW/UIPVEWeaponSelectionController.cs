using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022C9")]
public class UIPVEWeaponSelectionController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400D963")]
	[FieldOffset(Offset = "0x48")]
	private UIPVEWeaponSelectionView m_View;

	[Token(Token = "0x400D964")]
	[FieldOffset(Offset = "0x4C")]
	private UIPVEWeaponPropertyController m_SelectedWeaponProperty;

	[Token(Token = "0x400D965")]
	[FieldOffset(Offset = "0x50")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400D966")]
	[FieldOffset(Offset = "0x54")]
	private UIModelPVE m_ModelPVE;

	[Token(Token = "0x400D967")]
	[FieldOffset(Offset = "0x58")]
	private uint m_SelectedWeaponSkinId;

	[Token(Token = "0x400D968")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_SelectedWeaponId;

	[Token(Token = "0x400D969")]
	[FieldOffset(Offset = "0x60")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x600BF8C")]
	[Address(RVA = "0x15AE138", Offset = "0x15AE138", VA = "0x15AE138")]
	public UIPVEWeaponSelectionController()
	{
	}

	[Token(Token = "0x600BF8D")]
	[Address(RVA = "0x15AE140", Offset = "0x15AE140", VA = "0x15AE140")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF8E")]
	[Address(RVA = "0x15AE1E8", Offset = "0x15AE1E8", VA = "0x15AE1E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF8F")]
	[Address(RVA = "0x15AEF2C", Offset = "0x15AEF2C", VA = "0x15AEF2C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BF90")]
	[Address(RVA = "0x15AEFB4", Offset = "0x15AEFB4", VA = "0x15AEFB4")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600BF91")]
	[Address(RVA = "0x15AEBD4", Offset = "0x15AEBD4", VA = "0x15AEBD4")]
	public void RefreshPrimaryWeapon(uint itemid)
	{
	}

	[Token(Token = "0x600BF92")]
	[Address(RVA = "0x15ABD7C", Offset = "0x15ABD7C", VA = "0x15ABD7C")]
	public void RefreshSelectedWeaponTypeByID(uint itemid)
	{
	}

	[Token(Token = "0x600BF93")]
	private void RefreshWeaponSkinList<DataType>(List<DataType> dataList, bool needResort = true)
	{
	}

	[Token(Token = "0x600BF94")]
	[Address(RVA = "0x15AE5E4", Offset = "0x15AE5E4", VA = "0x15AE5E4")]
	private void SetTabsUIData()
	{
	}

	[Token(Token = "0x600BF95")]
	[Address(RVA = "0x15AF0CC", Offset = "0x15AF0CC", VA = "0x15AF0CC", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600BF96")]
	[Address(RVA = "0x15AF1C4", Offset = "0x15AF1C4", VA = "0x15AF1C4", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600BF97")]
	[Address(RVA = "0x15AF240", Offset = "0x15AF240", VA = "0x15AF240", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BF98")]
	[Address(RVA = "0x15AF3C4", Offset = "0x15AF3C4", VA = "0x15AF3C4", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BF99")]
	[Address(RVA = "0x15AF458", Offset = "0x15AF458", VA = "0x15AF458")]
	private bool _003CRefreshSelectedWeaponTypeByID_003Em__0(WeaponSkinBaseInfo wpInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600BF9A")]
	[Address(RVA = "0x15AF4B0", Offset = "0x15AF4B0", VA = "0x15AF4B0")]
	private int _003CSetTabsUIData_003Em__1(uint a, uint b)
	{
		return default(int);
	}

	[Token(Token = "0x600BF9B")]
	[Address(RVA = "0x15AF718", Offset = "0x15AF718", VA = "0x15AF718")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BF9C")]
	[Address(RVA = "0x15AF720", Offset = "0x15AF720", VA = "0x15AF720")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
