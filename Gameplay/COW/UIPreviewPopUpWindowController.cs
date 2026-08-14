using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C78")]
public abstract class UIPreviewPopUpWindowController : UIPopupWindowController
{
	[Token(Token = "0x2002C79")]
	private sealed class _003CCreateDoublePreviewAvatar_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010FBB")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 avatar1Pos;

		[Token(Token = "0x4010FBC")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 avatar2Pos;

		[Token(Token = "0x4010FBD")]
		[FieldOffset(Offset = "0x20")]
		internal UIPreviewPopUpWindowController _0024this;

		[Token(Token = "0x60128FA")]
		[Address(RVA = "0xEFE4CC", Offset = "0xEFE4CC", VA = "0xEFE4CC")]
		public _003CCreateDoublePreviewAvatar_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60128FB")]
		[Address(RVA = "0xEFEC40", Offset = "0xEFEC40", VA = "0xEFEC40")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010FB6")]
	[FieldOffset(Offset = "0x48")]
	protected UIWidget m_FrontEndPreviewBorder;

	[Token(Token = "0x4010FB7")]
	[FieldOffset(Offset = "0x4C")]
	protected FrontEndPreviewConfigData m_FrontEndPreviewData;

	[Token(Token = "0x4010FB8")]
	[FieldOffset(Offset = "0x50")]
	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x4010FB9")]
	[FieldOffset(Offset = "0x54")]
	protected bool m_PreviewWndCovered;

	[Token(Token = "0x4010FBA")]
	[FieldOffset(Offset = "0x58")]
	protected FrontendPreviewType m_PreviewUIType;

	[Token(Token = "0x60128D1")]
	[Address(RVA = "0xEFCAA4", Offset = "0xEFCAA4", VA = "0xEFCAA4")]
	protected UIPreviewPopUpWindowController()
	{
	}

	[Token(Token = "0x60128D2")]
	protected abstract FrontendPreviewType GetPreviewUIType();

	[Token(Token = "0x60128D3")]
	protected abstract UIWidget GetFrontEndPreviewBorder();

	[Token(Token = "0x60128D4")]
	[Address(RVA = "0xEFCAAC", Offset = "0xEFCAAC", VA = "0xEFCAAC", Slot = "48")]
	protected virtual bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x60128D5")]
	[Address(RVA = "0xEFCB04", Offset = "0xEFCB04", VA = "0xEFCB04", Slot = "49")]
	protected virtual FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x60128D6")]
	[Address(RVA = "0xEFCBBC", Offset = "0xEFCBBC", VA = "0xEFCBBC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60128D7")]
	[Address(RVA = "0xEFCC20", Offset = "0xEFCC20", VA = "0xEFCC20", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60128D8")]
	[Address(RVA = "0xEFCC98", Offset = "0xEFCC98", VA = "0xEFCC98", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60128D9")]
	[Address(RVA = "0xEFCDD4", Offset = "0xEFCDD4", VA = "0xEFCDD4", Slot = "50")]
	protected virtual FrontEndPreviewConfigData GetFrontEndPreviewData()
	{
		return null;
	}

	[Token(Token = "0x60128DA")]
	[Address(RVA = "0xEFCF40", Offset = "0xEFCF40", VA = "0xEFCF40", Slot = "51")]
	protected virtual void OpenPreview()
	{
	}

	[Token(Token = "0x60128DB")]
	[Address(RVA = "0xEFD2F4", Offset = "0xEFD2F4", VA = "0xEFD2F4", Slot = "52")]
	protected virtual void ChangePreviewUIType(FrontendPreviewType type)
	{
	}

	[Token(Token = "0x60128DC")]
	[Address(RVA = "0xEFD41C", Offset = "0xEFD41C", VA = "0xEFD41C", Slot = "53")]
	protected virtual void OnChangePreviewUIType()
	{
	}

	[Token(Token = "0x60128DD")]
	[Address(RVA = "0xEFD470", Offset = "0xEFD470", VA = "0xEFD470", Slot = "54")]
	protected virtual void ClosePreview()
	{
	}

	[Token(Token = "0x60128DE")]
	[Address(RVA = "0xEFD598", Offset = "0xEFD598", VA = "0xEFD598")]
	public void TempHidePreview(bool keepUIContent = false, bool keep3DContent = false)
	{
	}

	[Token(Token = "0x60128DF")]
	[Address(RVA = "0xEFD644", Offset = "0xEFD644", VA = "0xEFD644", Slot = "55")]
	protected virtual void OnTempHidePreview()
	{
	}

	[Token(Token = "0x60128E0")]
	[Address(RVA = "0xEFD698", Offset = "0xEFD698", VA = "0xEFD698")]
	public void RecoverPreview()
	{
	}

	[Token(Token = "0x60128E1")]
	[Address(RVA = "0xEFD76C", Offset = "0xEFD76C", VA = "0xEFD76C", Slot = "56")]
	protected virtual void OnRecoverPreview()
	{
	}

	[Token(Token = "0x60128E2")]
	[Address(RVA = "0xEFD7C0", Offset = "0xEFD7C0", VA = "0xEFD7C0", Slot = "57")]
	public virtual void ShowPreviewByBaseItemInfo(BaseItemInfo baseItemInfo, bool isShowDesc = true, bool isShowOwned = true, [Optional] FullScreenAnimParams animdata, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needShowInstallmentInfo = false, bool needResetUI = true)
	{
	}

	[Token(Token = "0x60128E3")]
	[Address(RVA = "0xEFD990", Offset = "0xEFD990", VA = "0xEFD990", Slot = "58")]
	public virtual void ShowPreviewByBaseItemInfoAccodingToLastParams(BaseItemInfo baseItemInfo)
	{
	}

	[Token(Token = "0x60128E4")]
	[Address(RVA = "0xEFDAB8", Offset = "0xEFDAB8", VA = "0xEFDAB8", Slot = "59")]
	public virtual void ShowPreviewByIdAccodingToLastParams(uint itemID, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM)
	{
	}

	[Token(Token = "0x60128E5")]
	[Address(RVA = "0xEFDB60", Offset = "0xEFDB60", VA = "0xEFDB60", Slot = "60")]
	public virtual void ShowPreviewByID(uint itemID, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM, bool isShowDesc = true, bool isShowOwned = true, [Optional] FullScreenAnimParams animdata, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needShowInstallmentInfo = false, bool needResetUI = true)
	{
	}

	[Token(Token = "0x60128E6")]
	[Address(RVA = "0xEFDCB0", Offset = "0xEFDCB0", VA = "0xEFDCB0", Slot = "61")]
	public virtual void ShowAvatar(uint avatarID, List<uint> clothList, uint weaponID = 0u, uint petID = 0u, bool needShowAnim = true, bool needOptionalDownload = false, bool clearUI = true, [Optional] List<uint> checkOptionalIds)
	{
	}

	[Token(Token = "0x60128E7")]
	[Address(RVA = "0xEFDDC0", Offset = "0xEFDDC0", VA = "0xEFDDC0", Slot = "62")]
	public virtual void RefreshPreviewUI(uint itemID)
	{
	}

	[Token(Token = "0x60128E8")]
	[Address(RVA = "0xEFDE88", Offset = "0xEFDE88", VA = "0xEFDE88", Slot = "63")]
	protected virtual void SetPreviewBorder(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x60128E9")]
	[Address(RVA = "0xEFDF54", Offset = "0xEFDF54", VA = "0xEFDF54", Slot = "64")]
	public virtual void ChangePreviewBorder(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x60128EA")]
	[Address(RVA = "0xEFDFD8", Offset = "0xEFDFD8", VA = "0xEFDFD8", Slot = "65")]
	protected virtual void SetAvatarParams(Vector3 scale, Vector3 pos, FrontEndPreviewComponent.AvatarType type, Vector4 boostparams, bool playPose = true, bool needStopEffect = true)
	{
	}

	[Token(Token = "0x60128EB")]
	[Address(RVA = "0xEFE204", Offset = "0xEFE204", VA = "0xEFE204")]
	public void ClearCache(bool clearall = false, bool clearPreviewAvatar = true, bool clearPreviewCacheAvatar = false, bool clearDesc = false)
	{
	}

	[Token(Token = "0x60128EC")]
	[Address(RVA = "0xEFE2C0", Offset = "0xEFE2C0", VA = "0xEFE2C0")]
	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, Vector3 avatar1Pos, Vector3 avatar2Pos)
	{
	}

	[Token(Token = "0x60128ED")]
	[Address(RVA = "0xEFE4D4", Offset = "0xEFE4D4", VA = "0xEFE4D4")]
	public UIMaleAvatar GetCreateAvatar()
	{
		return null;
	}

	[Token(Token = "0x60128EE")]
	[Address(RVA = "0xEFE548", Offset = "0xEFE548", VA = "0xEFE548")]
	public void SetAvatarPos(Vector3 pos)
	{
	}

	[Token(Token = "0x60128EF")]
	[Address(RVA = "0xEFD27C", Offset = "0xEFD27C", VA = "0xEFD27C")]
	private bool IsPreviewOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x60128F0")]
	[Address(RVA = "0xEFE6DC", Offset = "0xEFE6DC", VA = "0xEFE6DC", Slot = "43")]
	public override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x60128F1")]
	[Address(RVA = "0xEFEAC0", Offset = "0xEFEAC0", VA = "0xEFEAC0", Slot = "66")]
	protected virtual void OnPopupWindowListChanged(bool isShow)
	{
	}

	[Token(Token = "0x60128F2")]
	[Address(RVA = "0xEFEB1C", Offset = "0xEFEB1C", VA = "0xEFEB1C", Slot = "44")]
	public override void OnNavigationBack()
	{
	}

	[Token(Token = "0x60128F3")]
	[Address(RVA = "0xEFEB9C", Offset = "0xEFEB9C", VA = "0xEFEB9C", Slot = "45")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x60128F4")]
	[Address(RVA = "0xEFEC10", Offset = "0xEFEC10", VA = "0xEFEC10")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60128F5")]
	[Address(RVA = "0xEFEC18", Offset = "0xEFEC18", VA = "0xEFEC18")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60128F6")]
	[Address(RVA = "0xEFEC20", Offset = "0xEFEC20", VA = "0xEFEC20")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60128F7")]
	[Address(RVA = "0xEFEC28", Offset = "0xEFEC28", VA = "0xEFEC28")]
	public void _003C_003EiFixBaseProxy_OnNavigationBack()
	{
	}

	[Token(Token = "0x60128F8")]
	[Address(RVA = "0xEFEC30", Offset = "0xEFEC30", VA = "0xEFEC30")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x60128F9")]
	[Address(RVA = "0xEFEC38", Offset = "0xEFEC38", VA = "0xEFEC38")]
	public void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
