using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020BA")]
public class UIDownloadCentreBaseItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400CCF7")]
	[FieldOffset(Offset = "0x38")]
	protected UIButton downloadBtn;

	[Token(Token = "0x400CCF8")]
	[FieldOffset(Offset = "0x3C")]
	protected UIButton pauseDownloadBtn;

	[Token(Token = "0x400CCF9")]
	[FieldOffset(Offset = "0x40")]
	protected UIButton deleteBtn;

	[Token(Token = "0x400CCFA")]
	[FieldOffset(Offset = "0x44")]
	protected UIButton inPendingBtn;

	[Token(Token = "0x400CCFB")]
	[FieldOffset(Offset = "0x48")]
	protected UIButton retryBtn;

	[Token(Token = "0x400CCFC")]
	[FieldOffset(Offset = "0x4C")]
	protected UISprite tagState;

	[Token(Token = "0x400CCFD")]
	[FieldOffset(Offset = "0x50")]
	protected UISprite rewardIcon;

	[Token(Token = "0x400CCFE")]
	[FieldOffset(Offset = "0x54")]
	protected UIButton rewardBtn;

	[Token(Token = "0x400CCFF")]
	[FieldOffset(Offset = "0x58")]
	protected GameObject rewardEffect;

	[Token(Token = "0x400CD00")]
	[FieldOffset(Offset = "0x5C")]
	protected GameObject inPendingEffect;

	[Token(Token = "0x400CD01")]
	[FieldOffset(Offset = "0x60")]
	protected UISprite progressBar;

	[Token(Token = "0x400CD02")]
	[FieldOffset(Offset = "0x64")]
	protected UILabel progressLabel;

	[Token(Token = "0x400CD03")]
	[FieldOffset(Offset = "0x68")]
	protected UILabel title;

	[Token(Token = "0x400CD04")]
	[FieldOffset(Offset = "0x6C")]
	protected GameObject finishLabel;

	[Token(Token = "0x400CD05")]
	[FieldOffset(Offset = "0x70")]
	protected UILabel rewardNum;

	[Token(Token = "0x400CD06")]
	[FieldOffset(Offset = "0x74")]
	protected UIModelOptionalDownload m_Model;

	[Token(Token = "0x400CD07")]
	[FieldOffset(Offset = "0x78")]
	protected uint m_OptionalReDefId;

	[Token(Token = "0x400CD08")]
	[FieldOffset(Offset = "0x7C")]
	protected PatchOptionalResManagerData m_ManagerShowData;

	[Token(Token = "0x400CD09")]
	[FieldOffset(Offset = "0x80")]
	protected PatchOptionalCategoryManagerData m_DownloadShowInfo;

	[Token(Token = "0x400CD0A")]
	[FieldOffset(Offset = "0x84")]
	protected EDownloadContextState m_LastState;

	[Token(Token = "0x400CD0B")]
	[FieldOffset(Offset = "0x88")]
	protected TagDownloadInfo m_DownloadInfo;

	[Token(Token = "0x400CD0C")]
	[FieldOffset(Offset = "0x8C")]
	private bool isDeleteRecommend;

	[Token(Token = "0x600A8EF")]
	[Address(RVA = "0x275E784", Offset = "0x275E784", VA = "0x275E784")]
	public UIDownloadCentreBaseItemController()
	{
	}

	[Token(Token = "0x600A8F0")]
	[Address(RVA = "0x275E794", Offset = "0x275E794", VA = "0x275E794", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A8F1")]
	[Address(RVA = "0x275EAF4", Offset = "0x275EAF4", VA = "0x275EAF4")]
	private void OnStartDownloadClick()
	{
	}

	[Token(Token = "0x600A8F2")]
	[Address(RVA = "0x275ED10", Offset = "0x275ED10", VA = "0x275ED10")]
	private void OnPauseDownloadClick()
	{
	}

	[Token(Token = "0x600A8F3")]
	[Address(RVA = "0x275ED9C", Offset = "0x275ED9C", VA = "0x275ED9C")]
	private void OnPendingBtnClick()
	{
	}

	[Token(Token = "0x600A8F4")]
	[Address(RVA = "0x275EE28", Offset = "0x275EE28", VA = "0x275EE28")]
	private void SetDeleteRecommendState(bool state)
	{
	}

	[Token(Token = "0x600A8F5")]
	[Address(RVA = "0x275EE90", Offset = "0x275EE90", VA = "0x275EE90")]
	private void OnDeleteDownloadClick()
	{
	}

	[Token(Token = "0x600A8F6")]
	[Address(RVA = "0x275F77C", Offset = "0x275F77C", VA = "0x275F77C")]
	private void OnRewardBtnClick()
	{
	}

	[Token(Token = "0x600A8F7")]
	[Address(RVA = "0x275FA00", Offset = "0x275FA00", VA = "0x275FA00")]
	private void BtnGroupInit()
	{
	}

	[Token(Token = "0x600A8F8")]
	[Address(RVA = "0x275FE80", Offset = "0x275FE80", VA = "0x275FE80")]
	private void SetLastState(EDownloadContextState CurrentState)
	{
	}

	[Token(Token = "0x600A8F9")]
	[Address(RVA = "0x275FFCC", Offset = "0x275FFCC", VA = "0x275FFCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600A8FA")]
	[Address(RVA = "0x27602DC", Offset = "0x27602DC", VA = "0x27602DC")]
	private void RefreshRewardBtnState()
	{
	}

	[Token(Token = "0x600A8FB")]
	[Address(RVA = "0x2760830", Offset = "0x2760830", VA = "0x2760830", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A8FC")]
	[Address(RVA = "0x2760DB4", Offset = "0x2760DB4", VA = "0x2760DB4")]
	private void InitTagShow()
	{
	}

	[Token(Token = "0x600A8FD")]
	[Address(RVA = "0x2761004", Offset = "0x2761004", VA = "0x2761004", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A8FE")]
	[Address(RVA = "0x2761098", Offset = "0x2761098", VA = "0x2761098", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A8FF")]
	[Address(RVA = "0x2761164", Offset = "0x2761164", VA = "0x2761164")]
	private void _003COnDeleteDownloadClick_003Em__0()
	{
	}

	[Token(Token = "0x600A900")]
	[Address(RVA = "0x27611A8", Offset = "0x27611A8", VA = "0x27611A8")]
	private void _003COnDeleteDownloadClick_003Em__1()
	{
	}

	[Token(Token = "0x600A901")]
	[Address(RVA = "0x27611E0", Offset = "0x27611E0", VA = "0x27611E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
