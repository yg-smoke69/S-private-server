using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034CF")]
public class UIDigitaluniverseBGalaxyCanvasView : UIBaseView
{
	[Token(Token = "0x4014B2C")]
	[FieldOffset(Offset = "0x14")]
	public Transform Content;

	[Token(Token = "0x4014B2D")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView CanvasScrollView;

	[Token(Token = "0x4014B2E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TestGrid;

	[Token(Token = "0x4014B2F")]
	[FieldOffset(Offset = "0x20")]
	public UIDigitaluniverseBGalaxyTrackLevelView TrackLevelView;

	[Token(Token = "0x4014B30")]
	[FieldOffset(Offset = "0x24")]
	public UIDigitaluniverseBGalaxyGroupLevelView GroupLevelView;

	[Token(Token = "0x4014B31")]
	[FieldOffset(Offset = "0x28")]
	public Transform GuideTransform;

	[Token(Token = "0x4014B32")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget GuideWidget;

	[Token(Token = "0x4014B33")]
	[FieldOffset(Offset = "0x30")]
	public BoxCollider FingerGuideCollider;

	[Token(Token = "0x4014B34")]
	[FieldOffset(Offset = "0x34")]
	public UIButton FingerGuideBtn;

	[Token(Token = "0x4014B35")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PlayerName;

	[Token(Token = "0x4014B36")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RedIcon;

	[Token(Token = "0x4014B37")]
	[FieldOffset(Offset = "0x40")]
	public UIButton Core;

	[Token(Token = "0x4014B38")]
	[FieldOffset(Offset = "0x44")]
	public GameObject SelectedVfxContainer;

	[Token(Token = "0x4014B39")]
	[FieldOffset(Offset = "0x48")]
	public GameObject LongPressVfxContainer;

	[Token(Token = "0x4014B3A")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite CoreSprite;

	[Token(Token = "0x4014B3B")]
	[FieldOffset(Offset = "0x50")]
	public TweenPosition ScaleRoot;

	[Token(Token = "0x4014B3C")]
	[FieldOffset(Offset = "0x54")]
	public Transform SelfCoreAnimationCtrl;

	[Token(Token = "0x4014B3D")]
	[FieldOffset(Offset = "0x58")]
	public BoxCollider Collider;

	[Token(Token = "0x4014B3E")]
	[FieldOffset(Offset = "0x5C")]
	public UITexture Mesh_BG_Blur;

	[Token(Token = "0x6016221")]
	[Address(RVA = "0x2F63CF8", Offset = "0x2F63CF8", VA = "0x2F63CF8")]
	public UIDigitaluniverseBGalaxyCanvasView()
	{
	}

	[Token(Token = "0x6016222")]
	[Address(RVA = "0x2F63D00", Offset = "0x2F63D00", VA = "0x2F63D00", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016223")]
	[Address(RVA = "0x2F644C0", Offset = "0x2F644C0", VA = "0x2F644C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
