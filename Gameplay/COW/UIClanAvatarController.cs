using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200252C")]
public class UIClanAvatarController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E674")]
	[FieldOffset(Offset = "0x48")]
	private UIClanAvatarView m_View;

	[Token(Token = "0x600D82F")]
	[Address(RVA = "0x2F21DE4", Offset = "0x2F21DE4", VA = "0x2F21DE4")]
	public UIClanAvatarController()
	{
	}

	[Token(Token = "0x600D830")]
	[Address(RVA = "0x2F21DEC", Offset = "0x2F21DEC", VA = "0x2F21DEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D831")]
	[Address(RVA = "0x2F21E94", Offset = "0x2F21E94", VA = "0x2F21E94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D832")]
	[Address(RVA = "0x2F22120", Offset = "0x2F22120", VA = "0x2F22120", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D833")]
	[Address(RVA = "0x2F22254", Offset = "0x2F22254", VA = "0x2F22254")]
	public void SetColliderMaskAlpha()
	{
	}

	[Token(Token = "0x600D834")]
	[Address(RVA = "0x2F222D4", Offset = "0x2F222D4", VA = "0x2F222D4", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D835")]
	[Address(RVA = "0x2F223CC", Offset = "0x2F223CC", VA = "0x2F223CC", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D836")]
	[Address(RVA = "0x2F22448", Offset = "0x2F22448", VA = "0x2F22448")]
	public void AvatarSelectHandler(object[] args)
	{
	}

	[Token(Token = "0x600D837")]
	[Address(RVA = "0x2F224B4", Offset = "0x2F224B4", VA = "0x2F224B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D838")]
	[Address(RVA = "0x2F224BC", Offset = "0x2F224BC", VA = "0x2F224BC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
