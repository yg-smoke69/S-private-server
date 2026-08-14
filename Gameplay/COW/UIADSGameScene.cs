using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032FC")]
internal class UIADSGameScene : UITeamModeBaseGameScene
{
	[Token(Token = "0x20032FD")]
	private sealed class _003COnSyncBlackMask_003Ec__AnonStorey0
	{
		[Token(Token = "0x40135FF")]
		[FieldOffset(Offset = "0x8")]
		internal Player localPlayer;

		[Token(Token = "0x4013600")]
		[FieldOffset(Offset = "0xC")]
		internal UIADSGameScene _0024this;

		[Token(Token = "0x60157F1")]
		[Address(RVA = "0x29FB2F4", Offset = "0x29FB2F4", VA = "0x29FB2F4")]
		public _003COnSyncBlackMask_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60157F2")]
		[Address(RVA = "0x29FB820", Offset = "0x29FB820", VA = "0x29FB820")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x40135FB")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudADSpaceHintController m_HintController;

	[Token(Token = "0x40135FC")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHudADSBonusCountdownController m_BonusCountdownController;

	[Token(Token = "0x40135FD")]
	[FieldOffset(Offset = "0x2E0")]
	private UIHudADSTeamScoreController m_UIHUDTeamScoreBoardController;

	[Token(Token = "0x40135FE")]
	[FieldOffset(Offset = "0x2E4")]
	private uint showBlackMaskDelayCall;

	[Token(Token = "0x60157E0")]
	[Address(RVA = "0x29FA108", Offset = "0x29FA108", VA = "0x29FA108")]
	public UIADSGameScene()
	{
	}

	[Token(Token = "0x60157E1")]
	[Address(RVA = "0x29FA110", Offset = "0x29FA110", VA = "0x29FA110", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x60157E2")]
	[Address(RVA = "0x29FA378", Offset = "0x29FA378", VA = "0x29FA378", Slot = "40")]
	protected override void OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x60157E3")]
	[Address(RVA = "0x29FA404", Offset = "0x29FA404", VA = "0x29FA404", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60157E4")]
	[Address(RVA = "0x29FA608", Offset = "0x29FA608", VA = "0x29FA608", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x60157E5")]
	[Address(RVA = "0x29FA80C", Offset = "0x29FA80C", VA = "0x29FA80C", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x60157E6")]
	[Address(RVA = "0x29FA8E8", Offset = "0x29FA8E8", VA = "0x29FA8E8")]
	private void OnADSShowHint(object[] param)
	{
	}

	[Token(Token = "0x60157E7")]
	[Address(RVA = "0x29FAA48", Offset = "0x29FAA48", VA = "0x29FAA48")]
	private void OnADSBonusCountdown(object[] param)
	{
	}

	[Token(Token = "0x60157E8")]
	[Address(RVA = "0x29FAC7C", Offset = "0x29FAC7C", VA = "0x29FAC7C")]
	private void OnSyncBlackMask(object[] param)
	{
	}

	[Token(Token = "0x60157E9")]
	[Address(RVA = "0x29FB2FC", Offset = "0x29FB2FC", VA = "0x29FB2FC", Slot = "47")]
	protected override void ShowTeamScore(object[] data)
	{
	}

	[Token(Token = "0x60157EA")]
	[Address(RVA = "0x29FB408", Offset = "0x29FB408", VA = "0x29FB408")]
	public void OnMatchEnd()
	{
	}

	[Token(Token = "0x60157EB")]
	[Address(RVA = "0x29FB7F0", Offset = "0x29FB7F0", VA = "0x29FB7F0")]
	public new void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x60157EC")]
	[Address(RVA = "0x29FB7F8", Offset = "0x29FB7F8", VA = "0x29FB7F8")]
	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x60157ED")]
	[Address(RVA = "0x29FB800", Offset = "0x29FB800", VA = "0x29FB800")]
	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60157EE")]
	[Address(RVA = "0x29FB808", Offset = "0x29FB808", VA = "0x29FB808")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x60157EF")]
	[Address(RVA = "0x29FB810", Offset = "0x29FB810", VA = "0x29FB810")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x60157F0")]
	[Address(RVA = "0x29FB818", Offset = "0x29FB818", VA = "0x29FB818")]
	public void _003C_003EiFixBaseProxy_ShowTeamScore(object[] P0)
	{
	}
}
