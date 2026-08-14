using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027C4")]
internal class UIHudModeTipsController : UIBaseController
{
	[Token(Token = "0x400F582")]
	[FieldOffset(Offset = "0x28")]
	private UIHudModeTipsView m_View;

	[Token(Token = "0x400F583")]
	[FieldOffset(Offset = "0x2C")]
	private Camera m_Camera;

	[Token(Token = "0x400F584")]
	[FieldOffset(Offset = "0x30")]
	private UICamera m_UICamera;

	[Token(Token = "0x400F585")]
	[FieldOffset(Offset = "0x34")]
	private float dist;

	[Token(Token = "0x600F5F4")]
	[Address(RVA = "0x1F481A4", Offset = "0x1F481A4", VA = "0x1F481A4")]
	public UIHudModeTipsController()
	{
	}

	[Token(Token = "0x600F5F5")]
	[Address(RVA = "0x1F48228", Offset = "0x1F48228", VA = "0x1F48228")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F5F6")]
	[Address(RVA = "0x1F482CC", Offset = "0x1F482CC", VA = "0x1F482CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F5F7")]
	[Address(RVA = "0x1F48504", Offset = "0x1F48504", VA = "0x1F48504")]
	public void SetDesc(string key)
	{
	}

	[Token(Token = "0x600F5F8")]
	[Address(RVA = "0x1F48660", Offset = "0x1F48660", VA = "0x1F48660")]
	private void TryGetCameraComponent()
	{
	}

	[Token(Token = "0x600F5F9")]
	[Address(RVA = "0x1F487C4", Offset = "0x1F487C4", VA = "0x1F487C4")]
	private bool CheckPos(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600F5FA")]
	[Address(RVA = "0x1F48B34", Offset = "0x1F48B34", VA = "0x1F48B34")]
	private bool CheckPCTouch(Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600F5FB")]
	[Address(RVA = "0x1F48C44", Offset = "0x1F48C44", VA = "0x1F48C44")]
	private bool CheckMobileTouch()
	{
		return default(bool);
	}

	[Token(Token = "0x600F5FC")]
	[Address(RVA = "0x1F48D3C", Offset = "0x1F48D3C", VA = "0x1F48D3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600F5FD")]
	[Address(RVA = "0x1F48F8C", Offset = "0x1F48F8C", VA = "0x1F48F8C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
