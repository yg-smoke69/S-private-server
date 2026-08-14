using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002B76")]
internal class UITrainingCampController : UIPreviewBaseController, _Attribute
{
	[Token(Token = "0x4010A35")]
	[FieldOffset(Offset = "0x38")]
	private UITrainingCampView m_View;

	[Token(Token = "0x4010A36")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010A37")]
	[FieldOffset(Offset = "0x40")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x4010A38")]
	[FieldOffset(Offset = "0x44")]
	private bool m_CanApply;

	[Token(Token = "0x4010A39")]
	public const uint PROGRESS_OFFSET = 6u;

	[Token(Token = "0x4010A3A")]
	[FieldOffset(Offset = "0x48")]
	private List<UITrainingCampConditionItemController> m_ConditionItemList;

	[Token(Token = "0x4010A3B")]
	[FieldOffset(Offset = "0x4C")]
	private List<UITrainingCampConditionItemController> m_IntroductionConditionItemList;

	[Token(Token = "0x4010A3C")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> m_StudentPosList;

	[Token(Token = "0x4010A3D")]
	[FieldOffset(Offset = "0x54")]
	private List<UISprite> m_StudentConnectionList;

	[Token(Token = "0x4010A3E")]
	[FieldOffset(Offset = "0x58")]
	private List<UITrainingCampMemberItemController> m_StudentList;

	[Token(Token = "0x4010A3F")]
	[FieldOffset(Offset = "0x5C")]
	private List<UITrainingCampProgressAwardController> m_ProgressAwardList;

	[Token(Token = "0x4010A40")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<uint, UITrainingCampMemberProgressPinController> m_ProgressPinDic;

	[Token(Token = "0x4010A41")]
	[FieldOffset(Offset = "0x64")]
	private UITrainingCampSideListController m_SideListCtrl;

	[Token(Token = "0x4010A42")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsRewardListFilled;

	[Token(Token = "0x4010A43")]
	[FieldOffset(Offset = "0x69")]
	private bool m_IsStudentRewardListFilled;

	[Token(Token = "0x4010A44")]
	[FieldOffset(Offset = "0x70")]
	private ulong m_TutorAccountID;

	[Token(Token = "0x4010A45")]
	[FieldOffset(Offset = "0x78")]
	private int m_MaxIntimacy;

	[Token(Token = "0x4010A46")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_IsTrainingCampDescReady;

	[Token(Token = "0x4010A47")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_FullScreenPreviewOpen;

	[Token(Token = "0x4010A48")]
	[FieldOffset(Offset = "0x7E")]
	private bool m_FullScreenPreviewCloseWhenNotActive;

	[Token(Token = "0x6011EE9")]
	[Address(RVA = "0x2AFC820", Offset = "0x2AFC820", VA = "0x2AFC820")]
	public UITrainingCampController()
	{
	}

	[Token(Token = "0x6011EEA")]
	[Address(RVA = "0x2AFC828", Offset = "0x2AFC828", VA = "0x2AFC828")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011EEB")]
	[Address(RVA = "0x2AFC8CC", Offset = "0x2AFC8CC", VA = "0x2AFC8CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011EEC")]
	[Address(RVA = "0x2AFD290", Offset = "0x2AFD290", VA = "0x2AFD290", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011EED")]
	[Address(RVA = "0x2AFD2F4", Offset = "0x2AFD2F4", VA = "0x2AFD2F4", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x6011EEE")]
	[Address(RVA = "0x2AFDE40", Offset = "0x2AFDE40", VA = "0x2AFDE40", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6011EEF")]
	[Address(RVA = "0x2AFDEC8", Offset = "0x2AFDEC8", VA = "0x2AFDEC8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011EF0")]
	[Address(RVA = "0x2AFDFF4", Offset = "0x2AFDFF4", VA = "0x2AFDFF4", Slot = "51")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011EF1")]
	[Address(RVA = "0x2AFF8A4", Offset = "0x2AFF8A4", VA = "0x2AFF8A4", Slot = "52")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011EF2")]
	[Address(RVA = "0x2AFCF78", Offset = "0x2AFCF78", VA = "0x2AFCF78")]
	private void InitView()
	{
	}

	[Token(Token = "0x6011EF3")]
	[Address(RVA = "0x2AFD518", Offset = "0x2AFD518", VA = "0x2AFD518")]
	public void RefreshContainer()
	{
	}

	[Token(Token = "0x6011EF4")]
	[Address(RVA = "0x2AFF95C", Offset = "0x2AFF95C", VA = "0x2AFF95C")]
	private void RefreshApplyContainer()
	{
	}

	[Token(Token = "0x6011EF5")]
	[Address(RVA = "0x2B001A8", Offset = "0x2B001A8", VA = "0x2B001A8")]
	private void RefreshRewardDisplayList()
	{
	}

	[Token(Token = "0x6011EF6")]
	[Address(RVA = "0x2B0246C", Offset = "0x2B0246C", VA = "0x2B0246C")]
	private void RefreshStudentRewardDisplayList()
	{
	}

	[Token(Token = "0x6011EF7")]
	[Address(RVA = "0x2B007DC", Offset = "0x2B007DC", VA = "0x2B007DC")]
	private void RefreshTutorPage()
	{
	}

	[Token(Token = "0x6011EF8")]
	[Address(RVA = "0x2B02814", Offset = "0x2B02814", VA = "0x2B02814")]
	private void RefreshProgress()
	{
	}

	[Token(Token = "0x6011EF9")]
	[Address(RVA = "0x2AFE360", Offset = "0x2AFE360", VA = "0x2AFE360")]
	private void RefreshAwardStatus()
	{
	}

	[Token(Token = "0x6011EFA")]
	[Address(RVA = "0x2B030BC", Offset = "0x2B030BC", VA = "0x2B030BC")]
	public void ShowStudentContent(AccountInfoWithChummyState CurrentInfo, int index)
	{
	}

	[Token(Token = "0x6011EFB")]
	[Address(RVA = "0x2B01D98", Offset = "0x2B01D98", VA = "0x2B01D98")]
	private void RefreshIntroductionContainer()
	{
	}

	[Token(Token = "0x6011EFC")]
	[Address(RVA = "0x2B02288", Offset = "0x2B02288", VA = "0x2B02288")]
	private void RefreshStudentPage()
	{
	}

	[Token(Token = "0x6011EFD")]
	[Address(RVA = "0x2B04184", Offset = "0x2B04184", VA = "0x2B04184")]
	private void RefreshStudentPageInfo()
	{
	}

	[Token(Token = "0x6011EFE")]
	[Address(RVA = "0x2B03A90", Offset = "0x2B03A90", VA = "0x2B03A90")]
	private void RefreshClassmate()
	{
	}

	[Token(Token = "0x6011EFF")]
	[Address(RVA = "0x2B03850", Offset = "0x2B03850", VA = "0x2B03850")]
	private void TryShowPreviewAvatar(ulong accountID)
	{
	}

	[Token(Token = "0x6011F00")]
	[Address(RVA = "0x2AFE85C", Offset = "0x2AFE85C", VA = "0x2AFE85C")]
	private bool ShowAvatarInternal(ulong accountID, bool isForce = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6011F01")]
	[Address(RVA = "0x2B05580", Offset = "0x2B05580", VA = "0x2B05580")]
	private bool CheckSameClothList(List<uint> localList, List<uint> generatedList)
	{
		return default(bool);
	}

	[Token(Token = "0x6011F02")]
	[Address(RVA = "0x2B05704", Offset = "0x2B05704", VA = "0x2B05704")]
	private PlayDoubleAvatarAnimParams CreatePlayDoubleAvatarAnimParams(List<uint> idlistA, List<uint> idlistB)
	{
		return null;
	}

	[Token(Token = "0x6011F03")]
	[Address(RVA = "0x2B058CC", Offset = "0x2B058CC", VA = "0x2B058CC")]
	private PlayDoubleAvatarAnimParams.AvatarAnimParams CreateAvatarAnimParams(List<uint> idlist)
	{
		return null;
	}

	[Token(Token = "0x6011F04")]
	[Address(RVA = "0x2B05A10", Offset = "0x2B05A10", VA = "0x2B05A10")]
	private void SetAvatarTransformInfo(AvatarTransformInfo avatarInfoA, AvatarTransformInfo avatarInfoB)
	{
	}

	[Token(Token = "0x6011F05")]
	[Address(RVA = "0x2AFF6AC", Offset = "0x2AFF6AC", VA = "0x2AFF6AC")]
	private void ShowLoading(bool show)
	{
	}

	[Token(Token = "0x6011F06")]
	[Address(RVA = "0x2B05C50", Offset = "0x2B05C50", VA = "0x2B05C50")]
	private void OnClickDescTips()
	{
	}

	[Token(Token = "0x6011F07")]
	[Address(RVA = "0x2B05D84", Offset = "0x2B05D84", VA = "0x2B05D84")]
	private void OnClickApplyBtn()
	{
	}

	[Token(Token = "0x6011F08")]
	[Address(RVA = "0x2B06088", Offset = "0x2B06088", VA = "0x2B06088")]
	private void OnClickMessageBtn()
	{
	}

	[Token(Token = "0x6011F09")]
	[Address(RVA = "0x2B03540", Offset = "0x2B03540", VA = "0x2B03540")]
	private void OnClickAddBtn()
	{
	}

	[Token(Token = "0x6011F0A")]
	[Address(RVA = "0x2B06198", Offset = "0x2B06198", VA = "0x2B06198")]
	private void OnClickTaskBtn()
	{
	}

	[Token(Token = "0x6011F0B")]
	[Address(RVA = "0x2B062A8", Offset = "0x2B062A8", VA = "0x2B062A8")]
	private void OnClickStudent1InfoBtn()
	{
	}

	[Token(Token = "0x6011F0C")]
	[Address(RVA = "0x2B06624", Offset = "0x2B06624", VA = "0x2B06624")]
	private void OnClickStudent2InfoBtn()
	{
	}

	[Token(Token = "0x6011F0D")]
	[Address(RVA = "0x2B0630C", Offset = "0x2B0630C", VA = "0x2B0630C")]
	private void OnClickStudentInfo(int index)
	{
	}

	[Token(Token = "0x6011F0E")]
	[Address(RVA = "0x2B06688", Offset = "0x2B06688", VA = "0x2B06688")]
	private void OnClickTutorAvatarBtn()
	{
	}

	[Token(Token = "0x6011F0F")]
	[Address(RVA = "0x2B06F54", Offset = "0x2B06F54", VA = "0x2B06F54")]
	private void OnClickStudentRevoke(object obj)
	{
	}

	[Token(Token = "0x6011F10")]
	[Address(RVA = "0x2B070A8", Offset = "0x2B070A8", VA = "0x2B070A8")]
	private void OnClickStudentBreak(object obj)
	{
	}

	[Token(Token = "0x6011F11")]
	[Address(RVA = "0x2B07734", Offset = "0x2B07734", VA = "0x2B07734")]
	private void OnClickBreakBtn()
	{
	}

	[Token(Token = "0x6011F12")]
	[Address(RVA = "0x2B07888", Offset = "0x2B07888", VA = "0x2B07888")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x6011F13")]
	[Address(RVA = "0x2B07908", Offset = "0x2B07908", VA = "0x2B07908")]
	private void OnClickGraduateBtn()
	{
	}

	[Token(Token = "0x6011F14")]
	[Address(RVA = "0x2B07A58", Offset = "0x2B07A58", VA = "0x2B07A58", Slot = "31")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6011F15")]
	[Address(RVA = "0x2B07AC8", Offset = "0x2B07AC8", VA = "0x2B07AC8", Slot = "32")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6011F16")]
	[Address(RVA = "0x2B07B20", Offset = "0x2B07B20", VA = "0x2B07B20")]
	private void OnFullScreenPreviewOpen(object[] data)
	{
	}

	[Token(Token = "0x6011F17")]
	[Address(RVA = "0x2AFD3F8", Offset = "0x2AFD3F8", VA = "0x2AFD3F8")]
	private void OnFullScreenPreviewClose(object[] data)
	{
	}

	[Token(Token = "0x6011F18")]
	[Address(RVA = "0x2B07BD0", Offset = "0x2B07BD0", VA = "0x2B07BD0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011F19")]
	[Address(RVA = "0x2B07BD8", Offset = "0x2B07BD8", VA = "0x2B07BD8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6011F1A")]
	[Address(RVA = "0x2B07BE0", Offset = "0x2B07BE0", VA = "0x2B07BE0")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x6011F1B")]
	[Address(RVA = "0x2B07BE8", Offset = "0x2B07BE8", VA = "0x2B07BE8")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x6011F1C")]
	[Address(RVA = "0x2B07BF0", Offset = "0x2B07BF0", VA = "0x2B07BF0")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
