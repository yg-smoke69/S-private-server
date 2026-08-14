using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002194")]
public class UIHUDLudoGameController : UIBaseController
{
	[Token(Token = "0x400D26B")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDLudoGameInfoView m_View;

	[Token(Token = "0x400D26C")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, UIHUDLudoGamePlayerHeadInfoController> headInfoCtrls;

	[Token(Token = "0x400D26D")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsTrust;

	[Token(Token = "0x400D26E")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsRandom;

	[Token(Token = "0x600B22B")]
	[Address(RVA = "0x167A8F4", Offset = "0x167A8F4", VA = "0x167A8F4")]
	public UIHUDLudoGameController()
	{
	}

	[Token(Token = "0x600B22C")]
	[Address(RVA = "0x167A9AC", Offset = "0x167A9AC", VA = "0x167A9AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B22D")]
	[Address(RVA = "0x167AA50", Offset = "0x167AA50", VA = "0x167AA50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B22E")]
	[Address(RVA = "0x167AEC8", Offset = "0x167AEC8", VA = "0x167AEC8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B22F")]
	[Address(RVA = "0x167B19C", Offset = "0x167B19C", VA = "0x167B19C")]
	private void ShowRandom(object[] data)
	{
	}

	[Token(Token = "0x600B230")]
	[Address(RVA = "0x167B430", Offset = "0x167B430", VA = "0x167B430")]
	private void ShowTrust(object[] data)
	{
	}

	[Token(Token = "0x600B231")]
	[Address(RVA = "0x167B680", Offset = "0x167B680", VA = "0x167B680")]
	private void OnClickTrust()
	{
	}

	[Token(Token = "0x600B232")]
	[Address(RVA = "0x167B834", Offset = "0x167B834", VA = "0x167B834")]
	private void OnClickManual()
	{
	}

	[Token(Token = "0x600B233")]
	[Address(RVA = "0x167B9E8", Offset = "0x167B9E8", VA = "0x167B9E8")]
	private void OnClickLudoRandom()
	{
	}

	[Token(Token = "0x600B234")]
	[Address(RVA = "0x167BB54", Offset = "0x167BB54", VA = "0x167BB54")]
	private Transform GetItemTransform(uint index)
	{
		return null;
	}

	[Token(Token = "0x600B235")]
	[Address(RVA = "0x167BC54", Offset = "0x167BC54", VA = "0x167BC54")]
	private void AddPlayerList(Dictionary<uint, INMLKEJBEEH> players)
	{
	}

	[Token(Token = "0x600B236")]
	[Address(RVA = "0x167C498", Offset = "0x167C498", VA = "0x167C498")]
	private void UIAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x600B237")]
	[Address(RVA = "0x167BE2C", Offset = "0x167BE2C", VA = "0x167BE2C")]
	private void AddPlayer(INMLKEJBEEH ludoPlayer)
	{
	}

	[Token(Token = "0x600B238")]
	[Address(RVA = "0x167CDCC", Offset = "0x167CDCC", VA = "0x167CDCC")]
	private void UpdateHeadPos(Transform head, LudoPlayerHeadPos pos)
	{
	}

	[Token(Token = "0x600B239")]
	[Address(RVA = "0x167D058", Offset = "0x167D058", VA = "0x167D058")]
	private void UIUpdatePlayerStateAndTime(object[] data)
	{
	}

	[Token(Token = "0x600B23A")]
	[Address(RVA = "0x167D634", Offset = "0x167D634", VA = "0x167D634")]
	private void OnPlayerStateChange(object[] data)
	{
	}

	[Token(Token = "0x600B23B")]
	[Address(RVA = "0x167D1B8", Offset = "0x167D1B8", VA = "0x167D1B8")]
	private void UpdatePlayerStateAndTime(uint playerID, MDMMGPMJHJG state, float endTime)
	{
	}

	[Token(Token = "0x600B23C")]
	[Address(RVA = "0x167DF68", Offset = "0x167DF68", VA = "0x167DF68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B23D")]
	[Address(RVA = "0x167DF70", Offset = "0x167DF70", VA = "0x167DF70")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
