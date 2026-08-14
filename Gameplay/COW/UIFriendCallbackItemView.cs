using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003543")]
public class UIFriendCallbackItemView : UIBaseView
{
	[Token(Token = "0x4015150")]
	[FieldOffset(Offset = "0x14")]
	public UIButton headbtn;

	[Token(Token = "0x4015151")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture HeadIcon;

	[Token(Token = "0x4015152")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite HeadSprite;

	[Token(Token = "0x4015153")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FakeSprite;

	[Token(Token = "0x4015154")]
	[FieldOffset(Offset = "0x24")]
	public UILabel NickName;

	[Token(Token = "0x4015155")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PlatformName;

	[Token(Token = "0x4015156")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PlatformIcon;

	[Token(Token = "0x4015157")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PlatformNickNameLabel;

	[Token(Token = "0x4015158")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LastLoginTime;

	[Token(Token = "0x4015159")]
	[FieldOffset(Offset = "0x38")]
	public UISprite RequestBG;

	[Token(Token = "0x401515A")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite BigEventBG;

	[Token(Token = "0x6016379")]
	[Address(RVA = "0x24F50D0", Offset = "0x24F50D0", VA = "0x24F50D0")]
	public UIFriendCallbackItemView()
	{
	}

	[Token(Token = "0x601637A")]
	[Address(RVA = "0x24F50D8", Offset = "0x24F50D8", VA = "0x24F50D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601637B")]
	[Address(RVA = "0x24F561C", Offset = "0x24F561C", VA = "0x24F561C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
