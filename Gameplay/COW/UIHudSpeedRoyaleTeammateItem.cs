using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002D42")]
internal class UIHudSpeedRoyaleTeammateItem : MonoBehaviour
{
	[Token(Token = "0x40114E9")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Name;

	[Token(Token = "0x40114EA")]
	[FieldOffset(Offset = "0x10")]
	public GameObject HPBarGO;

	[Token(Token = "0x40114EB")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HP;

	[Token(Token = "0x40114EC")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Mark;

	[Token(Token = "0x40114ED")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject KillerGO;

	[Token(Token = "0x40114EE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TeamIndex;

	[Token(Token = "0x40114EF")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Offline;

	[Token(Token = "0x40114F0")]
	[FieldOffset(Offset = "0x28")]
	public UISprite DisFlag;

	[Token(Token = "0x40114F1")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject VoiceGO;

	[Token(Token = "0x40114F2")]
	[FieldOffset(Offset = "0x30")]
	private ETeammateState m_CurrentState;

	[Token(Token = "0x6012EF8")]
	[Address(RVA = "0x1FDF7FC", Offset = "0x1FDF7FC", VA = "0x1FDF7FC")]
	public UIHudSpeedRoyaleTeammateItem()
	{
	}

	[Token(Token = "0x6012EF9")]
	[Address(RVA = "0x1FDF804", Offset = "0x1FDF804", VA = "0x1FDF804")]
	public void Show(bool v)
	{
	}

	[Token(Token = "0x6012EFA")]
	[Address(RVA = "0x1FDF894", Offset = "0x1FDF894", VA = "0x1FDF894")]
	public void InitInfo(Player p)
	{
	}

	[Token(Token = "0x6012EFB")]
	[Address(RVA = "0x1FE0408", Offset = "0x1FE0408", VA = "0x1FE0408")]
	public void InitWithPlayerInfo(MNJIFKDNEKI playerInfo)
	{
	}

	[Token(Token = "0x6012EFC")]
	[Address(RVA = "0x1FE0384", Offset = "0x1FE0384", VA = "0x1FE0384")]
	public void SetVoiceVisible(bool flag)
	{
	}

	[Token(Token = "0x6012EFD")]
	[Address(RVA = "0x1FE06E0", Offset = "0x1FE06E0", VA = "0x1FE06E0")]
	public void SetMarkShow(bool show)
	{
	}

	[Token(Token = "0x6012EFE")]
	[Address(RVA = "0x1FE018C", Offset = "0x1FE018C", VA = "0x1FE018C")]
	public void SetTeammateState(ETeammateState nextState)
	{
	}

	[Token(Token = "0x6012EFF")]
	[Address(RVA = "0x1FE0050", Offset = "0x1FE0050", VA = "0x1FE0050")]
	public void SetDisconnected(bool disconnected)
	{
	}

	[Token(Token = "0x6012F00")]
	[Address(RVA = "0x1FDFE04", Offset = "0x1FDFE04", VA = "0x1FDFE04")]
	public void OnHPChanged(Player p)
	{
	}
}
