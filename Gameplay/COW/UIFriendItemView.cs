using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003545")]
public class UIFriendItemView : UIBaseView
{
	[Token(Token = "0x4015161")]
	[FieldOffset(Offset = "0x14")]
	public BoxCollider UIFriendItem;

	[Token(Token = "0x4015162")]
	[FieldOffset(Offset = "0x18")]
	public GameObject FriendInfoContainer;

	[Token(Token = "0x4015163")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture FriendInfoIcon;

	[Token(Token = "0x4015164")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LevelNumLabel;

	[Token(Token = "0x4015165")]
	[FieldOffset(Offset = "0x24")]
	public UILabel FriendStatLabel;

	[Token(Token = "0x4015166")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NickNameLabel;

	[Token(Token = "0x4015167")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject GameFriendProfileContainer;

	[Token(Token = "0x4015168")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ItemBtn;

	[Token(Token = "0x4015169")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AccountStatePivot_Right;

	[Token(Token = "0x401516A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel AccountState_InGame_Right;

	[Token(Token = "0x401516B")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel AccountState_Offline_Right;

	[Token(Token = "0x401516C")]
	[FieldOffset(Offset = "0x40")]
	public UILabel AccountState_Online_Right;

	[Token(Token = "0x401516D")]
	[FieldOffset(Offset = "0x44")]
	public UIButton AddBtn;

	[Token(Token = "0x401516E")]
	[FieldOffset(Offset = "0x48")]
	public UIButton SendGiftBtn;

	[Token(Token = "0x401516F")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite GiftIcon;

	[Token(Token = "0x4015170")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ChatBtn;

	[Token(Token = "0x4015171")]
	[FieldOffset(Offset = "0x54")]
	public GameObject AccountStatePivot;

	[Token(Token = "0x4015172")]
	[FieldOffset(Offset = "0x58")]
	public UILabel AccountState_InGame;

	[Token(Token = "0x4015173")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel AccountState_InGame_Time;

	[Token(Token = "0x4015174")]
	[FieldOffset(Offset = "0x60")]
	public UILabel AccountState_Offline;

	[Token(Token = "0x4015175")]
	[FieldOffset(Offset = "0x64")]
	public UILabel AccountState_Online;

	[Token(Token = "0x4015176")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Add_Tag;

	[Token(Token = "0x4015177")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject TagTri;

	[Token(Token = "0x4015178")]
	[FieldOffset(Offset = "0x70")]
	public GameObject TagTriPos_0;

	[Token(Token = "0x4015179")]
	[FieldOffset(Offset = "0x74")]
	public UISprite TagTri_BG_0;

	[Token(Token = "0x401517A")]
	[FieldOffset(Offset = "0x78")]
	public UILabel TagTri_Label_0;

	[Token(Token = "0x401517B")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject TagTriPos_1;

	[Token(Token = "0x401517C")]
	[FieldOffset(Offset = "0x80")]
	public UISprite TagTri_BG_1;

	[Token(Token = "0x401517D")]
	[FieldOffset(Offset = "0x84")]
	public UILabel TagTri_Label_1;

	[Token(Token = "0x401517E")]
	[FieldOffset(Offset = "0x88")]
	public GameObject TagTriPos_2;

	[Token(Token = "0x401517F")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite TagTri_BG_2;

	[Token(Token = "0x4015180")]
	[FieldOffset(Offset = "0x90")]
	public UILabel TagTri_Label_2;

	[Token(Token = "0x4015181")]
	[FieldOffset(Offset = "0x94")]
	public GameObject TagDouble;

	[Token(Token = "0x4015182")]
	[FieldOffset(Offset = "0x98")]
	public GameObject TagDoublePos_0;

	[Token(Token = "0x4015183")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite TagDouble_BG_0;

	[Token(Token = "0x4015184")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel TagDouble_Label_0;

	[Token(Token = "0x4015185")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject TagDoublePos_1;

	[Token(Token = "0x4015186")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite TagDouble_BG_1;

	[Token(Token = "0x4015187")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel TagDouble_Label_1;

	[Token(Token = "0x4015188")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite ItemBg;

	[Token(Token = "0x4015189")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject PlatformInfoContainer;

	[Token(Token = "0x401518A")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject PlatformIcon;

	[Token(Token = "0x401518B")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel PlatformNickNameLabel;

	[Token(Token = "0x401518C")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject RecommendRoot;

	[Token(Token = "0x401518D")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite Gender;

	[Token(Token = "0x401518E")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite LanguageIcon;

	[Token(Token = "0x401518F")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel ModePreferLabel;

	[Token(Token = "0x4015190")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel TimeActiveLabel;

	[Token(Token = "0x4015191")]
	[FieldOffset(Offset = "0xD4")]
	public Animation main;

	[Token(Token = "0x601637F")]
	[Address(RVA = "0x25054B4", Offset = "0x25054B4", VA = "0x25054B4")]
	public UIFriendItemView()
	{
	}

	[Token(Token = "0x6016380")]
	[Address(RVA = "0x25054BC", Offset = "0x25054BC", VA = "0x25054BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016381")]
	[Address(RVA = "0x25067B0", Offset = "0x25067B0", VA = "0x25067B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
