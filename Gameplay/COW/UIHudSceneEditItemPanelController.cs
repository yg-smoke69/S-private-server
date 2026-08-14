using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002335")]
internal class UIHudSceneEditItemPanelController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002336")]
	private sealed class _003CUpdateAnchorsForFirstTime_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DB5D")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003CgridPos_003E__0;

		[Token(Token = "0x400DB5E")]
		[FieldOffset(Offset = "0x14")]
		internal UIHudSceneEditItemContainerController _003CguideCtrl_003E__0;

		[Token(Token = "0x400DB5F")]
		[FieldOffset(Offset = "0x18")]
		internal UIHudSceneEditItemPanelController _0024this;

		[Token(Token = "0x400DB60")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400DB61")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400DB62")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x170010BE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C389")]
			[Address(RVA = "0x24DD0F4", Offset = "0x24DD0F4", VA = "0x24DD0F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010BF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C38A")]
			[Address(RVA = "0x24DD0FC", Offset = "0x24DD0FC", VA = "0x24DD0FC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C387")]
		[Address(RVA = "0x24D8148", Offset = "0x24D8148", VA = "0x24D8148")]
		public _003CUpdateAnchorsForFirstTime_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C388")]
		[Address(RVA = "0x24DCC30", Offset = "0x24DCC30", VA = "0x24DCC30", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C38B")]
		[Address(RVA = "0x24DD104", Offset = "0x24DD104", VA = "0x24DD104", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C38C")]
		[Address(RVA = "0x24DD118", Offset = "0x24DD118", VA = "0x24DD118", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DB51")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditItemPanelView m_View;

	[Token(Token = "0x400DB52")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSceneEditItemPanelTabView mGuidSubTypeTab;

	[Token(Token = "0x400DB53")]
	[FieldOffset(Offset = "0x30")]
	private int mSelectedTab;

	[Token(Token = "0x400DB54")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<int, int> SelectedTabRecords;

	[Token(Token = "0x400DB55")]
	[FieldOffset(Offset = "0x38")]
	private int mSelectedIndex;

	[Token(Token = "0x400DB56")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x400DB57")]
	[FieldOffset(Offset = "0x40")]
	private JPPGAJBAAKK m_SceneEditGame;

	[Token(Token = "0x400DB58")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsFirstShow;

	[Token(Token = "0x400DB59")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSceneEditItemContainerController m_SelectedController;

	[Token(Token = "0x400DB5A")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIHudSceneEditItem> mDataList;

	[Token(Token = "0x400DB5B")]
	[FieldOffset(Offset = "0x50")]
	private bool mIsFolded;

	[Token(Token = "0x400DB5C")]
	[FieldOffset(Offset = "0x54")]
	private int m_CurUserMaxCost;

	[Token(Token = "0x170010BD")]
	public int SelectedIndex
	{
		[Token(Token = "0x600C362")]
		[Address(RVA = "0x24D6A20", Offset = "0x24D6A20", VA = "0x24D6A20")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600C363")]
		[Address(RVA = "0x24D6A78", Offset = "0x24D6A78", VA = "0x24D6A78")]
		set
		{
		}
	}

	[Token(Token = "0x600C361")]
	[Address(RVA = "0x24D6924", Offset = "0x24D6924", VA = "0x24D6924")]
	public UIHudSceneEditItemPanelController()
	{
	}

	[Token(Token = "0x600C364")]
	[Address(RVA = "0x24D6B20", Offset = "0x24D6B20", VA = "0x24D6B20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C365")]
	[Address(RVA = "0x24D6BC4", Offset = "0x24D6BC4", VA = "0x24D6BC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C366")]
	[Address(RVA = "0x24D7FD0", Offset = "0x24D7FD0", VA = "0x24D7FD0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C367")]
	[Address(RVA = "0x24D807C", Offset = "0x24D807C", VA = "0x24D807C")]
	private IEnumerator UpdateAnchorsForFirstTime()
	{
		return null;
	}

	[Token(Token = "0x600C368")]
	[Address(RVA = "0x24D8150", Offset = "0x24D8150", VA = "0x24D8150", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C369")]
	[Address(RVA = "0x24D77F4", Offset = "0x24D77F4", VA = "0x24D77F4")]
	public void UpdatePrefabList()
	{
	}

	[Token(Token = "0x600C36A")]
	[Address(RVA = "0x24D855C", Offset = "0x24D855C", VA = "0x24D855C")]
	private void OnSelectTab(UIToggleButton button)
	{
	}

	[Token(Token = "0x600C36B")]
	[Address(RVA = "0x24D9444", Offset = "0x24D9444", VA = "0x24D9444")]
	private void OnSelectSubTab(UIToggleButton button)
	{
	}

	[Token(Token = "0x600C36C")]
	[Address(RVA = "0x24D9628", Offset = "0x24D9628", VA = "0x24D9628")]
	private void RefreshDataForCurrentSelection()
	{
	}

	[Token(Token = "0x600C36D")]
	[Address(RVA = "0x24DA2C8", Offset = "0x24DA2C8", VA = "0x24DA2C8", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C36E")]
	[Address(RVA = "0x24DA3C0", Offset = "0x24DA3C0", VA = "0x24DA3C0", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C36F")]
	[Address(RVA = "0x24DA43C", Offset = "0x24DA43C", VA = "0x24DA43C")]
	private void OnGroupModeChanged(object[] data)
	{
	}

	[Token(Token = "0x600C370")]
	[Address(RVA = "0x24DA538", Offset = "0x24DA538", VA = "0x24DA538")]
	private void OnOtherPanelToggle(object[] data)
	{
	}

	[Token(Token = "0x600C371")]
	[Address(RVA = "0x24DA8A4", Offset = "0x24DA8A4", VA = "0x24DA8A4")]
	private void OnMoreSettingAppear(object[] data)
	{
	}

	[Token(Token = "0x600C372")]
	[Address(RVA = "0x24DA918", Offset = "0x24DA918", VA = "0x24DA918")]
	private void OnModeTemplateChanged(object[] data)
	{
	}

	[Token(Token = "0x600C373")]
	[Address(RVA = "0x24DA988", Offset = "0x24DA988", VA = "0x24DA988")]
	private void OnToggleBtnClick()
	{
	}

	[Token(Token = "0x600C374")]
	[Address(RVA = "0x24DAB78", Offset = "0x24DAB78", VA = "0x24DAB78")]
	private void OnToggleBtnReverseClick()
	{
	}

	[Token(Token = "0x600C375")]
	[Address(RVA = "0x24DA6DC", Offset = "0x24DA6DC", VA = "0x24DA6DC")]
	private void FoldSelf()
	{
	}

	[Token(Token = "0x600C376")]
	[Address(RVA = "0x24DA7C0", Offset = "0x24DA7C0", VA = "0x24DA7C0")]
	private void UnfoldSelf()
	{
	}

	[Token(Token = "0x600C377")]
	[Address(RVA = "0x24DAD1C", Offset = "0x24DAD1C", VA = "0x24DAD1C")]
	private void OnTweenFinished()
	{
	}

	[Token(Token = "0x600C378")]
	[Address(RVA = "0x24DAE84", Offset = "0x24DAE84", VA = "0x24DAE84")]
	private void OnCancelCrosshair(object[] data)
	{
	}

	[Token(Token = "0x600C379")]
	[Address(RVA = "0x24DAEEC", Offset = "0x24DAEEC", VA = "0x24DAEEC")]
	private void UnSelectItem()
	{
	}

	[Token(Token = "0x600C37A")]
	[Address(RVA = "0x24DB054", Offset = "0x24DB054", VA = "0x24DB054")]
	private void OnSelectItem(object[] data)
	{
	}

	[Token(Token = "0x600C37B")]
	[Address(RVA = "0x24D9F8C", Offset = "0x24D9F8C", VA = "0x24D9F8C")]
	private void RefreshTabNew()
	{
	}

	[Token(Token = "0x600C37C")]
	[Address(RVA = "0x24DBA38", Offset = "0x24DBA38", VA = "0x24DBA38")]
	private void OnHandleSceneEditRefresh(object[] data)
	{
	}

	[Token(Token = "0x600C37D")]
	[Address(RVA = "0x24DC2E8", Offset = "0x24DC2E8", VA = "0x24DC2E8")]
	private void OnHandleSceneEditAddPrefab(object[] data)
	{
	}

	[Token(Token = "0x600C37E")]
	[Address(RVA = "0x24DC350", Offset = "0x24DC350", VA = "0x24DC350")]
	private void OnHandleSceneEditRemovePrefab(object[] data)
	{
	}

	[Token(Token = "0x600C37F")]
	[Address(RVA = "0x24DBAA0", Offset = "0x24DBAA0", VA = "0x24DBAA0")]
	private void UpdateCost()
	{
	}

	[Token(Token = "0x600C380")]
	[Address(RVA = "0x24DC3B8", Offset = "0x24DC3B8", VA = "0x24DC3B8")]
	private void OnHintButtonClick()
	{
	}

	[Token(Token = "0x600C381")]
	[Address(RVA = "0x24DC780", Offset = "0x24DC780", VA = "0x24DC780")]
	private void OnAttributeButtonClick()
	{
	}

	[Token(Token = "0x600C382")]
	[Address(RVA = "0x24DC9C4", Offset = "0x24DC9C4", VA = "0x24DC9C4")]
	private void OnCancelPutDownObj(object[] data)
	{
	}

	[Token(Token = "0x600C383")]
	[Address(RVA = "0x24DCBD8", Offset = "0x24DCBD8", VA = "0x24DCBD8")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600C384")]
	[Address(RVA = "0x24DCC18", Offset = "0x24DCC18", VA = "0x24DCC18")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C385")]
	[Address(RVA = "0x24DCC20", Offset = "0x24DCC20", VA = "0x24DCC20")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C386")]
	[Address(RVA = "0x24DCC28", Offset = "0x24DCC28", VA = "0x24DCC28")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
