using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002355")]
public class UISceneEditSlotInfoView : MonoBehaviour
{
	[Token(Token = "0x400DC1E")]
	[FieldOffset(Offset = "0xC")]
	public UILabel SlotNameTxt;

	[Token(Token = "0x400DC1F")]
	[FieldOffset(Offset = "0x10")]
	public UILabel AuthorTxt;

	[Token(Token = "0x400DC20")]
	[FieldOffset(Offset = "0x14")]
	public UILabel UpdateTimeTxt;

	[Token(Token = "0x400DC21")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ResourceTxt;

	[Token(Token = "0x400DC22")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CostTxt;

	[Token(Token = "0x400DC23")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ProgressFront;

	[Token(Token = "0x400DC24")]
	[FieldOffset(Offset = "0x24")]
	public UIProgressBar CostProgressBar;

	[Token(Token = "0x400DC25")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LikeTxt;

	[Token(Token = "0x400DC26")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SubscribeTxt;

	[Token(Token = "0x400DC27")]
	[FieldOffset(Offset = "0x30")]
	public UIInput DescInput;

	[Token(Token = "0x400DC28")]
	[FieldOffset(Offset = "0x34")]
	public UILabel GameModeTxt;

	[Token(Token = "0x400DC29")]
	[FieldOffset(Offset = "0x38")]
	public UILabel DescText;

	[Token(Token = "0x600C4E9")]
	[Address(RVA = "0x2DAB654", Offset = "0x2DAB654", VA = "0x2DAB654")]
	public UISceneEditSlotInfoView()
	{
	}

	[Token(Token = "0x600C4EA")]
	[Address(RVA = "0x2DAB65C", Offset = "0x2DAB65C", VA = "0x2DAB65C")]
	public void RefreshUI(SceneEditSlotInfo info)
	{
	}
}
