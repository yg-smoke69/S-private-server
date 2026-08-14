using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038AF")]
public class UIMissionAwardItemView : UIBaseView
{
	[Token(Token = "0x4017719")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseItemInfo;

	[Token(Token = "0x6016DB8")]
	[Address(RVA = "0x13084D8", Offset = "0x13084D8", VA = "0x13084D8")]
	public UIMissionAwardItemView()
	{
	}

	[Token(Token = "0x6016DB9")]
	[Address(RVA = "0x13084E0", Offset = "0x13084E0", VA = "0x13084E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DBA")]
	[Address(RVA = "0x1308688", Offset = "0x1308688", VA = "0x1308688")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
