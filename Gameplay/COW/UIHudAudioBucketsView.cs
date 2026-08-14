using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035DB")]
public class UIHudAudioBucketsView : UIBaseView
{
	[Token(Token = "0x40158EF")]
	[FieldOffset(Offset = "0x14")]
	public Transform TemplateContainer;

	[Token(Token = "0x40158F0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject AudioInfo;

	[Token(Token = "0x40158F1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Container;

	[Token(Token = "0x40158F2")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ListGrid;

	[Token(Token = "0x40158F3")]
	[FieldOffset(Offset = "0x24")]
	public UIButton ToggleAudioDebug;

	[Token(Token = "0x601653F")]
	[Address(RVA = "0x170BD44", Offset = "0x170BD44", VA = "0x170BD44")]
	public UIHudAudioBucketsView()
	{
	}

	[Token(Token = "0x6016540")]
	[Address(RVA = "0x170BD4C", Offset = "0x170BD4C", VA = "0x170BD4C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016541")]
	[Address(RVA = "0x170C034", Offset = "0x170C034", VA = "0x170C034")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
