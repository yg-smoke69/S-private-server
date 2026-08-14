using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003375")]
public class AvatarSimpleSkillSlot : MonoBehaviour
{
	[Token(Token = "0x4013988")]
	[FieldOffset(Offset = "0xC")]
	public GameObject SelectedHL;

	[Token(Token = "0x4013989")]
	[FieldOffset(Offset = "0x10")]
	public UISprite SkillSprite;

	[Token(Token = "0x401398A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Empty;

	[Token(Token = "0x401398B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LockGo;

	[Token(Token = "0x6015E12")]
	[Address(RVA = "0x23594CC", Offset = "0x23594CC", VA = "0x23594CC")]
	public AvatarSimpleSkillSlot()
	{
	}

	[Token(Token = "0x6015E13")]
	[Address(RVA = "0x23594D4", Offset = "0x23594D4", VA = "0x23594D4")]
	public void SetSkillIcon(uint skillID, bool isLock = false, bool isSelected = false)
	{
	}
}
