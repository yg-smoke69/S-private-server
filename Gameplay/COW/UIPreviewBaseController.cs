using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C76")]
public abstract class UIPreviewBaseController : UIBaseController
{
	[Token(Token = "0x2002C77")]
	private sealed class _003CCreateDoublePreviewAvatar_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010FB3")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 avatar1Pos;

		[Token(Token = "0x4010FB4")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 avatar2Pos;

		[Token(Token = "0x4010FB5")]
		[FieldOffset(Offset = "0x20")]
		internal UIPreviewBaseController _0024this;

		[Token(Token = "0x60128CF")]
		[Address(RVA = "0xEFA5FC", Offset = "0xEFA5FC", VA = "0xEFA5FC")]
		public _003CCreateDoublePreviewAvatar_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60128D0")]
		[Address(RVA = "0xEFA7B0", Offset = "0xEFA7B0", VA = "0xEFA7B0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010FAF")]
	[FieldOffset(Offset = "0x28")]
	protected FrontendPreviewType m_PreviewUIType;

	[Token(Token = "0x4010FB0")]
	[FieldOffset(Offset = "0x2C")]
	protected FrontEndPreviewConfigData m_FrontEndPreviewData;

	[Token(Token = "0x4010FB1")]
	[FieldOffset(Offset = "0x30")]
	protected UIWidget m_FrontEndPreviewBorder;

	[Token(Token = "0x4010FB2")]
	[FieldOffset(Offset = "0x34")]
	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x60128AD")]
	[Address(RVA = "0xEF8AF4", Offset = "0xEF8AF4", VA = "0xEF8AF4")]
	protected UIPreviewBaseController()
	{
	}

	[Token(Token = "0x60128AE")]
	protected abstract UIWidget GetFrontEndPreviewBorder();

	[Token(Token = "0x60128AF")]
	protected abstract FrontendPreviewType GetPreviewUIType();

	[Token(Token = "0x60128B0")]
	[Address(RVA = "0xEF8B78", Offset = "0xEF8B78", VA = "0xEF8B78", Slot = "33")]
	protected virtual bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x60128B1")]
	[Address(RVA = "0xEF8BD0", Offset = "0xEF8BD0", VA = "0xEF8BD0", Slot = "34")]
	protected virtual FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x60128B2")]
	[Address(RVA = "0xEF8C88", Offset = "0xEF8C88", VA = "0xEF8C88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60128B3")]
	[Address(RVA = "0xEF8CEC", Offset = "0xEF8CEC", VA = "0xEF8CEC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60128B4")]
	[Address(RVA = "0xEF8D64", Offset = "0xEF8D64", VA = "0xEF8D64", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60128B5")]
	[Address(RVA = "0xEF8EA0", Offset = "0xEF8EA0", VA = "0xEF8EA0", Slot = "35")]
	protected virtual FrontEndPreviewConfigData GetFrontEndPreviewData()
	{
		return null;
	}

	[Token(Token = "0x60128B6")]
	[Address(RVA = "0xEF900C", Offset = "0xEF900C", VA = "0xEF900C", Slot = "36")]
	protected virtual void OpenPreview()
	{
	}

	[Token(Token = "0x60128B7")]
	[Address(RVA = "0xEF93C0", Offset = "0xEF93C0", VA = "0xEF93C0", Slot = "37")]
	protected virtual void ChangePreviewUIType(FrontendPreviewType type)
	{
	}

	[Token(Token = "0x60128B8")]
	[Address(RVA = "0xEF94E8", Offset = "0xEF94E8", VA = "0xEF94E8", Slot = "38")]
	protected virtual void OnChangePreviewUIType()
	{
	}

	[Token(Token = "0x60128B9")]
	[Address(RVA = "0xEF953C", Offset = "0xEF953C", VA = "0xEF953C", Slot = "39")]
	protected virtual void ClosePreview()
	{
	}

	[Token(Token = "0x60128BA")]
	[Address(RVA = "0xEF9654", Offset = "0xEF9654", VA = "0xEF9654")]
	public void TempHidePreview(bool keepUIContent = false, bool keep3DContent = false)
	{
	}

	[Token(Token = "0x60128BB")]
	[Address(RVA = "0xEF9700", Offset = "0xEF9700", VA = "0xEF9700", Slot = "40")]
	protected virtual void OnTempHidePreview()
	{
	}

	[Token(Token = "0x60128BC")]
	[Address(RVA = "0xEF9754", Offset = "0xEF9754", VA = "0xEF9754")]
	public void RecoverPreview()
	{
	}

	[Token(Token = "0x60128BD")]
	[Address(RVA = "0xEF9828", Offset = "0xEF9828", VA = "0xEF9828", Slot = "41")]
	protected virtual void OnRecoverPreview()
	{
	}

	[Token(Token = "0x60128BE")]
	[Address(RVA = "0xEF987C", Offset = "0xEF987C", VA = "0xEF987C", Slot = "42")]
	public virtual void ShowPreviewByBaseItemInfo(BaseItemInfo baseItemInfo, bool isShowDesc = true, bool isShowOwned = true, [Optional] FullScreenAnimParams animdata, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needShowInstallmentInfo = false, bool needResetUI = true)
	{
	}

	[Token(Token = "0x60128BF")]
	[Address(RVA = "0xEF9A4C", Offset = "0xEF9A4C", VA = "0xEF9A4C", Slot = "43")]
	public virtual void ShowPreviewByBaseItemInfoAccodingToLastParams(BaseItemInfo baseItemInfo)
	{
	}

	[Token(Token = "0x60128C0")]
	[Address(RVA = "0xEF9B74", Offset = "0xEF9B74", VA = "0xEF9B74", Slot = "44")]
	public virtual void ShowPreviewByIdAccodingToLastParams(uint itemID, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM)
	{
	}

	[Token(Token = "0x60128C1")]
	[Address(RVA = "0xEF9C1C", Offset = "0xEF9C1C", VA = "0xEF9C1C", Slot = "45")]
	public virtual void ShowPreviewByID(uint itemID, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM, bool isShowDesc = true, bool isShowOwned = true, [Optional] FullScreenAnimParams animdata, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needShowInstallmentInfo = false, bool needResetUI = true)
	{
	}

	[Token(Token = "0x60128C2")]
	[Address(RVA = "0xEF9D6C", Offset = "0xEF9D6C", VA = "0xEF9D6C", Slot = "46")]
	public virtual void ShowAvatar(uint avatarID, List<uint> clothList, uint weaponID = 0u, uint petID = 0u, bool needShowAnim = true, bool needOptionalDownload = false, bool clearUI = true, [Optional] List<uint> checkOptionalIds)
	{
	}

	[Token(Token = "0x60128C3")]
	[Address(RVA = "0xEF9E7C", Offset = "0xEF9E7C", VA = "0xEF9E7C", Slot = "47")]
	public virtual void RefreshPreviewUI(uint itemID)
	{
	}

	[Token(Token = "0x60128C4")]
	[Address(RVA = "0xEF9F44", Offset = "0xEF9F44", VA = "0xEF9F44", Slot = "48")]
	protected virtual void SetPreviewBorder(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x60128C5")]
	[Address(RVA = "0xEFA010", Offset = "0xEFA010", VA = "0xEFA010", Slot = "49")]
	public virtual void ChangePreviewBorder(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x60128C6")]
	[Address(RVA = "0xEFA094", Offset = "0xEFA094", VA = "0xEFA094", Slot = "50")]
	protected virtual void SetAvatarParams(Vector3 scale, Vector3 pos, FrontEndPreviewComponent.AvatarType type, Vector4 boostparams, bool playPose = true, bool needStopEffect = true)
	{
	}

	[Token(Token = "0x60128C7")]
	[Address(RVA = "0xEFA2C0", Offset = "0xEFA2C0", VA = "0xEFA2C0")]
	public UIMaleAvatar GetCreateAvatar()
	{
		return null;
	}

	[Token(Token = "0x60128C8")]
	[Address(RVA = "0xEF9348", Offset = "0xEF9348", VA = "0xEF9348")]
	protected bool IsPreviewOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x60128C9")]
	[Address(RVA = "0xEFA334", Offset = "0xEFA334", VA = "0xEFA334")]
	public void ClearCache(bool clearall = false, bool clearPreviewAvatar = true, bool clearPreviewCacheAvatar = false, bool clearDesc = false)
	{
	}

	[Token(Token = "0x60128CA")]
	[Address(RVA = "0xEFA3F0", Offset = "0xEFA3F0", VA = "0xEFA3F0")]
	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, Vector3 avatar1Pos, Vector3 avatar2Pos)
	{
	}

	[Token(Token = "0x60128CB")]
	[Address(RVA = "0xEFA604", Offset = "0xEFA604", VA = "0xEFA604")]
	public void SetAvatarPos(Vector3 pos)
	{
	}

	[Token(Token = "0x60128CC")]
	[Address(RVA = "0xEFA798", Offset = "0xEFA798", VA = "0xEFA798")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60128CD")]
	[Address(RVA = "0xEFA7A0", Offset = "0xEFA7A0", VA = "0xEFA7A0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60128CE")]
	[Address(RVA = "0xEFA7A8", Offset = "0xEFA7A8", VA = "0xEFA7A8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
