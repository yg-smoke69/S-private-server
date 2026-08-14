using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200333D")]
internal class UIZombiePlusGameScene : UIInGameScene
{
	[Token(Token = "0x401386F")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudBigHintController m_BigHintController;

	[Token(Token = "0x6015C48")]
	[Address(RVA = "0x1A355FC", Offset = "0x1A355FC", VA = "0x1A355FC")]
	public UIZombiePlusGameScene()
	{
	}

	[Token(Token = "0x6015C49")]
	[Address(RVA = "0x1A35680", Offset = "0x1A35680", VA = "0x1A35680", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015C4A")]
	[Address(RVA = "0x1A357B4", Offset = "0x1A357B4", VA = "0x1A357B4", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015C4B")]
	[Address(RVA = "0x1A358E8", Offset = "0x1A358E8", VA = "0x1A358E8", Slot = "17")]
	public override void OpenHud()
	{
	}

	[Token(Token = "0x6015C4C")]
	[Address(RVA = "0x1A35A20", Offset = "0x1A35A20", VA = "0x1A35A20", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015C4D")]
	[Address(RVA = "0x1A35AFC", Offset = "0x1A35AFC", VA = "0x1A35AFC")]
	public void OnOpenBigHintTips(object[] data)
	{
	}

	[Token(Token = "0x6015C4E")]
	[Address(RVA = "0x1A35D54", Offset = "0x1A35D54", VA = "0x1A35D54")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015C4F")]
	[Address(RVA = "0x1A35D5C", Offset = "0x1A35D5C", VA = "0x1A35D5C")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015C50")]
	[Address(RVA = "0x1A35D64", Offset = "0x1A35D64", VA = "0x1A35D64")]
	public void _003C_003EiFixBaseProxy_OpenHud()
	{
	}

	[Token(Token = "0x6015C51")]
	[Address(RVA = "0x1A35D6C", Offset = "0x1A35D6C", VA = "0x1A35D6C")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
