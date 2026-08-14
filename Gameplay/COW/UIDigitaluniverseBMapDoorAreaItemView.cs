using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034D3")]
public class UIDigitaluniverseBMapDoorAreaItemView : UIBaseView
{
	[Token(Token = "0x4014B99")]
	[FieldOffset(Offset = "0x14")]
	public UISprite MapFrameTextureSelected;

	[Token(Token = "0x4014B9A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MapFrameTextureLock;

	[Token(Token = "0x4014B9B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject IconComplete;

	[Token(Token = "0x4014B9C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Mark;

	[Token(Token = "0x4014B9D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Gift;

	[Token(Token = "0x4014B9E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VFX_get;

	[Token(Token = "0x4014B9F")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite MapFrameTextureOpen;

	[Token(Token = "0x4014BA0")]
	[FieldOffset(Offset = "0x30")]
	public Transform Centre;

	[Token(Token = "0x601622D")]
	[Address(RVA = "0x2F74BF0", Offset = "0x2F74BF0", VA = "0x2F74BF0")]
	public UIDigitaluniverseBMapDoorAreaItemView()
	{
	}

	[Token(Token = "0x601622E")]
	[Address(RVA = "0x2F74BF8", Offset = "0x2F74BF8", VA = "0x2F74BF8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601622F")]
	[Address(RVA = "0x2F74FE8", Offset = "0x2F74FE8", VA = "0x2F74FE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
