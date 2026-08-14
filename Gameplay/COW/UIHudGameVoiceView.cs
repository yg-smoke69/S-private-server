using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003663")]
public class UIHudGameVoiceView : UIBaseView
{
	[Token(Token = "0x4015D2B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SpeakerMuteToggle;

	[Token(Token = "0x4015D2C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpeakerNotMuteSprite;

	[Token(Token = "0x4015D2D")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpeakerMutedSprite;

	[Token(Token = "0x4015D2E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CloseSprite;

	[Token(Token = "0x4015D2F")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle MicroPhoneMuteToggle;

	[Token(Token = "0x4015D30")]
	[FieldOffset(Offset = "0x28")]
	public UISprite MicSprite;

	[Token(Token = "0x4015D31")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite MicBanSprite;

	[Token(Token = "0x4015D32")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SpriteMuteToggleBg;

	[Token(Token = "0x4015D33")]
	[FieldOffset(Offset = "0x34")]
	public GameObject TeammateVoiceTemp;

	[Token(Token = "0x4015D34")]
	[FieldOffset(Offset = "0x38")]
	public GameObject VoiceMutePanel;

	[Token(Token = "0x4015D35")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton VoicePanelMaskBtn;

	[Token(Token = "0x4015D36")]
	[FieldOffset(Offset = "0x40")]
	public UISprite MutePanelBG;

	[Token(Token = "0x4015D37")]
	[FieldOffset(Offset = "0x44")]
	public UIButton MuteAllBtn;

	[Token(Token = "0x4015D38")]
	[FieldOffset(Offset = "0x48")]
	public UISprite MutedAllSprite;

	[Token(Token = "0x4015D39")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite NotMuteAllSprite;

	[Token(Token = "0x4015D3A")]
	[FieldOffset(Offset = "0x50")]
	public Transform Line;

	[Token(Token = "0x4015D3B")]
	[FieldOffset(Offset = "0x54")]
	public GameObject TeamMateContainer;

	[Token(Token = "0x4015D3C")]
	[FieldOffset(Offset = "0x58")]
	public UISprite MuteMask;

	[Token(Token = "0x60166D6")]
	[Address(RVA = "0x18924D8", Offset = "0x18924D8", VA = "0x18924D8")]
	public UIHudGameVoiceView()
	{
	}

	[Token(Token = "0x60166D7")]
	[Address(RVA = "0x18924E0", Offset = "0x18924E0", VA = "0x18924E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166D8")]
	[Address(RVA = "0x1892C9C", Offset = "0x1892C9C", VA = "0x1892C9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
