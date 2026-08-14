using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D2")]
public class UINewVaultNormalContainerView : UIBaseView
{
	[Token(Token = "0x40178B8")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40178B9")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x40178BA")]
	[FieldOffset(Offset = "0x1C")]
	public Animation UINewVaultNormalContainer;

	[Token(Token = "0x6016E1F")]
	[Address(RVA = "0x26C8E6C", Offset = "0x26C8E6C", VA = "0x26C8E6C")]
	public UINewVaultNormalContainerView()
	{
	}

	[Token(Token = "0x6016E20")]
	[Address(RVA = "0x26C8E74", Offset = "0x26C8E74", VA = "0x26C8E74", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E21")]
	[Address(RVA = "0x26C90DC", Offset = "0x26C90DC", VA = "0x26C90DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
