using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002346")]
public class UIHudSceneEditSlotManagerController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x2002347")]
	private sealed class _003COnUploadFinished_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DBCC")]
		[FieldOffset(Offset = "0x8")]
		internal uint slotId;

		[Token(Token = "0x400DBCD")]
		[FieldOffset(Offset = "0xC")]
		internal SceneEditSlotInfo _003Cinfo_003E__0;

		[Token(Token = "0x400DBCE")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudSceneEditSlotManagerController _0024this;

		[Token(Token = "0x400DBCF")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400DBD0")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400DBD1")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x170010C4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C47F")]
			[Address(RVA = "0x16B5828", Offset = "0x16B5828", VA = "0x16B5828", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010C5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C480")]
			[Address(RVA = "0x16B5830", Offset = "0x16B5830", VA = "0x16B5830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C47D")]
		[Address(RVA = "0x16B04BC", Offset = "0x16B04BC", VA = "0x16B04BC")]
		public _003COnUploadFinished_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C47E")]
		[Address(RVA = "0x16B5614", Offset = "0x16B5614", VA = "0x16B5614", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C481")]
		[Address(RVA = "0x16B5838", Offset = "0x16B5838", VA = "0x16B5838", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C482")]
		[Address(RVA = "0x16B584C", Offset = "0x16B584C", VA = "0x16B584C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DBC3")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSceneEditSlotManagerView m_View;

	[Token(Token = "0x400DBC4")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x400DBC5")]
	[FieldOffset(Offset = "0x50")]
	private EWorkshop.SlotType m_CurrentSlotType;

	[Token(Token = "0x400DBC6")]
	[FieldOffset(Offset = "0x54")]
	private int m_CurrentSlotIndex;

	[Token(Token = "0x400DBC7")]
	[FieldOffset(Offset = "0x58")]
	private string m_DefaultDesc;

	[Token(Token = "0x400DBC8")]
	[FieldOffset(Offset = "0x5C")]
	private string m_DefaultSlotName;

	[Token(Token = "0x400DBC9")]
	[FieldOffset(Offset = "0x60")]
	private Color m_LockColor;

	[Token(Token = "0x400DBCA")]
	[FieldOffset(Offset = "0x70")]
	private SwitchDesc m_NameSwitch;

	[Token(Token = "0x400DBCB")]
	[FieldOffset(Offset = "0x74")]
	private SwitchDesc m_DescSwitch;

	[Token(Token = "0x600C457")]
	[Address(RVA = "0x16ADDD4", Offset = "0x16ADDD4", VA = "0x16ADDD4")]
	public UIHudSceneEditSlotManagerController()
	{
	}

	[Token(Token = "0x600C458")]
	[Address(RVA = "0x16ADDDC", Offset = "0x16ADDDC", VA = "0x16ADDDC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C459")]
	[Address(RVA = "0x16ADE80", Offset = "0x16ADE80", VA = "0x16ADE80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C45A")]
	[Address(RVA = "0x16AF19C", Offset = "0x16AF19C", VA = "0x16AF19C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C45B")]
	[Address(RVA = "0x16AF3D8", Offset = "0x16AF3D8", VA = "0x16AF3D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600C45C")]
	[Address(RVA = "0x16AF5E8", Offset = "0x16AF5E8", VA = "0x16AF5E8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C45D")]
	[Address(RVA = "0x16B01E0", Offset = "0x16B01E0", VA = "0x16B01E0")]
	public void RefreshLeftScrollInfo()
	{
	}

	[Token(Token = "0x600C45E")]
	[Address(RVA = "0x16B0428", Offset = "0x16B0428", VA = "0x16B0428", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C45F")]
	[Address(RVA = "0x16AFC20", Offset = "0x16AFC20", VA = "0x16AFC20")]
	private void ReSelectItem()
	{
	}

	[Token(Token = "0x600C460")]
	[Address(RVA = "0x16AFD90", Offset = "0x16AFD90", VA = "0x16AFD90")]
	private IEnumerator OnUploadFinished(uint slotId)
	{
		return null;
	}

	[Token(Token = "0x600C461")]
	[Address(RVA = "0x16AFE7C", Offset = "0x16AFE7C", VA = "0x16AFE7C")]
	private void OnDownloadFinished(uint slotId)
	{
	}

	[Token(Token = "0x600C462")]
	[Address(RVA = "0x16B0018", Offset = "0x16B0018", VA = "0x16B0018")]
	private void OnShareFinished(int slotIndex)
	{
	}

	[Token(Token = "0x600C463")]
	[Address(RVA = "0x16B04C4", Offset = "0x16B04C4", VA = "0x16B04C4")]
	private void OnLostFocus()
	{
	}

	[Token(Token = "0x600C464")]
	[Address(RVA = "0x16B085C", Offset = "0x16B085C", VA = "0x16B085C")]
	private void OnClickUploadBtn()
	{
	}

	[Token(Token = "0x600C465")]
	[Address(RVA = "0x16B0F30", Offset = "0x16B0F30", VA = "0x16B0F30")]
	private void OnClickApplyBtn()
	{
	}

	[Token(Token = "0x600C466")]
	[Address(RVA = "0x16B1570", Offset = "0x16B1570", VA = "0x16B1570")]
	private void OnClickShareBtn()
	{
	}

	[Token(Token = "0x600C467")]
	[Address(RVA = "0x16B1AD0", Offset = "0x16B1AD0", VA = "0x16B1AD0")]
	private void OnClickChangeSlotNameBtn()
	{
	}

	[Token(Token = "0x600C468")]
	[Address(RVA = "0x16B1D84", Offset = "0x16B1D84", VA = "0x16B1D84")]
	private void OnClickDelBtn()
	{
	}

	[Token(Token = "0x600C469")]
	[Address(RVA = "0x16B2080", Offset = "0x16B2080", VA = "0x16B2080")]
	private void OnClickCopyBtn()
	{
	}

	[Token(Token = "0x600C46A")]
	[Address(RVA = "0x16B22E8", Offset = "0x16B22E8", VA = "0x16B22E8")]
	private void OnClickPreviewBtn()
	{
	}

	[Token(Token = "0x600C46B")]
	[Address(RVA = "0x16B267C", Offset = "0x16B267C", VA = "0x16B267C")]
	private void OnTipsGoToClick()
	{
	}

	[Token(Token = "0x600C46C")]
	[Address(RVA = "0x16B2714", Offset = "0x16B2714", VA = "0x16B2714")]
	private void OnBtnSearchClick()
	{
	}

	[Token(Token = "0x600C46D")]
	[Address(RVA = "0x16B2A88", Offset = "0x16B2A88", VA = "0x16B2A88")]
	private void OnSearchInputChanged()
	{
	}

	[Token(Token = "0x600C46E")]
	[Address(RVA = "0x16B2BE8", Offset = "0x16B2BE8", VA = "0x16B2BE8")]
	private void OnBtnClearClick()
	{
	}

	[Token(Token = "0x600C46F")]
	[Address(RVA = "0x16B2CF8", Offset = "0x16B2CF8", VA = "0x16B2CF8")]
	private void OnEditSlotClick()
	{
	}

	[Token(Token = "0x600C470")]
	[Address(RVA = "0x16B2E64", Offset = "0x16B2E64", VA = "0x16B2E64")]
	private void OnShareSlotClick()
	{
	}

	[Token(Token = "0x600C471")]
	[Address(RVA = "0x16B2FD0", Offset = "0x16B2FD0", VA = "0x16B2FD0")]
	private void OnSubscribeSlotClick()
	{
	}

	[Token(Token = "0x600C472")]
	[Address(RVA = "0x16B3144", Offset = "0x16B3144", VA = "0x16B3144")]
	private void OnClassicSlotClick()
	{
	}

	[Token(Token = "0x600C473")]
	[Address(RVA = "0x16B3600", Offset = "0x16B3600", VA = "0x16B3600")]
	private void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600C474")]
	[Address(RVA = "0x16B5220", Offset = "0x16B5220", VA = "0x16B5220")]
	private void OnEnterPreviewMode(object[] data)
	{
	}

	[Token(Token = "0x600C475")]
	[Address(RVA = "0x16B3C34", Offset = "0x16B3C34", VA = "0x16B3C34")]
	private void RefreshUIData(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x600C476")]
	[Address(RVA = "0x16B531C", Offset = "0x16B531C", VA = "0x16B531C")]
	private void OnHelpBtnClick()
	{
	}

	[Token(Token = "0x600C477")]
	[Address(RVA = "0x16B542C", Offset = "0x16B542C", VA = "0x16B542C")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600C478")]
	[Address(RVA = "0x16B5490", Offset = "0x16B5490", VA = "0x16B5490", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C479")]
	[Address(RVA = "0x16B5588", Offset = "0x16B5588", VA = "0x16B5588", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C47A")]
	[Address(RVA = "0x16AF438", Offset = "0x16AF438", VA = "0x16AF438")]
	private void TutorialUploadBtn()
	{
	}

	[Token(Token = "0x600C47B")]
	[Address(RVA = "0x16B5604", Offset = "0x16B5604", VA = "0x16B5604")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C47C")]
	[Address(RVA = "0x16B560C", Offset = "0x16B560C", VA = "0x16B560C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
