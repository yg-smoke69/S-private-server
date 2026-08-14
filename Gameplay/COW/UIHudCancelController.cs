using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026FF")]
internal class UIHudCancelController : UIHudButtonBaseController
{
	[Token(Token = "0x400F0B0")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCancelView m_View;

	[Token(Token = "0x400F0B1")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_pos;

	[Token(Token = "0x600ECE1")]
	[Address(RVA = "0x21451BC", Offset = "0x21451BC", VA = "0x21451BC")]
	public UIHudCancelController()
	{
	}

	[Token(Token = "0x600ECE2")]
	[Address(RVA = "0x21451C4", Offset = "0x21451C4", VA = "0x21451C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ECE3")]
	[Address(RVA = "0x2145268", Offset = "0x2145268", VA = "0x2145268", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ECE4")]
	[Address(RVA = "0x21453EC", Offset = "0x21453EC", VA = "0x21453EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ECE5")]
	[Address(RVA = "0x2145520", Offset = "0x2145520", VA = "0x2145520")]
	private void OnChangeVisible(object[] param)
	{
	}

	[Token(Token = "0x600ECE6")]
	[Address(RVA = "0x214577C", Offset = "0x214577C", VA = "0x214577C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600ECE7")]
	[Address(RVA = "0x2145820", Offset = "0x2145820", VA = "0x2145820")]
	public void SetDefaultPos(Vector3 pos)
	{
	}

	[Token(Token = "0x600ECE8")]
	[Address(RVA = "0x21458A8", Offset = "0x21458A8", VA = "0x21458A8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ECE9")]
	[Address(RVA = "0x21458B0", Offset = "0x21458B0", VA = "0x21458B0")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
