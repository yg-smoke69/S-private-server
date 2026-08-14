using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002ACF")]
public class UIReplayNodeController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002AD0")]
	private sealed class _003CTryRepairReplayInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010700")]
		[FieldOffset(Offset = "0x8")]
		internal MobileReplayInfo replayInfo;

		[Token(Token = "0x60118BC")]
		[Address(RVA = "0x1E56828", Offset = "0x1E56828", VA = "0x1E56828")]
		public _003CTryRepairReplayInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60118BD")]
		[Address(RVA = "0x1E56A34", Offset = "0x1E56A34", VA = "0x1E56A34")]
		internal bool _003C_003Em__0(MatchRecordPersonal v)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40106FB")]
	[FieldOffset(Offset = "0x28")]
	private UIReplayNodeView m_View;

	[Token(Token = "0x40106FC")]
	private const string FIRST_OPEN_KEY = "FIRST_OPEN_REPLAY_NODE";

	[Token(Token = "0x40106FD")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsFirstOpenController;

	[Token(Token = "0x40106FE")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_ReplayEnableWhenOpen;

	[Token(Token = "0x40106FF")]
	[FieldOffset(Offset = "0x30")]
	private EReplayNodeShowType m_ReplayNodeShowType;

	[Token(Token = "0x60118AC")]
	[Address(RVA = "0x1E54910", Offset = "0x1E54910", VA = "0x1E54910")]
	public UIReplayNodeController()
	{
	}

	[Token(Token = "0x60118AD")]
	[Address(RVA = "0x1E54994", Offset = "0x1E54994", VA = "0x1E54994", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60118AE")]
	[Address(RVA = "0x1E55188", Offset = "0x1E55188", VA = "0x1E55188", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60118AF")]
	[Address(RVA = "0x1E5537C", Offset = "0x1E5537C", VA = "0x1E5537C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60118B0")]
	[Address(RVA = "0x1E55420", Offset = "0x1E55420", VA = "0x1E55420")]
	public void RefreshReplayData([Optional] object[] data)
	{
	}

	[Token(Token = "0x60118B1")]
	[Address(RVA = "0x1E55764", Offset = "0x1E55764", VA = "0x1E55764")]
	private void UpdateReplayMemory()
	{
	}

	[Token(Token = "0x60118B2")]
	[Address(RVA = "0x1E55A50", Offset = "0x1E55A50", VA = "0x1E55A50")]
	private float FormatPlatformMemory(long value)
	{
		return default(float);
	}

	[Token(Token = "0x60118B3")]
	[Address(RVA = "0x1E55AF0", Offset = "0x1E55AF0", VA = "0x1E55AF0")]
	private void OnClickTipsBtn()
	{
	}

	[Token(Token = "0x60118B4")]
	[Address(RVA = "0x1E55D38", Offset = "0x1E55D38", VA = "0x1E55D38")]
	private void OnToggleBtnClick()
	{
	}

	[Token(Token = "0x60118B5")]
	[Address(RVA = "0x1E56058", Offset = "0x1E56058", VA = "0x1E56058")]
	private void OnShowReplayTypeClick()
	{
	}

	[Token(Token = "0x60118B6")]
	[Address(RVA = "0x1E56278", Offset = "0x1E56278", VA = "0x1E56278")]
	public void TryRepairReplayInfo()
	{
	}

	[Token(Token = "0x60118B7")]
	[Address(RVA = "0x1E56830", Offset = "0x1E56830", VA = "0x1E56830")]
	private bool CheckIsReplayInfoNotMatchResult(MobileReplayInfo replayInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60118B8")]
	[Address(RVA = "0x1E568B0", Offset = "0x1E568B0", VA = "0x1E568B0", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60118B9")]
	[Address(RVA = "0x1E569A8", Offset = "0x1E569A8", VA = "0x1E569A8", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60118BA")]
	[Address(RVA = "0x1E56A24", Offset = "0x1E56A24", VA = "0x1E56A24")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60118BB")]
	[Address(RVA = "0x1E56A2C", Offset = "0x1E56A2C", VA = "0x1E56A2C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
