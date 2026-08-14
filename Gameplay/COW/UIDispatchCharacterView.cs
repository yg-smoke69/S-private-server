using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034EE")]
public class UIDispatchCharacterView : UIBaseView
{
	[Token(Token = "0x4014CE8")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture TitleCDN;

	[Token(Token = "0x4014CE9")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x4014CEA")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView CharacterScrollView;

	[Token(Token = "0x4014CEB")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList EasyList;

	[Token(Token = "0x4014CEC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CharacterDragArea;

	[Token(Token = "0x4014CED")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Quota;

	[Token(Token = "0x4014CEE")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton StartBtn;

	[Token(Token = "0x4014CEF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ArrowPanel;

	[Token(Token = "0x601627A")]
	[Address(RVA = "0x275DDE0", Offset = "0x275DDE0", VA = "0x275DDE0")]
	public UIDispatchCharacterView()
	{
	}

	[Token(Token = "0x601627B")]
	[Address(RVA = "0x275DDE8", Offset = "0x275DDE8", VA = "0x275DDE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601627C")]
	[Address(RVA = "0x275E130", Offset = "0x275E130", VA = "0x275E130")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
