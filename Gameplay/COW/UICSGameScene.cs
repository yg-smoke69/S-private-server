using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200330E")]
internal class UICSGameScene : UIInGameScene
{
	[Token(Token = "0x401366F")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudBuffIntroController m_BuffIntroCtrl;

	[Token(Token = "0x6015891")]
	[Address(RVA = "0x1453098", Offset = "0x1453098", VA = "0x1453098")]
	public UICSGameScene()
	{
	}

	[Token(Token = "0x6015892")]
	[Address(RVA = "0x145311C", Offset = "0x145311C", VA = "0x145311C", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015893")]
	[Address(RVA = "0x14531F8", Offset = "0x14531F8", VA = "0x14531F8", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015894")]
	[Address(RVA = "0x145332C", Offset = "0x145332C", VA = "0x145332C", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015895")]
	[Address(RVA = "0x1453460", Offset = "0x1453460", VA = "0x1453460")]
	public void OnShowBuffIntro(object[] data)
	{
	}

	[Token(Token = "0x6015896")]
	[Address(RVA = "0x145368C", Offset = "0x145368C", VA = "0x145368C")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015897")]
	[Address(RVA = "0x1453694", Offset = "0x1453694", VA = "0x1453694")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015898")]
	[Address(RVA = "0x145369C", Offset = "0x145369C", VA = "0x145369C")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}
}
