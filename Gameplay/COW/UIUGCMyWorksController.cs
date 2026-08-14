using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002BA6")]
public class UIUGCMyWorksController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x2002BA7")]
	private sealed class _003COnBtnDelClick_003Ec__AnonStorey3
	{
		[Token(Token = "0x4010B0B")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCDeleteFileSelectController ctrl;

		[Token(Token = "0x4010B0C")]
		[FieldOffset(Offset = "0xC")]
		internal UIUGCMyWorksController _0024this;

		[Token(Token = "0x60120C8")]
		[Address(RVA = "0x27823B4", Offset = "0x27823B4", VA = "0x27823B4")]
		public _003COnBtnDelClick_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60120C9")]
		[Address(RVA = "0x278876C", Offset = "0x278876C", VA = "0x278876C")]
		internal void _003C_003Em__0(bool b)
		{
		}

		[Token(Token = "0x60120CA")]
		[Address(RVA = "0x2788824", Offset = "0x2788824", VA = "0x2788824")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2002BA8")]
	private sealed class _003CRequestDelPop_003Ec__AnonStorey4
	{
		[Token(Token = "0x4010B0D")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelSceneEdit.EWorkshopDelType type;

		[Token(Token = "0x4010B0E")]
		[FieldOffset(Offset = "0xC")]
		internal Action callback;

		[Token(Token = "0x4010B0F")]
		[FieldOffset(Offset = "0x10")]
		internal UIUGCMyWorksController _0024this;

		[Token(Token = "0x60120CB")]
		[Address(RVA = "0x27823BC", Offset = "0x27823BC", VA = "0x27823BC")]
		public _003CRequestDelPop_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60120CC")]
		[Address(RVA = "0x2788B9C", Offset = "0x2788B9C", VA = "0x2788B9C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BA9")]
	private sealed class _003CShowFreeRoomCardShareGuide_003Ec__AnonStorey5
	{
		[Token(Token = "0x4010B10")]
		[FieldOffset(Offset = "0x8")]
		internal string shareKey;

		[Token(Token = "0x60120CD")]
		[Address(RVA = "0x2785394", Offset = "0x2785394", VA = "0x2785394")]
		public _003CShowFreeRoomCardShareGuide_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60120CE")]
		[Address(RVA = "0x2788C34", Offset = "0x2788C34", VA = "0x2788C34")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BAA")]
	private sealed class _003COnUploadFinished_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010B11")]
		[FieldOffset(Offset = "0x8")]
		internal uint slotId;

		[Token(Token = "0x4010B12")]
		[FieldOffset(Offset = "0xC")]
		internal SceneEditSlotInfo _003Cinfo_003E__0;

		[Token(Token = "0x4010B13")]
		[FieldOffset(Offset = "0x10")]
		internal UIUGCMyWorksController _0024this;

		[Token(Token = "0x4010B14")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4010B15")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x4010B16")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x170012F3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60120D1")]
			[Address(RVA = "0x2788AF0", Offset = "0x2788AF0", VA = "0x2788AF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012F4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60120D2")]
			[Address(RVA = "0x2788AF8", Offset = "0x2788AF8", VA = "0x2788AF8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60120CF")]
		[Address(RVA = "0x2787C58", Offset = "0x2787C58", VA = "0x2787C58")]
		public _003COnUploadFinished_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60120D0")]
		[Address(RVA = "0x2788850", Offset = "0x2788850", VA = "0x2788850", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60120D3")]
		[Address(RVA = "0x2788B00", Offset = "0x2788B00", VA = "0x2788B00", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60120D4")]
		[Address(RVA = "0x2788B14", Offset = "0x2788B14", VA = "0x2788B14", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002BAB")]
	private sealed class _003CCheckLastCDNDownloadFailed_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010B17")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCMyWorksController _0024this;

		[Token(Token = "0x4010B18")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010B19")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010B1A")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012F5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60120D7")]
			[Address(RVA = "0x27884C0", Offset = "0x27884C0", VA = "0x27884C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012F6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60120D8")]
			[Address(RVA = "0x27884C8", Offset = "0x27884C8", VA = "0x27884C8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60120D5")]
		[Address(RVA = "0x2787C60", Offset = "0x2787C60", VA = "0x2787C60")]
		public _003CCheckLastCDNDownloadFailed_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x60120D6")]
		[Address(RVA = "0x2788248", Offset = "0x2788248", VA = "0x2788248", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60120D9")]
		[Address(RVA = "0x27884D0", Offset = "0x27884D0", VA = "0x27884D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60120DA")]
		[Address(RVA = "0x27884E4", Offset = "0x27884E4", VA = "0x27884E4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002BAC")]
	private sealed class _003CCheckLastEditedSlotId_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010B1B")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCMyWorksController _0024this;

		[Token(Token = "0x4010B1C")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010B1D")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010B1E")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012F7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60120DD")]
			[Address(RVA = "0x27886C0", Offset = "0x27886C0", VA = "0x27886C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012F8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60120DE")]
			[Address(RVA = "0x27886C8", Offset = "0x27886C8", VA = "0x27886C8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60120DB")]
		[Address(RVA = "0x2787C68", Offset = "0x2787C68", VA = "0x2787C68")]
		public _003CCheckLastEditedSlotId_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x60120DC")]
		[Address(RVA = "0x278856C", Offset = "0x278856C", VA = "0x278856C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60120DF")]
		[Address(RVA = "0x27886D0", Offset = "0x27886D0", VA = "0x27886D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60120E0")]
		[Address(RVA = "0x27886E4", Offset = "0x27886E4", VA = "0x27886E4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010AFE")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCMyWorksView m_View;

	[Token(Token = "0x4010AFF")]
	[FieldOffset(Offset = "0x2C")]
	private UIPopMenuSmallControler m_PopMenuSmallControler;

	[Token(Token = "0x4010B00")]
	[FieldOffset(Offset = "0x30")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x4010B01")]
	[FieldOffset(Offset = "0x34")]
	private SceneEditSlotInfo m_CurSlotInfo;

	[Token(Token = "0x4010B02")]
	[FieldOffset(Offset = "0x38")]
	private EWorkshop.SlotType m_CurSlotType;

	[Token(Token = "0x4010B03")]
	[FieldOffset(Offset = "0x3C")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x4010B04")]
	[FieldOffset(Offset = "0x40")]
	private Color m_LockColor;

	[Token(Token = "0x4010B05")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsNameSwitchOpen;

	[Token(Token = "0x4010B06")]
	[FieldOffset(Offset = "0x51")]
	private bool m_IsDescSwitchOpen;

	[Token(Token = "0x4010B07")]
	[FieldOffset(Offset = "0x52")]
	private bool m_ClassicSlotInited;

	[Token(Token = "0x4010B08")]
	[FieldOffset(Offset = "0x53")]
	private bool m_IsFE;

	[Token(Token = "0x4010B09")]
	[FieldOffset(Offset = "0x54")]
	private string m_DefaultSignature;

	[Token(Token = "0x4010B0A")]
	[FieldOffset(Offset = "0x58")]
	private List<PopMenuData> m_PopMenuDataList;

	[Token(Token = "0x601209B")]
	[Address(RVA = "0x277C0C8", Offset = "0x277C0C8", VA = "0x277C0C8")]
	public UIUGCMyWorksController()
	{
	}

	[Token(Token = "0x601209C")]
	[Address(RVA = "0x277C188", Offset = "0x277C188", VA = "0x277C188")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601209D")]
	[Address(RVA = "0x277C230", Offset = "0x277C230", VA = "0x277C230", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601209E")]
	[Address(RVA = "0x277D37C", Offset = "0x277D37C", VA = "0x277D37C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x601209F")]
	[Address(RVA = "0x277D5FC", Offset = "0x277D5FC", VA = "0x277D5FC")]
	private List<PopMenuData> GeneratePopMenuData()
	{
		return null;
	}

	[Token(Token = "0x60120A0")]
	[Address(RVA = "0x277DA10", Offset = "0x277DA10", VA = "0x277DA10")]
	private void OnGetFocus()
	{
	}

	[Token(Token = "0x60120A1")]
	[Address(RVA = "0x277DBB4", Offset = "0x277DBB4", VA = "0x277DBB4")]
	private void OnLostFocus()
	{
	}

	[Token(Token = "0x60120A2")]
	[Address(RVA = "0x277E098", Offset = "0x277E098", VA = "0x277E098")]
	private void OnBtnCreateRoomClick()
	{
	}

	[Token(Token = "0x60120A3")]
	[Address(RVA = "0x277E6CC", Offset = "0x277E6CC", VA = "0x277E6CC")]
	private void OnBtnPublishClick()
	{
	}

	[Token(Token = "0x60120A4")]
	[Address(RVA = "0x277F2C0", Offset = "0x277F2C0", VA = "0x277F2C0")]
	private void OnBtnEditClick()
	{
	}

	[Token(Token = "0x60120A5")]
	[Address(RVA = "0x277FB10", Offset = "0x277FB10", VA = "0x277FB10")]
	private void OnConfirmUserAgreement(object[] data)
	{
	}

	[Token(Token = "0x60120A6")]
	[Address(RVA = "0x277FB78", Offset = "0x277FB78", VA = "0x277FB78")]
	private void OnBtnNewClick()
	{
	}

	[Token(Token = "0x60120A7")]
	[Address(RVA = "0x277FDFC", Offset = "0x277FDFC", VA = "0x277FDFC")]
	private void OnBtnChangeSlotNameClick()
	{
	}

	[Token(Token = "0x60120A8")]
	[Address(RVA = "0x27800AC", Offset = "0x27800AC", VA = "0x27800AC")]
	private void OnBtnShareClick()
	{
	}

	[Token(Token = "0x60120A9")]
	[Address(RVA = "0x27807EC", Offset = "0x27807EC", VA = "0x27807EC")]
	private void OnBtnMoreClick()
	{
	}

	[Token(Token = "0x60120AA")]
	[Address(RVA = "0x2780938", Offset = "0x2780938", VA = "0x2780938")]
	private void OnBtnCopyClick()
	{
	}

	[Token(Token = "0x60120AB")]
	[Address(RVA = "0x2780CFC", Offset = "0x2780CFC", VA = "0x2780CFC")]
	private void OnBtnSaveAsClick()
	{
	}

	[Token(Token = "0x60120AC")]
	[Address(RVA = "0x27810FC", Offset = "0x27810FC", VA = "0x27810FC")]
	private void OnBtnDetailClick()
	{
	}

	[Token(Token = "0x60120AD")]
	[Address(RVA = "0x2781720", Offset = "0x2781720", VA = "0x2781720")]
	private void OnBtnUnPublishClick()
	{
	}

	[Token(Token = "0x60120AE")]
	[Address(RVA = "0x2781C30", Offset = "0x2781C30", VA = "0x2781C30")]
	private void OnBtnDelClick()
	{
	}

	[Token(Token = "0x60120AF")]
	[Address(RVA = "0x2782064", Offset = "0x2782064", VA = "0x2782064")]
	private void RequestDelPop(UIModelSceneEdit.EWorkshopDelType type, [Optional] Action callback)
	{
	}

	[Token(Token = "0x60120B0")]
	[Address(RVA = "0x277E5A8", Offset = "0x277E5A8", VA = "0x277E5A8")]
	private bool CheckOptionalDownload()
	{
		return default(bool);
	}

	[Token(Token = "0x60120B1")]
	[Address(RVA = "0x27823C4", Offset = "0x27823C4", VA = "0x27823C4")]
	private void OnSlotTypeSelected(object obj)
	{
	}

	[Token(Token = "0x60120B2")]
	[Address(RVA = "0x2782598", Offset = "0x2782598", VA = "0x2782598")]
	private void OnSlotItemSelected(object[] data)
	{
	}

	[Token(Token = "0x60120B3")]
	[Address(RVA = "0x2784E48", Offset = "0x2784E48", VA = "0x2784E48")]
	private void ShowFreeRoomCardShareGuide()
	{
	}

	[Token(Token = "0x60120B4")]
	[Address(RVA = "0x278271C", Offset = "0x278271C", VA = "0x278271C")]
	private void RefreshSlotInfo()
	{
	}

	[Token(Token = "0x60120B5")]
	[Address(RVA = "0x278539C", Offset = "0x278539C", VA = "0x278539C")]
	private void RefreshBottomBtns()
	{
	}

	[Token(Token = "0x60120B6")]
	[Address(RVA = "0x27861D4", Offset = "0x27861D4", VA = "0x27861D4")]
	private void RefreshTopBtns()
	{
	}

	[Token(Token = "0x60120B7")]
	[Address(RVA = "0x2786880", Offset = "0x2786880", VA = "0x2786880", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60120B8")]
	[Address(RVA = "0x2786918", Offset = "0x2786918", VA = "0x2786918", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60120B9")]
	[Address(RVA = "0x2787584", Offset = "0x2787584", VA = "0x2787584")]
	private void HideClassicSlot()
	{
	}

	[Token(Token = "0x60120BA")]
	[Address(RVA = "0x2787084", Offset = "0x2787084", VA = "0x2787084")]
	private void ReSelectItem(int index)
	{
	}

	[Token(Token = "0x60120BB")]
	[Address(RVA = "0x2787300", Offset = "0x2787300", VA = "0x2787300")]
	private IEnumerator OnUploadFinished(uint slotId)
	{
		return null;
	}

	[Token(Token = "0x60120BC")]
	[Address(RVA = "0x277D530", Offset = "0x277D530", VA = "0x277D530")]
	private IEnumerator CheckLastCDNDownloadFailed()
	{
		return null;
	}

	[Token(Token = "0x60120BD")]
	[Address(RVA = "0x277D464", Offset = "0x277D464", VA = "0x277D464")]
	private IEnumerator CheckLastEditedSlotId()
	{
		return null;
	}

	[Token(Token = "0x60120BE")]
	[Address(RVA = "0x27873EC", Offset = "0x27873EC", VA = "0x27873EC")]
	private void OnDownloadFinished(uint slotId)
	{
	}

	[Token(Token = "0x60120BF")]
	[Address(RVA = "0x2787D00", Offset = "0x2787D00", VA = "0x2787D00", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60120C0")]
	[Address(RVA = "0x2787DF8", Offset = "0x2787DF8", VA = "0x2787DF8", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60120C1")]
	[Address(RVA = "0x2787E74", Offset = "0x2787E74", VA = "0x2787E74")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x60120C2")]
	[Address(RVA = "0x2787EB8", Offset = "0x2787EB8", VA = "0x2787EB8")]
	private void _003COnBtnPublishClick_003Em__1()
	{
	}

	[Token(Token = "0x60120C3")]
	[Address(RVA = "0x2787EF0", Offset = "0x2787EF0", VA = "0x2787EF0")]
	private void _003COnBtnEditClick_003Em__2(bool b)
	{
	}

	[Token(Token = "0x60120C4")]
	[Address(RVA = "0x27881B4", Offset = "0x27881B4", VA = "0x27881B4")]
	private void _003COnBtnUnPublishClick_003Em__3()
	{
	}

	[Token(Token = "0x60120C5")]
	[Address(RVA = "0x2788200", Offset = "0x2788200", VA = "0x2788200")]
	private void _003COnBtnEditClick_003Em__4()
	{
	}

	[Token(Token = "0x60120C6")]
	[Address(RVA = "0x2788238", Offset = "0x2788238", VA = "0x2788238")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60120C7")]
	[Address(RVA = "0x2788240", Offset = "0x2788240", VA = "0x2788240")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
