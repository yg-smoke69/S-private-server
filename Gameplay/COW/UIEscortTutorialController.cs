using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200260D")]
public class UIEscortTutorialController : UIPopupWindowController
{
	[Token(Token = "0x400EAEA")]
	[FieldOffset(Offset = "0x48")]
	private uint m_MaxCount;

	[Token(Token = "0x400EAEB")]
	[FieldOffset(Offset = "0x4C")]
	private UIEscortTutorialView m_View;

	[Token(Token = "0x400EAEC")]
	[FieldOffset(Offset = "0x50")]
	private UICenterOnChild m_Wrap;

	[Token(Token = "0x400EAED")]
	[FieldOffset(Offset = "0x54")]
	private List<GameObject> m_DotsGo;

	[Token(Token = "0x400EAEE")]
	[FieldOffset(Offset = "0x58")]
	private List<Transform> m_ContentsGo;

	[Token(Token = "0x400EAEF")]
	[FieldOffset(Offset = "0x5C")]
	private int m_Selected;

	[Token(Token = "0x400EAF0")]
	[FieldOffset(Offset = "0x60")]
	private string[] m_GuideMessages;

	[Token(Token = "0x600E10A")]
	[Address(RVA = "0x19DB918", Offset = "0x19DB918", VA = "0x19DB918")]
	public UIEscortTutorialController()
	{
	}

	[Token(Token = "0x600E10B")]
	[Address(RVA = "0x19DB928", Offset = "0x19DB928", VA = "0x19DB928")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E10C")]
	[Address(RVA = "0x19DB9D0", Offset = "0x19DB9D0", VA = "0x19DB9D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E10D")]
	[Address(RVA = "0x19DC9A0", Offset = "0x19DC9A0", VA = "0x19DC9A0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600E10E")]
	[Address(RVA = "0x19DCA04", Offset = "0x19DCA04", VA = "0x19DCA04", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E10F")]
	[Address(RVA = "0x19DCAF8", Offset = "0x19DCAF8", VA = "0x19DCAF8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E110")]
	[Address(RVA = "0x19DCB5C", Offset = "0x19DCB5C", VA = "0x19DCB5C")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600E111")]
	[Address(RVA = "0x19DCBC0", Offset = "0x19DCBC0", VA = "0x19DCBC0")]
	private void OnLeftClick()
	{
	}

	[Token(Token = "0x600E112")]
	[Address(RVA = "0x19DCCD8", Offset = "0x19DCCD8", VA = "0x19DCCD8")]
	private void OnRightClick()
	{
	}

	[Token(Token = "0x600E113")]
	[Address(RVA = "0x19DCE00", Offset = "0x19DCE00", VA = "0x19DCE00")]
	private void getCenteredGo(GameObject centerGo)
	{
	}

	[Token(Token = "0x600E114")]
	[Address(RVA = "0x19DC7C8", Offset = "0x19DC7C8", VA = "0x19DC7C8")]
	private void UpdateShowLeftOrRight()
	{
	}

	[Token(Token = "0x600E115")]
	[Address(RVA = "0x19DC6F8", Offset = "0x19DC6F8", VA = "0x19DC6F8")]
	private void updateGuideMessage(int index)
	{
	}

	[Token(Token = "0x600E116")]
	[Address(RVA = "0x19DD010", Offset = "0x19DD010", VA = "0x19DD010")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E117")]
	[Address(RVA = "0x19DD018", Offset = "0x19DD018", VA = "0x19DD018")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600E118")]
	[Address(RVA = "0x19DD020", Offset = "0x19DD020", VA = "0x19DD020")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E119")]
	[Address(RVA = "0x19DD028", Offset = "0x19DD028", VA = "0x19DD028")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
