using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

[Token(Token = "0x20034EA")]
public class UIDigitaluniverseBVideoView : UIBaseView
{
	[Token(Token = "0x4014CCE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SkipBtn;

	[Token(Token = "0x4014CCF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton MaskBtn;

	[Token(Token = "0x4014CD0")]
	[FieldOffset(Offset = "0x1C")]
	public VideoPlayer videoPlayer;

	[Token(Token = "0x4014CD1")]
	[FieldOffset(Offset = "0x20")]
	public UITexture videoTexture;

	[Token(Token = "0x4014CD2")]
	[FieldOffset(Offset = "0x24")]
	public AudioSource videoAudio;

	[Token(Token = "0x4014CD3")]
	[FieldOffset(Offset = "0x28")]
	public UIAnchor TopRight;

	[Token(Token = "0x4014CD4")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SkipLabel;

	[Token(Token = "0x601626E")]
	[Address(RVA = "0x275A110", Offset = "0x275A110", VA = "0x275A110")]
	public UIDigitaluniverseBVideoView()
	{
	}

	[Token(Token = "0x601626F")]
	[Address(RVA = "0x275A118", Offset = "0x275A118", VA = "0x275A118", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016270")]
	[Address(RVA = "0x275A500", Offset = "0x275A500", VA = "0x275A500")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
