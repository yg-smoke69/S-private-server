using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002953")]
public class UILoginRegionChooseController : UIPopupWindowController
{
	[Token(Token = "0x400FEBF")]
	[FieldOffset(Offset = "0x48")]
	private UILoginRegionChooseView m_View;

	[Token(Token = "0x400FEC0")]
	[FieldOffset(Offset = "0x4C")]
	private string m_SelectedServer;

	[Token(Token = "0x601087D")]
	[Address(RVA = "0x21F6204", Offset = "0x21F6204", VA = "0x21F6204")]
	public UILoginRegionChooseController()
	{
	}

	[Token(Token = "0x601087E")]
	[Address(RVA = "0x21F620C", Offset = "0x21F620C", VA = "0x21F620C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601087F")]
	[Address(RVA = "0x21F62B0", Offset = "0x21F62B0", VA = "0x21F62B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010880")]
	[Address(RVA = "0x21F64A0", Offset = "0x21F64A0", VA = "0x21F64A0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010881")]
	[Address(RVA = "0x21EFFB4", Offset = "0x21EFFB4", VA = "0x21EFFB4")]
	public void SetData(List<string> serverList)
	{
	}

	[Token(Token = "0x6010882")]
	[Address(RVA = "0x21F69A8", Offset = "0x21F69A8", VA = "0x21F69A8")]
	private void OnSelectServer(object[] data)
	{
	}

	[Token(Token = "0x6010883")]
	[Address(RVA = "0x21F6B24", Offset = "0x21F6B24", VA = "0x21F6B24")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x6010884")]
	[Address(RVA = "0x21F6FF0", Offset = "0x21F6FF0", VA = "0x21F6FF0")]
	private void BtnConfirm()
	{
	}

	[Token(Token = "0x6010885")]
	[Address(RVA = "0x21F7124", Offset = "0x21F7124", VA = "0x21F7124")]
	private void BtnCancel()
	{
	}

	[Token(Token = "0x6010886")]
	[Address(RVA = "0x21F7190", Offset = "0x21F7190", VA = "0x21F7190")]
	private void _003COnBtnConfirmClick_003Em__0()
	{
	}

	[Token(Token = "0x6010887")]
	[Address(RVA = "0x21F7194", Offset = "0x21F7194", VA = "0x21F7194")]
	private void _003COnBtnConfirmClick_003Em__1()
	{
	}

	[Token(Token = "0x6010888")]
	[Address(RVA = "0x21F7198", Offset = "0x21F7198", VA = "0x21F7198")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010889")]
	[Address(RVA = "0x21F71A0", Offset = "0x21F71A0", VA = "0x21F71A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
