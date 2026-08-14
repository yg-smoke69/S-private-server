using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C73")]
public abstract class UIPreviewNavigationController : UINavigationController
{
	[Token(Token = "0x2002C74")]
	private sealed class _003CCreateDoublePreviewAvatar_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010FAB")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 avatar1Pos;

		[Token(Token = "0x4010FAC")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 avatar2Pos;

		[Token(Token = "0x4010FAD")]
		[FieldOffset(Offset = "0x20")]
		internal UIPreviewNavigationController _0024this;

		[Token(Token = "0x60128A5")]
		[Address(RVA = "0xEFC718", Offset = "0xEFC718", VA = "0xEFC718")]
		public _003CCreateDoublePreviewAvatar_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60128A6")]
		[Address(RVA = "0xEFCA10", Offset = "0xEFCA10", VA = "0xEFCA10")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010FA5")]
	[FieldOffset(Offset = "0x68")]
	protected bool m_FirstEnterFlag;

	[Token(Token = "0x4010FA6")]
	[FieldOffset(Offset = "0x69")]
	protected bool m_IsHideByPreviewPop;

	[Token(Token = "0x4010FA7")]
	[FieldOffset(Offset = "0x6C")]
	protected FrontendPreviewType m_PreviewUIType;

	[Token(Token = "0x4010FA8")]
	[FieldOffset(Offset = "0x70")]
	protected FrontEndPreviewConfigData m_FrontEndPreviewData;

	[Token(Token = "0x4010FA9")]
	[FieldOffset(Offset = "0x74")]
	protected UIWidget m_FrontEndPreviewBorder;

	[Token(Token = "0x4010FAA")]
	[FieldOffset(Offset = "0x78")]
	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x601287C")]
	[Address(RVA = "0xEFA844", Offset = "0xEFA844", VA = "0xEFA844")]
	protected UIPreviewNavigationController()
	{
	}

	[Token(Token = "0x601287D")]
	protected abstract UIWidget GetFrontEndPreviewBorder();

	[Token(Token = "0x601287E")]
	protected abstract FrontendPreviewType GetPreviewUIType();

	[Token(Token = "0x601287F")]
	[Address(RVA = "0xEFA8D0", Offset = "0xEFA8D0", VA = "0xEFA8D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012880")]
	[Address(RVA = "0xEFA9C4", Offset = "0xEFA9C4", VA = "0xEFA9C4", Slot = "44")]
	protected virtual bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x6012881")]
	[Address(RVA = "0xEFAA1C", Offset = "0xEFAA1C", VA = "0xEFAA1C", Slot = "45")]
	protected virtual bool NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x6012882")]
	[Address(RVA = "0xEFAA74", Offset = "0xEFAA74", VA = "0xEFAA74", Slot = "46")]
	protected virtual FrontEndPreviewConfigData GetFrontEndPreviewData()
	{
		return null;
	}

	[Token(Token = "0x6012883")]
	[Address(RVA = "0xEFABE0", Offset = "0xEFABE0", VA = "0xEFABE0", Slot = "47")]
	protected virtual FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x6012884")]
	[Address(RVA = "0xEFAC98", Offset = "0xEFAC98", VA = "0xEFAC98", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6012885")]
	[Address(RVA = "0xEFAE04", Offset = "0xEFAE04", VA = "0xEFAE04")]
	private bool IsCorveredByPreviewPopWindow()
	{
		return default(bool);
	}

	[Token(Token = "0x6012886")]
	[Address(RVA = "0xEFB0F8", Offset = "0xEFB0F8", VA = "0xEFB0F8", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6012887")]
	[Address(RVA = "0xEFB218", Offset = "0xEFB218", VA = "0xEFB218", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012888")]
	[Address(RVA = "0xEFB290", Offset = "0xEFB290", VA = "0xEFB290", Slot = "48")]
	protected virtual void OpenPreview()
	{
	}

	[Token(Token = "0x6012889")]
	[Address(RVA = "0xEFB644", Offset = "0xEFB644", VA = "0xEFB644", Slot = "49")]
	protected virtual void ChangePreviewUIType(FrontendPreviewType type)
	{
	}

	[Token(Token = "0x601288A")]
	[Address(RVA = "0xEFB758", Offset = "0xEFB758", VA = "0xEFB758", Slot = "50")]
	protected virtual void OnChangePreviewUIType()
	{
	}

	[Token(Token = "0x601288B")]
	[Address(RVA = "0xEFB7AC", Offset = "0xEFB7AC", VA = "0xEFB7AC", Slot = "51")]
	protected virtual void ClosePreview()
	{
	}

	[Token(Token = "0x601288C")]
	[Address(RVA = "0xEFB16C", Offset = "0xEFB16C", VA = "0xEFB16C")]
	public void TempHidePreview(bool keepUIContent = false, bool keep3DContent = false)
	{
	}

	[Token(Token = "0x601288D")]
	[Address(RVA = "0xEFB8C4", Offset = "0xEFB8C4", VA = "0xEFB8C4", Slot = "52")]
	protected virtual void OnTempHidePreview()
	{
	}

	[Token(Token = "0x601288E")]
	[Address(RVA = "0xEFB024", Offset = "0xEFB024", VA = "0xEFB024")]
	public void RecoverPreview()
	{
	}

	[Token(Token = "0x601288F")]
	[Address(RVA = "0xEFB918", Offset = "0xEFB918", VA = "0xEFB918", Slot = "53")]
	protected virtual void OnRecoverPreview()
	{
	}

	[Token(Token = "0x6012890")]
	[Address(RVA = "0xEFB96C", Offset = "0xEFB96C", VA = "0xEFB96C", Slot = "54")]
	public virtual void ShowPreviewByBaseItemInfo(BaseItemInfo baseItemInfo, bool isShowDesc = true, bool isShowOwned = true, [Optional] FullScreenAnimParams animdata, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needShowInstallmentInfo = false, bool needResetUI = true)
	{
	}

	[Token(Token = "0x6012891")]
	[Address(RVA = "0xEFBB3C", Offset = "0xEFBB3C", VA = "0xEFBB3C", Slot = "55")]
	public virtual void ShowPreviewByBaseItemInfoAccodingToLastParams(BaseItemInfo baseItemInfo)
	{
	}

	[Token(Token = "0x6012892")]
	[Address(RVA = "0xEFBC64", Offset = "0xEFBC64", VA = "0xEFBC64", Slot = "56")]
	public virtual void ShowPreviewByIdAccodingToLastParams(uint itemID, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM)
	{
	}

	[Token(Token = "0x6012893")]
	[Address(RVA = "0xEFBD0C", Offset = "0xEFBD0C", VA = "0xEFBD0C", Slot = "57")]
	public virtual void ShowPreviewByID(uint itemID, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM, bool isShowDesc = true, bool isShowOwned = true, [Optional] FullScreenAnimParams animdata, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needShowInstallmentInfo = false, bool needResetUI = true, bool playPetLoopIdleSound = false)
	{
	}

	[Token(Token = "0x6012894")]
	[Address(RVA = "0xEFBE68", Offset = "0xEFBE68", VA = "0xEFBE68", Slot = "58")]
	public virtual void ShowAvatar(uint avatarID, List<uint> clothList, uint weaponID = 0u, uint petID = 0u, bool needShowAnim = true, bool needOptionalDownload = false, bool clearUI = true, [Optional] List<uint> checkOptionalIds)
	{
	}

	[Token(Token = "0x6012895")]
	[Address(RVA = "0xEFBF78", Offset = "0xEFBF78", VA = "0xEFBF78", Slot = "59")]
	public virtual void RefreshPreviewUIOnly(uint itemID)
	{
	}

	[Token(Token = "0x6012896")]
	[Address(RVA = "0xEFC060", Offset = "0xEFC060", VA = "0xEFC060", Slot = "60")]
	protected virtual void SetPreviewBorder(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x6012897")]
	[Address(RVA = "0xEFC12C", Offset = "0xEFC12C", VA = "0xEFC12C", Slot = "61")]
	public virtual void ChangePreviewBorder(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x6012898")]
	[Address(RVA = "0xEFC1B0", Offset = "0xEFC1B0", VA = "0xEFC1B0", Slot = "62")]
	protected virtual void SetAvatarParams(Vector3 scale, Vector3 pos, FrontEndPreviewComponent.AvatarType type, Vector4 boostparams, bool playPose = true, bool needStopEffect = true)
	{
	}

	[Token(Token = "0x6012899")]
	[Address(RVA = "0xEFB5CC", Offset = "0xEFB5CC", VA = "0xEFB5CC")]
	protected bool IsPreviewOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x601289A")]
	[Address(RVA = "0xEFC3DC", Offset = "0xEFC3DC", VA = "0xEFC3DC")]
	public UIMaleAvatar GetCreateAvatar()
	{
		return null;
	}

	[Token(Token = "0x601289B")]
	[Address(RVA = "0xEFC450", Offset = "0xEFC450", VA = "0xEFC450")]
	public void ClearCache(bool clearall = false, bool clearPreviewAvatar = true, bool clearPreviewCacheAvatar = false, bool clearDesc = false)
	{
	}

	[Token(Token = "0x601289C")]
	[Address(RVA = "0xEFC50C", Offset = "0xEFC50C", VA = "0xEFC50C")]
	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, Vector3 avatar1Pos, Vector3 avatar2Pos)
	{
	}

	[Token(Token = "0x601289D")]
	[Address(RVA = "0xEFC720", Offset = "0xEFC720", VA = "0xEFC720")]
	public void SetAvatarPos(Vector3 pos)
	{
	}

	[Token(Token = "0x601289E")]
	[Address(RVA = "0xEFC8B4", Offset = "0xEFC8B4", VA = "0xEFC8B4", Slot = "63")]
	protected virtual void SetBgByCameraType(object[] param)
	{
	}

	[Token(Token = "0x601289F")]
	[Address(RVA = "0xEFC910", Offset = "0xEFC910", VA = "0xEFC910", Slot = "33")]
	protected override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x60128A0")]
	[Address(RVA = "0xEFC9E8", Offset = "0xEFC9E8", VA = "0xEFC9E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60128A1")]
	[Address(RVA = "0xEFC9F0", Offset = "0xEFC9F0", VA = "0xEFC9F0")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60128A2")]
	[Address(RVA = "0xEFC9F8", Offset = "0xEFC9F8", VA = "0xEFC9F8")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x60128A3")]
	[Address(RVA = "0xEFCA00", Offset = "0xEFCA00", VA = "0xEFCA00")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60128A4")]
	[Address(RVA = "0xEFCA08", Offset = "0xEFCA08", VA = "0xEFCA08")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
