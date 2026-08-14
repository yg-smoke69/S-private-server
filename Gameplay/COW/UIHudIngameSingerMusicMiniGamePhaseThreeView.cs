using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200367A")]
public class UIHudIngameSingerMusicMiniGamePhaseThreeView : UIBaseView
{
	[Token(Token = "0x4015E20")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PhaseMusicGame;

	[Token(Token = "0x4015E21")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Timer;

	[Token(Token = "0x4015E22")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Combo;

	[Token(Token = "0x4015E23")]
	[FieldOffset(Offset = "0x20")]
	public Transform ToneParent;

	[Token(Token = "0x4015E24")]
	[FieldOffset(Offset = "0x24")]
	public Transform CompleteEffectParent;

	[Token(Token = "0x601671B")]
	[Address(RVA = "0x22A9870", Offset = "0x22A9870", VA = "0x22A9870")]
	public UIHudIngameSingerMusicMiniGamePhaseThreeView()
	{
	}

	[Token(Token = "0x601671C")]
	[Address(RVA = "0x22A9878", Offset = "0x22A9878", VA = "0x22A9878", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601671D")]
	[Address(RVA = "0x22A9B44", Offset = "0x22A9B44", VA = "0x22A9B44")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
