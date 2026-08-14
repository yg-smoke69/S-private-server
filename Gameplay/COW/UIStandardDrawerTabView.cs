using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039EB")]
public class UIStandardDrawerTabView : UIBaseView
{
	[Token(Token = "0x4018626")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel TabPanel;

	[Token(Token = "0x4018627")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget GuideContainer;

	[Token(Token = "0x4018628")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4018629")]
	[FieldOffset(Offset = "0x20")]
	public UITable Table;

	[Token(Token = "0x401862A")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget LeftBG;

	[Token(Token = "0x401862B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DownArrow;

	[Token(Token = "0x6017167")]
	[Address(RVA = "0x2065EC8", Offset = "0x2065EC8", VA = "0x2065EC8")]
	public UIStandardDrawerTabView()
	{
	}

	[Token(Token = "0x6017168")]
	[Address(RVA = "0x2065ED0", Offset = "0x2065ED0", VA = "0x2065ED0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017169")]
	[Address(RVA = "0x206624C", Offset = "0x206624C", VA = "0x206624C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
