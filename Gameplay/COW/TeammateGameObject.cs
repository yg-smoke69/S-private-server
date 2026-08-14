using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D2E")]
public class TeammateGameObject
{
	[Token(Token = "0x401140E")]
	[FieldOffset(Offset = "0x8")]
	public GameObject teammate;

	[Token(Token = "0x401140F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject id;

	[Token(Token = "0x4011410")]
	[FieldOffset(Offset = "0x10")]
	public GameObject direction;

	[Token(Token = "0x4011411")]
	[FieldOffset(Offset = "0x14")]
	public GameObject directionSprite;

	[Token(Token = "0x4011412")]
	[FieldOffset(Offset = "0x18")]
	public GameObject knockdown;

	[Token(Token = "0x4011413")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject dead;

	[Token(Token = "0x4011414")]
	[FieldOffset(Offset = "0x20")]
	public GameObject vehicle;

	[Token(Token = "0x4011415")]
	[FieldOffset(Offset = "0x24")]
	public GameObject quickChatEffect;

	[Token(Token = "0x4011416")]
	[FieldOffset(Offset = "0x28")]
	public GameObject idIndexLabel;

	[Token(Token = "0x4011417")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite inmapShowSpr;

	[Token(Token = "0x4011418")]
	[FieldOffset(Offset = "0x30")]
	private TweenAlpha Firing_Tween;

	[Token(Token = "0x4011419")]
	[FieldOffset(Offset = "0x34")]
	private ETeammateState m_CurrentState;

	[Token(Token = "0x6012E42")]
	[Address(RVA = "0x28A198C", Offset = "0x28A198C", VA = "0x28A198C")]
	public TeammateGameObject(GameObject _teammate)
	{
	}

	[Token(Token = "0x6012E43")]
	[Address(RVA = "0x28A235C", Offset = "0x28A235C", VA = "0x28A235C")]
	private void SetTeamIDVisble(bool visible)
	{
	}

	[Token(Token = "0x6012E44")]
	[Address(RVA = "0x28A2404", Offset = "0x28A2404", VA = "0x28A2404")]
	public ETeammateState GetState()
	{
		return default(ETeammateState);
	}

	[Token(Token = "0x6012E45")]
	[Address(RVA = "0x28A1F48", Offset = "0x28A1F48", VA = "0x28A1F48")]
	public void SetState(ETeammateState nextState, [Optional] List<object> argList)
	{
	}

	[Token(Token = "0x6012E46")]
	[Address(RVA = "0x28A245C", Offset = "0x28A245C", VA = "0x28A245C")]
	public void PlayQuickChatEffect()
	{
	}
}
