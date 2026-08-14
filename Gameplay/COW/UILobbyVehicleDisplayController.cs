using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200213D")]
public class UILobbyVehicleDisplayController : UINavigationController, _Attribute
{
	[Token(Token = "0x400D066")]
	[FieldOffset(Offset = "0x68")]
	private UILobbyVehicleDisplayView m_View;

	[Token(Token = "0x400D067")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelVehicleDisplay m_Model;

	[Token(Token = "0x400D068")]
	[FieldOffset(Offset = "0x70")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400D069")]
	[FieldOffset(Offset = "0x74")]
	private UIPopMenuSmallControler m_PopMenuVehicle;

	[Token(Token = "0x400D06A")]
	[FieldOffset(Offset = "0x78")]
	private KLODDDDBAFP m_SelectedData;

	[Token(Token = "0x400D06B")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_CurrentSkinID;

	[Token(Token = "0x400D06C")]
	[FieldOffset(Offset = "0x80")]
	private List<PopMenuData> m_VehicleTypeFilterPopMenuList;

	[Token(Token = "0x400D06D")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<uint, VehicleDisplayItemData> m_VehicleDic;

	[Token(Token = "0x400D06E")]
	[FieldOffset(Offset = "0x88")]
	private UICommonGuideController m_guideController;

	[Token(Token = "0x400D06F")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<PopMenuData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D070")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<VehicleDisplayItemData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600AE97")]
	[Address(RVA = "0x1CBAAFC", Offset = "0x1CBAAFC", VA = "0x1CBAAFC")]
	public UILobbyVehicleDisplayController()
	{
	}

	[Token(Token = "0x600AE98")]
	[Address(RVA = "0x1CBABE8", Offset = "0x1CBABE8", VA = "0x1CBABE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AE99")]
	[Address(RVA = "0x1CBAC8C", Offset = "0x1CBAC8C", VA = "0x1CBAC8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AE9A")]
	[Address(RVA = "0x1CBB3A0", Offset = "0x1CBB3A0", VA = "0x1CBB3A0")]
	private void OnAutoRotateClicked()
	{
	}

	[Token(Token = "0x600AE9B")]
	[Address(RVA = "0x1CBB894", Offset = "0x1CBB894", VA = "0x1CBB894", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AE9C")]
	[Address(RVA = "0x1CBC814", Offset = "0x1CBC814", VA = "0x1CBC814", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AE9D")]
	[Address(RVA = "0x1CBC9F4", Offset = "0x1CBC9F4", VA = "0x1CBC9F4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AE9E")]
	[Address(RVA = "0x1CBCBEC", Offset = "0x1CBCBEC", VA = "0x1CBCBEC", Slot = "42")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600AE9F")]
	[Address(RVA = "0x1CBCD1C", Offset = "0x1CBCD1C", VA = "0x1CBCD1C", Slot = "43")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600AEA0")]
	[Address(RVA = "0x1CBCD98", Offset = "0x1CBCD98", VA = "0x1CBCD98")]
	private void OnGotoShopButtonClick()
	{
	}

	[Token(Token = "0x600AEA1")]
	[Address(RVA = "0x1CBCFA0", Offset = "0x1CBCFA0", VA = "0x1CBCFA0")]
	private void OnRemoveButtonClicked()
	{
	}

	[Token(Token = "0x600AEA2")]
	[Address(RVA = "0x1CBD228", Offset = "0x1CBD228", VA = "0x1CBD228")]
	private void GeneratePopMenuData()
	{
	}

	[Token(Token = "0x600AEA3")]
	[Address(RVA = "0x1CBDB1C", Offset = "0x1CBDB1C", VA = "0x1CBDB1C")]
	private void OnPopMenuItemSelected(object obj)
	{
	}

	[Token(Token = "0x600AEA4")]
	[Address(RVA = "0x1CBBF50", Offset = "0x1CBBF50", VA = "0x1CBBF50")]
	private void SetVehicleList(uint vehicleID)
	{
	}

	[Token(Token = "0x600AEA5")]
	[Address(RVA = "0x1CBDC80", Offset = "0x1CBDC80", VA = "0x1CBDC80")]
	private void OnClickCloseButton()
	{
	}

	[Token(Token = "0x600AEA6")]
	[Address(RVA = "0x1CBDD8C", Offset = "0x1CBDD8C", VA = "0x1CBDD8C")]
	private void OnClickHelpButton()
	{
	}

	[Token(Token = "0x600AEA7")]
	[Address(RVA = "0x1CBDFD4", Offset = "0x1CBDFD4", VA = "0x1CBDFD4")]
	private void ChangeVehicle(object[] data)
	{
	}

	[Token(Token = "0x600AEA8")]
	[Address(RVA = "0x1CBE518", Offset = "0x1CBE518", VA = "0x1CBE518")]
	private void OnCameraMoveEnd(object[] data)
	{
	}

	[Token(Token = "0x600AEA9")]
	[Address(RVA = "0x1CBE8BC", Offset = "0x1CBE8BC", VA = "0x1CBE8BC")]
	private static int _003CGeneratePopMenuData_003Em__0(PopMenuData a, PopMenuData b)
	{
		return default(int);
	}

	[Token(Token = "0x600AEAA")]
	[Address(RVA = "0x1CBE9E0", Offset = "0x1CBE9E0", VA = "0x1CBE9E0")]
	private static int _003CSetVehicleList_003Em__1(VehicleDisplayItemData a, VehicleDisplayItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x600AEAB")]
	[Address(RVA = "0x1CBEA14", Offset = "0x1CBEA14", VA = "0x1CBEA14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AEAC")]
	[Address(RVA = "0x1CBEA1C", Offset = "0x1CBEA1C", VA = "0x1CBEA1C")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600AEAD")]
	[Address(RVA = "0x1CBEA24", Offset = "0x1CBEA24", VA = "0x1CBEA24")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AEAE")]
	[Address(RVA = "0x1CBEA2C", Offset = "0x1CBEA2C", VA = "0x1CBEA2C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
