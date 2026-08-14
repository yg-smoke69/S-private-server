using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034E4")]
public class UIDigitaluniverseBStarMapTargetItemView : UIBaseView
{
	[Token(Token = "0x4014C7A")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SpriteState;

	[Token(Token = "0x4014C7B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelProgress;

	[Token(Token = "0x4014C7C")]
	[FieldOffset(Offset = "0x1C")]
	public Transform Reward;

	[Token(Token = "0x4014C7D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelTargetId;

	[Token(Token = "0x4014C7E")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnClaime;

	[Token(Token = "0x601625E")]
	[Address(RVA = "0x2F1A084", Offset = "0x2F1A084", VA = "0x2F1A084")]
	public UIDigitaluniverseBStarMapTargetItemView()
	{
	}

	[Token(Token = "0x601625F")]
	[Address(RVA = "0x2F1A08C", Offset = "0x2F1A08C", VA = "0x2F1A08C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016260")]
	[Address(RVA = "0x2F1A38C", Offset = "0x2F1A38C", VA = "0x2F1A38C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
