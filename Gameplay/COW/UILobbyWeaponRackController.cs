using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200294B")]
public class UILobbyWeaponRackController : UINavigationController, _Attribute
{
	[Token(Token = "0x200294C")]
	private sealed class _003COnCameraMoveEnd_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FE8C")]
		[FieldOffset(Offset = "0x8")]
		internal string key;

		[Token(Token = "0x400FE8D")]
		[FieldOffset(Offset = "0xC")]
		internal UILobbyWeaponRackController _0024this;

		[Token(Token = "0x6010800")]
		[Address(RVA = "0x21E1734", Offset = "0x21E1734", VA = "0x21E1734")]
		public _003COnCameraMoveEnd_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010801")]
		[Address(RVA = "0x21E173C", Offset = "0x21E173C", VA = "0x21E173C")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6010802")]
		[Address(RVA = "0x21E18CC", Offset = "0x21E18CC", VA = "0x21E18CC")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400FE7A")]
	private const string UILobbyWeaponRackNewGuideKey = "UILOBBYWEAPONRACKNEWGUIDEKEY";

	[Token(Token = "0x400FE7B")]
	[FieldOffset(Offset = "0x68")]
	private UILobbyWeaponRackView m_View;

	[Token(Token = "0x400FE7C")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelWeaponRack m_ModelRack;

	[Token(Token = "0x400FE7D")]
	[FieldOffset(Offset = "0x70")]
	private UIPopMenuSmallControler m_PopMenuGun;

	[Token(Token = "0x400FE7E")]
	[FieldOffset(Offset = "0x74")]
	private UIPopMenuSmallControler m_PopMenuRare;

	[Token(Token = "0x400FE7F")]
	[FieldOffset(Offset = "0x78")]
	private uint m_CurrentSelectWeaponID;

	[Token(Token = "0x400FE80")]
	[FieldOffset(Offset = "0x7C")]
	private CollectionDataManager.ECollectionWeaponType m_CurrentFilterWeaponType;

	[Token(Token = "0x400FE81")]
	[FieldOffset(Offset = "0x80")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400FE82")]
	[FieldOffset(Offset = "0x84")]
	private List<PopMenuData> m_WeaponTypeFilterPopMenuList;

	[Token(Token = "0x400FE83")]
	[FieldOffset(Offset = "0x88")]
	private List<PopMenuData> m_WeaponRareFilterPopMenuList;

	[Token(Token = "0x400FE84")]
	[FieldOffset(Offset = "0x8C")]
	private List<WeaponItemData> m_CurrentListBeforeQuality;

	[Token(Token = "0x400FE85")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<uint, List<WeaponSkinBaseInfo>> WeaponSkinBaseInfoDic;

	[Token(Token = "0x400FE86")]
	[FieldOffset(Offset = "0x94")]
	private Dictionary<uint, List<uint>> m_WeaponDataList;

	[Token(Token = "0x400FE87")]
	[FieldOffset(Offset = "0x98")]
	private List<uint> m_WeaponTypeList;

	[Token(Token = "0x400FE88")]
	private const string DEFAULTWEAPONTYPE = "T_15_Q_LIVE_ALL";

	[Token(Token = "0x400FE89")]
	[FieldOffset(Offset = "0x9C")]
	private Dictionary<uint, string> m_DictWeaponType2Text;

	[Token(Token = "0x400FE8A")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400FE8B")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<WeaponItemData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60107E4")]
	[Address(RVA = "0x1CC15DC", Offset = "0x1CC15DC", VA = "0x1CC15DC")]
	public UILobbyWeaponRackController()
	{
	}

	[Token(Token = "0x60107E5")]
	[Address(RVA = "0x1CC1E6C", Offset = "0x1CC1E6C", VA = "0x1CC1E6C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60107E6")]
	[Address(RVA = "0x1CC1F10", Offset = "0x1CC1F10", VA = "0x1CC1F10", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60107E7")]
	[Address(RVA = "0x1CC2488", Offset = "0x1CC2488", VA = "0x1CC2488", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60107E8")]
	[Address(RVA = "0x1CC2770", Offset = "0x1CC2770", VA = "0x1CC2770", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60107E9")]
	[Address(RVA = "0x1CC4210", Offset = "0x1CC4210", VA = "0x1CC4210", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x60107EA")]
	[Address(RVA = "0x1CC438C", Offset = "0x1CC438C", VA = "0x1CC438C", Slot = "41")]
	protected override void OnHelpButtonClick(object[] param)
	{
	}

	[Token(Token = "0x60107EB")]
	[Address(RVA = "0x1CC3408", Offset = "0x1CC3408", VA = "0x1CC3408")]
	private void ProcessCollectionData()
	{
	}

	[Token(Token = "0x60107EC")]
	[Address(RVA = "0x1CC4538", Offset = "0x1CC4538", VA = "0x1CC4538")]
	private void RefreshWeaponList(List<WeaponSkinBaseInfo> weaponList)
	{
	}

	[Token(Token = "0x60107ED")]
	[Address(RVA = "0x1CC4BB4", Offset = "0x1CC4BB4", VA = "0x1CC4BB4", Slot = "42")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60107EE")]
	[Address(RVA = "0x1CC4CE4", Offset = "0x1CC4CE4", VA = "0x1CC4CE4", Slot = "43")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60107EF")]
	[Address(RVA = "0x1CC4D60", Offset = "0x1CC4D60", VA = "0x1CC4D60")]
	private void GenerateWeaponTypeFilterData()
	{
	}

	[Token(Token = "0x60107F0")]
	[Address(RVA = "0x1CC5390", Offset = "0x1CC5390", VA = "0x1CC5390")]
	private void OnWeaponTypeFilterItemClick(object data)
	{
	}

	[Token(Token = "0x60107F1")]
	[Address(RVA = "0x1CC566C", Offset = "0x1CC566C", VA = "0x1CC566C")]
	private void GenerateQualityPopData()
	{
	}

	[Token(Token = "0x60107F2")]
	[Address(RVA = "0x1CC5D28", Offset = "0x1CC5D28", VA = "0x1CC5D28")]
	private void OnQualityItemClick(object data)
	{
	}

	[Token(Token = "0x60107F3")]
	[Address(RVA = "0x1CC3FD4", Offset = "0x1CC3FD4", VA = "0x1CC3FD4")]
	private void RefreshAllWeapons()
	{
	}

	[Token(Token = "0x60107F4")]
	[Address(RVA = "0x1CC6064", Offset = "0x1CC6064", VA = "0x1CC6064")]
	private void OnDragStart(object[] data)
	{
	}

	[Token(Token = "0x60107F5")]
	[Address(RVA = "0x1CC60FC", Offset = "0x1CC60FC", VA = "0x1CC60FC")]
	private void OnClickCloseButton()
	{
	}

	[Token(Token = "0x60107F6")]
	[Address(RVA = "0x1CC6208", Offset = "0x1CC6208", VA = "0x1CC6208")]
	private void OnClickHelpButton()
	{
	}

	[Token(Token = "0x60107F7")]
	[Address(RVA = "0x1CC6450", Offset = "0x1CC6450", VA = "0x1CC6450")]
	private void OnGotoShopButtonClick()
	{
	}

	[Token(Token = "0x60107F8")]
	[Address(RVA = "0x1CC6654", Offset = "0x1CC6654", VA = "0x1CC6654")]
	private void OnCameraMoveEnd(object[] data)
	{
	}

	[Token(Token = "0x60107F9")]
	[Address(RVA = "0x1CC6B30", Offset = "0x1CC6B30", VA = "0x1CC6B30")]
	private static int _003CProcessCollectionData_003Em__0(uint a, uint b)
	{
		return default(int);
	}

	[Token(Token = "0x60107FA")]
	[Address(RVA = "0x1CC6C24", Offset = "0x1CC6C24", VA = "0x1CC6C24")]
	private static int _003CRefreshWeaponList_003Em__1(WeaponItemData a, WeaponItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x60107FB")]
	[Address(RVA = "0x1CC6C58", Offset = "0x1CC6C58", VA = "0x1CC6C58")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60107FC")]
	[Address(RVA = "0x1CC6C60", Offset = "0x1CC6C60", VA = "0x1CC6C60")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x60107FD")]
	[Address(RVA = "0x1CC6C68", Offset = "0x1CC6C68", VA = "0x1CC6C68")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60107FE")]
	[Address(RVA = "0x1CC6C70", Offset = "0x1CC6C70", VA = "0x1CC6C70")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x60107FF")]
	[Address(RVA = "0x1CC6C78", Offset = "0x1CC6C78", VA = "0x1CC6C78")]
	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
