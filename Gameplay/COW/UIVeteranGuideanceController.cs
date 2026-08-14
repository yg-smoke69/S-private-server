using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BDA")]
internal class UIVeteranGuideanceController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x4010BF6")]
	[FieldOffset(Offset = "0x7C")]
	private UIVeteranGuideanceView m_View;

	[Token(Token = "0x4010BF7")]
	[FieldOffset(Offset = "0x80")]
	private UIModelVeteranBundle m_ModelBundle;

	[Token(Token = "0x4010BF8")]
	[FieldOffset(Offset = "0x84")]
	private UIModelVeteranSignin m_ModelSignIn;

	[Token(Token = "0x4010BF9")]
	[FieldOffset(Offset = "0x88")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010BFA")]
	[FieldOffset(Offset = "0x8C")]
	private List<Transform> m_ItemTrans;

	[Token(Token = "0x4010BFB")]
	[FieldOffset(Offset = "0x90")]
	private List<UIVeteranGuideancePreviewItemController> m_AwardItemList;

	[Token(Token = "0x6012263")]
	[Address(RVA = "0x28517A4", Offset = "0x28517A4", VA = "0x28517A4")]
	public UIVeteranGuideanceController()
	{
	}

	[Token(Token = "0x6012264")]
	[Address(RVA = "0x2851864", Offset = "0x2851864", VA = "0x2851864")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012265")]
	[Address(RVA = "0x2851908", Offset = "0x2851908", VA = "0x2851908", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012266")]
	[Address(RVA = "0x28522E4", Offset = "0x28522E4", VA = "0x28522E4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6012267")]
	[Address(RVA = "0x2852428", Offset = "0x2852428", VA = "0x2852428", Slot = "45")]
	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x6012268")]
	[Address(RVA = "0x2852480", Offset = "0x2852480", VA = "0x2852480", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6012269")]
	[Address(RVA = "0x2852CE0", Offset = "0x2852CE0", VA = "0x2852CE0", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x601226A")]
	[Address(RVA = "0x2852D44", Offset = "0x2852D44", VA = "0x2852D44")]
	private void OnClose()
	{
	}

	[Token(Token = "0x601226B")]
	[Address(RVA = "0x2853114", Offset = "0x2853114", VA = "0x2853114")]
	private void CloseNavigation()
	{
	}

	[Token(Token = "0x601226C")]
	[Address(RVA = "0x2851F70", Offset = "0x2851F70", VA = "0x2851F70")]
	private void InitItemTrans()
	{
	}

	[Token(Token = "0x601226D")]
	[Address(RVA = "0x2852664", Offset = "0x2852664", VA = "0x2852664")]
	private void RefreshAvatar()
	{
	}

	[Token(Token = "0x601226E")]
	[Address(RVA = "0x28525D8", Offset = "0x28525D8", VA = "0x28525D8")]
	private void RefreshUIView(bool isNotifyRefresh = false)
	{
	}

	[Token(Token = "0x601226F")]
	[Address(RVA = "0x2853E58", Offset = "0x2853E58", VA = "0x2853E58", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012270")]
	[Address(RVA = "0x2853EBC", Offset = "0x2853EBC", VA = "0x2853EBC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012271")]
	[Address(RVA = "0x2852ABC", Offset = "0x2852ABC", VA = "0x2852ABC")]
	private void RewardsAutoOpen(UINavigationData navigationDat)
	{
	}

	[Token(Token = "0x6012272")]
	[Address(RVA = "0x2853BD4", Offset = "0x2853BD4", VA = "0x2853BD4")]
	private void RefreshTime()
	{
	}

	[Token(Token = "0x6012273")]
	[Address(RVA = "0x2853204", Offset = "0x2853204", VA = "0x2853204")]
	private void RefreshVeteranBundle()
	{
	}

	[Token(Token = "0x6012274")]
	[Address(RVA = "0x28532E0", Offset = "0x28532E0", VA = "0x28532E0")]
	private void RefreshTaskActiviness()
	{
	}

	[Token(Token = "0x6012275")]
	[Address(RVA = "0x28535E4", Offset = "0x28535E4", VA = "0x28535E4")]
	private void RefreshDailyNotes()
	{
	}

	[Token(Token = "0x6012276")]
	[Address(RVA = "0x2853A9C", Offset = "0x2853A9C", VA = "0x2853A9C")]
	private void RefreshSlots(bool isNotifyRefresh = false)
	{
	}

	[Token(Token = "0x6012277")]
	[Address(RVA = "0x2854884", Offset = "0x2854884", VA = "0x2854884")]
	private void OnVeteranCountDownEnd()
	{
	}

	[Token(Token = "0x6012278")]
	[Address(RVA = "0x2853F20", Offset = "0x2853F20", VA = "0x2853F20")]
	private void OnVeteranSignClick()
	{
	}

	[Token(Token = "0x6012279")]
	[Address(RVA = "0x2854934", Offset = "0x2854934", VA = "0x2854934")]
	private void OnVeteranShopClick()
	{
	}

	[Token(Token = "0x601227A")]
	[Address(RVA = "0x2854B18", Offset = "0x2854B18", VA = "0x2854B18")]
	private void OnIntroductionBtnClick()
	{
	}

	[Token(Token = "0x601227B")]
	[Address(RVA = "0x2854CFC", Offset = "0x2854CFC", VA = "0x2854CFC")]
	private void OnDailyNotesBtnClick()
	{
	}

	[Token(Token = "0x601227C")]
	[Address(RVA = "0x285522C", Offset = "0x285522C", VA = "0x285522C")]
	private void OnTaskBtnClick()
	{
	}

	[Token(Token = "0x601227D")]
	[Address(RVA = "0x28558CC", Offset = "0x28558CC", VA = "0x28558CC")]
	private void GotoTask()
	{
	}

	[Token(Token = "0x601227E")]
	[Address(RVA = "0x2855A78", Offset = "0x2855A78", VA = "0x2855A78")]
	private void OnTokenClick()
	{
	}

	[Token(Token = "0x601227F")]
	[Address(RVA = "0x2855CBC", Offset = "0x2855CBC", VA = "0x2855CBC")]
	private void OnTokenClick2()
	{
	}

	[Token(Token = "0x6012280")]
	[Address(RVA = "0x285557C", Offset = "0x285557C", VA = "0x285557C")]
	private void OnChooseBtnClick()
	{
	}

	[Token(Token = "0x6012281")]
	[Address(RVA = "0x2855F00", Offset = "0x2855F00", VA = "0x2855F00")]
	private void GotoChoose()
	{
	}

	[Token(Token = "0x6012282")]
	[Address(RVA = "0x28560DC", Offset = "0x28560DC", VA = "0x28560DC", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012283")]
	[Address(RVA = "0x28562E8", Offset = "0x28562E8", VA = "0x28562E8", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012284")]
	[Address(RVA = "0x28563A0", Offset = "0x28563A0", VA = "0x28563A0", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6012285")]
	[Address(RVA = "0x2856410", Offset = "0x2856410", VA = "0x2856410", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6012286")]
	[Address(RVA = "0x2856468", Offset = "0x2856468", VA = "0x2856468")]
	private void _003COnClose_003Em__0()
	{
	}

	[Token(Token = "0x6012287")]
	[Address(RVA = "0x2856498", Offset = "0x2856498", VA = "0x2856498")]
	private void _003CRefreshTime_003Em__1()
	{
	}

	[Token(Token = "0x6012288")]
	[Address(RVA = "0x28564FC", Offset = "0x28564FC", VA = "0x28564FC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012289")]
	[Address(RVA = "0x2856504", Offset = "0x2856504", VA = "0x2856504")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x601228A")]
	[Address(RVA = "0x285650C", Offset = "0x285650C", VA = "0x285650C")]
	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x601228B")]
	[Address(RVA = "0x2856514", Offset = "0x2856514", VA = "0x2856514")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x601228C")]
	[Address(RVA = "0x285651C", Offset = "0x285651C", VA = "0x285651C")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x601228D")]
	[Address(RVA = "0x2856524", Offset = "0x2856524", VA = "0x2856524")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x601228E")]
	[Address(RVA = "0x285652C", Offset = "0x285652C", VA = "0x285652C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
