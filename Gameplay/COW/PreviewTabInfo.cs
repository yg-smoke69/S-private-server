using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20021DF")]
public class PreviewTabInfo
{
	[Token(Token = "0x400D3D5")]
	[FieldOffset(Offset = "0x8")]
	public UIToggleButton tb;

	[Token(Token = "0x400D3D6")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400D3D7")]
	[FieldOffset(Offset = "0x10")]
	public UIAtlas Atlas;

	[Token(Token = "0x400D3D8")]
	[FieldOffset(Offset = "0x14")]
	public string SpriteName;

	[Token(Token = "0x400D3D9")]
	[FieldOffset(Offset = "0x18")]
	public UISprite equip;

	[Token(Token = "0x400D3DA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject normal;

	[Token(Token = "0x400D3DB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite icon;

	[Token(Token = "0x400D3DC")]
	[FieldOffset(Offset = "0x24")]
	public UISprite highLight;

	[Token(Token = "0x400D3DD")]
	[FieldOffset(Offset = "0x28")]
	public UIButton unDressBtn;

	[Token(Token = "0x600B5B1")]
	[Address(RVA = "0x1962CFC", Offset = "0x1962CFC", VA = "0x1962CFC")]
	public PreviewTabInfo(UIToggleButton tb, uint id)
	{
	}
}
