using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BB7")]
internal class UIUGCRecommendationPopController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002BB8")]
	public enum ERecommendationSrc
	{
		[Token(Token = "0x4010B4E")]
		EEditorMainRec,
		[Token(Token = "0x4010B4F")]
		EEditorSideRec,
		[Token(Token = "0x4010B50")]
		EHot,
		[Token(Token = "0x4010B51")]
		ESelfdom
	}

	[Token(Token = "0x2002BB9")]
	private sealed class _003CReposition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010B52")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCRecommendationPopController _0024this;

		[Token(Token = "0x4010B53")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010B54")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010B55")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012FF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012149")]
			[Address(RVA = "0xF36D7C", Offset = "0xF36D7C", VA = "0xF36D7C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001300")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601214A")]
			[Address(RVA = "0xF36D84", Offset = "0xF36D84", VA = "0xF36D84", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012147")]
		[Address(RVA = "0xF36BB8", Offset = "0xF36BB8", VA = "0xF36BB8")]
		public _003CReposition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6012148")]
		[Address(RVA = "0xF36BC0", Offset = "0xF36BC0", VA = "0xF36BC0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601214B")]
		[Address(RVA = "0xF36D8C", Offset = "0xF36D8C", VA = "0xF36D8C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601214C")]
		[Address(RVA = "0xF36DA0", Offset = "0xF36DA0", VA = "0xF36DA0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010B48")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCRecommendationPopView m_View;

	[Token(Token = "0x4010B49")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSceneEdit m_Model;

	[Token(Token = "0x4010B4A")]
	[FieldOffset(Offset = "0x50")]
	private ERecommendationSrc m_Src;

	[Token(Token = "0x4010B4B")]
	[FieldOffset(Offset = "0x54")]
	private List<UISceneEditRecommendMapItemController> m_CachedSelfdomMapItemList;

	[Token(Token = "0x4010B4C")]
	[FieldOffset(Offset = "0x58")]
	private List<UIUGCHotMapController> m_CachedHotMapItemList;

	[Token(Token = "0x6012136")]
	[Address(RVA = "0x2795D74", Offset = "0x2795D74", VA = "0x2795D74")]
	public UIUGCRecommendationPopController()
	{
	}

	[Token(Token = "0x6012137")]
	[Address(RVA = "0x2795E34", Offset = "0x2795E34", VA = "0x2795E34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012138")]
	[Address(RVA = "0x2795EDC", Offset = "0x2795EDC", VA = "0x2795EDC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012139")]
	[Address(RVA = "0x2794474", Offset = "0x2794474", VA = "0x2794474")]
	public void SetViewData(ERecommendationSrc src, WorkshopEditorChoiceDesc desc)
	{
	}

	[Token(Token = "0x601213A")]
	[Address(RVA = "0x27962C8", Offset = "0x27962C8", VA = "0x27962C8")]
	private void ProcessEditorChoiceRec(WorkshopEditorChoiceDesc desc)
	{
	}

	[Token(Token = "0x601213B")]
	[Address(RVA = "0x279663C", Offset = "0x279663C", VA = "0x279663C")]
	private void ProcessHot()
	{
	}

	[Token(Token = "0x601213C")]
	[Address(RVA = "0x27969BC", Offset = "0x27969BC", VA = "0x27969BC")]
	private void ProcessSelfdomRec()
	{
	}

	[Token(Token = "0x601213D")]
	[Address(RVA = "0x2796A38", Offset = "0x2796A38", VA = "0x2796A38")]
	private IEnumerator Reposition()
	{
		return null;
	}

	[Token(Token = "0x601213E")]
	[Address(RVA = "0x2796B04", Offset = "0x2796B04", VA = "0x2796B04")]
	private void OnBlackBGClick()
	{
	}

	[Token(Token = "0x601213F")]
	[Address(RVA = "0x2796B68", Offset = "0x2796B68", VA = "0x2796B68")]
	private void OnRecomRefreshBtnClick()
	{
	}

	[Token(Token = "0x6012140")]
	[Address(RVA = "0x2796C44", Offset = "0x2796C44", VA = "0x2796C44")]
	private void RefreshEditorChoiceItems(List<WorkshopEditorChoiceInfo> data)
	{
	}

	[Token(Token = "0x6012141")]
	[Address(RVA = "0x2796F94", Offset = "0x2796F94", VA = "0x2796F94")]
	private void RefreshSelfdomRecommendMapItems(List<WorkshopPersonalRecommendationInfo> mapDataList)
	{
	}

	[Token(Token = "0x6012142")]
	[Address(RVA = "0x2797320", Offset = "0x2797320", VA = "0x2797320", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012143")]
	[Address(RVA = "0x2797770", Offset = "0x2797770", VA = "0x2797770", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012144")]
	[Address(RVA = "0x2797804", Offset = "0x2797804", VA = "0x2797804")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6012145")]
	[Address(RVA = "0x2797848", Offset = "0x2797848", VA = "0x2797848")]
	private void _003CProcessEditorChoiceRec_003Em__1()
	{
	}

	[Token(Token = "0x6012146")]
	[Address(RVA = "0x2797928", Offset = "0x2797928", VA = "0x2797928")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
