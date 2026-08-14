using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D34")]
internal class BaseProfileView : MonoBehaviour
{
	[Token(Token = "0x4011451")]
	[FieldOffset(Offset = "0xC")]
	public UILabel UI_Nickname;

	[Token(Token = "0x4011452")]
	[FieldOffset(Offset = "0x10")]
	public UILabel UI_ExternalName;

	[Token(Token = "0x4011453")]
	[FieldOffset(Offset = "0x14")]
	public UILabel UI_OnlineState;

	[Token(Token = "0x4011454")]
	[FieldOffset(Offset = "0x18")]
	public UILabel UI_Level;

	[Token(Token = "0x4011455")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite UI_PlatformIcon;

	[Token(Token = "0x4011456")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture UI_HeadIcon;

	[Token(Token = "0x4011457")]
	[FieldOffset(Offset = "0x24")]
	public UISprite UI_Gender;

	[Token(Token = "0x4011458")]
	[FieldOffset(Offset = "0x28")]
	public Color Online_Color;

	[Token(Token = "0x4011459")]
	[FieldOffset(Offset = "0x38")]
	public Color Offline_Color;

	[Token(Token = "0x6012E8C")]
	[Address(RVA = "0x2E658AC", Offset = "0x2E658AC", VA = "0x2E658AC")]
	public BaseProfileView()
	{
	}

	[Token(Token = "0x6012E8D")]
	[Address(RVA = "0x2E6590C", Offset = "0x2E6590C", VA = "0x2E6590C")]
	public void SetUIData(BaseProfileInfo data)
	{
	}
}
