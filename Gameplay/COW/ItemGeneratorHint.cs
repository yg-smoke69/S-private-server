using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200226A")]
internal class ItemGeneratorHint : MonoBehaviour
{
	[Token(Token = "0x400D72E")]
	[FieldOffset(Offset = "0xC")]
	public UISprite m_Icon;

	[Token(Token = "0x400D72F")]
	[FieldOffset(Offset = "0x10")]
	public UISprite m_BgIcon;

	[Token(Token = "0x400D730")]
	private const string LIFE_SPIRE = "";

	[Token(Token = "0x400D731")]
	private const string AMMO_SPIRE = "";

	[Token(Token = "0x400D732")]
	private const string ARMOR_SPIRE = "";

	[Token(Token = "0x600BBFB")]
	[Address(RVA = "0x1EE2454", Offset = "0x1EE2454", VA = "0x1EE2454")]
	public ItemGeneratorHint()
	{
	}

	[Token(Token = "0x600BBFC")]
	[Address(RVA = "0x1EE245C", Offset = "0x1EE245C", VA = "0x1EE245C")]
	public void SetInfo(OFJHNKMJNGA objType, bool isMyTeam)
	{
	}

	[Token(Token = "0x600BBFD")]
	[Address(RVA = "0x1EE2714", Offset = "0x1EE2714", VA = "0x1EE2714")]
	public void SetInfo(OFJHNKMJNGA objType, string IconName)
	{
	}
}
