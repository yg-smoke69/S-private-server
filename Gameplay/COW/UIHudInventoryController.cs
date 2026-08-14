using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002786")]
internal class UIHudInventoryController : UIBaseController
{
	[Token(Token = "0x2002787")]
	public enum SlotType : byte
	{
		[Token(Token = "0x400F41C")]
		Vest,
		[Token(Token = "0x400F41D")]
		Helmet,
		[Token(Token = "0x400F41E")]
		Bag,
		[Token(Token = "0x400F41F")]
		Cover,
		[Token(Token = "0x400F420")]
		PrimaryW,
		[Token(Token = "0x400F421")]
		SecondaryW,
		[Token(Token = "0x400F422")]
		SideW,
		[Token(Token = "0x400F423")]
		Melee
	}

	[Token(Token = "0x2002788")]
	private sealed class _003CRefreshCorListItem_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F424")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudInventoryController _0024this;

		[Token(Token = "0x400F425")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F426")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F427")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011CB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F312")]
			[Address(RVA = "0x2094F4C", Offset = "0x2094F4C", VA = "0x2094F4C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011CC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F313")]
			[Address(RVA = "0x2094F54", Offset = "0x2094F54", VA = "0x2094F54", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F310")]
		[Address(RVA = "0x2094EAC", Offset = "0x2094EAC", VA = "0x2094EAC")]
		public _003CRefreshCorListItem_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F311")]
		[Address(RVA = "0x2094EB4", Offset = "0x2094EB4", VA = "0x2094EB4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F314")]
		[Address(RVA = "0x2094F5C", Offset = "0x2094F5C", VA = "0x2094F5C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F315")]
		[Address(RVA = "0x2094F70", Offset = "0x2094F70", VA = "0x2094F70", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F3FD")]
	[FieldOffset(Offset = "0x28")]
	private UIHudInventoryView m_View;

	[Token(Token = "0x400F3FE")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, List<UIHudInventoryItemController>> m_ItemControllers;

	[Token(Token = "0x400F3FF")]
	[FieldOffset(Offset = "0x30")]
	private List<UIHudInventoryItemController> m_ListEndControllers;

	[Token(Token = "0x400F400")]
	[FieldOffset(Offset = "0x34")]
	private UIHudInventoryEquipSlotItemController m_VestSlot;

	[Token(Token = "0x400F401")]
	[FieldOffset(Offset = "0x38")]
	private UIHudInventoryEquipSlotItemController m_HelmetSlot;

	[Token(Token = "0x400F402")]
	[FieldOffset(Offset = "0x3C")]
	private UIHudInventoryEquipSlotItemController m_BagSlot;

	[Token(Token = "0x400F403")]
	[FieldOffset(Offset = "0x40")]
	private UIHudInventoryEquipSlotItemController m_CamouflageSlot;

	[Token(Token = "0x400F404")]
	[FieldOffset(Offset = "0x44")]
	private UIHudInventoryWeaponSlotItemController m_WeaponP1Slot;

	[Token(Token = "0x400F405")]
	[FieldOffset(Offset = "0x48")]
	private UIHudInventoryWeaponSlotItemController m_WeaponP2Slot;

	[Token(Token = "0x400F406")]
	[FieldOffset(Offset = "0x4C")]
	private UIHudInventoryWeaponSlotItemController m_WeaponS1Slot;

	[Token(Token = "0x400F407")]
	[FieldOffset(Offset = "0x50")]
	private UIHudInventoryWeaponSlotItemController m_WeaponM1Slot;

	[Token(Token = "0x400F408")]
	[FieldOffset(Offset = "0x54")]
	private UIHudPartialTrashController m_PartialTrash;

	[Token(Token = "0x400F409")]
	[FieldOffset(Offset = "0x58")]
	private UIPanel m_ScrollViewPanel;

	[Token(Token = "0x400F40A")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 m_CurrentClipOffset;

	[Token(Token = "0x400F40B")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 m_CurrentPanelLocalPos;

	[Token(Token = "0x400F40C")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 tempGridPos;

	[Token(Token = "0x400F40D")]
	[FieldOffset(Offset = "0x7C")]
	private bool inventoryTutorialShowed;

	[Token(Token = "0x400F40E")]
	[FieldOffset(Offset = "0x7D")]
	private bool showDropTutorialPrepared;

	[Token(Token = "0x400F40F")]
	[FieldOffset(Offset = "0x7E")]
	private bool dropCamouflageOpenBagShowed;

	[Token(Token = "0x400F410")]
	[FieldOffset(Offset = "0x7F")]
	private bool showDropCamouflageNoteTutorialPrepared;

	[Token(Token = "0x400F411")]
	[FieldOffset(Offset = "0x80")]
	private bool m_SortState;

	[Token(Token = "0x400F412")]
	[FieldOffset(Offset = "0x81")]
	private bool m_ItemDragged;

	[Token(Token = "0x400F413")]
	[FieldOffset(Offset = "0x82")]
	private bool m_FirstGridReposition;

	[Token(Token = "0x400F414")]
	[FieldOffset(Offset = "0x0")]
	public static Color m_SpareItemNameColor;

	[Token(Token = "0x400F415")]
	[FieldOffset(Offset = "0x10")]
	public static Color m_NormalItemNameColor;

	[Token(Token = "0x400F416")]
	[FieldOffset(Offset = "0x20")]
	protected static int m_ItemToggleGroupID;

	[Token(Token = "0x400F417")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<int, List<string>> SlotsKey;

	[Token(Token = "0x400F418")]
	[FieldOffset(Offset = "0x88")]
	private List<UIHudInventoryTagController> m_Ctrl;

	[Token(Token = "0x400F419")]
	[FieldOffset(Offset = "0x8C")]
	private AAHMJHHPECM m_weaponReplacer;

	[Token(Token = "0x400F41A")]
	[FieldOffset(Offset = "0x24")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600F2C6")]
	[Address(RVA = "0x22ACF7C", Offset = "0x22ACF7C", VA = "0x22ACF7C")]
	public UIHudInventoryController()
	{
	}

	[Token(Token = "0x600F2C7")]
	[Address(RVA = "0x22AD860", Offset = "0x22AD860", VA = "0x22AD860")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F2C8")]
	[Address(RVA = "0x22AD904", Offset = "0x22AD904", VA = "0x22AD904", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F2C9")]
	[Address(RVA = "0x22AF684", Offset = "0x22AF684", VA = "0x22AF684")]
	private void InitInventoryItemPool()
	{
	}

	[Token(Token = "0x600F2CA")]
	[Address(RVA = "0x22AF928", Offset = "0x22AF928", VA = "0x22AF928")]
	private void InitInventoryTagPool()
	{
	}

	[Token(Token = "0x600F2CB")]
	[Address(RVA = "0x22B06F0", Offset = "0x22B06F0", VA = "0x22B06F0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F2CC")]
	[Address(RVA = "0x22B0754", Offset = "0x22B0754", VA = "0x22B0754")]
	private void Update()
	{
	}

	[Token(Token = "0x600F2CD")]
	[Address(RVA = "0x22B0CC8", Offset = "0x22B0CC8", VA = "0x22B0CC8")]
	private void OnInventoryTrashStateChange(object[] data)
	{
	}

	[Token(Token = "0x600F2CE")]
	[Address(RVA = "0x22B0F70", Offset = "0x22B0F70", VA = "0x22B0F70")]
	private void OnTrashPartialShow(object[] data)
	{
	}

	[Token(Token = "0x600F2CF")]
	[Address(RVA = "0x22B16F4", Offset = "0x22B16F4", VA = "0x22B16F4")]
	private void OnVestToggleChanged()
	{
	}

	[Token(Token = "0x600F2D0")]
	[Address(RVA = "0x22B1A50", Offset = "0x22B1A50", VA = "0x22B1A50")]
	private void OnHelmetToggleChanged()
	{
	}

	[Token(Token = "0x600F2D1")]
	[Address(RVA = "0x22B1D78", Offset = "0x22B1D78", VA = "0x22B1D78")]
	private void OnBagToggleChanged()
	{
	}

	[Token(Token = "0x600F2D2")]
	[Address(RVA = "0x22B20A0", Offset = "0x22B20A0", VA = "0x22B20A0")]
	private void OnCoverToggleChanged()
	{
	}

	[Token(Token = "0x600F2D3")]
	[Address(RVA = "0x22B23C8", Offset = "0x22B23C8", VA = "0x22B23C8")]
	private void OnPrimaryWToggleChanged()
	{
	}

	[Token(Token = "0x600F2D4")]
	[Address(RVA = "0x22B26F0", Offset = "0x22B26F0", VA = "0x22B26F0")]
	private void OnSecondaryWToggleChanged()
	{
	}

	[Token(Token = "0x600F2D5")]
	[Address(RVA = "0x22B2A18", Offset = "0x22B2A18", VA = "0x22B2A18")]
	private void OnSideWToggleChanged()
	{
	}

	[Token(Token = "0x600F2D6")]
	[Address(RVA = "0x22B2D40", Offset = "0x22B2D40", VA = "0x22B2D40")]
	private void OnMeleeToggleChanged()
	{
	}

	[Token(Token = "0x600F2D7")]
	[Address(RVA = "0x22B3068", Offset = "0x22B3068", VA = "0x22B3068")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600F2D8")]
	[Address(RVA = "0x22B369C", Offset = "0x22B369C", VA = "0x22B369C")]
	private void OnInventoryOpen(object[] param)
	{
	}

	[Token(Token = "0x600F2D9")]
	[Address(RVA = "0x22B3E78", Offset = "0x22B3E78", VA = "0x22B3E78")]
	private void CheckChangeItemColor()
	{
	}

	[Token(Token = "0x600F2DA")]
	[Address(RVA = "0x22B44E8", Offset = "0x22B44E8", VA = "0x22B44E8")]
	private void OnItemDragStart(object[] datas)
	{
	}

	[Token(Token = "0x600F2DB")]
	[Address(RVA = "0x22B4544", Offset = "0x22B4544", VA = "0x22B4544")]
	private void OnShowIngameShop(object[] data)
	{
	}

	[Token(Token = "0x600F2DC")]
	[Address(RVA = "0x22B48B8", Offset = "0x22B48B8", VA = "0x22B48B8")]
	private void OnTryReplaceWeapon(object[] data)
	{
	}

	[Token(Token = "0x600F2DD")]
	[Address(RVA = "0x22B4A24", Offset = "0x22B4A24", VA = "0x22B4A24")]
	private void setTryReplaceWeapon(AAHMJHHPECM replacer)
	{
	}

	[Token(Token = "0x600F2DE")]
	[Address(RVA = "0x22B4AD0", Offset = "0x22B4AD0", VA = "0x22B4AD0")]
	private void OnRepositionGrid(object[] data)
	{
	}

	[Token(Token = "0x600F2DF")]
	[Address(RVA = "0x22B4BA0", Offset = "0x22B4BA0", VA = "0x22B4BA0")]
	private void OnTokenChanged(object[] data)
	{
	}

	[Token(Token = "0x600F2E0")]
	[Address(RVA = "0x22B4DBC", Offset = "0x22B4DBC", VA = "0x22B4DBC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F2E1")]
	[Address(RVA = "0x22B30F0", Offset = "0x22B30F0", VA = "0x22B30F0")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600F2E2")]
	[Address(RVA = "0x22B5948", Offset = "0x22B5948", VA = "0x22B5948")]
	private void OnBtnCloseMask()
	{
	}

	[Token(Token = "0x600F2E3")]
	[Address(RVA = "0x22B5C0C", Offset = "0x22B5C0C", VA = "0x22B5C0C")]
	private void OnBtnSort()
	{
	}

	[Token(Token = "0x600F2E4")]
	[Address(RVA = "0x22B6B1C", Offset = "0x22B6B1C", VA = "0x22B6B1C")]
	public int Exchange2NewNegativeId(int type)
	{
		return default(int);
	}

	[Token(Token = "0x600F2E5")]
	[Address(RVA = "0x22B6BA8", Offset = "0x22B6BA8", VA = "0x22B6BA8")]
	public int Exchange2NewPositiveId(int type)
	{
		return default(int);
	}

	[Token(Token = "0x600F2E6")]
	[Address(RVA = "0x22B6C34", Offset = "0x22B6C34", VA = "0x22B6C34")]
	private int ItemPositiveSort(UIItem a, UIItem b)
	{
		return default(int);
	}

	[Token(Token = "0x600F2E7")]
	[Address(RVA = "0x22B6DD0", Offset = "0x22B6DD0", VA = "0x22B6DD0")]
	private int ItemNegativeSort(UIItem a, UIItem b)
	{
		return default(int);
	}

	[Token(Token = "0x600F2E8")]
	[Address(RVA = "0x22B6F6C", Offset = "0x22B6F6C", VA = "0x22B6F6C")]
	private void OnAddLocalPlayer(object[] param)
	{
	}

	[Token(Token = "0x600F2E9")]
	[Address(RVA = "0x22B702C", Offset = "0x22B702C", VA = "0x22B702C")]
	private void OnCapacityRefresh(object[] param)
	{
	}

	[Token(Token = "0x600F2EA")]
	[Address(RVA = "0x22B73C0", Offset = "0x22B73C0", VA = "0x22B73C0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F2EB")]
	[Address(RVA = "0x22B7A58", Offset = "0x22B7A58", VA = "0x22B7A58")]
	private void OnInventoryRefresh(object[] param)
	{
	}

	[Token(Token = "0x600F2EC")]
	[Address(RVA = "0x22B85E0", Offset = "0x22B85E0", VA = "0x22B85E0")]
	private void CloseAllTagCtrls()
	{
	}

	[Token(Token = "0x600F2ED")]
	[Address(RVA = "0x22B8824", Offset = "0x22B8824", VA = "0x22B8824")]
	private void OnInventoryItemSelected(object[] param)
	{
	}

	[Token(Token = "0x600F2EE")]
	[Address(RVA = "0x22B92A4", Offset = "0x22B92A4", VA = "0x22B92A4")]
	private void OnInventoryItemUnSelected(object[] param)
	{
	}

	[Token(Token = "0x600F2EF")]
	[Address(RVA = "0x22B9408", Offset = "0x22B9408", VA = "0x22B9408")]
	private void OnInventoryItemReleased(object[] param)
	{
	}

	[Token(Token = "0x600F2F0")]
	[Address(RVA = "0x22B9578", Offset = "0x22B9578", VA = "0x22B9578")]
	private IEnumerator RefreshCorListItem()
	{
		return null;
	}

	[Token(Token = "0x600F2F1")]
	[Address(RVA = "0x22B9644", Offset = "0x22B9644", VA = "0x22B9644")]
	private void OnInventoryAttachmentStateChanged(object[] param)
	{
	}

	[Token(Token = "0x600F2F2")]
	[Address(RVA = "0x22B9C90", Offset = "0x22B9C90", VA = "0x22B9C90")]
	private void OnInventoryEquipmentStateChanged(object[] param)
	{
	}

	[Token(Token = "0x600F2F3")]
	[Address(RVA = "0x22AF3F0", Offset = "0x22AF3F0", VA = "0x22AF3F0")]
	private void ClearDescription()
	{
	}

	[Token(Token = "0x600F2F4")]
	[Address(RVA = "0x22B99F8", Offset = "0x22B99F8", VA = "0x22B99F8")]
	private void RemoveItemFromList(AAHMJHHPECM item)
	{
	}

	[Token(Token = "0x600F2F5")]
	[Address(RVA = "0x22BB964", Offset = "0x22BB964", VA = "0x22BB964")]
	private void ReSumeItemGrid()
	{
	}

	[Token(Token = "0x600F2F6")]
	[Address(RVA = "0x22BBA9C", Offset = "0x22BBA9C", VA = "0x22BBA9C")]
	private void ReSetNewItemListGrid()
	{
	}

	[Token(Token = "0x600F2F7")]
	[Address(RVA = "0x22BB7FC", Offset = "0x22BB7FC", VA = "0x22BB7FC")]
	private void ResetItemListGrid(bool flag = true)
	{
	}

	[Token(Token = "0x600F2F8")]
	[Address(RVA = "0x22B7BE4", Offset = "0x22B7BE4", VA = "0x22B7BE4")]
	private void RefreshItemList(AAHMJHHPECM item)
	{
	}

	[Token(Token = "0x600F2F9")]
	[Address(RVA = "0x22BC308", Offset = "0x22BC308", VA = "0x22BC308")]
	private void UpdateItemGrid()
	{
	}

	[Token(Token = "0x600F2FA")]
	[Address(RVA = "0x22B79A0", Offset = "0x22B79A0", VA = "0x22B79A0")]
	private void RefreshWeaponAmmo()
	{
	}

	[Token(Token = "0x600F2FB")]
	[Address(RVA = "0x22AFC2C", Offset = "0x22AFC2C", VA = "0x22AFC2C")]
	private UIHudInventoryItemController OpenInventoryItemControllerFromPool(Transform transform)
	{
		return null;
	}

	[Token(Token = "0x600F2FC")]
	[Address(RVA = "0x22AFEB0", Offset = "0x22AFEB0", VA = "0x22AFEB0")]
	private void CloseInventoryItemController(UIHudInventoryItemController itemController, AAHMJHHPECM item)
	{
	}

	[Token(Token = "0x600F2FD")]
	[Address(RVA = "0x22B0248", Offset = "0x22B0248", VA = "0x22B0248")]
	private UIHudInventoryTagController OpenInventoryTagFromPool(Transform transform)
	{
		return null;
	}

	[Token(Token = "0x600F2FE")]
	[Address(RVA = "0x22B04CC", Offset = "0x22B04CC", VA = "0x22B04CC")]
	private void CloseInventoryTagItemController(UIHudInventoryTagController itemController)
	{
	}

	[Token(Token = "0x600F2FF")]
	[Address(RVA = "0x22B3D90", Offset = "0x22B3D90", VA = "0x22B3D90")]
	private void SetScrollPos()
	{
	}

	[Token(Token = "0x600F300")]
	[Address(RVA = "0x22BC170", Offset = "0x22BC170", VA = "0x22BC170")]
	private void RessetScrollPos()
	{
	}

	[Token(Token = "0x600F301")]
	[Address(RVA = "0x22BC9A8", Offset = "0x22BC9A8", VA = "0x22BC9A8")]
	private void CloseInventory(object[] data)
	{
	}

	[Token(Token = "0x600F302")]
	[Address(RVA = "0x22BCCC4", Offset = "0x22BCCC4", VA = "0x22BCCC4")]
	private void OnInventoryDragAndDrop(object[] data)
	{
	}

	[Token(Token = "0x600F303")]
	[Address(RVA = "0x22BD120", Offset = "0x22BD120", VA = "0x22BD120")]
	private void OnInventoryNoCapacityToPickup(object[] data)
	{
	}

	[Token(Token = "0x600F304")]
	[Address(RVA = "0x22BD188", Offset = "0x22BD188", VA = "0x22BD188")]
	private void OnShowDropTutorial(object[] data)
	{
	}

	[Token(Token = "0x600F305")]
	[Address(RVA = "0x22BD1F0", Offset = "0x22BD1F0", VA = "0x22BD1F0")]
	private void OnDropCamouflageOpenBagShowed(object[] data)
	{
	}

	[Token(Token = "0x600F306")]
	[Address(RVA = "0x22BD258", Offset = "0x22BD258", VA = "0x22BD258")]
	private void OnShowTutorialDropCamouflageNote(object[] data)
	{
	}

	[Token(Token = "0x600F307")]
	[Address(RVA = "0x22BD2C0", Offset = "0x22BD2C0", VA = "0x22BD2C0")]
	private void OnReplacerCountChange(object[] data)
	{
	}

	[Token(Token = "0x600F308")]
	[Address(RVA = "0x22B4450", Offset = "0x22B4450", VA = "0x22B4450")]
	private void RefreshUpgradeWeaponStatus()
	{
	}

	[Token(Token = "0x600F30A")]
	[Address(RVA = "0x22BD428", Offset = "0x22BD428", VA = "0x22BD428")]
	private void _003COnVisibilityChanged_003Em__0()
	{
	}

	[Token(Token = "0x600F30B")]
	[Address(RVA = "0x22BD5FC", Offset = "0x22BD5FC", VA = "0x22BD5FC")]
	private static void _003COnVisibilityChanged_003Em__1()
	{
	}

	[Token(Token = "0x600F30C")]
	[Address(RVA = "0x22BD6C8", Offset = "0x22BD6C8", VA = "0x22BD6C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F30D")]
	[Address(RVA = "0x22BD6D0", Offset = "0x22BD6D0", VA = "0x22BD6D0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F30E")]
	[Address(RVA = "0x22BD6D8", Offset = "0x22BD6D8", VA = "0x22BD6D8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F30F")]
	[Address(RVA = "0x22BD6E0", Offset = "0x22BD6E0", VA = "0x22BD6E0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
