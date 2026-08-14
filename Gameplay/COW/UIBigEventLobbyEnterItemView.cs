using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033FD")]
public class UIBigEventLobbyEnterItemView : UIBaseView
{
	[Token(Token = "0x4014048")]
	[FieldOffset(Offset = "0x14")]
	public GameObject CheckboxForNotifyBoxContent;

	[Token(Token = "0x4014049")]
	[FieldOffset(Offset = "0x18")]
	public UIToggle CheckboxForNotify;

	[Token(Token = "0x401404A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleLabel;

	[Token(Token = "0x401404B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ActTimeLabel;

	[Token(Token = "0x401404C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite RewardIcon;

	[Token(Token = "0x401404D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite RewardIcon_bg;

	[Token(Token = "0x401404E")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton GotoBtn;

	[Token(Token = "0x401404F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BtnStateGoto;

	[Token(Token = "0x4014050")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BtnStateClose;

	[Token(Token = "0x4014051")]
	[FieldOffset(Offset = "0x38")]
	public UILabel closeLabel;

	[Token(Token = "0x4014052")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTexture CDNBg;

	[Token(Token = "0x6015FAB")]
	[Address(RVA = "0x300D8C0", Offset = "0x300D8C0", VA = "0x300D8C0")]
	public UIBigEventLobbyEnterItemView()
	{
	}

	[Token(Token = "0x6015FAC")]
	[Address(RVA = "0x300D8C8", Offset = "0x300D8C8", VA = "0x300D8C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FAD")]
	[Address(RVA = "0x300DE0C", Offset = "0x300DE0C", VA = "0x300DE0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
