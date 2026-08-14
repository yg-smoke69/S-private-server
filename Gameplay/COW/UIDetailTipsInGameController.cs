using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20025CD")]
internal class UIDetailTipsInGameController : UIPopupWindowController
{
	[Token(Token = "0x400E9CC")]
	[FieldOffset(Offset = "0x48")]
	private UIDetailTipsInGameView m_View;

	[Token(Token = "0x400E9CD")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Vector3 s_offset;

	[Token(Token = "0x400E9CE")]
	private const float m_HeightSpace = 40f;

	[Token(Token = "0x400E9CF")]
	[FieldOffset(Offset = "0x4C")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x600DE36")]
	[Address(RVA = "0x2D83600", Offset = "0x2D83600", VA = "0x2D83600")]
	public UIDetailTipsInGameController()
	{
	}

	[Token(Token = "0x600DE37")]
	[Address(RVA = "0x2D83608", Offset = "0x2D83608", VA = "0x2D83608")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DE38")]
	[Address(RVA = "0x2D836B0", Offset = "0x2D836B0", VA = "0x2D836B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DE39")]
	[Address(RVA = "0x2D8387C", Offset = "0x2D8387C", VA = "0x2D8387C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600DE3A")]
	[Address(RVA = "0x2D838E0", Offset = "0x2D838E0", VA = "0x2D838E0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DE3B")]
	[Address(RVA = "0x2D83944", Offset = "0x2D83944", VA = "0x2D83944", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DE3C")]
	[Address(RVA = "0x2D839A8", Offset = "0x2D839A8", VA = "0x2D839A8")]
	public void SetViewData(Vector3 itemPos, string description)
	{
	}

	[Token(Token = "0x600DE3D")]
	[Address(RVA = "0x2D83E30", Offset = "0x2D83E30", VA = "0x2D83E30")]
	public void SetDescriptionMaxWidth(int width)
	{
	}

	[Token(Token = "0x600DE3E")]
	[Address(RVA = "0x2D83A74", Offset = "0x2D83A74", VA = "0x2D83A74")]
	private void SetPosition(Vector3 itemPos)
	{
	}

	[Token(Token = "0x600DE3F")]
	[Address(RVA = "0x2D83EC8", Offset = "0x2D83EC8", VA = "0x2D83EC8")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x600DE41")]
	[Address(RVA = "0x2D83FCC", Offset = "0x2D83FCC", VA = "0x2D83FCC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DE42")]
	[Address(RVA = "0x2D83FD4", Offset = "0x2D83FD4", VA = "0x2D83FD4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600DE43")]
	[Address(RVA = "0x2D83FDC", Offset = "0x2D83FDC", VA = "0x2D83FDC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600DE44")]
	[Address(RVA = "0x2D83FE4", Offset = "0x2D83FE4", VA = "0x2D83FE4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
