using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003339")]
internal class UITutorialCSGameScene : UICSGameScene
{
	[Token(Token = "0x4013850")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudTutorialMainTaskGuideController m_TutorialMainTaskCtrl;

	[Token(Token = "0x4013851")]
	[FieldOffset(Offset = "0x2D0")]
	private Action m_actTutorialCSPauseGameFunc;

	[Token(Token = "0x6015BE9")]
	[Address(RVA = "0x1C39F3C", Offset = "0x1C39F3C", VA = "0x1C39F3C")]
	public UITutorialCSGameScene()
	{
	}

	[Token(Token = "0x6015BEA")]
	[Address(RVA = "0x1C39F44", Offset = "0x1C39F44", VA = "0x1C39F44", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BEB")]
	[Address(RVA = "0x1C3A078", Offset = "0x1C3A078", VA = "0x1C3A078", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015BEC")]
	[Address(RVA = "0x1C3A1AC", Offset = "0x1C3A1AC", VA = "0x1C3A1AC", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015BED")]
	[Address(RVA = "0x1C3A288", Offset = "0x1C3A288", VA = "0x1C3A288")]
	private void OnShowTutorialMainTaskShow(object[] data)
	{
	}

	[Token(Token = "0x6015BEE")]
	[Address(RVA = "0x1C3A534", Offset = "0x1C3A534", VA = "0x1C3A534")]
	public void RegisterCloseLoadingMaskFunc(Action tutorialCsPauseGameFunc)
	{
	}

	[Token(Token = "0x6015BEF")]
	[Address(RVA = "0x1C3A594", Offset = "0x1C3A594", VA = "0x1C3A594", Slot = "16")]
	protected override void OnMaskClosed()
	{
	}

	[Token(Token = "0x6015BF0")]
	[Address(RVA = "0x1C3A614", Offset = "0x1C3A614", VA = "0x1C3A614")]
	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BF1")]
	[Address(RVA = "0x1C3A61C", Offset = "0x1C3A61C", VA = "0x1C3A61C")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015BF2")]
	[Address(RVA = "0x1C3A624", Offset = "0x1C3A624", VA = "0x1C3A624")]
	public new Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015BF3")]
	[Address(RVA = "0x1C3A62C", Offset = "0x1C3A62C", VA = "0x1C3A62C")]
	public void _003C_003EiFixBaseProxy_OnMaskClosed()
	{
	}
}
