using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A51")]
public class UIVersionView : UIBaseView
{
	[Token(Token = "0x4018A94")]
	[FieldOffset(Offset = "0x14")]
	public UILabel VersionInfo;

	[Token(Token = "0x6017299")]
	[Address(RVA = "0x2844D90", Offset = "0x2844D90", VA = "0x2844D90")]
	public UIVersionView()
	{
	}

	[Token(Token = "0x601729A")]
	[Address(RVA = "0x2844D98", Offset = "0x2844D98", VA = "0x2844D98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601729B")]
	[Address(RVA = "0x2844F40", Offset = "0x2844F40", VA = "0x2844F40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
