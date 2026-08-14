using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002106")]
public class UIGachaBooyahDayController : UINavigationController, _Attribute
{
	[Token(Token = "0x400CE96")]
	public const string SHOW_ANIM_KEY = "ShowAnim_Gacha_";

	[Token(Token = "0x400CE97")]
	[FieldOffset(Offset = "0x68")]
	private UIGachaBooyahDayView m_View;

	[Token(Token = "0x400CE98")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400CE99")]
	[FieldOffset(Offset = "0x70")]
	private uint m_GachaID;

	[Token(Token = "0x400CE9A")]
	[FieldOffset(Offset = "0x74")]
	private bool m_FirstEnterFlag;

	[Token(Token = "0x400CE9B")]
	[FieldOffset(Offset = "0x78")]
	private AdType m_CurGachaBGType;

	[Token(Token = "0x400CE9C")]
	[FieldOffset(Offset = "0x7C")]
	private UIGachalegendaryBooyahDayContentController m_legendaryContentCtrl;

	[Token(Token = "0x400CE9D")]
	[FieldOffset(Offset = "0x80")]
	private UIGachaContentBase m_CurContent;

	[Token(Token = "0x400CE9E")]
	[FieldOffset(Offset = "0x84")]
	private uint m_RewardPoolJumpItmID;

	[Token(Token = "0x400CE9F")]
	[FieldOffset(Offset = "0x88")]
	private uint m_RewardPoolSelectedItmID;

	[Token(Token = "0x400CEA0")]
	[FieldOffset(Offset = "0x8C")]
	private UIGachaPreviewController m_RewardPoolCtrl;

	[Token(Token = "0x400CEA1")]
	[FieldOffset(Offset = "0x90")]
	private UIGachaPreviewManager m_GachaPreviewManager;

	[Token(Token = "0x400CEA2")]
	[FieldOffset(Offset = "0x94")]
	private bool m_HasShowFullScreenPreview;

	[Token(Token = "0x400CEA3")]
	[FieldOffset(Offset = "0x98")]
	private List<UIGachaCouponTipsController> m_CouponItemList;

	[Token(Token = "0x400CEA4")]
	[FieldOffset(Offset = "0x9C")]
	private int m_CurrentOwnedCouponTypeCnt;

	[Token(Token = "0x400CEA5")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_PostEffectDisabled;

	[Token(Token = "0x400CEA6")]
	[FieldOffset(Offset = "0xA1")]
	private bool m_EnterSourceIsGachaTab;

	[Token(Token = "0x400CEA7")]
	[FieldOffset(Offset = "0xA4")]
	private float m_CGPlayTime;

	[Token(Token = "0x400CEA8")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_IsActive;

	[Token(Token = "0x400CEA9")]
	[FieldOffset(Offset = "0xAC")]
	private new GameObject m_BGVFX;

	[Token(Token = "0x600ABB5")]
	[Address(RVA = "0x265B498", Offset = "0x265B498", VA = "0x265B498")]
	public UIGachaBooyahDayController()
	{
	}

	[Token(Token = "0x600ABB6")]
	[Address(RVA = "0x265B550", Offset = "0x265B550", VA = "0x265B550")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ABB7")]
	[Address(RVA = "0x265B5F4", Offset = "0x265B5F4", VA = "0x265B5F4")]
	public void Update()
	{
	}

	[Token(Token = "0x600ABB8")]
	[Address(RVA = "0x265B698", Offset = "0x265B698", VA = "0x265B698", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600ABB9")]
	[Address(RVA = "0x265B798", Offset = "0x265B798", VA = "0x265B798", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600ABBA")]
	[Address(RVA = "0x265BA34", Offset = "0x265BA34", VA = "0x265BA34", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600ABBB")]
	[Address(RVA = "0x265C298", Offset = "0x265C298", VA = "0x265C298", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ABBC")]
	[Address(RVA = "0x265E0BC", Offset = "0x265E0BC", VA = "0x265E0BC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600ABBD")]
	[Address(RVA = "0x265E140", Offset = "0x265E140", VA = "0x265E140", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ABBE")]
	[Address(RVA = "0x265EC5C", Offset = "0x265EC5C", VA = "0x265EC5C", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600ABBF")]
	[Address(RVA = "0x266098C", Offset = "0x266098C", VA = "0x266098C")]
	private void OnRuleClicked(object[] param)
	{
	}

	[Token(Token = "0x600ABC0")]
	[Address(RVA = "0x2660BE0", Offset = "0x2660BE0", VA = "0x2660BE0")]
	private void OnExchangeActivityBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600ABC1")]
	[Address(RVA = "0x2660D64", Offset = "0x2660D64", VA = "0x2660D64")]
	private void OnAnimPlayBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600ABC2")]
	[Address(RVA = "0x2661030", Offset = "0x2661030", VA = "0x2661030")]
	private void OnCDNChangeBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600ABC3")]
	[Address(RVA = "0x2661EB0", Offset = "0x2661EB0", VA = "0x2661EB0")]
	private void OnChangeLegendaryAvatar(object[] param)
	{
	}

	[Token(Token = "0x600ABC4")]
	[Address(RVA = "0x2661FBC", Offset = "0x2661FBC", VA = "0x2661FBC")]
	private void OnPropsClick(object[] param)
	{
	}

	[Token(Token = "0x600ABC5")]
	[Address(RVA = "0x2662808", Offset = "0x2662808", VA = "0x2662808")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600ABC6")]
	[Address(RVA = "0x2662914", Offset = "0x2662914", VA = "0x2662914")]
	private void OnBtnTokenClick()
	{
	}

	[Token(Token = "0x600ABC7")]
	[Address(RVA = "0x26629FC", Offset = "0x26629FC", VA = "0x26629FC")]
	private void OnPropsClose()
	{
	}

	[Token(Token = "0x600ABC8")]
	[Address(RVA = "0x2662A8C", Offset = "0x2662A8C", VA = "0x2662A8C")]
	private void OnInterfaceMackClick()
	{
	}

	[Token(Token = "0x600ABC9")]
	[Address(RVA = "0x2662B90", Offset = "0x2662B90", VA = "0x2662B90")]
	private void OnInterfaceContentMaskClick()
	{
	}

	[Token(Token = "0x600ABCA")]
	[Address(RVA = "0x265C064", Offset = "0x265C064", VA = "0x265C064")]
	private void RefreshGachaScene()
	{
	}

	[Token(Token = "0x600ABCB")]
	[Address(RVA = "0x2661220", Offset = "0x2661220", VA = "0x2661220")]
	private bool CheckNeedPlayAnimByDateAndOptionalAbs()
	{
		return default(bool);
	}

	[Token(Token = "0x600ABCC")]
	[Address(RVA = "0x2663604", Offset = "0x2663604", VA = "0x2663604")]
	private void RefreshUIScene()
	{
	}

	[Token(Token = "0x600ABCD")]
	[Address(RVA = "0x26637AC", Offset = "0x26637AC", VA = "0x26637AC")]
	private void RefreshGachaBG()
	{
	}

	[Token(Token = "0x600ABCE")]
	[Address(RVA = "0x2660450", Offset = "0x2660450", VA = "0x2660450")]
	private void RefreshAnimPlayBtnView()
	{
	}

	[Token(Token = "0x600ABCF")]
	[Address(RVA = "0x2664158", Offset = "0x2664158", VA = "0x2664158")]
	private void RefreshShowChangePlayBtnView()
	{
	}

	[Token(Token = "0x600ABD0")]
	[Address(RVA = "0x265F758", Offset = "0x265F758", VA = "0x265F758")]
	private void RefreshTokenView()
	{
	}

	[Token(Token = "0x600ABD1")]
	[Address(RVA = "0x265F8D4", Offset = "0x265F8D4", VA = "0x265F8D4")]
	private void RefreshPropsView()
	{
	}

	[Token(Token = "0x600ABD2")]
	[Address(RVA = "0x2663C00", Offset = "0x2663C00", VA = "0x2663C00")]
	private void RefreshContentView()
	{
	}

	[Token(Token = "0x600ABD3")]
	[Address(RVA = "0x26643C0", Offset = "0x26643C0", VA = "0x26643C0")]
	private void HideViewOnPlayAnimtion(object[] param)
	{
	}

	[Token(Token = "0x600ABD4")]
	[Address(RVA = "0x265DFAC", Offset = "0x265DFAC", VA = "0x265DFAC")]
	private void SetTopRight(bool active = true)
	{
	}

	[Token(Token = "0x600ABD5")]
	[Address(RVA = "0x26646AC", Offset = "0x26646AC", VA = "0x26646AC")]
	private void ShowViewOnOverAnimtion(object[] param)
	{
	}

	[Token(Token = "0x600ABD6")]
	[Address(RVA = "0x2662E38", Offset = "0x2662E38", VA = "0x2662E38")]
	private UIGachaContentBase GetGachaContent(ELottery.Type type)
	{
		return null;
	}

	[Token(Token = "0x600ABD7")]
	[Address(RVA = "0x265F364", Offset = "0x265F364", VA = "0x265F364")]
	private void CheckGachaOpen()
	{
	}

	[Token(Token = "0x600ABD8")]
	[Address(RVA = "0x265F58C", Offset = "0x265F58C", VA = "0x265F58C")]
	private void CheckAwardIsExist()
	{
	}

	[Token(Token = "0x600ABD9")]
	[Address(RVA = "0x2663040", Offset = "0x2663040", VA = "0x2663040")]
	private bool TryShowTutorialWnd([Optional] Action CloseCallBack)
	{
		return default(bool);
	}

	[Token(Token = "0x600ABDA")]
	[Address(RVA = "0x266497C", Offset = "0x266497C", VA = "0x266497C")]
	private void OnWebViewClose()
	{
	}

	[Token(Token = "0x600ABDB")]
	[Address(RVA = "0x2664CEC", Offset = "0x2664CEC", VA = "0x2664CEC")]
	private void OnOpenRewardPanel(object[] data)
	{
	}

	[Token(Token = "0x600ABDC")]
	[Address(RVA = "0x2664D48", Offset = "0x2664D48", VA = "0x2664D48")]
	private void OnCloseRewardPanel(object[] data)
	{
	}

	[Token(Token = "0x600ABDD")]
	[Address(RVA = "0x2664EC0", Offset = "0x2664EC0", VA = "0x2664EC0")]
	private void OnGachaAnimSkip(object[] data)
	{
	}

	[Token(Token = "0x600ABDE")]
	[Address(RVA = "0x26645B4", Offset = "0x26645B4", VA = "0x26645B4")]
	public void PlayShowAnim(bool isShow)
	{
	}

	[Token(Token = "0x600ABDF")]
	[Address(RVA = "0x265D95C", Offset = "0x265D95C", VA = "0x265D95C")]
	public void SetInterfaceMaskEnable(object[] param)
	{
	}

	[Token(Token = "0x600ABE0")]
	[Address(RVA = "0x2664F40", Offset = "0x2664F40", VA = "0x2664F40")]
	private void SetInterfaceMaskLabelEnable(bool v)
	{
	}

	[Token(Token = "0x600ABE1")]
	[Address(RVA = "0x265DEE8", Offset = "0x265DEE8", VA = "0x265DEE8")]
	public void SetContentMaskEnable(bool v)
	{
	}

	[Token(Token = "0x600ABE2")]
	[Address(RVA = "0x2664FF8", Offset = "0x2664FF8", VA = "0x2664FF8")]
	public void SetContentMMaskLabelEnable(bool v)
	{
	}

	[Token(Token = "0x600ABE3")]
	[Address(RVA = "0x26650B0", Offset = "0x26650B0", VA = "0x26650B0", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x600ABE4")]
	[Address(RVA = "0x2665108", Offset = "0x2665108", VA = "0x2665108")]
	private void OnRewardPoolClose(object[] data)
	{
	}

	[Token(Token = "0x600ABE5")]
	[Address(RVA = "0x26654B0", Offset = "0x26654B0", VA = "0x26654B0")]
	private void ShowChangeSceneMask()
	{
	}

	[Token(Token = "0x600ABE6")]
	[Address(RVA = "0x265B930", Offset = "0x265B930", VA = "0x265B930")]
	private void CloseRewardPool()
	{
	}

	[Token(Token = "0x600ABE7")]
	[Address(RVA = "0x2665610", Offset = "0x2665610", VA = "0x2665610")]
	private void OnRewardPoolItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600ABE8")]
	[Address(RVA = "0x2665744", Offset = "0x2665744", VA = "0x2665744")]
	private void OnAnimOver(object[] data)
	{
	}

	[Token(Token = "0x600ABE9")]
	[Address(RVA = "0x26658F0", Offset = "0x26658F0", VA = "0x26658F0")]
	private void OnAvatarClear(object[] data)
	{
	}

	[Token(Token = "0x600ABEA")]
	[Address(RVA = "0x2665970", Offset = "0x2665970", VA = "0x2665970")]
	private void OnWeaponCgUIShow(object[] data)
	{
	}

	[Token(Token = "0x600ABEB")]
	[Address(RVA = "0x2665A78", Offset = "0x2665A78", VA = "0x2665A78")]
	private void OnWeaponCgUIHide(object[] data)
	{
	}

	[Token(Token = "0x600ABEC")]
	[Address(RVA = "0x2665AFC", Offset = "0x2665AFC", VA = "0x2665AFC")]
	private void OnRewardPoolOpen(object[] data)
	{
	}

	[Token(Token = "0x600ABED")]
	[Address(RVA = "0x2661928", Offset = "0x2661928", VA = "0x2661928")]
	private void CheckForPlayGachaAnimation()
	{
	}

	[Token(Token = "0x600ABEE")]
	[Address(RVA = "0x2666140", Offset = "0x2666140", VA = "0x2666140")]
	private void OnFullScreenPreviewClose(object[] data)
	{
	}

	[Token(Token = "0x600ABEF")]
	[Address(RVA = "0x26662AC", Offset = "0x26662AC", VA = "0x26662AC")]
	private void OnFullScreenPreviewOpen(object[] data)
	{
	}

	[Token(Token = "0x600ABF0")]
	[Address(RVA = "0x266367C", Offset = "0x266367C", VA = "0x266367C")]
	private void DisablePostEffect()
	{
	}

	[Token(Token = "0x600ABF1")]
	[Address(RVA = "0x2666334", Offset = "0x2666334", VA = "0x2666334")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600ABF2")]
	[Address(RVA = "0x266633C", Offset = "0x266633C", VA = "0x266633C")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600ABF3")]
	[Address(RVA = "0x2666344", Offset = "0x2666344", VA = "0x2666344")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ABF4")]
	[Address(RVA = "0x266634C", Offset = "0x266634C", VA = "0x266634C")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600ABF5")]
	[Address(RVA = "0x2666354", Offset = "0x2666354", VA = "0x2666354")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600ABF6")]
	[Address(RVA = "0x266635C", Offset = "0x266635C", VA = "0x266635C")]
	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}
}
