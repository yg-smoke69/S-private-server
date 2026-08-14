using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020EA")]
public class UIHUDEquipUnlockLevelController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CDDD")]
	[FieldOffset(Offset = "0x48")]
	private UIHUDEquipUnlockLevelView m_View;

	[Token(Token = "0x400CDDE")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIHudBanknoteShopLevelListController> m_LevelList;

	[Token(Token = "0x400CDDF")]
	[FieldOffset(Offset = "0x50")]
	private int m_OneLevelSetCount;

	[Token(Token = "0x400CDE0")]
	[FieldOffset(Offset = "0x54")]
	private UITimeLabelHelper m_EndTime;

	[Token(Token = "0x600AA7F")]
	[Address(RVA = "0x1678674", Offset = "0x1678674", VA = "0x1678674")]
	public UIHUDEquipUnlockLevelController()
	{
	}

	[Token(Token = "0x600AA80")]
	[Address(RVA = "0x167867C", Offset = "0x167867C", VA = "0x167867C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA81")]
	[Address(RVA = "0x1678724", Offset = "0x1678724", VA = "0x1678724", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AA82")]
	[Address(RVA = "0x1678A40", Offset = "0x1678A40", VA = "0x1678A40", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AA83")]
	[Address(RVA = "0x1678AD4", Offset = "0x1678AD4", VA = "0x1678AD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AA84")]
	[Address(RVA = "0x1679074", Offset = "0x1679074", VA = "0x1679074", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AA85")]
	[Address(RVA = "0x1678CC8", Offset = "0x1678CC8", VA = "0x1678CC8")]
	public void SetUpData()
	{
	}

	[Token(Token = "0x600AA86")]
	[Address(RVA = "0x16791A4", Offset = "0x16791A4", VA = "0x16791A4")]
	public void InitOneLevel(int levelIndex)
	{
	}

	[Token(Token = "0x600AA87")]
	[Address(RVA = "0x1679344", Offset = "0x1679344", VA = "0x1679344")]
	public void ShowWindow(float showTime)
	{
	}

	[Token(Token = "0x600AA88")]
	[Address(RVA = "0x16787F0", Offset = "0x16787F0", VA = "0x16787F0")]
	public void UpdateUnLockInfo()
	{
	}

	[Token(Token = "0x600AA89")]
	[Address(RVA = "0x16795AC", Offset = "0x16795AC", VA = "0x16795AC")]
	public void RefreshSelectedItem()
	{
	}

	[Token(Token = "0x600AA8A")]
	[Address(RVA = "0x1679600", Offset = "0x1679600", VA = "0x1679600")]
	public void OnConfirm()
	{
	}

	[Token(Token = "0x600AA8B")]
	[Address(RVA = "0x16798F4", Offset = "0x16798F4", VA = "0x16798F4")]
	public void SendSelectInfoToServer()
	{
	}

	[Token(Token = "0x600AA8C")]
	[Address(RVA = "0x1679AA0", Offset = "0x1679AA0", VA = "0x1679AA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600AA8D")]
	[Address(RVA = "0x1679B40", Offset = "0x1679B40", VA = "0x1679B40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AA8E")]
	[Address(RVA = "0x1679B48", Offset = "0x1679B48", VA = "0x1679B48")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
