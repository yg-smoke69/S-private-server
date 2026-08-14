using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003474")]
public class UICommonCodeInputWindowView : UIBaseView
{
	[Token(Token = "0x4014697")]
	[FieldOffset(Offset = "0x14")]
	public UILabel title;

	[Token(Token = "0x4014698")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid codeGrid;

	[Token(Token = "0x4014699")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel codeItem;

	[Token(Token = "0x401469A")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid btnGrid;

	[Token(Token = "0x401469B")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButtonGroup btnToggleGroup;

	[Token(Token = "0x401469C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject btnItem;

	[Token(Token = "0x401469D")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton CodePasteBtn;

	[Token(Token = "0x401469E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PasteIcon;

	[Token(Token = "0x401469F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PasteIconGrey;

	[Token(Token = "0x6016110")]
	[Address(RVA = "0x2CDD914", Offset = "0x2CDD914", VA = "0x2CDD914")]
	public UICommonCodeInputWindowView()
	{
	}

	[Token(Token = "0x6016111")]
	[Address(RVA = "0x2CDD91C", Offset = "0x2CDD91C", VA = "0x2CDD91C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016112")]
	[Address(RVA = "0x2CDDDA0", Offset = "0x2CDDDA0", VA = "0x2CDDDA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
