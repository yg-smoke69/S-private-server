using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003519")]
public class UIEPChallengeTaskView : UIBaseView
{
	[Token(Token = "0x4014F47")]
	[FieldOffset(Offset = "0x14")]
	public Transform EPDebrisInfoPos;

	[Token(Token = "0x4014F48")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4014F49")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList EasyList;

	[Token(Token = "0x60162FB")]
	[Address(RVA = "0x2BA1F48", Offset = "0x2BA1F48", VA = "0x2BA1F48")]
	public UIEPChallengeTaskView()
	{
	}

	[Token(Token = "0x60162FC")]
	[Address(RVA = "0x2BA1F50", Offset = "0x2BA1F50", VA = "0x2BA1F50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162FD")]
	[Address(RVA = "0x2BA2190", Offset = "0x2BA2190", VA = "0x2BA2190")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
