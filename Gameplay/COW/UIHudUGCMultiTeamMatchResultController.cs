using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002258")]
internal class UIHudUGCMultiTeamMatchResultController : UIHudMatchResultBaseController, _Attribute
{
	[Token(Token = "0x400D6F3")]
	[FieldOffset(Offset = "0x18C")]
	private UIHudUGCMultiTeamMatchResultView m_View;

	[Token(Token = "0x400D6F4")]
	[FieldOffset(Offset = "0x190")]
	private uint m_DelayID;

	[Token(Token = "0x400D6F5")]
	[FieldOffset(Offset = "0x194")]
	private int[] m_RankToScoreRule;

	[Token(Token = "0x400D6F6")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D6F7")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600BB6E")]
	[Address(RVA = "0x1A5FF50", Offset = "0x1A5FF50", VA = "0x1A5FF50")]
	public UIHudUGCMultiTeamMatchResultController()
	{
	}

	[Token(Token = "0x600BB6F")]
	[Address(RVA = "0x1A5FF70", Offset = "0x1A5FF70", VA = "0x1A5FF70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB70")]
	[Address(RVA = "0x1A60018", Offset = "0x1A60018", VA = "0x1A60018")]
	public bool IsSelfTeam(ulong teamIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600BB71")]
	[Address(RVA = "0x1A600C0", Offset = "0x1A600C0", VA = "0x1A600C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BB72")]
	[Address(RVA = "0x1A606F8", Offset = "0x1A606F8", VA = "0x1A606F8", Slot = "50")]
	protected override void OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BB73")]
	[Address(RVA = "0x1A6085C", Offset = "0x1A6085C", VA = "0x1A6085C", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600BB74")]
	[Address(RVA = "0x1A60F2C", Offset = "0x1A60F2C", VA = "0x1A60F2C", Slot = "49")]
	protected override void OnShowDetailUI(bool show)
	{
	}

	[Token(Token = "0x600BB75")]
	[Address(RVA = "0x1A60B38", Offset = "0x1A60B38", VA = "0x1A60B38")]
	private void SetMatch(UGCMatchStats matchStats)
	{
	}

	[Token(Token = "0x600BB76")]
	[Address(RVA = "0x1A6148C", Offset = "0x1A6148C", VA = "0x1A6148C", Slot = "57")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600BB77")]
	[Address(RVA = "0x1A61694", Offset = "0x1A61694", VA = "0x1A61694", Slot = "58")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600BB78")]
	[Address(RVA = "0x1A61710", Offset = "0x1A61710", VA = "0x1A61710")]
	private bool _003CRefreshDetailUI_003Em__0(UGCTeamStats item)
	{
		return default(bool);
	}

	[Token(Token = "0x600BB79")]
	[Address(RVA = "0x1A61778", Offset = "0x1A61778", VA = "0x1A61778")]
	private static void _003COnShowDetailUI_003Em__1()
	{
	}

	[Token(Token = "0x600BB7A")]
	[Address(RVA = "0x1A618C4", Offset = "0x1A618C4", VA = "0x1A618C4")]
	private static void _003COnShowDetailUI_003Em__2()
	{
	}

	[Token(Token = "0x600BB7B")]
	[Address(RVA = "0x1A61A10", Offset = "0x1A61A10", VA = "0x1A61A10")]
	private bool _003CSetMatch_003Em__3(UGCTeamStats item)
	{
		return default(bool);
	}

	[Token(Token = "0x600BB7C")]
	[Address(RVA = "0x1A61A78", Offset = "0x1A61A78", VA = "0x1A61A78")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BB7D")]
	[Address(RVA = "0x1A61A80", Offset = "0x1A61A80", VA = "0x1A61A80")]
	public void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BB7E")]
	[Address(RVA = "0x1A61A88", Offset = "0x1A61A88", VA = "0x1A61A88")]
	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	[Token(Token = "0x600BB7F")]
	[Address(RVA = "0x1A61A90", Offset = "0x1A61A90", VA = "0x1A61A90")]
	public void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}
}
