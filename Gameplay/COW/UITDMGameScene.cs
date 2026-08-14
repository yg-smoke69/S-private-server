using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003333")]
internal class UITDMGameScene : UITeamModeBaseGameScene
{
	[Token(Token = "0x4013834")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudGameShowInfoController m_ShowInfoCtrl;

	[Token(Token = "0x6015B91")]
	[Address(RVA = "0x2014C5C", Offset = "0x2014C5C", VA = "0x2014C5C")]
	public UITDMGameScene()
	{
	}

	[Token(Token = "0x6015B92")]
	[Address(RVA = "0x2014CE4", Offset = "0x2014CE4", VA = "0x2014CE4", Slot = "40")]
	protected override void OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015B93")]
	[Address(RVA = "0x2014D70", Offset = "0x2014D70", VA = "0x2014D70", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B94")]
	[Address(RVA = "0x201517C", Offset = "0x201517C", VA = "0x201517C", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015B95")]
	[Address(RVA = "0x2015588", Offset = "0x2015588", VA = "0x2015588", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015B96")]
	[Address(RVA = "0x2015664", Offset = "0x2015664", VA = "0x2015664", Slot = "38")]
	protected override void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015B97")]
	[Address(RVA = "0x2015CD0", Offset = "0x2015CD0", VA = "0x2015CD0")]
	private void _003COnOpenHudInPregame_003Em__0()
	{
	}

	[Token(Token = "0x6015B98")]
	[Address(RVA = "0x2015D94", Offset = "0x2015D94", VA = "0x2015D94")]
	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015B99")]
	[Address(RVA = "0x2015D9C", Offset = "0x2015D9C", VA = "0x2015D9C")]
	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B9A")]
	[Address(RVA = "0x2015DA0", Offset = "0x2015DA0", VA = "0x2015DA0")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015B9B")]
	[Address(RVA = "0x2015DA4", Offset = "0x2015DA4", VA = "0x2015DA4")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015B9C")]
	[Address(RVA = "0x2015DAC", Offset = "0x2015DAC", VA = "0x2015DAC")]
	public new void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}
}
