using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003335")]
internal class UITKGameScene : UIInGameScene
{
	[Token(Token = "0x4013839")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudTKScoreInfoController m_UIHudTKScoreInfoController;

	[Token(Token = "0x401383A")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudTKProgressBarController m_UIHudTKProgressBarController;

	[Token(Token = "0x6015BAE")]
	[Address(RVA = "0x2015DB0", Offset = "0x2015DB0", VA = "0x2015DB0")]
	public UITKGameScene()
	{
	}

	[Token(Token = "0x6015BAF")]
	[Address(RVA = "0x2015E34", Offset = "0x2015E34", VA = "0x2015E34", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015BB0")]
	[Address(RVA = "0x2015FFC", Offset = "0x2015FFC", VA = "0x2015FFC", Slot = "38")]
	protected override void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015BB1")]
	[Address(RVA = "0x2016334", Offset = "0x2016334", VA = "0x2016334", Slot = "40")]
	protected override void OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015BB2")]
	[Address(RVA = "0x20163E8", Offset = "0x20163E8", VA = "0x20163E8", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015BB3")]
	[Address(RVA = "0x20164C4", Offset = "0x20164C4", VA = "0x20164C4")]
	private void _003COnOpenHudInPregame_003Em__0()
	{
	}

	[Token(Token = "0x6015BB4")]
	[Address(RVA = "0x2016588", Offset = "0x2016588", VA = "0x2016588")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015BB5")]
	[Address(RVA = "0x2016590", Offset = "0x2016590", VA = "0x2016590")]
	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015BB6")]
	[Address(RVA = "0x2016598", Offset = "0x2016598", VA = "0x2016598")]
	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015BB7")]
	[Address(RVA = "0x20165A0", Offset = "0x20165A0", VA = "0x20165A0")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
