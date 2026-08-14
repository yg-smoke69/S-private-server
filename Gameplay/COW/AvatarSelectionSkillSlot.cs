using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003374")]
public class AvatarSelectionSkillSlot : MonoBehaviour
{
	[Token(Token = "0x4013983")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_SlotContainer;

	[Token(Token = "0x4013984")]
	[FieldOffset(Offset = "0x10")]
	public UISprite m_EquippedSkillIcon;

	[Token(Token = "0x4013985")]
	[FieldOffset(Offset = "0x14")]
	public UISprite m_UnEquippedIcon;

	[Token(Token = "0x4013986")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_LockSkillIcon;

	[Token(Token = "0x4013987")]
	[FieldOffset(Offset = "0x1C")]
	private Color semiColor;

	[Token(Token = "0x6015E10")]
	[Address(RVA = "0x2358FFC", Offset = "0x2358FFC", VA = "0x2358FFC")]
	public AvatarSelectionSkillSlot()
	{
	}

	[Token(Token = "0x6015E11")]
	[Address(RVA = "0x2359060", Offset = "0x2359060", VA = "0x2359060")]
	public void SetSkillIcon(uint skillID, bool isLock = false, bool semiAlphaView = false)
	{
	}
}
