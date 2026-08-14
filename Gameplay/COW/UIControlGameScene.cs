using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003303")]
internal class UIControlGameScene : UITeamModeBaseGameScene
{
	[Token(Token = "0x4013610")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHUDControlModeBuffIconController m_BuffIcon;

	[Token(Token = "0x6015845")]
	[Address(RVA = "0x1EBF530", Offset = "0x1EBF530", VA = "0x1EBF530")]
	public UIControlGameScene()
	{
	}

	[Token(Token = "0x6015846")]
	[Address(RVA = "0x1EBF538", Offset = "0x1EBF538", VA = "0x1EBF538", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015847")]
	[Address(RVA = "0x1EBF828", Offset = "0x1EBF828", VA = "0x1EBF828", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015848")]
	[Address(RVA = "0x1EBF9C4", Offset = "0x1EBF9C4", VA = "0x1EBF9C4", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015849")]
	[Address(RVA = "0x1EBFB60", Offset = "0x1EBFB60", VA = "0x1EBFB60")]
	private void ShowBuffIcon(object[] data)
	{
	}

	[Token(Token = "0x601584A")]
	[Address(RVA = "0x1EBFD44", Offset = "0x1EBFD44", VA = "0x1EBFD44")]
	private void ShowControlLeaderboard(object[] data)
	{
	}

	[Token(Token = "0x601584B")]
	[Address(RVA = "0x1EBFE50", Offset = "0x1EBFE50", VA = "0x1EBFE50", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x601584C")]
	[Address(RVA = "0x1EBFF2C", Offset = "0x1EBFF2C", VA = "0x1EBFF2C")]
	public new void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x601584D")]
	[Address(RVA = "0x1EBFF34", Offset = "0x1EBFF34", VA = "0x1EBFF34")]
	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x601584E")]
	[Address(RVA = "0x1EBFF3C", Offset = "0x1EBFF3C", VA = "0x1EBFF3C")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x601584F")]
	[Address(RVA = "0x1EBFF44", Offset = "0x1EBFF44", VA = "0x1EBFF44")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
