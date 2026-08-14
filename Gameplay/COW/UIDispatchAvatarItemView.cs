using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034EC")]
public class UIDispatchAvatarItemView : UIBaseView
{
	[Token(Token = "0x4014CD8")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x4014CD9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Texture;

	[Token(Token = "0x4014CDA")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnAvatar;

	[Token(Token = "0x4014CDB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PlusIcon;

	[Token(Token = "0x4014CDC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Expired;

	[Token(Token = "0x6016274")]
	[Address(RVA = "0x275D758", Offset = "0x275D758", VA = "0x275D758")]
	public UIDispatchAvatarItemView()
	{
	}

	[Token(Token = "0x6016275")]
	[Address(RVA = "0x275D760", Offset = "0x275D760", VA = "0x275D760", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016276")]
	[Address(RVA = "0x275D9A4", Offset = "0x275D9A4", VA = "0x275D9A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
