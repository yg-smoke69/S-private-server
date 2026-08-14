using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002954")]
public class UILoginRegionChooseItemController : UIBaseController
{
	[Token(Token = "0x400FEC1")]
	[FieldOffset(Offset = "0x28")]
	private UILoginRegionChooseItemView m_View;

	[Token(Token = "0x400FEC2")]
	[FieldOffset(Offset = "0x2C")]
	private string m_ServerName;

	[Token(Token = "0x601088A")]
	[Address(RVA = "0x21F71A8", Offset = "0x21F71A8", VA = "0x21F71A8")]
	public UILoginRegionChooseItemController()
	{
	}

	[Token(Token = "0x601088B")]
	[Address(RVA = "0x21F722C", Offset = "0x21F722C", VA = "0x21F722C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601088C")]
	[Address(RVA = "0x21F72D0", Offset = "0x21F72D0", VA = "0x21F72D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601088D")]
	[Address(RVA = "0x21F7518", Offset = "0x21F7518", VA = "0x21F7518", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x601088E")]
	[Address(RVA = "0x21F65D4", Offset = "0x21F65D4", VA = "0x21F65D4")]
	public void SetData(string serverName)
	{
	}

	[Token(Token = "0x601088F")]
	[Address(RVA = "0x21F6838", Offset = "0x21F6838", VA = "0x21F6838")]
	public void OnBtnChooseClick()
	{
	}

	[Token(Token = "0x6010890")]
	[Address(RVA = "0x21F764C", Offset = "0x21F764C", VA = "0x21F764C")]
	private void OnSelectServer(object[] data)
	{
	}

	[Token(Token = "0x6010891")]
	[Address(RVA = "0x21F77F8", Offset = "0x21F77F8", VA = "0x21F77F8")]
	private void SetShowPickSelf(bool isSelf)
	{
	}

	[Token(Token = "0x6010892")]
	[Address(RVA = "0x21F79D4", Offset = "0x21F79D4", VA = "0x21F79D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010893")]
	[Address(RVA = "0x21F79DC", Offset = "0x21F79DC", VA = "0x21F79DC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
