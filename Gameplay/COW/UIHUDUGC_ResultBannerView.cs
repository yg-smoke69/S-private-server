using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037A4")]
public class UIHUDUGC_ResultBannerView : UIBaseView
{
	[Token(Token = "0x401688D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Victory;

	[Token(Token = "0x401688E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Dogfall;

	[Token(Token = "0x401688F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Defeat;

	[Token(Token = "0x6016A97")]
	[Address(RVA = "0x2E248EC", Offset = "0x2E248EC", VA = "0x2E248EC")]
	public UIHUDUGC_ResultBannerView()
	{
	}

	[Token(Token = "0x6016A98")]
	[Address(RVA = "0x2E248F4", Offset = "0x2E248F4", VA = "0x2E248F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A99")]
	[Address(RVA = "0x2E24B38", Offset = "0x2E24B38", VA = "0x2E24B38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
