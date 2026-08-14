using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034EB")]
public class UIDigitaluniverseBWarmUpView : UIBaseView
{
	[Token(Token = "0x4014CD5")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTextureExt CdnTexture;

	[Token(Token = "0x4014CD6")]
	[FieldOffset(Offset = "0x18")]
	public UICountDownLabel LabelCountDown;

	[Token(Token = "0x4014CD7")]
	[FieldOffset(Offset = "0x1C")]
	public Transform TopRightContainer;

	[Token(Token = "0x6016271")]
	[Address(RVA = "0x275ACCC", Offset = "0x275ACCC", VA = "0x275ACCC")]
	public UIDigitaluniverseBWarmUpView()
	{
	}

	[Token(Token = "0x6016272")]
	[Address(RVA = "0x275ACD4", Offset = "0x275ACD4", VA = "0x275ACD4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016273")]
	[Address(RVA = "0x275AF14", Offset = "0x275AF14", VA = "0x275AF14")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
