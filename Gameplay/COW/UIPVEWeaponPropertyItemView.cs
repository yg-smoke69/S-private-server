using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022C8")]
public class UIPVEWeaponPropertyItemView : MonoBehaviour
{
	[Token(Token = "0x400D95D")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Description;

	[Token(Token = "0x400D95E")]
	[FieldOffset(Offset = "0x10")]
	public UILabel PropertyValue;

	[Token(Token = "0x400D95F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject DotObject;

	[Token(Token = "0x400D960")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Arrow1;

	[Token(Token = "0x400D961")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Arrow2;

	[Token(Token = "0x400D962")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Arrow3;

	[Token(Token = "0x600BF8A")]
	[Address(RVA = "0x15ADDA4", Offset = "0x15ADDA4", VA = "0x15ADDA4")]
	public UIPVEWeaponPropertyItemView()
	{
	}

	[Token(Token = "0x600BF8B")]
	[Address(RVA = "0x15AD558", Offset = "0x15AD558", VA = "0x15AD558")]
	public void SetViewData(PVEProperty propertyData, bool showDot)
	{
	}
}
