using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EAA")]
public class UIDigitaluniverseBAwardItemView : MonoBehaviour
{
	[Token(Token = "0x400C0E5")]
	[FieldOffset(Offset = "0xC")]
	public UILabel ItemLabel;

	[Token(Token = "0x400C0E6")]
	[FieldOffset(Offset = "0x10")]
	public GameObject VFXNormal;

	[Token(Token = "0x400C0E7")]
	[FieldOffset(Offset = "0x14")]
	public GameObject VFXAvailable;

	[Token(Token = "0x400C0E8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BoxReceivedContainer;

	[Token(Token = "0x400C0E9")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnClick;

	[Token(Token = "0x400C0EA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BoxAvailableContainer;

	[Token(Token = "0x400C0EB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BoxNormalContainer;

	[Token(Token = "0x400C0EC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Bubble;

	[Token(Token = "0x600945D")]
	[Address(RVA = "0x2AC49F4", Offset = "0x2AC49F4", VA = "0x2AC49F4")]
	public UIDigitaluniverseBAwardItemView()
	{
	}
}
