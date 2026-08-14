using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002197")]
internal class UIHudLudoGamePlayerDetailInfoLstController : UIBaseController
{
	[Token(Token = "0x400D276")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLudoGamePlayerDetailInfoLstView m_View;

	[Token(Token = "0x400D277")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<IHAAMHPPLMG, UIHudLudoGamePlayerDetailItemController> m_PlayerDic;

	[Token(Token = "0x400D278")]
	[FieldOffset(Offset = "0x30")]
	private float m_ItemPosX;

	[Token(Token = "0x400D279")]
	[FieldOffset(Offset = "0x34")]
	private float m_ItemOffset;

	[Token(Token = "0x400D27A")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<UIHudLudoGamePlayerDetailItemController> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B259")]
	[Address(RVA = "0xFF47B8", Offset = "0xFF47B8", VA = "0xFF47B8")]
	public UIHudLudoGamePlayerDetailInfoLstController()
	{
	}

	[Token(Token = "0x600B25A")]
	[Address(RVA = "0xFF4870", Offset = "0xFF4870", VA = "0xFF4870")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B25B")]
	[Address(RVA = "0xFF4914", Offset = "0xFF4914", VA = "0xFF4914", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B25C")]
	[Address(RVA = "0xFF4C68", Offset = "0xFF4C68", VA = "0xFF4C68", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B25D")]
	[Address(RVA = "0xFF4E6C", Offset = "0xFF4E6C", VA = "0xFF4E6C")]
	private void OnAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x600B25E")]
	[Address(RVA = "0xFF5A84", Offset = "0xFF5A84", VA = "0xFF5A84")]
	private void ResetPlayerItemPos()
	{
	}

	[Token(Token = "0x600B25F")]
	[Address(RVA = "0xFF5D14", Offset = "0xFF5D14", VA = "0xFF5D14")]
	private void OnPlayerStateChange(object[] data)
	{
	}

	[Token(Token = "0x600B260")]
	[Address(RVA = "0xFF5EB4", Offset = "0xFF5EB4", VA = "0xFF5EB4")]
	private void OnPlayerChessFinished(object[] data)
	{
	}

	[Token(Token = "0x600B261")]
	[Address(RVA = "0xFF6188", Offset = "0xFF6188", VA = "0xFF6188")]
	private static int _003CResetPlayerItemPos_003Em__0(UIHudLudoGamePlayerDetailItemController a, UIHudLudoGamePlayerDetailItemController b)
	{
		return default(int);
	}

	[Token(Token = "0x600B262")]
	[Address(RVA = "0xFF61C8", Offset = "0xFF61C8", VA = "0xFF61C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B263")]
	[Address(RVA = "0xFF61D0", Offset = "0xFF61D0", VA = "0xFF61D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
