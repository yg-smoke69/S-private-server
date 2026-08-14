using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C22")]
internal class UIWorkshopCreateRoomController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x2002C23")]
	private sealed class _003CResetRefreshBtn_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010D99")]
		[FieldOffset(Offset = "0x8")]
		internal UIWorkshopCreateRoomController _0024this;

		[Token(Token = "0x4010D9A")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010D9B")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010D9C")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001325")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601261C")]
			[Address(RVA = "0x1A29B78", Offset = "0x1A29B78", VA = "0x1A29B78", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001326")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601261D")]
			[Address(RVA = "0x1A29B80", Offset = "0x1A29B80", VA = "0x1A29B80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601261A")]
		[Address(RVA = "0x1A28314", Offset = "0x1A28314", VA = "0x1A28314")]
		public _003CResetRefreshBtn_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601261B")]
		[Address(RVA = "0x1A29A54", Offset = "0x1A29A54", VA = "0x1A29A54", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601261E")]
		[Address(RVA = "0x1A29B88", Offset = "0x1A29B88", VA = "0x1A29B88", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601261F")]
		[Address(RVA = "0x1A29B9C", Offset = "0x1A29B9C", VA = "0x1A29B9C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002C24")]
	private sealed class _003CShowNormalConfirmPop_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010D9D")]
		[FieldOffset(Offset = "0x8")]
		internal RoomParams param;

		[Token(Token = "0x4010D9E")]
		[FieldOffset(Offset = "0xC")]
		internal UIWorkshopCreateRoomController _0024this;

		[Token(Token = "0x6012620")]
		[Address(RVA = "0x1A298F8", Offset = "0x1A298F8", VA = "0x1A298F8")]
		public _003CShowNormalConfirmPop_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6012621")]
		[Address(RVA = "0x1A29C24", Offset = "0x1A29C24", VA = "0x1A29C24")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010D80")]
	[FieldOffset(Offset = "0x48")]
	protected UIWorkshopCreateRoomView m_View;

	[Token(Token = "0x4010D81")]
	[FieldOffset(Offset = "0x4C")]
	protected UIModelCustomRoom m_CustomRoomModel;

	[Token(Token = "0x4010D82")]
	[FieldOffset(Offset = "0x50")]
	protected UIModelSceneEdit m_SceneEditModel;

	[Token(Token = "0x4010D83")]
	[FieldOffset(Offset = "0x54")]
	protected uint m_MapConfigId;

	[Token(Token = "0x4010D84")]
	[FieldOffset(Offset = "0x58")]
	protected string m_Name;

	[Token(Token = "0x4010D85")]
	[FieldOffset(Offset = "0x5C")]
	protected string m_Code;

	[Token(Token = "0x4010D86")]
	[FieldOffset(Offset = "0x60")]
	protected uint m_MemberNum;

	[Token(Token = "0x4010D87")]
	[FieldOffset(Offset = "0x64")]
	protected uint m_RoomSetting;

	[Token(Token = "0x4010D88")]
	[FieldOffset(Offset = "0x68")]
	protected uint m_RoomSetting2;

	[Token(Token = "0x4010D89")]
	[FieldOffset(Offset = "0x6C")]
	protected UIStandardTabController m_TabCtrl;

	[Token(Token = "0x4010D8A")]
	[FieldOffset(Offset = "0x70")]
	protected UIRoomCardListController m_RoomCardCtrl;

	[Token(Token = "0x4010D8B")]
	[FieldOffset(Offset = "0x74")]
	protected UIPopMenuSmallControler m_SelectWorkshopCtrl;

	[Token(Token = "0x4010D8C")]
	[FieldOffset(Offset = "0x78")]
	protected UIWorkshopCreateRoomSettingCSAdController m_CSAdController;

	[Token(Token = "0x4010D8D")]
	[FieldOffset(Offset = "0x7C")]
	protected UIWorkShopMapInfoDetailController m_WorkshopMapInfoCtrl;

	[Token(Token = "0x4010D8E")]
	[FieldOffset(Offset = "0x80")]
	protected uint m_RoomType;

	[Token(Token = "0x4010D8F")]
	[FieldOffset(Offset = "0x84")]
	protected bool m_IsDetermined;

	[Token(Token = "0x4010D90")]
	protected const int ROOM_CODE_MAX_LENGTH = 10;

	[Token(Token = "0x4010D91")]
	[FieldOffset(Offset = "0x88")]
	protected List<PopMenuData> m_PopMenuData;

	[Token(Token = "0x4010D92")]
	[FieldOffset(Offset = "0x8C")]
	protected SceneEditSlotInfo m_CurWorkShopInfo;

	[Token(Token = "0x4010D93")]
	[FieldOffset(Offset = "0x90")]
	private UIModelSceneEdit.EWorkShopCreateRoomSrc m_CurrentSrc;

	[Token(Token = "0x4010D94")]
	[FieldOffset(Offset = "0x94")]
	private int m_CurrentSrcIndex;

	[Token(Token = "0x4010D95")]
	[FieldOffset(Offset = "0x98")]
	private bool m_NeedDefaultSelect;

	[Token(Token = "0x4010D96")]
	[FieldOffset(Offset = "0x9C")]
	private EUGCScene m_UGCScene;

	[Token(Token = "0x4010D97")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<int, int> m_RoomSrcIndexDic;

	[Token(Token = "0x4010D98")]
	[FieldOffset(Offset = "0x0")]
	private static Action<string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60125EB")]
	[Address(RVA = "0x1A2205C", Offset = "0x1A2205C", VA = "0x1A2205C")]
	public UIWorkshopCreateRoomController()
	{
	}

	[Token(Token = "0x60125EC")]
	[Address(RVA = "0x1A22124", Offset = "0x1A22124", VA = "0x1A22124")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60125ED")]
	[Address(RVA = "0x1A221CC", Offset = "0x1A221CC", VA = "0x1A221CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60125EE")]
	[Address(RVA = "0x1A23898", Offset = "0x1A23898", VA = "0x1A23898", Slot = "50")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x60125EF")]
	[Address(RVA = "0x1A23B38", Offset = "0x1A23B38", VA = "0x1A23B38", Slot = "51")]
	protected virtual void SetDefaultUI()
	{
	}

	[Token(Token = "0x60125F0")]
	[Address(RVA = "0x1A24BA8", Offset = "0x1A24BA8", VA = "0x1A24BA8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60125F1")]
	[Address(RVA = "0x1A23434", Offset = "0x1A23434", VA = "0x1A23434")]
	private void InitStandardTabs()
	{
	}

	[Token(Token = "0x60125F2")]
	[Address(RVA = "0x1A23980", Offset = "0x1A23980", VA = "0x1A23980")]
	private void InitDefaultGameSettings()
	{
	}

	[Token(Token = "0x60125F3")]
	[Address(RVA = "0x1A22E0C", Offset = "0x1A22E0C", VA = "0x1A22E0C")]
	private void RefreshRoomCard()
	{
	}

	[Token(Token = "0x60125F4")]
	[Address(RVA = "0x1A231C8", Offset = "0x1A231C8", VA = "0x1A231C8")]
	private void InitPopMenus()
	{
	}

	[Token(Token = "0x60125F5")]
	[Address(RVA = "0x1A23CD0", Offset = "0x1A23CD0", VA = "0x1A23CD0")]
	private void GenerateWorkshopMenuData()
	{
	}

	[Token(Token = "0x60125F6")]
	[Address(RVA = "0x1A24708", Offset = "0x1A24708", VA = "0x1A24708")]
	protected void OnSrcTypeSelected(object obj)
	{
	}

	[Token(Token = "0x60125F7")]
	[Address(RVA = "0x1A24E10", Offset = "0x1A24E10", VA = "0x1A24E10")]
	private void RefreshConfirmBtn()
	{
	}

	[Token(Token = "0x60125F8")]
	[Address(RVA = "0x1A24F84", Offset = "0x1A24F84", VA = "0x1A24F84")]
	private EInventory.ItemSubType GetCurrentRoomCardType()
	{
		return default(EInventory.ItemSubType);
	}

	[Token(Token = "0x60125F9")]
	[Address(RVA = "0x1A25120", Offset = "0x1A25120", VA = "0x1A25120")]
	private bool RoomTypeRelatedCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60125FA")]
	[Address(RVA = "0x1A25424", Offset = "0x1A25424", VA = "0x1A25424", Slot = "52")]
	protected virtual void CalMapConfig()
	{
	}

	[Token(Token = "0x60125FB")]
	[Address(RVA = "0x1A254A4", Offset = "0x1A254A4", VA = "0x1A254A4")]
	protected uint CalWorkshopMap()
	{
		return default(uint);
	}

	[Token(Token = "0x60125FC")]
	[Address(RVA = "0x1A2551C", Offset = "0x1A2551C", VA = "0x1A2551C")]
	protected uint CalWorkshopGameMode()
	{
		return default(uint);
	}

	[Token(Token = "0x60125FD")]
	[Address(RVA = "0x1A25594", Offset = "0x1A25594", VA = "0x1A25594")]
	private void RefreshMapInfo()
	{
	}

	[Token(Token = "0x60125FE")]
	[Address(RVA = "0x1A25B20", Offset = "0x1A25B20", VA = "0x1A25B20")]
	private void OnRoomSettingClick()
	{
	}

	[Token(Token = "0x60125FF")]
	[Address(RVA = "0x1A25CEC", Offset = "0x1A25CEC", VA = "0x1A25CEC")]
	private void OnCSAdSettingClick()
	{
	}

	[Token(Token = "0x6012600")]
	[Address(RVA = "0x1A25C10", Offset = "0x1A25C10", VA = "0x1A25C10")]
	private void RepositionAllSettings()
	{
	}

	[Token(Token = "0x6012601")]
	[Address(RVA = "0x1A261A4", Offset = "0x1A261A4", VA = "0x1A261A4")]
	private void SetGameModeSpecificUI()
	{
	}

	[Token(Token = "0x6012602")]
	[Address(RVA = "0x1A25E84", Offset = "0x1A25E84", VA = "0x1A25E84")]
	private void UpdateBtnGrid(object[] data)
	{
	}

	[Token(Token = "0x6012603")]
	[Address(RVA = "0x1A26484", Offset = "0x1A26484", VA = "0x1A26484")]
	public void SetWorkShopViewData(SceneEditSlotInfo info, EUGCScene scene)
	{
	}

	[Token(Token = "0x6012604")]
	[Address(RVA = "0x1A26658", Offset = "0x1A26658", VA = "0x1A26658")]
	public void SetUGCScene(EUGCScene scene)
	{
	}

	[Token(Token = "0x6012605")]
	[Address(RVA = "0x1A24C88", Offset = "0x1A24C88", VA = "0x1A24C88")]
	private void OnWorkshopSelected(object[] data)
	{
	}

	[Token(Token = "0x6012606")]
	[Address(RVA = "0x1A25E10", Offset = "0x1A25E10", VA = "0x1A25E10")]
	protected bool IsCSMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6012607")]
	[Address(RVA = "0x1A266B8", Offset = "0x1A266B8", VA = "0x1A266B8")]
	protected void OnBtnConfirm()
	{
	}

	[Token(Token = "0x6012608")]
	[Address(RVA = "0x1A27984", Offset = "0x1A27984", VA = "0x1A27984")]
	private void ShowNormalConfirmPop()
	{
	}

	[Token(Token = "0x6012609")]
	[Address(RVA = "0x1A28038", Offset = "0x1A28038", VA = "0x1A28038")]
	private void CheckAndRecordSelect()
	{
	}

	[Token(Token = "0x601260A")]
	[Address(RVA = "0x1A280CC", Offset = "0x1A280CC", VA = "0x1A280CC")]
	private void CloseUI(object[] data)
	{
	}

	[Token(Token = "0x601260B")]
	[Address(RVA = "0x1A28138", Offset = "0x1A28138", VA = "0x1A28138")]
	private void OnBtnRefresh()
	{
	}

	[Token(Token = "0x601260C")]
	[Address(RVA = "0x1A28248", Offset = "0x1A28248", VA = "0x1A28248")]
	private IEnumerator ResetRefreshBtn()
	{
		return null;
	}

	[Token(Token = "0x601260D")]
	[Address(RVA = "0x1A2831C", Offset = "0x1A2831C", VA = "0x1A2831C")]
	private void OnBtnFullPreview()
	{
	}

	[Token(Token = "0x601260E")]
	[Address(RVA = "0x1A2865C", Offset = "0x1A2865C", VA = "0x1A2865C")]
	private void OnBtnAuthor()
	{
	}

	[Token(Token = "0x601260F")]
	[Address(RVA = "0x1A286B0", Offset = "0x1A286B0", VA = "0x1A286B0")]
	private void OnBtnClose()
	{
	}

	[Token(Token = "0x6012610")]
	[Address(RVA = "0x1A28714", Offset = "0x1A28714", VA = "0x1A28714")]
	private void OnBtnReset()
	{
	}

	[Token(Token = "0x6012611")]
	[Address(RVA = "0x1A28938", Offset = "0x1A28938", VA = "0x1A28938", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012612")]
	[Address(RVA = "0x1A28D54", Offset = "0x1A28D54", VA = "0x1A28D54", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012613")]
	[Address(RVA = "0x1A28E0C", Offset = "0x1A28E0C", VA = "0x1A28E0C", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6012614")]
	[Address(RVA = "0x1A28F04", Offset = "0x1A28F04", VA = "0x1A28F04", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6012615")]
	[Address(RVA = "0x1A28F80", Offset = "0x1A28F80", VA = "0x1A28F80")]
	private static void _003COnBtnConfirm_003Em__0(string s)
	{
	}

	[Token(Token = "0x6012616")]
	[Address(RVA = "0x1A291C8", Offset = "0x1A291C8", VA = "0x1A291C8")]
	private void _003CShowNormalConfirmPop_003Em__1()
	{
	}

	[Token(Token = "0x6012617")]
	[Address(RVA = "0x1A29900", Offset = "0x1A29900", VA = "0x1A29900")]
	private void _003COnBtnReset_003Em__2()
	{
	}

	[Token(Token = "0x6012618")]
	[Address(RVA = "0x1A29A44", Offset = "0x1A29A44", VA = "0x1A29A44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012619")]
	[Address(RVA = "0x1A29A4C", Offset = "0x1A29A4C", VA = "0x1A29A4C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
