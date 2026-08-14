using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F87")]
public class UIBigEventLobbyEntranceBaseView : MonoBehaviour
{
	[Token(Token = "0x400C5E7")]
	[FieldOffset(Offset = "0xC")]
	public UIButton BtnEntrance;

	[Token(Token = "0x400C5E8")]
	[FieldOffset(Offset = "0x10")]
	public Transform CountDownContainer;

	[Token(Token = "0x400C5E9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RedPointTip;

	[Token(Token = "0x400C5EA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Intro;

	[Token(Token = "0x400C5EB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel IntroDialog;

	[Token(Token = "0x400C5EC")]
	[FieldOffset(Offset = "0x20")]
	public Transform DownloadContainer;

	[Token(Token = "0x400C5ED")]
	[FieldOffset(Offset = "0x24")]
	public GameObject IntroConcert;

	[Token(Token = "0x6009CCA")]
	[Address(RVA = "0x3011430", Offset = "0x3011430", VA = "0x3011430")]
	public UIBigEventLobbyEntranceBaseView()
	{
	}
}
