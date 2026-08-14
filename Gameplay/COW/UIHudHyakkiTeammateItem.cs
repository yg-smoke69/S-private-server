using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002D40")]
internal class UIHudHyakkiTeammateItem : MonoBehaviour
{
	[Token(Token = "0x40114D4")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Name;

	[Token(Token = "0x40114D5")]
	[FieldOffset(Offset = "0x10")]
	public GameObject HPBarGO;

	[Token(Token = "0x40114D6")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HP;

	[Token(Token = "0x40114D7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Mark;

	[Token(Token = "0x40114D8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject KillerGO;

	[Token(Token = "0x40114D9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TeamIndex;

	[Token(Token = "0x40114DA")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Knockdown;

	[Token(Token = "0x40114DB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Offline;

	[Token(Token = "0x40114DC")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite DisFlag;

	[Token(Token = "0x40114DD")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Vehicle;

	[Token(Token = "0x40114DE")]
	[FieldOffset(Offset = "0x34")]
	public GameObject VoiceGO;

	[Token(Token = "0x40114DF")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Damage;

	[Token(Token = "0x40114E0")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ReviveBtn;

	[Token(Token = "0x40114E1")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ReviveLabel;

	[Token(Token = "0x40114E2")]
	[FieldOffset(Offset = "0x44")]
	public UISprite Self;

	[Token(Token = "0x40114E3")]
	[FieldOffset(Offset = "0x48")]
	public int TeamIndexNum;

	[Token(Token = "0x40114E4")]
	[FieldOffset(Offset = "0x4C")]
	private ETeammateState m_CurrentState;

	[Token(Token = "0x40114E5")]
	[FieldOffset(Offset = "0x50")]
	private IHAAMHPPLMG m_BindPlayerID;

	[Token(Token = "0x6012EE5")]
	[Address(RVA = "0x1346998", Offset = "0x1346998", VA = "0x1346998")]
	public UIHudHyakkiTeammateItem()
	{
	}

	[Token(Token = "0x6012EE6")]
	[Address(RVA = "0x13469A0", Offset = "0x13469A0", VA = "0x13469A0")]
	public void Show(bool v)
	{
	}

	[Token(Token = "0x6012EE7")]
	[Address(RVA = "0x1346A30", Offset = "0x1346A30", VA = "0x1346A30")]
	public void InitInfo(Player p)
	{
	}

	[Token(Token = "0x6012EE8")]
	[Address(RVA = "0x1347D24", Offset = "0x1347D24", VA = "0x1347D24")]
	public void InitWithPlayerInfo(MNJIFKDNEKI playerInfo)
	{
	}

	[Token(Token = "0x6012EE9")]
	[Address(RVA = "0x13478D4", Offset = "0x13478D4", VA = "0x13478D4")]
	public void SetVoiceVisible(bool flag)
	{
	}

	[Token(Token = "0x6012EEA")]
	[Address(RVA = "0x1347C80", Offset = "0x1347C80", VA = "0x1347C80")]
	public void SetMarkShow(bool show)
	{
	}

	[Token(Token = "0x6012EEB")]
	[Address(RVA = "0x1347958", Offset = "0x1347958", VA = "0x1347958")]
	public void SetTeammateState(ETeammateState nextState)
	{
	}

	[Token(Token = "0x6012EEC")]
	[Address(RVA = "0x1347798", Offset = "0x1347798", VA = "0x1347798")]
	public void SetDisconnected(bool disconnected)
	{
	}

	[Token(Token = "0x6012EED")]
	[Address(RVA = "0x1347558", Offset = "0x1347558", VA = "0x1347558")]
	public void OnHPChanged(Player p)
	{
	}

	[Token(Token = "0x6012EEE")]
	[Address(RVA = "0x13480C8", Offset = "0x13480C8", VA = "0x13480C8")]
	private void OnReviveBtnClick()
	{
	}

	[Token(Token = "0x6012EEF")]
	[Address(RVA = "0x1348290", Offset = "0x1348290", VA = "0x1348290")]
	public void UpdateDamage(uint damage)
	{
	}

	[Token(Token = "0x6012EF0")]
	[Address(RVA = "0x1348328", Offset = "0x1348328", VA = "0x1348328")]
	private string ConvertDamageToString(uint damage)
	{
		return null;
	}

	[Token(Token = "0x6012EF1")]
	[Address(RVA = "0x13486A4", Offset = "0x13486A4", VA = "0x13486A4")]
	public void UpdateBuybackAvaliable(bool enable)
	{
	}

	[Token(Token = "0x6012EF2")]
	[Address(RVA = "0x1348730", Offset = "0x1348730", VA = "0x1348730")]
	public void UpdateCostLabel(int cost)
	{
	}

	[Token(Token = "0x6012EF3")]
	[Address(RVA = "0x13473E0", Offset = "0x13473E0", VA = "0x13473E0")]
	private bool IsLocalPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6012EF4")]
	[Address(RVA = "0x13487D4", Offset = "0x13487D4", VA = "0x13487D4")]
	public void UpdateDamageShow(bool isShow)
	{
	}
}
