using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2003302")]
internal class UIBombGameScene : UIInGameScene
{
	[Token(Token = "0x401360B")]
	[FieldOffset(Offset = "0x2C8")]
	protected UIHudBombMatchInfoController m_BombMatchInfoInfoCtrl;

	[Token(Token = "0x401360C")]
	[FieldOffset(Offset = "0x2CC")]
	public Dictionary<uint, UIHudBombZoneMarkController> m_BombZoneMarkList;

	[Token(Token = "0x401360D")]
	[FieldOffset(Offset = "0x2D0")]
	private uint m_HideCSShopDelayCallID;

	[Token(Token = "0x401360E")]
	[FieldOffset(Offset = "0x2D4")]
	private uint m_ShowCSShopDelayCallID;

	[Token(Token = "0x401360F")]
	[FieldOffset(Offset = "0x2D8")]
	private EPGNANOLPFK m_CurrentPhase;

	[Token(Token = "0x6015833")]
	[Address(RVA = "0x10D79E8", Offset = "0x10D79E8", VA = "0x10D79E8")]
	public UIBombGameScene()
	{
	}

	[Token(Token = "0x6015834")]
	[Address(RVA = "0x10D7AA0", Offset = "0x10D7AA0", VA = "0x10D7AA0", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015835")]
	[Address(RVA = "0x10D7FF8", Offset = "0x10D7FF8", VA = "0x10D7FF8", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015836")]
	[Address(RVA = "0x10D8438", Offset = "0x10D8438", VA = "0x10D8438", Slot = "4")]
	public override void Destory()
	{
	}

	[Token(Token = "0x6015837")]
	[Address(RVA = "0x10D8810", Offset = "0x10D8810", VA = "0x10D8810")]
	private void OnBombNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x6015838")]
	[Address(RVA = "0x10D8E7C", Offset = "0x10D8E7C", VA = "0x10D8E7C", Slot = "26")]
	protected override void ShowCSShop(object[] data)
	{
	}

	[Token(Token = "0x6015839")]
	[Address(RVA = "0x10D921C", Offset = "0x10D921C", VA = "0x10D921C", Slot = "27")]
	protected override void ShowCSShopProcess()
	{
	}

	[Token(Token = "0x601583A")]
	[Address(RVA = "0x10D8C30", Offset = "0x10D8C30", VA = "0x10D8C30")]
	private bool IsFactionChangeRound()
	{
		return default(bool);
	}

	[Token(Token = "0x601583B")]
	[Address(RVA = "0x10D9338", Offset = "0x10D9338", VA = "0x10D9338")]
	public void OnPlayerGetBomb(object[] data)
	{
	}

	[Token(Token = "0x601583C")]
	[Address(RVA = "0x10D9540", Offset = "0x10D9540", VA = "0x10D9540")]
	public void OnBombSettled(object[] data)
	{
	}

	[Token(Token = "0x601583D")]
	[Address(RVA = "0x10D9748", Offset = "0x10D9748", VA = "0x10D9748")]
	public void OnBombZoneInfoChanged(object[] data)
	{
	}

	[Token(Token = "0x601583E")]
	[Address(RVA = "0x10D9B1C", Offset = "0x10D9B1C", VA = "0x10D9B1C", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x601583F")]
	[Address(RVA = "0x10D9BF8", Offset = "0x10D9BF8", VA = "0x10D9BF8")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015840")]
	[Address(RVA = "0x10D9C00", Offset = "0x10D9C00", VA = "0x10D9C00")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015841")]
	[Address(RVA = "0x10D9C08", Offset = "0x10D9C08", VA = "0x10D9C08")]
	public new void _003C_003EiFixBaseProxy_Destory()
	{
	}

	[Token(Token = "0x6015842")]
	[Address(RVA = "0x10D9C10", Offset = "0x10D9C10", VA = "0x10D9C10")]
	public void _003C_003EiFixBaseProxy_ShowCSShop(object[] P0)
	{
	}

	[Token(Token = "0x6015843")]
	[Address(RVA = "0x10D9C18", Offset = "0x10D9C18", VA = "0x10D9C18")]
	public void _003C_003EiFixBaseProxy_ShowCSShopProcess()
	{
	}

	[Token(Token = "0x6015844")]
	[Address(RVA = "0x10D9C20", Offset = "0x10D9C20", VA = "0x10D9C20")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
