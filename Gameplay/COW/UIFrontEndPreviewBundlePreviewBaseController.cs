using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CA2")]
public abstract class UIFrontEndPreviewBundlePreviewBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewBundlePreviewBaseView>, _Attribute
{
	[Token(Token = "0x40110A5")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_PreviewScrollViewOriginalPos;

	[Token(Token = "0x40110A6")]
	[FieldOffset(Offset = "0x44")]
	private Vector4 m_PreviewScrollViewBaseClipRegion;

	[Token(Token = "0x6012A81")]
	[Address(RVA = "0x27E0528", Offset = "0x27E0528", VA = "0x27E0528")]
	protected UIFrontEndPreviewBundlePreviewBaseController()
	{
	}

	[Token(Token = "0x6012A82")]
	[Address(RVA = "0x27E058C", Offset = "0x27E058C", VA = "0x27E058C", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012A83")]
	[Address(RVA = "0x27E070C", Offset = "0x27E070C", VA = "0x27E070C", Slot = "38")]
	public virtual void OnSetOriginal()
	{
	}

	[Token(Token = "0x6012A84")]
	[Address(RVA = "0x27E0778", Offset = "0x27E0778", VA = "0x27E0778", Slot = "39")]
	public virtual void OnCloseUIExceptMagn()
	{
	}

	[Token(Token = "0x6012A85")]
	[Address(RVA = "0x27E07E4", Offset = "0x27E07E4", VA = "0x27E07E4", Slot = "40")]
	public virtual void OnCloseAllUI()
	{
	}

	[Token(Token = "0x6012A86")]
	[Address(RVA = "0x27E0850", Offset = "0x27E0850", VA = "0x27E0850", Slot = "41")]
	public virtual void RefreshCratePreviewTab(List<BaseItemInfo> list)
	{
	}

	[Token(Token = "0x6012A87")]
	public virtual void RefreshViewData<DataType>(List<DataType> dataList, bool needResort = true)
	{
	}

	[Token(Token = "0x6012A88")]
	[Address(RVA = "0x27E09A4", Offset = "0x27E09A4", VA = "0x27E09A4")]
	public void RefreshBundlePreviewTab(CSSharedItemDataManager.ItemType type)
	{
	}

	[Token(Token = "0x6012A89")]
	[Address(RVA = "0x27E0D00", Offset = "0x27E0D00", VA = "0x27E0D00", Slot = "43")]
	public virtual void RefreshBundleTitle(bool showBundleTitle)
	{
	}

	[Token(Token = "0x6012A8A")]
	[Address(RVA = "0x27E0F14", Offset = "0x27E0F14", VA = "0x27E0F14", Slot = "44")]
	public virtual void ReRearrangePreviewTab()
	{
	}

	[Token(Token = "0x6012A8B")]
	[Address(RVA = "0x27E0FA4", Offset = "0x27E0FA4", VA = "0x27E0FA4", Slot = "45")]
	public virtual void ResetPreviewScrollViewBaseClipRegion()
	{
	}

	[Token(Token = "0x6012A8C")]
	[Address(RVA = "0x27E1468", Offset = "0x27E1468", VA = "0x27E1468", Slot = "33")]
	protected override void OnSetFrontEndPreviewUIConfigData()
	{
	}

	[Token(Token = "0x6012A8D")]
	[Address(RVA = "0x27E14D4", Offset = "0x27E14D4", VA = "0x27E14D4", Slot = "46")]
	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6012A8E")]
	[Address(RVA = "0x27E16BC", Offset = "0x27E16BC", VA = "0x27E16BC", Slot = "47")]
	public virtual void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6012A8F")]
	[Address(RVA = "0x27E1738", Offset = "0x27E1738", VA = "0x27E1738")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	[Token(Token = "0x6012A90")]
	[Address(RVA = "0x27E1740", Offset = "0x27E1740", VA = "0x27E1740")]
	public void _003C_003EiFixBaseProxy_OnSetFrontEndPreviewUIConfigData()
	{
	}
}
