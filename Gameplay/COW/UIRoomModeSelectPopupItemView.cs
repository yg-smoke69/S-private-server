using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003967")]
public class UIRoomModeSelectPopupItemView : UIBaseView
{
	[Token(Token = "0x401808C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SelectBtn;

	[Token(Token = "0x401808D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Select;

	[Token(Token = "0x401808E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Unselect;

	[Token(Token = "0x401808F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NameTxt;

	[Token(Token = "0x6016FDC")]
	[Address(RVA = "0x23D32D8", Offset = "0x23D32D8", VA = "0x23D32D8")]
	public UIRoomModeSelectPopupItemView()
	{
	}

	[Token(Token = "0x6016FDD")]
	[Address(RVA = "0x23D32E0", Offset = "0x23D32E0", VA = "0x23D32E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FDE")]
	[Address(RVA = "0x23D3590", Offset = "0x23D3590", VA = "0x23D3590")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
